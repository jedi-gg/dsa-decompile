using Gamedata;
using Il2CppDummyDll;
using System;

public class UnitCardEquipGearProgressTracker : AUnitCardProgressTracker
{
	[FieldOffset(Offset="0x20")]
	public readonly long EquipsAvailable;

	[FieldOffset(Offset="0x28")]
	public readonly int GearSlotIndex;

	[Address(RVA="0x11DEFB8", Offset="0x11DEFB8", VA="0x11DEFB8")]
	public UnitCardEquipGearProgressTracker([Attribute(Name="TupleElementNamesAttribute", RVA="0x1090E64", Offset="0x1090E64")] ValueTuple<Unit, long, int> data)
	{
	}
}