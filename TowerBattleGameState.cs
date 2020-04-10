using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using Zenject;

public class TowerBattleGameState : ABattleGameState
{
	public override bool AllowPause
	{
		[Address(RVA="0x14304A0", Offset="0x14304A0", VA="0x14304A0", Slot="21")]
		get
		{
			return new bool();
		}
	}

	public override bool AllowQuit
	{
		[Address(RVA="0x1430498", Offset="0x1430498", VA="0x1430498", Slot="20")]
		get
		{
			return new bool();
		}
	}

	public override bool AutoBattleEnabled
	{
		[Address(RVA="0x14303F8", Offset="0x14303F8", VA="0x14303F8", Slot="13")]
		get
		{
			return new bool();
		}
	}

	public override string AutoBattleSpeedPlayerPrefKey
	{
		[Address(RVA="0x1430450", Offset="0x1430450", VA="0x1430450", Slot="17")]
		get
		{
			return null;
		}
	}

	public override string AutoBattleStartsOnPrefKey
	{
		[Address(RVA="0x1430400", Offset="0x1430400", VA="0x1430400", Slot="15")]
		get
		{
			return null;
		}
	}

	public override bool BattleSpeedToggleEnabled
	{
		[Address(RVA="0x1430448", Offset="0x1430448", VA="0x1430448", Slot="14")]
		get
		{
			return new bool();
		}
	}

	public override bool ShowRounds
	{
		[Address(RVA="0x14303F0", Offset="0x14303F0", VA="0x14303F0", Slot="12")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x14306E4", Offset="0x14306E4", VA="0x14306E4")]
	public TowerBattleGameState()
	{
	}

	[Address(RVA="0x14304A8", Offset="0x14304A8", VA="0x14304A8", Slot="27")]
	protected override void Install(DiContainer container, ITransitionContext context, Action finished)
	{
	}

	public class TransitionContext : ABattleGameState.ATransitionContext
	{
		[FieldOffset(Offset="0x30")]
		public TowerBattleStartResponse StartBattleResponse;

		[FieldOffset(Offset="0x38")]
		public TowerIdentifier TowerId;

		[Address(RVA="0x14306EC", Offset="0x14306EC", VA="0x14306EC")]
		public TransitionContext()
		{
		}
	}
}