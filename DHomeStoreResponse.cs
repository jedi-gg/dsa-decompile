using Il2CppDummyDll;
using Serverproto;
using System;

public struct DHomeStoreResponse
{
	[FieldOffset(Offset="0x0")]
	public readonly int FreeItemCount;

	[FieldOffset(Offset="0x8")]
	public readonly StoreResponse Store;

	[Address(RVA="0xEFD9C0", Offset="0xEFD9C0", VA="0xEFD9C0")]
	public DHomeStoreResponse(HomeStoreResponse homeStore)
	{
	}
}