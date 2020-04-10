using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BuyAndEquipAllGearResponse : IMessage<BuyAndEquipAllGearResponse>, IMessage, IEquatable<BuyAndEquipAllGearResponse>, IDeepCloneable<BuyAndEquipAllGearResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BuyAndEquipAllGearResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099410", Offset="0x1099410")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F8256C", Offset="0x1F8256C", VA="0x1F8256C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099430", Offset="0x1099430")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1F8273C", Offset="0x1F8273C", VA="0x1F8273C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F82744", Offset="0x1F82744", VA="0x1F82744")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099400", Offset="0x1099400")]
		public static MessageParser<BuyAndEquipAllGearResponse> Parser
		{
			[Address(RVA="0x1F82504", Offset="0x1F82504", VA="0x1F82504")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099420", Offset="0x1099420")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F8265C", Offset="0x1F8265C", VA="0x1F8265C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F82C04", Offset="0x1F82C04", VA="0x1F82C04")]
		static BuyAndEquipAllGearResponse()
		{
		}

		[Address(RVA="0x1F826B8", Offset="0x1F826B8", VA="0x1F826B8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108310C", Offset="0x108310C")]
		public BuyAndEquipAllGearResponse()
		{
		}

		[Address(RVA="0x1F826C0", Offset="0x1F826C0", VA="0x1F826C0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108311C", Offset="0x108311C")]
		public BuyAndEquipAllGearResponse(BuyAndEquipAllGearResponse other)
		{
		}

		[Address(RVA="0x1F829E4", Offset="0x1F829E4", VA="0x1F829E4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108318C", Offset="0x108318C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F8274C", Offset="0x1F8274C", VA="0x1F8274C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108312C", Offset="0x108312C")]
		public BuyAndEquipAllGearResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1F827AC", Offset="0x1F827AC", VA="0x1F827AC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108313C", Offset="0x108313C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F82820", Offset="0x1F82820", VA="0x1F82820", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108314C", Offset="0x108314C")]
		public bool Equals(BuyAndEquipAllGearResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1F82884", Offset="0x1F82884", VA="0x1F82884", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108315C", Offset="0x108315C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F82A74", Offset="0x1F82A74", VA="0x1F82A74", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108319C", Offset="0x108319C")]
		public void MergeFrom(BuyAndEquipAllGearResponse other)
		{
		}

		[Address(RVA="0x1F82B28", Offset="0x1F82B28", VA="0x1F82B28", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10831AC", Offset="0x10831AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F828DC", Offset="0x1F828DC", VA="0x1F828DC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108316C", Offset="0x108316C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F82944", Offset="0x1F82944", VA="0x1F82944", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108317C", Offset="0x108317C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050308", Offset="0x1050308")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BuyAndEquipAllGearResponse.<>c <>9;

			[Address(RVA="0x1F82CDC", Offset="0x1F82CDC", VA="0x1F82CDC")]
			static <>c()
			{
			}

			[Address(RVA="0x1F82D40", Offset="0x1F82D40", VA="0x1F82D40")]
			public <>c()
			{
			}

			[Address(RVA="0x1F82D48", Offset="0x1F82D48", VA="0x1F82D48")]
			internal BuyAndEquipAllGearResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}