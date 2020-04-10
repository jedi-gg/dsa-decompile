using Il2CppDummyDll;
using System;
using UnityEngine;

public class ChatPreviewMessageListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private UiLabel _messageLabel;

	[Address(RVA="0x11A0700", Offset="0x11A0700", VA="0x11A0700")]
	public ChatPreviewMessageListItem()
	{
	}

	[Address(RVA="0x11A06C4", Offset="0x11A06C4", VA="0x11A06C4")]
	public void SetData(string message)
	{
	}
}