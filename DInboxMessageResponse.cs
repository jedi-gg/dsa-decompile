using Il2CppDummyDll;
using System;

public struct DInboxMessageResponse
{
	[FieldOffset(Offset="0x0")]
	public readonly string MessageId;

	[FieldOffset(Offset="0x8")]
	public readonly DInboxMessageResponse.ActionType Type;

	[FieldOffset(Offset="0xC")]
	public readonly bool Success;

	[Address(RVA="0xEFDCE4", Offset="0xEFDCE4", VA="0xEFDCE4")]
	public DInboxMessageResponse(string messageId, DInboxMessageResponse.ActionType type, bool success)
	{
	}

	public enum ActionType
	{
		[FieldOffset(Offset="0x0")]
		MarkAsRead,
		[FieldOffset(Offset="0x0")]
		MarkAsClaimed,
		[FieldOffset(Offset="0x0")]
		MarkAsDeleted
	}
}