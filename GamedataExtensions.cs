using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class GamedataExtensions
{
	[Address(RVA="0x14E9604", Offset="0x14E9604", VA="0x14E9604")]
	public static bool AllowsAssignSquadToNode(ClubWarPhaseType phaseType)
	{
		return new bool();
	}

	[Address(RVA="0x14E9618", Offset="0x14E9618", VA="0x14E9618")]
	public static bool AllowsRemoveSquadFromNode(ClubWarPhaseType phaseType)
	{
		return new bool();
	}

	[Address(RVA="0x14E8158", Offset="0x14E8158", VA="0x14E8158")]
	public static bool ExistsInCategory(Gamedata.Unit unit, UnitCategory category)
	{
		return new bool();
	}

	[Address(RVA="0x14E81A4", Offset="0x14E81A4", VA="0x14E81A4")]
	public static bool ExistsInCategory(Gamedata.Unit unit, ulong categoryId)
	{
		return new bool();
	}

	[Address(RVA="0x14E8220", Offset="0x14E8220", VA="0x14E8220")]
	public static bool ExistsInCategory(Gamedata.Spell spell, SpellCategory category)
	{
		return new bool();
	}

	[Address(RVA="0x14E826C", Offset="0x14E826C", VA="0x14E826C")]
	public static bool ExistsInCategory(Gamedata.Spell spell, ulong categoryId)
	{
		return new bool();
	}

	[Address(RVA="0x14E8058", Offset="0x14E8058", VA="0x14E8058")]
	public static UnitAbility? GetAbilityById(Gamedata.Unit unitDef, int abilityId)
	{
		return null;
	}

	[Address(RVA="0x14E8D28", Offset="0x14E8D28", VA="0x14E8D28")]
	public static float GetAccuracyStatValue(UnitGearSlot gearSlot, GearSlotTableData? gearSlotTable, int gearTier)
	{
		return new float();
	}

	[Address(RVA="0x14E88A0", Offset="0x14E88A0", VA="0x14E88A0")]
	public static float GetCritChanceStatValue(UnitGearSlot gearSlot, GearSlotTableData? gearSlotTable, int gearTier)
	{
		return new float();
	}

	[Address(RVA="0x14E8988", Offset="0x14E8988", VA="0x14E8988")]
	public static float GetCritPowerStatValue(UnitGearSlot gearSlot, GearSlotTableData? gearSlotTable, int gearTier)
	{
		return new float();
	}

	[Address(RVA="0x14E85E8", Offset="0x14E85E8", VA="0x14E85E8")]
	public static float GetDefenseStatValue(UnitGearSlot gearSlot, GearSlotTableData? gearSlotTable, int gearTier)
	{
		return new float();
	}

	[Address(RVA="0x14E8E10", Offset="0x14E8E10", VA="0x14E8E10")]
	public static float GetEvasionStatValue(UnitGearSlot gearSlot, GearSlotTableData? gearSlotTable, int gearTier)
	{
		return new float();
	}

	[Address(RVA="0x14E86D0", Offset="0x14E86D0", VA="0x14E86D0")]
	public static float GetHealthStatValue(UnitGearSlot gearSlot, GearSlotTableData? gearSlotTable, int gearTier)
	{
		return new float();
	}

	[Address(RVA="0x14E9628", Offset="0x14E9628", VA="0x14E9628")]
	public static string GetHomeBaseNodeId(Gamedata.ClubWar warDef, ClubWarTeam teamId)
	{
		return null;
	}

	[Address(RVA="0x14E7DA0", Offset="0x14E7DA0", VA="0x14E7DA0")]
	public static string GetIcon(Gamedata.Unit unitDef, Serverproto.Unit unit)
	{
		return null;
	}

	[Address(RVA="0x14E7EFC", Offset="0x14E7EFC", VA="0x14E7EFC")]
	public static string GetNameKey(Gamedata.Unit unitDef, Serverproto.Unit unit)
	{
		return null;
	}

	[Address(RVA="0x14E94FC", Offset="0x14E94FC", VA="0x14E94FC")]
	public static ClubWarNode? GetNode(Gamedata.ClubWar warDef, string nodeId)
	{
		return null;
	}

	[Address(RVA="0x14E83D0", Offset="0x14E83D0", VA="0x14E83D0")]
	private static int GetNumberOfStatTypes(UnitGearSlot gearSlot)
	{
		return new int();
	}

	[Address(RVA="0x14E82E8", Offset="0x14E82E8", VA="0x14E82E8")]
	public static float GetOffenseStatValue(UnitGearSlot gearSlot, GearSlotTableData? gearSlotTable, int gearTier)
	{
		return new float();
	}

	[Address(RVA="0x14E8B58", Offset="0x14E8B58", VA="0x14E8B58")]
	public static float GetPotencyStatValue(UnitGearSlot gearSlot, GearSlotTableData? gearSlotTable, int gearTier)
	{
		return new float();
	}

	[Address(RVA="0x14E77A8", Offset="0x14E77A8", VA="0x14E77A8")]
	public static string GetPrefabSafe(Gamedata.Unit unitDef, Serverproto.Unit unit)
	{
		return null;
	}

	[Address(RVA="0x14E79B0", Offset="0x14E79B0", VA="0x14E79B0")]
	public static string GetPrefabSafe(BattleLib_Bootstrap.Types.Unit unit, uint altPrefabId = 0)
	{
		return null;
	}

	[Address(RVA="0x14E87B8", Offset="0x14E87B8", VA="0x14E87B8")]
	public static float GetRecoveryeStatValue(UnitGearSlot gearSlot, GearSlotTableData? gearSlotTable, int gearTier)
	{
		return new float();
	}

	[Address(RVA="0x14E9384", Offset="0x14E9384", VA="0x14E9384")]
	public static GamedataExtensions.SorcererStoneMathOperation GetSorcererStoneMathOperation(Gamedata.InventoryItem stoneItem)
	{
		return new GamedataExtensions.SorcererStoneMathOperation();
	}

	[Address(RVA="0x14E90B4", Offset="0x14E90B4", VA="0x14E90B4")]
	public static float GetSorcererStonePrimaryStat(Gamedata.InventoryItem stoneItem)
	{
		return new float();
	}

	[Address(RVA="0x14E8A70", Offset="0x14E8A70", VA="0x14E8A70")]
	public static float GetSpeedStatValue(UnitGearSlot gearSlot, GearSlotTableData? gearSlotTable, int gearTier)
	{
		return new float();
	}

	[Address(RVA="0x14E84F0", Offset="0x14E84F0", VA="0x14E84F0")]
	private static float GetStatValue(GearSlotTableStat? tableStat, int gearTier, int numberOfOtherStatTypes)
	{
		return new float();
	}

	[Address(RVA="0x14E985C", Offset="0x14E985C", VA="0x14E985C")]
	private static float GetStatValue(GearSlotTableStatTier? statTier, int numberOfOtherStatTypes)
	{
		return new float();
	}

	[Address(RVA="0x14E8C40", Offset="0x14E8C40", VA="0x14E8C40")]
	public static float GetTenacityStatValue(UnitGearSlot gearSlot, GearSlotTableData? gearSlotTable, int gearTier)
	{
		return new float();
	}

	[Address(RVA="0x14E9450", Offset="0x14E9450", VA="0x14E9450")]
	public static string LocalizedName(ClubWarNode node, LocalizationManager lm)
	{
		return null;
	}

	[Address(RVA="0x14E9028", Offset="0x14E9028", VA="0x14E9028")]
	public static bool ShouldConsiderSpell(CardProgressTracker tracker, ulong id)
	{
		return new bool();
	}

	[Address(RVA="0x14E8F9C", Offset="0x14E8F9C", VA="0x14E8F9C")]
	public static bool ShouldConsiderUnit(CardProgressTracker tracker, ulong id)
	{
		return new bool();
	}

	[Address(RVA="0x14E8EF8", Offset="0x14E8EF8", VA="0x14E8EF8")]
	public static UnityEngine.Color ToUnityColor(Gamedata.Color color)
	{
		return new UnityEngine.Color();
	}

	[Address(RVA="0x14E9770", Offset="0x14E9770", VA="0x14E9770")]
	public static Vector2 ToVector2(RectTransformAlignment alignment)
	{
		return new Vector2();
	}

	[Address(RVA="0x14E9800", Offset="0x14E9800", VA="0x14E9800")]
	public static Vector2 ToVector2(RectTransformOffset offset)
	{
		return new Vector2();
	}

	public enum SorcererStoneMathOperation
	{
		[FieldOffset(Offset="0x0")]
		Invalid,
		[FieldOffset(Offset="0x0")]
		Addition,
		[FieldOffset(Offset="0x0")]
		Multiplication
	}
}