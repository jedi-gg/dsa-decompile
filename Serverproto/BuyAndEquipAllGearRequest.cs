using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BuyAndEquipAllGearRequest : IMessage<BuyAndEquipAllGearRequest>, IMessage, IEquatable<BuyAndEquipAllGearRequest>, IDeepCloneable<BuyAndEquipAllGearRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BuyAndEquipAllGearRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnitIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong unitId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10993D0", Offset="0x10993D0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DDC428", Offset="0x1DDC428", VA="0x1DDC428")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10993C0", Offset="0x10993C0")]
		public static MessageParser<BuyAndEquipAllGearRequest> Parser
		{
			[Address(RVA="0x1DDC3C0", Offset="0x1DDC3C0", VA="0x1DDC3C0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10993E0", Offset="0x10993E0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DDC518", Offset="0x1DDC518", VA="0x1DDC518", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10993F0", Offset="0x10993F0")]
		public ulong UnitId
		{
			[Address(RVA="0x1DDC640", Offset="0x1DDC640", VA="0x1DDC640")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DDC648", Offset="0x1DDC648", VA="0x1DDC648")]
			set
			{
			}
		}

		[Address(RVA="0x1DDC9BC", Offset="0x1DDC9BC", VA="0x1DDC9BC")]
		static BuyAndEquipAllGearRequest()
		{
		}

		[Address(RVA="0x1DDC574", Offset="0x1DDC574", VA="0x1DDC574")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108305C", Offset="0x108305C")]
		public BuyAndEquipAllGearRequest()
		{
		}

		[Address(RVA="0x1DDC57C", Offset="0x1DDC57C", VA="0x1DDC57C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108306C", Offset="0x108306C")]
		public BuyAndEquipAllGearRequest(BuyAndEquipAllGearRequest other)
		{
		}

		[Address(RVA="0x1DDC870", Offset="0x1DDC870", VA="0x1DDC870", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10830DC", Offset="0x10830DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DDC5E0", Offset="0x1DDC5E0", VA="0x1DDC5E0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108307C", Offset="0x108307C")]
		public BuyAndEquipAllGearRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1DDC650", Offset="0x1DDC650", VA="0x1DDC650", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108308C", Offset="0x108308C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DDC6C4", Offset="0x1DDC6C4", VA="0x1DDC6C4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108309C", Offset="0x108309C")]
		public bool Equals(BuyAndEquipAllGearRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1DDC700", Offset="0x1DDC700", VA="0x1DDC700", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10830AC", Offset="0x10830AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DDC900", Offset="0x1DDC900", VA="0x1DDC900", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10830EC", Offset="0x10830EC")]
		public void MergeFrom(BuyAndEquipAllGearRequest other)
		{
		}

		[Address(RVA="0x1DDC940", Offset="0x1DDC940", VA="0x1DDC940", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10830FC", Offset="0x10830FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DDC768", Offset="0x1DDC768", VA="0x1DDC768", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10830BC", Offset="0x10830BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DDC7D0", Offset="0x1DDC7D0", VA="0x1DDC7D0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10830CC", Offset="0x10830CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10502F8", Offset="0x10502F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BuyAndEquipAllGearRequest.<>c <>9;

			[Address(RVA="0x1DDCA94", Offset="0x1DDCA94", VA="0x1DDCA94")]
			static <>c()
			{
			}

			[Address(RVA="0x1DDCAF8", Offset="0x1DDCAF8", VA="0x1DDCAF8")]
			public <>c()
			{
			}

			[Address(RVA="0x1DDCB00", Offset="0x1DDCB00", VA="0x1DDCB00")]
			internal BuyAndEquipAllGearRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}