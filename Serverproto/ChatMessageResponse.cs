using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ChatMessageResponse : IMessage<ChatMessageResponse>, IMessage, IEquatable<ChatMessageResponse>, IDeepCloneable<ChatMessageResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ChatMessageResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10946F0", Offset="0x10946F0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A3A004", Offset="0x1A3A004", VA="0x1A3A004")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10946E0", Offset="0x10946E0")]
		public static MessageParser<ChatMessageResponse> Parser
		{
			[Address(RVA="0x1A39F9C", Offset="0x1A39F9C", VA="0x1A39F9C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094700", Offset="0x1094700")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A3A0F0", Offset="0x1A3A0F0", VA="0x1A3A0F0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A3A404", Offset="0x1A3A404", VA="0x1A3A404")]
		static ChatMessageResponse()
		{
		}

		[Address(RVA="0x1A3A14C", Offset="0x1A3A14C", VA="0x1A3A14C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A2BC", Offset="0x107A2BC")]
		public ChatMessageResponse()
		{
		}

		[Address(RVA="0x1A3A154", Offset="0x1A3A154", VA="0x1A3A154")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A2CC", Offset="0x107A2CC")]
		public ChatMessageResponse(ChatMessageResponse other)
		{
		}

		[Address(RVA="0x1A3A368", Offset="0x1A3A368", VA="0x1A3A368", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A33C", Offset="0x107A33C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A3A198", Offset="0x1A3A198", VA="0x1A3A198", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A2DC", Offset="0x107A2DC")]
		public ChatMessageResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A3A1F8", Offset="0x1A3A1F8", VA="0x1A3A1F8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A2EC", Offset="0x107A2EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A3A290", Offset="0x1A3A290", VA="0x1A3A290", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A2FC", Offset="0x107A2FC")]
		public bool Equals(ChatMessageResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A3A2BC", Offset="0x1A3A2BC", VA="0x1A3A2BC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A30C", Offset="0x107A30C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A3A37C", Offset="0x1A3A37C", VA="0x1A3A37C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A34C", Offset="0x107A34C")]
		public void MergeFrom(ChatMessageResponse other)
		{
		}

		[Address(RVA="0x1A3A3B0", Offset="0x1A3A3B0", VA="0x1A3A3B0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A35C", Offset="0x107A35C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A3A2EC", Offset="0x1A3A2EC", VA="0x1A3A2EC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A31C", Offset="0x107A31C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A3A354", Offset="0x1A3A354", VA="0x1A3A354", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A32C", Offset="0x107A32C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F608", Offset="0x104F608")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ChatMessageResponse.<>c <>9;

			[Address(RVA="0x1A3A4DC", Offset="0x1A3A4DC", VA="0x1A3A4DC")]
			static <>c()
			{
			}

			[Address(RVA="0x1A3A540", Offset="0x1A3A540", VA="0x1A3A540")]
			public <>c()
			{
			}

			[Address(RVA="0x1A3A548", Offset="0x1A3A548", VA="0x1A3A548")]
			internal ChatMessageResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}