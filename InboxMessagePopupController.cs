using Glunies;
using Il2CppDummyDll;
using System;

public class InboxMessagePopupController : APopupController, IDispatchHandler<DInboxMessagePopupViewAction>, IDispatchHandler, IDispatchHandler<DInboxMessageResponse>
{
	[Attribute(Name="InjectAttribute", RVA="0x1059168", Offset="0x1059168")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1059178", Offset="0x1059178")]
	[FieldOffset(Offset="0x40")]
	private InboxService _inboxService;

	[Attribute(Name="InjectAttribute", RVA="0x1059188", Offset="0x1059188")]
	[FieldOffset(Offset="0x48")]
	private LocalizationManager _locManager;

	[FieldOffset(Offset="0x50")]
	private bool _allowHistoryRestore;

	[FieldOffset(Offset="0x58")]
	private InboxViewController.Message _message;

	[FieldOffset(Offset="0x60")]
	private InboxMessagePopupView _view;

	public override bool ShouldBeRestoredFromHistory
	{
		[Address(RVA="0x117EA78", Offset="0x117EA78", VA="0x117EA78", Slot="7")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x117FB04", Offset="0x117FB04", VA="0x117FB04")]
	public InboxMessagePopupController()
	{
	}

	[Address(RVA="0x117EC94", Offset="0x117EC94", VA="0x117EC94", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x117ED28", Offset="0x117ED28", VA="0x117ED28", Slot="14")]
	public void HandleDispatchAction(DInboxMessagePopupViewAction action)
	{
	}

	[Address(RVA="0x117FA2C", Offset="0x117FA2C", VA="0x117FA2C", Slot="15")]
	public void HandleDispatchAction(DInboxMessageResponse action)
	{
	}

	[Address(RVA="0x117EA80", Offset="0x117EA80", VA="0x117EA80", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x117EBDC", Offset="0x117EBDC", VA="0x117EBDC", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C0CC", Offset="0x104C0CC")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public InboxMessagePopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x117EBD4", Offset="0x117EBD4", VA="0x117EBD4")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x117FB14", Offset="0x117FB14", VA="0x117FB14")]
		internal void <Initialize>b__0(InboxMessagePopupView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly InboxViewController.Message Message;

		[Address(RVA="0x117ECFC", Offset="0x117ECFC", VA="0x117ECFC")]
		public Context(InboxViewController.Message message)
		{
		}
	}
}