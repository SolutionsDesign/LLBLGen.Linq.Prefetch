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
using System.Collections.Generic;
using NW26.EntityClasses;
using NW26.HelperClasses;
using NW26.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NW26.FactoryClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase2<TEntity> : EntityFactoryCore2
		where TEntity : EntityBase2, IEntity2
	{
		private readonly NW26.EntityType _typeOfEntity;
		private readonly bool _isInHierarchy;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <param name="isInHierarchy">If true, the entity of this factory is in an inheritance hierarchy, false otherwise</param>
		public EntityFactoryBase2(string entityName, NW26.EntityType typeOfEntity, bool isInHierarchy) : base(entityName)
		{
			_typeOfEntity = typeOfEntity;
			_isInHierarchy = isInHierarchy;
		}
		
		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields2 object for the entity to create.</summary>
		/// <returns>Empty IEntityFields2 object.</returns>
		public override IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(_typeOfEntity);
		}
		
		/// <summary>Creates a new entity instance using the GeneralEntityFactory in the generated code, using the passed in entitytype value</summary>
		/// <param name="entityTypeValue">The entity type value of the entity to create an instance for.</param>
		/// <returns>new IEntity instance</returns>
		public override IEntity2 CreateEntityFromEntityTypeValue(int entityTypeValue)
		{
			return GeneralEntityFactory.Create((NW26.EntityType)entityTypeValue);
		}

		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <param name="objectAlias">The object alias to use for the elements in the relations.</param>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetHierarchyRelations(this.ForEntityName, objectAlias);
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public override IEntityFactory2 GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity) 
		{
			IEntityFactory2 toReturn = (IEntityFactory2)InheritanceInfoProviderSingleton.GetInstance().GetEntityFactory(this.ForEntityName, fieldValues, entityFieldStartIndexesPerEntity);
			if(toReturn == null)
			{
				toReturn = this;
			}
			return toReturn;
		}
		
		/// <summary>Gets a predicateexpression which filters on the entity with type belonging to this factory.</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <param name="objectAlias">The object alias to use for the predicate(s).</param>
		/// <returns>ready to use predicateexpression, or an empty predicate expression if the belonging entity isn't a hierarchical type.</returns>
		public override IPredicateExpression GetEntityTypeFilter(bool negate, string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter(this.ForEntityName, objectAlias, negate);
		}
						
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity which this factory belongs to.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<TEntity>(this);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields2 object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public override IEntityFields2 CreateHierarchyFields() 
		{
			return _isInHierarchy ? new EntityFields2(InheritanceInfoProviderSingleton.GetInstance().GetHierarchyFields(this.ForEntityName), InheritanceInfoProviderSingleton.GetInstance(), null) : base.CreateHierarchyFields();
		}
	}

	/// <summary>Factory to create new, empty AlphabeticalListOfProductEntity objects.</summary>
	[Serializable]
	public partial class AlphabeticalListOfProductEntityFactory : EntityFactoryBase2<AlphabeticalListOfProductEntity> {
		/// <summary>CTor</summary>
		public AlphabeticalListOfProductEntityFactory() : base("AlphabeticalListOfProductEntity", NW26.EntityType.AlphabeticalListOfProductEntity, false) { }
		
		/// <summary>Creates a new AlphabeticalListOfProductEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AlphabeticalListOfProductEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAlphabeticalListOfProductUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CategoryEntity objects.</summary>
	[Serializable]
	public partial class CategoryEntityFactory : EntityFactoryBase2<CategoryEntity> {
		/// <summary>CTor</summary>
		public CategoryEntityFactory() : base("CategoryEntity", NW26.EntityType.CategoryEntity, false) { }
		
		/// <summary>Creates a new CategoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CategoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CategorySalesFor1997Entity objects.</summary>
	[Serializable]
	public partial class CategorySalesFor1997EntityFactory : EntityFactoryBase2<CategorySalesFor1997Entity> {
		/// <summary>CTor</summary>
		public CategorySalesFor1997EntityFactory() : base("CategorySalesFor1997Entity", NW26.EntityType.CategorySalesFor1997Entity, false) { }
		
		/// <summary>Creates a new CategorySalesFor1997Entity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CategorySalesFor1997Entity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategorySalesFor1997UsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CurrentProductListEntity objects.</summary>
	[Serializable]
	public partial class CurrentProductListEntityFactory : EntityFactoryBase2<CurrentProductListEntity> {
		/// <summary>CTor</summary>
		public CurrentProductListEntityFactory() : base("CurrentProductListEntity", NW26.EntityType.CurrentProductListEntity, false) { }
		
		/// <summary>Creates a new CurrentProductListEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CurrentProductListEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCurrentProductListUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CustomerEntity objects.</summary>
	[Serializable]
	public partial class CustomerEntityFactory : EntityFactoryBase2<CustomerEntity> {
		/// <summary>CTor</summary>
		public CustomerEntityFactory() : base("CustomerEntity", NW26.EntityType.CustomerEntity, false) { }
		
		/// <summary>Creates a new CustomerEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CustomerEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomerUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CustomerAndSuppliersByCityEntity objects.</summary>
	[Serializable]
	public partial class CustomerAndSuppliersByCityEntityFactory : EntityFactoryBase2<CustomerAndSuppliersByCityEntity> {
		/// <summary>CTor</summary>
		public CustomerAndSuppliersByCityEntityFactory() : base("CustomerAndSuppliersByCityEntity", NW26.EntityType.CustomerAndSuppliersByCityEntity, false) { }
		
		/// <summary>Creates a new CustomerAndSuppliersByCityEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CustomerAndSuppliersByCityEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomerAndSuppliersByCityUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CustomerCustomerDemoEntity objects.</summary>
	[Serializable]
	public partial class CustomerCustomerDemoEntityFactory : EntityFactoryBase2<CustomerCustomerDemoEntity> {
		/// <summary>CTor</summary>
		public CustomerCustomerDemoEntityFactory() : base("CustomerCustomerDemoEntity", NW26.EntityType.CustomerCustomerDemoEntity, false) { }
		
		/// <summary>Creates a new CustomerCustomerDemoEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CustomerCustomerDemoEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomerCustomerDemoUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CustomerDemographicEntity objects.</summary>
	[Serializable]
	public partial class CustomerDemographicEntityFactory : EntityFactoryBase2<CustomerDemographicEntity> {
		/// <summary>CTor</summary>
		public CustomerDemographicEntityFactory() : base("CustomerDemographicEntity", NW26.EntityType.CustomerDemographicEntity, false) { }
		
		/// <summary>Creates a new CustomerDemographicEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CustomerDemographicEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomerDemographicUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty EmployeeEntity objects.</summary>
	[Serializable]
	public partial class EmployeeEntityFactory : EntityFactoryBase2<EmployeeEntity> {
		/// <summary>CTor</summary>
		public EmployeeEntityFactory() : base("EmployeeEntity", NW26.EntityType.EmployeeEntity, false) { }
		
		/// <summary>Creates a new EmployeeEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new EmployeeEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployeeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty EmployeeTerritoryEntity objects.</summary>
	[Serializable]
	public partial class EmployeeTerritoryEntityFactory : EntityFactoryBase2<EmployeeTerritoryEntity> {
		/// <summary>CTor</summary>
		public EmployeeTerritoryEntityFactory() : base("EmployeeTerritoryEntity", NW26.EntityType.EmployeeTerritoryEntity, false) { }
		
		/// <summary>Creates a new EmployeeTerritoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new EmployeeTerritoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployeeTerritoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty InvoiceEntity objects.</summary>
	[Serializable]
	public partial class InvoiceEntityFactory : EntityFactoryBase2<InvoiceEntity> {
		/// <summary>CTor</summary>
		public InvoiceEntityFactory() : base("InvoiceEntity", NW26.EntityType.InvoiceEntity, false) { }
		
		/// <summary>Creates a new InvoiceEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new InvoiceEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewInvoiceUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty OrderEntity objects.</summary>
	[Serializable]
	public partial class OrderEntityFactory : EntityFactoryBase2<OrderEntity> {
		/// <summary>CTor</summary>
		public OrderEntityFactory() : base("OrderEntity", NW26.EntityType.OrderEntity, false) { }
		
		/// <summary>Creates a new OrderEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new OrderEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewOrderUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty OrderDetailEntity objects.</summary>
	[Serializable]
	public partial class OrderDetailEntityFactory : EntityFactoryBase2<OrderDetailEntity> {
		/// <summary>CTor</summary>
		public OrderDetailEntityFactory() : base("OrderDetailEntity", NW26.EntityType.OrderDetailEntity, false) { }
		
		/// <summary>Creates a new OrderDetailEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new OrderDetailEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewOrderDetailUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty OrderDetailsExtendedEntity objects.</summary>
	[Serializable]
	public partial class OrderDetailsExtendedEntityFactory : EntityFactoryBase2<OrderDetailsExtendedEntity> {
		/// <summary>CTor</summary>
		public OrderDetailsExtendedEntityFactory() : base("OrderDetailsExtendedEntity", NW26.EntityType.OrderDetailsExtendedEntity, false) { }
		
		/// <summary>Creates a new OrderDetailsExtendedEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new OrderDetailsExtendedEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewOrderDetailsExtendedUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty OrdersQryEntity objects.</summary>
	[Serializable]
	public partial class OrdersQryEntityFactory : EntityFactoryBase2<OrdersQryEntity> {
		/// <summary>CTor</summary>
		public OrdersQryEntityFactory() : base("OrdersQryEntity", NW26.EntityType.OrdersQryEntity, false) { }
		
		/// <summary>Creates a new OrdersQryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new OrdersQryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewOrdersQryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty OrderSubtotalEntity objects.</summary>
	[Serializable]
	public partial class OrderSubtotalEntityFactory : EntityFactoryBase2<OrderSubtotalEntity> {
		/// <summary>CTor</summary>
		public OrderSubtotalEntityFactory() : base("OrderSubtotalEntity", NW26.EntityType.OrderSubtotalEntity, false) { }
		
		/// <summary>Creates a new OrderSubtotalEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new OrderSubtotalEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewOrderSubtotalUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductEntity objects.</summary>
	[Serializable]
	public partial class ProductEntityFactory : EntityFactoryBase2<ProductEntity> {
		/// <summary>CTor</summary>
		public ProductEntityFactory() : base("ProductEntity", NW26.EntityType.ProductEntity, false) { }
		
		/// <summary>Creates a new ProductEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductsAboveAveragePriceEntity objects.</summary>
	[Serializable]
	public partial class ProductsAboveAveragePriceEntityFactory : EntityFactoryBase2<ProductsAboveAveragePriceEntity> {
		/// <summary>CTor</summary>
		public ProductsAboveAveragePriceEntityFactory() : base("ProductsAboveAveragePriceEntity", NW26.EntityType.ProductsAboveAveragePriceEntity, false) { }
		
		/// <summary>Creates a new ProductsAboveAveragePriceEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductsAboveAveragePriceEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductsAboveAveragePriceUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductSalesFor1997Entity objects.</summary>
	[Serializable]
	public partial class ProductSalesFor1997EntityFactory : EntityFactoryBase2<ProductSalesFor1997Entity> {
		/// <summary>CTor</summary>
		public ProductSalesFor1997EntityFactory() : base("ProductSalesFor1997Entity", NW26.EntityType.ProductSalesFor1997Entity, false) { }
		
		/// <summary>Creates a new ProductSalesFor1997Entity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductSalesFor1997Entity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductSalesFor1997UsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductsByCategoryEntity objects.</summary>
	[Serializable]
	public partial class ProductsByCategoryEntityFactory : EntityFactoryBase2<ProductsByCategoryEntity> {
		/// <summary>CTor</summary>
		public ProductsByCategoryEntityFactory() : base("ProductsByCategoryEntity", NW26.EntityType.ProductsByCategoryEntity, false) { }
		
		/// <summary>Creates a new ProductsByCategoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductsByCategoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductsByCategoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty QuarterlyOrderEntity objects.</summary>
	[Serializable]
	public partial class QuarterlyOrderEntityFactory : EntityFactoryBase2<QuarterlyOrderEntity> {
		/// <summary>CTor</summary>
		public QuarterlyOrderEntityFactory() : base("QuarterlyOrderEntity", NW26.EntityType.QuarterlyOrderEntity, false) { }
		
		/// <summary>Creates a new QuarterlyOrderEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new QuarterlyOrderEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewQuarterlyOrderUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty RegionEntity objects.</summary>
	[Serializable]
	public partial class RegionEntityFactory : EntityFactoryBase2<RegionEntity> {
		/// <summary>CTor</summary>
		public RegionEntityFactory() : base("RegionEntity", NW26.EntityType.RegionEntity, false) { }
		
		/// <summary>Creates a new RegionEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new RegionEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRegionUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SalesByCategoryEntity objects.</summary>
	[Serializable]
	public partial class SalesByCategoryEntityFactory : EntityFactoryBase2<SalesByCategoryEntity> {
		/// <summary>CTor</summary>
		public SalesByCategoryEntityFactory() : base("SalesByCategoryEntity", NW26.EntityType.SalesByCategoryEntity, false) { }
		
		/// <summary>Creates a new SalesByCategoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SalesByCategoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesByCategoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SalesTotalsByAmountEntity objects.</summary>
	[Serializable]
	public partial class SalesTotalsByAmountEntityFactory : EntityFactoryBase2<SalesTotalsByAmountEntity> {
		/// <summary>CTor</summary>
		public SalesTotalsByAmountEntityFactory() : base("SalesTotalsByAmountEntity", NW26.EntityType.SalesTotalsByAmountEntity, false) { }
		
		/// <summary>Creates a new SalesTotalsByAmountEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SalesTotalsByAmountEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesTotalsByAmountUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ShipperEntity objects.</summary>
	[Serializable]
	public partial class ShipperEntityFactory : EntityFactoryBase2<ShipperEntity> {
		/// <summary>CTor</summary>
		public ShipperEntityFactory() : base("ShipperEntity", NW26.EntityType.ShipperEntity, false) { }
		
		/// <summary>Creates a new ShipperEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ShipperEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewShipperUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SummaryOfSalesByQuarterEntity objects.</summary>
	[Serializable]
	public partial class SummaryOfSalesByQuarterEntityFactory : EntityFactoryBase2<SummaryOfSalesByQuarterEntity> {
		/// <summary>CTor</summary>
		public SummaryOfSalesByQuarterEntityFactory() : base("SummaryOfSalesByQuarterEntity", NW26.EntityType.SummaryOfSalesByQuarterEntity, false) { }
		
		/// <summary>Creates a new SummaryOfSalesByQuarterEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SummaryOfSalesByQuarterEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSummaryOfSalesByQuarterUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SummaryOfSalesByYearEntity objects.</summary>
	[Serializable]
	public partial class SummaryOfSalesByYearEntityFactory : EntityFactoryBase2<SummaryOfSalesByYearEntity> {
		/// <summary>CTor</summary>
		public SummaryOfSalesByYearEntityFactory() : base("SummaryOfSalesByYearEntity", NW26.EntityType.SummaryOfSalesByYearEntity, false) { }
		
		/// <summary>Creates a new SummaryOfSalesByYearEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SummaryOfSalesByYearEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSummaryOfSalesByYearUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SupplierEntity objects.</summary>
	[Serializable]
	public partial class SupplierEntityFactory : EntityFactoryBase2<SupplierEntity> {
		/// <summary>CTor</summary>
		public SupplierEntityFactory() : base("SupplierEntity", NW26.EntityType.SupplierEntity, false) { }
		
		/// <summary>Creates a new SupplierEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SupplierEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSupplierUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty TerritoryEntity objects.</summary>
	[Serializable]
	public partial class TerritoryEntityFactory : EntityFactoryBase2<TerritoryEntity> {
		/// <summary>CTor</summary>
		public TerritoryEntityFactory() : base("TerritoryEntity", NW26.EntityType.TerritoryEntity, false) { }
		
		/// <summary>Creates a new TerritoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new TerritoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTerritoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses  entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity2 Create(NW26.EntityType entityTypeToCreate)
		{
			IEntityFactory2 factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case NW26.EntityType.AlphabeticalListOfProductEntity:
					factoryToUse = new AlphabeticalListOfProductEntityFactory();
					break;
				case NW26.EntityType.CategoryEntity:
					factoryToUse = new CategoryEntityFactory();
					break;
				case NW26.EntityType.CategorySalesFor1997Entity:
					factoryToUse = new CategorySalesFor1997EntityFactory();
					break;
				case NW26.EntityType.CurrentProductListEntity:
					factoryToUse = new CurrentProductListEntityFactory();
					break;
				case NW26.EntityType.CustomerEntity:
					factoryToUse = new CustomerEntityFactory();
					break;
				case NW26.EntityType.CustomerAndSuppliersByCityEntity:
					factoryToUse = new CustomerAndSuppliersByCityEntityFactory();
					break;
				case NW26.EntityType.CustomerCustomerDemoEntity:
					factoryToUse = new CustomerCustomerDemoEntityFactory();
					break;
				case NW26.EntityType.CustomerDemographicEntity:
					factoryToUse = new CustomerDemographicEntityFactory();
					break;
				case NW26.EntityType.EmployeeEntity:
					factoryToUse = new EmployeeEntityFactory();
					break;
				case NW26.EntityType.EmployeeTerritoryEntity:
					factoryToUse = new EmployeeTerritoryEntityFactory();
					break;
				case NW26.EntityType.InvoiceEntity:
					factoryToUse = new InvoiceEntityFactory();
					break;
				case NW26.EntityType.OrderEntity:
					factoryToUse = new OrderEntityFactory();
					break;
				case NW26.EntityType.OrderDetailEntity:
					factoryToUse = new OrderDetailEntityFactory();
					break;
				case NW26.EntityType.OrderDetailsExtendedEntity:
					factoryToUse = new OrderDetailsExtendedEntityFactory();
					break;
				case NW26.EntityType.OrdersQryEntity:
					factoryToUse = new OrdersQryEntityFactory();
					break;
				case NW26.EntityType.OrderSubtotalEntity:
					factoryToUse = new OrderSubtotalEntityFactory();
					break;
				case NW26.EntityType.ProductEntity:
					factoryToUse = new ProductEntityFactory();
					break;
				case NW26.EntityType.ProductsAboveAveragePriceEntity:
					factoryToUse = new ProductsAboveAveragePriceEntityFactory();
					break;
				case NW26.EntityType.ProductSalesFor1997Entity:
					factoryToUse = new ProductSalesFor1997EntityFactory();
					break;
				case NW26.EntityType.ProductsByCategoryEntity:
					factoryToUse = new ProductsByCategoryEntityFactory();
					break;
				case NW26.EntityType.QuarterlyOrderEntity:
					factoryToUse = new QuarterlyOrderEntityFactory();
					break;
				case NW26.EntityType.RegionEntity:
					factoryToUse = new RegionEntityFactory();
					break;
				case NW26.EntityType.SalesByCategoryEntity:
					factoryToUse = new SalesByCategoryEntityFactory();
					break;
				case NW26.EntityType.SalesTotalsByAmountEntity:
					factoryToUse = new SalesTotalsByAmountEntityFactory();
					break;
				case NW26.EntityType.ShipperEntity:
					factoryToUse = new ShipperEntityFactory();
					break;
				case NW26.EntityType.SummaryOfSalesByQuarterEntity:
					factoryToUse = new SummaryOfSalesByQuarterEntityFactory();
					break;
				case NW26.EntityType.SummaryOfSalesByYearEntity:
					factoryToUse = new SummaryOfSalesByYearEntityFactory();
					break;
				case NW26.EntityType.SupplierEntity:
					factoryToUse = new SupplierEntityFactory();
					break;
				case NW26.EntityType.TerritoryEntity:
					factoryToUse = new TerritoryEntityFactory();
					break;
			}
			IEntity2 toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}		
	}
		
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class EntityFactoryFactory
	{
#if CF
		/// <summary>Gets the factory of the entity with the NW26.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(NW26.EntityType typeOfEntity)
		{
			return GeneralEntityFactory.Create(typeOfEntity).GetEntityFactory();
		}
#else
		private static Dictionary<Type, IEntityFactory2> _factoryPerType = new Dictionary<Type, IEntityFactory2>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			Array entityTypeValues = Enum.GetValues(typeof(NW26.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity2 dummy = GeneralEntityFactory.Create((NW26.EntityType)entityTypeValue);
				_factoryPerType.Add(dummy.GetType(), dummy.GetEntityFactory());
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(Type typeOfEntity)
		{
			IEntityFactory2 toReturn = null;
			_factoryPerType.TryGetValue(typeOfEntity, out toReturn);
			return toReturn;
		}

		/// <summary>Gets the factory of the entity with the NW26.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(NW26.EntityType typeOfEntity)
		{
			return GetFactory(GeneralEntityFactory.Create(typeOfEntity).GetType());
		}
#endif		
	}
		
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator2
	{
		/// <summary>Gets the factory of the Entity type with the NW26.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(int entityTypeValue)
		{
			return (IEntityFactory2)this.GetFactoryImpl(entityTypeValue);
		}
		
		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(Type typeOfEntity)
		{
			return (IEntityFactory2)this.GetFactoryImpl(typeOfEntity);
		}

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields2 CreateResultsetFields(int numberOfFields)
		{
			return new ResultsetFields(numberOfFields);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand)
		{
			return new DynamicRelation(leftOperand);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (NW26.EntityType)Enum.Parse(typeof(NW26.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperandEntityName">Name of the entity which is used as the left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((NW26.EntityType)Enum.Parse(typeof(NW26.EntityType), leftOperandEntityName, false), joinType, (NW26.EntityType)Enum.Parse(typeof(NW26.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Obtains the inheritance info provider instance from the singleton </summary>
		/// <returns>The singleton instance of the inheritance info provider</returns>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the NW26.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return EntityFactoryFactory.GetFactory((NW26.EntityType)entityTypeValue);
		}
#if !CF		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity);
		}
#endif
	}
}
