using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EquipEmoteResponse : IMessage<EquipEmoteResponse>, IMessage, IEquatable<EquipEmoteResponse>, IDeepCloneable<EquipEmoteResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EquipEmoteResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int EmoteDeckFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_emoteDeck_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ulong> emoteDeck_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099160", Offset="0x1099160")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FC3694", Offset="0x1FC3694", VA="0x1FC3694")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099180", Offset="0x1099180")]
		public RepeatedField<ulong> EmoteDeck
		{
			[Address(RVA="0x1FC3948", Offset="0x1FC3948", VA="0x1FC3948")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099150", Offset="0x1099150")]
		public static MessageParser<EquipEmoteResponse> Parser
		{
			[Address(RVA="0x1FC362C", Offset="0x1FC362C", VA="0x1FC362C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099170", Offset="0x1099170")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FC3784", Offset="0x1FC3784", VA="0x1FC3784", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FC3E38", Offset="0x1FC3E38", VA="0x1FC3E38")]
		static EquipEmoteResponse()
		{
		}

		[Address(RVA="0x1FC37E0", Offset="0x1FC37E0", VA="0x1FC37E0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082A2C", Offset="0x1082A2C")]
		public EquipEmoteResponse()
		{
		}

		[Address(RVA="0x1FC3850", Offset="0x1FC3850", VA="0x1FC3850")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082A3C", Offset="0x1082A3C")]
		public EquipEmoteResponse(EquipEmoteResponse other)
		{
		}

		[Address(RVA="0x1FC3C00", Offset="0x1FC3C00", VA="0x1FC3C00", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082AAC", Offset="0x1082AAC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FC38E8", Offset="0x1FC38E8", VA="0x1FC38E8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082A4C", Offset="0x1082A4C")]
		public EquipEmoteResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1FC3950", Offset="0x1FC3950", VA="0x1FC3950", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082A5C", Offset="0x1082A5C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC39C4", Offset="0x1FC39C4", VA="0x1FC39C4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082A6C", Offset="0x1082A6C")]
		public bool Equals(EquipEmoteResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC3A74", Offset="0x1FC3A74", VA="0x1FC3A74", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082A7C", Offset="0x1082A7C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FC3CBC", Offset="0x1FC3CBC", VA="0x1FC3CBC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082ABC", Offset="0x1082ABC")]
		public void MergeFrom(EquipEmoteResponse other)
		{
		}

		[Address(RVA="0x1FC3D4C", Offset="0x1FC3D4C", VA="0x1FC3D4C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082ACC", Offset="0x1082ACC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FC3AD4", Offset="0x1FC3AD4", VA="0x1FC3AD4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082A8C", Offset="0x1082A8C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FC3B3C", Offset="0x1FC3B3C", VA="0x1FC3B3C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082A9C", Offset="0x1082A9C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050268", Offset="0x1050268")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EquipEmoteResponse.<>c <>9;

			[Address(RVA="0x1FC3F28", Offset="0x1FC3F28", VA="0x1FC3F28")]
			static <>c()
			{
			}

			[Address(RVA="0x1FC3F8C", Offset="0x1FC3F8C", VA="0x1FC3F8C")]
			public <>c()
			{
			}

			[Address(RVA="0x1FC3F94", Offset="0x1FC3F94", VA="0x1FC3F94")]
			internal EquipEmoteResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}