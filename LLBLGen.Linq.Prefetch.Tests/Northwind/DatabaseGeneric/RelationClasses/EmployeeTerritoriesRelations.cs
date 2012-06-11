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
	/// <summary>Implements the relations factory for the entity: EmployeeTerritories. </summary>
	public partial class EmployeeTerritoriesRelations
	{
		/// <summary>CTor</summary>
		public EmployeeTerritoriesRelations()
		{
		}

		/// <summary>Gets all relations of the EmployeeTerritoriesEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.EmployeesEntityUsingEmployeeId);
			toReturn.Add(this.TerritoriesEntityUsingTerritoryId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between EmployeeTerritoriesEntity and EmployeesEntity over the m:1 relation they have, using the relation between the fields:
		/// EmployeeTerritories.EmployeeId - Employees.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeesEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employees", false);
				relation.AddEntityFieldPair(EmployeesFields.EmployeeId, EmployeeTerritoriesFields.EmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeesEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeTerritoriesEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between EmployeeTerritoriesEntity and TerritoriesEntity over the m:1 relation they have, using the relation between the fields:
		/// EmployeeTerritories.TerritoryId - Territories.TerritoryId
		/// </summary>
		public virtual IEntityRelation TerritoriesEntityUsingTerritoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Territories", false);
				relation.AddEntityFieldPair(TerritoriesFields.TerritoryId, EmployeeTerritoriesFields.TerritoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TerritoriesEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeTerritoriesEntity", true);
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
	internal static class StaticEmployeeTerritoriesRelations
	{
		internal static readonly IEntityRelation EmployeesEntityUsingEmployeeIdStatic = new EmployeeTerritoriesRelations().EmployeesEntityUsingEmployeeId;
		internal static readonly IEntityRelation TerritoriesEntityUsingTerritoryIdStatic = new EmployeeTerritoriesRelations().TerritoriesEntityUsingTerritoryId;

		/// <summary>CTor</summary>
		static StaticEmployeeTerritoriesRelations()
		{
		}
	}
}
