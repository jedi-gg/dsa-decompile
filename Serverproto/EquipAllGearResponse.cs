using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EquipAllGearResponse : IMessage<EquipAllGearResponse>, IMessage, IEquatable<EquipAllGearResponse>, IDeepCloneable<EquipAllGearResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EquipAllGearResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098BD0", Offset="0x1098BD0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FC2434", Offset="0x1FC2434", VA="0x1FC2434")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098BF0", Offset="0x1098BF0")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1FC2604", Offset="0x1FC2604", VA="0x1FC2604")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FC260C", Offset="0x1FC260C", VA="0x1FC260C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098BC0", Offset="0x1098BC0")]
		public static MessageParser<EquipAllGearResponse> Parser
		{
			[Address(RVA="0x1FC23CC", Offset="0x1FC23CC", VA="0x1FC23CC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098BE0", Offset="0x1098BE0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FC2524", Offset="0x1FC2524", VA="0x1FC2524", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FC2ACC", Offset="0x1FC2ACC", VA="0x1FC2ACC")]
		static EquipAllGearResponse()
		{
		}

		[Address(RVA="0x1FC2580", Offset="0x1FC2580", VA="0x1FC2580")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108208C", Offset="0x108208C")]
		public EquipAllGearResponse()
		{
		}

		[Address(RVA="0x1FC2588", Offset="0x1FC2588", VA="0x1FC2588")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108209C", Offset="0x108209C")]
		public EquipAllGearResponse(EquipAllGearResponse other)
		{
		}

		[Address(RVA="0x1FC28AC", Offset="0x1FC28AC", VA="0x1FC28AC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108210C", Offset="0x108210C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FC2614", Offset="0x1FC2614", VA="0x1FC2614", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10820AC", Offset="0x10820AC")]
		public EquipAllGearResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1FC2674", Offset="0x1FC2674", VA="0x1FC2674", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10820BC", Offset="0x10820BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC26E8", Offset="0x1FC26E8", VA="0x1FC26E8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10820CC", Offset="0x10820CC")]
		public bool Equals(EquipAllGearResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC274C", Offset="0x1FC274C", VA="0x1FC274C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10820DC", Offset="0x10820DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FC293C", Offset="0x1FC293C", VA="0x1FC293C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108211C", Offset="0x108211C")]
		public void MergeFrom(EquipAllGearResponse other)
		{
		}

		[Address(RVA="0x1FC29F0", Offset="0x1FC29F0", VA="0x1FC29F0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108212C", Offset="0x108212C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FC27A4", Offset="0x1FC27A4", VA="0x1FC27A4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10820EC", Offset="0x10820EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FC280C", Offset="0x1FC280C", VA="0x1FC280C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10820FC", Offset="0x10820FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050188", Offset="0x1050188")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EquipAllGearResponse.<>c <>9;

			[Address(RVA="0x1FC2BA4", Offset="0x1FC2BA4", VA="0x1FC2BA4")]
			static <>c()
			{
			}

			[Address(RVA="0x1FC2C08", Offset="0x1FC2C08", VA="0x1FC2C08")]
			public <>c()
			{
			}

			[Address(RVA="0x1FC2C10", Offset="0x1FC2C10", VA="0x1FC2C10")]
			internal EquipAllGearResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}