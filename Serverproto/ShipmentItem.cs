using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ShipmentItem : IMessage<ShipmentItem>, IMessage, IEquatable<ShipmentItem>, IDeepCloneable<ShipmentItem>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ShipmentItem> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string id_;

		[FieldOffset(Offset="0x0")]
		public const int ItemFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ItemCount item_;

		[FieldOffset(Offset="0x0")]
		public const int CostFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ItemCount cost_;

		[FieldOffset(Offset="0x0")]
		public const int PurchasedFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private bool purchased_;

		[FieldOffset(Offset="0x0")]
		public const int IsLockedFieldNumber = 5;

		[FieldOffset(Offset="0x31")]
		private bool isLocked_;

		[FieldOffset(Offset="0x0")]
		public const int LockedKeyFieldNumber = 6;

		[FieldOffset(Offset="0x38")]
		private string lockedKey_;

		[FieldOffset(Offset="0x0")]
		public const int StoreItemFieldNumber = 7;

		[FieldOffset(Offset="0x40")]
		private Serverproto.StoreItem storeItem_;

		[FieldOffset(Offset="0x0")]
		public const int SortOrderFieldNumber = 8;

		[FieldOffset(Offset="0x48")]
		private long sortOrder_;

		[FieldOffset(Offset="0x0")]
		public const int OnSaleFieldNumber = 9;

		[FieldOffset(Offset="0x50")]
		private bool onSale_;

		[FieldOffset(Offset="0x0")]
		public const int IsVipLockedFieldNumber = 10;

		[FieldOffset(Offset="0x51")]
		private bool isVipLocked_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C318", Offset="0x109C318")]
		public ItemCount Cost
		{
			[Address(RVA="0x1BD1BAC", Offset="0x1BD1BAC", VA="0x1BD1BAC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BD37CC", Offset="0x1BD37CC", VA="0x1BD37CC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C2D8", Offset="0x109C2D8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BD354C", Offset="0x1BD354C", VA="0x1BD354C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C2F8", Offset="0x109C2F8")]
		public string Id
		{
			[Address(RVA="0x1BD38A4", Offset="0x1BD38A4", VA="0x1BD38A4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BD38AC", Offset="0x1BD38AC", VA="0x1BD38AC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C338", Offset="0x109C338")]
		public bool IsLocked
		{
			[Address(RVA="0x1BD3928", Offset="0x1BD3928", VA="0x1BD3928")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BD3930", Offset="0x1BD3930", VA="0x1BD3930")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C388", Offset="0x109C388")]
		public bool IsVipLocked
		{
			[Address(RVA="0x1BD39D8", Offset="0x1BD39D8", VA="0x1BD39D8")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BD39E0", Offset="0x1BD39E0", VA="0x1BD39E0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C308", Offset="0x109C308")]
		public ItemCount Item
		{
			[Address(RVA="0x1BD37BC", Offset="0x1BD37BC", VA="0x1BD37BC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BD37C4", Offset="0x1BD37C4", VA="0x1BD37C4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C348", Offset="0x109C348")]
		public string LockedKey
		{
			[Address(RVA="0x1BD393C", Offset="0x1BD393C", VA="0x1BD393C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BD3944", Offset="0x1BD3944", VA="0x1BD3944")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C378", Offset="0x109C378")]
		public bool OnSale
		{
			[Address(RVA="0x1BD39C4", Offset="0x1BD39C4", VA="0x1BD39C4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BD39CC", Offset="0x1BD39CC", VA="0x1BD39CC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C2C8", Offset="0x109C2C8")]
		public static MessageParser<ShipmentItem> Parser
		{
			[Address(RVA="0x1BD3420", Offset="0x1BD3420", VA="0x1BD3420")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C2E8", Offset="0x109C2E8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BD363C", Offset="0x1BD363C", VA="0x1BD363C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C328", Offset="0x109C328")]
		public bool Purchased
		{
			[Address(RVA="0x1BD1BA4", Offset="0x1BD1BA4", VA="0x1BD1BA4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BD391C", Offset="0x1BD391C", VA="0x1BD391C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C368", Offset="0x109C368")]
		public long SortOrder
		{
			[Address(RVA="0x1BD39B4", Offset="0x1BD39B4", VA="0x1BD39B4")]
			get
			{
				return new long();
			}
			[Address(RVA="0x1BD39BC", Offset="0x1BD39BC", VA="0x1BD39BC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C358", Offset="0x109C358")]
		public Serverproto.StoreItem StoreItem
		{
			[Address(RVA="0x1BD37D4", Offset="0x1BD37D4", VA="0x1BD37D4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BD383C", Offset="0x1BD383C", VA="0x1BD383C")]
			set
			{
			}
		}

		[Address(RVA="0x1BD4F94", Offset="0x1BD4F94", VA="0x1BD4F94")]
		static ShipmentItem()
		{
		}

		[Address(RVA="0x1BD3698", Offset="0x1BD3698", VA="0x1BD3698")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10881BC", Offset="0x10881BC")]
		public ShipmentItem()
		{
		}

		[Address(RVA="0x1BD36F4", Offset="0x1BD36F4", VA="0x1BD36F4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10881CC", Offset="0x10881CC")]
		public ShipmentItem(ShipmentItem other)
		{
		}

		[Address(RVA="0x1BD41C4", Offset="0x1BD41C4", VA="0x1BD41C4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108823C", Offset="0x108823C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BD3844", Offset="0x1BD3844", VA="0x1BD3844", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10881DC", Offset="0x10881DC")]
		public ShipmentItem Clone()
		{
			return null;
		}

		[Address(RVA="0x1BD39EC", Offset="0x1BD39EC", VA="0x1BD39EC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10881EC", Offset="0x10881EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD3A60", Offset="0x1BD3A60", VA="0x1BD3A60", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10881FC", Offset="0x10881FC")]
		public bool Equals(ShipmentItem other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD3BA4", Offset="0x1BD3BA4", VA="0x1BD3BA4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108820C", Offset="0x108820C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BD4408", Offset="0x1BD4408", VA="0x1BD4408", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108824C", Offset="0x108824C")]
		public void MergeFrom(ShipmentItem other)
		{
		}

		[Address(RVA="0x1BD4CFC", Offset="0x1BD4CFC", VA="0x1BD4CFC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108825C", Offset="0x108825C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BD3D64", Offset="0x1BD3D64", VA="0x1BD3D64", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108821C", Offset="0x108821C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BD3DCC", Offset="0x1BD3DCC", VA="0x1BD3DCC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108822C", Offset="0x108822C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050A68", Offset="0x1050A68")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ShipmentItem.<>c <>9;

			[Address(RVA="0x1BD506C", Offset="0x1BD506C", VA="0x1BD506C")]
			static <>c()
			{
			}

			[Address(RVA="0x1BD50D0", Offset="0x1BD50D0", VA="0x1BD50D0")]
			public <>c()
			{
			}

			[Address(RVA="0x1BD50D8", Offset="0x1BD50D8", VA="0x1BD50D8")]
			internal ShipmentItem <.cctor>b__70_0()
			{
				return null;
			}
		}
	}
}