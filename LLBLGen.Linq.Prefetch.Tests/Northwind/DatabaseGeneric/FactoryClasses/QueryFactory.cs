﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET35
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using NW26.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;

namespace NW26.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory
	{
		private int _aliasCounter = 0;

		/// <summary>Creates a new DynamicQuery instance with no alias set.</summary>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create()
		{
			return Create(string.Empty);
		}

		/// <summary>Creates a new DynamicQuery instance with the alias specified as the alias set.</summary>
		/// <param name="alias">The alias.</param>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create(string alias)
		{
			return new DynamicQuery(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}
	
		/// <summary>Creates a new EntityQuery for the entity of the type specified with no alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>()
			where TEntity : IEntityCore
		{
			return Create<TEntity>(string.Empty);
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with the alias specified as the alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <param name="alias">The alias.</param>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>(string alias)
			where TEntity : IEntityCore
		{
			return new EntityQuery<TEntity>(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}
				
		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field(string fieldName)
		{
			return Field<object>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field(string targetAlias, string fieldName)
		{
			return Field<object>(targetAlias, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value represented by the field.</typeparam>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field<TValue>(string fieldName)
		{
			return Field<TValue>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value.</typeparam>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field<TValue>(string targetAlias, string fieldName)
		{
			return new EntityField2(fieldName, targetAlias, typeof(TValue));
		}
		
		/// <summary>Gets the next alias counter value to produce artifical aliases with</summary>
		private int GetNextAliasCounterValue()
		{
			_aliasCounter++;
			return _aliasCounter;
		}
		
		/// <summary>Creates and returns a new EntityQuery for the AlphabeticalListOfProduct entity</summary>
		public EntityQuery<AlphabeticalListOfProductEntity> AlphabeticalListOfProduct
		{
			get { return Create<AlphabeticalListOfProductEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Category entity</summary>
		public EntityQuery<CategoryEntity> Category
		{
			get { return Create<CategoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CategorySalesFor1997 entity</summary>
		public EntityQuery<CategorySalesFor1997Entity> CategorySalesFor1997
		{
			get { return Create<CategorySalesFor1997Entity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CurrentProductList entity</summary>
		public EntityQuery<CurrentProductListEntity> CurrentProductList
		{
			get { return Create<CurrentProductListEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Customer entity</summary>
		public EntityQuery<CustomerEntity> Customer
		{
			get { return Create<CustomerEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CustomerAndSuppliersByCity entity</summary>
		public EntityQuery<CustomerAndSuppliersByCityEntity> CustomerAndSuppliersByCity
		{
			get { return Create<CustomerAndSuppliersByCityEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CustomerCustomerDemo entity</summary>
		public EntityQuery<CustomerCustomerDemoEntity> CustomerCustomerDemo
		{
			get { return Create<CustomerCustomerDemoEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CustomerDemographic entity</summary>
		public EntityQuery<CustomerDemographicEntity> CustomerDemographic
		{
			get { return Create<CustomerDemographicEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Employee entity</summary>
		public EntityQuery<EmployeeEntity> Employee
		{
			get { return Create<EmployeeEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the EmployeeTerritory entity</summary>
		public EntityQuery<EmployeeTerritoryEntity> EmployeeTerritory
		{
			get { return Create<EmployeeTerritoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Invoice entity</summary>
		public EntityQuery<InvoiceEntity> Invoice
		{
			get { return Create<InvoiceEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Order entity</summary>
		public EntityQuery<OrderEntity> Order
		{
			get { return Create<OrderEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the OrderDetail entity</summary>
		public EntityQuery<OrderDetailEntity> OrderDetail
		{
			get { return Create<OrderDetailEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the OrderDetailsExtended entity</summary>
		public EntityQuery<OrderDetailsExtendedEntity> OrderDetailsExtended
		{
			get { return Create<OrderDetailsExtendedEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the OrdersQry entity</summary>
		public EntityQuery<OrdersQryEntity> OrdersQry
		{
			get { return Create<OrdersQryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the OrderSubtotal entity</summary>
		public EntityQuery<OrderSubtotalEntity> OrderSubtotal
		{
			get { return Create<OrderSubtotalEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Product entity</summary>
		public EntityQuery<ProductEntity> Product
		{
			get { return Create<ProductEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ProductsAboveAveragePrice entity</summary>
		public EntityQuery<ProductsAboveAveragePriceEntity> ProductsAboveAveragePrice
		{
			get { return Create<ProductsAboveAveragePriceEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ProductSalesFor1997 entity</summary>
		public EntityQuery<ProductSalesFor1997Entity> ProductSalesFor1997
		{
			get { return Create<ProductSalesFor1997Entity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ProductsByCategory entity</summary>
		public EntityQuery<ProductsByCategoryEntity> ProductsByCategory
		{
			get { return Create<ProductsByCategoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the QuarterlyOrder entity</summary>
		public EntityQuery<QuarterlyOrderEntity> QuarterlyOrder
		{
			get { return Create<QuarterlyOrderEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Region entity</summary>
		public EntityQuery<RegionEntity> Region
		{
			get { return Create<RegionEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SalesByCategory entity</summary>
		public EntityQuery<SalesByCategoryEntity> SalesByCategory
		{
			get { return Create<SalesByCategoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SalesTotalsByAmount entity</summary>
		public EntityQuery<SalesTotalsByAmountEntity> SalesTotalsByAmount
		{
			get { return Create<SalesTotalsByAmountEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Shipper entity</summary>
		public EntityQuery<ShipperEntity> Shipper
		{
			get { return Create<ShipperEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SummaryOfSalesByQuarter entity</summary>
		public EntityQuery<SummaryOfSalesByQuarterEntity> SummaryOfSalesByQuarter
		{
			get { return Create<SummaryOfSalesByQuarterEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SummaryOfSalesByYear entity</summary>
		public EntityQuery<SummaryOfSalesByYearEntity> SummaryOfSalesByYear
		{
			get { return Create<SummaryOfSalesByYearEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Supplier entity</summary>
		public EntityQuery<SupplierEntity> Supplier
		{
			get { return Create<SupplierEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Territory entity</summary>
		public EntityQuery<TerritoryEntity> Territory
		{
			get { return Create<TerritoryEntity>(); }
		}

	}
}
