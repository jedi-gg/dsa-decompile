using Il2CppDummyDll;
using Serverproto;
using System;

public struct DDirectBuyAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ItemFindShipment ShipmentItem;

	[FieldOffset(Offset="0x8")]
	public readonly DDirectBuyAction.Type ActionType;

	[Address(RVA="0xF04CEC", Offset="0xF04CEC", VA="0xF04CEC")]
	public DDirectBuyAction(ItemFindShipment shipmentItem, DDirectBuyAction.Type actionType = 0)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Buy,
		[FieldOffset(Offset="0x0")]
		Update
	}
}