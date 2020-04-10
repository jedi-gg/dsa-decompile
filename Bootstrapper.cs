using Glunies;
using Il2CppDummyDll;
using System;
using Zenject;

public class Bootstrapper : IInitializable, ILoggable<LogCategory>
{
	[Attribute(Name="InjectAttribute", RVA="0x1054DA4", Offset="0x1054DA4")]
	[FieldOffset(Offset="0x10")]
	private DiContainer _gameContainer;

	[Attribute(Name="InjectAttribute", RVA="0x1054DB4", Offset="0x1054DB4")]
	[FieldOffset(Offset="0x18")]
	private InputSystem _inputSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1054DC4", Offset="0x1054DC4")]
	[FieldOffset(Offset="0x20")]
	private UiInputReactController _inputReactController;

	[Attribute(Name="InjectAttribute", RVA="0x1054DD4", Offset="0x1054DD4")]
	[FieldOffset(Offset="0x28")]
	private GameLanguageManager _gameLanguageManager;

	[Attribute(Name="InjectAttribute", RVA="0x1054DE4", Offset="0x1054DE4")]
	[FieldOffset(Offset="0x30")]
	private GameStateMachine _gameStateMachine;

	[Attribute(Name="InjectAttribute", RVA="0x1054DF4", Offset="0x1054DF4")]
	[FieldOffset(Offset="0x38")]
	private GameStateMachineNavigationTracker _gameStateMachineNavigationTracker;

