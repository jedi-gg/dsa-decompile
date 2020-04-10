using Il2CppDummyDll;
using Serverproto;
using System;

public struct DShipmentItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DShipmentItemAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly Serverproto.ShipmentItem ShipmentItem;

	[Address(RVA="0xEFF37C", Offset="0xEFF37C", VA="0xEFF37C")]
	public DShipmentItemAction(DShipmentItemAction.Type actionType, Serverproto.ShipmentItem shipmentItem)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Inspect,
		[FieldOffset(Offset="0x0")]
		Purchase
	}
}