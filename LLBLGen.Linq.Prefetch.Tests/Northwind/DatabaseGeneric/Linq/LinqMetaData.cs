///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET35
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using NW26;
using NW26.EntityClasses;
using NW26.FactoryClasses;
using NW26.HelperClasses;
using NW26.RelationClasses;

namespace NW26.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public partial class LinqMetaData: ILinqMetaData
	{
		#region Class Member Declarations
		private IDataAccessAdapter _adapterToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the IDataAccessAdapter object to use empty. To be able to execute the query, an IDataAccessAdapter instance
		/// is required, and has to be set on the LLBLGenProProvider2 object in the query to execute. </summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse) : this (adapterToUse, null)
		{
		}

		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse, FunctionMappingStore customFunctionMappings)
		{
			_adapterToUse = adapterToUse;
			_customFunctionMappings = customFunctionMappings;
		}
	
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			IDataSource toReturn = null;
			switch((NW26.EntityType)typeOfEntity)
			{
				case NW26.EntityType.AlphabeticalListOfProductEntity:
					toReturn = this.AlphabeticalListOfProduct;
					break;
				case NW26.EntityType.CategoryEntity:
					toReturn = this.Category;
					break;
				case NW26.EntityType.CategorySalesFor1997Entity:
					toReturn = this.CategorySalesFor1997;
					break;
				case NW26.EntityType.CurrentProductListEntity:
					toReturn = this.CurrentProductList;
					break;
				case NW26.EntityType.CustomerEntity:
					toReturn = this.Customer;
					break;
				case NW26.EntityType.CustomerAndSuppliersByCityEntity:
					toReturn = this.CustomerAndSuppliersByCity;
					break;
				case NW26.EntityType.CustomerCustomerDemoEntity:
					toReturn = this.CustomerCustomerDemo;
					break;
				case NW26.EntityType.CustomerDemographicEntity:
					toReturn = this.CustomerDemographic;
					break;
				case NW26.EntityType.EmployeeEntity:
					toReturn = this.Employee;
					break;
				case NW26.EntityType.EmployeeTerritoryEntity:
					toReturn = this.EmployeeTerritory;
					break;
				case NW26.EntityType.InvoiceEntity:
					toReturn = this.Invoice;
					break;
				case NW26.EntityType.OrderEntity:
					toReturn = this.Order;
					break;
				case NW26.EntityType.OrderDetailEntity:
					toReturn = this.OrderDetail;
					break;
				case NW26.EntityType.OrderDetailsExtendedEntity:
					toReturn = this.OrderDetailsExtended;
					break;
				case NW26.EntityType.OrdersQryEntity:
					toReturn = this.OrdersQry;
					break;
				case NW26.EntityType.OrderSubtotalEntity:
					toReturn = this.OrderSubtotal;
					break;
				case NW26.EntityType.ProductEntity:
					toReturn = this.Product;
					break;
				case NW26.EntityType.ProductsAboveAveragePriceEntity:
					toReturn = this.ProductsAboveAveragePrice;
					break;
				case NW26.EntityType.ProductSalesFor1997Entity:
					toReturn = this.ProductSalesFor1997;
					break;
				case NW26.EntityType.ProductsByCategoryEntity:
					toReturn = this.ProductsByCategory;
					break;
				case NW26.EntityType.QuarterlyOrderEntity:
					toReturn = this.QuarterlyOrder;
					break;
				case NW26.EntityType.RegionEntity:
					toReturn = this.Region;
					break;
				case NW26.EntityType.SalesByCategoryEntity:
					toReturn = this.SalesByCategory;
					break;
				case NW26.EntityType.SalesTotalsByAmountEntity:
					toReturn = this.SalesTotalsByAmount;
					break;
				case NW26.EntityType.ShipperEntity:
					toReturn = this.Shipper;
					break;
				case NW26.EntityType.SummaryOfSalesByQuarterEntity:
					toReturn = this.SummaryOfSalesByQuarter;
					break;
				case NW26.EntityType.SummaryOfSalesByYearEntity:
					toReturn = this.SummaryOfSalesByYear;
					break;
				case NW26.EntityType.SupplierEntity:
					toReturn = this.Supplier;
					break;
				case NW26.EntityType.TerritoryEntity:
					toReturn = this.Territory;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
		}

		/// <summary>returns the datasource to use in a Linq query when targeting AlphabeticalListOfProductEntity instances in the database.</summary>
		public DataSource2<AlphabeticalListOfProductEntity> AlphabeticalListOfProduct
		{
			get { return new DataSource2<AlphabeticalListOfProductEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CategoryEntity instances in the database.</summary>
		public DataSource2<CategoryEntity> Category
		{
			get { return new DataSource2<CategoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CategorySalesFor1997Entity instances in the database.</summary>
		public DataSource2<CategorySalesFor1997Entity> CategorySalesFor1997
		{
			get { return new DataSource2<CategorySalesFor1997Entity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CurrentProductListEntity instances in the database.</summary>
		public DataSource2<CurrentProductListEntity> CurrentProductList
		{
			get { return new DataSource2<CurrentProductListEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerEntity instances in the database.</summary>
		public DataSource2<CustomerEntity> Customer
		{
			get { return new DataSource2<CustomerEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerAndSuppliersByCityEntity instances in the database.</summary>
		public DataSource2<CustomerAndSuppliersByCityEntity> CustomerAndSuppliersByCity
		{
			get { return new DataSource2<CustomerAndSuppliersByCityEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerCustomerDemoEntity instances in the database.</summary>
		public DataSource2<CustomerCustomerDemoEntity> CustomerCustomerDemo
		{
			get { return new DataSource2<CustomerCustomerDemoEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerDemographicEntity instances in the database.</summary>
		public DataSource2<CustomerDemographicEntity> CustomerDemographic
		{
			get { return new DataSource2<CustomerDemographicEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeEntity instances in the database.</summary>
		public DataSource2<EmployeeEntity> Employee
		{
			get { return new DataSource2<EmployeeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeTerritoryEntity instances in the database.</summary>
		public DataSource2<EmployeeTerritoryEntity> EmployeeTerritory
		{
			get { return new DataSource2<EmployeeTerritoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting InvoiceEntity instances in the database.</summary>
		public DataSource2<InvoiceEntity> Invoice
		{
			get { return new DataSource2<InvoiceEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting OrderEntity instances in the database.</summary>
		public DataSource2<OrderEntity> Order
		{
			get { return new DataSource2<OrderEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting OrderDetailEntity instances in the database.</summary>
		public DataSource2<OrderDetailEntity> OrderDetail
		{
			get { return new DataSource2<OrderDetailEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting OrderDetailsExtendedEntity instances in the database.</summary>
		public DataSource2<OrderDetailsExtendedEntity> OrderDetailsExtended
		{
			get { return new DataSource2<OrderDetailsExtendedEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting OrdersQryEntity instances in the database.</summary>
		public DataSource2<OrdersQryEntity> OrdersQry
		{
			get { return new DataSource2<OrdersQryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting OrderSubtotalEntity instances in the database.</summary>
		public DataSource2<OrderSubtotalEntity> OrderSubtotal
		{
			get { return new DataSource2<OrderSubtotalEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductEntity instances in the database.</summary>
		public DataSource2<ProductEntity> Product
		{
			get { return new DataSource2<ProductEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductsAboveAveragePriceEntity instances in the database.</summary>
		public DataSource2<ProductsAboveAveragePriceEntity> ProductsAboveAveragePrice
		{
			get { return new DataSource2<ProductsAboveAveragePriceEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductSalesFor1997Entity instances in the database.</summary>
		public DataSource2<ProductSalesFor1997Entity> ProductSalesFor1997
		{
			get { return new DataSource2<ProductSalesFor1997Entity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductsByCategoryEntity instances in the database.</summary>
		public DataSource2<ProductsByCategoryEntity> ProductsByCategory
		{
			get { return new DataSource2<ProductsByCategoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting QuarterlyOrderEntity instances in the database.</summary>
		public DataSource2<QuarterlyOrderEntity> QuarterlyOrder
		{
			get { return new DataSource2<QuarterlyOrderEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting RegionEntity instances in the database.</summary>
		public DataSource2<RegionEntity> Region
		{
			get { return new DataSource2<RegionEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesByCategoryEntity instances in the database.</summary>
		public DataSource2<SalesByCategoryEntity> SalesByCategory
		{
			get { return new DataSource2<SalesByCategoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesTotalsByAmountEntity instances in the database.</summary>
		public DataSource2<SalesTotalsByAmountEntity> SalesTotalsByAmount
		{
			get { return new DataSource2<SalesTotalsByAmountEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ShipperEntity instances in the database.</summary>
		public DataSource2<ShipperEntity> Shipper
		{
			get { return new DataSource2<ShipperEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SummaryOfSalesByQuarterEntity instances in the database.</summary>
		public DataSource2<SummaryOfSalesByQuarterEntity> SummaryOfSalesByQuarter
		{
			get { return new DataSource2<SummaryOfSalesByQuarterEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SummaryOfSalesByYearEntity instances in the database.</summary>
		public DataSource2<SummaryOfSalesByYearEntity> SummaryOfSalesByYear
		{
			get { return new DataSource2<SummaryOfSalesByYearEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SupplierEntity instances in the database.</summary>
		public DataSource2<SupplierEntity> Supplier
		{
			get { return new DataSource2<SupplierEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting TerritoryEntity instances in the database.</summary>
		public DataSource2<TerritoryEntity> Territory
		{
			get { return new DataSource2<TerritoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		
		#region Class Property Declarations
		/// <summary> Gets / sets the IDataAccessAdapter to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public IDataAccessAdapter AdapterToUse
		{
			get { return _adapterToUse;}
			set { _adapterToUse = value;}
		}

		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings
		{
			get { return _customFunctionMappings; }
			set { _customFunctionMappings = value; }
		}
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse
		{
			get { return _contextToUse;}
			set { _contextToUse = value;}
		}
		#endregion
	}
}
