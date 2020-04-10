using BattleLib;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BattleUnitsController : ILoggable<LogCategory>, IDispatchHandler<DBattleMsgAction<BattleLib_UpdateResult.Types.UnitTurnStarted>>, IDispatchHandler, IDispatchHandler<DBattleMsgAction<BattleLib_UpdateResult.Types.UnitEffects>>, IDispatchHandler<DBattleHealthAction>
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053FF0", Offset="0x1053FF0")]
	[FieldOffset(Offset="0x10")]
	private BattleUnit <CurrentUnit>k__BackingField;

	[Attribute(Name="InjectAttribute", RVA="0x1054000", Offset="0x1054000")]
	[FieldOffset(Offset="0x18")]
	private AssetRegistry _assetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x1054010", Offset="0x1054010")]
	[FieldOffset(Offset="0x20")]
	private BattleUnit.Pool _battleUnitPool;

	[Attribute(Name="InjectAttribute", RVA="0x1054020", Offset="0x1054020")]
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x1054030", Offset="0x1054030")]
	[FieldOffset(Offset="0x30")]
	private UnitVisualSequencerFactory _unitVisualSequencerFactory;

	[Attribute(Name="InjectAttribute", RVA="0x1054040", Offset="0x1054040")]
	[FieldOffset(Offset="0x38")]
	private DiContainer _diContainer;

	[Attribute(Name="InjectAttribute", RVA="0x1054050", Offset="0x1054050")]
	[FieldOffset(Offset="0x40")]
	private BattleEnvironmentController _battleEnvController;

	[Attribute(Name="InjectAttribute", RVA="0x1054060", Offset="0x1054060")]
	[FieldOffset(Offset="0x48")]
	private ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x1054070", Offset="0x1054070")]
	[FieldOffset(Offset="0x50")]
	private LocalizationManager _locManager;

	[Attribute(Name="InjectAttribute", RVA="0x1054080", Offset="0x1054080")]
	[FieldOffset(Offset="0x58")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x60")]
	private AssetCollection _assets;

	[FieldOffset(Offset="0x68")]
	private Dictionary<byte, BattleUnit> _units;

	[FieldOffset(Offset="0x70")]
	private List<byte> _despawnedUnits;

	[FieldOffset(Offset="0x78")]
	private List<BattleUnit> _dyingUnits;

	[FieldOffset(Offset="0x80")]
	private Camera _mainCamera;

	[FieldOffset(Offset="0x88")]
	private uint _deathSlowMoTimeScaleId;

	[FieldOffset(Offset="0x8C")]
	private float _deathSlowMoEndTimeUnityClockS;

	[FieldOffset(Offset="0x90")]
	private bool _allowDeathVisuals;

	[FieldOffset(Offset="0x94")]
	private float _deathSlowMoPreDurationS;

	[FieldOffset(Offset="0x98")]
	private float _deathSlowMoPostDurationS;

	[FieldOffset(Offset="0x9C")]
	private float _deathSlowMoTimeScale;

	public BattleUnit CurrentUnit
	{
		[Address(RVA="0x129F4E8", Offset="0x129F4E8", VA="0x129F4E8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E6A8", Offset="0x106E6A8")]
		get
		{
			return null;
		}
		[Address(RVA="0x129F4F0", Offset="0x129F4F0", VA="0x129F4F0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E6B8", Offset="0x106E6B8")]
		private set
		{
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x129F4E0", Offset="0x129F4E0", VA="0x129F4E0", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x12A1CC4", Offset="0x12A1CC4", VA="0x12A1CC4")]
	public BattleUnitsController()
	{
	}

	[Address(RVA="0x12A1238", Offset="0x12A1238", VA="0x12A1238")]
	public bool AllEnemiesHaveEffectType(BattleEffectType effectType)
	{
		return new bool();
	}

	[Address(RVA="0x12A13E8", Offset="0x12A13E8", VA="0x12A13E8")]
	public bool AllEnemiesStealthed()
	{
		return new bool();
	}

	[Address(RVA="0x12A1098", Offset="0x12A1098", VA="0x12A1098")]
	public bool AnyEnemyIsTaunting()
	{
		return new bool();
	}

	[Address(RVA="0x129FF70", Offset="0x129FF70", VA="0x129FF70")]
	private void CleanupDyingUnits()
	{
	}

	[Address(RVA="0x12A107C", Offset="0x12A107C", VA="0x12A107C")]
	public void ClearAutoAttackTarget(byte unitId)
	{
	}

	[Address(RVA="0x12A06C8", Offset="0x12A06C8", VA="0x12A06C8")]
	public void Despawn(byte unitId)
	{
	}

	[Address(RVA="0x12A0738", Offset="0x12A0738", VA="0x12A0738")]
	public void EndDeathVisuals()
	{
	}

	[Address(RVA="0x12A0C64", Offset="0x12A0C64", VA="0x12A0C64")]
	public BattleUnit GetNearestUnitToScreenPos(Vector2 screenPos, float maxScreenDist = 100f, bool isLongPress = false)
	{
		return null;
	}

	[Address(RVA="0x1295648", Offset="0x1295648", VA="0x1295648")]
	public BattleUnit GetUnit(byte unitId)
	{
		return null;
	}

	[Address(RVA="0x12A0AA8", Offset="0x12A0AA8", VA="0x12A0AA8")]
	public BattleUnit GetUnitFromGameObject(GameObject gameObject)
	{
		return null;
	}

	[Address(RVA="0x12A0C04", Offset="0x12A0C04", VA="0x12A0C04")]
	public Dictionary<byte, BattleUnit>.ValueCollection GetUnits()
	{
		return null;
	}

	[Address(RVA="0x12A1630", Offset="0x12A1630", VA="0x12A1630", Slot="5")]
	public void HandleDispatchAction(DBattleMsgAction<BattleLib_UpdateResult.Types.UnitTurnStarted> action)
	{
	}

	[Address(RVA="0x12A1840", Offset="0x12A1840", VA="0x12A1840", Slot="6")]
	public void HandleDispatchAction(DBattleMsgAction<BattleLib_UpdateResult.Types.UnitEffects> action)
	{
	}

	[Address(RVA="0x12A19A0", Offset="0x12A19A0", VA="0x12A19A0", Slot="7")]
	public void HandleDispatchAction(DBattleHealthAction action)
	{
	}

	[Address(RVA="0x129F4F8", Offset="0x129F4F8", VA="0x129F4F8")]
	public void Initialize()
	{
	}

	[Address(RVA="0x129F884", Offset="0x129F884", VA="0x129F884")]
	public void LoadAssets(string[] unitAssets, Action finished)
	{
	}

	[Address(RVA="0x12A0864", Offset="0x12A0864", VA="0x12A0864")]
	public void PlayVictory(int winningTeam)
	{
	}

	[Address(RVA="0x12A1BB4", Offset="0x12A1BB4", VA="0x12A1BB4")]
	private void ReleaseDyingUnit(BattleUnit dyingUnit)
	{
	}

	[Address(RVA="0x129FC1C", Offset="0x129FC1C", VA="0x129FC1C")]
	private void RemoveDeadUnits()
	{
	}

	[Address(RVA="0x12A1038", Offset="0x12A1038", VA="0x12A1038")]
	public void SetAutoAttackTarget(byte unitId, byte targetUnitId)
	{
	}

	[Address(RVA="0x12A1588", Offset="0x12A1588", VA="0x12A1588")]
	public void SetFutureDeathTime(byte unitId, float deathTime)
	{
	}

	[Address(RVA="0x12A0F3C", Offset="0x12A0F3C", VA="0x12A0F3C")]
	public void SetPosition(byte unitId, float x, float y)
	{
	}

	[Address(RVA="0x12A1004", Offset="0x12A1004", VA="0x12A1004")]
	public void SetUnitEndCast(byte unitId, ushort castId)
	{
	}

	[Address(RVA="0x12A0FC8", Offset="0x12A0FC8", VA="0x12A0FC8")]
	public void SetUnitStartCast(byte unitId, byte abilityId, ushort castId)
	{
	}

	[Address(RVA="0x129F6B4", Offset="0x129F6B4", VA="0x129F6B4")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x12A02A4", Offset="0x12A02A4", VA="0x12A02A4")]
	public void Spawn(byte unitId, BattleLib_Bootstrap.Types.Unit unitData, float x, float y, byte playerId, byte teamId, BattleUnit.Ownership owner, uint maxHp, byte spawnIndex, uint altPrefabId)
	{
	}

	[Address(RVA="0x12A19D8", Offset="0x12A19D8", VA="0x12A19D8")]
	private void StartDeath(BattleUnit unit)
	{
	}

	[Address(RVA="0x129F9F8", Offset="0x129F9F8", VA="0x129F9F8")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x12A0084", Offset="0x12A0084", VA="0x12A0084")]
	public void UnitVisualTickUpdate()
	{
	}

	[Address(RVA="0x129FE1C", Offset="0x129FE1C", VA="0x129FE1C")]
	private void UpdateDeathCam(bool deathCamAllowed, float lastKnownFutureDeathTime)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B0CC", Offset="0x104B0CC")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleUnitsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public string[] unitAssets;

		[Address(RVA="0x129F9F0", Offset="0x129F9F0", VA="0x129F9F0")]
		public <>c__DisplayClass8_0()
		{
		}

		[Address(RVA="0x12A1CEC", Offset="0x12A1CEC", VA="0x12A1CEC")]
		internal void <LoadAssets>b__0(Action executed)
		{
		}

		[Address(RVA="0x12A1DB0", Offset="0x12A1DB0", VA="0x12A1DB0")]
		internal void <LoadAssets>b__1(Action executed)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B0DC", Offset="0x104B0DC")]
	private sealed class <>c__DisplayClass8_1
	{
		[FieldOffset(Offset="0x10")]
		public Action executed;

		[FieldOffset(Offset="0x18")]
		public BattleUnitsController.<>c__DisplayClass8_0 CS$<>8__locals1;

		[Address(RVA="0x12A1EA8", Offset="0x12A1EA8", VA="0x12A1EA8")]
		public <>c__DisplayClass8_1()
		{
		}

		[Address(RVA="0x12A1EB0", Offset="0x12A1EB0", VA="0x12A1EB0")]
		internal void <LoadAssets>b__2(AssetCollection collection)
		{
		}
	}
}