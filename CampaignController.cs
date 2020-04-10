using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class CampaignController : AFeatureController, IDispatchHandler<DCampaignMapButtonAction>, IDispatchHandler, IDispatchHandler<DCampaignNodeDetailsViewAction>, IDispatchHandler<DCampaignWorldBattleNodeAction>, IDispatchHandler<DCampaignWorldRewardNodeAction>, IDispatchHandler<DCampaignViewAction>, IDispatchHandler<DCampaignProgressUpdatedAction>, IDispatchHandler<DCampaignNodeDetailsBattleRestrictionAction>, IDispatchHandler<DPlayerActivityClaimAction>, IDispatchHandler<DCampaignProgressProcessedAction>, IDispatchHandler<DClubSupportRequestButtonAction>, IDispatchHandler<DBonusLootExpiredAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x10552DC", Offset="0x10552DC")]
	[FieldOffset(Offset="0x68")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x10552EC", Offset="0x10552EC")]
	[FieldOffset(Offset="0x70")]
	private SingleAssetRegistry _worldAssetReg;

	[Attribute(Name="InjectAttribute", RVA="0x10552FC", Offset="0x10552FC")]
	[FieldOffset(Offset="0x78")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x105530C", Offset="0x105530C")]
	[FieldOffset(Offset="0x80")]
	private CampaignService _campaignService;

	[Attribute(Name="InjectAttribute", RVA="0x105531C", Offset="0x105531C")]
	[FieldOffset(Offset="0x88")]
	private MiniUnitDetailsController _miniUnitDetailsController;

	[Attribute(Name="InjectAttribute", RVA="0x105532C", Offset="0x105532C")]
	[FieldOffset(Offset="0x90")]
	private CardUnlockTrackerController _cardUnlockTrackerController;

	[Attribute(Name="InjectAttribute", RVA="0x105533C", Offset="0x105533C")]
	[FieldOffset(Offset="0x98")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x105534C", Offset="0x105534C")]
	[FieldOffset(Offset="0xA0")]
	private CostController _costController;

	[Attribute(Name="InjectAttribute", RVA="0x105535C", Offset="0x105535C")]
	[FieldOffset(Offset="0xA8")]
	private CampaignUtility _campaignUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105536C", Offset="0x105536C")]
	[FieldOffset(Offset="0xB0")]
	private AppRatingController _appRatingController;

	[Attribute(Name="InjectAttribute", RVA="0x105537C", Offset="0x105537C")]
	[FieldOffset(Offset="0xB8")]
	private IHapticController _hapticController;

	[Attribute(Name="InjectAttribute", RVA="0x105538C", Offset="0x105538C")]
	[FieldOffset(Offset="0xC0")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105539C", Offset="0x105539C")]
	[FieldOffset(Offset="0xC8")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x10553AC", Offset="0x10553AC")]
	[FieldOffset(Offset="0xD0")]
	private HudController _hudController;

	[Attribute(Name="InjectAttribute", RVA="0x10553BC", Offset="0x10553BC")]
	[FieldOffset(Offset="0xD8")]
	private ClubUtil _clubUtil;

	[Attribute(Name="InjectAttribute", RVA="0x10553CC", Offset="0x10553CC")]
	[FieldOffset(Offset="0xE0")]
	private ClubServiceUtility _clubServiceUtility;

	[Attribute(Name="InjectAttribute", RVA="0x10553DC", Offset="0x10553DC")]
	[FieldOffset(Offset="0xE8")]
	private TelemetryTranslator _telemetryTranslator;

	[Attribute(Name="InjectAttribute", RVA="0x10553EC", Offset="0x10553EC")]
	[FieldOffset(Offset="0xF0")]
	private BattleService _battleService;

	[FieldOffset(Offset="0xF8")]
	private Campaign? _normalCampaignData;

	[FieldOffset(Offset="0x110")]
	private Campaign? _hardCampaignData;

	[FieldOffset(Offset="0x128")]
	private CampaignDetailResponse _campaignDetails;

	[FieldOffset(Offset="0x130")]
	private CampaignWorld _world;

	[FieldOffset(Offset="0x138")]
	private CampaignView _campaignView;

	[FieldOffset(Offset="0x140")]
	private CampaignGameState.Context.ViewMode _viewMode;

	[FieldOffset(Offset="0x148")]
	private DCampaignAddress _currentSelection;

	[FieldOffset(Offset="0x160")]
	private CampaignNodeDetailsView _nodeDetailsView;

	[FieldOffset(Offset="0x168")]
	private WidgetDependencyContainer _widgetDependencies;

	[Address(RVA="0x112C9EC", Offset="0x112C9EC", VA="0x112C9EC")]
	public CampaignController()
	{
	}

	[Address(RVA="0x112C9F4", Offset="0x112C9F4", VA="0x112C9F4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E968", Offset="0x106E968")]
	private void <HandleDispatchAction>b__9_2()
	{
	}

	[Address(RVA="0x11287C0", Offset="0x11287C0", VA="0x11287C0")]
	private void BuyLimitedAttemptRefresh()
	{
	}

	[Address(RVA="0x112A3D0", Offset="0x112A3D0", VA="0x112A3D0")]
	private void ClaimFreeClubSupportLimitedAttemptRefresh(Serverproto.ClubSupportRequest supportRequest)
	{
	}

	[Address(RVA="0x112B314", Offset="0x112B314", VA="0x112B314")]
	private void CreateBattleNodeTiles(Campaign? campaignData, IList<Serverproto.CampaignMap> campaignMaps)
	{
	}

	[Address(RVA="0x112A9A0", Offset="0x112A9A0", VA="0x112A9A0", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x112C4F4", Offset="0x112C4F4", VA="0x112C4F4")]
	private void FetchCampaignDetail(Action finished)
	{
	}

	[Address(RVA="0x112AA7C", Offset="0x112AA7C", VA="0x112AA7C")]
	private void FinishInitialization(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x112C11C", Offset="0x112C11C", VA="0x112C11C")]
	private Serverproto.BattleNode GetBattleNode(DCampaignAddress address)
	{
		return null;
	}

	[Address(RVA="0x1129814", Offset="0x1129814", VA="0x1129814")]
	private CampaignWorld.DCampaignUnlockStatus GetUnlockStatus(Campaign? campaignData)
	{
		return new CampaignWorld.DCampaignUnlockStatus();
	}

	[Address(RVA="0x112A980", Offset="0x112A980", VA="0x112A980", Slot="9")]
	protected override void HandleBackButton(AView view)
	{
	}

	[Address(RVA="0x1127AA8", Offset="0x1127AA8", VA="0x1127AA8", Slot="13")]
	public void HandleDispatchAction(DCampaignMapButtonAction action)
	{
	}

	[Address(RVA="0x1127C68", Offset="0x1127C68", VA="0x1127C68", Slot="18")]
	public void HandleDispatchAction(DCampaignProgressUpdatedAction action)
	{
	}

	[Address(RVA="0x112801C", Offset="0x112801C", VA="0x112801C", Slot="14")]
	public void HandleDispatchAction(DCampaignNodeDetailsViewAction action)
	{
	}

	[Address(RVA="0x11288E4", Offset="0x11288E4", VA="0x11288E4", Slot="15")]
	public void HandleDispatchAction(DCampaignWorldBattleNodeAction action)
	{
	}

	[Address(RVA="0x112917C", Offset="0x112917C", VA="0x112917C", Slot="17")]
	public void HandleDispatchAction(DCampaignViewAction action)
	{
	}

	[Address(RVA="0x112924C", Offset="0x112924C", VA="0x112924C", Slot="19")]
	public void HandleDispatchAction(DCampaignNodeDetailsBattleRestrictionAction action)
	{
	}

	[Address(RVA="0x1129378", Offset="0x1129378", VA="0x1129378", Slot="20")]
	public void HandleDispatchAction(DPlayerActivityClaimAction action)
	{
	}

	[Address(RVA="0x1129628", Offset="0x1129628", VA="0x1129628", Slot="21")]
	public void HandleDispatchAction(DCampaignProgressProcessedAction action)
	{
	}

	[Address(RVA="0x1129F68", Offset="0x1129F68", VA="0x1129F68", Slot="16")]
	public void HandleDispatchAction(DCampaignWorldRewardNodeAction action)
	{
	}

	[Address(RVA="0x112A160", Offset="0x112A160", VA="0x112A160", Slot="22")]
	public void HandleDispatchAction(DClubSupportRequestButtonAction action)
	{
	}

	[Address(RVA="0x112A62C", Offset="0x112A62C", VA="0x112A62C", Slot="23")]
	public void HandleDispatchAction(DBonusLootExpiredAction action)
	{
	}

	[Address(RVA="0x1127B60", Offset="0x1127B60", VA="0x1127B60")]
	private void HideDetails()
	{
	}

	[Address(RVA="0x1127088", Offset="0x1127088", VA="0x1127088", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x112C6CC", Offset="0x112C6CC", VA="0x112C6CC")]
	private bool IsBossNode(Serverproto.BattleNode node)
	{
		return new bool();
	}

	[Address(RVA="0x1127784", Offset="0x1127784", VA="0x1127784")]
	private bool IsGrandCampaign()
	{
		return new bool();
	}

	[Address(RVA="0x1127690", Offset="0x1127690", VA="0x1127690")]
	private bool IsPveCampaign()
	{
		return new bool();
	}

	[Address(RVA="0x1128298", Offset="0x1128298", VA="0x1128298")]
	private void SelectHeroesClicked(CampaignProgress progress)
	{
	}

	[Address(RVA="0x1128C30", Offset="0x1128C30", VA="0x1128C30")]
	private void ShowDetails(DCampaignAddress selection)
	{
	}

	[Address(RVA="0x1127818", Offset="0x1127818", VA="0x1127818", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x112790C", Offset="0x112790C", VA="0x112790C", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x1129C14", Offset="0x1129C14", VA="0x1129C14")]
	private void UpdateBattleTilesLockState(Campaign? campaignData)
	{
	}

	[Address(RVA="0x112A694", Offset="0x112A694", VA="0x112A694")]
	private void UpdateBonusLootLabel(Campaign? campaignData, bool isActive)
	{
	}

	[Address(RVA="0x1127E84", Offset="0x1127E84", VA="0x1127E84")]
	private void UpdateLimitedAttemptDetails()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B48C", Offset="0x104B48C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static CampaignController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<ClaimActivityResponse> <>9__9_0;

		[FieldOffset(Offset="0x10")]
		public static Action<long> <>9__9_1;

		[Address(RVA="0x112CA58", Offset="0x112CA58", VA="0x112CA58")]
		static <>c()
		{
		}

		[Address(RVA="0x112CABC", Offset="0x112CABC", VA="0x112CABC")]
		public <>c()
		{
		}

		[Address(RVA="0x112CAC4", Offset="0x112CAC4", VA="0x112CAC4")]
		internal void <HandleDispatchAction>b__9_0(ClaimActivityResponse response)
		{
		}

		[Address(RVA="0x112CAC8", Offset="0x112CAC8", VA="0x112CAC8")]
		internal void <HandleDispatchAction>b__9_1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B44C", Offset="0x104B44C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public CampaignController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x1127688", Offset="0x1127688", VA="0x1127688")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x112CACC", Offset="0x112CACC", VA="0x112CACC")]
		internal void <Initialize>b__0(Action jobFinished)
		{
		}

		[Address(RVA="0x112CBC0", Offset="0x112CBC0", VA="0x112CBC0")]
		internal void <Initialize>b__1(Action jobFinished)
		{
		}

		[Address(RVA="0x112CCB4", Offset="0x112CCB4", VA="0x112CCB4")]
		internal void <Initialize>b__2(Action jobFinished)
		{
		}

		[Address(RVA="0x112CE14", Offset="0x112CE14", VA="0x112CE14")]
		internal void <Initialize>b__3(Action done)
		{
		}

		[Address(RVA="0x112CE60", Offset="0x112CE60", VA="0x112CE60")]
		internal void <Initialize>b__4(Action done)
		{
		}

		[Address(RVA="0x112CEAC", Offset="0x112CEAC", VA="0x112CEAC")]
		internal void <Initialize>b__5(Action done)
		{
		}

		[Address(RVA="0x112CEF8", Offset="0x112CEF8", VA="0x112CEF8")]
		internal void <Initialize>b__6()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B45C", Offset="0x104B45C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[FieldOffset(Offset="0x18")]
		public CampaignController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x112CBB8", Offset="0x112CBB8", VA="0x112CBB8")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x112D124", Offset="0x112D124", VA="0x112D124")]
		internal void <Initialize>b__7(CampaignView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B46C", Offset="0x104B46C")]
	private sealed class <>c__DisplayClass0_2
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[FieldOffset(Offset="0x18")]
		public CampaignController.<>c__DisplayClass0_0 CS$<>8__locals2;

		[Address(RVA="0x112CCAC", Offset="0x112CCAC", VA="0x112CCAC")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x112D18C", Offset="0x112D18C", VA="0x112D18C")]
		internal void <Initialize>b__8(CampaignNodeDetailsView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B47C", Offset="0x104B47C")]
	private sealed class <>c__DisplayClass0_3
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[FieldOffset(Offset="0x18")]
		public CampaignController.<>c__DisplayClass0_0 CS$<>8__locals3;

		[Address(RVA="0x112CE0C", Offset="0x112CE0C", VA="0x112CE0C")]
		public <>c__DisplayClass0_3()
		{
		}

		[Address(RVA="0x112D710", Offset="0x112D710", VA="0x112D710")]
		internal void <Initialize>b__9(AssetHandle handle)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B49C", Offset="0x104B49C")]
	private sealed class <>c__DisplayClass17_0
	{
		[FieldOffset(Offset="0x10")]
		public CampaignController <>4__this;

		[FieldOffset(Offset="0x18")]
		public DCampaignAddress? newlyUnlockedNode;

		[Address(RVA="0x112B30C", Offset="0x112B30C", VA="0x112B30C")]
		public <>c__DisplayClass17_0()
		{
		}

		[Address(RVA="0x112D8D0", Offset="0x112D8D0", VA="0x112D8D0")]
		internal void <FinishInitialization>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B4AC", Offset="0x104B4AC")]
	private sealed class <>c__DisplayClass23_0
	{
		[FieldOffset(Offset="0x10")]
		public CampaignController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x112C6C4", Offset="0x112C6C4", VA="0x112C6C4")]
		public <>c__DisplayClass23_0()
		{
		}

		[Address(RVA="0x112D97C", Offset="0x112D97C", VA="0x112D97C")]
		internal void <FetchCampaignDetail>b__0(CampaignDetailResponse response)
		{
		}

		[Address(RVA="0x112D9D4", Offset="0x112D9D4", VA="0x112D9D4")]
		internal void <FetchCampaignDetail>b__1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B4BC", Offset="0x104B4BC")]
	private sealed class <>c__DisplayClass31_0
	{
		[FieldOffset(Offset="0x10")]
		public CampaignController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Serverproto.ClubSupportRequest supportRequest;

		[FieldOffset(Offset="0x20")]
		public BuyPveRefreshRequest req;

		[Address(RVA="0x112C9E4", Offset="0x112C9E4", VA="0x112C9E4")]
		public <>c__DisplayClass31_0()
		{
		}

		[Address(RVA="0x112DAB4", Offset="0x112DAB4", VA="0x112DAB4")]
		internal void <ClaimFreeClubSupportLimitedAttemptRefresh>b__0(BuyPveRefreshResponse response)
		{
		}

		[Address(RVA="0x112DC40", Offset="0x112DC40", VA="0x112DC40")]
		internal void <ClaimFreeClubSupportLimitedAttemptRefresh>b__1(long response)
		{
		}

		[Address(RVA="0x112DCC0", Offset="0x112DCC0", VA="0x112DCC0")]
		internal void <ClaimFreeClubSupportLimitedAttemptRefresh>b__2()
		{
		}
	}
}