using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.LinqSupportClasses.ExpressionClasses;
using SD.LLBLGen.Pro.LinqSupportClasses.PrefetchPathAPI;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Expression = System.Linq.Expressions.Expression;

namespace LLBLGen.Linq.Prefetch
{
    public static class PrefetchExtensions
    {
        #region Expression Tree Methods
        // these methods don't do anything really - they just provide the declarations for the expression tree syntax
        
        public static CollectionCore<TEntity> Filter<TEntity>(this CollectionCore<TEntity> collection,
                                                              Expression<Func<TEntity, Boolean>> filter)
            where TEntity : class, IEntityCore
        {
            return collection;
        }

        public static CollectionCore<TEntity> Order<TEntity>(this CollectionCore<TEntity> collection,
                                                             Expression<Func<TEntity, Object>> order)
            where TEntity : class, IEntityCore
        {
            return collection;
        }

        public static CollectionCore<TEntity> OrderDescending<TEntity>(this CollectionCore<TEntity> collection,
                                                                       Expression<Func<TEntity, Object>> order)
            where TEntity : class, IEntityCore
        {
            return collection;
        }

        public static CollectionCore<TEntity> Limit<TEntity>(this CollectionCore<TEntity> collection,
                                                             Int32 limit)
            where TEntity : class, IEntityCore
        {
            return collection;
        }

        public static CollectionCore<TEntity> Exclude<TEntity>(this CollectionCore<TEntity> collection,
                                                               params Expression<Func<TEntity, Object>>[] excludeFields)
            where TEntity : class, IEntityCore
        {
            return collection;
        }

        public static CollectionCore<TEntity> Include<TEntity>(this CollectionCore<TEntity> collection,
                                                               params Expression<Func<TEntity, Object>>[] includeFields)
            where TEntity : class, IEntityCore
        {
            return collection;
        }

        public static Object With<TEntity>(this CollectionCore<TEntity> collection,
                                           params Expression<Func<TEntity, Object>>[] prefetch)
            where TEntity : class, IEntityCore
        {
            return null;
        }

        public static TEntity Filter<TEntity>(this TEntity entity,
                                              Expression<Func<TEntity, Boolean>> filter)
            where TEntity : class, IEntityCore
        {
            return entity;
        }

        public static TEntity Exclude<TEntity>(this TEntity entity,
                                               params Expression<Func<TEntity, Object>>[] excludeFields)
            where TEntity : class, IEntityCore
        {
            return entity;
        }

        public static TEntity Include<TEntity>(this TEntity entity,
                                               params Expression<Func<TEntity, Object>>[] includeFields)
            where TEntity : class, IEntityCore
        {
            return entity;
        }

        public static Object With<TEntity>(this TEntity entity,
                                           params Expression<Func<TEntity, Object>>[] prefetch)
            where TEntity : class, IEntityCore
        {
            return null;
        }

        #endregion

        public static IQueryable<TEntity> With<TEntity>(this IQueryable<TEntity> query,
                                                        params Expression<Func<TEntity, Object>>[] prefetch)
            where TEntity : class, IEntityCore
        {
            var creator = LinqUtils.GetElementCreator(query);
            var rootEdges = GetPathEdges(prefetch, creator, typeof(TEntity)).ToArray();
            return query.WithPath(rootEdges);
        }

        private static IEnumerable<IPathEdge> GetPathEdges(IEnumerable<Expression> expressions,
                                                           IElementCreatorCore creator,
                                                           Type sourceType)
        {
            return expressions
                .Select(e => GetPathEdge(e, creator, sourceType))
                .ToArray();
        }

        private static PathEdgeNonGeneric GetPathEdge(Expression expression,
                                                      IElementCreatorCore creator,
                                                      Type sourceType)
        {
            expression = UnwrapUnaryExpression(expression);
            var lambdaExpression = expression as LambdaExpression;
            if (lambdaExpression != null)
            {
                expression = lambdaExpression.Body;
            }
            var methodCallExpression = expression as MethodCallExpression;
            if (methodCallExpression != null)
            {
                return GetPathEdge(creator, sourceType, methodCallExpression);
            }
            var memberExpression = expression as MemberExpression;
            if (memberExpression != null)
            {
                return GetPathEdge(creator, sourceType, memberExpression);
            }

            // if it gets here then something is wrong
            throw new Exception(String.Format("Cannot handle {0}", expression.GetType().Name));
        }

