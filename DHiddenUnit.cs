using Il2CppDummyDll;
using System;

public struct DHiddenUnit
{
	[FieldOffset(Offset="0x0")]
	public BattleUnit Unit;

	[FieldOffset(Offset="0x8")]
	public uint HideId;

	[Address(RVA="0xEFD540", Offset="0xEFD540", VA="0xEFD540")]
	public void Show()
	{
	}
}