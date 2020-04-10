using Gamedata;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class UnitStatCalculator
{
	[FieldOffset(Offset="0x0")]
	private const int NUMBER_OF_GEAR_SLOTS = 6;

	[Attribute(Name="InjectAttribute", RVA="0x105EFC8", Offset="0x105EFC8")]
	[FieldOffset(Offset="0x10")]
	private GamedataDomainController _gamedataDC;

	[Address(RVA="0x15124FC", Offset="0x15124FC", VA="0x15124FC")]
	public UnitStatCalculator()
	{
	}

	[Address(RVA="0x15104BC", Offset="0x15104BC", VA="0x15104BC")]
	public float CalculateUnitStat(Serverproto.Unit unit, int level, UnitStatCalculator.StatType stat)
	{
		return new float();
	}

	[Address(RVA="0x1511520", Offset="0x1511520", VA="0x1511520")]
	public float CalculateUnitStat(Serverproto.Unit unit, Gamedata.InventoryItem? sorcererStone, UnitStatCalculator.StatType stat)
	{
		return new float();
	}

	[Address(RVA="0x1510A50", Offset="0x1510A50", VA="0x1510A50")]
	public static float CalculateUnitStat(Gamedata.Unit unitDef, StatProgressionTable statProgressionTable, GearSlotTable gearSlotTable, uint level, ulong rarity, IList<bool> gearSlotEquipped, ulong gearTier, Gamedata.InventoryItem? sorcererStone, UnitStatCalculator.StatType stat)
	{
		return new float();
	}

	[Address(RVA="0x1511E74", Offset="0x1511E74", VA="0x1511E74")]
	private static float GetGearSlotValue(GearSlotTable gst, UnitStatCalculator.StatType stat, int tierIndex, int numOthers)
	{
		return new float();
	}

	[Address(RVA="0x1511B58", Offset="0x1511B58", VA="0x1511B58")]
	private static float GetStatProgressionTableDataByStatType(StatProgressionTableData sptd, UnitStatCalculator.StatType statType)
	{
		return new float();
	}

	[Address(RVA="0x1511A58", Offset="0x1511A58", VA="0x1511A58")]
	private static float GetUnitStatByStatType(UnitStats stats, UnitStatCalculator.StatType statType)
	{
		return new float();
	}

	[Address(RVA="0x151223C", Offset="0x151223C", VA="0x151223C")]
	private static float GetUnitStatFromSorcererStone(Gamedata.InventoryItem item, UnitStatCalculator.StatType stat)
	{
		return new float();
	}

	[Address(RVA="0x1511BB8", Offset="0x1511BB8", VA="0x1511BB8")]
	private static bool IsGearSlotStatChecked(UnitGearTier gearTier, UnitStatCalculator.StatType statType, int slotIndex)
	{
		return new bool();
	}

	[Address(RVA="0x15124D4", Offset="0x15124D4", VA="0x15124D4")]
	private static float Round(float val)
	{
		return new float();
	}

	public enum StatType
	{
		[FieldOffset(Offset="0x0")]
		Offense,
		[FieldOffset(Offset="0x0")]
		Defense,
		[FieldOffset(Offset="0x0")]
		Health,
		[FieldOffset(Offset="0x0")]
		Recovery,
		[FieldOffset(Offset="0x0")]
		CritChance,
		[FieldOffset(Offset="0x0")]
		CritPower,
		[FieldOffset(Offset="0x0")]
		AttackSpeed_Deprecated,
		[FieldOffset(Offset="0x0")]
		Speed,
		[FieldOffset(Offset="0x0")]
		Potency,
		[FieldOffset(Offset="0x0")]
		Tenacity,
		[FieldOffset(Offset="0x0")]
		Accuracy,
		[FieldOffset(Offset="0x0")]
		Evasion
	}
}