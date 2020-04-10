using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BuyShipmentItemRequest : IMessage<BuyShipmentItemRequest>, IMessage, IEquatable<BuyShipmentItemRequest>, IDeepCloneable<BuyShipmentItemRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BuyShipmentItemRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ShipmentItemIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string shipmentItemId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C750", Offset="0x109C750")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F872F4", Offset="0x1F872F4", VA="0x1F872F4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C740", Offset="0x109C740")]
		public static MessageParser<BuyShipmentItemRequest> Parser
		{
			[Address(RVA="0x1F8728C", Offset="0x1F8728C", VA="0x1F8728C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C760", Offset="0x109C760")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F873E4", Offset="0x1F873E4", VA="0x1F873E4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C770", Offset="0x109C770")]
		public string ShipmentItemId
		{
			[Address(RVA="0x1F87558", Offset="0x1F87558", VA="0x1F87558")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F87560", Offset="0x1F87560", VA="0x1F87560")]
			set
			{
			}
		}

		[Address(RVA="0x1F879F0", Offset="0x1F879F0", VA="0x1F879F0")]
		static BuyShipmentItemRequest()
		{
		}

		[Address(RVA="0x1F87440", Offset="0x1F87440", VA="0x1F87440")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108889C", Offset="0x108889C")]
		public BuyShipmentItemRequest()
		{
		}

		[Address(RVA="0x1F87498", Offset="0x1F87498", VA="0x1F87498")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10888AC", Offset="0x10888AC")]
		public BuyShipmentItemRequest(BuyShipmentItemRequest other)
		{
		}

		[Address(RVA="0x1F8784C", Offset="0x1F8784C", VA="0x1F8784C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108891C", Offset="0x108891C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F874F8", Offset="0x1F874F8", VA="0x1F874F8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10888BC", Offset="0x10888BC")]
		public BuyShipmentItemRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1F875D0", Offset="0x1F875D0", VA="0x1F875D0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10888CC", Offset="0x10888CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F87644", Offset="0x1F87644", VA="0x1F87644", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10888DC", Offset="0x10888DC")]
		public bool Equals(BuyShipmentItemRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1F876A8", Offset="0x1F876A8", VA="0x1F876A8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10888EC", Offset="0x10888EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F87900", Offset="0x1F87900", VA="0x1F87900", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108892C", Offset="0x108892C")]
		public void MergeFrom(BuyShipmentItemRequest other)
		{
		}

		[Address(RVA="0x1F8796C", Offset="0x1F8796C", VA="0x1F8796C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108893C", Offset="0x108893C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F8772C", Offset="0x1F8772C", VA="0x1F8772C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10888FC", Offset="0x10888FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F87794", Offset="0x1F87794", VA="0x1F87794", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108890C", Offset="0x108890C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050B08", Offset="0x1050B08")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BuyShipmentItemRequest.<>c <>9;

			[Address(RVA="0x1F87AC8", Offset="0x1F87AC8", VA="0x1F87AC8")]
			static <>c()
			{
			}

			[Address(RVA="0x1F87B2C", Offset="0x1F87B2C", VA="0x1F87B2C")]
			public <>c()
			{
			}

			[Address(RVA="0x1F87B34", Offset="0x1F87B34", VA="0x1F87B34")]
			internal BuyShipmentItemRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}