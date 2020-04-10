using Il2CppDummyDll;
using System;

public struct DHomeBattleSelectionViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DHomeBattleSelectionViewAction.Type ActionType;

	[Address(RVA="0xEFD5FC", Offset="0xEFD5FC", VA="0xEFD5FC")]
	public DHomeBattleSelectionViewAction(DHomeBattleSelectionViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Hero,
		[FieldOffset(Offset="0x0")]
		Villain,
		[FieldOffset(Offset="0x0")]
		Grand,
		[FieldOffset(Offset="0x0")]
		Pvp
	}
}