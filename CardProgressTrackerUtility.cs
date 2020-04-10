using Gamedata;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class CardProgressTrackerUtility
{
	[FieldOffset(Offset="0x0")]
	private static int s_randomSeed;

	[Attribute(Name="InjectAttribute", RVA="0x10587A0", Offset="0x10587A0")]
	[FieldOffset(Offset="0x10")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x10587B0", Offset="0x10587B0")]
	[FieldOffset(Offset="0x18")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x10587C0", Offset="0x10587C0")]
	[FieldOffset(Offset="0x20")]
	private InventoryUtility _inventoryUtility;

	[Attribute(Name="TupleElementNamesAttribute", RVA="0x10587D0", Offset="0x10587D0")]
	[FieldOffset(Offset="0x28")]
	private List<ValueTuple<CardProgressTracker, ACardProgressTracker>> _trackers;

	[Address(RVA="0x1192EE8", Offset="0x1192EE8", VA="0x1192EE8")]
	static CardProgressTrackerUtility()
	{
	}

	[Address(RVA="0x1192E78", Offset="0x1192E78", VA="0x1192E78")]
	public CardProgressTrackerUtility()
	{
	}

	[Address(RVA="0x1190E9C", Offset="0x1190E9C", VA="0x1190E9C")]
	private ACardProgressTracker BuildTracker(CardProgressTracker trackerDef)
	{
		return null;
	}

	[Address(RVA="0x11926F4", Offset="0x11926F4", VA="0x11926F4")]
	private ValueTuple<Spell, long, long, long>? GetSpellToUnlockOrPromote(CardProgressTracker trackerDef, bool unlock)
	{
		return null;
	}

	[Address(RVA="0x1190A54", Offset="0x1190A54", VA="0x1190A54")]
	public ACardProgressTracker GetTracker()
	{
		return null;
	}

	[Address(RVA="0x1191B34", Offset="0x1191B34", VA="0x1191B34")]
	private ValueTuple<Unit, long, int>? GetUnitToEquipGear(CardProgressTracker trackerDef)
	{
		return null;
	}

	[Address(RVA="0x11913CC", Offset="0x11913CC", VA="0x11913CC")]
	private ValueTuple<Unit, long, long, long>? GetUnitToUnlockOrPromote(CardProgressTracker trackerDef, bool unlock)
	{
		return null;
	}

	[Address(RVA="0x11920B4", Offset="0x11920B4", VA="0x11920B4")]
	private ValueTuple<Unit, long, int>? GetUnitToUpgradeAbility(CardProgressTracker trackerDef)
	{
		return null;
	}

	[Address(RVA="0x11909D4", Offset="0x11909D4", VA="0x11909D4")]
	public static void SelectRandomSeed()
	{
	}

	[Address(RVA="0x1191210", Offset="0x1191210", VA="0x1191210")]
	private static ACardProgressTracker SelectTracker([Attribute(Name="TupleElementNamesAttribute", RVA="0x1090D34", Offset="0x1090D34")] List<ValueTuple<CardProgressTracker, ACardProgressTracker>> trackers, int totalWeights)
	{
		return null;
	}
}