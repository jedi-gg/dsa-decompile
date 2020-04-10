using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ChatController : AFeatureController, IDispatchHandler<DChatMessageAddedToChannelAction>, IDispatchHandler, IDispatchHandler<DChatViewSendMessageAction>, IDispatchHandler<DChatChannelListItemClickedAction>, IDispatchHandler<DChatMessageListItemClickedAction>, IDispatchHandler<DSendEmoteAction>, IDispatchHandler<DChatChannelsChangedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1055A68", Offset="0x1055A68")]
	[FieldOffset(Offset="0x68")]
	private DialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x1055A78", Offset="0x1055A78")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1055A88", Offset="0x1055A88")]
	[FieldOffset(Offset="0x78")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1055A98", Offset="0x1055A98")]
	[FieldOffset(Offset="0x80")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1055AA8", Offset="0x1055AA8")]
	[FieldOffset(Offset="0x88")]
	private ChatDomainController _chatDc;

	[Attribute(Name="InjectAttribute", RVA="0x1055AB8", Offset="0x1055AB8")]
	[FieldOffset(Offset="0x90")]
	private ChatService _chatService;

	[Attribute(Name="InjectAttribute", RVA="0x1055AC8", Offset="0x1055AC8")]
	[FieldOffset(Offset="0x98")]
	private ClubServiceUtility _clubServiceUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1055AD8", Offset="0x1055AD8")]
	[FieldOffset(Offset="0xA0")]
	private ClubDomainController _clubDc;

	[Attribute(Name="InjectAttribute", RVA="0x1055AE8", Offset="0x1055AE8")]
	[FieldOffset(Offset="0xA8")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x1055AF8", Offset="0x1055AF8")]
	[FieldOffset(Offset="0xB0")]
	private PlayerServiceUtility _playerServiceUtility;

	[FieldOffset(Offset="0xB8")]
	private ChatView _view;

	[FieldOffset(Offset="0xC0")]
	private ChatDomainController.Channel _selectedChannel;

	[FieldOffset(Offset="0xC8")]
	private bool _sendInProgress;

	[FieldOffset(Offset="0xD0")]
	private List<Friend> _friends;

	[Address(RVA="0x1198EF0", Offset="0x1198EF0", VA="0x1198EF0")]
	public ChatController()
	{
	}

	[Address(RVA="0x119906C", Offset="0x119906C", VA="0x119906C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EA38", Offset="0x106EA38")]
	private void <RequestFriendsList>b__15_0(FriendsListResponse response)
	{
	}

	[Address(RVA="0x11990F8", Offset="0x11990F8", VA="0x11990F8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EA48", Offset="0x106EA48")]
	private void <RequestFriendsList>b__15_1(long failureCode)
	{
	}

	[Address(RVA="0x1198F60", Offset="0x1198F60", VA="0x1198F60")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EA18", Offset="0x106EA18")]
	private void <SendMessage>b__10_0(ChatMessageResponse response)
	{
	}

	[Address(RVA="0x1199000", Offset="0x1199000", VA="0x1199000")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EA28", Offset="0x106EA28")]
	private void <SendMessage>b__10_2()
	{
	}

	[Address(RVA="0x1198748", Offset="0x1198748", VA="0x1198748", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x11975EC", Offset="0x11975EC", VA="0x11975EC", Slot="13")]
	public void HandleDispatchAction(DChatMessageAddedToChannelAction action)
	{
	}

	[Address(RVA="0x1197840", Offset="0x1197840", VA="0x1197840", Slot="14")]
	public void HandleDispatchAction(DChatViewSendMessageAction action)
	{
	}

	[Address(RVA="0x1197B24", Offset="0x1197B24", VA="0x1197B24", Slot="15")]
	public void HandleDispatchAction(DChatChannelListItemClickedAction action)
	{
	}

	[Address(RVA="0x1197C30", Offset="0x1197C30", VA="0x1197C30", Slot="16")]
	public void HandleDispatchAction(DChatMessageListItemClickedAction action)
	{
	}

	[Address(RVA="0x11984B4", Offset="0x11984B4", VA="0x11984B4", Slot="17")]
	public void HandleDispatchAction(DSendEmoteAction action)
	{
	}

	[Address(RVA="0x1198550", Offset="0x1198550", VA="0x1198550", Slot="18")]
	public void HandleDispatchAction(DChatChannelsChangedAction action)
	{
	}

	[Address(RVA="0x11971D0", Offset="0x11971D0", VA="0x11971D0", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x1198998", Offset="0x1198998", VA="0x1198998")]
	private void LoadEmotes()
	{
	}

	[Address(RVA="0x1198354", Offset="0x1198354", VA="0x1198354")]
	private void PerformMessageAction(ChatMessage message)
	{
	}

	[Address(RVA="0x1198D8C", Offset="0x1198D8C", VA="0x1198D8C")]
	private void RequestFriendsList(Action finished)
	{
	}

	[Address(RVA="0x1198554", Offset="0x1198554", VA="0x1198554")]
	private void SelectDefaultChannel()
	{
	}

	[Address(RVA="0x1197844", Offset="0x1197844", VA="0x1197844")]
	private void SendMessage(string messageText, ChatDomainController.Channel channel)
	{
	}

	[Address(RVA="0x1197D84", Offset="0x1197D84", VA="0x1197D84")]
	private void ShowPlayerPopupMenu(string channelName, string playerId, string playerUsername, string messageId, ulong messageTimestamp, RectTransform where)
	{
	}

	[Address(RVA="0x1197580", Offset="0x1197580", VA="0x1197580", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x1197444", Offset="0x1197444", VA="0x1197444", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B54C", Offset="0x104B54C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static ChatController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<long> <>9__10_1;

		[Address(RVA="0x11991B8", Offset="0x11991B8", VA="0x11991B8")]
		static <>c()
		{
		}

		[Address(RVA="0x119921C", Offset="0x119921C", VA="0x119921C")]
		public <>c()
		{
		}

		[Address(RVA="0x1199224", Offset="0x1199224", VA="0x1199224")]
		internal void <SendMessage>b__10_1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B52C", Offset="0x104B52C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ChatController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x119743C", Offset="0x119743C", VA="0x119743C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1199228", Offset="0x1199228", VA="0x1199228")]
		internal void <Initialize>b__0(Action finished)
		{
		}

		[Address(RVA="0x119931C", Offset="0x119931C", VA="0x119931C")]
		internal void <Initialize>b__1()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B53C", Offset="0x104B53C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action finished;

		[FieldOffset(Offset="0x18")]
		public ChatController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x1199314", Offset="0x1199314", VA="0x1199314")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x119940C", Offset="0x119940C", VA="0x119940C")]
		internal void <Initialize>b__2(ChatView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B55C", Offset="0x104B55C")]
	private sealed class <>c__DisplayClass12_0
	{
		[FieldOffset(Offset="0x10")]
		public ChatController <>4__this;

		[FieldOffset(Offset="0x18")]
		public string playerId;

		[FieldOffset(Offset="0x20")]
		public string playerUsername;

		[FieldOffset(Offset="0x28")]
		public string messageId;

		[FieldOffset(Offset="0x30")]
		public string channelName;

		[FieldOffset(Offset="0x38")]
		public ulong messageTimestamp;

		[FieldOffset(Offset="0x40")]
		public Action <>9__6;

		[FieldOffset(Offset="0x48")]
		public Action<BlockChatUserResponse> <>9__7;

		[FieldOffset(Offset="0x50")]
		public Action<long> <>9__8;

		[FieldOffset(Offset="0x58")]
		public Action<ChatReportResponse> <>9__9;

		[FieldOffset(Offset="0x60")]
		public Action<long> <>9__10;

		[Address(RVA="0x1198904", Offset="0x1198904", VA="0x1198904")]
		public <>c__DisplayClass12_0()
		{
		}

		[Address(RVA="0x11994C4", Offset="0x11994C4", VA="0x11994C4")]
		internal void <ShowPlayerPopupMenu>b__0()
		{
		}

		[Address(RVA="0x1199550", Offset="0x1199550", VA="0x1199550")]
		internal bool <ShowPlayerPopupMenu>b__1(Friend f)
		{
			return new bool();
		}

		[Address(RVA="0x1199ED0", Offset="0x1199ED0", VA="0x1199ED0")]
		internal void <ShowPlayerPopupMenu>b__10(long errorCode)
		{
		}

		[Address(RVA="0x11995A8", Offset="0x11995A8", VA="0x11995A8")]
		internal void <ShowPlayerPopupMenu>b__2()
		{
		}

		[Address(RVA="0x1199800", Offset="0x1199800", VA="0x1199800")]
		internal void <ShowPlayerPopupMenu>b__3()
		{
		}

		[Address(RVA="0x1199B9C", Offset="0x1199B9C", VA="0x1199B9C")]
		internal void <ShowPlayerPopupMenu>b__4()
		{
		}

		[Address(RVA="0x1199F94", Offset="0x1199F94", VA="0x1199F94")]
		internal void <ShowPlayerPopupMenu>b__5()
		{
		}

		[Address(RVA="0x11996E4", Offset="0x11996E4", VA="0x11996E4")]
		internal void <ShowPlayerPopupMenu>b__6()
		{
		}

		[Address(RVA="0x1199980", Offset="0x1199980", VA="0x1199980")]
		internal void <ShowPlayerPopupMenu>b__7(BlockChatUserResponse response)
		{
		}

		[Address(RVA="0x1199AD8", Offset="0x1199AD8", VA="0x1199AD8")]
		internal void <ShowPlayerPopupMenu>b__8(long errorCode)
		{
		}

		[Address(RVA="0x1199DA8", Offset="0x1199DA8", VA="0x1199DA8")]
		internal void <ShowPlayerPopupMenu>b__9(ChatReportResponse response)
		{
		}
	}
}