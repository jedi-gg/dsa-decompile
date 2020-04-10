using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PromoteClubMemberRequest : IMessage<PromoteClubMemberRequest>, IMessage, IEquatable<PromoteClubMemberRequest>, IDeepCloneable<PromoteClubMemberRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PromoteClubMemberRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string playerId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10950A0", Offset="0x10950A0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B127E0", Offset="0x1B127E0", VA="0x1B127E0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095090", Offset="0x1095090")]
		public static MessageParser<PromoteClubMemberRequest> Parser
		{
			[Address(RVA="0x1B12778", Offset="0x1B12778", VA="0x1B12778")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10950B0", Offset="0x10950B0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B128D0", Offset="0x1B128D0", VA="0x1B128D0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10950C0", Offset="0x10950C0")]
		public string PlayerId
		{
			[Address(RVA="0x1B12A44", Offset="0x1B12A44", VA="0x1B12A44")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B12A4C", Offset="0x1B12A4C", VA="0x1B12A4C")]
			set
			{
			}
		}

		[Address(RVA="0x1B12EDC", Offset="0x1B12EDC", VA="0x1B12EDC")]
		static PromoteClubMemberRequest()
		{
		}

		[Address(RVA="0x1B1292C", Offset="0x1B1292C", VA="0x1B1292C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B80C", Offset="0x107B80C")]
		public PromoteClubMemberRequest()
		{
		}

		[Address(RVA="0x1B12984", Offset="0x1B12984", VA="0x1B12984")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B81C", Offset="0x107B81C")]
		public PromoteClubMemberRequest(PromoteClubMemberRequest other)
		{
		}

		[Address(RVA="0x1B12D38", Offset="0x1B12D38", VA="0x1B12D38", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B88C", Offset="0x107B88C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B129E4", Offset="0x1B129E4", VA="0x1B129E4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B82C", Offset="0x107B82C")]
		public PromoteClubMemberRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B12ABC", Offset="0x1B12ABC", VA="0x1B12ABC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B83C", Offset="0x107B83C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B12B30", Offset="0x1B12B30", VA="0x1B12B30", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B84C", Offset="0x107B84C")]
		public bool Equals(PromoteClubMemberRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B12B94", Offset="0x1B12B94", VA="0x1B12B94", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B85C", Offset="0x107B85C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B12DEC", Offset="0x1B12DEC", VA="0x1B12DEC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B89C", Offset="0x107B89C")]
		public void MergeFrom(PromoteClubMemberRequest other)
		{
		}

		[Address(RVA="0x1B12E58", Offset="0x1B12E58", VA="0x1B12E58", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B8AC", Offset="0x107B8AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B12C18", Offset="0x1B12C18", VA="0x1B12C18", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B86C", Offset="0x107B86C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B12C80", Offset="0x1B12C80", VA="0x1B12C80", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B87C", Offset="0x107B87C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F7F8", Offset="0x104F7F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PromoteClubMemberRequest.<>c <>9;

			[Address(RVA="0x1B12FB4", Offset="0x1B12FB4", VA="0x1B12FB4")]
			static <>c()
			{
			}

			[Address(RVA="0x1B13018", Offset="0x1B13018", VA="0x1B13018")]
			public <>c()
			{
			}

			[Address(RVA="0x1B13020", Offset="0x1B13020", VA="0x1B13020")]
			internal PromoteClubMemberRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}