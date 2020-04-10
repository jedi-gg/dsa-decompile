using Il2CppDummyDll;
using System;

public struct DInAppBrowserAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DInAppBrowserAction.Type ActionType;

	[Address(RVA="0xEFDBD0", Offset="0xEFDBD0", VA="0xEFDBD0")]
	public DInAppBrowserAction(DInAppBrowserAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		FinishedLoading,
		[FieldOffset(Offset="0x0")]
		HadError
	}
}