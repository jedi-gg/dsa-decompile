using Il2CppDummyDll;
using System;

public struct DSorcererStoneCraftingViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DSorcererStoneCraftingViewAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly ulong ContentId;

	[Address(RVA="0xEFF5B8", Offset="0xEFF5B8", VA="0xEFF5B8")]
	public DSorcererStoneCraftingViewAction(DSorcererStoneCraftingViewAction.Type actionType, ulong contentId)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Craft,
		[FieldOffset(Offset="0x0")]
		Find
	}
}