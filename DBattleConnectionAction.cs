using Il2CppDummyDll;
using System;

public struct DBattleConnectionAction
{
	[FieldOffset(Offset="0x0")]
	public readonly BattleConnectionStatus Status;

	[Address(RVA="0xF02B34", Offset="0xF02B34", VA="0xF02B34")]
	public DBattleConnectionAction(BattleConnectionStatus status)
	{
	}
}