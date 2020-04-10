using Il2CppDummyDll;
using Serverproto;
using System;

public struct DStoreItemGrantOddsPopupOptionAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DStoreItemGrantOddsPopupOptionAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly StoreItemGrantOption Option;

	[Address(RVA="0xEFF914", Offset="0xEFF914", VA="0xEFF914")]
	public DStoreItemGrantOddsPopupOptionAction(DStoreItemGrantOddsPopupOptionAction.Type actionType, StoreItemGrantOption option)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Clicked
	}
}