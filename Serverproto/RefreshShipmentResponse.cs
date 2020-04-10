using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RefreshShipmentResponse : IMessage<RefreshShipmentResponse>, IMessage, IEquatable<RefreshShipmentResponse>, IDeepCloneable<RefreshShipmentResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RefreshShipmentResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int RefreshedShipmentFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Shipment refreshedShipment_;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C858", Offset="0x109C858")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x2020E08", Offset="0x2020E08", VA="0x2020E08")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C888", Offset="0x109C888")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x2020FFC", Offset="0x2020FFC", VA="0x2020FFC")]
			get
			{
				return null;
			}
			[Address(RVA="0x2021004", Offset="0x2021004", VA="0x2021004")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C848", Offset="0x109C848")]
		public static MessageParser<RefreshShipmentResponse> Parser
		{
			[Address(RVA="0x2020DA0", Offset="0x2020DA0", VA="0x2020DA0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C868", Offset="0x109C868")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x2020EF8", Offset="0x2020EF8", VA="0x2020EF8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C878", Offset="0x109C878")]
		public Shipment RefreshedShipment
		{
			[Address(RVA="0x2020FEC", Offset="0x2020FEC", VA="0x2020FEC")]
			get
			{
				return null;
			}
			[Address(RVA="0x2020FF4", Offset="0x2020FF4", VA="0x2020FF4")]
			set
			{
			}
		}

		[Address(RVA="0x2021614", Offset="0x2021614", VA="0x2021614")]
		static RefreshShipmentResponse()
		{
		}

		[Address(RVA="0x2020F54", Offset="0x2020F54", VA="0x2020F54")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088AAC", Offset="0x1088AAC")]
		public RefreshShipmentResponse()
		{
		}

		[Address(RVA="0x2020F5C", Offset="0x2020F5C", VA="0x2020F5C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088ABC", Offset="0x1088ABC")]
		public RefreshShipmentResponse(RefreshShipmentResponse other)
		{
		}

		[Address(RVA="0x2021328", Offset="0x2021328", VA="0x2021328", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088B2C", Offset="0x1088B2C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x202100C", Offset="0x202100C", VA="0x202100C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088ACC", Offset="0x1088ACC")]
		public RefreshShipmentResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x202106C", Offset="0x202106C", VA="0x202106C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088ADC", Offset="0x1088ADC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x20210E0", Offset="0x20210E0", VA="0x20210E0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088AEC", Offset="0x1088AEC")]
		public bool Equals(RefreshShipmentResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x2021158", Offset="0x2021158", VA="0x2021158", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088AFC", Offset="0x1088AFC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x20213FC", Offset="0x20213FC", VA="0x20213FC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088B3C", Offset="0x1088B3C")]
		public void MergeFrom(RefreshShipmentResponse other)
		{
		}

		[Address(RVA="0x2021500", Offset="0x2021500", VA="0x2021500", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088B4C", Offset="0x1088B4C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x20211C8", Offset="0x20211C8", VA="0x20211C8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088B0C", Offset="0x1088B0C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x2021230", Offset="0x2021230", VA="0x2021230", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088B1C", Offset="0x1088B1C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050B38", Offset="0x1050B38")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RefreshShipmentResponse.<>c <>9;

			[Address(RVA="0x20216EC", Offset="0x20216EC", VA="0x20216EC")]
			static <>c()
			{
			}

			[Address(RVA="0x2021750", Offset="0x2021750", VA="0x2021750")]
			public <>c()
			{
			}

			[Address(RVA="0x2021758", Offset="0x2021758", VA="0x2021758")]
			internal RefreshShipmentResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}