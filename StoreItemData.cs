using Il2CppDummyDll;
using Serverproto;
using System;

public class StoreItemData
{
	[FieldOffset(Offset="0x10")]
	public readonly StoreItem Item;

	[FieldOffset(Offset="0x18")]
	public readonly string PlatformIapProductId;

	[FieldOffset(Offset="0x20")]
	public readonly DateTime? Expiry;

	[Address(RVA="0x1232140", Offset="0x1232140", VA="0x1232140")]
	public StoreItemData(StoreItem item)
	{
	}

	[Address(RVA="0x1231D3C", Offset="0x1231D3C", VA="0x1231D3C")]
	public bool DoesItemHaveGuaranteedDrop(ulong itemId)
	{
		return new bool();
	}

	[Address(RVA="0x1231A10", Offset="0x1231A10", VA="0x1231A10")]
	public ValueTuple<ulong, ulong> GetItemCountRange(ulong itemId)
	{
		return new ValueTuple<ulong, ulong>();
	}
}