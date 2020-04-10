using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InboxMarkAsReadRequest : IMessage<InboxMarkAsReadRequest>, IMessage, IEquatable<InboxMarkAsReadRequest>, IDeepCloneable<InboxMarkAsReadRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InboxMarkAsReadRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int MessageIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string messageId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AA60", Offset="0x109AA60")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18DD570", Offset="0x18DD570", VA="0x18DD570")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AA80", Offset="0x109AA80")]
		public string MessageId
		{
			[Address(RVA="0x18DD7D4", Offset="0x18DD7D4", VA="0x18DD7D4")]
			get
			{
				return null;
			}
			[Address(RVA="0x18DD7DC", Offset="0x18DD7DC", VA="0x18DD7DC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AA50", Offset="0x109AA50")]
		public static MessageParser<InboxMarkAsReadRequest> Parser
		{
			[Address(RVA="0x18DD508", Offset="0x18DD508", VA="0x18DD508")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AA70", Offset="0x109AA70")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18DD660", Offset="0x18DD660", VA="0x18DD660", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18DDC6C", Offset="0x18DDC6C", VA="0x18DDC6C")]
		static InboxMarkAsReadRequest()
		{
		}

		[Address(RVA="0x18DD6BC", Offset="0x18DD6BC", VA="0x18DD6BC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108519C", Offset="0x108519C")]
		public InboxMarkAsReadRequest()
		{
		}

		[Address(RVA="0x18DD714", Offset="0x18DD714", VA="0x18DD714")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10851AC", Offset="0x10851AC")]
		public InboxMarkAsReadRequest(InboxMarkAsReadRequest other)
		{
		}

		[Address(RVA="0x18DDAC8", Offset="0x18DDAC8", VA="0x18DDAC8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108521C", Offset="0x108521C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18DD774", Offset="0x18DD774", VA="0x18DD774", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10851BC", Offset="0x10851BC")]
		public InboxMarkAsReadRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x18DD84C", Offset="0x18DD84C", VA="0x18DD84C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10851CC", Offset="0x10851CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18DD8C0", Offset="0x18DD8C0", VA="0x18DD8C0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10851DC", Offset="0x10851DC")]
		public bool Equals(InboxMarkAsReadRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x18DD924", Offset="0x18DD924", VA="0x18DD924", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10851EC", Offset="0x10851EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18DDB7C", Offset="0x18DDB7C", VA="0x18DDB7C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108522C", Offset="0x108522C")]
		public void MergeFrom(InboxMarkAsReadRequest other)
		{
		}

		[Address(RVA="0x18DDBE8", Offset="0x18DDBE8", VA="0x18DDBE8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108523C", Offset="0x108523C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18DD9A8", Offset="0x18DD9A8", VA="0x18DD9A8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10851FC", Offset="0x10851FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18DDA10", Offset="0x18DDA10", VA="0x18DDA10", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108520C", Offset="0x108520C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10505F8", Offset="0x10505F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InboxMarkAsReadRequest.<>c <>9;

			[Address(RVA="0x18DDD44", Offset="0x18DDD44", VA="0x18DDD44")]
			static <>c()
			{
			}

			[Address(RVA="0x18DDDA8", Offset="0x18DDDA8", VA="0x18DDDA8")]
			public <>c()
			{
			}

			[Address(RVA="0x18DDDB0", Offset="0x18DDDB0", VA="0x18DDDB0")]
			internal InboxMarkAsReadRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}