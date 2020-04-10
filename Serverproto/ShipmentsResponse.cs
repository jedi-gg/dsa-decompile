using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ShipmentsResponse : IMessage<ShipmentsResponse>, IMessage, IEquatable<ShipmentsResponse>, IDeepCloneable<ShipmentsResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ShipmentsResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ShipmentsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<Shipment> _repeated_shipments_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<Shipment> shipments_;

		[FieldOffset(Offset="0x0")]
		public const int ShipmentResetTimestampFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong shipmentResetTimestamp_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C700", Offset="0x109C700")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BD57A4", Offset="0x1BD57A4", VA="0x1BD57A4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C6F0", Offset="0x109C6F0")]
		public static MessageParser<ShipmentsResponse> Parser
		{
			[Address(RVA="0x1BD573C", Offset="0x1BD573C", VA="0x1BD573C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C710", Offset="0x109C710")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BD5894", Offset="0x1BD5894", VA="0x1BD5894", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C730", Offset="0x109C730")]
		public ulong ShipmentResetTimestamp
		{
			[Address(RVA="0x1BD5A68", Offset="0x1BD5A68", VA="0x1BD5A68")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BD5A70", Offset="0x1BD5A70", VA="0x1BD5A70")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C720", Offset="0x109C720")]
		public RepeatedField<Shipment> Shipments
		{
			[Address(RVA="0x1BD5A60", Offset="0x1BD5A60", VA="0x1BD5A60")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BD6050", Offset="0x1BD6050", VA="0x1BD6050")]
		static ShipmentsResponse()
		{
		}

		[Address(RVA="0x1BD58F0", Offset="0x1BD58F0", VA="0x1BD58F0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10887EC", Offset="0x10887EC")]
		public ShipmentsResponse()
		{
		}

		[Address(RVA="0x1BD5960", Offset="0x1BD5960", VA="0x1BD5960")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10887FC", Offset="0x10887FC")]
		public ShipmentsResponse(ShipmentsResponse other)
		{
		}

		[Address(RVA="0x1BD5DB4", Offset="0x1BD5DB4", VA="0x1BD5DB4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108886C", Offset="0x108886C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BD5A00", Offset="0x1BD5A00", VA="0x1BD5A00", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108880C", Offset="0x108880C")]
		public ShipmentsResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BD5A78", Offset="0x1BD5A78", VA="0x1BD5A78", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108881C", Offset="0x108881C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD5AEC", Offset="0x1BD5AEC", VA="0x1BD5AEC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108882C", Offset="0x108882C")]
		public bool Equals(ShipmentsResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD5BAC", Offset="0x1BD5BAC", VA="0x1BD5BAC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108883C", Offset="0x108883C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BD5EA8", Offset="0x1BD5EA8", VA="0x1BD5EA8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108887C", Offset="0x108887C")]
		public void MergeFrom(ShipmentsResponse other)
		{
		}

		[Address(RVA="0x1BD5F44", Offset="0x1BD5F44", VA="0x1BD5F44", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108888C", Offset="0x108888C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BD5C30", Offset="0x1BD5C30", VA="0x1BD5C30", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108884C", Offset="0x108884C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BD5C98", Offset="0x1BD5C98", VA="0x1BD5C98", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108885C", Offset="0x108885C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050AF8", Offset="0x1050AF8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ShipmentsResponse.<>c <>9;

			[Address(RVA="0x1BD6170", Offset="0x1BD6170", VA="0x1BD6170")]
			static <>c()
			{
			}

			[Address(RVA="0x1BD61D4", Offset="0x1BD61D4", VA="0x1BD61D4")]
			public <>c()
			{
			}

			[Address(RVA="0x1BD61DC", Offset="0x1BD61DC", VA="0x1BD61DC")]
			internal ShipmentsResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}