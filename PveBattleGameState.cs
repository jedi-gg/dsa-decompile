using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using Zenject;

public class PveBattleGameState : ABattleGameState
{
	[Attribute(Name="InjectAttribute", RVA="0x10544B0", Offset="0x10544B0")]
	[FieldOffset(Offset="0x70")]
	private DispatchSystem _dispatchSystem;

	public override bool AllowPause
	{
		[Address(RVA="0x1281224", Offset="0x1281224", VA="0x1281224", Slot="21")]
		get
		{
			return new bool();
		}
	}

	public override bool AllowQuit
	{
		[Address(RVA="0x128121C", Offset="0x128121C", VA="0x128121C", Slot="20")]
		get
		{
			return new bool();
		}
	}

	public override bool AutoBattleEnabled
	{
		[Address(RVA="0x12811C4", Offset="0x12811C4", VA="0x12811C4", Slot="13")]
		get
		{
			return new bool();
		}
	}

	public override string AutoBattleSpeedPlayerPrefKey
	{
		[Address(RVA="0x12811D4", Offset="0x12811D4", VA="0x12811D4", Slot="17")]
		get
		{
			return null;
		}
	}

	public override bool BattleSpeedToggleEnabled
	{
		[Address(RVA="0x12811CC", Offset="0x12811CC", VA="0x12811CC", Slot="14")]
		get
		{
			return new bool();
		}
	}

	public override bool ShowRounds
	{
		[Address(RVA="0x12811BC", Offset="0x12811BC", VA="0x12811BC", Slot="12")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x12814E0", Offset="0x12814E0", VA="0x12814E0")]
	public PveBattleGameState()
	{
	}

	[Address(RVA="0x128122C", Offset="0x128122C", VA="0x128122C", Slot="27")]
	protected override void Install(DiContainer container, ITransitionContext context, Action finished)
	{
	}

	public class TransitionContext : ABattleGameState.ATransitionContext
	{
		[FieldOffset(Offset="0x30")]
		public PveBattleStartResponse StartBattleResponse;

		[FieldOffset(Offset="0x38")]
		public CampaignIdentifier CampaignIdentifier;

		[FieldOffset(Offset="0x40")]
		public BattleSquadSaveInfo SquadInfo;

		[Address(RVA="0x12814E8", Offset="0x12814E8", VA="0x12814E8")]
		public TransitionContext()
		{
		}
	}
}