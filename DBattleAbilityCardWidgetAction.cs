using Il2CppDummyDll;
using System;

public struct DBattleAbilityCardWidgetAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleAbilityCardWidgetAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly BattleAbilityCardWidget BattleAbilityCard;

	[Address(RVA="0xF02894", Offset="0xF02894", VA="0xF02894")]
	public DBattleAbilityCardWidgetAction(DBattleAbilityCardWidgetAction.Type actionType, BattleAbilityCardWidget battleAbilityCard)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Click,
		[FieldOffset(Offset="0x0")]
		LongPress
	}
}