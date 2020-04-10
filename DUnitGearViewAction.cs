using Il2CppDummyDll;
using System;

public struct DUnitGearViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DUnitGearViewAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public ulong ItemId;

	[Address(RVA="0xEFFD94", Offset="0xEFFD94", VA="0xEFFD94")]
	public DUnitGearViewAction(DUnitGearViewAction.Type actionType, ulong itemId)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Equip,
		[FieldOffset(Offset="0x0")]
		EquipAll,
		[FieldOffset(Offset="0x0")]
		TierUp,
		[FieldOffset(Offset="0x0")]
		ClubDonateRequest,
		[FieldOffset(Offset="0x0")]
		BuyAndEquip,
		[FieldOffset(Offset="0x0")]
		BuyAndEquipAll
	}
}