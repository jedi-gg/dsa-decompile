using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ApproveClubInviteResponse : IMessage<ApproveClubInviteResponse>, IMessage, IEquatable<ApproveClubInviteResponse>, IDeepCloneable<ApproveClubInviteResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ApproveClubInviteResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ClubFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.Club club_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095000", Offset="0x1095000")]
		public Serverproto.Club Club
		{
			[Address(RVA="0x160C074", Offset="0x160C074", VA="0x160C074")]
			get
			{
				return null;
			}
			[Address(RVA="0x160C07C", Offset="0x160C07C", VA="0x160C07C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094FE0", Offset="0x1094FE0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x160BEA4", Offset="0x160BEA4", VA="0x160BEA4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094FD0", Offset="0x1094FD0")]
		public static MessageParser<ApproveClubInviteResponse> Parser
		{
			[Address(RVA="0x160BE3C", Offset="0x160BE3C", VA="0x160BE3C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094FF0", Offset="0x1094FF0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x160BF94", Offset="0x160BF94", VA="0x160BF94", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x160C53C", Offset="0x160C53C", VA="0x160C53C")]
		static ApproveClubInviteResponse()
		{
		}

		[Address(RVA="0x160BFF0", Offset="0x160BFF0", VA="0x160BFF0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B5FC", Offset="0x107B5FC")]
		public ApproveClubInviteResponse()
		{
		}

		[Address(RVA="0x160BFF8", Offset="0x160BFF8", VA="0x160BFF8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B60C", Offset="0x107B60C")]
		public ApproveClubInviteResponse(ApproveClubInviteResponse other)
		{
		}

		[Address(RVA="0x160C31C", Offset="0x160C31C", VA="0x160C31C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B67C", Offset="0x107B67C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x160C084", Offset="0x160C084", VA="0x160C084", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B61C", Offset="0x107B61C")]
		public ApproveClubInviteResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x160C0E4", Offset="0x160C0E4", VA="0x160C0E4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B62C", Offset="0x107B62C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x160C158", Offset="0x160C158", VA="0x160C158", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B63C", Offset="0x107B63C")]
		public bool Equals(ApproveClubInviteResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x160C1BC", Offset="0x160C1BC", VA="0x160C1BC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B64C", Offset="0x107B64C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x160C3AC", Offset="0x160C3AC", VA="0x160C3AC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B68C", Offset="0x107B68C")]
		public void MergeFrom(ApproveClubInviteResponse other)
		{
		}

		[Address(RVA="0x160C460", Offset="0x160C460", VA="0x160C460", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B69C", Offset="0x107B69C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x160C214", Offset="0x160C214", VA="0x160C214", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B65C", Offset="0x107B65C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x160C27C", Offset="0x160C27C", VA="0x160C27C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B66C", Offset="0x107B66C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F7C8", Offset="0x104F7C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ApproveClubInviteResponse.<>c <>9;

			[Address(RVA="0x160C614", Offset="0x160C614", VA="0x160C614")]
			static <>c()
			{
			}

			[Address(RVA="0x160C678", Offset="0x160C678", VA="0x160C678")]
			public <>c()
			{
			}

			[Address(RVA="0x160C680", Offset="0x160C680", VA="0x160C680")]
			internal ApproveClubInviteResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}