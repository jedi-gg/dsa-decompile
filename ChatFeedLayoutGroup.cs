using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatFeedLayoutGroup : LayoutGroup
{
	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private float _spacing;

	[FieldOffset(Offset="0x60")]
	private List<ChatMessageListItem> _chatMessageListItems;

	[Address(RVA="0x119D7D4", Offset="0x119D7D4", VA="0x119D7D4")]
	public ChatFeedLayoutGroup()
	{
	}

	[Address(RVA="0x119CDA4", Offset="0x119CDA4", VA="0x119CDA4", Slot="28")]
	public override void CalculateLayoutInputHorizontal()
	{
	}

	[Address(RVA="0x119CE94", Offset="0x119CE94", VA="0x119CE94", Slot="29")]
	public override void CalculateLayoutInputVertical()
	{
	}

	[Address(RVA="0x119D2D4", Offset="0x119D2D4", VA="0x119D2D4", Slot="37")]
	public override void SetLayoutHorizontal()
	{
	}

	[Address(RVA="0x119D2D8", Offset="0x119D2D8", VA="0x119D2D8", Slot="38")]
	public override void SetLayoutVertical()
	{
	}
}