using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ChatMessageDeleted : IMessage<ChatMessageDeleted>, IMessage, IEquatable<ChatMessageDeleted>, IDeepCloneable<ChatMessageDeleted>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ChatMessageDeleted> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int MessageIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string messageId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094800", Offset="0x1094800")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A396A0", Offset="0x1A396A0", VA="0x1A396A0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094820", Offset="0x1094820")]
		public string MessageId
		{
			[Address(RVA="0x1A39968", Offset="0x1A39968", VA="0x1A39968")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A39970", Offset="0x1A39970", VA="0x1A39970")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10947F0", Offset="0x10947F0")]
		public static MessageParser<ChatMessageDeleted> Parser
		{
			[Address(RVA="0x1A39638", Offset="0x1A39638", VA="0x1A39638")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094810", Offset="0x1094810")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A397F4", Offset="0x1A397F4", VA="0x1A397F4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A39E00", Offset="0x1A39E00", VA="0x1A39E00")]
		static ChatMessageDeleted()
		{
		}

		[Address(RVA="0x1A39850", Offset="0x1A39850", VA="0x1A39850")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A62C", Offset="0x107A62C")]
		public ChatMessageDeleted()
		{
		}

		[Address(RVA="0x1A398A8", Offset="0x1A398A8", VA="0x1A398A8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A63C", Offset="0x107A63C")]
		public ChatMessageDeleted(ChatMessageDeleted other)
		{
		}

		[Address(RVA="0x1A39C5C", Offset="0x1A39C5C", VA="0x1A39C5C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A6AC", Offset="0x107A6AC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A39908", Offset="0x1A39908", VA="0x1A39908", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A64C", Offset="0x107A64C")]
		public ChatMessageDeleted Clone()
		{
			return null;
		}

		[Address(RVA="0x1A399E0", Offset="0x1A399E0", VA="0x1A399E0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A65C", Offset="0x107A65C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A39A54", Offset="0x1A39A54", VA="0x1A39A54", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A66C", Offset="0x107A66C")]
		public bool Equals(ChatMessageDeleted other)
		{
			return new bool();
		}

		[Address(RVA="0x1A39AB8", Offset="0x1A39AB8", VA="0x1A39AB8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A67C", Offset="0x107A67C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A39D10", Offset="0x1A39D10", VA="0x1A39D10", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A6BC", Offset="0x107A6BC")]
		public void MergeFrom(ChatMessageDeleted other)
		{
		}

		[Address(RVA="0x1A39D7C", Offset="0x1A39D7C", VA="0x1A39D7C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A6CC", Offset="0x107A6CC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A39B3C", Offset="0x1A39B3C", VA="0x1A39B3C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A68C", Offset="0x107A68C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A39BA4", Offset="0x1A39BA4", VA="0x1A39BA4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A69C", Offset="0x107A69C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F658", Offset="0x104F658")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ChatMessageDeleted.<>c <>9;

			[Address(RVA="0x1A39ED8", Offset="0x1A39ED8", VA="0x1A39ED8")]
			static <>c()
			{
			}

			[Address(RVA="0x1A39F3C", Offset="0x1A39F3C", VA="0x1A39F3C")]
			public <>c()
			{
			}

			[Address(RVA="0x1A39F44", Offset="0x1A39F44", VA="0x1A39F44")]
			internal ChatMessageDeleted <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}