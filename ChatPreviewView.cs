using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatPreviewView : AStandardView
{
	[FieldOffset(Offset="0x0")]
	private const int MAX_PREVIEW_MESSAGES = 3;

	[FieldOffset(Offset="0x0")]
	private const float MSG_SCROLL_DURATION_S = 0.2f;

	[FieldOffset(Offset="0x68")]
	private List<string> _chatMessages;

	private ChatPreviewView.SerializedFields Fields
	{
		[Address(RVA="0x11A0708", Offset="0x11A0708", VA="0x11A0708")]
		get
		{
			return null;
		}
	}

	protected override bool WillHandleBackButton
	{
		[Address(RVA="0x11A0AC0", Offset="0x11A0AC0", VA="0x11A0AC0", Slot="19")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11A0AC8", Offset="0x11A0AC8", VA="0x11A0AC8")]
	public ChatPreviewView()
	{
	}

	[Address(RVA="0x11A0B3C", Offset="0x11A0B3C", VA="0x11A0B3C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EADC", Offset="0x106EADC")]
	private void <ViewAssetLoaded>b__3_0()
	{
	}

	[Address(RVA="0x11A03E4", Offset="0x11A03E4", VA="0x11A03E4")]
	public void AddChatMessage(string msg)
	{
	}

	[Address(RVA="0x11A09C4", Offset="0x11A09C4", VA="0x11A09C4")]
	private void BindChatMessageListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x119FFC0", Offset="0x119FFC0", VA="0x119FFC0")]
	public void ClearMessages()
	{
	}

	[Address(RVA="0x119FB00", Offset="0x119FB00", VA="0x119FB00")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x11A07E8", Offset="0x11A07E8", VA="0x11A07E8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11A0920", Offset="0x11A0920", VA="0x11A0920", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public UnityEngine.GameObject ChatContainer;

		[FieldOffset(Offset="0x30")]
		public Button ChatButton;

		[FieldOffset(Offset="0x38")]
		public WrappedScrollRect ChatScrollRect;

		[Address(RVA="0x11A0BA0", Offset="0x11A0BA0", VA="0x11A0BA0")]
		public SerializedFields()
		{
		}
	}
}