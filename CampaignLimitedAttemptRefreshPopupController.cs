using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class CampaignLimitedAttemptRefreshPopupController : APopupController, IDispatchHandler<DCampaignLimitedAttemptRefreshPopupViewAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1055898", Offset="0x1055898")]
	[FieldOffset(Offset="0x38")]
	private CampaignUtility _campaignUtility;

	[Attribute(Name="InjectAttribute", RVA="0x10558A8", Offset="0x10558A8")]
	[FieldOffset(Offset="0x40")]
	private CampaignService _campaignService;

	[Attribute(Name="InjectAttribute", RVA="0x10558B8", Offset="0x10558B8")]
	[FieldOffset(Offset="0x48")]
	private TelemetryTranslator _telemetryTranslator;

	[FieldOffset(Offset="0x50")]
	private CampaignLimitedAttemptRefreshPopupController.Context _context;

	[FieldOffset(Offset="0x58")]
	private CampaignLimitedAttemptRefreshPopupView _view;

	[Address(RVA="0x112E2C0", Offset="0x112E2C0", VA="0x112E2C0")]
	public CampaignLimitedAttemptRefreshPopupController()
	{
	}

	[Address(RVA="0x112E0B0", Offset="0x112E0B0", VA="0x112E0B0")]
	private void BuyLimitedAttemptRefresh()
	{
	}

	[Address(RVA="0x112E09C", Offset="0x112E09C", VA="0x112E09C", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x112E0A4", Offset="0x112E0A4", VA="0x112E0A4", Slot="14")]
	public void HandleDispatchAction(DCampaignLimitedAttemptRefreshPopupViewAction action)
	{
	}

	[Address(RVA="0x112DDA4", Offset="0x112DDA4", VA="0x112DDA4", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x112DFE4", Offset="0x112DFE4", VA="0x112DFE4", Slot="9")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x112DFF0", Offset="0x112DFF0", VA="0x112DFF0", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B4EC", Offset="0x104B4EC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public CampaignLimitedAttemptRefreshPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x112DFD4", Offset="0x112DFD4", VA="0x112DFD4")]
		public <>c__DisplayClass0_0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B4FC", Offset="0x104B4FC")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public CampaignUtility.DLimitedAttemptInfo info;

		[FieldOffset(Offset="0x30")]
		public CampaignLimitedAttemptRefreshPopupController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x112DFDC", Offset="0x112DFDC", VA="0x112DFDC")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x112E2C8", Offset="0x112E2C8", VA="0x112E2C8")]
		internal void <Initialize>b__0(CampaignLimitedAttemptRefreshPopupView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B50C", Offset="0x104B50C")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset="0x10")]
		public CampaignLimitedAttemptRefreshPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public BuyPveRefreshRequest req;

		[Address(RVA="0x112E2B8", Offset="0x112E2B8", VA="0x112E2B8")]
		public <>c__DisplayClass5_0()
		{
		}

		[Address(RVA="0x112E5B0", Offset="0x112E5B0", VA="0x112E5B0")]
		internal void <BuyLimitedAttemptRefresh>b__0(BuyPveRefreshResponse response)
		{
		}

		[Address(RVA="0x112E774", Offset="0x112E774", VA="0x112E774")]
		internal void <BuyLimitedAttemptRefresh>b__1(long response)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly DCampaignAddress CampaignAddress;

		[Address(RVA="0x112C9AC", Offset="0x112C9AC", VA="0x112C9AC")]
		public Context(DCampaignAddress campaignAddress)
		{
		}
	}
}