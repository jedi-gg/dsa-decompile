using Il2CppDummyDll;
using Serverproto;
using System;

public struct DStoreResponseAction
{
	[FieldOffset(Offset="0x0")]
	public StoreResponse Store;

	[Address(RVA="0xEFF9C4", Offset="0xEFF9C4", VA="0xEFF9C4")]
	public DStoreResponseAction(StoreResponse store)
	{
	}
}