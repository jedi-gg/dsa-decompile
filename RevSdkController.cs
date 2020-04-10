using Csdk.GluAds;
using Csdk.GluCentralServices;
using Csdk.GluIAP;
using Csdk.GluMarketing;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class RevSdkController : ILoggable<LogCategory>, IDispatchHandler<DPlayerChangeAction>, IDispatchHandler, IDispatchHandler<DPlayerLevelUpAction>, IDispatchHandler<DPlayerClubChangedAction>, IDispatchHandler<DInventoryDeltaProcessedAction>, IDispatchHandler<DBuyStoreItemInventoryDeltaAction>, IDispatchHandler<DRevSdkShowVgp>, IDispatchHandler<DRevSdkShowRewardInterstitialAction>, IDispatchHandler<DRevSdkShowOfferWallAction>, IDispatchHandler<DRevSdkRewardInterstitialValidationFailAction>, IDispatchHandler<DRevSdkLogEventAction>, IDispatchHandler<DRevSdkLogInventoryDeltaAction>, IDispatchHandler<DRevSdkLogPlayerSnapshotAction>, IDispatchHandler<DRevSdkLogAppTrackingEventAction>, IDispatchHandler<DRevSdkPurchaseResponseAction>, IDispatchHandler<DPushNotificationTokenChangedAction>, IDispatchHandler<DRevSdkUnitPromotedOrTieredAction>
{
	[FieldOffset(Offset="0x0")]
	private const string AD_TYPE_REWARD_INTERSTITIAL = "rewardedInterstitial";

	[FieldOffset(Offset="0x0")]
	private const string AD_TYPE_REWARD_INTERSTITIAL_PLACEMENT = "*";

	[FieldOffset(Offset="0x0")]
	private const string AD_TYPE_OFFER_WALL = "offerWall";

	[FieldOffset(Offset="0x0")]
	private const string AD_TYPE_OFFER_WALL_PLACEMENT = "hc_offerwall";

	[FieldOffset(Offset="0x0")]
	private const float AD_FAIL_QUICK_RELOAD_WAIT_DURATION_S = 10f;

	[FieldOffset(Offset="0x0")]
	private const float AD_FAIL_LONG_RELOAD_WAIT_DURATION_S = 30f;

	[FieldOffset(Offset="0x0")]
	private const int MAX_QUICK_AD_FAILS = 10;

	[FieldOffset(Offset="0x0")]
	private const float SHOW_AD_FAILED_WAIT_FOR_RELOAD_DURATION_S = 5f;

	[FieldOffset(Offset="0x0")]
	private const float PENDING_IAP_RESTORE_DURATION_S = 30f;

	[FieldOffset(Offset="0x0")]
	private const int QUERY_PRODUCTS_TIMEOUT_S = 15;

	[FieldOffset(Offset="0x0")]
	private const string VGP_ACTION_PURCHASE_IAP = "purchaseIAP";

	[FieldOffset(Offset="0x0")]
	private const string VGP_ACTION_PURCHASE_NON_IAP = "purchaseNonIAP";

	[FieldOffset(Offset="0x0")]
	private const string VGP_ACTION_DEEP_LINK = "deepLink";

	[FieldOffset(Offset="0x0")]
	private const int APP_TRACKING_TUTORIAL_COMPLETE_LEVEL = 4;

	[FieldOffset(Offset="0x0")]
	private const string APP_TRACKING_EVENT_PLAYER_LEVELED_FORMAT = "Reach Level {0}";

	[FieldOffset(Offset="0x0")]
	private const string APP_TRACKING_EVENT_SPELL_UNLOCKED_FORMAT = "Obtain {0} spells";

	[FieldOffset(Offset="0x0")]
	private const string APP_TRACKING_EVENT_UNIT_UNLOCKED_FORMAT = "Obtain {0} characters";

	[FieldOffset(Offset="0x0")]
	private const string APP_TRACKING_EVENT_UNIT_PROMOTED_FORMAT = "Obtain a {0} star character";

	[FieldOffset(Offset="0x0")]
	private const string APP_TRACKING_EVENT_UNIT_TIERED_FORMAT = "Upgrade an enchantment to tier {0}";

	[FieldOffset(Offset="0x0")]
	private const string APP_TRACKING_EVENT_JOINED_CLUB = "join_group";

	[FieldOffset(Offset="0x0")]
	private const string APP_TRACKING_DAILY_PVP_PACK = "Opened an arena pack";

	[FieldOffset(Offset="0x0")]
	private const string APP_TRACKING_COMPLETED_DAILY_REWARD = "Complete a daily reward offer";

	[FieldOffset(Offset="0x0")]
	private const string APP_TRACKING_IAP_PURCHASE_DAY_ONE = "Purchase an IAP pack on day one";

	[FieldOffset(Offset="0x0")]
	private const string APP_TRACKING_PURCHASED_PASSHOLDER = "Purchase passholder";

	[FieldOffset(Offset="0x0")]
	private const string APP_TRACKING_CHARACTER_4_STAR_AND_GEAR_TIER_3 = "Character is 4 star and gear tier 3";

	[FieldOffset(Offset="0x0")]
	private const string APP_TRACKING_PURCHASED_20_DOLLAR_GEM_PACK = "Purchased $20 gem pack";

	[FieldOffset(Offset="0x0")]
	private const string APP_TRACKING_PURCHASED_5_DOLLAR_STARTER_PACK = "Purchased $5 starter pack";

	[FieldOffset(Offset="0x0")]
	private const string GLU_MARKETING_ATTRIBUTE_KEY_PREFIX = "GLUM_";

	[FieldOffset(Offset="0x0")]
	private const string GLU_MARKETING_DYNAMIC_LINK_PURCHASE_IAP_URI_HOST = "purchaseiap";

	[FieldOffset(Offset="0x0")]
	private const string GLU_MARKETING_DYNAMIC_LINK_PURCHASE_NON_IAP_URI_HOST = "purchasenoniap";

	[FieldOffset(Offset="0x0")]
	private static Dictionary<string, object>[] s_adRewards;

	[Attribute(Name="InjectAttribute", RVA="0x105BFB0", Offset="0x105BFB0")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x105BFC0", Offset="0x105BFC0")]
	[FieldOffset(Offset="0x18")]
	private SystemDialogManager _systemDialog;

	[Attribute(Name="InjectAttribute", RVA="0x105BFD0", Offset="0x105BFD0")]
	[FieldOffset(Offset="0x20")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x105BFE0", Offset="0x105BFE0")]
	[FieldOffset(Offset="0x28")]
	private StoreService _storeService;

	[Attribute(Name="InjectAttribute", RVA="0x105BFF0", Offset="0x105BFF0")]
	[FieldOffset(Offset="0x30")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x105C000", Offset="0x105C000")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105C010", Offset="0x105C010")]
	[FieldOffset(Offset="0x40")]
	private StoreDomainController _storeDc;

	[Attribute(Name="InjectAttribute", RVA="0x105C020", Offset="0x105C020")]
	[FieldOffset(Offset="0x48")]
	private TelemetryTranslator _telemetryTranslator;

	[Attribute(Name="InjectAttribute", RVA="0x105C030", Offset="0x105C030")]
	[FieldOffset(Offset="0x50")]
	private AccountPrefs _accountPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x105C040", Offset="0x105C040")]
	[FieldOffset(Offset="0x58")]
	private SharedPrefs _sharedPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x105C050", Offset="0x105C050")]
	[FieldOffset(Offset="0x60")]
	private ContextualMessageController _contextualMessageController;

	[Attribute(Name="InjectAttribute", RVA="0x105C060", Offset="0x105C060")]
	[FieldOffset(Offset="0x68")]
	private PassportSeasonUtility _passportSeasonUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105C070", Offset="0x105C070")]
	[FieldOffset(Offset="0x70")]
	private ANotificationController _notificationController;

	[FieldOffset(Offset="0x78")]
	private Dictionary<string, InAppPurchaseProduct> _iapProductLookup;

	[FieldOffset(Offset="0x80")]
	private Dictionary<string, float> _iapUsdPriceLookup;

	[FieldOffset(Offset="0x88")]
	private Dictionary<string, PurchaseEvent> _pendingIapRestores;

	[FieldOffset(Offset="0x90")]
	private DateTime _nextPendingIapRestoreAttemptTime;

	[FieldOffset(Offset="0x98")]
	private Action _queryProductsFinishedCallback;

	[FieldOffset(Offset="0xA0")]
	private DateTime _queryProductsTimeout;

	[FieldOffset(Offset="0xA8")]
	private RevSdkRewardType _pendingAdRewardType;

	[FieldOffset(Offset="0xAC")]
	private float? _nextAdFailReloadTimer;

	[FieldOffset(Offset="0xB4")]
	private float? _showAdFailedWaitForReloadTimer;

	[FieldOffset(Offset="0xBC")]
	private int _sequentialAdLoadFails;

	[FieldOffset(Offset="0xC0")]
	private bool _isShutdown;

	[FieldOffset(Offset="0xC1")]
	private bool _gdprPopupInProgress;

	[FieldOffset(Offset="0xC2")]
	private bool _doesGdprApply;

	[FieldOffset(Offset="0xC8")]
	private string _pendingIapGiftId;

	public string AnalyticsDeviceId
	{
		[Address(RVA="0x2C2FBC4", Offset="0x2C2FBC4", VA="0x2C2FBC4")]
		get
		{
			return null;
		}
	}

	public string AnalyticsRevId
	{
		[Address(RVA="0x2C2FAE0", Offset="0x2C2FAE0", VA="0x2C2FAE0")]
		get
		{
			return null;
		}
	}

	public bool DoesGdprApply
	{
		[Address(RVA="0x2C2FCB0", Offset="0x2C2FCB0", VA="0x2C2FCB0")]
		get
		{
			return new bool();
		}
	}

	public bool GdprPopupInProgress
	{
		[Address(RVA="0x2C2FCA8", Offset="0x2C2FCA8", VA="0x2C2FCA8")]
		get
		{
			return new bool();
		}
	}

	public bool HasPendingIapPurchases
	{
		[Address(RVA="0x2C2FCB8", Offset="0x2C2FCB8", VA="0x2C2FCB8")]
		get
		{
			return new bool();
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x2C2FAD8", Offset="0x2C2FAD8", VA="0x2C2FAD8", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x2C3B138", Offset="0x2C3B138", VA="0x2C3B138")]
	public RevSdkController()
	{
	}

	[Address(RVA="0x2C3775C", Offset="0x2C3775C", VA="0x2C3775C")]
	private Dictionary<string, object> BuildPlayerSnapshot()
	{
		return null;
	}

	[Address(RVA="0x2C38F04", Offset="0x2C38F04", VA="0x2C38F04")]
	private Dictionary<string, object> BuildSorcererStoneSnapshot()
	{
		return null;
	}

	[Address(RVA="0x2C3AF58", Offset="0x2C3AF58", VA="0x2C3AF58")]
	private void ConsentUpdateReceived(ConsentUpdateResult consentUpdateResult)
	{
	}

	[Address(RVA="0x2C30BE4", Offset="0x2C30BE4", VA="0x2C30BE4")]
	private void CreateAdRewardLookup()
	{
	}

	[Address(RVA="0x2C32AE8", Offset="0x2C32AE8", VA="0x2C32AE8")]
	public InAppPurchaseProduct GetIapProduct(string productId)
	{
		return null;
	}

	[Address(RVA="0x2C32934", Offset="0x2C32934", VA="0x2C32934")]
	public IapProductValidity GetProductValidity(string productId)
	{
		return new IapProductValidity();
	}

	[Address(RVA="0x2C329FC", Offset="0x2C329FC", VA="0x2C329FC")]
	public string GetUserIdentityPin()
	{
		return null;
	}

	[Address(RVA="0x2C339D4", Offset="0x2C339D4", VA="0x2C339D4", Slot="18")]
	public void HandleDispatchAction(DRevSdkPurchaseResponseAction action)
	{
	}

	[Address(RVA="0x2C33BD8", Offset="0x2C33BD8", VA="0x2C33BD8", Slot="5")]
	public void HandleDispatchAction(DPlayerChangeAction action)
	{
	}

	[Address(RVA="0x2C33FD8", Offset="0x2C33FD8", VA="0x2C33FD8", Slot="6")]
	public void HandleDispatchAction(DPlayerLevelUpAction action)
	{
	}

	[Address(RVA="0x2C3408C", Offset="0x2C3408C", VA="0x2C3408C", Slot="7")]
	public void HandleDispatchAction(DPlayerClubChangedAction action)
	{
	}

	[Address(RVA="0x2C348E4", Offset="0x2C348E4", VA="0x2C348E4", Slot="8")]
	public void HandleDispatchAction(DInventoryDeltaProcessedAction action)
	{
	}

	[Address(RVA="0x2C34CD0", Offset="0x2C34CD0", VA="0x2C34CD0", Slot="9")]
	public void HandleDispatchAction(DBuyStoreItemInventoryDeltaAction action)
	{
	}

	[Address(RVA="0x2C35074", Offset="0x2C35074", VA="0x2C35074", Slot="10")]
	public void HandleDispatchAction(DRevSdkShowVgp action)
	{
	}

	[Address(RVA="0x2C355A8", Offset="0x2C355A8", VA="0x2C355A8", Slot="11")]
	public void HandleDispatchAction(DRevSdkShowRewardInterstitialAction action)
	{
	}

	[Address(RVA="0x2C35934", Offset="0x2C35934", VA="0x2C35934", Slot="12")]
	public void HandleDispatchAction(DRevSdkShowOfferWallAction action)
	{
	}

	[Address(RVA="0x2C35A88", Offset="0x2C35A88", VA="0x2C35A88", Slot="13")]
	public void HandleDispatchAction(DRevSdkRewardInterstitialValidationFailAction action)
	{
	}

	[Address(RVA="0x2C35B18", Offset="0x2C35B18", VA="0x2C35B18", Slot="14")]
	public void HandleDispatchAction(DRevSdkLogEventAction action)
	{
	}

	[Address(RVA="0x2C36A54", Offset="0x2C36A54", VA="0x2C36A54", Slot="15")]
	public void HandleDispatchAction(DRevSdkLogInventoryDeltaAction action)
	{
	}

	[Address(RVA="0x2C375C8", Offset="0x2C375C8", VA="0x2C375C8", Slot="16")]
	public void HandleDispatchAction(DRevSdkLogPlayerSnapshotAction action)
	{
	}

	[Address(RVA="0x2C39430", Offset="0x2C39430", VA="0x2C39430", Slot="17")]
	public void HandleDispatchAction(DRevSdkLogAppTrackingEventAction action)
	{
	}

	[Address(RVA="0x2C39438", Offset="0x2C39438", VA="0x2C39438", Slot="19")]
	public void HandleDispatchAction(DPushNotificationTokenChangedAction action)
	{
	}

	[Address(RVA="0x2C3943C", Offset="0x2C3943C", VA="0x2C3943C", Slot="20")]
	public void HandleDispatchAction(DRevSdkUnitPromotedOrTieredAction action)
	{
	}

	[Address(RVA="0x2C33228", Offset="0x2C33228", VA="0x2C33228")]
	public void IncrementUserAttribute(string key, int amount)
	{
	}

	[Address(RVA="0x2C33524", Offset="0x2C33524", VA="0x2C33524")]
	public void IncrementUserAttribute(string key, long amount)
	{
	}

	[Address(RVA="0x2C2FFA0", Offset="0x2C2FFA0", VA="0x2C2FFA0")]
	public void Initialize()
	{
	}

	[Address(RVA="0x2C32ACC", Offset="0x2C32ACC", VA="0x2C32ACC")]
	public bool IsIapProductValid(string productId)
	{
		return new bool();
	}

	[Address(RVA="0x2C328E8", Offset="0x2C328E8", VA="0x2C328E8")]
	private static bool IsPlatformValidForRevSdk()
	{
		return new bool();
	}

	[Address(RVA="0x2C394A0", Offset="0x2C394A0", VA="0x2C394A0")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x2C2FD24", Offset="0x2C2FD24", VA="0x2C2FD24")]
	public static string LoadConfig(string sdkName)
	{
		return null;
	}

	[Address(RVA="0x2C34114", Offset="0x2C34114", VA="0x2C34114")]
	private void LogAppTrackingEvent(RevSdkAppTrackingEvent trackingEvent, int value)
	{
	}

	[Address(RVA="0x2C35BDC", Offset="0x2C35BDC", VA="0x2C35BDC")]
	private void LogEvent(string name, string st1, string st2, string st3, long? val, long? referenceId, IDictionary<string, object> data, bool includePlayerData = true)
	{
	}

	[Address(RVA="0x2C36A68", Offset="0x2C36A68", VA="0x2C36A68")]
	private void LogInventoryDelta(string name, string st3, long referenceId, InventoryDelta delta, IDictionary<string, object> baseData)
	{
	}

	[Address(RVA="0x2C3AB44", Offset="0x2C3AB44", VA="0x2C3AB44")]
	private void MarketingDynamicLinkReceived(DynamicLinkEvent linkEvent)
	{
	}

	[Address(RVA="0x2C39D50", Offset="0x2C39D50", VA="0x2C39D50")]
	private void PlacementEventReceived(PlacementEvent evt)
	{
	}

	[Address(RVA="0x2C3A298", Offset="0x2C3A298", VA="0x2C3A298")]
	private void PlacementEventReceivedOfferWall(PlacementEvent evt)
	{
	}

	[Address(RVA="0x2C39ECC", Offset="0x2C39ECC", VA="0x2C39ECC")]
	private void PlacementEventReceivedRewardedInterstitial(PlacementEvent evt)
	{
	}

	[Address(RVA="0x2C394A8", Offset="0x2C394A8", VA="0x2C394A8")]
	private void ProcessVGPActions(Csdk.GluCentralServices.CustomAction customAction)
	{
	}

	[Address(RVA="0x2C3A460", Offset="0x2C3A460", VA="0x2C3A460")]
	private void PurchaseEventReceived(PurchaseEvent evt)
	{
	}

	[Address(RVA="0x2C39850", Offset="0x2C39850", VA="0x2C39850")]
	private void PurchaseIap(string productName)
	{
	}

	[Address(RVA="0x2C399E8", Offset="0x2C399E8", VA="0x2C399E8")]
	private void PurchaseNonIap(string productString)
	{
	}

	[Address(RVA="0x2C3A76C", Offset="0x2C3A76C", VA="0x2C3A76C")]
	private void QueryEventReceived(QueryEvent evt)
	{
	}

	[Address(RVA="0x2C32650", Offset="0x2C32650", VA="0x2C32650")]
	public void QueryIapProducts(Action finished)
	{
	}

	[Address(RVA="0x2C39B50", Offset="0x2C39B50", VA="0x2C39B50")]
	private void RequestDirectStoreItemBuy(ulong storeItemId)
	{
	}

	[Address(RVA="0x2C32098", Offset="0x2C32098", VA="0x2C32098")]
	private void RequestIapItemsFromServer(PurchaseEvent evt, bool deferred)
	{
	}

	[Address(RVA="0x2C32B80", Offset="0x2C32B80", VA="0x2C32B80")]
	public bool RequestIapPurchase(string productId, string giftId)
	{
		return new bool();
	}

	[Address(RVA="0x2C3110C", Offset="0x2C3110C", VA="0x2C3110C")]
	private void SetPushToken()
	{
	}

	[Address(RVA="0x2C32D48", Offset="0x2C32D48", VA="0x2C32D48")]
	public void SetUserAttribute(string key, bool val)
	{
	}

	[Address(RVA="0x2C32EE4", Offset="0x2C32EE4", VA="0x2C32EE4")]
	public void SetUserAttribute(string key, string val)
	{
	}

	[Address(RVA="0x2C3308C", Offset="0x2C3308C", VA="0x2C3308C")]
	public void SetUserAttribute(string key, int val)
	{
	}

	[Address(RVA="0x2C3338C", Offset="0x2C3338C", VA="0x2C3338C")]
	public void SetUserAttribute(string key, long val)
	{
	}

	[Address(RVA="0x2C33684", Offset="0x2C33684", VA="0x2C33684")]
	public void SetUserAttribute(string key, double val)
	{
	}

	[Address(RVA="0x2C3381C", Offset="0x2C3381C", VA="0x2C3381C")]
	public void SetUserAttribute(string key, DateTime val)
	{
	}

	[Address(RVA="0x2C31DEC", Offset="0x2C31DEC", VA="0x2C31DEC")]
	private void ShowAdErrorDialog()
	{
	}

	[Address(RVA="0x2C3B030", Offset="0x2C3B030", VA="0x2C3B030")]
	private void ShowConsentReceived(ShowConsentResult showConsentResult)
	{
	}

	[Address(RVA="0x2C324B4", Offset="0x2C324B4", VA="0x2C324B4")]
	public void ShowGdprSettings()
	{
	}

	[Address(RVA="0x2C3121C", Offset="0x2C3121C", VA="0x2C3121C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x2C319E0", Offset="0x2C319E0", VA="0x2C319E0")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x2C31ED0", Offset="0x2C31ED0", VA="0x2C31ED0")]
	private void TryLoadRewardAd()
	{
	}

	[Address(RVA="0x2C35638", Offset="0x2C35638", VA="0x2C35638")]
	private bool TryShowRewardAd()
	{
		return new bool();
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C8AC", Offset="0x104C8AC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static RevSdkController.<>c <>9;

		[Address(RVA="0x2C3B244", Offset="0x2C3B244", VA="0x2C3B244")]
		static <>c()
		{
		}

		[Address(RVA="0x2C3B2A8", Offset="0x2C3B2A8", VA="0x2C3B2A8")]
		public <>c()
		{
		}

		[Address(RVA="0x2C3B3C4", Offset="0x2C3B3C4", VA="0x2C3B3C4")]
		internal void <HandleDispatchAction>g__PayloadCallback|37_1(PayloadResult result)
		{
		}

		[Address(RVA="0x2C3B2B0", Offset="0x2C3B2B0", VA="0x2C3B2B0")]
		internal void <HandleDispatchAction>g__TagCallback|37_0(string tag, string tagMetadata)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C89C", Offset="0x104C89C")]
	private sealed class <>c__DisplayClass17_0
	{
		[FieldOffset(Offset="0x10")]
		public RevSdkController <>4__this;

		[FieldOffset(Offset="0x18")]
		public bool validRevSdk;

		[FieldOffset(Offset="0x20")]
		public Action finished;

		[Address(RVA="0x2C328E0", Offset="0x2C328E0", VA="0x2C328E0")]
		public <>c__DisplayClass17_0()
		{
		}

		[Address(RVA="0x2C3B3C8", Offset="0x2C3B3C8", VA="0x2C3B3C8")]
		internal void <QueryIapProducts>b__0(IapCatalogResponse response)
		{
		}

		[Address(RVA="0x2C3BB24", Offset="0x2C3BB24", VA="0x2C3BB24")]
		internal void <QueryIapProducts>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C8BC", Offset="0x104C8BC")]
	private sealed class <>c__DisplayClass62_0
	{
		[FieldOffset(Offset="0x10")]
		public RevSdkController <>4__this;

		[FieldOffset(Offset="0x18")]
		public PurchaseEvent evt;

		[FieldOffset(Offset="0x20")]
		public bool deferred;

		[Address(RVA="0x2C3B128", Offset="0x2C3B128", VA="0x2C3B128")]
		public <>c__DisplayClass62_0()
		{
		}

		[Address(RVA="0x2C3BBC0", Offset="0x2C3BBC0", VA="0x2C3BBC0")]
		internal void <RequestIapItemsFromServer>b__0(BuyStoreItemResponse response)
		{
		}

		[Address(RVA="0x2C3C180", Offset="0x2C3C180", VA="0x2C3C180")]
		internal void <RequestIapItemsFromServer>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C8CC", Offset="0x104C8CC")]
	private sealed class <>c__DisplayClass63_0
	{
		[FieldOffset(Offset="0x10")]
		public RevSdkController <>4__this;

		[FieldOffset(Offset="0x18")]
		public ulong storeItemId;

		[Address(RVA="0x2C3B130", Offset="0x2C3B130", VA="0x2C3B130")]
		public <>c__DisplayClass63_0()
		{
		}

		[Address(RVA="0x2C3C45C", Offset="0x2C3C45C", VA="0x2C3C45C")]
		internal void <RequestDirectStoreItemBuy>b__0(BuyStoreItemDirectResponse response)
		{
		}

		[Address(RVA="0x2C3C600", Offset="0x2C3C600", VA="0x2C3C600")]
		internal void <RequestDirectStoreItemBuy>b__1(long failureCode)
		{
		}

		[Address(RVA="0x2C3C7A4", Offset="0x2C3C7A4", VA="0x2C3C7A4")]
		internal void <RequestDirectStoreItemBuy>g__HideScrim|2()
		{
		}
	}

	[Serializable]
	private class VgpVariantPayload
	{
		[FieldOffset(Offset="0x10")]
		public string Vgp;

		[Address(RVA="0x2C3C818", Offset="0x2C3C818", VA="0x2C3C818")]
		public VgpVariantPayload()
		{
		}
	}
}