using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BuyAllShipmentItemsRequest : IMessage<BuyAllShipmentItemsRequest>, IMessage, IEquatable<BuyAllShipmentItemsRequest>, IDeepCloneable<BuyAllShipmentItemsRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BuyAllShipmentItemsRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ShipmentDefIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong shipmentDefId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CBE8", Offset="0x109CBE8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DDB3EC", Offset="0x1DDB3EC", VA="0x1DDB3EC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CBD8", Offset="0x109CBD8")]
		public static MessageParser<BuyAllShipmentItemsRequest> Parser
		{
			[Address(RVA="0x1DDB384", Offset="0x1DDB384", VA="0x1DDB384")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CBF8", Offset="0x109CBF8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DDB4DC", Offset="0x1DDB4DC", VA="0x1DDB4DC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CC08", Offset="0x109CC08")]
		public ulong ShipmentDefId
		{
			[Address(RVA="0x1DDB604", Offset="0x1DDB604", VA="0x1DDB604")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DDB60C", Offset="0x1DDB60C", VA="0x1DDB60C")]
			set
			{
			}
		}

		[Address(RVA="0x1DDB980", Offset="0x1DDB980", VA="0x1DDB980")]
		static BuyAllShipmentItemsRequest()
		{
		}

		[Address(RVA="0x1DDB538", Offset="0x1DDB538", VA="0x1DDB538")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10892EC", Offset="0x10892EC")]
		public BuyAllShipmentItemsRequest()
		{
		}

		[Address(RVA="0x1DDB540", Offset="0x1DDB540", VA="0x1DDB540")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10892FC", Offset="0x10892FC")]
		public BuyAllShipmentItemsRequest(BuyAllShipmentItemsRequest other)
		{
		}

		[Address(RVA="0x1DDB834", Offset="0x1DDB834", VA="0x1DDB834", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108936C", Offset="0x108936C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DDB5A4", Offset="0x1DDB5A4", VA="0x1DDB5A4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108930C", Offset="0x108930C")]
		public BuyAllShipmentItemsRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1DDB614", Offset="0x1DDB614", VA="0x1DDB614", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108931C", Offset="0x108931C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DDB688", Offset="0x1DDB688", VA="0x1DDB688", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108932C", Offset="0x108932C")]
		public bool Equals(BuyAllShipmentItemsRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1DDB6C4", Offset="0x1DDB6C4", VA="0x1DDB6C4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108933C", Offset="0x108933C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DDB8C4", Offset="0x1DDB8C4", VA="0x1DDB8C4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108937C", Offset="0x108937C")]
		public void MergeFrom(BuyAllShipmentItemsRequest other)
		{
		}

		[Address(RVA="0x1DDB904", Offset="0x1DDB904", VA="0x1DDB904", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108938C", Offset="0x108938C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DDB72C", Offset="0x1DDB72C", VA="0x1DDB72C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108934C", Offset="0x108934C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DDB794", Offset="0x1DDB794", VA="0x1DDB794", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108935C", Offset="0x108935C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050BF8", Offset="0x1050BF8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BuyAllShipmentItemsRequest.<>c <>9;

			[Address(RVA="0x1DDBA58", Offset="0x1DDBA58", VA="0x1DDBA58")]
			static <>c()
			{
			}

			[Address(RVA="0x1DDBABC", Offset="0x1DDBABC", VA="0x1DDBABC")]
			public <>c()
			{
			}

			[Address(RVA="0x1DDBAC4", Offset="0x1DDBAC4", VA="0x1DDBAC4")]
			internal BuyAllShipmentItemsRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}