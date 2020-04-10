using Il2CppDummyDll;
using System;

public struct DBattleHealthAction
{
	[FieldOffset(Offset="0x0")]
	public readonly byte UnitId;

	[FieldOffset(Offset="0x4")]
	public readonly float HealthPercent;

	[FieldOffset(Offset="0x8")]
	public readonly float ShieldPercent;

	[FieldOffset(Offset="0xC")]
	public readonly float SpeedBarPercent;

	[FieldOffset(Offset="0x10")]
	public readonly bool IsCcImmune;

	[Address(RVA="0xF02D04", Offset="0xF02D04", VA="0xF02D04")]
	public DBattleHealthAction(byte unitId, float healthPercent, float shieldPercent, float speedBarPercent, bool isCcImmune)
	{
	}
}