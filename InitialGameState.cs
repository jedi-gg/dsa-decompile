using Glunies;
using Il2CppDummyDll;
using System;
using Zenject;

public class InitialGameState : AGameState, IDispatchHandler<DTitleViewAction>, IDispatchHandler, IDispatchHandler<DAutoAuthenticationCompletedAction>, IDispatchHandler<DTutorialAssetsDownloadCompletedAction>, IDispatchHandler<DServerMaintenanceRetryAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x10592B8", Offset="0x10592B8")]
	[FieldOffset(Offset="0x30")]
	private IAssetDownloader _assetDownloader;

	[Attribute(Name="InjectAttribute", RVA="0x10592C8", Offset="0x10592C8")]
	[FieldOffset(Offset="0x38")]
	private ContextualMessageController _contextualMessageController;

	[Attribute(Name="InjectAttribute", RVA="0x10592D8", Offset="0x10592D8")]
	[FieldOffset(Offset="0x40")]
	private RevSdkController _revSdk;

	[Attribute(Name="InjectAttribute", RVA="0x10592E8", Offset="0x10592E8")]
	[FieldOffset(Offset="0x48")]
	private SharedPrefs _sharedPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x10592F8", Offset="0x10592F8")]
	[FieldOffset(Offset="0x50")]
	private TitleController _titleController;

	[Attribute(Name="InjectAttribute", RVA="0x1059308", Offset="0x1059308")]
	[FieldOffset(Offset="0x58")]
	private SystemDialogManager _systemDialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x1059318", Offset="0x1059318")]
	[FieldOffset(Offset="0x60")]
	private DiContainer _diContainer;

	[Attribute(Name="InjectAttribute", RVA="0x1059328", Offset="0x1059328")]
	[FieldOffset(Offset="0x68")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x1059338", Offset="0x1059338")]
	[FieldOffset(Offset="0x70")]
	private MultiplayerRecovery _mpRecovery;

	[Attribute(Name="InjectAttribute", RVA="0x1059348", Offset="0x1059348")]
	[FieldOffset(Offset="0x78")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1059358", Offset="0x1059358")]
	[FieldOffset(Offset="0x80")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1059368", Offset="0x1059368")]
	[FieldOffset(Offset="0x88")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1059378", Offset="0x1059378")]
	[FieldOffset(Offset="0x90")]
	private GameStateMachine _gameStateMachine;

	[Attribute(Name="InjectAttribute", RVA="0x1059388", Offset="0x1059388")]
	[FieldOffset(Offset="0x98")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1059398", Offset="0x1059398")]
	[FieldOffset(Offset="0xA0")]
	private ServerMaintenanceUtil _serverMaintenanceUtil;

	[Attribute(Name="InjectAttribute", RVA="0x10593A8", Offset="0x10593A8")]
	[FieldOffset(Offset="0xA8")]
	private IGameServiceTransport _gameServiceTransport;

	[FieldOffset(Offset="0xB0")]
	private AsyncJobExecutor _startGameDependencyWaiter;

	[FieldOffset(Offset="0xB8")]
	private Action _tutorialAssetsDownloadedCallback;

	[FieldOffset(Offset="0xC0")]
	private Action _playerAuthenticatedCallback;

	[FieldOffset(Offset="0xC8")]
	private Action _titleViewPreCaseOpeningStateReachedCallback;

	[FieldOffset(Offset="0xD0")]
	private Action _serverMaintenanceCallback;

	[FieldOffset(Offset="0xD8")]
	private AutoAuthenticationController _autoAuthenticationController;

	[FieldOffset(Offset="0xE0")]
	private bool _initialized;

	[FieldOffset(Offset="0xE1")]
	private bool _titleLaunched;

	[FieldOffset(Offset="0xE8")]
	private long? _introCinematicPlayedTelemetryRefId;

	public override bool CanBeNavigatedBackInto
	{
		[Address(RVA="0x1184F28", Offset="0x1184F28", VA="0x1184F28", Slot="8")]
		get
		{
			return new bool();
		}
	}

	public override bool ShowGlobalBackdrop
	{
		[Address(RVA="0x1184F30", Offset="0x1184F30", VA="0x1184F30", Slot="10")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1185D64", Offset="0x1185D64", VA="0x1185D64")]
	public InitialGameState()
	{
	}

	[Address(RVA="0x1185EA0", Offset="0x1185EA0", VA="0x1185EA0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FF34", Offset="0x106FF34")]
	private void <CheckServerStatus>b__16_0(DServerMaintenance finished)
	{
	}

	[Address(RVA="0x1185DCC", Offset="0x1185DCC", VA="0x1185DCC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FEE4", Offset="0x106FEE4")]
	private void <Entering>b__4_0(Action finished)
	{
	}

	[Address(RVA="0x1185DD4", Offset="0x1185DD4", VA="0x1185DD4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FEF4", Offset="0x106FEF4")]
	private void <Entering>b__4_1(Action finished)
	{
	}

	[Address(RVA="0x1185DDC", Offset="0x1185DDC", VA="0x1185DDC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FF04", Offset="0x106FF04")]
	private void <Entering>b__4_2(Action finished)
	{
	}

	[Address(RVA="0x1185DE4", Offset="0x1185DE4", VA="0x1185DE4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FF14", Offset="0x106FF14")]
	private void <Entering>b__4_3(Action finished)
	{
	}

	[Address(RVA="0x1185DEC", Offset="0x1185DEC", VA="0x1185DEC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FF24", Offset="0x106FF24")]
	private void <Entering>g__FinishInitialization|4_4()
	{
	}

	[Address(RVA="0x11857CC", Offset="0x11857CC", VA="0x11857CC")]
	private void BypassDownloadPrompt()
	{
	}

	[Address(RVA="0x1185734", Offset="0x1185734", VA="0x1185734")]
	private void CheckServerStatus()
	{
	}

	[Address(RVA="0x1184F38", Offset="0x1184F38", VA="0x1184F38", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	[Address(RVA="0x118535C", Offset="0x118535C", VA="0x118535C", Slot="5")]
	public override void Exiting()
	{
	}

	[Address(RVA="0x118541C", Offset="0x118541C", VA="0x118541C", Slot="12")]
	public void HandleDispatchAction(DTitleViewAction action)
	{
	}

	[Address(RVA="0x11855E4", Offset="0x11855E4", VA="0x11855E4", Slot="13")]
	public void HandleDispatchAction(DAutoAuthenticationCompletedAction action)
	{
	}

	[Address(RVA="0x1185678", Offset="0x1185678", VA="0x1185678", Slot="14")]
	public void HandleDispatchAction(DTutorialAssetsDownloadCompletedAction action)
	{
	}

	[Address(RVA="0x1185730", Offset="0x1185730", VA="0x1185730", Slot="15")]
	public void HandleDispatchAction(DServerMaintenanceRetryAction action)
	{
	}

	[Address(RVA="0x11858A8", Offset="0x11858A8", VA="0x11858A8")]
	private void InitialDownloadPromptConfirmed()
	{
	}

	[Address(RVA="0x11858A4", Offset="0x11858A4", VA="0x11858A4")]
	private void PromptInitialDownload()
	{
	}

	[Address(RVA="0x11859E8", Offset="0x11859E8", VA="0x11859E8")]
	private void StartGame()
	{
	}

	[Address(RVA="0x11851CC", Offset="0x11851CC", VA="0x11851CC", Slot="11")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x118521C", Offset="0x118521C", VA="0x118521C")]
	private void TryLaunchTitleView()
	{
	}

	[Address(RVA="0x1185514", Offset="0x1185514", VA="0x1185514")]
	private void TryStartPlayerAuthentication()
	{
	}
}