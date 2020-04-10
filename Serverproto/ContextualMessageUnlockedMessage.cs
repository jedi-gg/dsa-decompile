using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ContextualMessageUnlockedMessage : IMessage<ContextualMessageUnlockedMessage>, IMessage, IEquatable<ContextualMessageUnlockedMessage>, IDeepCloneable<ContextualMessageUnlockedMessage>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ContextualMessageUnlockedMessage> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnlockedMessageGroupIdsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_unlockedMessageGroupIds_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ulong> unlockedMessageGroupIds_;

		[FieldOffset(Offset="0x0")]
		public const int AutoCompletedExistingMessageGroupIdsFieldNumber = 2;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ulong> _repeated_autoCompletedExistingMessageGroupIds_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<ulong> autoCompletedExistingMessageGroupIds_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B0F0", Offset="0x109B0F0")]
		public RepeatedField<ulong> AutoCompletedExistingMessageGroupIds
		{
			[Address(RVA="0x1EEE06C", Offset="0x1EEE06C", VA="0x1EEE06C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B0C0", Offset="0x109B0C0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EEDD70", Offset="0x1EEDD70", VA="0x1EEDD70")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B0B0", Offset="0x109B0B0")]
		public static MessageParser<ContextualMessageUnlockedMessage> Parser
		{
			[Address(RVA="0x1EEDD08", Offset="0x1EEDD08", VA="0x1EEDD08")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B0D0", Offset="0x109B0D0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EEDE60", Offset="0x1EEDE60", VA="0x1EEDE60", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B0E0", Offset="0x109B0E0")]
		public RepeatedField<ulong> UnlockedMessageGroupIds
		{
			[Address(RVA="0x1EEE064", Offset="0x1EEE064", VA="0x1EEE064")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EEE6A0", Offset="0x1EEE6A0", VA="0x1EEE6A0")]
		static ContextualMessageUnlockedMessage()
		{
		}

		[Address(RVA="0x1EEDEBC", Offset="0x1EEDEBC", VA="0x1EEDEBC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108642C", Offset="0x108642C")]
		public ContextualMessageUnlockedMessage()
		{
		}

		[Address(RVA="0x1EEDF4C", Offset="0x1EEDF4C", VA="0x1EEDF4C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108643C", Offset="0x108643C")]
		public ContextualMessageUnlockedMessage(ContextualMessageUnlockedMessage other)
		{
		}

		[Address(RVA="0x1EEE3C0", Offset="0x1EEE3C0", VA="0x1EEE3C0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10864AC", Offset="0x10864AC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EEE004", Offset="0x1EEE004", VA="0x1EEE004", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108644C", Offset="0x108644C")]
		public ContextualMessageUnlockedMessage Clone()
		{
			return null;
		}

		[Address(RVA="0x1EEE074", Offset="0x1EEE074", VA="0x1EEE074", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108645C", Offset="0x108645C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EEE0E8", Offset="0x1EEE0E8", VA="0x1EEE0E8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108646C", Offset="0x108646C")]
		public bool Equals(ContextualMessageUnlockedMessage other)
		{
			return new bool();
		}

		[Address(RVA="0x1EEE1CC", Offset="0x1EEE1CC", VA="0x1EEE1CC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108647C", Offset="0x108647C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EEE4B4", Offset="0x1EEE4B4", VA="0x1EEE4B4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10864BC", Offset="0x10864BC")]
		public void MergeFrom(ContextualMessageUnlockedMessage other)
		{
		}

		[Address(RVA="0x1EEE570", Offset="0x1EEE570", VA="0x1EEE570", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10864CC", Offset="0x10864CC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EEE258", Offset="0x1EEE258", VA="0x1EEE258", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108648C", Offset="0x108648C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EEE2C0", Offset="0x1EEE2C0", VA="0x1EEE2C0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108649C", Offset="0x108649C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10507A8", Offset="0x10507A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ContextualMessageUnlockedMessage.<>c <>9;

			[Address(RVA="0x1EEE7A8", Offset="0x1EEE7A8", VA="0x1EEE7A8")]
			static <>c()
			{
			}

			[Address(RVA="0x1EEE80C", Offset="0x1EEE80C", VA="0x1EEE80C")]
			public <>c()
			{
			}

			[Address(RVA="0x1EEE814", Offset="0x1EEE814", VA="0x1EEE814")]
			internal ContextualMessageUnlockedMessage <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}