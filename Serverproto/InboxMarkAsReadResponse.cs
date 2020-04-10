using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InboxMarkAsReadResponse : IMessage<InboxMarkAsReadResponse>, IMessage, IEquatable<InboxMarkAsReadResponse>, IDeepCloneable<InboxMarkAsReadResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InboxMarkAsReadResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AAA0", Offset="0x109AAA0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18DDE70", Offset="0x18DDE70", VA="0x18DDE70")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AA90", Offset="0x109AA90")]
		public static MessageParser<InboxMarkAsReadResponse> Parser
		{
			[Address(RVA="0x18DDE08", Offset="0x18DDE08", VA="0x18DDE08")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AAB0", Offset="0x109AAB0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18DDF60", Offset="0x18DDF60", VA="0x18DDF60", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18DE274", Offset="0x18DE274", VA="0x18DE274")]
		static InboxMarkAsReadResponse()
		{
		}

		[Address(RVA="0x18DDFBC", Offset="0x18DDFBC", VA="0x18DDFBC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108524C", Offset="0x108524C")]
		public InboxMarkAsReadResponse()
		{
		}

		[Address(RVA="0x18DDFC4", Offset="0x18DDFC4", VA="0x18DDFC4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108525C", Offset="0x108525C")]
		public InboxMarkAsReadResponse(InboxMarkAsReadResponse other)
		{
		}

		[Address(RVA="0x18DE1D8", Offset="0x18DE1D8", VA="0x18DE1D8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10852CC", Offset="0x10852CC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18DE008", Offset="0x18DE008", VA="0x18DE008", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108526C", Offset="0x108526C")]
		public InboxMarkAsReadResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x18DE068", Offset="0x18DE068", VA="0x18DE068", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108527C", Offset="0x108527C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18DE100", Offset="0x18DE100", VA="0x18DE100", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108528C", Offset="0x108528C")]
		public bool Equals(InboxMarkAsReadResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x18DE12C", Offset="0x18DE12C", VA="0x18DE12C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108529C", Offset="0x108529C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18DE1EC", Offset="0x18DE1EC", VA="0x18DE1EC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10852DC", Offset="0x10852DC")]
		public void MergeFrom(InboxMarkAsReadResponse other)
		{
		}

		[Address(RVA="0x18DE220", Offset="0x18DE220", VA="0x18DE220", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10852EC", Offset="0x10852EC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18DE15C", Offset="0x18DE15C", VA="0x18DE15C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10852AC", Offset="0x10852AC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18DE1C4", Offset="0x18DE1C4", VA="0x18DE1C4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10852BC", Offset="0x10852BC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050608", Offset="0x1050608")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InboxMarkAsReadResponse.<>c <>9;

			[Address(RVA="0x18DE34C", Offset="0x18DE34C", VA="0x18DE34C")]
			static <>c()
			{
			}

			[Address(RVA="0x18DE3B0", Offset="0x18DE3B0", VA="0x18DE3B0")]
			public <>c()
			{
			}

			[Address(RVA="0x18DE3B8", Offset="0x18DE3B8", VA="0x18DE3B8")]
			internal InboxMarkAsReadResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}