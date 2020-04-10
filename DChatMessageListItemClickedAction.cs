using Il2CppDummyDll;
using Serverproto;
using System;

public struct DChatMessageListItemClickedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DChatMessageListItemClickedAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly ChatMessage Message;

	[FieldOffset(Offset="0x10")]
	public readonly ChatMessageListItem ListItem;

	[Address(RVA="0xF035B0", Offset="0xF035B0", VA="0xF035B0")]
	public DChatMessageListItemClickedAction(DChatMessageListItemClickedAction.Type actionType, ChatMessageListItem listItem, ChatMessage message)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Avatar,
		[FieldOffset(Offset="0x0")]
		Bubble
	}
}