using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using Zenject;

public class PvpBattleGameState : ABattleGameState
{
	[Attribute(Name="InjectAttribute", RVA="0x1054510", Offset="0x1054510")]
	[FieldOffset(Offset="0x70")]
	private MultiplayerRecovery _mpRecovery;

	[FieldOffset(Offset="0x78")]
	private OpponentDesaturator _desaturator;

	public override bool AllowEmotes
	{
		[Address(RVA="0x12823FC", Offset="0x12823FC", VA="0x12823FC", Slot="23")]
		get
		{
			return new bool();
		}
	}

	public override bool AllowReversedPositions
	{
		[Address(RVA="0x1282414", Offset="0x1282414", VA="0x1282414", Slot="26")]
		get
		{
			return new bool();
		}
	}

	public override bool AutoBattleEnabled
	{
		[Address(RVA="0x1282354", Offset="0x1282354", VA="0x1282354", Slot="13")]
		get
		{
			return new bool();
		}
	}

	public override string AutoBattleSpeedPlayerPrefKey
	{
		[Address(RVA="0x12823AC", Offset="0x12823AC", VA="0x12823AC", Slot="17")]
		get
		{
			return null;
		}
	}

	public override string AutoBattleStartsOnPrefKey
	{
		[Address(RVA="0x128235C", Offset="0x128235C", VA="0x128235C", Slot="15")]
		get
		{
			return null;
		}
	}

	public override bool BattleSpeedToggleEnabled
	{
		[Address(RVA="0x12823A4", Offset="0x12823A4", VA="0x12823A4", Slot="14")]
		get
		{
			return new bool();
		}
	}

	public override AutoBattle.Speed DefaultBattleSpeed
	{
		[Address(RVA="0x12823F4", Offset="0x12823F4", VA="0x12823F4", Slot="16")]
		get
		{
			return new AutoBattle.Speed();
		}
	}

	public override bool IgnoreAutoBattlePref
	{
		[Address(RVA="0x128240C", Offset="0x128240C", VA="0x128240C", Slot="25")]
		get
		{
			return new bool();
		}
	}

	public override bool PlayVictoryOnDefeat
	{
		[Address(RVA="0x1282404", Offset="0x1282404", VA="0x1282404", Slot="24")]
		get
		{
			return new bool();
		}
	}

	public override bool ShowRounds
	{
		[Address(RVA="0x128234C", Offset="0x128234C", VA="0x128234C", Slot="12")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x12827A4", Offset="0x12827A4", VA="0x12827A4")]
	public PvpBattleGameState()
	{
	}

	[Address(RVA="0x128241C", Offset="0x128241C", VA="0x128241C", Slot="5")]
	public override void Exiting()
	{
	}

	[Address(RVA="0x1282454", Offset="0x1282454", VA="0x1282454", Slot="27")]
	protected override void Install(DiContainer container, ITransitionContext context, Action finished)
	{
	}

	public class TransitionContext : ABattleGameState.ATransitionContext
	{
		[FieldOffset(Offset="0x30")]
		public PvpFindMatchResponse FindMatchResponse;

		[FieldOffset(Offset="0x38")]
		public BattleLib_Bootstrap BattleData;

		[FieldOffset(Offset="0x40")]
		public bool IsReconnect;

		[Address(RVA="0x12827AC", Offset="0x12827AC", VA="0x12827AC")]
		public TransitionContext()
		{
		}
	}
}