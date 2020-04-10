using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InventoryDelta : IMessage<InventoryDelta>, IMessage, IEquatable<InventoryDelta>, IDeepCloneable<InventoryDelta>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InventoryDelta> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ItemsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<InventoryItem> _repeated_items_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<InventoryItem> items_;

		[FieldOffset(Offset="0x0")]
		public const int UnitsFieldNumber = 2;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<Unit> _repeated_units_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<Unit> units_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerLevelUpFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private Serverproto.PlayerLevelUp playerLevelUp_;

		[FieldOffset(Offset="0x0")]
		public const int SpellsFieldNumber = 4;

		[FieldOffset(Offset="0x18")]
		private readonly static FieldCodec<Spell> _repeated_spells_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<Spell> spells_;

		[FieldOffset(Offset="0x0")]
		public const int PassportSeasonLevelUpFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private Serverproto.PassportSeasonLevelUp passportSeasonLevelUp_;

		[FieldOffset(Offset="0x0")]
		public const int ItemConversionsFieldNumber = 6;

		[FieldOffset(Offset="0x20")]
		private readonly static FieldCodec<InventoryItemConversion> _repeated_itemConversions_codec;

		[FieldOffset(Offset="0x40")]
		private readonly RepeatedField<InventoryItemConversion> itemConversions_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098850", Offset="0x1098850")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18E7680", Offset="0x18E7680", VA="0x18E7680")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10988C0", Offset="0x10988C0")]
		public RepeatedField<InventoryItemConversion> ItemConversions
		{
			[Address(RVA="0x18E793C", Offset="0x18E793C", VA="0x18E793C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098870", Offset="0x1098870")]
		public RepeatedField<InventoryItem> Items
		{
			[Address(RVA="0x18E7924", Offset="0x18E7924", VA="0x18E7924")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098840", Offset="0x1098840")]
		public static MessageParser<InventoryDelta> Parser
		{
			[Address(RVA="0x18E7618", Offset="0x18E7618", VA="0x18E7618")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10988B0", Offset="0x10988B0")]
		public Serverproto.PassportSeasonLevelUp PassportSeasonLevelUp
		{
			[Address(RVA="0x18E7914", Offset="0x18E7914", VA="0x18E7914")]
			get
			{
				return null;
			}
			[Address(RVA="0x18E791C", Offset="0x18E791C", VA="0x18E791C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098860", Offset="0x1098860")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18E7770", Offset="0x18E7770", VA="0x18E7770", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098890", Offset="0x1098890")]
		public Serverproto.PlayerLevelUp PlayerLevelUp
		{
			[Address(RVA="0x18E7904", Offset="0x18E7904", VA="0x18E7904")]
			get
			{
				return null;
			}
			[Address(RVA="0x18E790C", Offset="0x18E790C", VA="0x18E790C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10988A0", Offset="0x10988A0")]
		public RepeatedField<Spell> Spells
		{
			[Address(RVA="0x18E7934", Offset="0x18E7934", VA="0x18E7934")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098880", Offset="0x1098880")]
		public RepeatedField<Unit> Units
		{
			[Address(RVA="0x18E792C", Offset="0x18E792C", VA="0x18E792C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18E8370", Offset="0x18E8370", VA="0x18E8370")]
		static InventoryDelta()
		{
		}

		[Address(RVA="0x18DC0E8", Offset="0x18DC0E8", VA="0x18DC0E8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108184C", Offset="0x108184C")]
		public InventoryDelta()
		{
		}

		[Address(RVA="0x18E77CC", Offset="0x18E77CC", VA="0x18E77CC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108185C", Offset="0x108185C")]
		public InventoryDelta(InventoryDelta other)
		{
		}

		[Address(RVA="0x18E7EEC", Offset="0x18E7EEC", VA="0x18E7EEC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10818CC", Offset="0x10818CC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18DBCAC", Offset="0x18DBCAC", VA="0x18DBCAC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108186C", Offset="0x108186C")]
		public InventoryDelta Clone()
		{
			return null;
		}

		[Address(RVA="0x18E7944", Offset="0x18E7944", VA="0x18E7944", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108187C", Offset="0x108187C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18E79B8", Offset="0x18E79B8", VA="0x18E79B8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108188C", Offset="0x108188C")]
		public bool Equals(InventoryDelta other)
		{
			return new bool();
		}

		[Address(RVA="0x18E7B20", Offset="0x18E7B20", VA="0x18E7B20", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108189C", Offset="0x108189C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18DC1D0", Offset="0x18DC1D0", VA="0x18DC1D0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10818DC", Offset="0x10818DC")]
		public void MergeFrom(InventoryDelta other)
		{
		}

		[Address(RVA="0x18E8100", Offset="0x18E8100", VA="0x18E8100", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10818EC", Offset="0x10818EC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18E7C2C", Offset="0x18E7C2C", VA="0x18E7C2C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10818AC", Offset="0x10818AC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18E7C94", Offset="0x18E7C94", VA="0x18E7C94", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10818BC", Offset="0x10818BC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10500C8", Offset="0x10500C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InventoryDelta.<>c <>9;

			[Address(RVA="0x1A88C00", Offset="0x1A88C00", VA="0x1A88C00")]
			static <>c()
			{
			}

			[Address(RVA="0x1A88C64", Offset="0x1A88C64", VA="0x1A88C64")]
			public <>c()
			{
			}

			[Address(RVA="0x1A88C6C", Offset="0x1A88C6C", VA="0x1A88C6C")]
			internal InventoryDelta <.cctor>b__50_0()
			{
				return null;
			}
		}
	}
}