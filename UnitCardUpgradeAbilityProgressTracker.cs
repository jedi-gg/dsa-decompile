using Gamedata;
using Il2CppDummyDll;
using System;

public class UnitCardUpgradeAbilityProgressTracker : AUnitCardProgressTracker
{
	[FieldOffset(Offset="0x20")]
	public readonly long UpgradesAvailable;

	[FieldOffset(Offset="0x28")]
	public readonly int AbilityId;

	[Address(RVA="0x11DF04C", Offset="0x11DF04C", VA="0x11DF04C")]
	public UnitCardUpgradeAbilityProgressTracker([Attribute(Name="TupleElementNamesAttribute", RVA="0x1090EFC", Offset="0x1090EFC")] ValueTuple<Unit, long, int> data)
	{
	}
}