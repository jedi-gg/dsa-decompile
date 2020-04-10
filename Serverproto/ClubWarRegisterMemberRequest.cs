using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarRegisterMemberRequest : IMessage<ClubWarRegisterMemberRequest>, IMessage, IEquatable<ClubWarRegisterMemberRequest>, IDeepCloneable<ClubWarRegisterMemberRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarRegisterMemberRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int AutoRegisterFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private bool autoRegister_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095ED0", Offset="0x1095ED0")]
		public bool AutoRegister
		{
			[Address(RVA="0x1B29124", Offset="0x1B29124", VA="0x1B29124")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1B2912C", Offset="0x1B2912C", VA="0x1B2912C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095EB0", Offset="0x1095EB0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B28F0C", Offset="0x1B28F0C", VA="0x1B28F0C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095EA0", Offset="0x1095EA0")]
		public static MessageParser<ClubWarRegisterMemberRequest> Parser
		{
			[Address(RVA="0x1B28EA4", Offset="0x1B28EA4", VA="0x1B28EA4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095EC0", Offset="0x1095EC0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B28FFC", Offset="0x1B28FFC", VA="0x1B28FFC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B29460", Offset="0x1B29460", VA="0x1B29460")]
		static ClubWarRegisterMemberRequest()
		{
		}

		[Address(RVA="0x1B29058", Offset="0x1B29058", VA="0x1B29058")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D85C", Offset="0x107D85C")]
		public ClubWarRegisterMemberRequest()
		{
		}

		[Address(RVA="0x1B29060", Offset="0x1B29060", VA="0x1B29060")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D86C", Offset="0x107D86C")]
		public ClubWarRegisterMemberRequest(ClubWarRegisterMemberRequest other)
		{
		}

		[Address(RVA="0x1B29368", Offset="0x1B29368", VA="0x1B29368", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D8DC", Offset="0x107D8DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B290C4", Offset="0x1B290C4", VA="0x1B290C4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D87C", Offset="0x107D87C")]
		public ClubWarRegisterMemberRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B29138", Offset="0x1B29138", VA="0x1B29138", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D88C", Offset="0x107D88C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B291AC", Offset="0x1B291AC", VA="0x1B291AC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D89C", Offset="0x107D89C")]
		public bool Equals(ClubWarRegisterMemberRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B291F8", Offset="0x1B291F8", VA="0x1B291F8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D8AC", Offset="0x107D8AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B293A0", Offset="0x1B293A0", VA="0x1B293A0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D8EC", Offset="0x107D8EC")]
		public void MergeFrom(ClubWarRegisterMemberRequest other)
		{
		}

		[Address(RVA="0x1B293E0", Offset="0x1B293E0", VA="0x1B293E0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D8FC", Offset="0x107D8FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B2925C", Offset="0x1B2925C", VA="0x1B2925C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D8BC", Offset="0x107D8BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B292C4", Offset="0x1B292C4", VA="0x1B292C4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D8CC", Offset="0x107D8CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FAF8", Offset="0x104FAF8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarRegisterMemberRequest.<>c <>9;

			[Address(RVA="0x1B29538", Offset="0x1B29538", VA="0x1B29538")]
			static <>c()
			{
			}

			[Address(RVA="0x1B2959C", Offset="0x1B2959C", VA="0x1B2959C")]
			public <>c()
			{
			}

			[Address(RVA="0x1B295A4", Offset="0x1B295A4", VA="0x1B295A4")]
			internal ClubWarRegisterMemberRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}