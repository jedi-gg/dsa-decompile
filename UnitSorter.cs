using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class UnitSorter
{
	[Attribute(Name="InjectAttribute", RVA="0x105EF98", Offset="0x105EF98")]
	[FieldOffset(Offset="0x10")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105EFA8", Offset="0x105EFA8")]
	[FieldOffset(Offset="0x18")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x105EFB8", Offset="0x105EFB8")]
	[FieldOffset(Offset="0x20")]
	private InventoryUtility _inventoryUtility;

	[Address(RVA="0x1510190", Offset="0x1510190", VA="0x1510190")]
	public UnitSorter()
	{
	}

	[Address(RVA="0x1510198", Offset="0x1510198", VA="0x1510198")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070FCC", Offset="0x1070FCC")]
	private int <Sort>b__0_0(Gamedata.Unit? aUnitDef, Gamedata.Unit? bUnitDef)
	{
		return new int();
	}

	[Address(RVA="0x150FC58", Offset="0x150FC58", VA="0x150FC58")]
	private int Compare(Gamedata.Unit? aDef, Gamedata.Unit? bDef)
	{
		return new int();
	}

	[Address(RVA="0x150FFD0", Offset="0x150FFD0", VA="0x150FFD0")]
	private int Compare(Serverproto.Unit aUnit, Serverproto.Unit bUnit)
	{
		return new int();
	}

	[Address(RVA="0x150F538", Offset="0x150F538", VA="0x150F538")]
	public int CompareAccuracy(Gamedata.Unit? aDef, Gamedata.Unit? bDef)
	{
		return new int();
	}

	[Address(RVA="0x150E360", Offset="0x150E360", VA="0x150E360")]
	public int CompareCritChance(Gamedata.Unit? aDef, Gamedata.Unit? bDef)
	{
		return new int();
	}

	[Address(RVA="0x150E6F0", Offset="0x150E6F0", VA="0x150E6F0")]
	public int CompareCritPower(Gamedata.Unit? aDef, Gamedata.Unit? bDef)
	{
		return new int();
	}

	[Address(RVA="0x150D898", Offset="0x150D898", VA="0x150D898")]
	public int CompareDefense(Gamedata.Unit? aDef, Gamedata.Unit? bDef)
	{
		return new int();
	}

	[Address(RVA="0x150F8C8", Offset="0x150F8C8", VA="0x150F8C8")]
	public int CompareEvasion(Gamedata.Unit? aDef, Gamedata.Unit? bDef)
	{
		return new int();
	}

	[Address(RVA="0x150D374", Offset="0x150D374", VA="0x150D374")]
	public int CompareGearTier(Gamedata.Unit? aDef, Gamedata.Unit? bDef)
	{
		return new int();
	}

	[Address(RVA="0x150DC30", Offset="0x150DC30", VA="0x150DC30")]
	public int CompareHealth(Gamedata.Unit? aDef, Gamedata.Unit? bDef)
	{
		return new int();
	}

	[Address(RVA="0x150D1E8", Offset="0x150D1E8", VA="0x150D1E8")]
	public int CompareLevel(Gamedata.Unit? aDef, Gamedata.Unit? bDef)
	{
		return new int();
	}

	[Address(RVA="0x150FEC4", Offset="0x150FEC4", VA="0x150FEC4")]
	private int CompareName(Gamedata.Unit? aDef, Gamedata.Unit? bDef)
	{
		return new int();
	}

	[Address(RVA="0x150D500", Offset="0x150D500", VA="0x150D500")]
	public int CompareOffense(Gamedata.Unit? aDef, Gamedata.Unit? bDef)
	{
		return new int();
	}

	[Address(RVA="0x150EE18", Offset="0x150EE18", VA="0x150EE18")]
	public int ComparePotency(Gamedata.Unit? aDef, Gamedata.Unit? bDef)
	{
		return new int();
	}

	[Address(RVA="0x150CDC8", Offset="0x150CDC8", VA="0x150CDC8")]
	public int ComparePower(Gamedata.Unit? aDef, Gamedata.Unit? bDef)
	{
		return new int();
	}

	[Address(RVA="0x150CFE4", Offset="0x150CFE4", VA="0x150CFE4")]
	public int CompareRarity(Gamedata.Unit? aDef, Gamedata.Unit? bDef)
	{
		return new int();
	}

	[Address(RVA="0x150DFC8", Offset="0x150DFC8", VA="0x150DFC8")]
	public int CompareRecovery(Gamedata.Unit? aDef, Gamedata.Unit? bDef)
	{
		return new int();
	}

	[Address(RVA="0x150EA80", Offset="0x150EA80", VA="0x150EA80")]
	public int CompareSpeed(Gamedata.Unit? aDef, Gamedata.Unit? bDef)
	{
		return new int();
	}

	[Address(RVA="0x150F1A8", Offset="0x150F1A8", VA="0x150F1A8")]
	public int CompareTenacity(Gamedata.Unit? aDef, Gamedata.Unit? bDef)
	{
		return new int();
	}

	[Address(RVA="0x150CFA0", Offset="0x150CFA0", VA="0x150CFA0")]
	private int FallbackComparison(Gamedata.Unit? aDef, Gamedata.Unit? bDef)
	{
		return new int();
	}

	[Address(RVA="0x15034D4", Offset="0x15034D4", VA="0x15034D4")]
	public void Sort(List<Gamedata.Unit?> unitDefList)
	{
	}

	[Address(RVA="0x150CC1C", Offset="0x150CC1C", VA="0x150CC1C")]
	public void Sort(List<Serverproto.Unit> units)
	{
	}

	[Address(RVA="0x150CCBC", Offset="0x150CCBC", VA="0x150CCBC")]
	public void Sort(List<Serverproto.Unit> units, List<Serverproto.Unit> selectedUnits, PersistedPlayerBattleUnits battleInfo)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CF9C", Offset="0x104CF9C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public List<Serverproto.Unit> selectedUnits;

		[FieldOffset(Offset="0x18")]
		public PersistedPlayerBattleUnits battleInfo;

		[FieldOffset(Offset="0x20")]
		public UnitSorter <>4__this;

		[Address(RVA="0x150CDC0", Offset="0x150CDC0", VA="0x150CDC0")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x15102E8", Offset="0x15102E8", VA="0x15102E8")]
		internal int <Sort>b__0(Serverproto.Unit aUnitProto, Serverproto.Unit bUnitProto)
		{
			return new int();
		}
	}
}