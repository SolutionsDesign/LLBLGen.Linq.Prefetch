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
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NW26.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass( (29 + 0));
			InitAlphabeticalListOfProductEntityInfos();
			InitCategoryEntityInfos();
			InitCategorySalesFor1997EntityInfos();
			InitCurrentProductListEntityInfos();
			InitCustomerEntityInfos();
			InitCustomerAndSuppliersByCityEntityInfos();
			InitCustomerCustomerDemoEntityInfos();
			InitCustomerDemographicEntityInfos();
			InitEmployeeEntityInfos();
			InitEmployeeTerritoryEntityInfos();
			InitInvoiceEntityInfos();
			InitOrderEntityInfos();
			InitOrderDetailEntityInfos();
			InitOrderDetailsExtendedEntityInfos();
			InitOrdersQryEntityInfos();
			InitOrderSubtotalEntityInfos();
			InitProductEntityInfos();
			InitProductsAboveAveragePriceEntityInfos();
			InitProductSalesFor1997EntityInfos();
			InitProductsByCategoryEntityInfos();
			InitQuarterlyOrderEntityInfos();
			InitRegionEntityInfos();
			InitSalesByCategoryEntityInfos();
			InitSalesTotalsByAmountEntityInfos();
			InitShipperEntityInfos();
			InitSummaryOfSalesByQuarterEntityInfos();
			InitSummaryOfSalesByYearEntityInfos();
			InitSupplierEntityInfos();
			InitTerritoryEntityInfos();

			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits AlphabeticalListOfProductEntity's FieldInfo objects</summary>
		private void InitAlphabeticalListOfProductEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AlphabeticalListOfProductFieldIndex), "AlphabeticalListOfProductEntity");
			this.AddElementFieldInfo("AlphabeticalListOfProductEntity", "CategoryId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)AlphabeticalListOfProductFieldIndex.CategoryId, 0, 0, 10);
			this.AddElementFieldInfo("AlphabeticalListOfProductEntity", "CategoryName", typeof(System.String), false, false, false, false,  (int)AlphabeticalListOfProductFieldIndex.CategoryName, 15, 0, 0);
			this.AddElementFieldInfo("AlphabeticalListOfProductEntity", "Discontinued", typeof(System.Boolean), false, false, false, false,  (int)AlphabeticalListOfProductFieldIndex.Discontinued, 0, 0, 0);
			this.AddElementFieldInfo("AlphabeticalListOfProductEntity", "ProductId", typeof(System.Int32), false, false, false, false,  (int)AlphabeticalListOfProductFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("AlphabeticalListOfProductEntity", "ProductName", typeof(System.String), false, false, false, false,  (int)AlphabeticalListOfProductFieldIndex.ProductName, 40, 0, 0);
			this.AddElementFieldInfo("AlphabeticalListOfProductEntity", "QuantityPerUnit", typeof(System.String), false, false, false, true,  (int)AlphabeticalListOfProductFieldIndex.QuantityPerUnit, 20, 0, 0);
			this.AddElementFieldInfo("AlphabeticalListOfProductEntity", "ReorderLevel", typeof(Nullable<System.Int16>), false, false, false, true,  (int)AlphabeticalListOfProductFieldIndex.ReorderLevel, 0, 0, 5);
			this.AddElementFieldInfo("AlphabeticalListOfProductEntity", "SupplierId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)AlphabeticalListOfProductFieldIndex.SupplierId, 0, 0, 10);
			this.AddElementFieldInfo("AlphabeticalListOfProductEntity", "UnitPrice", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)AlphabeticalListOfProductFieldIndex.UnitPrice, 0, 4, 19);
			this.AddElementFieldInfo("AlphabeticalListOfProductEntity", "UnitsInStock", typeof(Nullable<System.Int16>), false, false, false, true,  (int)AlphabeticalListOfProductFieldIndex.UnitsInStock, 0, 0, 5);
			this.AddElementFieldInfo("AlphabeticalListOfProductEntity", "UnitsOnOrder", typeof(Nullable<System.Int16>), false, false, false, true,  (int)AlphabeticalListOfProductFieldIndex.UnitsOnOrder, 0, 0, 5);
		}
		/// <summary>Inits CategoryEntity's FieldInfo objects</summary>
		private void InitCategoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CategoryFieldIndex), "CategoryEntity");
			this.AddElementFieldInfo("CategoryEntity", "CategoryId", typeof(System.Int32), true, false, true, false,  (int)CategoryFieldIndex.CategoryId, 0, 0, 10);
			this.AddElementFieldInfo("CategoryEntity", "CategoryName", typeof(System.String), false, false, false, false,  (int)CategoryFieldIndex.CategoryName, 15, 0, 0);
			this.AddElementFieldInfo("CategoryEntity", "Description", typeof(System.String), false, false, false, true,  (int)CategoryFieldIndex.Description, 1073741823, 0, 0);
			this.AddElementFieldInfo("CategoryEntity", "Picture", typeof(System.Byte[]), false, false, false, true,  (int)CategoryFieldIndex.Picture, 2147483647, 0, 0);
		}
		/// <summary>Inits CategorySalesFor1997Entity's FieldInfo objects</summary>
		private void InitCategorySalesFor1997EntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CategorySalesFor1997FieldIndex), "CategorySalesFor1997Entity");
			this.AddElementFieldInfo("CategorySalesFor1997Entity", "CategoryName", typeof(System.String), false, false, false, false,  (int)CategorySalesFor1997FieldIndex.CategoryName, 15, 0, 0);
			this.AddElementFieldInfo("CategorySalesFor1997Entity", "CategorySales", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)CategorySalesFor1997FieldIndex.CategorySales, 0, 4, 19);
		}
		/// <summary>Inits CurrentProductListEntity's FieldInfo objects</summary>
		private void InitCurrentProductListEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CurrentProductListFieldIndex), "CurrentProductListEntity");
			this.AddElementFieldInfo("CurrentProductListEntity", "ProductId", typeof(System.Int32), false, false, false, false,  (int)CurrentProductListFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("CurrentProductListEntity", "ProductName", typeof(System.String), false, false, false, false,  (int)CurrentProductListFieldIndex.ProductName, 40, 0, 0);
		}
		/// <summary>Inits CustomerEntity's FieldInfo objects</summary>
		private void InitCustomerEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CustomerFieldIndex), "CustomerEntity");
			this.AddElementFieldInfo("CustomerEntity", "Address", typeof(System.String), false, false, false, true,  (int)CustomerFieldIndex.Address, 60, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "City", typeof(System.String), false, false, false, true,  (int)CustomerFieldIndex.City, 15, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "CompanyName", typeof(System.String), false, false, false, false,  (int)CustomerFieldIndex.CompanyName, 40, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "ContactName", typeof(System.String), false, false, false, true,  (int)CustomerFieldIndex.ContactName, 30, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "ContactTitle", typeof(System.String), false, false, false, true,  (int)CustomerFieldIndex.ContactTitle, 30, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "Country", typeof(System.String), false, false, false, true,  (int)CustomerFieldIndex.Country, 15, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "CustomerId", typeof(System.String), true, false, false, false,  (int)CustomerFieldIndex.CustomerId, 5, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "Fax", typeof(System.String), false, false, false, true,  (int)CustomerFieldIndex.Fax, 24, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "Phone", typeof(System.String), false, false, false, true,  (int)CustomerFieldIndex.Phone, 24, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "PostalCode", typeof(System.String), false, false, false, true,  (int)CustomerFieldIndex.PostalCode, 10, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "Region", typeof(System.String), false, false, false, true,  (int)CustomerFieldIndex.Region, 15, 0, 0);
		}
		/// <summary>Inits CustomerAndSuppliersByCityEntity's FieldInfo objects</summary>
		private void InitCustomerAndSuppliersByCityEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CustomerAndSuppliersByCityFieldIndex), "CustomerAndSuppliersByCityEntity");
			this.AddElementFieldInfo("CustomerAndSuppliersByCityEntity", "City", typeof(System.String), false, false, false, true,  (int)CustomerAndSuppliersByCityFieldIndex.City, 15, 0, 0);
			this.AddElementFieldInfo("CustomerAndSuppliersByCityEntity", "CompanyName", typeof(System.String), false, false, false, false,  (int)CustomerAndSuppliersByCityFieldIndex.CompanyName, 40, 0, 0);
			this.AddElementFieldInfo("CustomerAndSuppliersByCityEntity", "ContactName", typeof(System.String), false, false, false, true,  (int)CustomerAndSuppliersByCityFieldIndex.ContactName, 30, 0, 0);
			this.AddElementFieldInfo("CustomerAndSuppliersByCityEntity", "Relationship", typeof(System.String), false, false, false, false,  (int)CustomerAndSuppliersByCityFieldIndex.Relationship, 9, 0, 0);
		}
		/// <summary>Inits CustomerCustomerDemoEntity's FieldInfo objects</summary>
		private void InitCustomerCustomerDemoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CustomerCustomerDemoFieldIndex), "CustomerCustomerDemoEntity");
			this.AddElementFieldInfo("CustomerCustomerDemoEntity", "CustomerId", typeof(System.String), true, true, false, false,  (int)CustomerCustomerDemoFieldIndex.CustomerId, 5, 0, 0);
			this.AddElementFieldInfo("CustomerCustomerDemoEntity", "CustomerTypeId", typeof(System.String), true, true, false, false,  (int)CustomerCustomerDemoFieldIndex.CustomerTypeId, 10, 0, 0);
		}
		/// <summary>Inits CustomerDemographicEntity's FieldInfo objects</summary>
		private void InitCustomerDemographicEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CustomerDemographicFieldIndex), "CustomerDemographicEntity");
			this.AddElementFieldInfo("CustomerDemographicEntity", "CustomerDesc", typeof(System.String), false, false, false, true,  (int)CustomerDemographicFieldIndex.CustomerDesc, 1073741823, 0, 0);
			this.AddElementFieldInfo("CustomerDemographicEntity", "CustomerTypeId", typeof(System.String), true, false, false, false,  (int)CustomerDemographicFieldIndex.CustomerTypeId, 10, 0, 0);
		}
		/// <summary>Inits EmployeeEntity's FieldInfo objects</summary>
		private void InitEmployeeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmployeeFieldIndex), "EmployeeEntity");
			this.AddElementFieldInfo("EmployeeEntity", "Address", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Address, 60, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "BirthDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)EmployeeFieldIndex.BirthDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "City", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.City, 15, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "Country", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Country, 15, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "EmployeeId", typeof(System.Int32), true, false, true, false,  (int)EmployeeFieldIndex.EmployeeId, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeEntity", "Extension", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Extension, 4, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.FirstName, 10, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "HireDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)EmployeeFieldIndex.HireDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "HomePhone", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.HomePhone, 24, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "LastName", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.LastName, 20, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "Notes", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Notes, 1073741823, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "Photo", typeof(System.Byte[]), false, false, false, true,  (int)EmployeeFieldIndex.Photo, 2147483647, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "PhotoPath", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.PhotoPath, 255, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "PostalCode", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.PostalCode, 10, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "Region", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Region, 15, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "ReportsTo", typeof(Nullable<System.Int32>), false, true, false, true,  (int)EmployeeFieldIndex.ReportsTo, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeEntity", "Title", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Title, 30, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "TitleOfCourtesy", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.TitleOfCourtesy, 25, 0, 0);
		}
		/// <summary>Inits EmployeeTerritoryEntity's FieldInfo objects</summary>
		private void InitEmployeeTerritoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmployeeTerritoryFieldIndex), "EmployeeTerritoryEntity");
			this.AddElementFieldInfo("EmployeeTerritoryEntity", "EmployeeId", typeof(System.Int32), true, true, false, false,  (int)EmployeeTerritoryFieldIndex.EmployeeId, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeTerritoryEntity", "TerritoryId", typeof(System.String), true, true, false, false,  (int)EmployeeTerritoryFieldIndex.TerritoryId, 20, 0, 0);
		}
		/// <summary>Inits InvoiceEntity's FieldInfo objects</summary>
		private void InitInvoiceEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(InvoiceFieldIndex), "InvoiceEntity");
			this.AddElementFieldInfo("InvoiceEntity", "Address", typeof(System.String), false, false, false, true,  (int)InvoiceFieldIndex.Address, 60, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "City", typeof(System.String), false, false, false, true,  (int)InvoiceFieldIndex.City, 15, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "Country", typeof(System.String), false, false, false, true,  (int)InvoiceFieldIndex.Country, 15, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "CustomerId", typeof(System.String), false, false, false, true,  (int)InvoiceFieldIndex.CustomerId, 5, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "CustomerName", typeof(System.String), false, false, false, false,  (int)InvoiceFieldIndex.CustomerName, 40, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "Discount", typeof(System.Single), false, false, false, false,  (int)InvoiceFieldIndex.Discount, 0, 0, 24);
			this.AddElementFieldInfo("InvoiceEntity", "ExtendedPrice", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)InvoiceFieldIndex.ExtendedPrice, 0, 4, 19);
			this.AddElementFieldInfo("InvoiceEntity", "Freight", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)InvoiceFieldIndex.Freight, 0, 4, 19);
			this.AddElementFieldInfo("InvoiceEntity", "OrderDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)InvoiceFieldIndex.OrderDate, 0, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "OrderId", typeof(System.Int32), false, false, false, false,  (int)InvoiceFieldIndex.OrderId, 0, 0, 10);
			this.AddElementFieldInfo("InvoiceEntity", "PostalCode", typeof(System.String), false, false, false, true,  (int)InvoiceFieldIndex.PostalCode, 10, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "ProductId", typeof(System.Int32), false, false, false, false,  (int)InvoiceFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("InvoiceEntity", "ProductName", typeof(System.String), false, false, false, false,  (int)InvoiceFieldIndex.ProductName, 40, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "Quantity", typeof(System.Int16), false, false, false, false,  (int)InvoiceFieldIndex.Quantity, 0, 0, 5);
			this.AddElementFieldInfo("InvoiceEntity", "Region", typeof(System.String), false, false, false, true,  (int)InvoiceFieldIndex.Region, 15, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "RequiredDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)InvoiceFieldIndex.RequiredDate, 0, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "Salesperson", typeof(System.String), false, false, false, false,  (int)InvoiceFieldIndex.Salesperson, 31, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "ShipAddress", typeof(System.String), false, false, false, true,  (int)InvoiceFieldIndex.ShipAddress, 60, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "ShipCity", typeof(System.String), false, false, false, true,  (int)InvoiceFieldIndex.ShipCity, 15, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "ShipCountry", typeof(System.String), false, false, false, true,  (int)InvoiceFieldIndex.ShipCountry, 15, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "ShipName", typeof(System.String), false, false, false, true,  (int)InvoiceFieldIndex.ShipName, 40, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "ShippedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)InvoiceFieldIndex.ShippedDate, 0, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "ShipperName", typeof(System.String), false, false, false, false,  (int)InvoiceFieldIndex.ShipperName, 40, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "ShipPostalCode", typeof(System.String), false, false, false, true,  (int)InvoiceFieldIndex.ShipPostalCode, 10, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "ShipRegion", typeof(System.String), false, false, false, true,  (int)InvoiceFieldIndex.ShipRegion, 15, 0, 0);
			this.AddElementFieldInfo("InvoiceEntity", "UnitPrice", typeof(System.Decimal), false, false, false, false,  (int)InvoiceFieldIndex.UnitPrice, 0, 4, 19);
		}
		/// <summary>Inits OrderEntity's FieldInfo objects</summary>
		private void InitOrderEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(OrderFieldIndex), "OrderEntity");
			this.AddElementFieldInfo("OrderEntity", "CustomerId", typeof(System.String), false, true, false, true,  (int)OrderFieldIndex.CustomerId, 5, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "EmployeeId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)OrderFieldIndex.EmployeeId, 0, 0, 10);
			this.AddElementFieldInfo("OrderEntity", "Freight", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)OrderFieldIndex.Freight, 0, 4, 19);
			this.AddElementFieldInfo("OrderEntity", "OrderDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)OrderFieldIndex.OrderDate, 0, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "OrderId", typeof(System.Int32), true, false, true, false,  (int)OrderFieldIndex.OrderId, 0, 0, 10);
			this.AddElementFieldInfo("OrderEntity", "RequiredDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)OrderFieldIndex.RequiredDate, 0, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "ShipAddress", typeof(System.String), false, false, false, true,  (int)OrderFieldIndex.ShipAddress, 60, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "ShipCity", typeof(System.String), false, false, false, true,  (int)OrderFieldIndex.ShipCity, 15, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "ShipCountry", typeof(System.String), false, false, false, true,  (int)OrderFieldIndex.ShipCountry, 15, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "ShipName", typeof(System.String), false, false, false, true,  (int)OrderFieldIndex.ShipName, 40, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "ShippedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)OrderFieldIndex.ShippedDate, 0, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "ShipPostalCode", typeof(System.String), false, false, false, true,  (int)OrderFieldIndex.ShipPostalCode, 10, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "ShipRegion", typeof(System.String), false, false, false, true,  (int)OrderFieldIndex.ShipRegion, 15, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "ShipVia", typeof(Nullable<System.Int32>), false, true, false, true,  (int)OrderFieldIndex.ShipVia, 0, 0, 10);
		}
		/// <summary>Inits OrderDetailEntity's FieldInfo objects</summary>
		private void InitOrderDetailEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(OrderDetailFieldIndex), "OrderDetailEntity");
			this.AddElementFieldInfo("OrderDetailEntity", "Discount", typeof(System.Single), false, false, false, false,  (int)OrderDetailFieldIndex.Discount, 0, 0, 24);
			this.AddElementFieldInfo("OrderDetailEntity", "OrderId", typeof(System.Int32), true, true, false, false,  (int)OrderDetailFieldIndex.OrderId, 0, 0, 10);
			this.AddElementFieldInfo("OrderDetailEntity", "ProductId", typeof(System.Int32), true, true, false, false,  (int)OrderDetailFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("OrderDetailEntity", "Quantity", typeof(System.Int16), false, false, false, false,  (int)OrderDetailFieldIndex.Quantity, 0, 0, 5);
			this.AddElementFieldInfo("OrderDetailEntity", "UnitPrice", typeof(System.Decimal), false, false, false, false,  (int)OrderDetailFieldIndex.UnitPrice, 0, 4, 19);
		}
		/// <summary>Inits OrderDetailsExtendedEntity's FieldInfo objects</summary>
		private void InitOrderDetailsExtendedEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(OrderDetailsExtendedFieldIndex), "OrderDetailsExtendedEntity");
			this.AddElementFieldInfo("OrderDetailsExtendedEntity", "Discount", typeof(System.Single), false, false, false, false,  (int)OrderDetailsExtendedFieldIndex.Discount, 0, 0, 24);
			this.AddElementFieldInfo("OrderDetailsExtendedEntity", "ExtendedPrice", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)OrderDetailsExtendedFieldIndex.ExtendedPrice, 0, 4, 19);
			this.AddElementFieldInfo("OrderDetailsExtendedEntity", "OrderId", typeof(System.Int32), false, false, false, false,  (int)OrderDetailsExtendedFieldIndex.OrderId, 0, 0, 10);
			this.AddElementFieldInfo("OrderDetailsExtendedEntity", "ProductId", typeof(System.Int32), false, false, false, false,  (int)OrderDetailsExtendedFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("OrderDetailsExtendedEntity", "ProductName", typeof(System.String), false, false, false, false,  (int)OrderDetailsExtendedFieldIndex.ProductName, 40, 0, 0);
			this.AddElementFieldInfo("OrderDetailsExtendedEntity", "Quantity", typeof(System.Int16), false, false, false, false,  (int)OrderDetailsExtendedFieldIndex.Quantity, 0, 0, 5);
			this.AddElementFieldInfo("OrderDetailsExtendedEntity", "UnitPrice", typeof(System.Decimal), false, false, false, false,  (int)OrderDetailsExtendedFieldIndex.UnitPrice, 0, 4, 19);
		}
		/// <summary>Inits OrdersQryEntity's FieldInfo objects</summary>
		private void InitOrdersQryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(OrdersQryFieldIndex), "OrdersQryEntity");
			this.AddElementFieldInfo("OrdersQryEntity", "Address", typeof(System.String), false, false, false, true,  (int)OrdersQryFieldIndex.Address, 60, 0, 0);
			this.AddElementFieldInfo("OrdersQryEntity", "City", typeof(System.String), false, false, false, true,  (int)OrdersQryFieldIndex.City, 15, 0, 0);
			this.AddElementFieldInfo("OrdersQryEntity", "CompanyName", typeof(System.String), false, false, false, false,  (int)OrdersQryFieldIndex.CompanyName, 40, 0, 0);
			this.AddElementFieldInfo("OrdersQryEntity", "Country", typeof(System.String), false, false, false, true,  (int)OrdersQryFieldIndex.Country, 15, 0, 0);
			this.AddElementFieldInfo("OrdersQryEntity", "CustomerId", typeof(System.String), false, false, false, true,  (int)OrdersQryFieldIndex.CustomerId, 5, 0, 0);
			this.AddElementFieldInfo("OrdersQryEntity", "EmployeeId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)OrdersQryFieldIndex.EmployeeId, 0, 0, 10);
			this.AddElementFieldInfo("OrdersQryEntity", "Freight", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)OrdersQryFieldIndex.Freight, 0, 4, 19);
			this.AddElementFieldInfo("OrdersQryEntity", "OrderDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)OrdersQryFieldIndex.OrderDate, 0, 0, 0);
			this.AddElementFieldInfo("OrdersQryEntity", "OrderId", typeof(System.Int32), false, false, false, false,  (int)OrdersQryFieldIndex.OrderId, 0, 0, 10);
			this.AddElementFieldInfo("OrdersQryEntity", "PostalCode", typeof(System.String), false, false, false, true,  (int)OrdersQryFieldIndex.PostalCode, 10, 0, 0);
			this.AddElementFieldInfo("OrdersQryEntity", "Region", typeof(System.String), false, false, false, true,  (int)OrdersQryFieldIndex.Region, 15, 0, 0);
			this.AddElementFieldInfo("OrdersQryEntity", "RequiredDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)OrdersQryFieldIndex.RequiredDate, 0, 0, 0);
			this.AddElementFieldInfo("OrdersQryEntity", "ShipAddress", typeof(System.String), false, false, false, true,  (int)OrdersQryFieldIndex.ShipAddress, 60, 0, 0);
			this.AddElementFieldInfo("OrdersQryEntity", "ShipCity", typeof(System.String), false, false, false, true,  (int)OrdersQryFieldIndex.ShipCity, 15, 0, 0);
			this.AddElementFieldInfo("OrdersQryEntity", "ShipCountry", typeof(System.String), false, false, false, true,  (int)OrdersQryFieldIndex.ShipCountry, 15, 0, 0);
			this.AddElementFieldInfo("OrdersQryEntity", "ShipName", typeof(System.String), false, false, false, true,  (int)OrdersQryFieldIndex.ShipName, 40, 0, 0);
			this.AddElementFieldInfo("OrdersQryEntity", "ShippedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)OrdersQryFieldIndex.ShippedDate, 0, 0, 0);
			this.AddElementFieldInfo("OrdersQryEntity", "ShipPostalCode", typeof(System.String), false, false, false, true,  (int)OrdersQryFieldIndex.ShipPostalCode, 10, 0, 0);
			this.AddElementFieldInfo("OrdersQryEntity", "ShipRegion", typeof(System.String), false, false, false, true,  (int)OrdersQryFieldIndex.ShipRegion, 15, 0, 0);
			this.AddElementFieldInfo("OrdersQryEntity", "ShipVia", typeof(Nullable<System.Int32>), false, false, false, true,  (int)OrdersQryFieldIndex.ShipVia, 0, 0, 10);
		}
		/// <summary>Inits OrderSubtotalEntity's FieldInfo objects</summary>
		private void InitOrderSubtotalEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(OrderSubtotalFieldIndex), "OrderSubtotalEntity");
			this.AddElementFieldInfo("OrderSubtotalEntity", "OrderId", typeof(System.Int32), false, false, false, false,  (int)OrderSubtotalFieldIndex.OrderId, 0, 0, 10);
			this.AddElementFieldInfo("OrderSubtotalEntity", "Subtotal", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)OrderSubtotalFieldIndex.Subtotal, 0, 4, 19);
		}
		/// <summary>Inits ProductEntity's FieldInfo objects</summary>
		private void InitProductEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductFieldIndex), "ProductEntity");
			this.AddElementFieldInfo("ProductEntity", "CategoryId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ProductFieldIndex.CategoryId, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "Discontinued", typeof(System.Boolean), false, false, false, false,  (int)ProductFieldIndex.Discontinued, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ProductId", typeof(System.Int32), true, false, true, false,  (int)ProductFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "ProductName", typeof(System.String), false, false, false, false,  (int)ProductFieldIndex.ProductName, 40, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "QuantityPerUnit", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.QuantityPerUnit, 20, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ReorderLevel", typeof(Nullable<System.Int16>), false, false, false, true,  (int)ProductFieldIndex.ReorderLevel, 0, 0, 5);
			this.AddElementFieldInfo("ProductEntity", "SupplierId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ProductFieldIndex.SupplierId, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "UnitPrice", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ProductFieldIndex.UnitPrice, 0, 4, 19);
			this.AddElementFieldInfo("ProductEntity", "UnitsInStock", typeof(Nullable<System.Int16>), false, false, false, true,  (int)ProductFieldIndex.UnitsInStock, 0, 0, 5);
			this.AddElementFieldInfo("ProductEntity", "UnitsOnOrder", typeof(Nullable<System.Int16>), false, false, false, true,  (int)ProductFieldIndex.UnitsOnOrder, 0, 0, 5);
		}
		/// <summary>Inits ProductsAboveAveragePriceEntity's FieldInfo objects</summary>
		private void InitProductsAboveAveragePriceEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductsAboveAveragePriceFieldIndex), "ProductsAboveAveragePriceEntity");
			this.AddElementFieldInfo("ProductsAboveAveragePriceEntity", "ProductName", typeof(System.String), false, false, false, false,  (int)ProductsAboveAveragePriceFieldIndex.ProductName, 40, 0, 0);
			this.AddElementFieldInfo("ProductsAboveAveragePriceEntity", "UnitPrice", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ProductsAboveAveragePriceFieldIndex.UnitPrice, 0, 4, 19);
		}
		/// <summary>Inits ProductSalesFor1997Entity's FieldInfo objects</summary>
		private void InitProductSalesFor1997EntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductSalesFor1997FieldIndex), "ProductSalesFor1997Entity");
			this.AddElementFieldInfo("ProductSalesFor1997Entity", "CategoryName", typeof(System.String), false, false, false, false,  (int)ProductSalesFor1997FieldIndex.CategoryName, 15, 0, 0);
			this.AddElementFieldInfo("ProductSalesFor1997Entity", "ProductName", typeof(System.String), false, false, false, false,  (int)ProductSalesFor1997FieldIndex.ProductName, 40, 0, 0);
			this.AddElementFieldInfo("ProductSalesFor1997Entity", "ProductSales", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ProductSalesFor1997FieldIndex.ProductSales, 0, 4, 19);
		}
		/// <summary>Inits ProductsByCategoryEntity's FieldInfo objects</summary>
		private void InitProductsByCategoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductsByCategoryFieldIndex), "ProductsByCategoryEntity");
			this.AddElementFieldInfo("ProductsByCategoryEntity", "CategoryName", typeof(System.String), false, false, false, false,  (int)ProductsByCategoryFieldIndex.CategoryName, 15, 0, 0);
			this.AddElementFieldInfo("ProductsByCategoryEntity", "Discontinued", typeof(System.Boolean), false, false, false, false,  (int)ProductsByCategoryFieldIndex.Discontinued, 0, 0, 0);
			this.AddElementFieldInfo("ProductsByCategoryEntity", "ProductName", typeof(System.String), false, false, false, false,  (int)ProductsByCategoryFieldIndex.ProductName, 40, 0, 0);
			this.AddElementFieldInfo("ProductsByCategoryEntity", "QuantityPerUnit", typeof(System.String), false, false, false, true,  (int)ProductsByCategoryFieldIndex.QuantityPerUnit, 20, 0, 0);
			this.AddElementFieldInfo("ProductsByCategoryEntity", "UnitsInStock", typeof(Nullable<System.Int16>), false, false, false, true,  (int)ProductsByCategoryFieldIndex.UnitsInStock, 0, 0, 5);
		}
		/// <summary>Inits QuarterlyOrderEntity's FieldInfo objects</summary>
		private void InitQuarterlyOrderEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(QuarterlyOrderFieldIndex), "QuarterlyOrderEntity");
			this.AddElementFieldInfo("QuarterlyOrderEntity", "City", typeof(System.String), false, false, false, true,  (int)QuarterlyOrderFieldIndex.City, 15, 0, 0);
			this.AddElementFieldInfo("QuarterlyOrderEntity", "CompanyName", typeof(System.String), false, false, false, true,  (int)QuarterlyOrderFieldIndex.CompanyName, 40, 0, 0);
			this.AddElementFieldInfo("QuarterlyOrderEntity", "Country", typeof(System.String), false, false, false, true,  (int)QuarterlyOrderFieldIndex.Country, 15, 0, 0);
			this.AddElementFieldInfo("QuarterlyOrderEntity", "CustomerId", typeof(System.String), false, false, false, true,  (int)QuarterlyOrderFieldIndex.CustomerId, 5, 0, 0);
		}
		/// <summary>Inits RegionEntity's FieldInfo objects</summary>
		private void InitRegionEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(RegionFieldIndex), "RegionEntity");
			this.AddElementFieldInfo("RegionEntity", "RegionDescription", typeof(System.String), false, false, false, false,  (int)RegionFieldIndex.RegionDescription, 50, 0, 0);
			this.AddElementFieldInfo("RegionEntity", "RegionId", typeof(System.Int32), true, false, false, false,  (int)RegionFieldIndex.RegionId, 0, 0, 10);
		}
		/// <summary>Inits SalesByCategoryEntity's FieldInfo objects</summary>
		private void InitSalesByCategoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesByCategoryFieldIndex), "SalesByCategoryEntity");
			this.AddElementFieldInfo("SalesByCategoryEntity", "CategoryId", typeof(System.Int32), false, false, false, false,  (int)SalesByCategoryFieldIndex.CategoryId, 0, 0, 10);
			this.AddElementFieldInfo("SalesByCategoryEntity", "CategoryName", typeof(System.String), false, false, false, false,  (int)SalesByCategoryFieldIndex.CategoryName, 15, 0, 0);
			this.AddElementFieldInfo("SalesByCategoryEntity", "ProductName", typeof(System.String), false, false, false, false,  (int)SalesByCategoryFieldIndex.ProductName, 40, 0, 0);
			this.AddElementFieldInfo("SalesByCategoryEntity", "ProductSales", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)SalesByCategoryFieldIndex.ProductSales, 0, 4, 19);
		}
		/// <summary>Inits SalesTotalsByAmountEntity's FieldInfo objects</summary>
		private void InitSalesTotalsByAmountEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesTotalsByAmountFieldIndex), "SalesTotalsByAmountEntity");
			this.AddElementFieldInfo("SalesTotalsByAmountEntity", "CompanyName", typeof(System.String), false, false, false, false,  (int)SalesTotalsByAmountFieldIndex.CompanyName, 40, 0, 0);
			this.AddElementFieldInfo("SalesTotalsByAmountEntity", "OrderId", typeof(System.Int32), false, false, false, false,  (int)SalesTotalsByAmountFieldIndex.OrderId, 0, 0, 10);
			this.AddElementFieldInfo("SalesTotalsByAmountEntity", "SaleAmount", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)SalesTotalsByAmountFieldIndex.SaleAmount, 0, 4, 19);
			this.AddElementFieldInfo("SalesTotalsByAmountEntity", "ShippedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SalesTotalsByAmountFieldIndex.ShippedDate, 0, 0, 0);
		}
		/// <summary>Inits ShipperEntity's FieldInfo objects</summary>
		private void InitShipperEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ShipperFieldIndex), "ShipperEntity");
			this.AddElementFieldInfo("ShipperEntity", "CompanyName", typeof(System.String), false, false, false, false,  (int)ShipperFieldIndex.CompanyName, 40, 0, 0);
			this.AddElementFieldInfo("ShipperEntity", "Phone", typeof(System.String), false, false, false, true,  (int)ShipperFieldIndex.Phone, 24, 0, 0);
			this.AddElementFieldInfo("ShipperEntity", "ShipperId", typeof(System.Int32), true, false, true, false,  (int)ShipperFieldIndex.ShipperId, 0, 0, 10);
		}
		/// <summary>Inits SummaryOfSalesByQuarterEntity's FieldInfo objects</summary>
		private void InitSummaryOfSalesByQuarterEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SummaryOfSalesByQuarterFieldIndex), "SummaryOfSalesByQuarterEntity");
			this.AddElementFieldInfo("SummaryOfSalesByQuarterEntity", "OrderId", typeof(System.Int32), false, false, false, false,  (int)SummaryOfSalesByQuarterFieldIndex.OrderId, 0, 0, 10);
			this.AddElementFieldInfo("SummaryOfSalesByQuarterEntity", "ShippedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SummaryOfSalesByQuarterFieldIndex.ShippedDate, 0, 0, 0);
			this.AddElementFieldInfo("SummaryOfSalesByQuarterEntity", "Subtotal", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)SummaryOfSalesByQuarterFieldIndex.Subtotal, 0, 4, 19);
		}
		/// <summary>Inits SummaryOfSalesByYearEntity's FieldInfo objects</summary>
		private void InitSummaryOfSalesByYearEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SummaryOfSalesByYearFieldIndex), "SummaryOfSalesByYearEntity");
			this.AddElementFieldInfo("SummaryOfSalesByYearEntity", "OrderId", typeof(System.Int32), false, false, false, false,  (int)SummaryOfSalesByYearFieldIndex.OrderId, 0, 0, 10);
			this.AddElementFieldInfo("SummaryOfSalesByYearEntity", "ShippedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SummaryOfSalesByYearFieldIndex.ShippedDate, 0, 0, 0);
			this.AddElementFieldInfo("SummaryOfSalesByYearEntity", "Subtotal", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)SummaryOfSalesByYearFieldIndex.Subtotal, 0, 4, 19);
		}
		/// <summary>Inits SupplierEntity's FieldInfo objects</summary>
		private void InitSupplierEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SupplierFieldIndex), "SupplierEntity");
			this.AddElementFieldInfo("SupplierEntity", "Address", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.Address, 60, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "City", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.City, 15, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "CompanyName", typeof(System.String), false, false, false, false,  (int)SupplierFieldIndex.CompanyName, 40, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "ContactName", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.ContactName, 30, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "ContactTitle", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.ContactTitle, 30, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "Country", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.Country, 15, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "Fax", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.Fax, 24, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "HomePage", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.HomePage, 1073741823, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "Phone", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.Phone, 24, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "PostalCode", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.PostalCode, 10, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "Region", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.Region, 15, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "SupplierId", typeof(System.Int32), true, false, true, false,  (int)SupplierFieldIndex.SupplierId, 0, 0, 10);
		}
		/// <summary>Inits TerritoryEntity's FieldInfo objects</summary>
		private void InitTerritoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(TerritoryFieldIndex), "TerritoryEntity");
			this.AddElementFieldInfo("TerritoryEntity", "RegionId", typeof(System.Int32), false, true, false, false,  (int)TerritoryFieldIndex.RegionId, 0, 0, 10);
			this.AddElementFieldInfo("TerritoryEntity", "TerritoryDescription", typeof(System.String), false, false, false, false,  (int)TerritoryFieldIndex.TerritoryDescription, 50, 0, 0);
			this.AddElementFieldInfo("TerritoryEntity", "TerritoryId", typeof(System.String), true, false, false, false,  (int)TerritoryFieldIndex.TerritoryId, 20, 0, 0);
		}
		
	}
}




