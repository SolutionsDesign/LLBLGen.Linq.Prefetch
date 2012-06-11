﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Implements the relations factory for the entity: Suppliers. </summary>
	public partial class SuppliersRelations
	{
		/// <summary>CTor</summary>
		public SuppliersRelations()
		{
		}

		/// <summary>Gets all relations of the SuppliersEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductsEntityUsingSupplierId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SuppliersEntity and ProductsEntity over the 1:n relation they have, using the relation between the fields:
		/// Suppliers.SupplierId - Products.SupplierId
		/// </summary>
		public virtual IEntityRelation ProductsEntityUsingSupplierId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Products" , true);
				relation.AddEntityFieldPair(SuppliersFields.SupplierId, ProductsFields.SupplierId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SuppliersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductsEntity", false);
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
	internal static class StaticSuppliersRelations
	{
		internal static readonly IEntityRelation ProductsEntityUsingSupplierIdStatic = new SuppliersRelations().ProductsEntityUsingSupplierId;

		/// <summary>CTor</summary>
		static StaticSuppliersRelations()
		{
		}
	}
}