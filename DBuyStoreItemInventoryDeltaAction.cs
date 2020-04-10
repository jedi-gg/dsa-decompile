using Il2CppDummyDll;
using Serverproto;
using System;

public struct DBuyStoreItemInventoryDeltaAction
{
	[FieldOffset(Offset="0x0")]
	public readonly InventoryDelta Delta;

	[Address(RVA="0xF030F4", Offset="0xF030F4", VA="0xF030F4")]
	public DBuyStoreItemInventoryDeltaAction(InventoryDelta delta)
	{
	}
}