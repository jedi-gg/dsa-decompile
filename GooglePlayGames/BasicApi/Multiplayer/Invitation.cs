using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	public class Invitation
	{
		[FieldOffset(Offset="0x10")]
		private Invitation.InvType mInvitationType;

		[FieldOffset(Offset="0x18")]
		private string mInvitationId;

		[FieldOffset(Offset="0x20")]
		private Participant mInviter;

		[FieldOffset(Offset="0x28")]
		private int mVariant;

		[FieldOffset(Offset="0x30")]
		private DateTime mCreationTime;

		public DateTime CreationTime
		{
			[Address(RVA="0x1EC4998", Offset="0x1EC4998", VA="0x1EC4998")]
			get
			{
				return new DateTime();
			}
		}

		public string InvitationId
		{
			[Address(RVA="0x1EAC920", Offset="0x1EAC920", VA="0x1EAC920")]
			get
			{
				return null;
			}
		}

		public Invitation.InvType InvitationType
		{
			[Address(RVA="0x1EC4980", Offset="0x1EC4980", VA="0x1EC4980")]
			get
			{
				return new Invitation.InvType();
			}
		}

		public Participant Inviter
		{
			[Address(RVA="0x1EC4988", Offset="0x1EC4988", VA="0x1EC4988")]
			get
			{
				return null;
			}
		}

		public int Variant
		{
			[Address(RVA="0x1EC4990", Offset="0x1EC4990", VA="0x1EC4990")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x1EC4928", Offset="0x1EC4928", VA="0x1EC4928")]
		internal Invitation(Invitation.InvType invType, string invId, Participant inviter, int variant, DateTime creationTime)
		{
		}

		[Address(RVA="0x1EC49A0", Offset="0x1EC49A0", VA="0x1EC49A0", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		public enum InvType
		{
			[FieldOffset(Offset="0x0")]
			RealTime,
			[FieldOffset(Offset="0x0")]
			TurnBased,
			[FieldOffset(Offset="0x0")]
			Unknown
		}
	}
}