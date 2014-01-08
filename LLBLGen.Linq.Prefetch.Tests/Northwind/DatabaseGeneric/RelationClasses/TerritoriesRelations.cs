///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
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
	/// <summary>Implements the relations factory for the entity: Territories. </summary>
	public partial class TerritoriesRelations
	{
		/// <summary>CTor</summary>
		public TerritoriesRelations()
		{
		}

		/// <summary>Gets all relations of the TerritoriesEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.EmployeeTerritoriesEntityUsingTerritoryId);
			toReturn.Add(this.RegionEntityUsingRegionId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between TerritoriesEntity and EmployeeTerritoriesEntity over the 1:n relation they have, using the relation between the fields:
		/// Territories.TerritoryId - EmployeeTerritories.TerritoryId
		/// </summary>
		public virtual IEntityRelation EmployeeTerritoriesEntityUsingTerritoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EmployeeTerritories" , true);
				relation.AddEntityFieldPair(TerritoriesFields.TerritoryId, EmployeeTerritoriesFields.TerritoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TerritoriesEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeTerritoriesEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between TerritoriesEntity and RegionEntity over the m:1 relation they have, using the relation between the fields:
		/// Territories.RegionId - Region.RegionId
		/// </summary>
		public virtual IEntityRelation RegionEntityUsingRegionId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Region", false);
				relation.AddEntityFieldPair(RegionFields.RegionId, TerritoriesFields.RegionId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegionEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TerritoriesEntity", true);
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
	internal static class StaticTerritoriesRelations
	{
		internal static readonly IEntityRelation EmployeeTerritoriesEntityUsingTerritoryIdStatic = new TerritoriesRelations().EmployeeTerritoriesEntityUsingTerritoryId;
		internal static readonly IEntityRelation RegionEntityUsingRegionIdStatic = new TerritoriesRelations().RegionEntityUsingRegionId;

		/// <summary>CTor</summary>
		static StaticTerritoriesRelations()
		{
		}
	}
}
