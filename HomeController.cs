using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class HomeController : AFeatureController, IDispatchHandler<DHomeViewAction>, IDispatchHandler, IDispatchHandler<DPlayerXpContainerAction>, IDispatchHandler<DTitleViewAction>, IDispatchHandler<DPopupControllerAction>, IDispatchHandler<DCardUnlockTrackerViewAction>, IDispatchHandler<DHomeDailyEventsResponse>, IDispatchHandler<DScheduledEventDomainUpdatedAction>, IDispatchHandler<DHomeTowerStatusResponse>, IDispatchHandler<DHomeClubDungeonStatusResponse>, IDispatchHandler<DApplicationFocusAction>, IDispatchHandler<DHomeDailyActivityButtonAction>, IDispatchHandler<DHomeKothResponse>, IDispatchHandler<DHomeStoreResponse>, IDispatchHandler<DHomeClubWarResponse>, IDispatchHandler<DHomeClubDonationsResponse>, IDispatchHandler<DPlayerLevelUpAction>, IDispatchHandler<DPlayerActivityUpdatedAction>, IDispatchHandler<DSpecialOfferChangedAction>, IDispatchHandler<DHomePvpResponse>, IDispatchHandler<DHomeBattleSelectResponse>
{
	[FieldOffset(Offset="0x0")]
	private const int NUM_PASSPORT_PREVIEWS = 3;

	[FieldOffset(Offset="0x0")]
	private const int NUM_DAILY_ACTIVITY_PREVIEWS = 1;

	[FieldOffset(Offset="0x0")]
	private readonly static TimeSpan s_passportActivityCycleTime;

	[FieldOffset(Offset="0x8")]
	private readonly static TimeSpan s_marqueeEventsCycleTime;

	[FieldOffset(Offset="0x10")]
	private readonly static TimeSpan s_helpshiftMessageCheckIntervalTime;

	[FieldOffset(Offset="0x18")]
	private static int s_currentMarqueeEventIndex;

	[Attribute(Name="InjectAttribute", RVA="0x10588E8", Offset="0x10588E8")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x10588F8", Offset="0x10588F8")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1058908", Offset="0x1058908")]
	[FieldOffset(Offset="0x78")]
	private StoreDomainController _storeDC;

	[Attribute(Name="InjectAttribute", RVA="0x1058918", Offset="0x1058918")]
	[FieldOffset(Offset="0x80")]
	private EventDomainController _eventDC;

	[Attribute(Name="InjectAttribute", RVA="0x1058928", Offset="0x1058928")]
	[FieldOffset(Offset="0x88")]
	private DeepLinkHandler _deepLinkHandler;

	[Attribute(Name="InjectAttribute", RVA="0x1058938", Offset="0x1058938")]
	[FieldOffset(Offset="0x90")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1058948", Offset="0x1058948")]
	[FieldOffset(Offset="0x98")]
	private CardUnlockTrackerController _cardUnlockTrackerController;

	[Attribute(Name="InjectAttribute", RVA="0x1058958", Offset="0x1058958")]
	[FieldOffset(Offset="0xA0")]
	private TitleController _titleController;

	[Attribute(Name="InjectAttribute", RVA="0x1058968", Offset="0x1058968")]
	[FieldOffset(Offset="0xA8")]
	private Procrastinator _procrastinator;

	[Attribute(Name="InjectAttribute", RVA="0x1058978", Offset="0x1058978")]
	[FieldOffset(Offset="0xB0")]
	private ChatPreviewController _chatPreviewController;

	[Attribute(Name="InjectAttribute", RVA="0x1058988", Offset="0x1058988")]
	[FieldOffset(Offset="0xB8")]
	private AppRatingController _appRatingController;

	[Attribute(Name="InjectAttribute", RVA="0x1058998", Offset="0x1058998")]
	[FieldOffset(Offset="0xC0")]
	private HomeServiceUtility _homeServiceUtility;

	[Attribute(Name="InjectAttribute", RVA="0x10589A8", Offset="0x10589A8")]
	[FieldOffset(Offset="0xC8")]
	private PassportSeasonUtility _passportSeasonUtility;

	[Attribute(Name="InjectAttribute", RVA="0x10589B8", Offset="0x10589B8")]
	[FieldOffset(Offset="0xD0")]
	private HelpshiftController _helpshift;

	[Attribute(Name="InjectAttribute", RVA="0x10589C8", Offset="0x10589C8")]
	[FieldOffset(Offset="0xD8")]
	private AccountPrefs _accountPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x10589D8", Offset="0x10589D8")]
	[FieldOffset(Offset="0xE0")]
	private HudController _hudController;

	[Attribute(Name="InjectAttribute", RVA="0x10589E8", Offset="0x10589E8")]
	[FieldOffset(Offset="0xE8")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x10589F8", Offset="0x10589F8")]
	[FieldOffset(Offset="0xF0")]
	private InventoryUtility _inventoryUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1058A08", Offset="0x1058A08")]
	[FieldOffset(Offset="0xF8")]
	private CardProgressTrackerUtility _cardProgressTrackerUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1058A18", Offset="0x1058A18")]
	[FieldOffset(Offset="0x100")]
	private AssetRegistry _marqueeEventsRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x1058A28", Offset="0x1058A28")]
	[FieldOffset(Offset="0x108")]
	private ClubDomainController _clubDc;

	[Attribute(Name="InjectAttribute", RVA="0x1058A38", Offset="0x1058A38")]
	[FieldOffset(Offset="0x110")]
	private RevSdkController _revSdkController;

	[FieldOffset(Offset="0x118")]
	private HomeView _view;

	[FieldOffset(Offset="0x120")]
	private HomeScene _homeScene;

	[FieldOffset(Offset="0x128")]
	private HomeGameState.Context _context;

	[FieldOffset(Offset="0x130")]
	private List<Serverproto.PlayerActivity> _passportPreviews;

	[FieldOffset(Offset="0x138")]
	private DateTime _showNextPassportActivityTime;

	[FieldOffset(Offset="0x140")]
	private int _currentPassportPreviewIndex;

	[FieldOffset(Offset="0x148")]
	private HomePvpResponse _cachedPvpResponse;

	[FieldOffset(Offset="0x150")]
	private HomeBattleSelectResponse _cachedBattleSelectResponse;

	[FieldOffset(Offset="0x158")]
	private List<EventGroup> _marqueeEventGroups;

	[FieldOffset(Offset="0x160")]
	private AssetCollection _marqueeEventsAssetCollection;

	[FieldOffset(Offset="0x168")]
	private DateTime _showNextMarqueeEventTime;

	[FieldOffset(Offset="0x170")]
	private DateTime _helpshiftCheckNextMessageEventTime;

	[Address(RVA="0x12F10E4", Offset="0x12F10E4", VA="0x12F10E4")]
	static HomeController()
	{
	}

	[Address(RVA="0x12F1010", Offset="0x12F1010", VA="0x12F1010")]
	public HomeController()
	{
	}

	[Address(RVA="0x12F1204", Offset="0x12F1204", VA="0x12F1204")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FC74", Offset="0x106FC74")]
	private bool <HandleDispatchAction>b__12_0()
	{
		return new bool();
	}

	[Address(RVA="0x12F11B4", Offset="0x12F11B4", VA="0x12F11B4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FC54", Offset="0x106FC54")]
	private void <HandleDispatchAction>b__5_0()
	{
	}

	[Address(RVA="0x12F11C4", Offset="0x12F11C4", VA="0x12F11C4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FC64", Offset="0x106FC64")]
	private void <HandleDispatchAction>b__5_1()
	{
	}

	[Address(RVA="0x12F1224", Offset="0x12F1224", VA="0x12F1224")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FC84", Offset="0x106FC84")]
	private void <SetMarqueeEventGroups>b__34_1(AssetCollection assetCollection)
	{
	}

	[Address(RVA="0x12EF2F8", Offset="0x12EF2F8", VA="0x12EF2F8", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x12EF370", Offset="0x12EF370", VA="0x12EF370")]
	private void FinishInitialization()
	{
	}

	[Address(RVA="0x12F042C", Offset="0x12F042C", VA="0x12F042C")]
	private ValueTuple<Gamedata.Unit?, Gamedata.Spell?, Gamedata.InventoryItem?> GetCardPromotionData()
	{
		return null;
	}

	[Address(RVA="0x12EFE50", Offset="0x12EFE50", VA="0x12EFE50")]
	private List<Serverproto.PlayerActivity> GetDailyActivities()
	{
		return null;
	}

	[Address(RVA="0x12EEFE0", Offset="0x12EEFE0", VA="0x12EEFE0", Slot="9")]
	protected override void HandleBackButton(AView view)
	{
	}

	[Address(RVA="0x12ED23C", Offset="0x12ED23C", VA="0x12ED23C", Slot="13")]
	public void HandleDispatchAction(DHomeViewAction action)
	{
	}

	[Address(RVA="0x12ED7F4", Offset="0x12ED7F4", VA="0x12ED7F4", Slot="14")]
	public void HandleDispatchAction(DPlayerXpContainerAction action)
	{
	}

	[Address(RVA="0x12ED848", Offset="0x12ED848", VA="0x12ED848", Slot="15")]
	public void HandleDispatchAction(DTitleViewAction action)
	{
	}

	[Address(RVA="0x12EDAF8", Offset="0x12EDAF8", VA="0x12EDAF8", Slot="16")]
	public void HandleDispatchAction(DPopupControllerAction action)
	{
	}

	[Address(RVA="0x12EDC24", Offset="0x12EDC24", VA="0x12EDC24", Slot="17")]
	public void HandleDispatchAction(DCardUnlockTrackerViewAction action)
	{
	}

	[Address(RVA="0x12EDC3C", Offset="0x12EDC3C", VA="0x12EDC3C", Slot="18")]
	public void HandleDispatchAction(DHomeDailyEventsResponse action)
	{
	}

	[Address(RVA="0x12EDC84", Offset="0x12EDC84", VA="0x12EDC84", Slot="19")]
	public void HandleDispatchAction(DScheduledEventDomainUpdatedAction action)
	{
	}

	[Address(RVA="0x12EE2E8", Offset="0x12EE2E8", VA="0x12EE2E8", Slot="20")]
	public void HandleDispatchAction(DHomeTowerStatusResponse action)
	{
	}

	[Address(RVA="0x12EE3D4", Offset="0x12EE3D4", VA="0x12EE3D4", Slot="21")]
	public void HandleDispatchAction(DHomeClubDungeonStatusResponse action)
	{
	}

	[Address(RVA="0x12EE420", Offset="0x12EE420", VA="0x12EE420", Slot="22")]
	public void HandleDispatchAction(DApplicationFocusAction action)
	{
	}

	[Address(RVA="0x12EE4DC", Offset="0x12EE4DC", VA="0x12EE4DC", Slot="23")]
	public void HandleDispatchAction(DHomeDailyActivityButtonAction action)
	{
	}

	[Address(RVA="0x12EE700", Offset="0x12EE700", VA="0x12EE700", Slot="24")]
	public void HandleDispatchAction(DHomeKothResponse action)
	{
	}

	[Address(RVA="0x12EE780", Offset="0x12EE780", VA="0x12EE780", Slot="25")]
	public void HandleDispatchAction(DHomeStoreResponse action)
	{
	}

	[Address(RVA="0x12EE79C", Offset="0x12EE79C", VA="0x12EE79C", Slot="26")]
	public void HandleDispatchAction(DHomeClubWarResponse action)
	{
	}

	[Address(RVA="0x12EE918", Offset="0x12EE918", VA="0x12EE918", Slot="27")]
	public void HandleDispatchAction(DHomeClubDonationsResponse action)
	{
	}

	[Address(RVA="0x12EE9D0", Offset="0x12EE9D0", VA="0x12EE9D0", Slot="28")]
	public void HandleDispatchAction(DPlayerLevelUpAction action)
	{
	}

	[Address(RVA="0x12EEA3C", Offset="0x12EEA3C", VA="0x12EEA3C", Slot="29")]
	public void HandleDispatchAction(DPlayerActivityUpdatedAction action)
	{
	}

	[Address(RVA="0x12EEB34", Offset="0x12EEB34", VA="0x12EEB34", Slot="30")]
	public void HandleDispatchAction(DSpecialOfferChangedAction action)
	{
	}

	[Address(RVA="0x12EEBEC", Offset="0x12EEBEC", VA="0x12EEBEC", Slot="31")]
	public void HandleDispatchAction(DHomePvpResponse response)
	{
	}

	[Address(RVA="0x12EEBF4", Offset="0x12EEBF4", VA="0x12EEBF4", Slot="32")]
	public void HandleDispatchAction(DHomeBattleSelectResponse response)
	{
	}

	[Address(RVA="0x12EC6EC", Offset="0x12EC6EC", VA="0x12EC6EC", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x12F02BC", Offset="0x12F02BC", VA="0x12F02BC")]
	private int InsertionSortDailyActivities(Serverproto.PlayerActivity a, Serverproto.PlayerActivity b)
	{
		return new int();
	}

	[Address(RVA="0x12EF420", Offset="0x12EF420", VA="0x12EF420")]
	private bool ProcessInitializationSequence()
	{
		return new bool();
	}

	[Address(RVA="0x12F0F0C", Offset="0x12F0F0C", VA="0x12F0F0C")]
	private void RefreshActivitiesOrPromotionWidgets()
	{
	}

	[Address(RVA="0x12EE91C", Offset="0x12EE91C", VA="0x12EE91C")]
	private void SetClubSupportCount()
	{
	}

	[Address(RVA="0x12ED03C", Offset="0x12ED03C", VA="0x12ED03C")]
	private void SetCurrentMarqueeEvent()
	{
	}

	[Address(RVA="0x12EDC88", Offset="0x12EDC88", VA="0x12EDC88")]
	private void SetMarqueeEventGroups()
	{
	}

	[Address(RVA="0x12EF980", Offset="0x12EF980", VA="0x12EF980")]
	private void SetPassportSeasonActivities()
	{
	}

	[Address(RVA="0x12EEB38", Offset="0x12EEB38", VA="0x12EEB38")]
	private void SetSpecialOffer()
	{
	}

	[Address(RVA="0x12EDA00", Offset="0x12EDA00", VA="0x12EDA00")]
	private void ShowHud()
	{
	}

	[Address(RVA="0x12EC9DC", Offset="0x12EC9DC", VA="0x12EC9DC", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x12ECAA0", Offset="0x12ECAA0", VA="0x12ECAA0", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C03C", Offset="0x104C03C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static HomeController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<long> <>9__13_1;

		[FieldOffset(Offset="0x10")]
		public static Comparison<Serverproto.PlayerActivity> <>9__28_0;

		[FieldOffset(Offset="0x18")]
		public static Comparison<EventGroup> <>9__34_0;

		[Address(RVA="0x116BE5C", Offset="0x116BE5C", VA="0x116BE5C")]
		static <>c()
		{
		}

		[Address(RVA="0x116BEC0", Offset="0x116BEC0", VA="0x116BEC0")]
		public <>c()
		{
		}

		[Address(RVA="0x116BEC8", Offset="0x116BEC8", VA="0x116BEC8")]
		internal void <HandleDispatchAction>b__13_1(long errorCode)
		{
		}

		[Address(RVA="0x116BFCC", Offset="0x116BFCC", VA="0x116BFCC")]
		internal int <SetMarqueeEventGroups>b__34_0(EventGroup a, EventGroup b)
		{
			return new int();
		}

		[Address(RVA="0x116BECC", Offset="0x116BECC", VA="0x116BECC")]
		internal int <SetPassportSeasonActivities>b__28_0(Serverproto.PlayerActivity a, Serverproto.PlayerActivity b)
		{
			return new int();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BFFC", Offset="0x104BFFC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public HomeController <>4__this;

		[FieldOffset(Offset="0x18")]
		public bool enteredFromTitleScreen;

		[Address(RVA="0x116C03C", Offset="0x116C03C", VA="0x116C03C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x116C044", Offset="0x116C044", VA="0x116C044")]
		internal void <Initialize>b__0(Action executed)
		{
		}

		[Address(RVA="0x116C094", Offset="0x116C094", VA="0x116C094")]
		internal void <Initialize>b__1(Action executed)
		{
		}

		[Address(RVA="0x116C198", Offset="0x116C198", VA="0x116C198")]
		internal void <Initialize>b__2(Action executed)
		{
		}

		[Address(RVA="0x116C28C", Offset="0x116C28C", VA="0x116C28C")]
		internal void <Initialize>b__3()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C00C", Offset="0x104C00C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action executed;

		[FieldOffset(Offset="0x18")]
		public HomeController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x116C190", Offset="0x116C190", VA="0x116C190")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x116CB5C", Offset="0x116CB5C", VA="0x116CB5C")]
		internal void <Initialize>b__4(HomeScene scene)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C01C", Offset="0x104C01C")]
	private sealed class <>c__DisplayClass0_2
	{
		[FieldOffset(Offset="0x10")]
		public Action executed;

		[FieldOffset(Offset="0x18")]
		public HomeController.<>c__DisplayClass0_0 CS$<>8__locals2;

		[Address(RVA="0x116C284", Offset="0x116C284", VA="0x116C284")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x116CF0C", Offset="0x116CF0C", VA="0x116CF0C")]
		internal void <Initialize>b__5(HomeView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C02C", Offset="0x104C02C")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset="0x10")]
		public HomeController <>4__this;

		[FieldOffset(Offset="0x18")]
		public DHomeDailyActivityButtonAction action;

		[Address(RVA="0x116D9A4", Offset="0x116D9A4", VA="0x116D9A4")]
		public <>c__DisplayClass13_0()
		{
		}

		[Address(RVA="0x116D9AC", Offset="0x116D9AC", VA="0x116D9AC")]
		internal void <HandleDispatchAction>b__0(ClaimActivityResponse response)
		{
		}

		[Address(RVA="0x116E1AC", Offset="0x116E1AC", VA="0x116E1AC")]
		internal void <HandleDispatchAction>b__2()
		{
		}
	}
}