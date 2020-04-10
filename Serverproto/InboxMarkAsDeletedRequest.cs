using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InboxMarkAsDeletedRequest : IMessage<InboxMarkAsDeletedRequest>, IMessage, IEquatable<InboxMarkAsDeletedRequest>, IDeepCloneable<InboxMarkAsDeletedRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InboxMarkAsDeletedRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int MessageIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string messageId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AB50", Offset="0x109AB50")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18DC664", Offset="0x18DC664", VA="0x18DC664")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AB70", Offset="0x109AB70")]
		public string MessageId
		{
			[Address(RVA="0x18DC8C8", Offset="0x18DC8C8", VA="0x18DC8C8")]
			get
			{
				return null;
			}
			[Address(RVA="0x18DC8D0", Offset="0x18DC8D0", VA="0x18DC8D0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AB40", Offset="0x109AB40")]
		public static MessageParser<InboxMarkAsDeletedRequest> Parser
		{
			[Address(RVA="0x18DC5FC", Offset="0x18DC5FC", VA="0x18DC5FC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AB60", Offset="0x109AB60")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18DC754", Offset="0x18DC754", VA="0x18DC754", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18DCD60", Offset="0x18DCD60", VA="0x18DCD60")]
		static InboxMarkAsDeletedRequest()
		{
		}

		[Address(RVA="0x18DC7B0", Offset="0x18DC7B0", VA="0x18DC7B0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108545C", Offset="0x108545C")]
		public InboxMarkAsDeletedRequest()
		{
		}

		[Address(RVA="0x18DC808", Offset="0x18DC808", VA="0x18DC808")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108546C", Offset="0x108546C")]
		public InboxMarkAsDeletedRequest(InboxMarkAsDeletedRequest other)
		{
		}

		[Address(RVA="0x18DCBBC", Offset="0x18DCBBC", VA="0x18DCBBC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10854DC", Offset="0x10854DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18DC868", Offset="0x18DC868", VA="0x18DC868", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108547C", Offset="0x108547C")]
		public InboxMarkAsDeletedRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x18DC940", Offset="0x18DC940", VA="0x18DC940", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108548C", Offset="0x108548C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18DC9B4", Offset="0x18DC9B4", VA="0x18DC9B4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108549C", Offset="0x108549C")]
		public bool Equals(InboxMarkAsDeletedRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x18DCA18", Offset="0x18DCA18", VA="0x18DCA18", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10854AC", Offset="0x10854AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18DCC70", Offset="0x18DCC70", VA="0x18DCC70", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10854EC", Offset="0x10854EC")]
		public void MergeFrom(InboxMarkAsDeletedRequest other)
		{
		}

		[Address(RVA="0x18DCCDC", Offset="0x18DCCDC", VA="0x18DCCDC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10854FC", Offset="0x10854FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18DCA9C", Offset="0x18DCA9C", VA="0x18DCA9C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10854BC", Offset="0x10854BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18DCB04", Offset="0x18DCB04", VA="0x18DCB04", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10854CC", Offset="0x10854CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050638", Offset="0x1050638")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InboxMarkAsDeletedRequest.<>c <>9;

			[Address(RVA="0x18DCE38", Offset="0x18DCE38", VA="0x18DCE38")]
			static <>c()
			{
			}

			[Address(RVA="0x18DCE9C", Offset="0x18DCE9C", VA="0x18DCE9C")]
			public <>c()
			{
			}

			[Address(RVA="0x18DCEA4", Offset="0x18DCEA4", VA="0x18DCEA4")]
			internal InboxMarkAsDeletedRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}