	[Attribute(Name="InjectAttribute", RVA="0x1054E04", Offset="0x1054E04")]
	[FieldOffset(Offset="0x40")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1054E14", Offset="0x1054E14")]
	[FieldOffset(Offset="0x48")]
	private BackdropController _backdropController;

	[Attribute(Name="InjectAttribute", RVA="0x1054E24", Offset="0x1054E24")]
	[FieldOffset(Offset="0x50")]
	private ScrimController _scrimController;

	[Attribute(Name="InjectAttribute", RVA="0x1054E34", Offset="0x1054E34")]
	[FieldOffset(Offset="0x58")]
	private AssetManager _assetManager;

	[Attribute(Name="InjectAttribute", RVA="0x1054E44", Offset="0x1054E44")]
	[FieldOffset(Offset="0x60")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x1054E54", Offset="0x1054E54")]
	[FieldOffset(Offset="0x68")]
	private SystemDialogManager _systemDialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x1054E64", Offset="0x1054E64")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1054E74", Offset="0x1054E74")]
	[FieldOffset(Offset="0x78")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1054E84", Offset="0x1054E84")]
	[FieldOffset(Offset="0x80")]
	private LocalizationManager _localizationManager;

	[Attribute(Name="InjectAttribute", RVA="0x1054E94", Offset="0x1054E94")]
	[FieldOffset(Offset="0x88")]
	private BadgingController _badgingController;

	[Attribute(Name="InjectAttribute", RVA="0x1054EA4", Offset="0x1054EA4")]
	[FieldOffset(Offset="0x90")]
	private DeepLinkHandler _deepLinkHandler;

	[Attribute(Name="InjectAttribute", RVA="0x1054EB4", Offset="0x1054EB4")]
	[FieldOffset(Offset="0x98")]
	private IHapticController _hapticController;

	[Attribute(Name="InjectAttribute", RVA="0x1054EC4", Offset="0x1054EC4")]
	[FieldOffset(Offset="0xA0")]
	private EnergyGenerateController _energyGenerateController;

	[Attribute(Name="InjectAttribute", RVA="0x1054ED4", Offset="0x1054ED4")]
	[FieldOffset(Offset="0xA8")]
	private UiAnimatedGradientEffectController _uiAnimatedGradientEffectController;

	[Attribute(Name="InjectAttribute", RVA="0x1054EE4", Offset="0x1054EE4")]
	[FieldOffset(Offset="0xB0")]
	private GameServiceManager _gameServiceManager;

	[Attribute(Name="InjectAttribute", RVA="0x1054EF4", Offset="0x1054EF4")]
	[FieldOffset(Offset="0xB8")]
	private Procrastinator _procrastinator;

	[Attribute(Name="InjectAttribute", RVA="0x1054F04", Offset="0x1054F04")]
	[FieldOffset(Offset="0xC0")]
	private CrashController _crashController;

	[Attribute(Name="InjectAttribute", RVA="0x1054F14", Offset="0x1054F14")]
	[FieldOffset(Offset="0xC8")]
	private IAssetDependentInitializer _assetDependentInitializer;

	[Attribute(Name="InjectAttribute", RVA="0x1054F24", Offset="0x1054F24")]
	[FieldOffset(Offset="0xD0")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1054F34", Offset="0x1054F34")]
	[FieldOffset(Offset="0xD8")]
	private DownloadOverlayController _downloadOverlayController;

	[Attribute(Name="InjectAttribute", RVA="0x1054F44", Offset="0x1054F44")]
	[FieldOffset(Offset="0xE0")]
	private ItemFindTracker _itemFindTracker;

	[Attribute(Name="InjectAttribute", RVA="0x1054F54", Offset="0x1054F54")]
	[FieldOffset(Offset="0xE8")]
	private ChatDomainController _chatDc;

	[Attribute(Name="InjectAttribute", RVA="0x1054F64", Offset="0x1054F64")]
	[FieldOffset(Offset="0xF0")]
	private CardUnlockTrackerController _cardUnlockTrackerController;

	[Attribute(Name="InjectAttribute", RVA="0x1054F74", Offset="0x1054F74")]
	[FieldOffset(Offset="0xF8")]
	private SharedPrefs _sharedPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x1054F84", Offset="0x1054F84")]
	[FieldOffset(Offset="0x100")]
	private IGameServiceTransport _gameServiceTransport;

	[Attribute(Name="InjectAttribute", RVA="0x1054F94", Offset="0x1054F94")]
	[FieldOffset(Offset="0x108")]
	private RevSdkController _revSdkController;

	[Attribute(Name="InjectAttribute", RVA="0x1054FA4", Offset="0x1054FA4")]
	[FieldOffset(Offset="0x110")]
	private GamedataManager _gamedataManager;

	[Attribute(Name="InjectAttribute", RVA="0x1054FB4", Offset="0x1054FB4")]
	[FieldOffset(Offset="0x118")]
	private ANotificationController _notificationController;

	[Attribute(Name="InjectAttribute", RVA="0x1054FC4", Offset="0x1054FC4")]
	[FieldOffset(Offset="0x120")]
	private HelpshiftController _helpshiftController;

	[Attribute(Name="InjectAttribute", RVA="0x1054FD4", Offset="0x1054FD4")]
	[FieldOffset(Offset="0x128")]
	private HomeServiceUtility _homeServiceUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1054FE4", Offset="0x1054FE4")]
	[FieldOffset(Offset="0x130")]
	private ProfanityFilter _profanityFilter;

	[Attribute(Name="InjectAttribute", RVA="0x1054FF4", Offset="0x1054FF4")]
	[FieldOffset(Offset="0x138")]
	private HttpService _httpService;

	[Attribute(Name="InjectAttribute", RVA="0x1055004", Offset="0x1055004")]
	[FieldOffset(Offset="0x140")]
	private GraphicsSettings _graphicsSettings;

	[Attribute(Name="InjectAttribute", RVA="0x1055014", Offset="0x1055014")]
	[FieldOffset(Offset="0x148")]
	private CostController _costController;

	[Attribute(Name="InjectAttribute", RVA="0x1055024", Offset="0x1055024")]
	[FieldOffset(Offset="0x150")]
	private ClubWarDomainController _clubWarDc;

	[Attribute(Name="InjectAttribute", RVA="0x1055034", Offset="0x1055034")]
	[FieldOffset(Offset="0x158")]
	private FirebaseController _firebaseController;

	[Attribute(Name="InjectAttribute", RVA="0x1055044", Offset="0x1055044")]
	[FieldOffset(Offset="0x160")]
	private EventDomainController _eventDc;

	[Attribute(Name="InjectAttribute", RVA="0x1055054", Offset="0x1055054")]
	[FieldOffset(Offset="0x168")]
	private StoreDomainController _storeDc;

	[Attribute(Name="InjectAttribute", RVA="0x1055064", Offset="0x1055064")]
	[FieldOffset(Offset="0x170")]
	private ClubDomainController _clubDc;

	[Attribute(Name="InjectAttribute", RVA="0x1055074", Offset="0x1055074")]
	[FieldOffset(Offset="0x178")]
	private FontManager _fontManager;

	[FieldOffset(Offset="0x180")]
	private SyncJobExecutor _executor;

	[FieldOffset(Offset="0x188")]
	private bool _isShutdown;

	public LogCategory LogCategory
	{
		[Address(RVA="0x1120798", Offset="0x1120798", VA="0x1120798", Slot="5")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x11215C0", Offset="0x11215C0", VA="0x11215C0")]
	public Bootstrapper()
	{
	}

	[Address(RVA="0x1121520", Offset="0x1121520", VA="0x1121520")]
	private void FinishBootUp()
	{
	}

	[Address(RVA="0x11207A0", Offset="0x11207A0", VA="0x11207A0", Slot="4")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1120F38", Offset="0x1120F38", VA="0x1120F38")]
	public void Shutdown()
	{
	}
}