        private static PathEdgeNonGeneric GetPathEdge(IElementCreatorCore creator,
                                                      Type sourceType,
                                                      MethodCallExpression expression)
        {
            var pathEdge = GetPathEdge(expression.Arguments[0], creator, sourceType);
            var targetEdge = pathEdge;
            while (targetEdge.ChildEdges.Any())
                targetEdge = (PathEdgeNonGeneric)targetEdge.ChildEdges[0];

            var methodName = expression.Method.Name;
            var argumentExpression = expression.Arguments[1];

            switch (methodName)
            {
                case "With":
                {
                    AddChildEdges(creator, argumentExpression, targetEdge);
                    break;
                }
                case "Filter":
                {
                    targetEdge.FilterLambda = GetExpression<LambdaExpression>(argumentExpression);
                    break;
                }
                case "Order":
                {
                    var sortClauseExpression = new SortClauseExpression(sourceType,
                                                                        SortOperator.Ascending,
                                                                        GetExpression<LambdaExpression>(
                                                                                                        argumentExpression));
                    targetEdge.SortClauseExpressions.Add(sortClauseExpression);
                    break;
                }
                case "OrderDescending":
                {
                    var sortClauseExpression = new SortClauseExpression(sourceType,
                                                                        SortOperator.Descending,
                                                                        GetExpression<LambdaExpression>(
                                                                                                        argumentExpression));
                    targetEdge.SortClauseExpressions.Add(sortClauseExpression);
                    break;
                }
                case "Limit":
                {
                    var constantExpression = GetExpression<ConstantExpression>(argumentExpression);
                    targetEdge.Limiter = (Int32)constantExpression.Value;
                    break;
                }
                case "Include":
                {
                    HandleIncludeExcludeFields(targetEdge,
                                               creator,
                                               GetExpression<NewArrayExpression>(argumentExpression).Expressions,
                                               false);
                    break;
                }
                case "Exclude":
                {
                    HandleIncludeExcludeFields(targetEdge,
                                               creator,
                                               GetExpression<NewArrayExpression>(argumentExpression).Expressions,
                                               true);
                    break;
                }
            }
            return pathEdge;
        }

        private static void AddChildEdges(IElementCreatorCore creator,
                                          Expression childExpression,
                                          PathEdgeNonGeneric targetEdge)
        {
            var destinationType = targetEdge.EndNodeType;
            var pathEdges = GetPathEdges(childExpression, creator, destinationType);
            targetEdge.ChildEdges.AddRange(pathEdges);
        }

        private static IEnumerable<IPathEdge> GetPathEdges(Expression expression,
                                                           IElementCreatorCore creator,
                                                           Type sourceType)
        {
            var arrayExpression = GetExpression<NewArrayExpression>(expression);
            return GetPathEdges(arrayExpression.Expressions, creator, sourceType);
        }

        private static PathEdgeNonGeneric GetPathEdge(IElementCreatorCore creator,
                                                      Type sourceType,
                                                      MemberExpression expression)
        {
            var nodeType = expression.Expression.NodeType;
            var propertyName = expression.Member.Name;
            var destinationType = DetermineEntityType(expression);
            switch (nodeType)
            {
                case ExpressionType.Parameter:
                {
                    return CreatePathEdge(creator, destinationType, sourceType, propertyName);
                }
                case ExpressionType.MemberAccess:
                case ExpressionType.Call:
                {
                    var pathEdge = GetPathEdge(expression.Expression, creator, sourceType);
                    var childEdge = CreatePathEdge(creator, destinationType, pathEdge.EndNodeType, propertyName);
                    pathEdge.ChildEdges.Add(childEdge);
                    return pathEdge;
                }
            }
            throw new Exception(String.Format("Cannot Handle NodeType: {0}", nodeType));
        }

        private static PathEdgeNonGeneric CreatePathEdge(IElementCreatorCore creator,
                                                         Type destinationType,
                                                         Type sourceType,
                                                         String propertyName)
        {
            var prefetchPathElement = new PathElementCreator
                (creator,
                 destinationType,
                 sourceType,
                 propertyName)
                .CreatePrefetchElement();
            return new PathEdgeNonGeneric
            {
                EndNodeType = destinationType,
                PathElement = prefetchPathElement
            };
        }

        private static Type DetermineEntityType(Expression expression)
        {
            return typeof(IEntityCore).IsAssignableFrom(expression.Type)
                       ? expression.Type
                       : LinqUtils.DetermineEntityTypeFromEntityCollectionType(expression.Type);
        }

        private static void HandleIncludeExcludeFields(PathEdgeNonGeneric targetEdge,
                                                       IElementCreatorCore creator,
                                                       IEnumerable<Expression> expressions,
                                                       Boolean exclude)
        {
            var destinationType = targetEdge.EndNodeType;
            if (targetEdge.FieldsToExcludeInclude != null)
            {
                throw new Exception("There can only be one call to Exclude or Include in each part of the prefetch path.");
            }
            targetEdge.FieldsToExcludeInclude = new ExcludeIncludeFieldsList(exclude);
            var entity = LinqUtils.CreateEntityInstanceFromEntityType(destinationType, creator);
            var fields = expressions
                .Select(e => GetExpression<LambdaExpression>(e).Body)
                .Select(e => GetExpression<MemberExpression>(e).Member.Name)
                .Select(name => LinqUtils.GetFieldObject(entity, name));
            targetEdge.FieldsToExcludeInclude.AddRange(fields);
        }

        private static TExpression GetExpression<TExpression>(Expression expression)
            where TExpression : Expression
        {
            var result = UnwrapUnaryExpression(expression) as TExpression;
            if (result == null)
                throw new Exception(String.Format("Expected {0}", typeof(TExpression).Name));
            return result;
        }

        private static Expression UnwrapUnaryExpression(Expression expression)
        {
            var unaryExpression = expression as UnaryExpression;
            return unaryExpression != null ? unaryExpression.Operand : expression;
        }
    }
}