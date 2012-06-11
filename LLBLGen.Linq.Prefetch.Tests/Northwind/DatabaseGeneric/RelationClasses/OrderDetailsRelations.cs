///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using NW26;
using NW26.FactoryClasses;
using NW26.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NW26.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: OrderDetails. </summary>
	public partial class OrderDetailsRelations
	{
		/// <summary>CTor</summary>
		public OrderDetailsRelations()
		{
		}

		/// <summary>Gets all relations of the OrderDetailsEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.OrdersEntityUsingOrderId);
			toReturn.Add(this.ProductsEntityUsingProductId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between OrderDetailsEntity and OrdersEntity over the m:1 relation they have, using the relation between the fields:
		/// OrderDetails.OrderId - Orders.OrderId
		/// </summary>
		public virtual IEntityRelation OrdersEntityUsingOrderId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Orders", false);
				relation.AddEntityFieldPair(OrdersFields.OrderId, OrderDetailsFields.OrderId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrderDetailsEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between OrderDetailsEntity and ProductsEntity over the m:1 relation they have, using the relation between the fields:
		/// OrderDetails.ProductId - Products.ProductId
		/// </summary>
		public virtual IEntityRelation ProductsEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Products", false);
				relation.AddEntityFieldPair(ProductsFields.ProductId, OrderDetailsFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductsEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrderDetailsEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticOrderDetailsRelations
	{
		internal static readonly IEntityRelation OrdersEntityUsingOrderIdStatic = new OrderDetailsRelations().OrdersEntityUsingOrderId;
		internal static readonly IEntityRelation ProductsEntityUsingProductIdStatic = new OrderDetailsRelations().ProductsEntityUsingProductId;

		/// <summary>CTor</summary>
		static StaticOrderDetailsRelations()
		{
		}
	}
}
