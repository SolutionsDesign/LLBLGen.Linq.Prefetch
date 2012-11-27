///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
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
	/// <summary>Implements the relations factory for the entity: Products. </summary>
	public partial class ProductsRelations
	{
		/// <summary>CTor</summary>
		public ProductsRelations()
		{
		}

		/// <summary>Gets all relations of the ProductsEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.OrderDetailsEntityUsingProductId);
			toReturn.Add(this.CategoriesEntityUsingCategoryId);
			toReturn.Add(this.SuppliersEntityUsingSupplierId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ProductsEntity and OrderDetailsEntity over the 1:n relation they have, using the relation between the fields:
		/// Products.ProductId - OrderDetails.ProductId
		/// </summary>
		public virtual IEntityRelation OrderDetailsEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "OrderDetails" , true);
				relation.AddEntityFieldPair(ProductsFields.ProductId, OrderDetailsFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrderDetailsEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between ProductsEntity and CategoriesEntity over the m:1 relation they have, using the relation between the fields:
		/// Products.CategoryId - Categories.CategoryId
		/// </summary>
		public virtual IEntityRelation CategoriesEntityUsingCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Categories", false);
				relation.AddEntityFieldPair(CategoriesFields.CategoryId, ProductsFields.CategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CategoriesEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductsEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ProductsEntity and SuppliersEntity over the m:1 relation they have, using the relation between the fields:
		/// Products.SupplierId - Suppliers.SupplierId
		/// </summary>
		public virtual IEntityRelation SuppliersEntityUsingSupplierId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Suppliers", false);
				relation.AddEntityFieldPair(SuppliersFields.SupplierId, ProductsFields.SupplierId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SuppliersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductsEntity", true);
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
	internal static class StaticProductsRelations
	{
		internal static readonly IEntityRelation OrderDetailsEntityUsingProductIdStatic = new ProductsRelations().OrderDetailsEntityUsingProductId;
		internal static readonly IEntityRelation CategoriesEntityUsingCategoryIdStatic = new ProductsRelations().CategoriesEntityUsingCategoryId;
		internal static readonly IEntityRelation SuppliersEntityUsingSupplierIdStatic = new ProductsRelations().SuppliersEntityUsingSupplierId;

		/// <summary>CTor</summary>
		static StaticProductsRelations()
		{
		}
	}
}
