using Il2CppDummyDll;
using System;

public struct DVipUpgradePreviewViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DVipUpgradePreviewViewAction.Type ActionType;

	[Address(RVA="0xF0008C", Offset="0xF0008C", VA="0xF0008C")]
	public DVipUpgradePreviewViewAction(DVipUpgradePreviewViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Buy
	}
}