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
	/// <summary>Implements the relations factory for the entity: Orders. </summary>
	public partial class OrdersRelations
	{
		/// <summary>CTor</summary>
		public OrdersRelations()
		{
		}

		/// <summary>Gets all relations of the OrdersEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.OrderDetailsEntityUsingOrderId);
			toReturn.Add(this.CustomersEntityUsingCustomerId);
			toReturn.Add(this.EmployeesEntityUsingEmployeeId);
			toReturn.Add(this.ShippersEntityUsingShipVia);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between OrdersEntity and OrderDetailsEntity over the 1:n relation they have, using the relation between the fields:
		/// Orders.OrderId - OrderDetails.OrderId
		/// </summary>
		public virtual IEntityRelation OrderDetailsEntityUsingOrderId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "OrderDetails" , true);
				relation.AddEntityFieldPair(OrdersFields.OrderId, OrderDetailsFields.OrderId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdersEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrderDetailsEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between OrdersEntity and CustomersEntity over the m:1 relation they have, using the relation between the fields:
		/// Orders.CustomerId - Customers.CustomerId
		/// </summary>
		public virtual IEntityRelation CustomersEntityUsingCustomerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Customers", false);
				relation.AddEntityFieldPair(CustomersFields.CustomerId, OrdersFields.CustomerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdersEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between OrdersEntity and EmployeesEntity over the m:1 relation they have, using the relation between the fields:
		/// Orders.EmployeeId - Employees.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeesEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employees", false);
				relation.AddEntityFieldPair(EmployeesFields.EmployeeId, OrdersFields.EmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeesEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdersEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between OrdersEntity and ShippersEntity over the m:1 relation they have, using the relation between the fields:
		/// Orders.ShipVia - Shippers.ShipperId
		/// </summary>
		public virtual IEntityRelation ShippersEntityUsingShipVia
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Shippers", false);
				relation.AddEntityFieldPair(ShippersFields.ShipperId, OrdersFields.ShipVia);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ShippersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdersEntity", true);
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
	internal static class StaticOrdersRelations
	{
		internal static readonly IEntityRelation OrderDetailsEntityUsingOrderIdStatic = new OrdersRelations().OrderDetailsEntityUsingOrderId;
		internal static readonly IEntityRelation CustomersEntityUsingCustomerIdStatic = new OrdersRelations().CustomersEntityUsingCustomerId;
		internal static readonly IEntityRelation EmployeesEntityUsingEmployeeIdStatic = new OrdersRelations().EmployeesEntityUsingEmployeeId;
		internal static readonly IEntityRelation ShippersEntityUsingShipViaStatic = new OrdersRelations().ShippersEntityUsingShipVia;

		/// <summary>CTor</summary>
		static StaticOrdersRelations()
		{
		}
	}
}
