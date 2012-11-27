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
	/// <summary>Implements the relations factory for the entity: Customers. </summary>
	public partial class CustomersRelations
	{
		/// <summary>CTor</summary>
		public CustomersRelations()
		{
		}

		/// <summary>Gets all relations of the CustomersEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CustomerCustomerDemoEntityUsingCustomerId);
			toReturn.Add(this.OrdersEntityUsingCustomerId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CustomersEntity and CustomerCustomerDemoEntity over the 1:n relation they have, using the relation between the fields:
		/// Customers.CustomerId - CustomerCustomerDemo.CustomerId
		/// </summary>
		public virtual IEntityRelation CustomerCustomerDemoEntityUsingCustomerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CustomerCustomerDemos" , true);
				relation.AddEntityFieldPair(CustomersFields.CustomerId, CustomerCustomerDemoFields.CustomerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerCustomerDemoEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CustomersEntity and OrdersEntity over the 1:n relation they have, using the relation between the fields:
		/// Customers.CustomerId - Orders.CustomerId
		/// </summary>
		public virtual IEntityRelation OrdersEntityUsingCustomerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Orders" , true);
				relation.AddEntityFieldPair(CustomersFields.CustomerId, OrdersFields.CustomerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdersEntity", false);
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
	internal static class StaticCustomersRelations
	{
		internal static readonly IEntityRelation CustomerCustomerDemoEntityUsingCustomerIdStatic = new CustomersRelations().CustomerCustomerDemoEntityUsingCustomerId;
		internal static readonly IEntityRelation OrdersEntityUsingCustomerIdStatic = new CustomersRelations().OrdersEntityUsingCustomerId;

		/// <summary>CTor</summary>
		static StaticCustomersRelations()
		{
		}
	}
}
