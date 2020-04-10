using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using Zenject;

public class KothBattleGameState : ABattleGameState
{
	[Attribute(Name="InjectAttribute", RVA="0x1054370", Offset="0x1054370")]
	[FieldOffset(Offset="0x70")]
	private MultiplayerRecovery _mpRecovery;

	[FieldOffset(Offset="0x78")]
	private OpponentDesaturator _desaturator;

	public override bool AllowEmotes
	{
		[Address(RVA="0x11C880C", Offset="0x11C880C", VA="0x11C880C", Slot="23")]
		get
		{
			return new bool();
		}
	}

	public override bool AutoBattleEnabled
	{
		[Address(RVA="0x11C8764", Offset="0x11C8764", VA="0x11C8764", Slot="13")]
		get
		{
			return new bool();
		}
	}

	public override string AutoBattleSpeedPlayerPrefKey
	{
		[Address(RVA="0x11C87BC", Offset="0x11C87BC", VA="0x11C87BC", Slot="17")]
		get
		{
			return null;
		}
	}

	public override string AutoBattleStartsOnPrefKey
	{
		[Address(RVA="0x11C876C", Offset="0x11C876C", VA="0x11C876C", Slot="15")]
		get
		{
			return null;
		}
	}

	public override bool BattleSpeedToggleEnabled
	{
		[Address(RVA="0x11C87B4", Offset="0x11C87B4", VA="0x11C87B4", Slot="14")]
		get
		{
			return new bool();
		}
	}

	public override AutoBattle.Speed DefaultBattleSpeed
	{
		[Address(RVA="0x11C8804", Offset="0x11C8804", VA="0x11C8804", Slot="16")]
		get
		{
			return new AutoBattle.Speed();
		}
	}

	public override bool IgnoreAutoBattlePref
	{
		[Address(RVA="0x11C881C", Offset="0x11C881C", VA="0x11C881C", Slot="25")]
		get
		{
			return new bool();
		}
	}

	public override bool PlayVictoryOnDefeat
	{
		[Address(RVA="0x11C8814", Offset="0x11C8814", VA="0x11C8814", Slot="24")]
		get
		{
			return new bool();
		}
	}

	public override bool ShowRounds
	{
		[Address(RVA="0x11C875C", Offset="0x11C875C", VA="0x11C875C", Slot="12")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11C8BAC", Offset="0x11C8BAC", VA="0x11C8BAC")]
	public KothBattleGameState()
	{
	}

	[Address(RVA="0x11C8824", Offset="0x11C8824", VA="0x11C8824", Slot="5")]
	public override void Exiting()
	{
	}

	[Address(RVA="0x11C885C", Offset="0x11C885C", VA="0x11C885C", Slot="27")]
	protected override void Install(DiContainer container, ITransitionContext context, Action finished)
	{
	}

	public class TransitionContext : ABattleGameState.ATransitionContext
	{
		[FieldOffset(Offset="0x30")]
		public KothBattleStartResponse StartBattleResponse;

		[FieldOffset(Offset="0x38")]
		public BattleLib_Bootstrap BattleData;

		[FieldOffset(Offset="0x40")]
		public bool IsReconnect;

		[Address(RVA="0x11C8BB4", Offset="0x11C8BB4", VA="0x11C8BB4")]
		public TransitionContext()
		{
		}
	}
}