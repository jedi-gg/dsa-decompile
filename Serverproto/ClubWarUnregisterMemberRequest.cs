using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarUnregisterMemberRequest : IMessage<ClubWarUnregisterMemberRequest>, IMessage, IEquatable<ClubWarUnregisterMemberRequest>, IDeepCloneable<ClubWarUnregisterMemberRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarUnregisterMemberRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095F20", Offset="0x1095F20")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EE7484", Offset="0x1EE7484", VA="0x1EE7484")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095F10", Offset="0x1095F10")]
		public static MessageParser<ClubWarUnregisterMemberRequest> Parser
		{
			[Address(RVA="0x1EE741C", Offset="0x1EE741C", VA="0x1EE741C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095F30", Offset="0x1095F30")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EE7574", Offset="0x1EE7574", VA="0x1EE7574", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EE7888", Offset="0x1EE7888", VA="0x1EE7888")]
		static ClubWarUnregisterMemberRequest()
		{
		}

		[Address(RVA="0x1EE75D0", Offset="0x1EE75D0", VA="0x1EE75D0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D9BC", Offset="0x107D9BC")]
		public ClubWarUnregisterMemberRequest()
		{
		}

		[Address(RVA="0x1EE75D8", Offset="0x1EE75D8", VA="0x1EE75D8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D9CC", Offset="0x107D9CC")]
		public ClubWarUnregisterMemberRequest(ClubWarUnregisterMemberRequest other)
		{
		}

		[Address(RVA="0x1EE77EC", Offset="0x1EE77EC", VA="0x1EE77EC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DA3C", Offset="0x107DA3C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EE761C", Offset="0x1EE761C", VA="0x1EE761C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D9DC", Offset="0x107D9DC")]
		public ClubWarUnregisterMemberRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1EE767C", Offset="0x1EE767C", VA="0x1EE767C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D9EC", Offset="0x107D9EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE7714", Offset="0x1EE7714", VA="0x1EE7714", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D9FC", Offset="0x107D9FC")]
		public bool Equals(ClubWarUnregisterMemberRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE7740", Offset="0x1EE7740", VA="0x1EE7740", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DA0C", Offset="0x107DA0C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EE7800", Offset="0x1EE7800", VA="0x1EE7800", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DA4C", Offset="0x107DA4C")]
		public void MergeFrom(ClubWarUnregisterMemberRequest other)
		{
		}

		[Address(RVA="0x1EE7834", Offset="0x1EE7834", VA="0x1EE7834", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DA5C", Offset="0x107DA5C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EE7770", Offset="0x1EE7770", VA="0x1EE7770", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DA1C", Offset="0x107DA1C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EE77D8", Offset="0x1EE77D8", VA="0x1EE77D8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DA2C", Offset="0x107DA2C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FB18", Offset="0x104FB18")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarUnregisterMemberRequest.<>c <>9;

			[Address(RVA="0x1EE7960", Offset="0x1EE7960", VA="0x1EE7960")]
			static <>c()
			{
			}

			[Address(RVA="0x1EE79C4", Offset="0x1EE79C4", VA="0x1EE79C4")]
			public <>c()
			{
			}

			[Address(RVA="0x1EE79CC", Offset="0x1EE79CC", VA="0x1EE79CC")]
			internal ClubWarUnregisterMemberRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}