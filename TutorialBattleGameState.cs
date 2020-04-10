using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using Zenject;

public class TutorialBattleGameState : ABattleGameState
{
	[FieldOffset(Offset="0x70")]
	private TutorialBattleController _tutorialBattleController;

	public override bool AllowMenu
	{
		[Address(RVA="0x143C7BC", Offset="0x143C7BC", VA="0x143C7BC", Slot="19")]
		get
		{
			return new bool();
		}
	}

	public override bool AutoBattleEnabled
	{
		[Address(RVA="0x143C7A4", Offset="0x143C7A4", VA="0x143C7A4", Slot="13")]
		get
		{
			return new bool();
		}
	}

	public override bool BattleSpeedToggleEnabled
	{
		[Address(RVA="0x143C7AC", Offset="0x143C7AC", VA="0x143C7AC", Slot="14")]
		get
		{
			return new bool();
		}
	}

	public override bool ShowCardsImmediately
	{
		[Address(RVA="0x143C7B4", Offset="0x143C7B4", VA="0x143C7B4", Slot="18")]
		get
		{
			return new bool();
		}
	}

	public override bool ShowEnvironmentImmediately
	{
		[Address(RVA="0x143C7C4", Offset="0x143C7C4", VA="0x143C7C4", Slot="22")]
		get
		{
			return new bool();
		}
	}

	public override bool ShowRounds
	{
		[Address(RVA="0x143C79C", Offset="0x143C79C", VA="0x143C79C", Slot="12")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x143CAD8", Offset="0x143CAD8", VA="0x143CAD8")]
	public TutorialBattleGameState()
	{
	}

	[Address(RVA="0x143CA88", Offset="0x143CA88", VA="0x143CA88", Slot="5")]
	public override void Exiting()
	{
	}

	[Address(RVA="0x143C7CC", Offset="0x143C7CC", VA="0x143C7CC", Slot="27")]
	protected override void Install(DiContainer container, ITransitionContext context, Action finished)
	{
	}

	[Address(RVA="0x143CABC", Offset="0x143CABC", VA="0x143CABC", Slot="11")]
	public override void TickUpdate()
	{
	}

	public class TransitionContext : ABattleGameState.ATransitionContext
	{
		[FieldOffset(Offset="0x30")]
		public PveBattleStartResponse StartBattleResponse;

		[FieldOffset(Offset="0x38")]
		public CampaignIdentifier CampaignIdentifier;

		[Address(RVA="0x143CAE0", Offset="0x143CAE0", VA="0x143CAE0")]
		public TransitionContext()
		{
		}
	}
}