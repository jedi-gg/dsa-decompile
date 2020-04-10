using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class TowerController : AFeatureController, IDispatchHandler<DTowerViewAction>, IDispatchHandler, IDispatchHandler<DTowerNodeSelectedAction>, IDispatchHandler<DTowerSceneProgressionChestAction>, IDispatchHandler<DCampaignNodeDetailsViewAction>, IDispatchHandler<DPopupControllerAction>, IDispatchHandler<DCampaignNodeDetailsBattleRestrictionAction>, IDispatchHandler<DTowerSceneIntroAnimationAction>
{
	[FieldOffset(Offset="0x0")]
	private const float CHEST_OPEN_DELAY_S = 2f;

	[Attribute(Name="InjectAttribute", RVA="0x105D708", Offset="0x105D708")]
	[FieldOffset(Offset="0x68")]
	private TowerService _towerService;

	[Attribute(Name="InjectAttribute", RVA="0x105D718", Offset="0x105D718")]
	[FieldOffset(Offset="0x70")]
	private BattleService _battleService;

	[Attribute(Name="InjectAttribute", RVA="0x105D728", Offset="0x105D728")]
	[FieldOffset(Offset="0x78")]
	private MiniUnitDetailsController _miniUnitDetailsController;

	[Attribute(Name="InjectAttribute", RVA="0x105D738", Offset="0x105D738")]
	[FieldOffset(Offset="0x80")]
	private LocalizationManager _locManager;

	[Attribute(Name="InjectAttribute", RVA="0x105D748", Offset="0x105D748")]
	[FieldOffset(Offset="0x88")]
	private DialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x105D758", Offset="0x105D758")]
	[FieldOffset(Offset="0x90")]
	private RevSdkController _revSdk;

	[Attribute(Name="InjectAttribute", RVA="0x105D768", Offset="0x105D768")]
	[FieldOffset(Offset="0x98")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105D778", Offset="0x105D778")]
	[FieldOffset(Offset="0xA0")]
	private Procrastinator _procrastinator;

	[Attribute(Name="InjectAttribute", RVA="0x105D788", Offset="0x105D788")]
	[FieldOffset(Offset="0xA8")]
	private ContextualMessageController _contextualMessageController;

	[Attribute(Name="InjectAttribute", RVA="0x105D798", Offset="0x105D798")]
	[FieldOffset(Offset="0xB0")]
	private AccountPrefs _accountPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x105D7A8", Offset="0x105D7A8")]
	[FieldOffset(Offset="0xB8")]
	private TelemetryTranslator _telemetryTranslator;

	[FieldOffset(Offset="0xC0")]
	private TowerGameState.Context _context;

	[FieldOffset(Offset="0xC8")]
	private TowerView _towerView;

	[FieldOffset(Offset="0xD0")]
	private TowerScene _towerScene;

	[FieldOffset(Offset="0xD8")]
	private CampaignNodeDetailsView _nodeDetailsView;

	[FieldOffset(Offset="0xE0")]
	private Tower _tower;

	[FieldOffset(Offset="0xE8")]
	private TowerMap _towerMap;

	[FieldOffset(Offset="0xF0")]
	private TowerStatus _towerStatus;

	[FieldOffset(Offset="0xF8")]
	private TowerNode _selectedNode;

	[FieldOffset(Offset="0x100")]
	private List<EnemyUnitPreview> _currentNodeEnemyPreviews;

	[FieldOffset(Offset="0x108")]
	private PersistedPlayerBattleUnits _playerUnitStates;

	[Address(RVA="0x1434770", Offset="0x1434770", VA="0x1434770")]
	public TowerController()
	{
	}

	[Address(RVA="0x14349D0", Offset="0x14349D0", VA="0x14349D0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070DD4", Offset="0x1070DD4")]
	private void <AutoWinTower>b__18_0(TowerAutoWinResponse response)
	{
	}

	[Address(RVA="0x1434BFC", Offset="0x1434BFC", VA="0x1434BFC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070DE4", Offset="0x1070DE4")]
	private void <AutoWinTower>b__18_1(long failureCode)
	{
	}

	[Address(RVA="0x1434CE4", Offset="0x1434CE4", VA="0x1434CE4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070DF4", Offset="0x1070DF4")]
	private void <ClaimProgressionLoot>b__24_0(ClaimTowerProgressionLootResponse response)
	{
	}

	[Address(RVA="0x1434E48", Offset="0x1434E48", VA="0x1434E48")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070E04", Offset="0x1070E04")]
	private void <ClaimProgressionLoot>b__24_1(long failureCode)
	{
	}

	[Address(RVA="0x1434800", Offset="0x1434800", VA="0x1434800")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070DB4", Offset="0x1070DB4")]
	private void <RefreshTower>b__17_0(RefreshTowerResponse response)
	{
	}

	[Address(RVA="0x14348E8", Offset="0x14348E8", VA="0x14348E8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070DC4", Offset="0x1070DC4")]
	private void <RefreshTower>b__17_1(long failureCode)
	{
	}

	[Address(RVA="0x143117C", Offset="0x143117C", VA="0x143117C")]
	private void AutoWinTower()
	{
	}

	[Address(RVA="0x143132C", Offset="0x143132C", VA="0x143132C")]
	private void ClaimProgressionLoot()
	{
	}

	[Address(RVA="0x1431FB8", Offset="0x1431FB8", VA="0x1431FB8", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x1431968", Offset="0x1431968", VA="0x1431968")]
	private void EnterSquadSelect()
	{
	}

	[Address(RVA="0x1431FC0", Offset="0x1431FC0", VA="0x1431FC0")]
	private void FinishInitialization()
	{
	}

	[Address(RVA="0x1430CE8", Offset="0x1430CE8", VA="0x1430CE8", Slot="13")]
	public void HandleDispatchAction(DTowerViewAction action)
	{
	}

	[Address(RVA="0x14314DC", Offset="0x14314DC", VA="0x14314DC", Slot="14")]
	public void HandleDispatchAction(DTowerNodeSelectedAction action)
	{
	}

	[Address(RVA="0x1431860", Offset="0x1431860", VA="0x1431860", Slot="15")]
	public void HandleDispatchAction(DTowerSceneProgressionChestAction action)
	{
	}

	[Address(RVA="0x143195C", Offset="0x143195C", VA="0x143195C", Slot="16")]
	public void HandleDispatchAction(DCampaignNodeDetailsViewAction action)
	{
	}

	[Address(RVA="0x1431BC4", Offset="0x1431BC4", VA="0x1431BC4", Slot="17")]
	public void HandleDispatchAction(DPopupControllerAction action)
	{
	}

	[Address(RVA="0x1431CA8", Offset="0x1431CA8", VA="0x1431CA8", Slot="18")]
	public void HandleDispatchAction(DCampaignNodeDetailsBattleRestrictionAction action)
	{
	}

	[Address(RVA="0x1431F18", Offset="0x1431F18", VA="0x1431F18", Slot="19")]
	public void HandleDispatchAction(DTowerSceneIntroAnimationAction action)
	{
	}

	[Address(RVA="0x14306F4", Offset="0x14306F4", VA="0x14306F4", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x1433B94", Offset="0x1433B94", VA="0x1433B94")]
	private void LoadNodeDetailsView(Action finished)
	{
	}

	[Address(RVA="0x1433C78", Offset="0x1433C78", VA="0x1433C78")]
	private void LoadScene(Action finished)
	{
	}

	[Address(RVA="0x1433AB0", Offset="0x1433AB0", VA="0x1433AB0")]
	private void LoadTowerView(Action finished)
	{
	}

	[Address(RVA="0x143296C", Offset="0x143296C", VA="0x143296C")]
	private void ParseUnitBattleStates()
	{
	}

	[Address(RVA="0x1434088", Offset="0x1434088", VA="0x1434088")]
	private void RefreshTower()
	{
	}

	[Address(RVA="0x1433D80", Offset="0x1433D80", VA="0x1433D80")]
	private void RequestTower(Action finished)
	{
	}

	[Address(RVA="0x1433F04", Offset="0x1433F04", VA="0x1433F04")]
	private void RequestTowerStatus(Action finished)
	{
	}

	[Address(RVA="0x1434238", Offset="0x1434238", VA="0x1434238")]
	private void SendRefreshTowerTelemetry()
	{
	}

	[Address(RVA="0x143437C", Offset="0x143437C", VA="0x143437C")]
	private void SendTowerAutoWinTelemetry(TowerAutoWinResponse response)
	{
	}

	[Address(RVA="0x14345C0", Offset="0x14345C0", VA="0x14345C0")]
	private void SendTowerProgressionLootTelemetry(ClaimTowerProgressionLootResponse response)
	{
	}

	[Address(RVA="0x14309CC", Offset="0x14309CC", VA="0x14309CC", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x1430A5C", Offset="0x1430A5C", VA="0x1430A5C", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x1431688", Offset="0x1431688", VA="0x1431688")]
	private void ToggleNodeDetails(TowerNode node)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CE7C", Offset="0x104CE7C")]
	private sealed class <>c__DisplayClass12_0
	{
		[FieldOffset(Offset="0x10")]
		public TowerController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x1433B8C", Offset="0x1433B8C", VA="0x1433B8C")]
		public <>c__DisplayClass12_0()
		{
		}

		[Address(RVA="0x1434EEC", Offset="0x1434EEC", VA="0x1434EEC")]
		internal void <LoadTowerView>b__0(TowerView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CE8C", Offset="0x104CE8C")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset="0x10")]
		public TowerController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x1433C70", Offset="0x1433C70", VA="0x1433C70")]
		public <>c__DisplayClass13_0()
		{
		}

		[Address(RVA="0x1434F44", Offset="0x1434F44", VA="0x1434F44")]
		internal void <LoadNodeDetailsView>b__0(CampaignNodeDetailsView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CE9C", Offset="0x104CE9C")]
	private sealed class <>c__DisplayClass14_0
	{
		[FieldOffset(Offset="0x10")]
		public TowerController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x1433D78", Offset="0x1433D78", VA="0x1433D78")]
		public <>c__DisplayClass14_0()
		{
		}

		[Address(RVA="0x1434FCC", Offset="0x1434FCC", VA="0x1434FCC")]
		internal void <LoadScene>b__0(TowerScene scene)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CEAC", Offset="0x104CEAC")]
	private sealed class <>c__DisplayClass15_0
	{
		[FieldOffset(Offset="0x10")]
		public TowerController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x1433EFC", Offset="0x1433EFC", VA="0x1433EFC")]
		public <>c__DisplayClass15_0()
		{
		}

		[Address(RVA="0x1435228", Offset="0x1435228", VA="0x1435228")]
		internal void <RequestTower>b__0(TowerResponse response)
		{
		}

		[Address(RVA="0x1435688", Offset="0x1435688", VA="0x1435688")]
		internal void <RequestTower>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CEBC", Offset="0x104CEBC")]
	private sealed class <>c__DisplayClass16_0
	{
		[FieldOffset(Offset="0x10")]
		public TowerController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x1434080", Offset="0x1434080", VA="0x1434080")]
		public <>c__DisplayClass16_0()
		{
		}

		[Address(RVA="0x1435758", Offset="0x1435758", VA="0x1435758")]
		internal void <RequestTowerStatus>b__0(TowerStatusResponse response)
		{
		}

		[Address(RVA="0x1435A7C", Offset="0x1435A7C", VA="0x1435A7C")]
		internal void <RequestTowerStatus>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CECC", Offset="0x104CECC")]
	private sealed class <>c__DisplayClass24_0
	{
		[FieldOffset(Offset="0x10")]
		public ClaimTowerProgressionLootResponse response;

		[FieldOffset(Offset="0x18")]
		public TowerController <>4__this;

		[Address(RVA="0x1434E40", Offset="0x1434E40", VA="0x1434E40")]
		public <>c__DisplayClass24_0()
		{
		}

		[Address(RVA="0x1435B4C", Offset="0x1435B4C", VA="0x1435B4C")]
		internal void <ClaimProgressionLoot>b__2()
		{
		}
	}
}