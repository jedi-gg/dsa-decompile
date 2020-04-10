using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class ChatDomainController : ILoggable<LogCategory>, IDispatchHandler<DChatDynamicMessageAction>, IDispatchHandler, IDispatchHandler<DPlayerChangeProcessedAction>, IDispatchHandler<DPlayerClubChangeProcessedAction>, IDispatchHandler<DChatHistoryChangeAction>, IDispatchHandler<DChatDeleteMessageAction>
{
	[FieldOffset(Offset="0x0")]
	public const string MESSAGE_EMOTE_PREFIX = "emote:";

	[FieldOffset(Offset="0x0")]
	public const int MAX_MESSAGES_PER_CHANNEL = 80;

	[Attribute(Name="InjectAttribute", RVA="0x1055B08", Offset="0x1055B08")]
	[FieldOffset(Offset="0x10")]
	private ProfanityFilter _profanityFilter;

	[Attribute(Name="InjectAttribute", RVA="0x1055B18", Offset="0x1055B18")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1055B28", Offset="0x1055B28")]
	[FieldOffset(Offset="0x20")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1055B38", Offset="0x1055B38")]
	[FieldOffset(Offset="0x28")]
	private SystemMessageUtil _systemMessageUtil;

	[Attribute(Name="InjectAttribute", RVA="0x1055B48", Offset="0x1055B48")]
	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1055B58", Offset="0x1055B58")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x40")]
	private bool _processingThreadRunning;

	[FieldOffset(Offset="0x48")]
	private Queue<ChatMessage> _messageProcessingQueue;

	[FieldOffset(Offset="0x50")]
	private Queue<ChatMessage> _messagesFinishedProcessing;

	[FieldOffset(Offset="0x58")]
	private List<ChatDomainController.Channel> _activeChannels;

	[FieldOffset(Offset="0x60")]
	private ChatChannelType _defaultPreviewMode;

	public IReadOnlyList<ChatDomainController.Channel> Channels
	{
		[Address(RVA="0x11987B0", Offset="0x11987B0", VA="0x11987B0")]
		get
		{
			return null;
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x119A050", Offset="0x119A050", VA="0x119A050", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x119C1A8", Offset="0x119C1A8", VA="0x119C1A8")]
	public ChatDomainController()
	{
	}

	[Address(RVA="0x119C268", Offset="0x119C268", VA="0x119C268")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EABC", Offset="0x106EABC")]
	private void <StartProcessIncomingMessagesThread>b__19_0()
	{
	}

	[Address(RVA="0x119BFC4", Offset="0x119BFC4", VA="0x119BFC4")]
	public static ChatDomainController.Channel FindChannel(List<ChatDomainController.Channel> channels, ChatChannelType channelType, string channelName)
	{
		return null;
	}

	[Address(RVA="0x119AA70", Offset="0x119AA70", VA="0x119AA70")]
	public ChatDomainController.Channel GetChannelForType(ChatChannelType channelType)
	{
		return null;
	}

	[Address(RVA="0x119A9E8", Offset="0x119A9E8", VA="0x119A9E8")]
	public ChatChannelType GetDefaultPreviewMode()
	{
		return new ChatChannelType();
	}

	[Address(RVA="0x119ABA8", Offset="0x119ABA8", VA="0x119ABA8", Slot="5")]
	public void HandleDispatchAction(DChatDynamicMessageAction action)
	{
	}

	[Address(RVA="0x119AC90", Offset="0x119AC90", VA="0x119AC90", Slot="6")]
	public void HandleDispatchAction(DPlayerChangeProcessedAction action)
	{
	}

	[Address(RVA="0x119B2A0", Offset="0x119B2A0", VA="0x119B2A0", Slot="7")]
	public void HandleDispatchAction(DPlayerClubChangeProcessedAction action)
	{
	}

	[Address(RVA="0x119B2A8", Offset="0x119B2A8", VA="0x119B2A8", Slot="8")]
	public void HandleDispatchAction(DChatHistoryChangeAction action)
	{
	}

	[Address(RVA="0x119B868", Offset="0x119B868", VA="0x119B868", Slot="9")]
	public void HandleDispatchAction(DChatDeleteMessageAction action)
	{
	}

	[Address(RVA="0x119A058", Offset="0x119A058", VA="0x119A058")]
	public void Initialize()
	{
	}

	[Address(RVA="0x11987E0", Offset="0x11987E0", VA="0x11987E0")]
	public bool IsInChannel(ChatDomainController.Channel channel)
	{
		return new bool();
	}

	[Address(RVA="0x119AC98", Offset="0x119AC98", VA="0x119AC98")]
	private void RefreshChannels(bool retainHistory)
	{
	}

	[Address(RVA="0x119BB40", Offset="0x119BB40", VA="0x119BB40")]
	private static void RemoveMessageFromQueue(Queue<ChatMessage> messages, string messageId, string playerId)
	{
	}

	[Address(RVA="0x1197C28", Offset="0x1197C28", VA="0x1197C28")]
	public void SetDefaultPreviewMode(ChatChannelType mode)
	{
	}

	[Address(RVA="0x119A15C", Offset="0x119A15C", VA="0x119A15C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x119A094", Offset="0x119A094", VA="0x119A094")]
	[Attribute(Name="AsyncStateMachineAttribute", RVA="0x106EA58", Offset="0x106EA58")]
	private void StartProcessIncomingMessagesThread()
	{
	}

	[Address(RVA="0x119A344", Offset="0x119A344", VA="0x119A344")]
	public void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B56C", Offset="0x104B56C")]
	private struct <StartProcessIncomingMessagesThread>d__19 : IAsyncStateMachine
	{
		[FieldOffset(Offset="0x0")]
		public int <>1__state;

		[FieldOffset(Offset="0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[FieldOffset(Offset="0x28")]
		public ChatDomainController <>4__this;

		[FieldOffset(Offset="0x30")]
		private TaskAwaiter <>u__1;

		[Address(RVA="0xEFD01C", Offset="0xEFD01C", VA="0xEFD01C", Slot="4")]
		private void MoveNext()
		{
		}

		[Address(RVA="0xEFD024", Offset="0xEFD024", VA="0xEFD024", Slot="5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public class Channel
	{
		[FieldOffset(Offset="0x10")]
		public readonly ChatChannelType ChannelType;

		[FieldOffset(Offset="0x18")]
		public readonly string ChannelName;

		[FieldOffset(Offset="0x20")]
		public string DisplayName;

		[FieldOffset(Offset="0x28")]
		public string Icon;

		[FieldOffset(Offset="0x30")]
		private List<ChatMessage> _messages;

		public IReadOnlyList<ChatMessage> Messages
		{
			[Address(RVA="0x119CC90", Offset="0x119CC90", VA="0x119CC90")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x119C11C", Offset="0x119C11C", VA="0x119C11C")]
		public Channel(ChatChannelType channelType, string channelId)
		{
		}

		[Address(RVA="0x119B808", Offset="0x119B808", VA="0x119B808")]
		public void ClearMessages()
		{
		}

		[Address(RVA="0x119CC98", Offset="0x119CC98", VA="0x119CC98")]
		public ChatMessage GetMostRecentMessage()
		{
			return null;
		}

		[Address(RVA="0x119CD34", Offset="0x119CD34", VA="0x119CD34")]
		private int InsertionSortMessages(ChatMessage a, ChatMessage b)
		{
			return new int();
		}

		[Address(RVA="0x119BE34", Offset="0x119BE34", VA="0x119BE34")]
		public bool RemoveMessages(string messageId, string playerId)
		{
			return new bool();
		}

		[Address(RVA="0x119A720", Offset="0x119A720", VA="0x119A720")]
		public bool TryAddMessage(ChatMessage msg)
		{
			return new bool();
		}
	}
}