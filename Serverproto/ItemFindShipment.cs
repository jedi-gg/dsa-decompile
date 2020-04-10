using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ItemFindShipment : IMessage<ItemFindShipment>, IMessage, IEquatable<ItemFindShipment>, IDeepCloneable<ItemFindShipment>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ItemFindShipment> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string id_;

		[FieldOffset(Offset="0x0")]
		public const int ShipmentIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong shipmentId_;

		[FieldOffset(Offset="0x0")]
		public const int ItemDefIdFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong itemDefId_;

		[FieldOffset(Offset="0x0")]
		public const int ItemCountFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong itemCount_;

		[FieldOffset(Offset="0x0")]
		public const int CostDefIdFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong costDefId_;

		[FieldOffset(Offset="0x0")]
		public const int CostCountFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private ulong costCount_;

		[FieldOffset(Offset="0x0")]
		public const int OnSaleFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private bool onSale_;

		[FieldOffset(Offset="0x0")]
		public const int VipOnlyFieldNumber = 8;

		[FieldOffset(Offset="0x49")]
		private bool vipOnly_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098D00", Offset="0x1098D00")]
		public ulong CostCount
		{
			[Address(RVA="0x1A95608", Offset="0x1A95608", VA="0x1A95608")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A95610", Offset="0x1A95610", VA="0x1A95610")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098CF0", Offset="0x1098CF0")]
		public ulong CostDefId
		{
			[Address(RVA="0x1A955F8", Offset="0x1A955F8", VA="0x1A955F8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A95600", Offset="0x1A95600", VA="0x1A95600")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098C90", Offset="0x1098C90")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A9522C", Offset="0x1A9522C", VA="0x1A9522C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098CB0", Offset="0x1098CB0")]
		public string Id
		{
			[Address(RVA="0x1A95550", Offset="0x1A95550", VA="0x1A95550")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A95558", Offset="0x1A95558", VA="0x1A95558")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098CE0", Offset="0x1098CE0")]
		public ulong ItemCount
		{
			[Address(RVA="0x1A955E8", Offset="0x1A955E8", VA="0x1A955E8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A955F0", Offset="0x1A955F0", VA="0x1A955F0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098CD0", Offset="0x1098CD0")]
		public ulong ItemDefId
		{
			[Address(RVA="0x1A955D8", Offset="0x1A955D8", VA="0x1A955D8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A955E0", Offset="0x1A955E0", VA="0x1A955E0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098D10", Offset="0x1098D10")]
		public bool OnSale
		{
			[Address(RVA="0x1A95618", Offset="0x1A95618", VA="0x1A95618")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A95620", Offset="0x1A95620", VA="0x1A95620")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098C80", Offset="0x1098C80")]
		public static MessageParser<ItemFindShipment> Parser
		{
			[Address(RVA="0x1A905B4", Offset="0x1A905B4", VA="0x1A905B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098CA0", Offset="0x1098CA0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A95318", Offset="0x1A95318", VA="0x1A95318", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098CC0", Offset="0x1098CC0")]
		public ulong ShipmentId
		{
			[Address(RVA="0x1A955C8", Offset="0x1A955C8", VA="0x1A955C8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A955D0", Offset="0x1A955D0", VA="0x1A955D0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098D20", Offset="0x1098D20")]
		public bool VipOnly
		{
			[Address(RVA="0x1A9562C", Offset="0x1A9562C", VA="0x1A9562C")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A95634", Offset="0x1A95634", VA="0x1A95634")]
			set
			{
			}
		}

		[Address(RVA="0x1A9611C", Offset="0x1A9611C", VA="0x1A9611C")]
		static ItemFindShipment()
		{
		}

		[Address(RVA="0x1A95374", Offset="0x1A95374", VA="0x1A95374")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108229C", Offset="0x108229C")]
		public ItemFindShipment()
		{
		}

		[Address(RVA="0x1A953CC", Offset="0x1A953CC", VA="0x1A953CC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10822AC", Offset="0x10822AC")]
		public ItemFindShipment(ItemFindShipment other)
		{
		}

		[Address(RVA="0x1A95C98", Offset="0x1A95C98", VA="0x1A95C98", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108231C", Offset="0x108231C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A954F0", Offset="0x1A954F0", VA="0x1A954F0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10822BC", Offset="0x10822BC")]
		public ItemFindShipment Clone()
		{
			return null;
		}

		[Address(RVA="0x1A95640", Offset="0x1A95640", VA="0x1A95640", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10822CC", Offset="0x10822CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A956B4", Offset="0x1A956B4", VA="0x1A956B4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10822DC", Offset="0x10822DC")]
		public bool Equals(ItemFindShipment other)
		{
			return new bool();
		}

		[Address(RVA="0x1A957A8", Offset="0x1A957A8", VA="0x1A957A8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10822EC", Offset="0x10822EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A95EA0", Offset="0x1A95EA0", VA="0x1A95EA0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108232C", Offset="0x108232C")]
		public void MergeFrom(ItemFindShipment other)
		{
		}

		[Address(RVA="0x1A95F60", Offset="0x1A95F60", VA="0x1A95F60", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108233C", Offset="0x108233C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A95908", Offset="0x1A95908", VA="0x1A95908", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10822FC", Offset="0x10822FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A95970", Offset="0x1A95970", VA="0x1A95970", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108230C", Offset="0x108230C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10501B8", Offset="0x10501B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ItemFindShipment.<>c <>9;

			[Address(RVA="0x1A961F4", Offset="0x1A961F4", VA="0x1A961F4")]
			static <>c()
			{
			}

			[Address(RVA="0x1A96258", Offset="0x1A96258", VA="0x1A96258")]
			public <>c()
			{
			}

			[Address(RVA="0x1A96260", Offset="0x1A96260", VA="0x1A96260")]
			internal ItemFindShipment <.cctor>b__60_0()
			{
				return null;
			}
		}
	}
}