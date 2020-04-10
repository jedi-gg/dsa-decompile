using Il2CppDummyDll;
using System;

public struct DAbilityCardSelectAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DAbilityCardSelectAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly BattleAbilityCardData CardData;

	[Address(RVA="0xF02330", Offset="0xF02330", VA="0xF02330")]
	public DAbilityCardSelectAction(DAbilityCardSelectAction.Type actionType, BattleAbilityCardData cardData)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Selected,
		[FieldOffset(Offset="0x0")]
		Deselected
	}
}