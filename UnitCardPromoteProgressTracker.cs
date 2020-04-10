using Gamedata;
using Il2CppDummyDll;
using System;

public class UnitCardPromoteProgressTracker : AUnitCardProgressTracker
{
	[FieldOffset(Offset="0x20")]
	public readonly long TokensOwned;

	[FieldOffset(Offset="0x28")]
	public readonly long TokensRequired;

	[FieldOffset(Offset="0x30")]
	public readonly long TokenCost;

	[FieldOffset(Offset="0x38")]
	public readonly bool UnlocksUnit;

	[Address(RVA="0x11DEFF4", Offset="0x11DEFF4", VA="0x11DEFF4")]
	public UnitCardPromoteProgressTracker([Attribute(Name="TupleElementNamesAttribute", RVA="0x1090DBC", Offset="0x1090DBC")] ValueTuple<Unit, long, long, long> data, bool unlocksUnit)
	{
	}
}