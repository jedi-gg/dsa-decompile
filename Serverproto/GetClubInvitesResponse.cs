using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GetClubInvitesResponse : IMessage<GetClubInvitesResponse>, IMessage, IEquatable<GetClubInvitesResponse>, IDeepCloneable<GetClubInvitesResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GetClubInvitesResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InvitesFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ClubInvite> _repeated_invites_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ClubInvite> invites_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095370", Offset="0x1095370")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA7240", Offset="0x1BA7240", VA="0x1BA7240")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095390", Offset="0x1095390")]
		public RepeatedField<ClubInvite> Invites
		{
			[Address(RVA="0x1BA74F4", Offset="0x1BA74F4", VA="0x1BA74F4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095360", Offset="0x1095360")]
		public static MessageParser<GetClubInvitesResponse> Parser
		{
			[Address(RVA="0x1BA71D8", Offset="0x1BA71D8", VA="0x1BA71D8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095380", Offset="0x1095380")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA7330", Offset="0x1BA7330", VA="0x1BA7330", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BA79DC", Offset="0x1BA79DC", VA="0x1BA79DC")]
		static GetClubInvitesResponse()
		{
		}

		[Address(RVA="0x1BA738C", Offset="0x1BA738C", VA="0x1BA738C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BF9C", Offset="0x107BF9C")]
		public GetClubInvitesResponse()
		{
		}

		[Address(RVA="0x1BA73FC", Offset="0x1BA73FC", VA="0x1BA73FC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BFAC", Offset="0x107BFAC")]
		public GetClubInvitesResponse(GetClubInvitesResponse other)
		{
		}

		[Address(RVA="0x1BA77AC", Offset="0x1BA77AC", VA="0x1BA77AC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C01C", Offset="0x107C01C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA7494", Offset="0x1BA7494", VA="0x1BA7494", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BFBC", Offset="0x107BFBC")]
		public GetClubInvitesResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA74FC", Offset="0x1BA74FC", VA="0x1BA74FC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BFCC", Offset="0x107BFCC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA7570", Offset="0x1BA7570", VA="0x1BA7570", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BFDC", Offset="0x107BFDC")]
		public bool Equals(GetClubInvitesResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA7620", Offset="0x1BA7620", VA="0x1BA7620", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BFEC", Offset="0x107BFEC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA7868", Offset="0x1BA7868", VA="0x1BA7868", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C02C", Offset="0x107C02C")]
		public void MergeFrom(GetClubInvitesResponse other)
		{
		}

		[Address(RVA="0x1BA78F8", Offset="0x1BA78F8", VA="0x1BA78F8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C03C", Offset="0x107C03C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA7680", Offset="0x1BA7680", VA="0x1BA7680", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BFFC", Offset="0x107BFFC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA76E8", Offset="0x1BA76E8", VA="0x1BA76E8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C00C", Offset="0x107C00C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F8A8", Offset="0x104F8A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GetClubInvitesResponse.<>c <>9;

			[Address(RVA="0x1BA7B00", Offset="0x1BA7B00", VA="0x1BA7B00")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA7B64", Offset="0x1BA7B64", VA="0x1BA7B64")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA7B6C", Offset="0x1BA7B6C", VA="0x1BA7B6C")]
			internal GetClubInvitesResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}