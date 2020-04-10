using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatView : AStandardView
{
	[FieldOffset(Offset="0x0")]
	private const int MESSAGE_POOL_INITIAL_SIZE = 20;

	[FieldOffset(Offset="0x68")]
	private IReadOnlyList<ChatDomainController.Channel> _channels;

	[FieldOffset(Offset="0x70")]
	private ChatDomainController.Channel _selectedChannel;

	[FieldOffset(Offset="0x78")]
	private MonoArchetypePool<ChatMessageListItem> _messagePool;

	[FieldOffset(Offset="0x80")]
	private List<ChatChannelListItem> _channelListItems;

	public RectTransform FeedBounds
	{
		[Address(RVA="0x119890C", Offset="0x119890C", VA="0x119890C")]
		get
		{
			return null;
		}
	}

	private ChatView.SerializedFields Fields
	{
		[Address(RVA="0x11A216C", Offset="0x11A216C", VA="0x11A216C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11A3CD0", Offset="0x11A3CD0", VA="0x11A3CD0")]
	public ChatView()
	{
	}

	[Address(RVA="0x11A3CD8", Offset="0x11A3CD8", VA="0x11A3CD8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EACC", Offset="0x106EACC")]
	private void <ViewAssetLoaded>b__8_0()
	{
	}

	[Address(RVA="0x1197634", Offset="0x1197634", VA="0x1197634")]
	public ChatMessageListItem AddMessage(ChatMessage message)
	{
		return null;
	}

	[Address(RVA="0x11A3374", Offset="0x11A3374", VA="0x11A3374")]
	private ChatMessageListItem AppendMessageListItem(ChatMessage chatMessage)
	{
		return null;
	}

	[Address(RVA="0x1198F70", Offset="0x1198F70", VA="0x1198F70")]
	public void ClearInputField()
	{
	}

	[Address(RVA="0x11A26A8", Offset="0x11A26A8", VA="0x11A26A8")]
	private void InitializeChannelList()
	{
	}

	[Address(RVA="0x11A2FA4", Offset="0x11A2FA4", VA="0x11A2FA4")]
	private void InstantiateMessages()
	{
	}

	[Address(RVA="0x1198D44", Offset="0x1198D44", VA="0x1198D44")]
	public void LoadEmotes(List<Gamedata.InventoryItem> emotes)
	{
	}

	[Address(RVA="0x11A3C60", Offset="0x11A3C60", VA="0x11A3C60")]
	private void RemoveMessageListItem(ChatMessageListItem messageListItem)
	{
	}

	[Address(RVA="0x11A2E44", Offset="0x11A2E44", VA="0x11A2E44")]
	private void SelectChannelListItem()
	{
	}

	[Address(RVA="0x11A2BF8", Offset="0x11A2BF8", VA="0x11A2BF8")]
	private void SetAllowMessageSending()
	{
	}

	[Address(RVA="0x11987B8", Offset="0x11987B8", VA="0x11987B8")]
	public void SetChannels(IReadOnlyList<ChatDomainController.Channel> channels)
	{
	}

	[Address(RVA="0x1197BC4", Offset="0x1197BC4", VA="0x1197BC4")]
	public void SetSelectedChannel(ChatDomainController.Channel channel)
	{
	}

	[Address(RVA="0x11A224C", Offset="0x11A224C", VA="0x11A224C")]
	private void ShutdownChannelList()
	{
	}

	[Address(RVA="0x11A3BBC", Offset="0x11A3BBC", VA="0x11A3BBC")]
	private void SubmitMessage(string messageText)
	{
	}

	[Address(RVA="0x11974BC", Offset="0x11974BC", VA="0x11974BC")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x11A3ADC", Offset="0x11A3ADC", VA="0x11A3ADC")]
	private char ValidateInput(string text, int charIndex, char addedChar)
	{
		return new char();
	}

	[Address(RVA="0x11A367C", Offset="0x11A367C", VA="0x11A367C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11A3998", Offset="0x11A3998", VA="0x11A3998", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public UiInputField InputField;

		[FieldOffset(Offset="0x30")]
		public ChatMessageListItem MessageTemplate;

		[FieldOffset(Offset="0x38")]
		public ChatChannelListItem ChannelButtonTemplate;

		[FieldOffset(Offset="0x40")]
		public ChatChannelListGroupHeading ChannelGroupHeadingTemplate;

		[FieldOffset(Offset="0x48")]
		public ScrollRect ChannelScrollRect;

		[FieldOffset(Offset="0x50")]
		public ChatFeedScrollRect FeedScrollRect;

		[FieldOffset(Offset="0x58")]
		public Button ChatSettingsPopupButton;

		[FieldOffset(Offset="0x60")]
		public UnityEngine.GameObject NoInputFillerImage;

		[Attribute(Name="HeaderAttribute", RVA="0x1069E94", Offset="0x1069E94")]
		[FieldOffset(Offset="0x68")]
		public Toggle KeyboardToggle;

		[FieldOffset(Offset="0x70")]
		public EmoteKeyboardWidget EmoteKeyboard;

		[Address(RVA="0x11A3DB0", Offset="0x11A3DB0", VA="0x11A3DB0")]
		public SerializedFields()
		{
		}
	}
}