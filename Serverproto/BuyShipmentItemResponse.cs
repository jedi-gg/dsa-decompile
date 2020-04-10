using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BuyShipmentItemResponse : IMessage<BuyShipmentItemResponse>, IMessage, IEquatable<BuyShipmentItemResponse>, IDeepCloneable<BuyShipmentItemResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BuyShipmentItemResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C790", Offset="0x109C790")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F87BF4", Offset="0x1F87BF4", VA="0x1F87BF4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C7B0", Offset="0x109C7B0")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1F87DC4", Offset="0x1F87DC4", VA="0x1F87DC4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F87DCC", Offset="0x1F87DCC", VA="0x1F87DCC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C780", Offset="0x109C780")]
		public static MessageParser<BuyShipmentItemResponse> Parser
		{
			[Address(RVA="0x1F87B8C", Offset="0x1F87B8C", VA="0x1F87B8C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C7A0", Offset="0x109C7A0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F87CE4", Offset="0x1F87CE4", VA="0x1F87CE4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F8828C", Offset="0x1F8828C", VA="0x1F8828C")]
		static BuyShipmentItemResponse()
		{
		}

		[Address(RVA="0x1F87D40", Offset="0x1F87D40", VA="0x1F87D40")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108894C", Offset="0x108894C")]
		public BuyShipmentItemResponse()
		{
		}

		[Address(RVA="0x1F87D48", Offset="0x1F87D48", VA="0x1F87D48")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108895C", Offset="0x108895C")]
		public BuyShipmentItemResponse(BuyShipmentItemResponse other)
		{
		}

		[Address(RVA="0x1F8806C", Offset="0x1F8806C", VA="0x1F8806C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10889CC", Offset="0x10889CC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F87DD4", Offset="0x1F87DD4", VA="0x1F87DD4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108896C", Offset="0x108896C")]
		public BuyShipmentItemResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1F87E34", Offset="0x1F87E34", VA="0x1F87E34", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108897C", Offset="0x108897C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F87EA8", Offset="0x1F87EA8", VA="0x1F87EA8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108898C", Offset="0x108898C")]
		public bool Equals(BuyShipmentItemResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1F87F0C", Offset="0x1F87F0C", VA="0x1F87F0C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108899C", Offset="0x108899C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F880FC", Offset="0x1F880FC", VA="0x1F880FC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10889DC", Offset="0x10889DC")]
		public void MergeFrom(BuyShipmentItemResponse other)
		{
		}

		[Address(RVA="0x1F881B0", Offset="0x1F881B0", VA="0x1F881B0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10889EC", Offset="0x10889EC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F87F64", Offset="0x1F87F64", VA="0x1F87F64", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10889AC", Offset="0x10889AC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F87FCC", Offset="0x1F87FCC", VA="0x1F87FCC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10889BC", Offset="0x10889BC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050B18", Offset="0x1050B18")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BuyShipmentItemResponse.<>c <>9;

			[Address(RVA="0x1F88364", Offset="0x1F88364", VA="0x1F88364")]
			static <>c()
			{
			}

			[Address(RVA="0x1F883C8", Offset="0x1F883C8", VA="0x1F883C8")]
			public <>c()
			{
			}

			[Address(RVA="0x1F883D0", Offset="0x1F883D0", VA="0x1F883D0")]
			internal BuyShipmentItemResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}