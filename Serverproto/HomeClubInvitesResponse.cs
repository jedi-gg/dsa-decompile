using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeClubInvitesResponse : IMessage<HomeClubInvitesResponse>, IMessage, IEquatable<HomeClubInvitesResponse>, IDeepCloneable<HomeClubInvitesResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeClubInvitesResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InvitesFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ClubInvite> _repeated_invites_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ClubInvite> invites_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097CD8", Offset="0x1097CD8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1D01070", Offset="0x1D01070", VA="0x1D01070")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097CF8", Offset="0x1097CF8")]
		public RepeatedField<ClubInvite> Invites
		{
			[Address(RVA="0x1D01320", Offset="0x1D01320", VA="0x1D01320")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097CC8", Offset="0x1097CC8")]
		public static MessageParser<HomeClubInvitesResponse> Parser
		{
			[Address(RVA="0x1D01008", Offset="0x1D01008", VA="0x1D01008")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097CE8", Offset="0x1097CE8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1D0115C", Offset="0x1D0115C", VA="0x1D0115C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1D01808", Offset="0x1D01808", VA="0x1D01808")]
		static HomeClubInvitesResponse()
		{
		}

		[Address(RVA="0x1D011B8", Offset="0x1D011B8", VA="0x1D011B8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108087C", Offset="0x108087C")]
		public HomeClubInvitesResponse()
		{
		}

		[Address(RVA="0x1D01228", Offset="0x1D01228", VA="0x1D01228")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108088C", Offset="0x108088C")]
		public HomeClubInvitesResponse(HomeClubInvitesResponse other)
		{
		}

		[Address(RVA="0x1D015D8", Offset="0x1D015D8", VA="0x1D015D8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10808FC", Offset="0x10808FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1D012C0", Offset="0x1D012C0", VA="0x1D012C0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108089C", Offset="0x108089C")]
		public HomeClubInvitesResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1D01328", Offset="0x1D01328", VA="0x1D01328", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10808AC", Offset="0x10808AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1D0139C", Offset="0x1D0139C", VA="0x1D0139C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10808BC", Offset="0x10808BC")]
		public bool Equals(HomeClubInvitesResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1D0144C", Offset="0x1D0144C", VA="0x1D0144C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10808CC", Offset="0x10808CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D01694", Offset="0x1D01694", VA="0x1D01694", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108090C", Offset="0x108090C")]
		public void MergeFrom(HomeClubInvitesResponse other)
		{
		}

		[Address(RVA="0x1D01724", Offset="0x1D01724", VA="0x1D01724", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108091C", Offset="0x108091C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D014AC", Offset="0x1D014AC", VA="0x1D014AC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10808DC", Offset="0x10808DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D01514", Offset="0x1D01514", VA="0x1D01514", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10808EC", Offset="0x10808EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FF58", Offset="0x104FF58")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeClubInvitesResponse.<>c <>9;

			[Address(RVA="0x1D0192C", Offset="0x1D0192C", VA="0x1D0192C")]
			static <>c()
			{
			}

			[Address(RVA="0x1D01990", Offset="0x1D01990", VA="0x1D01990")]
			public <>c()
			{
			}

			[Address(RVA="0x1D01998", Offset="0x1D01998", VA="0x1D01998")]
			internal HomeClubInvitesResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}