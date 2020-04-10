using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	public class Participant : IComparable<Participant>
	{
		[FieldOffset(Offset="0x10")]
		private string mDisplayName;

		[FieldOffset(Offset="0x18")]
		private readonly string mParticipantId;

		[FieldOffset(Offset="0x20")]
		private Participant.ParticipantStatus mStatus;

		[FieldOffset(Offset="0x28")]
		private GooglePlayGames.BasicApi.Multiplayer.Player mPlayer;

		[FieldOffset(Offset="0x30")]
		private bool mIsConnectedToRoom;

		public string DisplayName
		{
			[Address(RVA="0x1EC5080", Offset="0x1EC5080", VA="0x1EC5080")]
			get
			{
				return null;
			}
		}

		public bool IsAutomatch
		{
			[Address(RVA="0x1EC5098", Offset="0x1EC5098", VA="0x1EC5098")]
			get
			{
				return new bool();
			}
		}

		public bool IsConnectedToRoom
		{
			[Address(RVA="0x1EC5090", Offset="0x1EC5090", VA="0x1EC5090")]
			get
			{
				return new bool();
			}
		}

		public string ParticipantId
		{
			[Address(RVA="0x1EAF854", Offset="0x1EAF854", VA="0x1EAF854")]
			get
			{
				return null;
			}
		}

		public GooglePlayGames.BasicApi.Multiplayer.Player Player
		{
			[Address(RVA="0x1EC5088", Offset="0x1EC5088", VA="0x1EC5088")]
			get
			{
				return null;
			}
		}

		public Participant.ParticipantStatus Status
		{
			[Address(RVA="0x1EAEF48", Offset="0x1EAEF48", VA="0x1EAEF48")]
			get
			{
				return new Participant.ParticipantStatus();
			}
		}

		[Address(RVA="0x1EBA774", Offset="0x1EBA774", VA="0x1EBA774")]
		internal Participant(string displayName, string participantId, Participant.ParticipantStatus status, GooglePlayGames.BasicApi.Multiplayer.Player player, bool connectedToRoom)
		{
		}

		[Address(RVA="0x1EC5348", Offset="0x1EC5348", VA="0x1EC5348", Slot="4")]
		public int CompareTo(Participant other)
		{
			return new int();
		}

		[Address(RVA="0x1EC5384", Offset="0x1EC5384", VA="0x1EC5384", Slot="0")]
		public override bool Equals(object obj)
		{
			return new bool();
		}

		[Address(RVA="0x1EC54FC", Offset="0x1EC54FC", VA="0x1EC54FC", Slot="2")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EC50A8", Offset="0x1EC50A8", VA="0x1EC50A8", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		public enum ParticipantStatus
		{
			[FieldOffset(Offset="0x0")]
			NotInvitedYet,
			[FieldOffset(Offset="0x0")]
			Invited,
			[FieldOffset(Offset="0x0")]
			Joined,
			[FieldOffset(Offset="0x0")]
			Declined,
			[FieldOffset(Offset="0x0")]
			Left,
			[FieldOffset(Offset="0x0")]
			Finished,
			[FieldOffset(Offset="0x0")]
			Unresponsive,
			[FieldOffset(Offset="0x0")]
			Unknown
		}
	}
}