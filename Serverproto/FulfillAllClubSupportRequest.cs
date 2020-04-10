using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class FulfillAllClubSupportRequest : IMessage<FulfillAllClubSupportRequest>, IMessage, IEquatable<FulfillAllClubSupportRequest>, IDeepCloneable<FulfillAllClubSupportRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<FulfillAllClubSupportRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095530", Offset="0x1095530")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA1E80", Offset="0x1BA1E80", VA="0x1BA1E80")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095520", Offset="0x1095520")]
		public static MessageParser<FulfillAllClubSupportRequest> Parser
		{
			[Address(RVA="0x1BA1E18", Offset="0x1BA1E18", VA="0x1BA1E18")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095540", Offset="0x1095540")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA1F70", Offset="0x1BA1F70", VA="0x1BA1F70", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BA2284", Offset="0x1BA2284", VA="0x1BA2284")]
		static FulfillAllClubSupportRequest()
		{
		}

		[Address(RVA="0x1BA1FCC", Offset="0x1BA1FCC", VA="0x1BA1FCC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C46C", Offset="0x107C46C")]
		public FulfillAllClubSupportRequest()
		{
		}

		[Address(RVA="0x1BA1FD4", Offset="0x1BA1FD4", VA="0x1BA1FD4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C47C", Offset="0x107C47C")]
		public FulfillAllClubSupportRequest(FulfillAllClubSupportRequest other)
		{
		}

		[Address(RVA="0x1BA21E8", Offset="0x1BA21E8", VA="0x1BA21E8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C4EC", Offset="0x107C4EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA2018", Offset="0x1BA2018", VA="0x1BA2018", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C48C", Offset="0x107C48C")]
		public FulfillAllClubSupportRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA2078", Offset="0x1BA2078", VA="0x1BA2078", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C49C", Offset="0x107C49C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA2110", Offset="0x1BA2110", VA="0x1BA2110", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C4AC", Offset="0x107C4AC")]
		public bool Equals(FulfillAllClubSupportRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA213C", Offset="0x1BA213C", VA="0x1BA213C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C4BC", Offset="0x107C4BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA21FC", Offset="0x1BA21FC", VA="0x1BA21FC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C4FC", Offset="0x107C4FC")]
		public void MergeFrom(FulfillAllClubSupportRequest other)
		{
		}

		[Address(RVA="0x1BA2230", Offset="0x1BA2230", VA="0x1BA2230", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C50C", Offset="0x107C50C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA216C", Offset="0x1BA216C", VA="0x1BA216C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C4CC", Offset="0x107C4CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA21D4", Offset="0x1BA21D4", VA="0x1BA21D4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C4DC", Offset="0x107C4DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F918", Offset="0x104F918")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FulfillAllClubSupportRequest.<>c <>9;

			[Address(RVA="0x1BA235C", Offset="0x1BA235C", VA="0x1BA235C")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA23C0", Offset="0x1BA23C0", VA="0x1BA23C0")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA23C8", Offset="0x1BA23C8", VA="0x1BA23C8")]
			internal FulfillAllClubSupportRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}