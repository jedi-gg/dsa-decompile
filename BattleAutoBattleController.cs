using BattleLib;
using Glunies;
using Il2CppDummyDll;
using System;

public class BattleAutoBattleController : ILoggable<LogCategory>, IDispatchHandler<DBattleAutoBattleAction>, IDispatchHandler, IDispatchHandler<DBattleAutoBattleStateChangedAction>, IDispatchHandler<DBattleAbilityCardWidgetAction>, IDispatchHandler<DBattleEndedAction>, IDispatchHandler<DBattleSelectTargetAction>
{
	[FieldOffset(Offset="0x0")]
	private const float RAMP_DURATION_S = 4f;

	[Attribute(Name="InjectAttribute", RVA="0x1052D6C", Offset="0x1052D6C")]
	[FieldOffset(Offset="0x10")]
	private AccountPrefs _accountPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x1052D7C", Offset="0x1052D7C")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1052D8C", Offset="0x1052D8C")]
	[FieldOffset(Offset="0x20")]
	private ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x1052D9C", Offset="0x1052D9C")]
	[FieldOffset(Offset="0x28")]
	private BattleConfig _battleConfig;

	[Attribute(Name="InjectAttribute", RVA="0x1052DAC", Offset="0x1052DAC")]
	[FieldOffset(Offset="0x30")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1052DBC", Offset="0x1052DBC")]
	[FieldOffset(Offset="0x38")]
	private FeatureLockController _featureLockController;

	[FieldOffset(Offset="0x40")]
	private bool _autoBattleEnabled;

	[FieldOffset(Offset="0x41")]
	private bool _autoBattleEverEnabled;

	[FieldOffset(Offset="0x44")]
	private AutoBattle.Speed _speed;

	[FieldOffset(Offset="0x48")]
	private uint _timeScaleId;

	[FieldOffset(Offset="0x4C")]
	private float _prevTimeScale;

	[FieldOffset(Offset="0x50")]
	private float _rampTimer;

	public bool AutoBattleEnabled
	{
		[Address(RVA="0x116899C", Offset="0x116899C", VA="0x116899C")]
		get
		{
			return new bool();
		}
	}

	public bool AutoBattleEverEnabled
	{
		[Address(RVA="0x11689A4", Offset="0x11689A4", VA="0x11689A4")]
		get
		{
			return new bool();
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x1168994", Offset="0x1168994", VA="0x1168994", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	public int Speed
	{
		[Address(RVA="0x11689AC", Offset="0x11689AC", VA="0x11689AC")]
		get
		{
			return new int();
		}
	}

	[Address(RVA="0x1169704", Offset="0x1169704", VA="0x1169704")]
	public BattleAutoBattleController()
	{
	}

	[Address(RVA="0x1168FD8", Offset="0x1168FD8", VA="0x1168FD8", Slot="5")]
	public void HandleDispatchAction(DBattleAutoBattleAction action)
	{
	}

	[Address(RVA="0x1169318", Offset="0x1169318", VA="0x1169318", Slot="6")]
	public void HandleDispatchAction(DBattleAutoBattleStateChangedAction action)
	{
	}

	[Address(RVA="0x11695F4", Offset="0x11695F4", VA="0x11695F4", Slot="7")]
	public void HandleDispatchAction(DBattleAbilityCardWidgetAction action)
	{
	}

	[Address(RVA="0x1169600", Offset="0x1169600", VA="0x1169600", Slot="8")]
	public void HandleDispatchAction(DBattleEndedAction action)
	{
	}

	[Address(RVA="0x1169678", Offset="0x1169678", VA="0x1169678", Slot="9")]
	public void HandleDispatchAction(DBattleSelectTargetAction action)
	{
	}

	[Address(RVA="0x11689B4", Offset="0x11689B4", VA="0x11689B4")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1168C44", Offset="0x1168C44", VA="0x1168C44")]
	private void SetAutoBattleEnabled(bool enabled)
	{
	}

	[Address(RVA="0x1169564", Offset="0x1169564", VA="0x1169564")]
	private void SetTimeScale(float timeScale)
	{
	}

	[Address(RVA="0x1168E90", Offset="0x1168E90", VA="0x1168E90")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1168C68", Offset="0x1168C68", VA="0x1168C68")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1169228", Offset="0x1169228", VA="0x1169228")]
	private void TogglePlay(bool isPlayOn)
	{
	}

	[Address(RVA="0x11690A8", Offset="0x11690A8", VA="0x11690A8")]
	private void ToggleSpeed()
	{
	}
}