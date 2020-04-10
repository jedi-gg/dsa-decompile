using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BuyAllShipmentItemsResponse : IMessage<BuyAllShipmentItemsResponse>, IMessage, IEquatable<BuyAllShipmentItemsResponse>, IDeepCloneable<BuyAllShipmentItemsResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BuyAllShipmentItemsResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 2;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CC28", Offset="0x109CC28")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DDBB88", Offset="0x1DDBB88", VA="0x1DDBB88")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CC48", Offset="0x109CC48")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1DDBD58", Offset="0x1DDBD58", VA="0x1DDBD58")]
			get
			{
				return null;
			}
			[Address(RVA="0x1DDBD60", Offset="0x1DDBD60", VA="0x1DDBD60")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CC18", Offset="0x109CC18")]
		public static MessageParser<BuyAllShipmentItemsResponse> Parser
		{
			[Address(RVA="0x1DDBB20", Offset="0x1DDBB20", VA="0x1DDBB20")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CC38", Offset="0x109CC38")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DDBC78", Offset="0x1DDBC78", VA="0x1DDBC78", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1DDC220", Offset="0x1DDC220", VA="0x1DDC220")]
		static BuyAllShipmentItemsResponse()
		{
		}

		[Address(RVA="0x1DDBCD4", Offset="0x1DDBCD4", VA="0x1DDBCD4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108939C", Offset="0x108939C")]
		public BuyAllShipmentItemsResponse()
		{
		}

		[Address(RVA="0x1DDBCDC", Offset="0x1DDBCDC", VA="0x1DDBCDC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10893AC", Offset="0x10893AC")]
		public BuyAllShipmentItemsResponse(BuyAllShipmentItemsResponse other)
		{
		}

		[Address(RVA="0x1DDC000", Offset="0x1DDC000", VA="0x1DDC000", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108941C", Offset="0x108941C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DDBD68", Offset="0x1DDBD68", VA="0x1DDBD68", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10893BC", Offset="0x10893BC")]
		public BuyAllShipmentItemsResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1DDBDC8", Offset="0x1DDBDC8", VA="0x1DDBDC8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10893CC", Offset="0x10893CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DDBE3C", Offset="0x1DDBE3C", VA="0x1DDBE3C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10893DC", Offset="0x10893DC")]
		public bool Equals(BuyAllShipmentItemsResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1DDBEA0", Offset="0x1DDBEA0", VA="0x1DDBEA0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10893EC", Offset="0x10893EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DDC090", Offset="0x1DDC090", VA="0x1DDC090", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108942C", Offset="0x108942C")]
		public void MergeFrom(BuyAllShipmentItemsResponse other)
		{
		}

		[Address(RVA="0x1DDC144", Offset="0x1DDC144", VA="0x1DDC144", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108943C", Offset="0x108943C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DDBEF8", Offset="0x1DDBEF8", VA="0x1DDBEF8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10893FC", Offset="0x10893FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DDBF60", Offset="0x1DDBF60", VA="0x1DDBF60", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108940C", Offset="0x108940C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050C08", Offset="0x1050C08")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BuyAllShipmentItemsResponse.<>c <>9;

			[Address(RVA="0x1DDC2F8", Offset="0x1DDC2F8", VA="0x1DDC2F8")]
			static <>c()
			{
			}

			[Address(RVA="0x1DDC35C", Offset="0x1DDC35C", VA="0x1DDC35C")]
			public <>c()
			{
			}

			[Address(RVA="0x1DDC364", Offset="0x1DDC364", VA="0x1DDC364")]
			internal BuyAllShipmentItemsResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}