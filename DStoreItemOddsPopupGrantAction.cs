using Il2CppDummyDll;
using Serverproto;
using System;

public struct DStoreItemOddsPopupGrantAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DStoreItemOddsPopupGrantAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly StoreItemGrant Grant;

	[Address(RVA="0xEFF96C", Offset="0xEFF96C", VA="0xEFF96C")]
	public DStoreItemOddsPopupGrantAction(DStoreItemOddsPopupGrantAction.Type actionType, StoreItemGrant grant)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Clicked
	}
}