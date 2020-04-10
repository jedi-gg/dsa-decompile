using Il2CppDummyDll;
using Serverproto;
using System;

public struct DChatMessageAddedToChannelAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ChatDomainController.Channel Channel;

	[FieldOffset(Offset="0x8")]
	public readonly Serverproto.ChatMessage ChatMessage;

	[Address(RVA="0xF0355C", Offset="0xF0355C", VA="0xF0355C")]
	public DChatMessageAddedToChannelAction(ChatDomainController.Channel channel, Serverproto.ChatMessage chatMessage)
	{
	}
}