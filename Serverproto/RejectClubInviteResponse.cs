using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RejectClubInviteResponse : IMessage<RejectClubInviteResponse>, IMessage, IEquatable<RejectClubInviteResponse>, IDeepCloneable<RejectClubInviteResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RejectClubInviteResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095070", Offset="0x1095070")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x20240F4", Offset="0x20240F4", VA="0x20240F4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095060", Offset="0x1095060")]
		public static MessageParser<RejectClubInviteResponse> Parser
		{
			[Address(RVA="0x202408C", Offset="0x202408C", VA="0x202408C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095080", Offset="0x1095080")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x20241E4", Offset="0x20241E4", VA="0x20241E4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x20244F8", Offset="0x20244F8", VA="0x20244F8")]
		static RejectClubInviteResponse()
		{
		}

		[Address(RVA="0x2024240", Offset="0x2024240", VA="0x2024240")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B75C", Offset="0x107B75C")]
		public RejectClubInviteResponse()
		{
		}

		[Address(RVA="0x2024248", Offset="0x2024248", VA="0x2024248")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B76C", Offset="0x107B76C")]
		public RejectClubInviteResponse(RejectClubInviteResponse other)
		{
		}

		[Address(RVA="0x202445C", Offset="0x202445C", VA="0x202445C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B7DC", Offset="0x107B7DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x202428C", Offset="0x202428C", VA="0x202428C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B77C", Offset="0x107B77C")]
		public RejectClubInviteResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x20242EC", Offset="0x20242EC", VA="0x20242EC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B78C", Offset="0x107B78C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x2024384", Offset="0x2024384", VA="0x2024384", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B79C", Offset="0x107B79C")]
		public bool Equals(RejectClubInviteResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x20243B0", Offset="0x20243B0", VA="0x20243B0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B7AC", Offset="0x107B7AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2024470", Offset="0x2024470", VA="0x2024470", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B7EC", Offset="0x107B7EC")]
		public void MergeFrom(RejectClubInviteResponse other)
		{
		}

		[Address(RVA="0x20244A4", Offset="0x20244A4", VA="0x20244A4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B7FC", Offset="0x107B7FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x20243E0", Offset="0x20243E0", VA="0x20243E0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B7BC", Offset="0x107B7BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x2024448", Offset="0x2024448", VA="0x2024448", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B7CC", Offset="0x107B7CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F7E8", Offset="0x104F7E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RejectClubInviteResponse.<>c <>9;

			[Address(RVA="0x20245D0", Offset="0x20245D0", VA="0x20245D0")]
			static <>c()
			{
			}

			[Address(RVA="0x2024634", Offset="0x2024634", VA="0x2024634")]
			public <>c()
			{
			}

			[Address(RVA="0x202463C", Offset="0x202463C", VA="0x202463C")]
			internal RejectClubInviteResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}