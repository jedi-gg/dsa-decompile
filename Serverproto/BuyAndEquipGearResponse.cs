using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BuyAndEquipGearResponse : IMessage<BuyAndEquipGearResponse>, IMessage, IEquatable<BuyAndEquipGearResponse>, IDeepCloneable<BuyAndEquipGearResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BuyAndEquipGearResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099390", Offset="0x1099390")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F836D0", Offset="0x1F836D0", VA="0x1F836D0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10993B0", Offset="0x10993B0")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1F838A0", Offset="0x1F838A0", VA="0x1F838A0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F838A8", Offset="0x1F838A8", VA="0x1F838A8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099380", Offset="0x1099380")]
		public static MessageParser<BuyAndEquipGearResponse> Parser
		{
			[Address(RVA="0x1F83668", Offset="0x1F83668", VA="0x1F83668")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10993A0", Offset="0x10993A0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F837C0", Offset="0x1F837C0", VA="0x1F837C0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F83D68", Offset="0x1F83D68", VA="0x1F83D68")]
		static BuyAndEquipGearResponse()
		{
		}

		[Address(RVA="0x1F8381C", Offset="0x1F8381C", VA="0x1F8381C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082FAC", Offset="0x1082FAC")]
		public BuyAndEquipGearResponse()
		{
		}

		[Address(RVA="0x1F83824", Offset="0x1F83824", VA="0x1F83824")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082FBC", Offset="0x1082FBC")]
		public BuyAndEquipGearResponse(BuyAndEquipGearResponse other)
		{
		}

		[Address(RVA="0x1F83B48", Offset="0x1F83B48", VA="0x1F83B48", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108302C", Offset="0x108302C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F838B0", Offset="0x1F838B0", VA="0x1F838B0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082FCC", Offset="0x1082FCC")]
		public BuyAndEquipGearResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1F83910", Offset="0x1F83910", VA="0x1F83910", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082FDC", Offset="0x1082FDC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F83984", Offset="0x1F83984", VA="0x1F83984", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082FEC", Offset="0x1082FEC")]
		public bool Equals(BuyAndEquipGearResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1F839E8", Offset="0x1F839E8", VA="0x1F839E8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082FFC", Offset="0x1082FFC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F83BD8", Offset="0x1F83BD8", VA="0x1F83BD8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108303C", Offset="0x108303C")]
		public void MergeFrom(BuyAndEquipGearResponse other)
		{
		}

		[Address(RVA="0x1F83C8C", Offset="0x1F83C8C", VA="0x1F83C8C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108304C", Offset="0x108304C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F83A40", Offset="0x1F83A40", VA="0x1F83A40", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108300C", Offset="0x108300C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F83AA8", Offset="0x1F83AA8", VA="0x1F83AA8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108301C", Offset="0x108301C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10502E8", Offset="0x10502E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BuyAndEquipGearResponse.<>c <>9;

			[Address(RVA="0x1F83E40", Offset="0x1F83E40", VA="0x1F83E40")]
			static <>c()
			{
			}

			[Address(RVA="0x1F83EA4", Offset="0x1F83EA4", VA="0x1F83EA4")]
			public <>c()
			{
			}

			[Address(RVA="0x1F83EAC", Offset="0x1F83EAC", VA="0x1F83EAC")]
			internal BuyAndEquipGearResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}