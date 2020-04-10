using Il2CppDummyDll;
using Serverproto;
using System;

public struct DInventoryDeltaAction
{
	[FieldOffset(Offset="0x0")]
	public readonly InventoryDelta Delta;

	[Address(RVA="0xEFDDE8", Offset="0xEFDDE8", VA="0xEFDDE8")]
	public DInventoryDeltaAction(InventoryDelta delta)
	{
	}
}