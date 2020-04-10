using BattleLib;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleCastController : ILoggable<LogCategory>, IDispatchHandler<DBattleAbilityCardWidgetAction>, IDispatchHandler, IDispatchHandler<DBattleFullscreenInputAction>, IDispatchHandler<DBattleAbilityCastResultAction>, IDispatchHandler<DBattleUnitsControllerAction>, IDispatchHandler<DBattleEncounterAction>, IDispatchHandler<DBattleMsgAction<BattleLib_UpdateResult.Types.UnitEffects>>, IDispatchHandler<DBattleMsgAction<BattleLib_UpdateResult.Types.PlayerSpellCharge>>, IDispatchHandler<DBattleBusyAction>, IDispatchHandler<DBattleMsgAction<BattleLib_UpdateResult.Types.UnitTurnStarted>>
{
	[FieldOffset(Offset="0x0")]
	protected readonly static UnityEngine.Color s_scrimColor;

	[FieldOffset(Offset="0x10")]
	protected readonly static UnityEngine.Color s_allyHighlightColor;

	[FieldOffset(Offset="0x20")]
	protected readonly static UnityEngine.Color s_enemyHighlightColor;

	[FieldOffset(Offset="0x30")]
	protected readonly static UnityEngine.Color s_unitDimColor;

	[FieldOffset(Offset="0x40")]
	private readonly static UnityEngine.Color s_canTargetOutlineColor;

	[Attribute(Name="InjectAttribute", RVA="0x1053014", Offset="0x1053014")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1053024", Offset="0x1053024")]
	[FieldOffset(Offset="0x18")]
	private ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x1053034", Offset="0x1053034")]
	[FieldOffset(Offset="0x20")]
	private BattleUnitsController _unitsController;

	[Attribute(Name="InjectAttribute", RVA="0x1053044", Offset="0x1053044")]
	[FieldOffset(Offset="0x28")]
	private IHapticController _hapticController;

	[Attribute(Name="InjectAttribute", RVA="0x1053054", Offset="0x1053054")]
	[FieldOffset(Offset="0x30")]
	private LocalizationManager _locManager;

	[Attribute(Name="InjectAttribute", RVA="0x1053064", Offset="0x1053064")]
	[FieldOffset(Offset="0x38")]
	private BattleWorldController _worldController;

	[Attribute(Name="InjectAttribute", RVA="0x1053074", Offset="0x1053074")]
	[FieldOffset(Offset="0x40")]
	private BattleHandController _handController;

	[Attribute(Name="InjectAttribute", RVA="0x1053084", Offset="0x1053084")]
	[FieldOffset(Offset="0x48")]
	private BattleAutoBattleController _autoBattleController;

	[Attribute(Name="InjectAttribute", RVA="0x1053094", Offset="0x1053094")]
	[FieldOffset(Offset="0x50")]
	private BattleEnvironmentController _battleEnvController;

	[FieldOffset(Offset="0x58")]
	private BattleUnit _currentTarget;

	[FieldOffset(Offset="0x60")]
	private BattleCastController.State _currentState;

	[FieldOffset(Offset="0x64")]
	private bool _allowTargetSelection;

	[FieldOffset(Offset="0x65")]
	private bool _isPlayersTurn;

	[FieldOffset(Offset="0x66")]
	private bool _battleIsBusy;

	[FieldOffset(Offset="0x68")]
	private BattleAbilityCardWidget _pendingAbility;

	[FieldOffset(Offset="0x70")]
	private List<BattleUnit> _highlightedUnits;

	[FieldOffset(Offset="0x78")]
	private Dictionary<uint, BattleLib_UpdateResult.Types.PlayerSpellCharge> _spellCharges;

	public LogCategory LogCategory
	{
		[Address(RVA="0x113A004", Offset="0x113A004", VA="0x113A004", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x113CAAC", Offset="0x113CAAC", VA="0x113CAAC")]
	static BattleCastController()
	{
	}

	[Address(RVA="0x113CA10", Offset="0x113CA10", VA="0x113CA10")]
	public BattleCastController()
	{
	}

	[Address(RVA="0x113AC40", Offset="0x113AC40", VA="0x113AC40")]
	private void AttemptCast(BattleAbilityCardData abilityCardData, BattleUnit targetOverride = // 
	// Current member / type: System.Void BattleCastController::AttemptCast(BattleAbilityCardData,BattleUnit,System.Int32)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void AttemptCast(BattleAbilityCardData,BattleUnit,System.Int32)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x113BA04", Offset="0x113BA04", VA="0x113BA04")]
	private void ClearHighlightedUnits()
	{
	}

	[Address(RVA="0x113A04C", Offset="0x113A04C", VA="0x113A04C")]
	private void EnterState(BattleCastController.State newState)
	{
	}

	[Address(RVA="0x113A9B8", Offset="0x113A9B8", VA="0x113A9B8")]
	private void FailedPredictedCast(BattleAbilityCardData abilityCardData, CastAttemptStatus predictedStatus)
	{
	}

	[Address(RVA="0x113A434", Offset="0x113A434", VA="0x113A434")]
	public float GetSpellCharge(uint abilityId)
	{
		return new float();
	}

	[Address(RVA="0x113A4D4", Offset="0x113A4D4", VA="0x113A4D4", Slot="5")]
	public void HandleDispatchAction(DBattleAbilityCardWidgetAction action)
	{
	}

	[Address(RVA="0x113AF6C", Offset="0x113AF6C", VA="0x113AF6C", Slot="6")]
	public void HandleDispatchAction(DBattleFullscreenInputAction action)
	{
	}

	[Address(RVA="0x113B494", Offset="0x113B494", VA="0x113B494", Slot="7")]
	public void HandleDispatchAction(DBattleAbilityCastResultAction action)
	{
	}

	[Address(RVA="0x113B730", Offset="0x113B730", VA="0x113B730", Slot="8")]
	public void HandleDispatchAction(DBattleUnitsControllerAction action)
	{
	}

	[Address(RVA="0x113B7E8", Offset="0x113B7E8", VA="0x113B7E8", Slot="9")]
	public void HandleDispatchAction(DBattleEncounterAction action)
	{
	}

	[Address(RVA="0x113B7FC", Offset="0x113B7FC", VA="0x113B7FC", Slot="10")]
	public void HandleDispatchAction(DBattleMsgAction<BattleLib_UpdateResult.Types.UnitEffects> action)
	{
	}

	[Address(RVA="0x113B804", Offset="0x113B804", VA="0x113B804", Slot="11")]
	public void HandleDispatchAction(DBattleMsgAction<BattleLib_UpdateResult.Types.PlayerSpellCharge> action)
	{
	}

	[Address(RVA="0x113B894", Offset="0x113B894", VA="0x113B894", Slot="12")]
	public void HandleDispatchAction(DBattleBusyAction action)
	{
	}

	[Address(RVA="0x113B958", Offset="0x113B958", VA="0x113B958", Slot="13")]
	public void HandleDispatchAction(DBattleMsgAction<BattleLib_UpdateResult.Types.UnitTurnStarted> action)
	{
	}

	[Address(RVA="0x113C014", Offset="0x113C014", VA="0x113C014")]
	private void HighlightSpawnPoints()
	{
	}

	[Address(RVA="0x113BBA8", Offset="0x113BBA8", VA="0x113BBA8")]
	private void HighlightUnits(bool dimEnemies, bool highlightSource)
	{
	}

	[Address(RVA="0x113A00C", Offset="0x113A00C", VA="0x113A00C")]
	public void Initialize()
	{
	}

	[Address(RVA="0x113B1DC", Offset="0x113B1DC", VA="0x113B1DC")]
	private bool IsValidAlly(BattleUnit unit)
	{
		return new bool();
	}

	[Address(RVA="0x113C550", Offset="0x113C550", VA="0x113C550")]
	private bool IsValidTarget(BattleUnit unit, BattleCastController.TargetOption options, bool showError = false)
	{
		return new bool();
	}

	[Address(RVA="0x113A7F4", Offset="0x113A7F4", VA="0x113A7F4")]
	private CastAttemptStatus PredictAttemptStatus(BattleAbilityCardData abilityCardData)
	{
		return new CastAttemptStatus();
	}

	[Address(RVA="0x113B25C", Offset="0x113B25C", VA="0x113B25C")]
	private void SelectTarget(BattleUnit preferredTarget = // 
	// Current member / type: System.Void BattleCastController::SelectTarget(BattleUnit)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void SelectTarget(BattleUnit)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x113A1B4", Offset="0x113A1B4", VA="0x113A1B4")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x113A200", Offset="0x113A200", VA="0x113A200")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x113B8DC", Offset="0x113B8DC", VA="0x113B8DC")]
	private void UpdateAllowTargetSelection()
	{
	}

	[Address(RVA="0x113A204", Offset="0x113A204", VA="0x113A204")]
	private void UpdateHighlightedUnits()
	{
	}

	private enum State
	{
		[FieldOffset(Offset="0x0")]
		WaitingForAbility,
		[FieldOffset(Offset="0x0")]
		SelectTarget,
		[FieldOffset(Offset="0x0")]
		SelectSpawnIndex
	}

	[Flags]
	private enum TargetOption
	{
		[FieldOffset(Offset="0x0")]
		None,
		[FieldOffset(Offset="0x0")]
		IgnoreTaunt,
		[FieldOffset(Offset="0x0")]
		IgnoreStealth
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		EnabledChanged = 1,
		[FieldOffset(Offset="0x0")]
		SpeedChanged = 2,
		[FieldOffset(Offset="0x0")]
		Ramp = 4
	}
}