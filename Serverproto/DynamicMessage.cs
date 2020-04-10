using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class DynamicMessage : IMessage<DynamicMessage>, IMessage, IEquatable<DynamicMessage>, IDeepCloneable<DynamicMessage>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<DynamicMessage> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int TypeFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private DynamicMessageType type_;

		[FieldOffset(Offset="0x0")]
		public const int PayloadFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ByteString payload_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BAA0", Offset="0x109BAA0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FBDB2C", Offset="0x1FBDB2C", VA="0x1FBDB2C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BA90", Offset="0x109BA90")]
		public static MessageParser<DynamicMessage> Parser
		{
			[Address(RVA="0x1FBDAC4", Offset="0x1FBDAC4", VA="0x1FBDAC4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BAD0", Offset="0x109BAD0")]
		public ByteString Payload
		{
			[Address(RVA="0x1FBDDD8", Offset="0x1FBDDD8", VA="0x1FBDDD8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FBDDE0", Offset="0x1FBDDE0", VA="0x1FBDDE0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BAB0", Offset="0x109BAB0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FBDC1C", Offset="0x1FBDC1C", VA="0x1FBDC1C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BAC0", Offset="0x109BAC0")]
		public DynamicMessageType Type
		{
			[Address(RVA="0x1FBDDC8", Offset="0x1FBDDC8", VA="0x1FBDDC8")]
			get
			{
				return new DynamicMessageType();
			}
			[Address(RVA="0x1FBDDD0", Offset="0x1FBDDD0", VA="0x1FBDDD0")]
			set
			{
			}
		}

		[Address(RVA="0x1FBE3C8", Offset="0x1FBE3C8", VA="0x1FBE3C8")]
		static DynamicMessage()
		{
		}

		[Address(RVA="0x1FBDC78", Offset="0x1FBDC78", VA="0x1FBDC78")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108781C", Offset="0x108781C")]
		public DynamicMessage()
		{
		}

		[Address(RVA="0x1FBDCEC", Offset="0x1FBDCEC", VA="0x1FBDCEC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108782C", Offset="0x108782C")]
		public DynamicMessage(DynamicMessage other)
		{
		}

		[Address(RVA="0x1FBE1B4", Offset="0x1FBE1B4", VA="0x1FBE1B4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108789C", Offset="0x108789C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FBDD68", Offset="0x1FBDD68", VA="0x1FBDD68", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108783C", Offset="0x108783C")]
		public DynamicMessage Clone()
		{
			return null;
		}

		[Address(RVA="0x1FBDE50", Offset="0x1FBDE50", VA="0x1FBDE50", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108784C", Offset="0x108784C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBDEC4", Offset="0x1FBDEC4", VA="0x1FBDEC4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108785C", Offset="0x108785C")]
		public bool Equals(DynamicMessage other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBDF90", Offset="0x1FBDF90", VA="0x1FBDF90", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108786C", Offset="0x108786C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FBE2A4", Offset="0x1FBE2A4", VA="0x1FBE2A4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10878AC", Offset="0x10878AC")]
		public void MergeFrom(DynamicMessage other)
		{
		}

		[Address(RVA="0x1FBE31C", Offset="0x1FBE31C", VA="0x1FBE31C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10878BC", Offset="0x10878BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FBE03C", Offset="0x1FBE03C", VA="0x1FBE03C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108787C", Offset="0x108787C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FBE0A4", Offset="0x1FBE0A4", VA="0x1FBE0A4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108788C", Offset="0x108788C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050978", Offset="0x1050978")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DynamicMessage.<>c <>9;

			[Address(RVA="0x1FBE4A0", Offset="0x1FBE4A0", VA="0x1FBE4A0")]
			static <>c()
			{
			}

			[Address(RVA="0x1FBE504", Offset="0x1FBE504", VA="0x1FBE504")]
			public <>c()
			{
			}

			[Address(RVA="0x1FBE50C", Offset="0x1FBE50C", VA="0x1FBE50C")]
			internal DynamicMessage <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}