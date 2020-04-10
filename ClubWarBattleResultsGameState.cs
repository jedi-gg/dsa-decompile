using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ClubWarBattleResultsGameState : AGameState
{
	public override bool CanBeNavigatedBackInto
	{
		[Address(RVA="0x126A098", Offset="0x126A098", VA="0x126A098", Slot="8")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x126A100", Offset="0x126A100", VA="0x126A100")]
	public ClubWarBattleResultsGameState()
	{
	}

	[Address(RVA="0x126A0A0", Offset="0x126A0A0", VA="0x126A0A0", Slot="4")]
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
		public readonly string AlertText;

		[FieldOffset(Offset="0x30")]
		public readonly bool ContinueToWar;

		[FieldOffset(Offset="0x38")]
		public readonly ClubWarClubScoreDelta AttackerScoreDelta;

		[FieldOffset(Offset="0x40")]
		public readonly ClubWarClubScoreDelta DefenderScoreDelta;

		[Address(RVA="0x1269120", Offset="0x1269120", VA="0x1269120")]
		public TransitionContext(bool victory, BattleLib_UpdateResult.Types.BattleEnded.Types.Reason reason, ClubWarClubScoreDelta attackerScoreDelta, ClubWarClubScoreDelta defenderScoreDelta)
		{
		}

		[Address(RVA="0x12694A8", Offset="0x12694A8", VA="0x12694A8")]
		public TransitionContext(bool victory, BattleLib_UpdateResult.Types.BattleEnded.Types.Reason reason, string alertText, bool navigateBackToWar)
		{
		}
	}
}