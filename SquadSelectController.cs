using Gamedata;
using Glunies;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using System.Diagnostics;

public class SquadSelectController : AFeatureController, IDispatchHandler<DSquadSelectViewAction>, IDispatchHandler, IDispatchHandler<DSquadSelectUnitSlotAction>, IDispatchHandler<DSquadSelectSpellSlotAction>, IDispatchHandler<DUnitListViewAction>, IDispatchHandler<DSpellListViewAction>, IDispatchHandler<DMatchmakingPopupViewAction>, IDispatchHandler<DBattleSendInviteAction>, IDispatchHandler<DDailyPvpRewardAction>, IDispatchHandler<DSavedSquadAction>
{
	[FieldOffset(Offset="0x0")]
	public const int MAX_UNITS = 5;

	[FieldOffset(Offset="0x0")]
	public const int MAX_SPELLS = 2;

	[Attribute(Name="InjectAttribute", RVA="0x105C850", Offset="0x105C850")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105C860", Offset="0x105C860")]
	[FieldOffset(Offset="0x70")]
	private BattleService _battleService;

	[Attribute(Name="InjectAttribute", RVA="0x105C870", Offset="0x105C870")]
	[FieldOffset(Offset="0x78")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x105C880", Offset="0x105C880")]
	[FieldOffset(Offset="0x80")]
	private ClubService _clubService;

	[Attribute(Name="InjectAttribute", RVA="0x105C890", Offset="0x105C890")]
	[FieldOffset(Offset="0x88")]
	private UnitSorter _unitSorter;

	[Attribute(Name="InjectAttribute", RVA="0x105C8A0", Offset="0x105C8A0")]
	[FieldOffset(Offset="0x90")]
	private SpellSorter _spellSorter;

	[Attribute(Name="InjectAttribute", RVA="0x105C8B0", Offset="0x105C8B0")]
	[FieldOffset(Offset="0x98")]
	private BattleStateTransitionController _stateTransitionController;

	[Attribute(Name="InjectAttribute", RVA="0x105C8C0", Offset="0x105C8C0")]
	[FieldOffset(Offset="0xA0")]
	private RemoteBattleStateTransitionController _remoteBattleStateTransitionController;

	[Attribute(Name="InjectAttribute", RVA="0x105C8D0", Offset="0x105C8D0")]
	[FieldOffset(Offset="0xA8")]
	private DialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x105C8E0", Offset="0x105C8E0")]
	[FieldOffset(Offset="0xB0")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x105C8F0", Offset="0x105C8F0")]
	[FieldOffset(Offset="0xB8")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105C900", Offset="0x105C900")]
	[FieldOffset(Offset="0xC0")]
	private BattleInviteMessageController _inviteMessageController;

	[Attribute(Name="InjectAttribute", RVA="0x105C910", Offset="0x105C910")]
	[FieldOffset(Offset="0xC8")]
	private TelemetryTranslator _telemetryTranslator;

	[Attribute(Name="InjectAttribute", RVA="0x105C920", Offset="0x105C920")]
	[FieldOffset(Offset="0xD0")]
	private TelemetryUtility _telemetryUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105C930", Offset="0x105C930")]
	[FieldOffset(Offset="0xD8")]
	private AccountPrefs _accountPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x105C940", Offset="0x105C940")]
	[FieldOffset(Offset="0xE0")]
	private RevSdkController _revSdk;

	[Attribute(Name="InjectAttribute", RVA="0x105C950", Offset="0x105C950")]
	[FieldOffset(Offset="0xE8")]
	private CardUnlockTrackerController _cardUnlockTracker;

	[Attribute(Name="InjectAttribute", RVA="0x105C960", Offset="0x105C960")]
	[FieldOffset(Offset="0xF0")]
	private BattleRestrictionUtility _battleRestrictionUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105C970", Offset="0x105C970")]
	[FieldOffset(Offset="0xF8")]
	private FeatureLockController _featureLockController;

	[FieldOffset(Offset="0x100")]
	private SquadSelectGameState.AContext _context;

	[FieldOffset(Offset="0x108")]
	private SquadSelectView _view;

	[FieldOffset(Offset="0x110")]
	private SquadSelectScene _scene;

	[FieldOffset(Offset="0x118")]
	private Serverproto.PvpLobbyResponse _pvpLobbyResponse;

	[FieldOffset(Offset="0x120")]
	private BattleRestriction? _battleRestriction;

	[FieldOffset(Offset="0x138")]
	private BattleRestriction? _unitBonusRestriction;

	[FieldOffset(Offset="0x150")]
	private List<Serverproto.Unit> _squadUnits;

	[FieldOffset(Offset="0x158")]
	private ulong _squadLeaderUnitId;

	[FieldOffset(Offset="0x160")]
	private List<Serverproto.Unit> _availableUnits;

	[FieldOffset(Offset="0x168")]
	private List<Serverproto.Unit> _ineligibleUnits;

	[FieldOffset(Offset="0x170")]
	private List<Serverproto.Unit> _unitsWithActiveBonus;

	[FieldOffset(Offset="0x178")]
	private int _maxUnitsInSquad;

	[FieldOffset(Offset="0x17C")]
	private int _unitIndexBeingEdited;

	[FieldOffset(Offset="0x180")]
	private string _noUnitAvailableLocKey;

	[FieldOffset(Offset="0x188")]
	private List<Serverproto.Spell> _squadSpells;

	[FieldOffset(Offset="0x190")]
	private List<Serverproto.Spell> _availableSpells;

	[FieldOffset(Offset="0x198")]
	private List<Serverproto.Spell> _ineligibleSpells;

	[FieldOffset(Offset="0x1A0")]
	private int _maxSpellsInSquad;

	[FieldOffset(Offset="0x1A4")]
	private int _spellIndexBeingEdited;

	[FieldOffset(Offset="0x1A8")]
	private bool _pendingCancel;

	[FieldOffset(Offset="0x1B0")]
	private Gamedata.InventoryItem? _entryCostItem;

	[FieldOffset(Offset="0x1C8")]
	private ulong _entryCostCount;

	public Serverproto.PvpLobbyResponse PvpLobbyResponse
	{
		[Address(RVA="0x12480F0", Offset="0x12480F0", VA="0x12480F0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1251CA8", Offset="0x1251CA8", VA="0x1251CA8")]
	public SquadSelectController()
	{
	}

	[Address(RVA="0x1251DD0", Offset="0x1251DD0", VA="0x1251DD0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10709A4", Offset="0x10709A4")]
	private void <HandleDispatchAction>b__13_0(long errorCode)
	{
	}

	[Address(RVA="0x1251E90", Offset="0x1251E90", VA="0x1251E90")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10709B4", Offset="0x10709B4")]
	private void <HandleDispatchAction>b__13_1()
	{
	}

	[Address(RVA="0x1251E98", Offset="0x1251E98", VA="0x1251E98")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10709C4", Offset="0x10709C4")]
	private void <HandleDispatchAction>b__15_0()
	{
	}

	[Address(RVA="0x1251EEC", Offset="0x1251EEC", VA="0x1251EEC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10709D4", Offset="0x10709D4")]
	private void <HandleDispatchAction>b__16_0()
	{
	}

	[Address(RVA="0x12521D0", Offset="0x12521D0", VA="0x12521D0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070A04", Offset="0x1070A04")]
	private void <SetSquad>b__46_0()
	{
	}

	[Address(RVA="0x1251F50", Offset="0x1251F50", VA="0x1251F50")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10709E4", Offset="0x10709E4")]
	private void <StartBattle>b__25_0()
	{
	}

	[Address(RVA="0x124DD80", Offset="0x124DD80", VA="0x124DD80")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10709F4", Offset="0x10709F4")]
	private bool <StartBattle>g__PassesAllBattleRestrictions|25_1()
	{
		return new bool();
	}

	[Address(RVA="0x1249FC0", Offset="0x1249FC0", VA="0x1249FC0")]
	private void AutoFillSquad(SquadSelectController.SquadSelectionStrategy strategy, bool emptySlotsOnly = false)
	{
	}

	[Address(RVA="0x124C1A8", Offset="0x124C1A8", VA="0x124C1A8")]
	private bool CanAssignToSquad(Serverproto.Unit unit, bool alertOnFail = false)
	{
		return new bool();
	}

	[Address(RVA="0x124992C", Offset="0x124992C", VA="0x124992C")]
	private bool CanBattle()
	{
		return new bool();
	}

	[Address(RVA="0x124D80C", Offset="0x124D80C", VA="0x124D80C", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x12491F8", Offset="0x12491F8", VA="0x12491F8")]
	public void FinishFeatureInitialization()
	{
	}

	[Address(RVA="0x124E5E0", Offset="0x124E5E0", VA="0x124E5E0")]
	private BattleSquadSaveInfo GetSquadSaveInfo()
	{
		return null;
	}

	[Address(RVA="0x1249B7C", Offset="0x1249B7C", VA="0x1249B7C", Slot="13")]
	public void HandleDispatchAction(DSquadSelectViewAction action)
	{
	}

	[Address(RVA="0x124AA08", Offset="0x124AA08", VA="0x124AA08", Slot="14")]
	public void HandleDispatchAction(DSquadSelectUnitSlotAction action)
	{
	}

	[Address(RVA="0x124B510", Offset="0x124B510", VA="0x124B510", Slot="15")]
	public void HandleDispatchAction(DSquadSelectSpellSlotAction action)
	{
	}

	[Address(RVA="0x124BA00", Offset="0x124BA00", VA="0x124BA00", Slot="16")]
	public void HandleDispatchAction(DUnitListViewAction action)
	{
	}

	[Address(RVA="0x124C5A4", Offset="0x124C5A4", VA="0x124C5A4", Slot="17")]
	public void HandleDispatchAction(DSpellListViewAction action)
	{
	}

	[Address(RVA="0x124CAB8", Offset="0x124CAB8", VA="0x124CAB8", Slot="18")]
	public void HandleDispatchAction(DMatchmakingPopupViewAction action)
	{
	}

	[Address(RVA="0x124CC08", Offset="0x124CC08", VA="0x124CC08", Slot="19")]
	public void HandleDispatchAction(DBattleSendInviteAction action)
	{
	}

	[Address(RVA="0x124CCE8", Offset="0x124CCE8", VA="0x124CCE8", Slot="20")]
	public void HandleDispatchAction(DDailyPvpRewardAction action)
	{
	}

	[Address(RVA="0x124CE28", Offset="0x124CE28", VA="0x124CE28", Slot="21")]
	public void HandleDispatchAction(DSavedSquadAction action)
	{
	}

	[Address(RVA="0x1250F9C", Offset="0x1250F9C", VA="0x1250F9C")]
	private bool HasAnySelections()
	{
		return new bool();
	}

	[Address(RVA="0x12480F8", Offset="0x12480F8", VA="0x12480F8")]
	public void Initialize(GameStateTransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x124833C", Offset="0x124833C", VA="0x124833C")]
	private void InitializeBattleRestrictions()
	{
	}

	[Address(RVA="0x1248AA8", Offset="0x1248AA8", VA="0x1248AA8")]
	private void InitializeSpells()
	{
	}

	[Address(RVA="0x1248404", Offset="0x1248404", VA="0x1248404")]
	private void InitializeUnits()
	{
	}

	[Address(RVA="0x124CC10", Offset="0x124CC10", VA="0x124CC10")]
	private void InviteToBattle(string friendId)
	{
	}

	[Address(RVA="0x124ECD0", Offset="0x124ECD0", VA="0x124ECD0")]
	private void InviteToCoopPveBattle(SquadSelectGameState.EventContext context, string friendId)
	{
	}

	[Address(RVA="0x124E2C8", Offset="0x124E2C8", VA="0x124E2C8")]
	private bool IsCoopBattleContext(SquadSelectGameState.AContext context)
	{
		return new bool();
	}

	[Address(RVA="0x124C340", Offset="0x124C340", VA="0x124C340")]
	public bool IsUnitInSquad(ulong unitId)
	{
		return new bool();
	}

	[Address(RVA="0x124D268", Offset="0x124D268", VA="0x124D268")]
	private void LoadSavedSquad(ulong slot)
	{
	}

	[Address(RVA="0x124DB40", Offset="0x124DB40", VA="0x124DB40")]
	private void LoadScene(Action finished)
	{
	}

	[Address(RVA="0x1250888", Offset="0x1250888", VA="0x1250888")]
	private void MakeClubWarDefense(SquadSelectGameState.ClubWarDefenseContext clubWarDefenseContext)
	{
	}

	[Address(RVA="0x124F428", Offset="0x124F428", VA="0x124F428")]
	private void MatchmakingCanceled(string canceledText)
	{
	}

	[Address(RVA="0x124F374", Offset="0x124F374", VA="0x124F374")]
	private void MatchmakingFailed(string failedText)
	{
	}

	[Address(RVA="0x124E0A0", Offset="0x124E0A0", VA="0x124E0A0")]
	private bool MeetsSquadSizeRequirement(bool alertOnFail = false)
	{
		return new bool();
	}

	[Address(RVA="0x124E6B4", Offset="0x124E6B4", VA="0x124E6B4")]
	private void PopulateBattleRequestSquad(IList<ulong> unitList, IList<ulong> spellList)
	{
	}

	[Address(RVA="0x1249F4C", Offset="0x1249F4C", VA="0x1249F4C")]
	private void RemoveSpell(int index)
	{
	}

	[Address(RVA="0x1249EC8", Offset="0x1249EC8", VA="0x1249EC8")]
	private void RemoveUnit(int index)
	{
	}

	[Address(RVA="0x124C478", Offset="0x124C478", VA="0x124C478")]
	private void SelectDefaultLeaderUnit()
	{
	}

	[Address(RVA="0x12511E0", Offset="0x12511E0", VA="0x12511E0")]
	private void SendSquadTelemetry(long referenceId, string name, string st3, IList<ulong> unitIds, ulong leaderUnitId, IList<ulong> spellIds, Dictionary<string, object> baseData = // 
	// Current member / type: System.Void SquadSelectController::SendSquadTelemetry(System.Int64,System.String,System.String,System.Collections.Generic.IList`1<System.UInt64>,System.UInt64,System.Collections.Generic.IList`1<System.UInt64>,System.Collections.Generic.Dictionary`2<System.String,System.Object>)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void SendSquadTelemetry(System.Int64,System.String,System.String,System.Collections.Generic.IList<System.UInt64>,System.UInt64,System.Collections.Generic.IList<System.UInt64>,System.Collections.Generic.Dictionary<System.String,System.Object>)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x124A8D4", Offset="0x124A8D4", VA="0x124A8D4")]
	private void SetSquad()
	{
	}

	[Address(RVA="0x124CEE8", Offset="0x124CEE8", VA="0x124CEE8")]
	private void SetSquadSelection(Gamedata.GameMode gameMode, ulong slot, Action setSuccessCallback)
	{
	}

	[Address(RVA="0x124A7C0", Offset="0x124A7C0", VA="0x124A7C0")]
	private void ShowFriendInvitePopup()
	{
	}

	[Address(RVA="0x1249104", Offset="0x1249104", VA="0x1249104", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x124DF88", Offset="0x124DF88", VA="0x124DF88")]
	private int SlottedUnitCount()
	{
		return new int();
	}

	[Address(RVA="0x1250D74", Offset="0x1250D74", VA="0x1250D74")]
	private void SquadSaved(Gamedata.GameMode gameMode, ulong slot, RepeatedField<ulong> unitList, RepeatedField<ulong> spellList, ulong leaderUnit)
	{
	}

	[Address(RVA="0x1249E1C", Offset="0x1249E1C", VA="0x1249E1C")]
	private void StartBattle()
	{
	}

	[Address(RVA="0x124FA50", Offset="0x124FA50", VA="0x124FA50")]
	private void StartClubDungeonBattle(SquadSelectGameState.ClubDungeonContext context)
	{
	}

	[Address(RVA="0x125055C", Offset="0x125055C", VA="0x125055C")]
	private void StartClubWarBattle(SquadSelectGameState.ClubWarContext context)
	{
	}

	[Address(RVA="0x124E9B4", Offset="0x124E9B4", VA="0x124E9B4")]
	private void StartCoopPveBattle(SquadSelectGameState.EventContext context)
	{
	}

	[Address(RVA="0x124F508", Offset="0x124F508", VA="0x124F508")]
	private void StartEventBattle(SquadSelectGameState.EventContext context)
	{
	}

	[Address(RVA="0x124FCD0", Offset="0x124FCD0", VA="0x124FCD0")]
	private void StartKothBattle(SquadSelectGameState.KothContext context)
	{
	}

	[Address(RVA="0x124F044", Offset="0x124F044", VA="0x124F044")]
	private void StartPvpBattle(SquadSelectGameState.PvpContext context)
	{
	}

	[Address(RVA="0x124E364", Offset="0x124E364", VA="0x124E364")]
	private void StartStandardPveBattle(SquadSelectGameState.CampaignContext context)
	{
	}

	[Address(RVA="0x124F7A0", Offset="0x124F7A0", VA="0x124F7A0")]
	private void StartTowerBattle(SquadSelectGameState.TowerContext context)
	{
	}

	[Address(RVA="0x1249170", Offset="0x1249170", VA="0x1249170", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x1250E2C", Offset="0x1250E2C", VA="0x1250E2C")]
	private void TryAutoAutoFillSquad()
	{
	}

	[Address(RVA="0x124B148", Offset="0x124B148", VA="0x124B148")]
	private bool TrySelectLeaderUnit(ulong leaderUnitId, bool alert = false)
	{
		return new bool();
	}

	[Address(RVA="0x1249A18", Offset="0x1249A18", VA="0x1249A18")]
	private void UpdateBattleRequirementsUi()
	{
	}

	[Address(RVA="0x1249AB8", Offset="0x1249AB8", VA="0x1249AB8")]
	private void UpdateUnitCountRestrictionUi()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CACC", Offset="0x104CACC")]
	private sealed class <>c__DisplayClass18_0
	{
		[FieldOffset(Offset="0x10")]
		public SquadSelectController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[FieldOffset(Offset="0x20")]
		public Action<SquadSelectScene> <>9__3;

		[Address(RVA="0x121A370", Offset="0x121A370", VA="0x121A370")]
		public <>c__DisplayClass18_0()
		{
		}

		[Address(RVA="0x121A378", Offset="0x121A378", VA="0x121A378")]
		internal void <LoadScene>b__0(Serverproto.PvpLobbyResponse response)
		{
		}

		[Address(RVA="0x121A5BC", Offset="0x121A5BC", VA="0x121A5BC")]
		internal void <LoadScene>b__1(long error)
		{
		}

		[Address(RVA="0x121A564", Offset="0x121A564", VA="0x121A564")]
		internal void <LoadScene>b__3(SquadSelectScene scene)
		{
		}

		[Address(RVA="0x121A5C4", Offset="0x121A5C4", VA="0x121A5C4")]
		internal void <LoadScene>g__LoadDefaultScene|2(Action scenedLoaded)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CADC", Offset="0x104CADC")]
	private sealed class <>c__DisplayClass18_1
	{
		[FieldOffset(Offset="0x10")]
		public string sceneAssetId;

		[FieldOffset(Offset="0x18")]
		public SquadSelectController.<>c__DisplayClass18_0 CS$<>8__locals1;

		[Address(RVA="0x121A55C", Offset="0x121A55C", VA="0x121A55C")]
		public <>c__DisplayClass18_1()
		{
		}

		[Address(RVA="0x121A6C8", Offset="0x121A6C8", VA="0x121A6C8")]
		internal void <LoadScene>b__4()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CAEC", Offset="0x104CAEC")]
	private sealed class <>c__DisplayClass18_2
	{
		[FieldOffset(Offset="0x10")]
		public Action scenedLoaded;

		[FieldOffset(Offset="0x18")]
		public SquadSelectController.<>c__DisplayClass18_0 CS$<>8__locals2;

		[Address(RVA="0x121A6C0", Offset="0x121A6C0", VA="0x121A6C0")]
		public <>c__DisplayClass18_2()
		{
		}

		[Address(RVA="0x121A7B8", Offset="0x121A7B8", VA="0x121A7B8")]
		internal void <LoadScene>b__5(SquadSelectScene scene)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CAFC", Offset="0x104CAFC")]
	private sealed class <>c__DisplayClass26_0
	{
		[FieldOffset(Offset="0x10")]
		public SquadSelectController <>4__this;

		[FieldOffset(Offset="0x18")]
		public string friendId;

		[Address(RVA="0x121A820", Offset="0x121A820", VA="0x121A820")]
		public <>c__DisplayClass26_0()
		{
		}

		[Address(RVA="0x121A828", Offset="0x121A828", VA="0x121A828")]
		internal void <InviteToBattle>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CB0C", Offset="0x104CB0C")]
	private sealed class <>c__DisplayClass35_0
	{
		[FieldOffset(Offset="0x10")]
		public SquadSelectController <>4__this;

		[FieldOffset(Offset="0x18")]
		public PveBattleStartRequest request;

		[Address(RVA="0x121A93C", Offset="0x121A93C", VA="0x121A93C")]
		public <>c__DisplayClass35_0()
		{
		}

		[Address(RVA="0x121A944", Offset="0x121A944", VA="0x121A944")]
		internal void <StartStandardPveBattle>b__0(PveBattleStartResponse response)
		{
		}

		[Address(RVA="0x121ACF0", Offset="0x121ACF0", VA="0x121ACF0")]
		internal void <StartStandardPveBattle>b__1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CB1C", Offset="0x104CB1C")]
	private sealed class <>c__DisplayClass36_0
	{
		[FieldOffset(Offset="0x10")]
		public SquadSelectController <>4__this;

		[FieldOffset(Offset="0x18")]
		public CoopFindMatchRequest request;

		[Address(RVA="0x121ADEC", Offset="0x121ADEC", VA="0x121ADEC")]
		public <>c__DisplayClass36_0()
		{
		}

		[Address(RVA="0x121ADF4", Offset="0x121ADF4", VA="0x121ADF4")]
		internal void <StartCoopPveBattle>b__0(CoopFindMatchResponse response)
		{
		}

		[Address(RVA="0x121B12C", Offset="0x121B12C", VA="0x121B12C")]
		internal void <StartCoopPveBattle>b__1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CB2C", Offset="0x104CB2C")]
	private sealed class <>c__DisplayClass37_0
	{
		[FieldOffset(Offset="0x10")]
		public SquadSelectController <>4__this;

		[FieldOffset(Offset="0x18")]
		public CoopInviteToMatchRequest request;

		[Address(RVA="0x121B1B0", Offset="0x121B1B0", VA="0x121B1B0")]
		public <>c__DisplayClass37_0()
		{
		}

		[Address(RVA="0x121B1B8", Offset="0x121B1B8", VA="0x121B1B8")]
		internal void <InviteToCoopPveBattle>b__0(CoopFindMatchResponse response)
		{
		}

		[Address(RVA="0x121B524", Offset="0x121B524", VA="0x121B524")]
		internal void <InviteToCoopPveBattle>b__1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CB3C", Offset="0x104CB3C")]
	private sealed class <>c__DisplayClass38_0
	{
		[FieldOffset(Offset="0x10")]
		public Stopwatch matchingTimer;

		[FieldOffset(Offset="0x18")]
		public SquadSelectController <>4__this;

		[FieldOffset(Offset="0x20")]
		public PvpFindMatchRequest request;

		[Address(RVA="0x121B5A8", Offset="0x121B5A8", VA="0x121B5A8")]
		public <>c__DisplayClass38_0()
		{
		}

		[Address(RVA="0x121B5B0", Offset="0x121B5B0", VA="0x121B5B0")]
		internal void <StartPvpBattle>b__0(PvpFindMatchResponse response)
		{
		}

		[Address(RVA="0x121BD10", Offset="0x121BD10", VA="0x121BD10")]
		internal void <StartPvpBattle>b__1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CAAC", Offset="0x104CAAC")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public SquadSelectController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x12205E8", Offset="0x12205E8", VA="0x12205E8")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x12205F0", Offset="0x12205F0", VA="0x12205F0")]
		internal void <Initialize>b__0(Action finished)
		{
		}

		[Address(RVA="0x12206E4", Offset="0x12206E4", VA="0x12206E4")]
		internal void <Initialize>b__1()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CABC", Offset="0x104CABC")]
	private sealed class <>c__DisplayClass4_1
	{
		[FieldOffset(Offset="0x10")]
		public Action finished;

		[FieldOffset(Offset="0x18")]
		public SquadSelectController.<>c__DisplayClass4_0 CS$<>8__locals1;

		[Address(RVA="0x12206DC", Offset="0x12206DC", VA="0x12206DC")]
		public <>c__DisplayClass4_1()
		{
		}

		[Address(RVA="0x1220D68", Offset="0x1220D68", VA="0x1220D68")]
		internal void <Initialize>b__2(SquadSelectView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CB4C", Offset="0x104CB4C")]
	private sealed class <>c__DisplayClass41_0
	{
		[FieldOffset(Offset="0x10")]
		public SquadSelectController <>4__this;

		[FieldOffset(Offset="0x18")]
		public EventBattleStartRequest request;

		[FieldOffset(Offset="0x20")]
		public SquadSelectGameState.EventContext context;

		[Address(RVA="0x121BE1C", Offset="0x121BE1C", VA="0x121BE1C")]
		public <>c__DisplayClass41_0()
		{
		}

		[Address(RVA="0x121BE24", Offset="0x121BE24", VA="0x121BE24")]
		internal void <StartEventBattle>b__0(EventBattleStartResponse response)
		{
		}

		[Address(RVA="0x121C154", Offset="0x121C154", VA="0x121C154")]
		internal void <StartEventBattle>b__1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CB5C", Offset="0x104CB5C")]
	private sealed class <>c__DisplayClass42_0
	{
		[FieldOffset(Offset="0x10")]
		public SquadSelectController <>4__this;

		[FieldOffset(Offset="0x18")]
		public TowerBattleStartRequest request;

		[FieldOffset(Offset="0x20")]
		public SquadSelectGameState.TowerContext context;

		[Address(RVA="0x121C250", Offset="0x121C250", VA="0x121C250")]
		public <>c__DisplayClass42_0()
		{
		}

		[Address(RVA="0x121C258", Offset="0x121C258", VA="0x121C258")]
		internal void <StartTowerBattle>b__0(TowerBattleStartResponse response)
		{
		}

		[Address(RVA="0x121C5AC", Offset="0x121C5AC", VA="0x121C5AC")]
		internal void <StartTowerBattle>b__1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CB6C", Offset="0x104CB6C")]
	private sealed class <>c__DisplayClass43_0
	{
		[FieldOffset(Offset="0x10")]
		public SquadSelectController <>4__this;

		[FieldOffset(Offset="0x18")]
		public ClubDungeonBattleStartRequest request;

		[FieldOffset(Offset="0x20")]
		public SquadSelectGameState.ClubDungeonContext context;

		[Address(RVA="0x121C6A8", Offset="0x121C6A8", VA="0x121C6A8")]
		public <>c__DisplayClass43_0()
		{
		}

		[Address(RVA="0x121C6B0", Offset="0x121C6B0", VA="0x121C6B0")]
		internal void <StartClubDungeonBattle>b__0(ClubDungeonBattleStartResponse response)
		{
		}

		[Address(RVA="0x121CAD0", Offset="0x121CAD0", VA="0x121CAD0")]
		internal void <StartClubDungeonBattle>b__1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CB7C", Offset="0x104CB7C")]
	private sealed class <>c__DisplayClass44_0
	{
		[FieldOffset(Offset="0x10")]
		public SquadSelectController <>4__this;

		[FieldOffset(Offset="0x18")]
		public KothBattleStartRequest request;

		[FieldOffset(Offset="0x20")]
		public SquadSelectGameState.KothContext context;

		[FieldOffset(Offset="0x28")]
		public Action <>9__2;

		[FieldOffset(Offset="0x30")]
		public Action <>9__3;

		[Address(RVA="0x121CBCC", Offset="0x121CBCC", VA="0x121CBCC")]
		public <>c__DisplayClass44_0()
		{
		}

		[Address(RVA="0x121CBD4", Offset="0x121CBD4", VA="0x121CBD4")]
		internal void <StartKothBattle>b__0(KothBattleStartResponse response)
		{
		}

		[Address(RVA="0x121DF48", Offset="0x121DF48", VA="0x121DF48")]
		internal void <StartKothBattle>b__1(long errorCode)
		{
		}

		[Address(RVA="0x121DED4", Offset="0x121DED4", VA="0x121DED4")]
		internal void <StartKothBattle>b__2()
		{
		}

		[Address(RVA="0x121E254", Offset="0x121E254", VA="0x121E254")]
		internal void <StartKothBattle>b__3()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CB8C", Offset="0x104CB8C")]
	private sealed class <>c__DisplayClass45_0
	{
		[FieldOffset(Offset="0x10")]
		public SquadSelectGameState.ClubWarContext context;

		[FieldOffset(Offset="0x18")]
		public SquadSelectController <>4__this;

		[FieldOffset(Offset="0x20")]
		public ClubWarBattleStartRequest request;

		[FieldOffset(Offset="0x28")]
		public Action <>9__2;

		[Address(RVA="0x121E2C8", Offset="0x121E2C8", VA="0x121E2C8")]
		public <>c__DisplayClass45_0()
		{
		}

		[Address(RVA="0x121E2D0", Offset="0x121E2D0", VA="0x121E2D0")]
		internal void <StartClubWarBattle>b__0(ClubWarBattleStartResponse response)
		{
		}

		[Address(RVA="0x121F454", Offset="0x121F454", VA="0x121F454")]
		internal void <StartClubWarBattle>b__1(long errorCode)
		{
		}

		[Address(RVA="0x121F3E0", Offset="0x121F3E0", VA="0x121F3E0")]
		internal void <StartClubWarBattle>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CB9C", Offset="0x104CB9C")]
	private sealed class <>c__DisplayClass45_1
	{
		[FieldOffset(Offset="0x10")]
		public bool returnToClubWar;

		[FieldOffset(Offset="0x18")]
		public SquadSelectController.<>c__DisplayClass45_0 CS$<>8__locals1;

		[Address(RVA="0x121F748", Offset="0x121F748", VA="0x121F748")]
		public <>c__DisplayClass45_1()
		{
		}

		[Address(RVA="0x121F750", Offset="0x121F750", VA="0x121F750")]
		internal void <StartClubWarBattle>b__3()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CBAC", Offset="0x104CBAC")]
	private sealed class <>c__DisplayClass47_0
	{
		[FieldOffset(Offset="0x10")]
		public SquadSelectGameState.ClubWarDefenseContext clubWarDefenseContext;

		[FieldOffset(Offset="0x18")]
		public SquadSelectController <>4__this;

		[Address(RVA="0x121F80C", Offset="0x121F80C", VA="0x121F80C")]
		public <>c__DisplayClass47_0()
		{
		}

		[Address(RVA="0x121F814", Offset="0x121F814", VA="0x121F814")]
		internal void <MakeClubWarDefense>b__1(long errorCode)
		{
		}

		[Address(RVA="0x121F9D4", Offset="0x121F9D4", VA="0x121F9D4")]
		internal void <MakeClubWarDefense>b__3(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CBBC", Offset="0x104CBBC")]
	private sealed class <>c__DisplayClass47_1
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarSetDefenseRequest request;

		[FieldOffset(Offset="0x18")]
		public SquadSelectController.<>c__DisplayClass47_0 CS$<>8__locals1;

		[Address(RVA="0x121FB94", Offset="0x121FB94", VA="0x121FB94")]
		public <>c__DisplayClass47_1()
		{
		}

		[Address(RVA="0x121FB9C", Offset="0x121FB9C", VA="0x121FB9C")]
		internal void <MakeClubWarDefense>b__0(ClubWarSetDefenseResponse response)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CBCC", Offset="0x104CBCC")]
	private sealed class <>c__DisplayClass47_2
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarMakeDefenseRequest request;

		[FieldOffset(Offset="0x18")]
		public SquadSelectController.<>c__DisplayClass47_0 CS$<>8__locals2;

		[Address(RVA="0x121FF40", Offset="0x121FF40", VA="0x121FF40")]
		public <>c__DisplayClass47_2()
		{
		}

		[Address(RVA="0x121FF48", Offset="0x121FF48", VA="0x121FF48")]
		internal void <MakeClubWarDefense>b__2(ClubWarMakeDefenseResponse response)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CBDC", Offset="0x104CBDC")]
	private sealed class <>c__DisplayClass48_0
	{
		[FieldOffset(Offset="0x10")]
		public Gamedata.GameMode gameMode;

		[FieldOffset(Offset="0x18")]
		public SquadSelectController <>4__this;

		[FieldOffset(Offset="0x20")]
		public SetPlayerSquadSelectionRequest request;

		[FieldOffset(Offset="0x28")]
		public ulong slot;

		[FieldOffset(Offset="0x30")]
		public Action setSuccessCallback;

		[Address(RVA="0x12201D8", Offset="0x12201D8", VA="0x12201D8")]
		public <>c__DisplayClass48_0()
		{
		}

		[Address(RVA="0x12201E0", Offset="0x12201E0", VA="0x12201E0")]
		internal void <SetSquadSelection>b__0(SetPlayerSquadSelectionResponse response)
		{
		}

		[Address(RVA="0x12204B0", Offset="0x12204B0", VA="0x12204B0")]
		internal void <SetSquadSelection>b__1(long errorCode)
		{
		}

		[Address(RVA="0x1220574", Offset="0x1220574", VA="0x1220574")]
		internal void <SetSquadSelection>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CBEC", Offset="0x104CBEC")]
	private sealed class <>c__DisplayClass53_0
	{
		[FieldOffset(Offset="0x10")]
		public PlayerSquadSelection squad;

		[Address(RVA="0x1220DD0", Offset="0x1220DD0", VA="0x1220DD0")]
		public <>c__DisplayClass53_0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CBFC", Offset="0x104CBFC")]
	private sealed class <>c__DisplayClass53_1
	{
		[FieldOffset(Offset="0x10")]
		public int i;

		[FieldOffset(Offset="0x18")]
		public SquadSelectController.<>c__DisplayClass53_0 CS$<>8__locals1;

		[Address(RVA="0x1220DD8", Offset="0x1220DD8", VA="0x1220DD8")]
		public <>c__DisplayClass53_1()
		{
		}

		[Address(RVA="0x1220DE0", Offset="0x1220DE0", VA="0x1220DE0")]
		internal bool <LoadSavedSquad>b__0(Serverproto.Unit u)
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CC0C", Offset="0x104CC0C")]
	private sealed class <>c__DisplayClass53_2
	{
		[FieldOffset(Offset="0x10")]
		public int i;

		[FieldOffset(Offset="0x18")]
		public SquadSelectController.<>c__DisplayClass53_0 CS$<>8__locals2;

		[Address(RVA="0x1220EA4", Offset="0x1220EA4", VA="0x1220EA4")]
		public <>c__DisplayClass53_2()
		{
		}

		[Address(RVA="0x1220EAC", Offset="0x1220EAC", VA="0x1220EAC")]
		internal bool <LoadSavedSquad>b__1(Serverproto.Spell s)
		{
			return new bool();
		}
	}

	private enum SquadSelectionStrategy
	{
		[FieldOffset(Offset="0x0")]
		Any,
		[FieldOffset(Offset="0x0")]
		HighestPower
	}
}