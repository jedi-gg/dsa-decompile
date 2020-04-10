using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class CardUnlockTrackerController : IDispatchHandler<DCardUnlockTrackerViewAction>, IDispatchHandler, IDispatchHandler<DInventoryDeltaProcessedAction>, IDispatchHandler<DPlayerChangeAction>, IDispatchHandler<DUnitSkinsViewedAction>, IDispatchHandler<DEmoteInventoryItemSelectAction>, IDispatchHandler<DUnitGearTierUpAction>, IDispatchHandler<DUnitUnlockedAction>, IDispatchHandler<DSpellUnlockedAction>, IDispatchHandler<DPinViewedAction>
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1055928", Offset="0x1055928")]
	[FieldOffset(Offset="0x10")]
	private bool <UnlockedAnyUnitOrSpellThisSession>k__BackingField;

	[Attribute(Name="InjectAttribute", RVA="0x1055938", Offset="0x1055938")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1055948", Offset="0x1055948")]
	[FieldOffset(Offset="0x20")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1055958", Offset="0x1055958")]
	[FieldOffset(Offset="0x28")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1055968", Offset="0x1055968")]
	[FieldOffset(Offset="0x30")]
	private InventoryUtility _inventoryUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1055978", Offset="0x1055978")]
	[FieldOffset(Offset="0x38")]
	private AccountPrefs _accountPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x1055988", Offset="0x1055988")]
	[FieldOffset(Offset="0x40")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x1055998", Offset="0x1055998")]
	[FieldOffset(Offset="0x48")]
	private GameStateMachine _gameStateMachine;

	[Attribute(Name="InjectAttribute", RVA="0x10559A8", Offset="0x10559A8")]
	[FieldOffset(Offset="0x50")]
	private ContextualMessageController _contextualMessageController;

	[FieldOffset(Offset="0x58")]
	private List<ulong> _newUnlockableUnitIds;

	[FieldOffset(Offset="0x60")]
	private List<ulong> _newUnlockableSpellIds;

	[FieldOffset(Offset="0x68")]
	private SortedSet<ulong> _newUnitSkinsByUnitId;

	[FieldOffset(Offset="0x70")]
	private SortedSet<ulong> _newEmotes;

	[FieldOffset(Offset="0x78")]
	private SortedSet<ulong> _newPins;

	[FieldOffset(Offset="0x80")]
	private Dictionary<ulong, List<int>> _newUnitAbilityUnlocks;

	[FieldOffset(Offset="0x88")]
	private CardUnlockTrackerView _view;

	[FieldOffset(Offset="0x90")]
	private bool _viewIsLoading;

	[FieldOffset(Offset="0x91")]
	private bool _isShutdown;

	[FieldOffset(Offset="0x98")]
	private string _lastPlayerId;

	public bool UnlockedAnyUnitOrSpellThisSession
	{
		[Address(RVA="0x1192EEC", Offset="0x1192EEC", VA="0x1192EEC")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E9D8", Offset="0x106E9D8")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x1192EF4", Offset="0x1192EF4", VA="0x1192EF4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E9E8", Offset="0x106E9E8")]
		private set
		{
		}
	}

	[Address(RVA="0x11952F4", Offset="0x11952F4", VA="0x11952F4")]
	public CardUnlockTrackerController()
	{
	}

	[Address(RVA="0x1195404", Offset="0x1195404", VA="0x1195404")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E9F8", Offset="0x106E9F8")]
	private void <Show>b__7_0(CardUnlockTrackerView view)
	{
	}

	[Address(RVA="0x11933F0", Offset="0x11933F0", VA="0x11933F0")]
	public bool EmoteIsNew(ulong emoteId)
	{
		return new bool();
	}

	[Address(RVA="0x199FCD8", Offset="0x199FCD8", VA="0x199FCD8")]
	private void EnterState<TState>(GameStateTransitionContext context = // 
	// Current member / type: System.Void CardUnlockTrackerController::EnterState(Glunies.GameStateTransitionContext)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void EnterState(Glunies.GameStateTransitionContext)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1193540", Offset="0x1193540", VA="0x1193540")]
	public bool GetAndConsumeNewAbilityUnlockForUnit(ulong unitId, int abilityId)
	{
		return new bool();
	}

	[Address(RVA="0x1193390", Offset="0x1193390", VA="0x1193390")]
	public int GetNumNewEmotes()
	{
		return new int();
	}

	[Address(RVA="0x1193430", Offset="0x1193430", VA="0x1193430")]
	public int GetNumNewPins()
	{
		return new int();
	}

	[Address(RVA="0x1193738", Offset="0x1193738", VA="0x1193738", Slot="4")]
	public void HandleDispatchAction(DCardUnlockTrackerViewAction action)
	{
	}

	[Address(RVA="0x1193870", Offset="0x1193870", VA="0x1193870", Slot="5")]
	public void HandleDispatchAction(DInventoryDeltaProcessedAction action)
	{
	}

	[Address(RVA="0x1194B64", Offset="0x1194B64", VA="0x1194B64", Slot="6")]
	public void HandleDispatchAction(DPlayerChangeAction action)
	{
	}

	[Address(RVA="0x1194D28", Offset="0x1194D28", VA="0x1194D28", Slot="7")]
	public void HandleDispatchAction(DUnitSkinsViewedAction action)
	{
	}

	[Address(RVA="0x1194DDC", Offset="0x1194DDC", VA="0x1194DDC", Slot="8")]
	public void HandleDispatchAction(DEmoteInventoryItemSelectAction action)
	{
	}

	[Address(RVA="0x1194E94", Offset="0x1194E94", VA="0x1194E94", Slot="9")]
	public void HandleDispatchAction(DUnitGearTierUpAction action)
	{
	}

	[Address(RVA="0x1195214", Offset="0x1195214", VA="0x1195214", Slot="10")]
	public void HandleDispatchAction(DUnitUnlockedAction action)
	{
	}

	[Address(RVA="0x1195220", Offset="0x1195220", VA="0x1195220", Slot="11")]
	public void HandleDispatchAction(DSpellUnlockedAction action)
	{
	}

	[Address(RVA="0x119522C", Offset="0x119522C", VA="0x119522C", Slot="12")]
	public void HandleDispatchAction(DPinViewedAction action)
	{
	}

	[Address(RVA="0x1192FCC", Offset="0x1192FCC", VA="0x1192FCC")]
	public bool HasNewUnlocks()
	{
		return new bool();
	}

	[Address(RVA="0x1192F00", Offset="0x1192F00", VA="0x1192F00")]
	public void Initialize()
	{
	}

	[Address(RVA="0x11934D0", Offset="0x11934D0", VA="0x11934D0")]
	public bool IsAnyAbilityRecentlyUnlockedForUnit(ulong unitId)
	{
		return new bool();
	}

	[Address(RVA="0x11952EC", Offset="0x11952EC", VA="0x11952EC")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x1193490", Offset="0x1193490", VA="0x1193490")]
	public bool PinIsNew(ulong pinId)
	{
		return new bool();
	}

	[Address(RVA="0x1194C50", Offset="0x1194C50", VA="0x1194C50")]
	private void ReadNewEmotesPref()
	{
	}

	[Address(RVA="0x1194CBC", Offset="0x1194CBC", VA="0x1194CBC")]
	private void ReadNewPinsPref()
	{
	}

	[Address(RVA="0x1194BE4", Offset="0x1194BE4", VA="0x1194BE4")]
	private void ReadNewUnitSkinPref()
	{
	}

	[Address(RVA="0x1192F7C", Offset="0x1192F7C", VA="0x1192F7C")]
	private void ReleaseView()
	{
	}

	[Address(RVA="0x11931BC", Offset="0x11931BC", VA="0x11931BC")]
	public void Show()
	{
	}

	[Address(RVA="0x1192F38", Offset="0x1192F38", VA="0x1192F38")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1193350", Offset="0x1193350", VA="0x1193350")]
	public bool UnitHasUnviewedSkins(ulong unitId)
	{
		return new bool();
	}

	[Address(RVA="0x1194A8C", Offset="0x1194A8C", VA="0x1194A8C")]
	private void WriteNewEmotesPref()
	{
	}

	[Address(RVA="0x1194AF8", Offset="0x1194AF8", VA="0x1194AF8")]
	private void WriteNewPinsPref()
	{
	}

	[Address(RVA="0x1194A20", Offset="0x1194A20", VA="0x1194A20")]
	private void WriteNewUnitSkinPref()
	{
	}
}