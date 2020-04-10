using Il2CppDummyDll;
using System;

public struct DInboxMessagePopupViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DInboxMessagePopupViewAction.Type ActionType;

	[Address(RVA="0xEFDC34", Offset="0xEFDC34", VA="0xEFDC34")]
	public DInboxMessagePopupViewAction(DInboxMessagePopupViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		ClaimAttachments,
		[FieldOffset(Offset="0x0")]
		DeleteMessage,
		[FieldOffset(Offset="0x0")]
		FollowDeepLink
	}
}