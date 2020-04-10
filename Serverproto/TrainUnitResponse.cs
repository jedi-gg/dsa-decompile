using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class TrainUnitResponse : IMessage<TrainUnitResponse>, IMessage, IEquatable<TrainUnitResponse>, IDeepCloneable<TrainUnitResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<TrainUnitResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10989B0", Offset="0x10989B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B79E14", Offset="0x1B79E14", VA="0x1B79E14")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10989D0", Offset="0x10989D0")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1B79FE4", Offset="0x1B79FE4", VA="0x1B79FE4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B79FEC", Offset="0x1B79FEC", VA="0x1B79FEC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10989A0", Offset="0x10989A0")]
		public static MessageParser<TrainUnitResponse> Parser
		{
			[Address(RVA="0x1B79DAC", Offset="0x1B79DAC", VA="0x1B79DAC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10989C0", Offset="0x10989C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B79F04", Offset="0x1B79F04", VA="0x1B79F04", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B7A4AC", Offset="0x1B7A4AC", VA="0x1B7A4AC")]
		static TrainUnitResponse()
		{
		}

		[Address(RVA="0x1B79F60", Offset="0x1B79F60", VA="0x1B79F60")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081B0C", Offset="0x1081B0C")]
		public TrainUnitResponse()
		{
		}

		[Address(RVA="0x1B79F68", Offset="0x1B79F68", VA="0x1B79F68")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081B1C", Offset="0x1081B1C")]
		public TrainUnitResponse(TrainUnitResponse other)
		{
		}

		[Address(RVA="0x1B7A28C", Offset="0x1B7A28C", VA="0x1B7A28C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081B8C", Offset="0x1081B8C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B79FF4", Offset="0x1B79FF4", VA="0x1B79FF4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081B2C", Offset="0x1081B2C")]
		public TrainUnitResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B7A054", Offset="0x1B7A054", VA="0x1B7A054", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081B3C", Offset="0x1081B3C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B7A0C8", Offset="0x1B7A0C8", VA="0x1B7A0C8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081B4C", Offset="0x1081B4C")]
		public bool Equals(TrainUnitResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B7A12C", Offset="0x1B7A12C", VA="0x1B7A12C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081B5C", Offset="0x1081B5C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B7A31C", Offset="0x1B7A31C", VA="0x1B7A31C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081B9C", Offset="0x1081B9C")]
		public void MergeFrom(TrainUnitResponse other)
		{
		}

		[Address(RVA="0x1B7A3D0", Offset="0x1B7A3D0", VA="0x1B7A3D0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081BAC", Offset="0x1081BAC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B7A184", Offset="0x1B7A184", VA="0x1B7A184", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081B6C", Offset="0x1081B6C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B7A1EC", Offset="0x1B7A1EC", VA="0x1B7A1EC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081B7C", Offset="0x1081B7C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050108", Offset="0x1050108")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TrainUnitResponse.<>c <>9;

			[Address(RVA="0x1B7A584", Offset="0x1B7A584", VA="0x1B7A584")]
			static <>c()
			{
			}

			[Address(RVA="0x1B7A5E8", Offset="0x1B7A5E8", VA="0x1B7A5E8")]
			public <>c()
			{
			}

			[Address(RVA="0x1B7A5F0", Offset="0x1B7A5F0", VA="0x1B7A5F0")]
			internal TrainUnitResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}