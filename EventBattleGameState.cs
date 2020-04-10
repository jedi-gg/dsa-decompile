using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using Zenject;

public class EventBattleGameState : ABattleGameState
{
	[Attribute(Name="InjectAttribute", RVA="0x1054300", Offset="0x1054300")]
	[FieldOffset(Offset="0x70")]
	private DispatchSystem _dispatch;

	public override bool AllowPause
	{
		[Address(RVA="0x1213848", Offset="0x1213848", VA="0x1213848", Slot="21")]
		get
		{
			return new bool();
		}
	}

	public override bool AllowQuit
	{
		[Address(RVA="0x1213840", Offset="0x1213840", VA="0x1213840", Slot="20")]
		get
		{
			return new bool();
		}
	}

	public override bool AutoBattleEnabled
	{
		[Address(RVA="0x12137A0", Offset="0x12137A0", VA="0x12137A0", Slot="13")]
		get
		{
			return new bool();
		}
	}

	public override string AutoBattleSpeedPlayerPrefKey
	{
		[Address(RVA="0x12137F8", Offset="0x12137F8", VA="0x12137F8", Slot="17")]
		get
		{
			return null;
		}
	}

	public override string AutoBattleStartsOnPrefKey
	{
		[Address(RVA="0x12137A8", Offset="0x12137A8", VA="0x12137A8", Slot="15")]
		get
		{
			return null;
		}
	}

	public override bool BattleSpeedToggleEnabled
	{
		[Address(RVA="0x12137F0", Offset="0x12137F0", VA="0x12137F0", Slot="14")]
		get
		{
			return new bool();
		}
	}

	public override bool ShowRounds
	{
		[Address(RVA="0x1213798", Offset="0x1213798", VA="0x1213798", Slot="12")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1213B04", Offset="0x1213B04", VA="0x1213B04")]
	public EventBattleGameState()
	{
	}

	[Address(RVA="0x1213850", Offset="0x1213850", VA="0x1213850", Slot="27")]
	protected override void Install(DiContainer container, ITransitionContext context, Action finished)
	{
	}

	public class TransitionContext : ABattleGameState.ATransitionContext
	{
		[FieldOffset(Offset="0x30")]
		public EventBattleStartResponse StartBattleResponse;

		[FieldOffset(Offset="0x38")]
		public EventIdentifier EventId;

		[FieldOffset(Offset="0x40")]
		public EventGameStateContext.EventType EventType;

		[FieldOffset(Offset="0x44")]
		public bool IsLastTier;

		[Address(RVA="0x1213B0C", Offset="0x1213B0C", VA="0x1213B0C")]
		public TransitionContext()
		{
		}
	}
}