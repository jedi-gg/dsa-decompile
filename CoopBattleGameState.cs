using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using Zenject;

public class CoopBattleGameState : ABattleGameState
{
	public override bool AutoBattleEnabled
	{
		[Address(RVA="0x154C19C", Offset="0x154C19C", VA="0x154C19C", Slot="13")]
		get
		{
			return new bool();
		}
	}

	public override bool BattleSpeedToggleEnabled
	{
		[Address(RVA="0x154C1A4", Offset="0x154C1A4", VA="0x154C1A4", Slot="14")]
		get
		{
			return new bool();
		}
	}

	public override bool ShowRounds
	{
		[Address(RVA="0x154C194", Offset="0x154C194", VA="0x154C194", Slot="12")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x154C420", Offset="0x154C420", VA="0x154C420")]
	public CoopBattleGameState()
	{
	}

	[Address(RVA="0x154C1AC", Offset="0x154C1AC", VA="0x154C1AC", Slot="27")]
	protected override void Install(DiContainer container, ITransitionContext context, Action finished)
	{
	}

	public class TransitionContext : ABattleGameState.ATransitionContext
	{
		[FieldOffset(Offset="0x30")]
		public CoopFindMatchResponse FindMatchResponse;

		[FieldOffset(Offset="0x38")]
		public BattleLib_Bootstrap BattleData;

		[Address(RVA="0x154C428", Offset="0x154C428", VA="0x154C428")]
		public TransitionContext()
		{
		}
	}
}