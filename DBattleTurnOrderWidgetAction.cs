using Il2CppDummyDll;
using System;

public struct DBattleTurnOrderWidgetAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleTurnOrderWidgetAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly BattleTurnOrderUnitWidget Widget;

	[Address(RVA="0xF02FA4", Offset="0xF02FA4", VA="0xF02FA4")]
	public DBattleTurnOrderWidgetAction(DBattleTurnOrderWidgetAction.Type actionType, BattleTurnOrderUnitWidget widget)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Clicked
	}
}