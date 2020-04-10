using Il2CppDummyDll;
using System;

public class StoreItemDropDetail
{
	[FieldOffset(Offset="0x10")]
	public ulong ItemId;

	[FieldOffset(Offset="0x18")]
	public ulong CountMin;

	[FieldOffset(Offset="0x20")]
	public ulong CountMax;

	[FieldOffset(Offset="0x28")]
	public bool IsClubGift;

	[Address(RVA="0x130E4D8", Offset="0x130E4D8", VA="0x130E4D8")]
	public StoreItemDropDetail()
	{
	}
}