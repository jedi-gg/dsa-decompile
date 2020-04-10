using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	public class TurnBasedMatch
	{
		[FieldOffset(Offset="0x10")]
		private string mMatchId;

		[FieldOffset(Offset="0x18")]
		private byte[] mData;

		[FieldOffset(Offset="0x20")]
		private bool mCanRematch;

		[FieldOffset(Offset="0x24")]
		private uint mAvailableAutomatchSlots;

		[FieldOffset(Offset="0x28")]
		private string mSelfParticipantId;

		[FieldOffset(Offset="0x30")]
		private List<Participant> mParticipants;

		[FieldOffset(Offset="0x38")]
		private string mPendingParticipantId;

		[FieldOffset(Offset="0x40")]
		private TurnBasedMatch.MatchTurnStatus mTurnStatus;

		[FieldOffset(Offset="0x44")]
		private TurnBasedMatch.MatchStatus mMatchStatus;

		[FieldOffset(Offset="0x48")]
		private uint mVariant;

		[FieldOffset(Offset="0x4C")]
		private uint mVersion;

		[FieldOffset(Offset="0x50")]
		private DateTime mCreationTime;

		[FieldOffset(Offset="0x58")]
		private DateTime mLastUpdateTime;

		public uint AvailableAutomatchSlots
		{
			[Address(RVA="0x1EC5688", Offset="0x1EC5688", VA="0x1EC5688")]
			get
			{
				return new uint();
			}
		}

		public bool CanRematch
		{
			[Address(RVA="0x1EC5634", Offset="0x1EC5634", VA="0x1EC5634")]
			get
			{
				return new bool();
			}
		}

		public DateTime CreationTime
		{
			[Address(RVA="0x1EC561C", Offset="0x1EC561C", VA="0x1EC561C")]
			get
			{
				return new DateTime();
			}
		}

		public byte[] Data
		{
			[Address(RVA="0x1EC562C", Offset="0x1EC562C", VA="0x1EC562C")]
			get
			{
				return null;
			}
		}

		public DateTime LastUpdateTime
		{
			[Address(RVA="0x1EC5624", Offset="0x1EC5624", VA="0x1EC5624")]
			get
			{
				return new DateTime();
			}
		}

		public string MatchId
		{
			[Address(RVA="0x1EB9D34", Offset="0x1EB9D34", VA="0x1EB9D34")]
			get
			{
				return null;
			}
		}

		public List<Participant> Participants
		{
			[Address(RVA="0x1EC564C", Offset="0x1EC564C", VA="0x1EC564C")]
			get
			{
				return null;
			}
		}

		public Participant PendingParticipant
		{
			[Address(RVA="0x1EC565C", Offset="0x1EC565C", VA="0x1EC565C")]
			get
			{
				return null;
			}
		}

		public string PendingParticipantId
		{
			[Address(RVA="0x1EC5654", Offset="0x1EC5654", VA="0x1EC5654")]
			get
			{
				return null;
			}
		}

		public Participant Self
		{
			[Address(RVA="0x1EC5644", Offset="0x1EC5644", VA="0x1EC5644")]
			get
			{
				return null;
			}
		}

		public string SelfParticipantId
		{
			[Address(RVA="0x1EC563C", Offset="0x1EC563C", VA="0x1EC563C")]
			get
			{
				return null;
			}
		}

		public TurnBasedMatch.MatchStatus Status
		{
			[Address(RVA="0x1EC5678", Offset="0x1EC5678", VA="0x1EC5678")]
			get
			{
				return new TurnBasedMatch.MatchStatus();
			}
		}

		public TurnBasedMatch.MatchTurnStatus TurnStatus
		{
			[Address(RVA="0x1EC5670", Offset="0x1EC5670", VA="0x1EC5670")]
			get
			{
				return new TurnBasedMatch.MatchTurnStatus();
			}
		}

		public uint Variant
		{
			[Address(RVA="0x1EC5680", Offset="0x1EC5680", VA="0x1EC5680")]
			get
			{
				return new uint();
			}
		}

		public uint Version
		{
			[Address(RVA="0x1EBF638", Offset="0x1EBF638", VA="0x1EBF638")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0x1EC5514", Offset="0x1EC5514", VA="0x1EC5514")]
		internal TurnBasedMatch(string matchId, byte[] data, bool canRematch, string selfParticipantId, List<Participant> participants, uint availableAutomatchSlots, string pendingParticipantId, TurnBasedMatch.MatchTurnStatus turnStatus, TurnBasedMatch.MatchStatus matchStatus, uint variant, uint version, DateTime creationTime, DateTime lastUpdateTime)
		{
		}

		[Address(RVA="0x1EBF7C0", Offset="0x1EBF7C0", VA="0x1EBF7C0")]
		public Participant GetParticipant(string participantId)
		{
			return null;
		}

		[Address(RVA="0x1EC5690", Offset="0x1EC5690", VA="0x1EC5690", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104ED58", Offset="0x104ED58")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TurnBasedMatch.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<Participant, string> <>9__47_0;

			[Address(RVA="0x1EC5C44", Offset="0x1EC5C44", VA="0x1EC5C44")]
			static <>c()
			{
			}

			[Address(RVA="0x1EC5CA8", Offset="0x1EC5CA8", VA="0x1EC5CA8")]
			public <>c()
			{
			}

			[Address(RVA="0x1EC5CB0", Offset="0x1EC5CB0", VA="0x1EC5CB0")]
			internal string <ToString>b__47_0(Participant p)
			{
				return null;
			}
		}

		public enum MatchStatus
		{
			[FieldOffset(Offset="0x0")]
			Active,
			[FieldOffset(Offset="0x0")]
			AutoMatching,
			[FieldOffset(Offset="0x0")]
			Cancelled,
			[FieldOffset(Offset="0x0")]
			Complete,
			[FieldOffset(Offset="0x0")]
			Expired,
			[FieldOffset(Offset="0x0")]
			Unknown,
			[FieldOffset(Offset="0x0")]
			Deleted
		}

		public enum MatchTurnStatus
		{
			[FieldOffset(Offset="0x0")]
			Complete,
			[FieldOffset(Offset="0x0")]
			Invited,
			[FieldOffset(Offset="0x0")]
			MyTurn,
			[FieldOffset(Offset="0x0")]
			TheirTurn,
			[FieldOffset(Offset="0x0")]
			Unknown
		}
	}
}