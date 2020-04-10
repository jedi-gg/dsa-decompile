using Il2CppDummyDll;
using System;

public struct DBattleHpDecayAction
{
	[FieldOffset(Offset="0x0")]
	public readonly byte UnitId;

	[FieldOffset(Offset="0x4")]
	public readonly uint HpDecay;

	[Address(RVA="0xF02D1C", Offset="0xF02D1C", VA="0xF02D1C")]
	public DBattleHpDecayAction(byte unitId, uint hpDecay)
	{
	}
}