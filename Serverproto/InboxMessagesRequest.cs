using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InboxMessagesRequest : IMessage<InboxMessagesRequest>, IMessage, IEquatable<InboxMessagesRequest>, IDeepCloneable<InboxMessagesRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InboxMessagesRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A9F0", Offset="0x109A9F0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18E0074", Offset="0x18E0074", VA="0x18E0074")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A9E0", Offset="0x109A9E0")]
		public static MessageParser<InboxMessagesRequest> Parser
		{
			[Address(RVA="0x18E000C", Offset="0x18E000C", VA="0x18E000C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AA00", Offset="0x109AA00")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18E0164", Offset="0x18E0164", VA="0x18E0164", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18E0478", Offset="0x18E0478", VA="0x18E0478")]
		static InboxMessagesRequest()
		{
		}

		[Address(RVA="0x18E01C0", Offset="0x18E01C0", VA="0x18E01C0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108503C", Offset="0x108503C")]
		public InboxMessagesRequest()
		{
		}

		[Address(RVA="0x18E01C8", Offset="0x18E01C8", VA="0x18E01C8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108504C", Offset="0x108504C")]
		public InboxMessagesRequest(InboxMessagesRequest other)
		{
		}

		[Address(RVA="0x18E03DC", Offset="0x18E03DC", VA="0x18E03DC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10850BC", Offset="0x10850BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18E020C", Offset="0x18E020C", VA="0x18E020C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108505C", Offset="0x108505C")]
		public InboxMessagesRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x18E026C", Offset="0x18E026C", VA="0x18E026C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108506C", Offset="0x108506C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18E0304", Offset="0x18E0304", VA="0x18E0304", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108507C", Offset="0x108507C")]
		public bool Equals(InboxMessagesRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x18E0330", Offset="0x18E0330", VA="0x18E0330", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108508C", Offset="0x108508C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18E03F0", Offset="0x18E03F0", VA="0x18E03F0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10850CC", Offset="0x10850CC")]
		public void MergeFrom(InboxMessagesRequest other)
		{
		}

		[Address(RVA="0x18E0424", Offset="0x18E0424", VA="0x18E0424", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10850DC", Offset="0x10850DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18E0360", Offset="0x18E0360", VA="0x18E0360", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108509C", Offset="0x108509C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18E03C8", Offset="0x18E03C8", VA="0x18E03C8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10850AC", Offset="0x10850AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10505D8", Offset="0x10505D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InboxMessagesRequest.<>c <>9;

			[Address(RVA="0x18E0550", Offset="0x18E0550", VA="0x18E0550")]
			static <>c()
			{
			}

			[Address(RVA="0x18E05B4", Offset="0x18E05B4", VA="0x18E05B4")]
			public <>c()
			{
			}

			[Address(RVA="0x18E05BC", Offset="0x18E05BC", VA="0x18E05BC")]
			internal InboxMessagesRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}