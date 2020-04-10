using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public struct DChatHistoryChangeAction
{
	[FieldOffset(Offset="0x0")]
	public IReadOnlyList<ChatMessage> ChatHistory;

	[Address(RVA="0xF03508", Offset="0xF03508", VA="0xF03508")]
	public DChatHistoryChangeAction(IReadOnlyList<ChatMessage> chatHistory)
	{
	}
}