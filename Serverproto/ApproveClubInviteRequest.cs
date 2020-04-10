using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ApproveClubInviteRequest : IMessage<ApproveClubInviteRequest>, IMessage, IEquatable<ApproveClubInviteRequest>, IDeepCloneable<ApproveClubInviteRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ApproveClubInviteRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ClubIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string clubId_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string playerId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094FB0", Offset="0x1094FB0")]
		public string ClubId
		{
			[Address(RVA="0x160B604", Offset="0x160B604", VA="0x160B604")]
			get
			{
				return null;
			}
			[Address(RVA="0x160B60C", Offset="0x160B60C", VA="0x160B60C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094F90", Offset="0x1094F90")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x160B384", Offset="0x160B384", VA="0x160B384")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094F80", Offset="0x1094F80")]
		public static MessageParser<ApproveClubInviteRequest> Parser
		{
			[Address(RVA="0x160B31C", Offset="0x160B31C", VA="0x160B31C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094FA0", Offset="0x1094FA0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x160B474", Offset="0x160B474", VA="0x160B474", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094FC0", Offset="0x1094FC0")]
		public string PlayerId
		{
			[Address(RVA="0x160B67C", Offset="0x160B67C", VA="0x160B67C")]
			get
			{
				return null;
			}
			[Address(RVA="0x160B684", Offset="0x160B684", VA="0x160B684")]
			set
			{
			}
		}

		[Address(RVA="0x160BCA0", Offset="0x160BCA0", VA="0x160BCA0")]
		static ApproveClubInviteRequest()
		{
		}

		[Address(RVA="0x160B4D0", Offset="0x160B4D0", VA="0x160B4D0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B54C", Offset="0x107B54C")]
		public ApproveClubInviteRequest()
		{
		}

		[Address(RVA="0x160B528", Offset="0x160B528", VA="0x160B528")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B55C", Offset="0x107B55C")]
		public ApproveClubInviteRequest(ApproveClubInviteRequest other)
		{
		}

		[Address(RVA="0x160BA40", Offset="0x160BA40", VA="0x160BA40", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B5CC", Offset="0x107B5CC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x160B5A4", Offset="0x160B5A4", VA="0x160B5A4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B56C", Offset="0x107B56C")]
		public ApproveClubInviteRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x160B6F4", Offset="0x160B6F4", VA="0x160B6F4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B57C", Offset="0x107B57C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x160B768", Offset="0x160B768", VA="0x160B768", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B58C", Offset="0x107B58C")]
		public bool Equals(ApproveClubInviteRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x160B7E0", Offset="0x160B7E0", VA="0x160B7E0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B59C", Offset="0x107B59C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x160BB54", Offset="0x160BB54", VA="0x160BB54", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B5DC", Offset="0x107B5DC")]
		public void MergeFrom(ApproveClubInviteRequest other)
		{
		}

		[Address(RVA="0x160BBEC", Offset="0x160BBEC", VA="0x160BBEC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B5EC", Offset="0x107B5EC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x160B8B0", Offset="0x160B8B0", VA="0x160B8B0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B5AC", Offset="0x107B5AC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x160B918", Offset="0x160B918", VA="0x160B918", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B5BC", Offset="0x107B5BC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F7B8", Offset="0x104F7B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ApproveClubInviteRequest.<>c <>9;

			[Address(RVA="0x160BD78", Offset="0x160BD78", VA="0x160BD78")]
			static <>c()
			{
			}

			[Address(RVA="0x160BDDC", Offset="0x160BDDC", VA="0x160BDDC")]
			public <>c()
			{
			}

			[Address(RVA="0x160BDE4", Offset="0x160BDE4", VA="0x160BDE4")]
			internal ApproveClubInviteRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}