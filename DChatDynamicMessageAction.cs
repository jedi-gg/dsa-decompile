using Il2CppDummyDll;
using Serverproto;
using System;

public struct DChatDynamicMessageAction
{
	[FieldOffset(Offset="0x0")]
	public Serverproto.ChatMessage ChatMessage;

	[Address(RVA="0xF034B4", Offset="0xF034B4", VA="0xF034B4")]
	public DChatDynamicMessageAction(Serverproto.ChatMessage chatMessage)
	{
	}
}