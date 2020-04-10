using Il2CppDummyDll;
using System;

public struct DInboxViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DInboxViewAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly string Id;

	[Address(RVA="0xEFDD80", Offset="0xEFDD80", VA="0xEFDD80")]
	public DInboxViewAction(DInboxViewAction.Type actionType, string id)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		OpenMessage,
		[FieldOffset(Offset="0x0")]
		GoToNews
	}
}