using Il2CppDummyDll;
using System;

public struct DChatViewSendMessageAction
{
	[FieldOffset(Offset="0x0")]
	public readonly string MessageText;

	[FieldOffset(Offset="0x8")]
	public readonly ChatDomainController.Channel Channel;

	[Address(RVA="0xF03608", Offset="0xF03608", VA="0xF03608")]
	public DChatViewSendMessageAction(string text, ChatDomainController.Channel channel)
	{
	}
}