﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using NW26;
using NW26.HelperClasses;
using NW26.FactoryClasses;
using NW26.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NW26.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Invoice'.<br/><br/></summary>
	[Serializable]
	public partial class InvoiceEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static InvoiceEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public InvoiceEntity():base("InvoiceEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public InvoiceEntity(IEntityFields2 fields):base("InvoiceEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this InvoiceEntity</param>
		public InvoiceEntity(IValidator validator):base("InvoiceEntity")
		{
			InitClassEmpty(validator, null);
		}
				


		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected InvoiceEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}


		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				default:
					break;				
			}
			return toReturn;
		}
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it/ will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		protected override bool CheckOneWayRelations(string propertyName)
		{
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			return toReturn;
		}

		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new InvoiceRelations().GetAllRelations();
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(InvoiceEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			return toReturn;
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}


		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Address", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Country", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CustomerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CustomerName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Discount", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ExtendedPrice", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Freight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("OrderDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("OrderId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PostalCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Quantity", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Region", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RequiredDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Salesperson", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipAddress", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipCity", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipCountry", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShippedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipperName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipPostalCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipRegion", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UnitPrice", fieldHashtable);
		}
		#endregion

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this InvoiceEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();

		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static InvoiceRelations Relations
		{
			get	{ return new InvoiceRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The Address property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."Address"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address
		{
			get { return (System.String)GetValue((int)InvoiceFieldIndex.Address, true); }
			set	{ SetValue((int)InvoiceFieldIndex.Address, value); }
		}

		/// <summary> The City property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."City"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)InvoiceFieldIndex.City, true); }
			set	{ SetValue((int)InvoiceFieldIndex.City, value); }
		}

		/// <summary> The Country property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."Country"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Country
		{
			get { return (System.String)GetValue((int)InvoiceFieldIndex.Country, true); }
			set	{ SetValue((int)InvoiceFieldIndex.Country, value); }
		}

		/// <summary> The CustomerId property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."CustomerID"<br/>
		/// View field type characteristics (type, precision, scale, length): NChar, 0, 0, 5<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CustomerId
		{
			get { return (System.String)GetValue((int)InvoiceFieldIndex.CustomerId, true); }
			set	{ SetValue((int)InvoiceFieldIndex.CustomerId, value); }
		}

		/// <summary> The CustomerName property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."CustomerName"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 40<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CustomerName
		{
			get { return (System.String)GetValue((int)InvoiceFieldIndex.CustomerName, true); }
			set	{ SetValue((int)InvoiceFieldIndex.CustomerName, value); }
		}

		/// <summary> The Discount property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."Discount"<br/>
		/// View field type characteristics (type, precision, scale, length): Real, 24, 0, 0<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Single Discount
		{
			get { return (System.Single)GetValue((int)InvoiceFieldIndex.Discount, true); }
			set	{ SetValue((int)InvoiceFieldIndex.Discount, value); }
		}

		/// <summary> The ExtendedPrice property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."ExtendedPrice"<br/>
		/// View field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> ExtendedPrice
		{
			get { return (Nullable<System.Decimal>)GetValue((int)InvoiceFieldIndex.ExtendedPrice, false); }
			set	{ SetValue((int)InvoiceFieldIndex.ExtendedPrice, value); }
		}

		/// <summary> The Freight property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."Freight"<br/>
		/// View field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Freight
		{
			get { return (Nullable<System.Decimal>)GetValue((int)InvoiceFieldIndex.Freight, false); }
			set	{ SetValue((int)InvoiceFieldIndex.Freight, value); }
		}

		/// <summary> The OrderDate property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."OrderDate"<br/>
		/// View field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> OrderDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)InvoiceFieldIndex.OrderDate, false); }
			set	{ SetValue((int)InvoiceFieldIndex.OrderDate, value); }
		}

		/// <summary> The OrderId property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."OrderID"<br/>
		/// View field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 OrderId
		{
			get { return (System.Int32)GetValue((int)InvoiceFieldIndex.OrderId, true); }
			set	{ SetValue((int)InvoiceFieldIndex.OrderId, value); }
		}

		/// <summary> The PostalCode property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."PostalCode"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PostalCode
		{
			get { return (System.String)GetValue((int)InvoiceFieldIndex.PostalCode, true); }
			set	{ SetValue((int)InvoiceFieldIndex.PostalCode, value); }
		}

		/// <summary> The ProductId property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."ProductID"<br/>
		/// View field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)InvoiceFieldIndex.ProductId, true); }
			set	{ SetValue((int)InvoiceFieldIndex.ProductId, value); }
		}

		/// <summary> The ProductName property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."ProductName"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 40<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ProductName
		{
			get { return (System.String)GetValue((int)InvoiceFieldIndex.ProductName, true); }
			set	{ SetValue((int)InvoiceFieldIndex.ProductName, value); }
		}

		/// <summary> The Quantity property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."Quantity"<br/>
		/// View field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 Quantity
		{
			get { return (System.Int16)GetValue((int)InvoiceFieldIndex.Quantity, true); }
			set	{ SetValue((int)InvoiceFieldIndex.Quantity, value); }
		}

		/// <summary> The Region property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."Region"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Region
		{
			get { return (System.String)GetValue((int)InvoiceFieldIndex.Region, true); }
			set	{ SetValue((int)InvoiceFieldIndex.Region, value); }
		}

		/// <summary> The RequiredDate property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."RequiredDate"<br/>
		/// View field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> RequiredDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)InvoiceFieldIndex.RequiredDate, false); }
			set	{ SetValue((int)InvoiceFieldIndex.RequiredDate, value); }
		}

		/// <summary> The Salesperson property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."Salesperson"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 31<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Salesperson
		{
			get { return (System.String)GetValue((int)InvoiceFieldIndex.Salesperson, true); }
			set	{ SetValue((int)InvoiceFieldIndex.Salesperson, value); }
		}

		/// <summary> The ShipAddress property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."ShipAddress"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ShipAddress
		{
			get { return (System.String)GetValue((int)InvoiceFieldIndex.ShipAddress, true); }
			set	{ SetValue((int)InvoiceFieldIndex.ShipAddress, value); }
		}

		/// <summary> The ShipCity property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."ShipCity"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ShipCity
		{
			get { return (System.String)GetValue((int)InvoiceFieldIndex.ShipCity, true); }
			set	{ SetValue((int)InvoiceFieldIndex.ShipCity, value); }
		}

		/// <summary> The ShipCountry property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."ShipCountry"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ShipCountry
		{
			get { return (System.String)GetValue((int)InvoiceFieldIndex.ShipCountry, true); }
			set	{ SetValue((int)InvoiceFieldIndex.ShipCountry, value); }
		}

		/// <summary> The ShipName property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."ShipName"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 40<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ShipName
		{
			get { return (System.String)GetValue((int)InvoiceFieldIndex.ShipName, true); }
			set	{ SetValue((int)InvoiceFieldIndex.ShipName, value); }
		}

		/// <summary> The ShippedDate property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."ShippedDate"<br/>
		/// View field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ShippedDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)InvoiceFieldIndex.ShippedDate, false); }
			set	{ SetValue((int)InvoiceFieldIndex.ShippedDate, value); }
		}

		/// <summary> The ShipperName property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."ShipperName"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 40<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ShipperName
		{
			get { return (System.String)GetValue((int)InvoiceFieldIndex.ShipperName, true); }
			set	{ SetValue((int)InvoiceFieldIndex.ShipperName, value); }
		}

		/// <summary> The ShipPostalCode property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."ShipPostalCode"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ShipPostalCode
		{
			get { return (System.String)GetValue((int)InvoiceFieldIndex.ShipPostalCode, true); }
			set	{ SetValue((int)InvoiceFieldIndex.ShipPostalCode, value); }
		}

		/// <summary> The ShipRegion property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."ShipRegion"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ShipRegion
		{
			get { return (System.String)GetValue((int)InvoiceFieldIndex.ShipRegion, true); }
			set	{ SetValue((int)InvoiceFieldIndex.ShipRegion, value); }
		}

		/// <summary> The UnitPrice property of the Entity Invoice<br/><br/></summary>
		/// <remarks>Mapped on  view field: "Invoices"."UnitPrice"<br/>
		/// View field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal UnitPrice
		{
			get { return (System.Decimal)GetValue((int)InvoiceFieldIndex.UnitPrice, true); }
			set	{ SetValue((int)InvoiceFieldIndex.UnitPrice, value); }
		}
	
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the NW26.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)NW26.EntityType.InvoiceEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
