using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ContextualMessageController : ILoggable<LogCategory>, IAssetDependentLifecycleObject, IDispatchHandler<DViewShownAction>, IDispatchHandler, IDispatchHandler<DViewHiddenAction>, IDispatchHandler<DViewReleasedAction>, IDispatchHandler<DContextualMessageDynamicMessagesProcessed>, IDispatchHandler<DPlayerChangeProcessedAction>, IDispatchHandler<DTutorialMessageBubbleViewAction>, IDispatchHandler<DDialogViewAction>
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10575E8", Offset="0x10575E8")]
	[FieldOffset(Offset="0x10")]
	private bool <SuppressNewMessageGroups>k__BackingField;

	[Attribute(Name="InjectAttribute", RVA="0x10575F8", Offset="0x10575F8")]
	[FieldOffset(Offset="0x18")]
	private InputSystem _inputSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1057608", Offset="0x1057608")]
	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x1057618", Offset="0x1057618")]
	[FieldOffset(Offset="0x28")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1057628", Offset="0x1057628")]
	[FieldOffset(Offset="0x30")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1057638", Offset="0x1057638")]
	[FieldOffset(Offset="0x38")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x1057648", Offset="0x1057648")]
	[FieldOffset(Offset="0x40")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x1057658", Offset="0x1057658")]
	[FieldOffset(Offset="0x48")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1057668", Offset="0x1057668")]
	[FieldOffset(Offset="0x50")]
	private InventoryUtility _inventoryUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1057678", Offset="0x1057678")]
	[FieldOffset(Offset="0x58")]
	private PassportSeasonUtility _passportSeasonUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1057688", Offset="0x1057688")]
	[FieldOffset(Offset="0x60")]
	private CampaignUtility _campaignUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1057698", Offset="0x1057698")]
	[FieldOffset(Offset="0x68")]
	private GameStateMachine _gameStateMachine;

	[FieldOffset(Offset="0x70")]
	private TutorialPointAtView _pointAtView;

	[FieldOffset(Offset="0x78")]
	private TutorialMessageBubbleView _messageBubbleView;

	[FieldOffset(Offset="0x80")]
	private TutorialDialogView _dialogView;

	[FieldOffset(Offset="0x88")]
	private SeekerView _seekerView;

	[FieldOffset(Offset="0x90")]
	private TransientScrimView _transientScrimView;

	[FieldOffset(Offset="0x98")]
	private ContextualMessageGroup? _activeMessageGroup;

	[FieldOffset(Offset="0xB0")]
	private long _activeTelemetryRefId;

	[FieldOffset(Offset="0xB8")]
	private int _currentMessageIndex;

	[FieldOffset(Offset="0xBC")]
	private bool _isShutdown;

	[FieldOffset(Offset="0xC0")]
	private DialogContext _dialogContext;

	public ulong ActiveMessageGroupId
	{
		[Address(RVA="0x1547674", Offset="0x1547674", VA="0x1547674")]
		get
		{
			return new ulong();
		}
	}

	public int CurrentMessageIndex
	{
		[Address(RVA="0x1547708", Offset="0x1547708", VA="0x1547708")]
		get
		{
			return new int();
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x154766C", Offset="0x154766C", VA="0x154766C", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	public bool SuppressNewMessageGroups
	{
		[Address(RVA="0x1547710", Offset="0x1547710", VA="0x1547710")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F344", Offset="0x106F344")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x1547718", Offset="0x1547718", VA="0x1547718")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F354", Offset="0x106F354")]
		set
		{
		}
	}

	[Address(RVA="0x154ADE8", Offset="0x154ADE8", VA="0x154ADE8")]
	public ContextualMessageController()
	{
	}

	[Address(RVA="0x154AE50", Offset="0x154AE50", VA="0x154AE50")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F364", Offset="0x106F364")]
	private void <HandleIsolatedInputObjectClicked>b__26_0()
	{
	}

	[Address(RVA="0x15480C0", Offset="0x15480C0", VA="0x15480C0")]
	private void CheckForNewActiveMessageGroup(AView shownView)
	{
	}

	[Address(RVA="0x1548AF0", Offset="0x1548AF0", VA="0x1548AF0")]
	private void CheckViewHiddenTrigger(Type hiddenViewType)
	{
	}

	[Address(RVA="0x154AD18", Offset="0x154AD18", VA="0x154AD18")]
	private void DismissActiveMessageGroup()
	{
	}

	[Address(RVA="0x154AA98", Offset="0x154AA98", VA="0x154AA98")]
	private void DismissActiveMessageGroup(Action messageGroupDismissed)
	{
	}

	[Address(RVA="0x1547C08", Offset="0x1547C08", VA="0x1547C08")]
	public void ForceClearCurrentActiveMessageGroup()
	{
	}

	[Address(RVA="0x1547FB4", Offset="0x1547FB4", VA="0x1547FB4", Slot="9")]
	public void HandleDispatchAction(DViewShownAction action)
	{
	}

	[Address(RVA="0x1548A5C", Offset="0x1548A5C", VA="0x1548A5C", Slot="10")]
	public void HandleDispatchAction(DViewHiddenAction action)
	{
	}

	[Address(RVA="0x1548C58", Offset="0x1548C58", VA="0x1548C58", Slot="11")]
	public void HandleDispatchAction(DViewReleasedAction action)
	{
	}

	[Address(RVA="0x1548C5C", Offset="0x1548C5C", VA="0x1548C5C", Slot="12")]
	public void HandleDispatchAction(DContextualMessageDynamicMessagesProcessed action)
	{
	}

	[Address(RVA="0x1549074", Offset="0x1549074", VA="0x1549074", Slot="13")]
	public void HandleDispatchAction(DPlayerChangeProcessedAction action)
	{
	}

	[Address(RVA="0x1549078", Offset="0x1549078", VA="0x1549078", Slot="14")]
	public void HandleDispatchAction(DTutorialMessageBubbleViewAction action)
	{
	}

	[Address(RVA="0x1549348", Offset="0x1549348", VA="0x1549348", Slot="15")]
	public void HandleDispatchAction(DDialogViewAction action)
	{
	}

	[Address(RVA="0x154AD28", Offset="0x154AD28", VA="0x154AD28")]
	private void HandleGameStateEntering(AGameState gameState)
	{
	}

	[Address(RVA="0x154ADCC", Offset="0x154ADCC", VA="0x154ADCC")]
	private void HandleGameStateExiting(AGameState gameState)
	{
	}

	[Address(RVA="0x15493C4", Offset="0x15493C4", VA="0x15493C4")]
	private void HandleIsolatedInputObjectClicked()
	{
	}

	[Address(RVA="0x1547724", Offset="0x1547724", VA="0x1547724", Slot="5")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x154915C", Offset="0x154915C", VA="0x154915C")]
	private bool IsCurrentMessageIndexInRange()
	{
		return new bool();
	}

	[Address(RVA="0x1547F2C", Offset="0x1547F2C", VA="0x1547F2C")]
	public bool IsCurrentMessageShowing()
	{
		return new bool();
	}

	[Address(RVA="0x1547F9C", Offset="0x1547F9C", VA="0x1547F9C")]
	public bool IsPointAtShowing()
	{
		return new bool();
	}

	[Address(RVA="0x15493BC", Offset="0x15493BC", VA="0x15493BC")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x1547828", Offset="0x1547828", VA="0x1547828", Slot="7")]
	public void LoadAssets(Action finished)
	{
	}

	[Address(RVA="0x154984C", Offset="0x154984C", VA="0x154984C")]
	private bool PassesDisplayCondition(ContextualMessageGroup? messageGroup)
	{
		return new bool();
	}

	[Address(RVA="0x1549200", Offset="0x1549200", VA="0x1549200")]
	private void ProcessDeepLink()
	{
	}

	[Address(RVA="0x1548C60", Offset="0x1548C60", VA="0x1548C60")]
	private void ProcessPlayerUpdate()
	{
	}

	[Address(RVA="0x1549340", Offset="0x1549340", VA="0x1549340")]
	private void ProgressToNextContextualMessageInActiveGroup()
	{
	}

	[Address(RVA="0x1549438", Offset="0x1549438", VA="0x1549438")]
	private void ProgressToNextContextualMessageInActiveGroup(Action progressUpdatedCallback)
	{
	}

	[Address(RVA="0x1547C30", Offset="0x1547C30", VA="0x1547C30", Slot="8")]
	public void ReleaseAssets()
	{
	}

	[Address(RVA="0x1547DCC", Offset="0x1547DCC", VA="0x1547DCC")]
	private void ResetCurrentMessageIndex()
	{
	}

	[Address(RVA="0x154A174", Offset="0x154A174", VA="0x154A174")]
	private void ShowCurrentMessage(AView triggeredView)
	{
	}

	[Address(RVA="0x1547A64", Offset="0x1547A64", VA="0x1547A64", Slot="6")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1547D40", Offset="0x1547D40", VA="0x1547D40")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1548800", Offset="0x1548800", VA="0x1548800")]
	private void TryToShowCurrentMessage(bool ignoreViewHiddenTriggers = false)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BC6C", Offset="0x104BC6C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static ContextualMessageController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Func<AView, bool> <>9__27_0;

		[FieldOffset(Offset="0x10")]
		public static Func<AView, bool> <>9__28_0;

		[FieldOffset(Offset="0x18")]
		public static Func<AView, bool> <>9__29_0;

		[Address(RVA="0x154AF38", Offset="0x154AF38", VA="0x154AF38")]
		static <>c()
		{
		}

		[Address(RVA="0x154AF9C", Offset="0x154AF9C", VA="0x154AF9C")]
		public <>c()
		{
		}

		[Address(RVA="0x154AFA4", Offset="0x154AFA4", VA="0x154AFA4")]
		internal bool <CheckForNewActiveMessageGroup>b__27_0(AView view)
		{
			return new bool();
		}

		[Address(RVA="0x154B054", Offset="0x154B054", VA="0x154B054")]
		internal bool <ShowCurrentMessage>b__29_0(AView view)
		{
			return new bool();
		}

		[Address(RVA="0x154AFFC", Offset="0x154AFFC", VA="0x154AFFC")]
		internal bool <TryToShowCurrentMessage>b__28_0(AView view)
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BC0C", Offset="0x104BC0C")]
	private sealed class <>c__DisplayClass12_0
	{
		[FieldOffset(Offset="0x10")]
		public ContextualMessageController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x1547D38", Offset="0x1547D38", VA="0x1547D38")]
		public <>c__DisplayClass12_0()
		{
		}

		[Address(RVA="0x154B088", Offset="0x154B088", VA="0x154B088")]
		internal void <LoadAssets>b__0(Action jobFinished)
		{
		}

		[Address(RVA="0x154B1CC", Offset="0x154B1CC", VA="0x154B1CC")]
		internal void <LoadAssets>b__1(Action jobFinished)
		{
		}

		[Address(RVA="0x154B310", Offset="0x154B310", VA="0x154B310")]
		internal void <LoadAssets>b__2(Action jobFinished)
		{
		}

		[Address(RVA="0x154B454", Offset="0x154B454", VA="0x154B454")]
		internal void <LoadAssets>b__3(Action jobFinished)
		{
		}

		[Address(RVA="0x154B598", Offset="0x154B598", VA="0x154B598")]
		internal void <LoadAssets>b__4(Action jobFinished)
		{
		}

		[Address(RVA="0x154B6DC", Offset="0x154B6DC", VA="0x154B6DC")]
		internal void <LoadAssets>b__5()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BC1C", Offset="0x104BC1C")]
	private sealed class <>c__DisplayClass12_1
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[FieldOffset(Offset="0x18")]
		public ContextualMessageController.<>c__DisplayClass12_0 CS$<>8__locals1;

		[Address(RVA="0x154B1C4", Offset="0x154B1C4", VA="0x154B1C4")]
		public <>c__DisplayClass12_1()
		{
		}

		[Address(RVA="0x154B754", Offset="0x154B754", VA="0x154B754")]
		internal void <LoadAssets>b__6(TutorialPointAtView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BC2C", Offset="0x104BC2C")]
	private sealed class <>c__DisplayClass12_2
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[FieldOffset(Offset="0x18")]
		public ContextualMessageController.<>c__DisplayClass12_0 CS$<>8__locals2;

		[Address(RVA="0x154B308", Offset="0x154B308", VA="0x154B308")]
		public <>c__DisplayClass12_2()
		{
		}

		[Address(RVA="0x154B7BC", Offset="0x154B7BC", VA="0x154B7BC")]
		internal void <LoadAssets>b__7(TutorialMessageBubbleView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BC3C", Offset="0x104BC3C")]
	private sealed class <>c__DisplayClass12_3
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[FieldOffset(Offset="0x18")]
		public ContextualMessageController.<>c__DisplayClass12_0 CS$<>8__locals3;

		[Address(RVA="0x154B44C", Offset="0x154B44C", VA="0x154B44C")]
		public <>c__DisplayClass12_3()
		{
		}

		[Address(RVA="0x154B824", Offset="0x154B824", VA="0x154B824")]
		internal void <LoadAssets>b__8(TutorialDialogView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BC4C", Offset="0x104BC4C")]
	private sealed class <>c__DisplayClass12_4
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[FieldOffset(Offset="0x18")]
		public ContextualMessageController.<>c__DisplayClass12_0 CS$<>8__locals4;

		[Address(RVA="0x154B590", Offset="0x154B590", VA="0x154B590")]
		public <>c__DisplayClass12_4()
		{
		}

		[Address(RVA="0x154B88C", Offset="0x154B88C", VA="0x154B88C")]
		internal void <LoadAssets>b__9(SeekerView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BC5C", Offset="0x104BC5C")]
	private sealed class <>c__DisplayClass12_5
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[FieldOffset(Offset="0x18")]
		public ContextualMessageController.<>c__DisplayClass12_0 CS$<>8__locals5;

		[Address(RVA="0x154B6D4", Offset="0x154B6D4", VA="0x154B6D4")]
		public <>c__DisplayClass12_5()
		{
		}

		[Address(RVA="0x154B8F4", Offset="0x154B8F4", VA="0x154B8F4")]
		internal void <LoadAssets>b__10(TransientScrimView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BC7C", Offset="0x104BC7C")]
	private sealed class <>c__DisplayClass34_0
	{
		[FieldOffset(Offset="0x10")]
		public ContextualMessageController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action messageGroupDismissed;

		[FieldOffset(Offset="0x20")]
		public DismissContextualMessageRequest request;

		[Address(RVA="0x154AD20", Offset="0x154AD20", VA="0x154AD20")]
		public <>c__DisplayClass34_0()
		{
		}

		[Address(RVA="0x154B95C", Offset="0x154B95C", VA="0x154B95C")]
		internal void <DismissActiveMessageGroup>b__0(DismissContextualMessageResponse response)
		{
		}

		[Address(RVA="0x154BC84", Offset="0x154BC84", VA="0x154BC84")]
		internal void <DismissActiveMessageGroup>b__1(long failureCode)
		{
		}

		[Address(RVA="0x154BD98", Offset="0x154BD98", VA="0x154BD98")]
		internal void <DismissActiveMessageGroup>b__2()
		{
		}
	}
}