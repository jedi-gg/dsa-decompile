using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InboxMarkAsClaimedRequest : IMessage<InboxMarkAsClaimedRequest>, IMessage, IEquatable<InboxMarkAsClaimedRequest>, IDeepCloneable<InboxMarkAsClaimedRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InboxMarkAsClaimedRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int MessageIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string messageId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AAD0", Offset="0x109AAD0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18DB1D8", Offset="0x18DB1D8", VA="0x18DB1D8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AAF0", Offset="0x109AAF0")]
		public string MessageId
		{
			[Address(RVA="0x18DB43C", Offset="0x18DB43C", VA="0x18DB43C")]
			get
			{
				return null;
			}
			[Address(RVA="0x18DB444", Offset="0x18DB444", VA="0x18DB444")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AAC0", Offset="0x109AAC0")]
		public static MessageParser<InboxMarkAsClaimedRequest> Parser
		{
			[Address(RVA="0x18DB170", Offset="0x18DB170", VA="0x18DB170")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AAE0", Offset="0x109AAE0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18DB2C8", Offset="0x18DB2C8", VA="0x18DB2C8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18DB8D4", Offset="0x18DB8D4", VA="0x18DB8D4")]
		static InboxMarkAsClaimedRequest()
		{
		}

		[Address(RVA="0x18DB324", Offset="0x18DB324", VA="0x18DB324")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10852FC", Offset="0x10852FC")]
		public InboxMarkAsClaimedRequest()
		{
		}

		[Address(RVA="0x18DB37C", Offset="0x18DB37C", VA="0x18DB37C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108530C", Offset="0x108530C")]
		public InboxMarkAsClaimedRequest(InboxMarkAsClaimedRequest other)
		{
		}

		[Address(RVA="0x18DB730", Offset="0x18DB730", VA="0x18DB730", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108537C", Offset="0x108537C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18DB3DC", Offset="0x18DB3DC", VA="0x18DB3DC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108531C", Offset="0x108531C")]
		public InboxMarkAsClaimedRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x18DB4B4", Offset="0x18DB4B4", VA="0x18DB4B4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108532C", Offset="0x108532C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18DB528", Offset="0x18DB528", VA="0x18DB528", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108533C", Offset="0x108533C")]
		public bool Equals(InboxMarkAsClaimedRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x18DB58C", Offset="0x18DB58C", VA="0x18DB58C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108534C", Offset="0x108534C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18DB7E4", Offset="0x18DB7E4", VA="0x18DB7E4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108538C", Offset="0x108538C")]
		public void MergeFrom(InboxMarkAsClaimedRequest other)
		{
		}

		[Address(RVA="0x18DB850", Offset="0x18DB850", VA="0x18DB850", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108539C", Offset="0x108539C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18DB610", Offset="0x18DB610", VA="0x18DB610", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108535C", Offset="0x108535C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18DB678", Offset="0x18DB678", VA="0x18DB678", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108536C", Offset="0x108536C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050618", Offset="0x1050618")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InboxMarkAsClaimedRequest.<>c <>9;

			[Address(RVA="0x18DB9AC", Offset="0x18DB9AC", VA="0x18DB9AC")]
			static <>c()
			{
			}

			[Address(RVA="0x18DBA10", Offset="0x18DBA10", VA="0x18DBA10")]
			public <>c()
			{
			}

			[Address(RVA="0x18DBA18", Offset="0x18DBA18", VA="0x18DBA18")]
			internal InboxMarkAsClaimedRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}