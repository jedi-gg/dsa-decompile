using Il2CppDummyDll;
using System;

public struct DUnitSkinAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DUnitSkinAction.Type ActionType;

	[FieldOffset(Offset="0x4")]
	public readonly int SkinDefIndex;

	[Address(RVA="0xEFFF10", Offset="0xEFFF10", VA="0xEFFF10")]
	public DUnitSkinAction(DUnitSkinAction.Type actionType, int skinDefIndex)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Equip,
		[FieldOffset(Offset="0x0")]
		Unequip,
		[FieldOffset(Offset="0x0")]
		Find
	}
}