using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InventoryItemConversion : IMessage<InventoryItemConversion>, IMessage, IEquatable<InventoryItemConversion>, IDeepCloneable<InventoryItemConversion>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InventoryItemConversion> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int FromFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private InventoryItem from_;

		[FieldOffset(Offset="0x0")]
		public const int ToFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private InventoryItem to_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098800", Offset="0x1098800")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A898A4", Offset="0x1A898A4", VA="0x1A898A4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098820", Offset="0x1098820")]
		public InventoryItem From
		{
			[Address(RVA="0x1A89A7C", Offset="0x1A89A7C", VA="0x1A89A7C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A89A84", Offset="0x1A89A84", VA="0x1A89A84")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10987F0", Offset="0x10987F0")]
		public static MessageParser<InventoryItemConversion> Parser
		{
			[Address(RVA="0x1A8983C", Offset="0x1A8983C", VA="0x1A8983C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098810", Offset="0x1098810")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A89990", Offset="0x1A89990", VA="0x1A89990", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098830", Offset="0x1098830")]
		public InventoryItem To
		{
			[Address(RVA="0x1A89A8C", Offset="0x1A89A8C", VA="0x1A89A8C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A89A94", Offset="0x1A89A94", VA="0x1A89A94")]
			set
			{
			}
		}

		[Address(RVA="0x1A8A09C", Offset="0x1A8A09C", VA="0x1A8A09C")]
		static InventoryItemConversion()
		{
		}

		[Address(RVA="0x1A899EC", Offset="0x1A899EC", VA="0x1A899EC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108179C", Offset="0x108179C")]
		public InventoryItemConversion()
		{
		}

		[Address(RVA="0x1A899F4", Offset="0x1A899F4", VA="0x1A899F4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10817AC", Offset="0x10817AC")]
		public InventoryItemConversion(InventoryItemConversion other)
		{
		}

		[Address(RVA="0x1A89DB8", Offset="0x1A89DB8", VA="0x1A89DB8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108181C", Offset="0x108181C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A89A9C", Offset="0x1A89A9C", VA="0x1A89A9C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10817BC", Offset="0x10817BC")]
		public InventoryItemConversion Clone()
		{
			return null;
		}

		[Address(RVA="0x1A89AFC", Offset="0x1A89AFC", VA="0x1A89AFC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10817CC", Offset="0x10817CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A89B70", Offset="0x1A89B70", VA="0x1A89B70", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10817DC", Offset="0x10817DC")]
		public bool Equals(InventoryItemConversion other)
		{
			return new bool();
		}

		[Address(RVA="0x1A89BE8", Offset="0x1A89BE8", VA="0x1A89BE8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10817EC", Offset="0x10817EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A89E8C", Offset="0x1A89E8C", VA="0x1A89E8C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108182C", Offset="0x108182C")]
		public void MergeFrom(InventoryItemConversion other)
		{
		}

		[Address(RVA="0x1A89F88", Offset="0x1A89F88", VA="0x1A89F88", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108183C", Offset="0x108183C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A89C58", Offset="0x1A89C58", VA="0x1A89C58", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10817FC", Offset="0x10817FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A89CC0", Offset="0x1A89CC0", VA="0x1A89CC0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108180C", Offset="0x108180C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10500B8", Offset="0x10500B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InventoryItemConversion.<>c <>9;

			[Address(RVA="0x1A8A174", Offset="0x1A8A174", VA="0x1A8A174")]
			static <>c()
			{
			}

			[Address(RVA="0x1A8A1D8", Offset="0x1A8A1D8", VA="0x1A8A1D8")]
			public <>c()
			{
			}

			[Address(RVA="0x1A8A1E0", Offset="0x1A8A1E0", VA="0x1A8A1E0")]
			internal InventoryItemConversion <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}