using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClaimDailyEnergyGiftResponse : IMessage<ClaimDailyEnergyGiftResponse>, IMessage, IEquatable<ClaimDailyEnergyGiftResponse>, IDeepCloneable<ClaimDailyEnergyGiftResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClaimDailyEnergyGiftResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int DailyGiftsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<PlayerEnergyDailyGifts> _repeated_dailyGifts_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<PlayerEnergyDailyGifts> dailyGifts_;

		[FieldOffset(Offset="0x0")]
		public const int EnergyItemIdFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong energyItemId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A550", Offset="0x109A550")]
		public RepeatedField<PlayerEnergyDailyGifts> DailyGifts
		{
			[Address(RVA="0x1A42010", Offset="0x1A42010", VA="0x1A42010")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A520", Offset="0x109A520")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A41D14", Offset="0x1A41D14", VA="0x1A41D14")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A560", Offset="0x109A560")]
		public ulong EnergyItemId
		{
			[Address(RVA="0x1A42018", Offset="0x1A42018", VA="0x1A42018")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A42020", Offset="0x1A42020", VA="0x1A42020")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A540", Offset="0x109A540")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1A41FA0", Offset="0x1A41FA0", VA="0x1A41FA0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A41FA8", Offset="0x1A41FA8", VA="0x1A41FA8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A510", Offset="0x109A510")]
		public static MessageParser<ClaimDailyEnergyGiftResponse> Parser
		{
			[Address(RVA="0x1A41CAC", Offset="0x1A41CAC", VA="0x1A41CAC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A530", Offset="0x109A530")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A41E04", Offset="0x1A41E04", VA="0x1A41E04", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A42780", Offset="0x1A42780", VA="0x1A42780")]
		static ClaimDailyEnergyGiftResponse()
		{
		}

		[Address(RVA="0x1A41E60", Offset="0x1A41E60", VA="0x1A41E60")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10845EC", Offset="0x10845EC")]
		public ClaimDailyEnergyGiftResponse()
		{
		}

		[Address(RVA="0x1A41ED0", Offset="0x1A41ED0", VA="0x1A41ED0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10845FC", Offset="0x10845FC")]
		public ClaimDailyEnergyGiftResponse(ClaimDailyEnergyGiftResponse other)
		{
		}

		[Address(RVA="0x1A423F0", Offset="0x1A423F0", VA="0x1A423F0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108466C", Offset="0x108466C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A41FB0", Offset="0x1A41FB0", VA="0x1A41FB0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108460C", Offset="0x108460C")]
		public ClaimDailyEnergyGiftResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A42028", Offset="0x1A42028", VA="0x1A42028", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108461C", Offset="0x108461C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A4209C", Offset="0x1A4209C", VA="0x1A4209C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108462C", Offset="0x108462C")]
		public bool Equals(ClaimDailyEnergyGiftResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A42170", Offset="0x1A42170", VA="0x1A42170", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108463C", Offset="0x108463C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A42524", Offset="0x1A42524", VA="0x1A42524", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108467C", Offset="0x108467C")]
		public void MergeFrom(ClaimDailyEnergyGiftResponse other)
		{
		}

		[Address(RVA="0x1A42610", Offset="0x1A42610", VA="0x1A42610", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108468C", Offset="0x108468C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A42214", Offset="0x1A42214", VA="0x1A42214", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108464C", Offset="0x108464C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A4227C", Offset="0x1A4227C", VA="0x1A4227C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108465C", Offset="0x108465C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10504E8", Offset="0x10504E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClaimDailyEnergyGiftResponse.<>c <>9;

			[Address(RVA="0x1A428A4", Offset="0x1A428A4", VA="0x1A428A4")]
			static <>c()
			{
			}

			[Address(RVA="0x1A42908", Offset="0x1A42908", VA="0x1A42908")]
			public <>c()
			{
			}

			[Address(RVA="0x1A42910", Offset="0x1A42910", VA="0x1A42910")]
			internal ClaimDailyEnergyGiftResponse <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}