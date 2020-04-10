using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class BattleResultsController : AFeatureController, IDispatchHandler<DBattleResultsViewAction>, IDispatchHandler, IDispatchHandler<DPopupControllerAction>, IDispatchHandler<DCampaignProgressUpdatedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1054B54", Offset="0x1054B54")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1054B64", Offset="0x1054B64")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1054B74", Offset="0x1054B74")]
	[FieldOffset(Offset="0x78")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1054B84", Offset="0x1054B84")]
	[FieldOffset(Offset="0x80")]
	private BattleService _battleService;

	[Attribute(Name="InjectAttribute", RVA="0x1054B94", Offset="0x1054B94")]
	[FieldOffset(Offset="0x88")]
	private BattleStateTransitionController _stateTransitionController;

	[Attribute(Name="InjectAttribute", RVA="0x1054BA4", Offset="0x1054BA4")]
	[FieldOffset(Offset="0x90")]
	private TelemetryTranslator _telemetryTranslator;

	[Attribute(Name="InjectAttribute", RVA="0x1054BB4", Offset="0x1054BB4")]
	[FieldOffset(Offset="0x98")]
	private TelemetryUtility _telemetryUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1054BC4", Offset="0x1054BC4")]
	[FieldOffset(Offset="0xA0")]
	private CampaignUtility _campaignUtility;

	[FieldOffset(Offset="0xA8")]
	private BattleResultsGameState.TransitionContext _context;

	[FieldOffset(Offset="0xB0")]
	private AView _view;

	private BattleVictoryView VictoryView
	{
		[Address(RVA="0x1290F70", Offset="0x1290F70", VA="0x1290F70")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1292140", Offset="0x1292140", VA="0x1292140")]
	public BattleResultsController()
	{
	}

	[Address(RVA="0x1291B98", Offset="0x1291B98", VA="0x1291B98")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E848", Offset="0x106E848")]
	private void <HandleDispatchAction>g__ShowResultsView|4_0()
	{
	}

	[Address(RVA="0x1291600", Offset="0x1291600", VA="0x1291600")]
	private void EnterBattle(DCampaignAddress? campaignAddress)
	{
	}

	[Address(RVA="0x12910F8", Offset="0x12910F8", VA="0x12910F8", Slot="13")]
	public void HandleDispatchAction(DBattleResultsViewAction action)
	{
	}

	[Address(RVA="0x12919FC", Offset="0x12919FC", VA="0x12919FC", Slot="14")]
	public void HandleDispatchAction(DPopupControllerAction action)
	{
	}

	[Address(RVA="0x1291CC4", Offset="0x1291CC4", VA="0x1291CC4", Slot="15")]
	public void HandleDispatchAction(DCampaignProgressUpdatedAction action)
	{
	}

	[Address(RVA="0x1290B78", Offset="0x1290B78", VA="0x1290B78", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x1291D94", Offset="0x1291D94", VA="0x1291D94")]
	private void SetLimitedAttemptInfo(BattleVictoryView victoryView)
	{
	}

	[Address(RVA="0x1291F0C", Offset="0x1291F0C", VA="0x1291F0C")]
	private void SetLimitedAttemptInfo(BattleDefeatView defeatView)
	{
	}

	[Address(RVA="0x1290E84", Offset="0x1290E84", VA="0x1290E84", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x1290EF4", Offset="0x1290EF4", VA="0x1290EF4", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B3CC", Offset="0x104B3CC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleResultsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public bool allowNavigateAway;

		[FieldOffset(Offset="0x20")]
		public GameStateTransitionContext context;

		[FieldOffset(Offset="0x28")]
		public bool showResultsViewImmediately;

		[Address(RVA="0x1290E7C", Offset="0x1290E7C", VA="0x1290E7C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x12923D8", Offset="0x12923D8", VA="0x12923D8")]
		internal void <Initialize>b__0(Action executed)
		{
		}

		[Address(RVA="0x12924CC", Offset="0x12924CC", VA="0x12924CC")]
		internal void <Initialize>b__1(Action executed)
		{
		}

		[Address(RVA="0x12925CC", Offset="0x12925CC", VA="0x12925CC")]
		internal void <Initialize>b__2(Action executed)
		{
		}

		[Address(RVA="0x12926C0", Offset="0x12926C0", VA="0x12926C0")]
		internal void <Initialize>b__3(Action executed)
		{
		}

		[Address(RVA="0x12927BC", Offset="0x12927BC", VA="0x12927BC")]
		internal void <Initialize>b__4()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B3DC", Offset="0x104B3DC")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action executed;

		[FieldOffset(Offset="0x18")]
		public BattleResultsController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x12926B8", Offset="0x12926B8", VA="0x12926B8")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x12927F8", Offset="0x12927F8", VA="0x12927F8")]
		internal void <Initialize>b__5(BattleVictoryView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B3EC", Offset="0x104B3EC")]
	private sealed class <>c__DisplayClass0_2
	{
		[FieldOffset(Offset="0x10")]
		public Action executed;

		[FieldOffset(Offset="0x18")]
		public BattleResultsController.<>c__DisplayClass0_0 CS$<>8__locals2;

		[Address(RVA="0x12927B4", Offset="0x12927B4", VA="0x12927B4")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x12933A8", Offset="0x12933A8", VA="0x12933A8")]
		internal void <Initialize>b__6(BattleDefeatView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B3FC", Offset="0x104B3FC")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset="0x10")]
		public PveBattleStartRequest request;

		[FieldOffset(Offset="0x18")]
		public BattleResultsController <>4__this;

		[Address(RVA="0x1292010", Offset="0x1292010", VA="0x1292010")]
		public <>c__DisplayClass6_0()
		{
		}

		[Address(RVA="0x1293620", Offset="0x1293620", VA="0x1293620")]
		internal void <EnterBattle>b__0(PveBattleStartResponse response)
		{
		}

		[Address(RVA="0x1293874", Offset="0x1293874", VA="0x1293874")]
		internal void <EnterBattle>b__1(long errorCode)
		{
		}
	}
}