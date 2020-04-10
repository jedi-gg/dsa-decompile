using BattleLib;
using Glunies;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;

public class BattleHandler : ILoggable<LogCategory>, IDispatchHandler<DBattleViewControllerAction>, IDispatchHandler, IDispatchHandler<DBattleBeginAction>, IDispatchHandler<DBattleAbilityCamerasSettingChangedAction>, IDispatchHandler<DApplicationPauseAction>, IDispatchHandler<DPlayerThinkingHeartbeatAction>, IDispatchHandler<DCastAttemptAction>
{
	[FieldOffset(Offset="0x0")]
	public const byte INVALID_BYTE_ID = 255;

	[FieldOffset(Offset="0x0")]
	public const ushort INVALID_SHORT_ID = 65535;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10535D4", Offset="0x10535D4")]
	[FieldOffset(Offset="0x10")]
	private int <CurrentEncounterIndex>k__BackingField;

	[FieldOffset(Offset="0x0")]
	private const float EXIT_DELAY_S = 3f;

	[FieldOffset(Offset="0x0")]
	private const float BATTLE_CATCHUP_SPEED = 2f;

	[FieldOffset(Offset="0x0")]
	private const float BATTLE_CATCHUP_ENABLED_WAIT_DURATION_S = 10f;

	[Attribute(Name="InjectAttribute", RVA="0x10535E4", Offset="0x10535E4")]
	[FieldOffset(Offset="0x18")]
	private ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x10535F4", Offset="0x10535F4")]
	[FieldOffset(Offset="0x20")]
	private BattleUnitsController _unitsController;

	[Attribute(Name="InjectAttribute", RVA="0x1053604", Offset="0x1053604")]
	[FieldOffset(Offset="0x28")]
	private BattleUnitHitReactionController _unitHitReactionController;

	[Attribute(Name="InjectAttribute", RVA="0x1053614", Offset="0x1053614")]
	[FieldOffset(Offset="0x30")]
	private BattleEffectsController _effectsController;

