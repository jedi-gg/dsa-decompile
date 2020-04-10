using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public struct DInboxFetchResponse
{
	[FieldOffset(Offset="0x0")]
	public readonly bool Success;

	[FieldOffset(Offset="0x8")]
	public readonly IReadOnlyList<InboxMessage> Messages;

	[Address(RVA="0xEFDC24", Offset="0xEFDC24", VA="0xEFDC24")]
	public DInboxFetchResponse(bool success, IReadOnlyList<InboxMessage> messages)
	{
	}
}