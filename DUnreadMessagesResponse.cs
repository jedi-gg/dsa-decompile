using Il2CppDummyDll;
using System;

public struct DUnreadMessagesResponse
{
	[FieldOffset(Offset="0x0")]
	public InboxMessageType Type;

	[FieldOffset(Offset="0x4")]
	public uint Count;

	[Address(RVA="0xEFFFDC", Offset="0xEFFFDC", VA="0xEFFFDC")]
	public DUnreadMessagesResponse(InboxMessageType type, uint count)
	{
	}
}