	[Attribute(Name="InjectAttribute", RVA="0x1053624", Offset="0x1053624")]
	[FieldOffset(Offset="0x38")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x1053634", Offset="0x1053634")]
	[FieldOffset(Offset="0x40")]
	private BattleEnvironmentController _battleEnvController;

	[Attribute(Name="InjectAttribute", RVA="0x1053644", Offset="0x1053644")]
	[FieldOffset(Offset="0x48")]
	private BattleCinematicController _battleCinematicController;

	[Attribute(Name="InjectAttribute", RVA="0x1053654", Offset="0x1053654")]
	[FieldOffset(Offset="0x50")]
	private BattleCameraShakeController _cameraShakeController;

	[Attribute(Name="InjectAttribute", RVA="0x1053664", Offset="0x1053664")]
	[FieldOffset(Offset="0x58")]
	private BattleCastController _castController;

	[Attribute(Name="InjectAttribute", RVA="0x1053674", Offset="0x1053674")]
	[FieldOffset(Offset="0x60")]
	private BattleAutoBattleController _autoBattleController;

	[Attribute(Name="InjectAttribute", RVA="0x1053684", Offset="0x1053684")]
	[FieldOffset(Offset="0x68")]
	private BattleConfig _battleConfig;

	[Attribute(Name="InjectAttribute", RVA="0x1053694", Offset="0x1053694")]
	[FieldOffset(Offset="0x70")]
	private BattleStateTransitionController _battleStateTransitionController;

	[Attribute(Name="InjectAttribute", RVA="0x10536A4", Offset="0x10536A4")]
	[FieldOffset(Offset="0x78")]
	private BattleHandController _battlePlayerHandController;

	[Attribute(Name="InjectAttribute", RVA="0x10536B4", Offset="0x10536B4")]
	[FieldOffset(Offset="0x80")]
	private IBattleEndHandler _battleEndHandler;

	[Attribute(Name="InjectAttribute", RVA="0x10536C4", Offset="0x10536C4")]
	[FieldOffset(Offset="0x88")]
	private MultiplayerRecovery _mpRecovery;

	[Attribute(Name="InjectAttribute", RVA="0x10536D4", Offset="0x10536D4")]
	[FieldOffset(Offset="0x90")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x10536E4", Offset="0x10536E4")]
	[FieldOffset(Offset="0x98")]
	private BattleTelemetryCollector _battleTelemetryCollector;

	[Attribute(Name="InjectAttribute", RVA="0x10536F4", Offset="0x10536F4")]
	[FieldOffset(Offset="0xA0")]
	private GraphicsSettings _graphicsSettings;

	[Attribute(Name="InjectAttribute", RVA="0x1053704", Offset="0x1053704")]
	[FieldOffset(Offset="0xA8")]
	private FirebaseController _firebaseController;

	[Attribute(Name="InjectAttribute", RVA="0x1053714", Offset="0x1053714")]
	[FieldOffset(Offset="0xB0")]
	private BattleAbilityCameraManager _abilityCameraManager;

	[Attribute(Name="InjectAttribute", RVA="0x1053724", Offset="0x1053724")]
	[FieldOffset(Offset="0xB8")]
	private SharedPrefs _sharedPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x1053734", Offset="0x1053734")]
	[FieldOffset(Offset="0xC0")]
	private BattleWorldController _worldController;

	[Attribute(Name="InjectAttribute", RVA="0x1053744", Offset="0x1053744")]
	[FieldOffset(Offset="0xC8")]
	private BattleMessageController _messageController;

	[FieldOffset(Offset="0xD0")]
	private ABattleGameState.ATransitionContext _context;

	[FieldOffset(Offset="0xD8")]
	private bool _battleRunning;

	[FieldOffset(Offset="0xD9")]
	private bool _hidScrims;

	[FieldOffset(Offset="0xDC")]
	private uint _battleSpeedTimeScale;

	[FieldOffset(Offset="0xE0")]
	private uint _battleCatchupTimeScale;

	[FieldOffset(Offset="0xE4")]
	private bool _doDamageTraceLogging;

	[FieldOffset(Offset="0xE5")]
	private bool _handledInitialSpawns;

	[FieldOffset(Offset="0xE6")]
	private bool _abilityCamerasEnabled;

	[FieldOffset(Offset="0xE7")]
	private bool _battleHasEnded;

	[FieldOffset(Offset="0xE8")]
	private bool _isExiting;

	[FieldOffset(Offset="0xEC")]
	private float _exitDelayTimerS;

	[FieldOffset(Offset="0xF0")]
	private Type _exitToState;

	[FieldOffset(Offset="0xF8")]
	private ITransitionContext _exitTransitionContext;

	[FieldOffset(Offset="0x100")]
	private uint? _battleQuitTimeScaleId;

	[FieldOffset(Offset="0x108")]
	private float? _applicationPauseTime;

	[FieldOffset(Offset="0x110")]
	private bool _trackFramerate;

	[FieldOffset(Offset="0x118")]
	private ulong _frameCounter;

	[FieldOffset(Offset="0x120")]
	private float _totalBattleTime;

	[FieldOffset(Offset="0x124")]
	private BattleConnectionStatus _connectionStatus;

	[FieldOffset(Offset="0x128")]
	private float _badConnectionMaxClockDriftS;

	[FieldOffset(Offset="0x12C")]
	private float _badConnectionUpdateWaitS;

	[FieldOffset(Offset="0x130")]
	private float _badConnectionMinDurationS;

	[FieldOffset(Offset="0x134")]
	private float _badConnectionDurationS;

	public int CurrentEncounterIndex
	{
		[Address(RVA="0x114A6D4", Offset="0x114A6D4", VA="0x114A6D4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E548", Offset="0x106E548")]
		get
		{
			return new int();
		}
		[Address(RVA="0x114A6DC", Offset="0x114A6DC", VA="0x114A6DC")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E558", Offset="0x106E558")]
		private set
		{
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x114A6CC", Offset="0x114A6CC", VA="0x114A6CC", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x114E360", Offset="0x114E360", VA="0x114E360")]
	public BattleHandler()
	{
	}

	[Address(RVA="0x199FAC8", Offset="0x199FAC8", VA="0x199FAC8")]
	public void ExitBattle<ExitToState>(ITransitionContext context = // 
	// Current member / type: System.Void BattleHandler::ExitBattle(Glunies.ITransitionContext)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void ExitBattle(Glunies.ITransitionContext)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x199FB14", Offset="0x199FB14", VA="0x199FB14")]
	public void ExitBattle<ExitToState>(bool delay, ITransitionContext context = // 
	// Current member / type: System.Void BattleHandler::ExitBattle(System.Boolean,Glunies.ITransitionContext)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void ExitBattle(System.Boolean,Glunies.ITransitionContext)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x114AEC8", Offset="0x114AEC8", VA="0x114AEC8")]
	private void ExitBattle()
	{
	}

	[Address(RVA="0x114D240", Offset="0x114D240", VA="0x114D240")]
	public void HandleAbilityCamera(BattleLib_UpdateResult.Types.AbilityCamera abilityCam)
	{
	}

	[Address(RVA="0x114BD88", Offset="0x114BD88", VA="0x114BD88")]
	public void HandleAutoAttackTargetChange(BattleLib_UpdateResult.Types.AutoAttackTargetChange autoAttackTargetChange)
	{
	}

	[Address(RVA="0x114D5E8", Offset="0x114D5E8", VA="0x114D5E8")]
	public void HandleBattleActivityUpdate(BattleLib_UpdateResult.Types.BattleActivityUpdate battleActivityUpdate)
	{
	}

	[Address(RVA="0x114DAD4", Offset="0x114DAD4", VA="0x114DAD4")]
	public void HandleBattleEnd(BattleLib_UpdateResult.Types.BattleEnded battleEnded)
	{
	}

	[Address(RVA="0x114E0A0", Offset="0x114E0A0", VA="0x114E0A0")]
	public void HandleBattleQuit()
	{
	}

	[Address(RVA="0x114CB4C", Offset="0x114CB4C", VA="0x114CB4C")]
	public void HandleCastEnd(BattleLib_UpdateResult.Types.CastEnd castEnd)
	{
	}

	[Address(RVA="0x114C84C", Offset="0x114C84C", VA="0x114C84C")]
	public void HandleCastStart(BattleLib_UpdateResult.Types.CastStart castStart)
	{
	}

	[Address(RVA="0x114BE54", Offset="0x114BE54", VA="0x114BE54")]
	public void HandleDamage(BattleLib_UpdateResult.Types.Damage damage)
	{
	}

	[Address(RVA="0x114C46C", Offset="0x114C46C", VA="0x114C46C")]
	public void HandleDeath(byte unitId)
	{
	}

	[Address(RVA="0x114AF90", Offset="0x114AF90", VA="0x114AF90", Slot="5")]
	public void HandleDispatchAction(DBattleViewControllerAction action)
	{
	}

	[Address(RVA="0x114B2CC", Offset="0x114B2CC", VA="0x114B2CC", Slot="6")]
	public void HandleDispatchAction(DBattleBeginAction action)
	{
	}

	[Address(RVA="0x114B408", Offset="0x114B408", VA="0x114B408", Slot="7")]
	public void HandleDispatchAction(DBattleAbilityCamerasSettingChangedAction action)
	{
	}

	[Address(RVA="0x114B47C", Offset="0x114B47C", VA="0x114B47C", Slot="8")]
	public void HandleDispatchAction(DApplicationPauseAction action)
	{
	}

	[Address(RVA="0x114B69C", Offset="0x114B69C", VA="0x114B69C", Slot="9")]
	public void HandleDispatchAction(DPlayerThinkingHeartbeatAction action)
	{
	}

	[Address(RVA="0x114B780", Offset="0x114B780", VA="0x114B780", Slot="10")]
	public void HandleDispatchAction(DCastAttemptAction action)
	{
	}

	[Address(RVA="0x114D88C", Offset="0x114D88C", VA="0x114D88C")]
	public void HandleEncounterEnd(int encounterIndex)
	{
	}

	[Address(RVA="0x114D6F4", Offset="0x114D6F4", VA="0x114D6F4")]
	public void HandleEncounterStart(int encounterIndex)
	{
	}

	[Address(RVA="0x114C72C", Offset="0x114C72C", VA="0x114C72C")]
	public void HandlePlayerHand(BattleLib_UpdateResult.Types.PlayerHand hand)
	{
	}

	[Address(RVA="0x114C7BC", Offset="0x114C7BC", VA="0x114C7BC")]
	public void HandleSpellHand(BattleLib_UpdateResult.Types.SpellHand spellHand)
	{
	}

	[Address(RVA="0x114E260", Offset="0x114E260", VA="0x114E260")]
	public void HandleUnitFutureDeath(byte unitId, float deathTime)
	{
	}

	[Address(RVA="0x114C21C", Offset="0x114C21C", VA="0x114C21C")]
	public void HandleUnitHealth(BattleLib_UpdateResult.Types.UnitHealth health)
	{
	}

	[Address(RVA="0x114C39C", Offset="0x114C39C", VA="0x114C39C")]
	public void HandleUnitHpDecay(BattleLib_UpdateResult.Types.UnitHpDecay hpDecay)
	{
	}

	[Address(RVA="0x114BCC8", Offset="0x114BCC8", VA="0x114BCC8")]
	public void HandleUnitPosition(BattleLib_UpdateResult.Types.UnitPosition position)
	{
	}

	[Address(RVA="0x114B9FC", Offset="0x114B9FC", VA="0x114B9FC")]
	private void HandleUnitSpawn(BattleLib_UpdateResult.Types.Spawn spawn)
	{
	}

	[Address(RVA="0x114B790", Offset="0x114B790", VA="0x114B790")]
	public void HandleUnitSpawns(RepeatedField<BattleLib_UpdateResult.Types.Spawn> spawns)
	{
	}

	[Address(RVA="0x114C4D0", Offset="0x114C4D0", VA="0x114C4D0")]
	public void HandleUseAbilityResponse(BattleLib_UpdateResult.Types.UseAbilityResponse useAbilityResponse)
	{
	}

	[Address(RVA="0x114CFFC", Offset="0x114CFFC", VA="0x114CFFC")]
	public void HandleVisualAtPosition(BattleLib_UpdateResult.Types.VisualAtPosition visual)
	{
	}

	[Address(RVA="0x114D598", Offset="0x114D598", VA="0x114D598")]
	public void HandleVisualInterrupt(BattleLib_UpdateResult.Types.VisualInterrupt visual)
	{
	}

	[Address(RVA="0x114CD38", Offset="0x114CD38", VA="0x114CD38")]
	public void HandleVisualOnUnit(BattleLib_UpdateResult.Types.VisualOnUnit visual)
	{
	}

	[Address(RVA="0x114CE54", Offset="0x114CE54", VA="0x114CE54")]
	public void HandleVisualOnWorld(BattleLib_UpdateResult.Types.VisualOnWorld visual)
	{
	}

	[Address(RVA="0x114B2D0", Offset="0x114B2D0", VA="0x114B2D0")]
	private void HideScrims()
	{
	}

	[Address(RVA="0x114A6E4", Offset="0x114A6E4", VA="0x114A6E4")]
	public void Initialize(ITransitionContext context, Action successCallback, Action failureCallback)
	{
	}

	[Address(RVA="0x114B098", Offset="0x114B098", VA="0x114B098")]
	private void SendBattleStartTelemetry()
	{
	}

	[Address(RVA="0x114AA40", Offset="0x114AA40", VA="0x114AA40")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x114B488", Offset="0x114B488", VA="0x114B488")]
	private void StartCatchupTimeScale(bool appPaused)
	{
	}

	[Address(RVA="0x114B6A0", Offset="0x114B6A0", VA="0x114B6A0")]
	private void StopCatchupTimeScale()
	{
	}

	[Address(RVA="0x114AC48", Offset="0x114AC48", VA="0x114AC48")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x114D14C", Offset="0x114D14C", VA="0x114D14C")]
	private Vector3 TranslateVisualPos(BattleLib_UpdateResult.Types.VisualPos visualPos)
	{
		return new Vector3();
	}

	[Address(RVA="0x114E2A8", Offset="0x114E2A8", VA="0x114E2A8")]
	private void UpdateConnectionStatus(BattleConnectionStatus status)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AFCC", Offset="0x104AFCC")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleHandler <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action failureCallback;

		[FieldOffset(Offset="0x20")]
		public Action successCallback;

		[FieldOffset(Offset="0x28")]
		public AnonymousJob.Work <>9__1;

		[FieldOffset(Offset="0x30")]
		public AnonymousJob.Work <>9__2;

		[FieldOffset(Offset="0x38")]
		public AnonymousJob.Work <>9__3;

		[FieldOffset(Offset="0x40")]
		public AnonymousJob.Work <>9__4;

		[FieldOffset(Offset="0x48")]
		public AnonymousJob.Work <>9__5;

		[FieldOffset(Offset="0x50")]
		public AnonymousJob.Work <>9__6;

		[FieldOffset(Offset="0x58")]
		public AnonymousJob.Work <>9__7;

		[Address(RVA="0x114AA38", Offset="0x114AA38", VA="0x114AA38")]
		public <>c__DisplayClass8_0()
		{
		}

		[Address(RVA="0x114E370", Offset="0x114E370", VA="0x114E370")]
		internal void <Initialize>b__0(bool success)
		{
		}

		[Address(RVA="0x114E8A0", Offset="0x114E8A0", VA="0x114E8A0")]
		internal void <Initialize>b__1(Action jobFinished)
		{
		}

		[Address(RVA="0x114E9DC", Offset="0x114E9DC", VA="0x114E9DC")]
		internal void <Initialize>b__2(Action jobFinished)
		{
		}

		[Address(RVA="0x114EA64", Offset="0x114EA64", VA="0x114EA64")]
		internal void <Initialize>b__3(Action jobFinished)
		{
		}

		[Address(RVA="0x114EAF0", Offset="0x114EAF0", VA="0x114EAF0")]
		internal void <Initialize>b__4(Action jobFinished)
		{
		}

		[Address(RVA="0x114EB78", Offset="0x114EB78", VA="0x114EB78")]
		internal void <Initialize>b__5(Action jobFinished)
		{
		}

		[Address(RVA="0x114EC00", Offset="0x114EC00", VA="0x114EC00")]
		internal void <Initialize>b__6(Action jobFinished)
		{
		}

		[Address(RVA="0x114EC48", Offset="0x114EC48", VA="0x114EC48")]
		internal void <Initialize>b__7(Action jobFinished)
		{
		}
	}
}