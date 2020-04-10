using Il2CppDummyDll;
using System;

public struct DStoreItemDetailsViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DStoreItemDetailsViewAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly ulong CostItemId;

	[Address(RVA="0xEFF8BC", Offset="0xEFF8BC", VA="0xEFF8BC")]
	public DStoreItemDetailsViewAction(DStoreItemDetailsViewAction.Type actionType, ulong costItemId = 0L)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Buy,
		[FieldOffset(Offset="0x0")]
		ShowOdds
	}
}