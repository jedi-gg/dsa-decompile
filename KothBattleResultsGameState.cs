using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class KothBattleResultsGameState : AGameState
{
	public override bool CanBeNavigatedBackInto
	{
		[Address(RVA="0x11CB558", Offset="0x11CB558", VA="0x11CB558", Slot="8")]
		get
		{
			return new bool();
		}
	}

	public override bool ShowGlobalBackdrop
	{
		[Address(RVA="0x11CB560", Offset="0x11CB560", VA="0x11CB560", Slot="10")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11CB5C8", Offset="0x11CB5C8", VA="0x11CB5C8")]
	public KothBattleResultsGameState()
	{
	}

	[Address(RVA="0x11CB568", Offset="0x11CB568", VA="0x11CB568", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class TransitionContext : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x1C")]
		public readonly bool Victory;

		[FieldOffset(Offset="0x20")]
		public readonly BattleLib_UpdateResult.Types.BattleEnded.Types.Reason Reason;

		[FieldOffset(Offset="0x28")]
		public readonly ulong NewKothRank;

		[FieldOffset(Offset="0x30")]
		public readonly ulong RankDelta;

		[Address(RVA="0x11C8708", Offset="0x11C8708", VA="0x11C8708")]
		public TransitionContext(bool victory, BattleLib_UpdateResult.Types.BattleEnded.Types.Reason reason, ulong newKothRank, ulong rankDelta)
		{
		}
	}
}