using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class InboxViewController : AFeatureController, IDispatchHandler<DInboxFetchResponse>, IDispatchHandler, IDispatchHandler<DInboxMessageResponse>, IDispatchHandler<DInboxViewAction>, IDispatchHandler<DInventoryDeltaProcessedAction>, IDispatchHandler<DDailyRewardClaimedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1059248", Offset="0x1059248")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1059258", Offset="0x1059258")]
	[FieldOffset(Offset="0x70")]
	private InboxService _inboxService;

	[Attribute(Name="InjectAttribute", RVA="0x1059268", Offset="0x1059268")]
	[FieldOffset(Offset="0x78")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1059278", Offset="0x1059278")]
	[FieldOffset(Offset="0x80")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1059288", Offset="0x1059288")]
	[FieldOffset(Offset="0x88")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1059298", Offset="0x1059298")]
	[FieldOffset(Offset="0x90")]
	private GameLanguageManager _gameLanguageManager;

	[FieldOffset(Offset="0x98")]
	private InboxView _view;

	[FieldOffset(Offset="0xA0")]
	private List<InboxViewController.Message> _messages;

	[Address(RVA="0x1184864", Offset="0x1184864", VA="0x1184864")]
	public InboxViewController()
	{
	}

	[Address(RVA="0x1183570", Offset="0x1183570", VA="0x1183570")]
	private void ConstructMessagesFromProto(IReadOnlyList<Serverproto.InboxMessage> serverMessages)
	{
	}

	[Address(RVA="0x11834C0", Offset="0x11834C0", VA="0x11834C0", Slot="13")]
	public void HandleDispatchAction(DInboxFetchResponse action)
	{
	}

	[Address(RVA="0x118412C", Offset="0x118412C", VA="0x118412C", Slot="14")]
	public void HandleDispatchAction(DInboxMessageResponse action)
	{
	}

	[Address(RVA="0x118436C", Offset="0x118436C", VA="0x118436C", Slot="15")]
	public void HandleDispatchAction(DInboxViewAction action)
	{
	}

	[Address(RVA="0x1184694", Offset="0x1184694", VA="0x1184694", Slot="16")]
	public void HandleDispatchAction(DInventoryDeltaProcessedAction action)
	{
	}

	[Address(RVA="0x1184798", Offset="0x1184798", VA="0x1184798", Slot="17")]
	public void HandleDispatchAction(DDailyRewardClaimedAction action)
	{
	}

	[Address(RVA="0x1183244", Offset="0x1183244", VA="0x1183244", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x11833D8", Offset="0x11833D8", VA="0x11833D8")]
	public void RefreshInbox()
	{
	}

	[Address(RVA="0x1183348", Offset="0x1183348", VA="0x1183348", Slot="7")]
	public override void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C12C", Offset="0x104C12C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public InboxViewController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x1183340", Offset="0x1183340", VA="0x1183340")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11848D4", Offset="0x11848D4", VA="0x11848D4")]
		internal void <Initialize>b__0(InboxView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C13C", Offset="0x104C13C")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public DInboxMessageResponse action;

		[Address(RVA="0x1184364", Offset="0x1184364", VA="0x1184364")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x1184BC4", Offset="0x1184BC4", VA="0x1184BC4")]
		internal bool <HandleDispatchAction>b__0(InboxViewController.Message m)
		{
			return new bool();
		}

		[Address(RVA="0x1184BFC", Offset="0x1184BFC", VA="0x1184BFC")]
		internal bool <HandleDispatchAction>b__1(InboxViewController.Message m)
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C14C", Offset="0x104C14C")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset="0x10")]
		public DInboxViewAction action;

		[Address(RVA="0x118468C", Offset="0x118468C", VA="0x118468C")]
		public <>c__DisplayClass5_0()
		{
		}

		[Address(RVA="0x1184C34", Offset="0x1184C34", VA="0x1184C34")]
		internal bool <HandleDispatchAction>b__0(InboxViewController.Message message)
		{
			return new bool();
		}
	}

	public struct DAttachment
	{
		[FieldOffset(Offset="0x0")]
		public readonly Gamedata.InventoryItem Item;

		[FieldOffset(Offset="0x10")]
		public readonly long Count;

		[Address(RVA="0xEFCEFC", Offset="0xEFCEFC", VA="0xEFCEFC")]
		public DAttachment(Gamedata.InventoryItem item, long count)
		{
		}
	}

	public class Message
	{
		[FieldOffset(Offset="0x10")]
		public readonly string Id;

		[FieldOffset(Offset="0x18")]
		public readonly DateTime Sent;

		[FieldOffset(Offset="0x20")]
		public readonly DateTime Expiry;

		[FieldOffset(Offset="0x28")]
		public readonly string Sender;

		[FieldOffset(Offset="0x30")]
		public readonly string Subject;

		[FieldOffset(Offset="0x38")]
		public readonly string Body;

		[FieldOffset(Offset="0x40")]
		public readonly IReadOnlyList<InboxViewController.DAttachment> Attachments;

		[FieldOffset(Offset="0x48")]
		public readonly DeepLinkLocation DeepLinkLocation;

		[FieldOffset(Offset="0x50")]
		public readonly string DeepLinkSublocation;

		[FieldOffset(Offset="0x58")]
		public readonly ulong TemplateId;

		[FieldOffset(Offset="0x60")]
		public InboxMessageStatus Status;

		[FieldOffset(Offset="0x68")]
		public string[] AdditionalParams;

		[Address(RVA="0x11847BC", Offset="0x11847BC", VA="0x11847BC")]
		public Message(string id, DateTime sent, DateTime expiry, string sender, string subject, string body, List<InboxViewController.DAttachment> attachments, DeepLinkLocation deepLinkLocation, string deepLinkSublocation, ulong templateId, InboxMessageStatus status, string[] additionalParams)
		{
		}
	}
}