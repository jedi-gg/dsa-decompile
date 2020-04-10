using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InboxMessagesResponse : IMessage<InboxMessagesResponse>, IMessage, IEquatable<InboxMessagesResponse>, IDeepCloneable<InboxMessagesResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InboxMessagesResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int MessagesFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<InboxMessage> _repeated_messages_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<InboxMessage> messages_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AA20", Offset="0x109AA20")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18E0680", Offset="0x18E0680", VA="0x18E0680")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AA40", Offset="0x109AA40")]
		public RepeatedField<InboxMessage> Messages
		{
			[Address(RVA="0x18E0934", Offset="0x18E0934", VA="0x18E0934")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AA10", Offset="0x109AA10")]
		public static MessageParser<InboxMessagesResponse> Parser
		{
			[Address(RVA="0x18E0618", Offset="0x18E0618", VA="0x18E0618")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AA30", Offset="0x109AA30")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18E0770", Offset="0x18E0770", VA="0x18E0770", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18E0E1C", Offset="0x18E0E1C", VA="0x18E0E1C")]
		static InboxMessagesResponse()
		{
		}

		[Address(RVA="0x18E07CC", Offset="0x18E07CC", VA="0x18E07CC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10850EC", Offset="0x10850EC")]
		public InboxMessagesResponse()
		{
		}

		[Address(RVA="0x18E083C", Offset="0x18E083C", VA="0x18E083C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10850FC", Offset="0x10850FC")]
		public InboxMessagesResponse(InboxMessagesResponse other)
		{
		}

		[Address(RVA="0x18E0BEC", Offset="0x18E0BEC", VA="0x18E0BEC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108516C", Offset="0x108516C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18E08D4", Offset="0x18E08D4", VA="0x18E08D4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108510C", Offset="0x108510C")]
		public InboxMessagesResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x18E093C", Offset="0x18E093C", VA="0x18E093C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108511C", Offset="0x108511C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18E09B0", Offset="0x18E09B0", VA="0x18E09B0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108512C", Offset="0x108512C")]
		public bool Equals(InboxMessagesResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x18E0A60", Offset="0x18E0A60", VA="0x18E0A60", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108513C", Offset="0x108513C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18E0CA8", Offset="0x18E0CA8", VA="0x18E0CA8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108517C", Offset="0x108517C")]
		public void MergeFrom(InboxMessagesResponse other)
		{
		}

		[Address(RVA="0x18E0D38", Offset="0x18E0D38", VA="0x18E0D38", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108518C", Offset="0x108518C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18E0AC0", Offset="0x18E0AC0", VA="0x18E0AC0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108514C", Offset="0x108514C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18E0B28", Offset="0x18E0B28", VA="0x18E0B28", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108515C", Offset="0x108515C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10505E8", Offset="0x10505E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InboxMessagesResponse.<>c <>9;

			[Address(RVA="0x18E0F3C", Offset="0x18E0F3C", VA="0x18E0F3C")]
			static <>c()
			{
			}

			[Address(RVA="0x18E0FA0", Offset="0x18E0FA0", VA="0x18E0FA0")]
			public <>c()
			{
			}

			[Address(RVA="0x18E0FA8", Offset="0x18E0FA8", VA="0x18E0FA8")]
			internal InboxMessagesResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}