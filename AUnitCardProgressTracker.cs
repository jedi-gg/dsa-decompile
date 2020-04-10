using Gamedata;
using Il2CppDummyDll;
using System;

public abstract class AUnitCardProgressTracker : ACardProgressTracker
{
	[FieldOffset(Offset="0x10")]
	public readonly Unit UnitDef;

	[Address(RVA="0x10F520C", Offset="0x10F520C", VA="0x10F520C")]
	public AUnitCardProgressTracker(Unit unitDef)
	{
	}
}