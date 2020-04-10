using Il2CppDummyDll;
using Serverproto;
using System;

public struct DShipmentViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DShipmentViewAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly Serverproto.Shipment Shipment;

	[Address(RVA="0xEFF3D4", Offset="0xEFF3D4", VA="0xEFF3D4")]
	public DShipmentViewAction(DShipmentViewAction.Type actionType, Serverproto.Shipment shipment)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		ShipmentSelected,
		[FieldOffset(Offset="0x0")]
		PurchaseRefresh,
		[FieldOffset(Offset="0x0")]
		BuyAll
	}
}