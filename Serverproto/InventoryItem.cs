using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InventoryItem : IMessage<InventoryItem>, IMessage, IEquatable<InventoryItem>, IDeepCloneable<InventoryItem>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InventoryItem> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong id_;

		[FieldOffset(Offset="0x0")]
		public const int CountFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private long count_;

		[FieldOffset(Offset="0x0")]
		public const int LootTagFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private Serverproto.LootTag lootTag_;

		[FieldOffset(Offset="0x0")]
		public const int VipExclusiveFieldNumber = 4;

		[FieldOffset(Offset="0x2C")]
		private bool vipExclusive_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10987C0", Offset="0x10987C0")]
		public long Count
		{
			[Address(RVA="0x1A89010", Offset="0x1A89010", VA="0x1A89010")]
			get
			{
				return new long();
			}
			[Address(RVA="0x1A89018", Offset="0x1A89018", VA="0x1A89018")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098790", Offset="0x1098790")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A88D30", Offset="0x1A88D30", VA="0x1A88D30")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10987B0", Offset="0x10987B0")]
		public ulong Id
		{
			[Address(RVA="0x1A89000", Offset="0x1A89000", VA="0x1A89000")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A89008", Offset="0x1A89008", VA="0x1A89008")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10987D0", Offset="0x10987D0")]
		public Serverproto.LootTag LootTag
		{
			[Address(RVA="0x1A89020", Offset="0x1A89020", VA="0x1A89020")]
			get
			{
				return new Serverproto.LootTag();
			}
			[Address(RVA="0x1A89028", Offset="0x1A89028", VA="0x1A89028")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098780", Offset="0x1098780")]
		public static MessageParser<InventoryItem> Parser
		{
			[Address(RVA="0x1A88CC8", Offset="0x1A88CC8", VA="0x1A88CC8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10987A0", Offset="0x10987A0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A88E84", Offset="0x1A88E84", VA="0x1A88E84", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10987E0", Offset="0x10987E0")]
		public bool VipExclusive
		{
			[Address(RVA="0x1A89030", Offset="0x1A89030", VA="0x1A89030")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A89038", Offset="0x1A89038", VA="0x1A89038")]
			set
			{
			}
		}

		[Address(RVA="0x1A8969C", Offset="0x1A8969C", VA="0x1A8969C")]
		static InventoryItem()
		{
		}

		[Address(RVA="0x1A88EE0", Offset="0x1A88EE0", VA="0x1A88EE0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10816EC", Offset="0x10816EC")]
		public InventoryItem()
		{
		}

		[Address(RVA="0x1A88EE8", Offset="0x1A88EE8", VA="0x1A88EE8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10816FC", Offset="0x10816FC")]
		public InventoryItem(InventoryItem other)
		{
		}

		[Address(RVA="0x1A89410", Offset="0x1A89410", VA="0x1A89410", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108176C", Offset="0x108176C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A88FA0", Offset="0x1A88FA0", VA="0x1A88FA0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108170C", Offset="0x108170C")]
		public InventoryItem Clone()
		{
			return null;
		}

		[Address(RVA="0x1A89044", Offset="0x1A89044", VA="0x1A89044", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108171C", Offset="0x108171C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A890B8", Offset="0x1A890B8", VA="0x1A890B8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108172C", Offset="0x108172C")]
		public bool Equals(InventoryItem other)
		{
			return new bool();
		}

		[Address(RVA="0x1A89134", Offset="0x1A89134", VA="0x1A89134", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108173C", Offset="0x108173C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A89538", Offset="0x1A89538", VA="0x1A89538", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108177C", Offset="0x108177C")]
		public void MergeFrom(InventoryItem other)
		{
		}

		[Address(RVA="0x1A8959C", Offset="0x1A8959C", VA="0x1A8959C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108178C", Offset="0x108178C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A891FC", Offset="0x1A891FC", VA="0x1A891FC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108174C", Offset="0x108174C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A89264", Offset="0x1A89264", VA="0x1A89264", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108175C", Offset="0x108175C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10500A8", Offset="0x10500A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InventoryItem.<>c <>9;

			[Address(RVA="0x1A89774", Offset="0x1A89774", VA="0x1A89774")]
			static <>c()
			{
			}

			[Address(RVA="0x1A897D8", Offset="0x1A897D8", VA="0x1A897D8")]
			public <>c()
			{
			}

			[Address(RVA="0x1A897E0", Offset="0x1A897E0", VA="0x1A897E0")]
			internal InventoryItem <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}