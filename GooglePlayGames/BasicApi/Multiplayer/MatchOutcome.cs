using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	public class MatchOutcome
	{
		[FieldOffset(Offset="0x0")]
		public const uint PlacementUnset = 0;

		[FieldOffset(Offset="0x10")]
		private List<string> mParticipantIds;

		[FieldOffset(Offset="0x18")]
		private Dictionary<string, uint> mPlacements;

		[FieldOffset(Offset="0x20")]
		private Dictionary<string, MatchOutcome.ParticipantResult> mResults;

		public List<string> ParticipantIds
		{
			[Address(RVA="0x1EBD864", Offset="0x1EBD864", VA="0x1EBD864")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EC4CBC", Offset="0x1EC4CBC", VA="0x1EC4CBC")]
		public MatchOutcome()
		{
		}

		[Address(RVA="0x1EBD91C", Offset="0x1EBD91C", VA="0x1EBD91C")]
		public uint GetPlacementFor(string participantId)
		{
			return new uint();
		}

		[Address(RVA="0x1EBD86C", Offset="0x1EBD86C", VA="0x1EBD86C")]
		public MatchOutcome.ParticipantResult GetResultFor(string participantId)
		{
			return new MatchOutcome.ParticipantResult();
		}

		[Address(RVA="0x1EC4D7C", Offset="0x1EC4D7C", VA="0x1EC4D7C")]
		public void SetParticipantResult(string participantId, MatchOutcome.ParticipantResult result, uint placement)
		{
		}

		[Address(RVA="0x1EC4E80", Offset="0x1EC4E80", VA="0x1EC4E80")]
		public void SetParticipantResult(string participantId, MatchOutcome.ParticipantResult result)
		{
		}

		[Address(RVA="0x1EC4E88", Offset="0x1EC4E88", VA="0x1EC4E88")]
		public void SetParticipantResult(string participantId, uint placement)
		{
		}

		[Address(RVA="0x1EC4E98", Offset="0x1EC4E98", VA="0x1EC4E98", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		public enum ParticipantResult
		{
			[FieldOffset(Offset="0x0")]
			Unset = -1,
			[FieldOffset(Offset="0x0")]
			None = 0,
			[FieldOffset(Offset="0x0")]
			Win = 1,
			[FieldOffset(Offset="0x0")]
			Loss = 2,
			[FieldOffset(Offset="0x0")]
			Tie = 3
		}
	}
}