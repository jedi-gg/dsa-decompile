using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using Zenject;

public class ClubDungeonBattleGameState : ABattleGameState
{
	public override bool AllowPause
	{
		[Address(RVA="0x11A7BBC", Offset="0x11A7BBC", VA="0x11A7BBC", Slot="21")]
		get
		{
			return new bool();
		}
	}

	public override bool AllowQuit
	{
		[Address(RVA="0x11A7BB4", Offset="0x11A7BB4", VA="0x11A7BB4", Slot="20")]
		get
		{
			return new bool();
		}
	}

	public override bool AutoBattleEnabled
	{
		[Address(RVA="0x11A7B14", Offset="0x11A7B14", VA="0x11A7B14", Slot="13")]
		get
		{
			return new bool();
		}
	}

	public override string AutoBattleSpeedPlayerPrefKey
	{
		[Address(RVA="0x11A7B6C", Offset="0x11A7B6C", VA="0x11A7B6C", Slot="17")]
		get
		{
			return null;
		}
	}

	public override string AutoBattleStartsOnPrefKey
	{
		[Address(RVA="0x11A7B1C", Offset="0x11A7B1C", VA="0x11A7B1C", Slot="15")]
		get
		{
			return null;
		}
	}

	public override bool BattleSpeedToggleEnabled
	{
		[Address(RVA="0x11A7B64", Offset="0x11A7B64", VA="0x11A7B64", Slot="14")]
		get
		{
			return new bool();
		}
	}

	public override bool ShowRounds
	{
		[Address(RVA="0x11A7B0C", Offset="0x11A7B0C", VA="0x11A7B0C", Slot="12")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11A7E04", Offset="0x11A7E04", VA="0x11A7E04")]
	public ClubDungeonBattleGameState()
	{
	}

	[Address(RVA="0x11A7BC4", Offset="0x11A7BC4", VA="0x11A7BC4", Slot="27")]
	protected override void Install(DiContainer container, ITransitionContext context, Action finished)
	{
	}

	public class TransitionContext : ABattleGameState.ATransitionContext
	{
		[FieldOffset(Offset="0x30")]
		public ClubDungeonBattleStartResponse StartBattleResponse;

		[Address(RVA="0x11A7E0C", Offset="0x11A7E0C", VA="0x11A7E0C")]
		public TransitionContext()
		{
		}
	}
}