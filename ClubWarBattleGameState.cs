using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using Zenject;

public class ClubWarBattleGameState : ABattleGameState
{
	[Attribute(Name="InjectAttribute", RVA="0x1054270", Offset="0x1054270")]
	[FieldOffset(Offset="0x70")]
	private MultiplayerRecovery _mpRecovery;

	[FieldOffset(Offset="0x78")]
	private OpponentDesaturator _desaturator;

	public override bool AllowEmotes
	{
		[Address(RVA="0x12695B8", Offset="0x12695B8", VA="0x12695B8", Slot="23")]
		get
		{
			return new bool();
		}
	}

	public override bool AutoBattleEnabled
	{
		[Address(RVA="0x1269510", Offset="0x1269510", VA="0x1269510", Slot="13")]
		get
		{
			return new bool();
		}
	}

	public override string AutoBattleSpeedPlayerPrefKey
	{
		[Address(RVA="0x1269568", Offset="0x1269568", VA="0x1269568", Slot="17")]
		get
		{
			return null;
		}
	}

	public override string AutoBattleStartsOnPrefKey
	{
		[Address(RVA="0x1269518", Offset="0x1269518", VA="0x1269518", Slot="15")]
		get
		{
			return null;
		}
	}

	public override bool BattleSpeedToggleEnabled
	{
		[Address(RVA="0x1269560", Offset="0x1269560", VA="0x1269560", Slot="14")]
		get
		{
			return new bool();
		}
	}

	public override AutoBattle.Speed DefaultBattleSpeed
	{
		[Address(RVA="0x12695B0", Offset="0x12695B0", VA="0x12695B0", Slot="16")]
		get
		{
			return new AutoBattle.Speed();
		}
	}

	public override bool IgnoreAutoBattlePref
	{
		[Address(RVA="0x12695C8", Offset="0x12695C8", VA="0x12695C8", Slot="25")]
		get
		{
			return new bool();
		}
	}

	public override bool PlayVictoryOnDefeat
	{
		[Address(RVA="0x12695C0", Offset="0x12695C0", VA="0x12695C0", Slot="24")]
		get
		{
			return new bool();
		}
	}

	public override bool ShowRounds
	{
		[Address(RVA="0x1269508", Offset="0x1269508", VA="0x1269508", Slot="12")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1269958", Offset="0x1269958", VA="0x1269958")]
	public ClubWarBattleGameState()
	{
	}

	[Address(RVA="0x12695D0", Offset="0x12695D0", VA="0x12695D0", Slot="5")]
	public override void Exiting()
	{
	}

	[Address(RVA="0x1269608", Offset="0x1269608", VA="0x1269608", Slot="27")]
	protected override void Install(DiContainer container, ITransitionContext context, Action finished)
	{
	}

	public class TransitionContext : ABattleGameState.ATransitionContext
	{
		[FieldOffset(Offset="0x30")]
		public ClubWarBattleStartResponse StartBattleResponse;

		[FieldOffset(Offset="0x38")]
		public BattleLib_Bootstrap BattleData;

		[FieldOffset(Offset="0x40")]
		public string GdNodeId;

		[FieldOffset(Offset="0x48")]
		public string OpponentClubWarTelemetryId;

		[FieldOffset(Offset="0x50")]
		public bool IsReconnect;

		[Address(RVA="0x1269960", Offset="0x1269960", VA="0x1269960")]
		public TransitionContext()
		{
		}
	}
}