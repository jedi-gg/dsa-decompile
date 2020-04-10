using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BuyStoreItemDirectResponse : IMessage<BuyStoreItemDirectResponse>, IMessage, IEquatable<BuyStoreItemDirectResponse>, IDeepCloneable<BuyStoreItemDirectResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BuyStoreItemDirectResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CBA8", Offset="0x109CBA8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F88C30", Offset="0x1F88C30", VA="0x1F88C30")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CBC8", Offset="0x109CBC8")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1F88E00", Offset="0x1F88E00", VA="0x1F88E00")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F88E08", Offset="0x1F88E08", VA="0x1F88E08")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CB98", Offset="0x109CB98")]
		public static MessageParser<BuyStoreItemDirectResponse> Parser
		{
			[Address(RVA="0x1F88BC8", Offset="0x1F88BC8", VA="0x1F88BC8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CBB8", Offset="0x109CBB8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F88D20", Offset="0x1F88D20", VA="0x1F88D20", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F892C8", Offset="0x1F892C8", VA="0x1F892C8")]
		static BuyStoreItemDirectResponse()
		{
		}

		[Address(RVA="0x1F88D7C", Offset="0x1F88D7C", VA="0x1F88D7C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108923C", Offset="0x108923C")]
		public BuyStoreItemDirectResponse()
		{
		}

		[Address(RVA="0x1F88D84", Offset="0x1F88D84", VA="0x1F88D84")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108924C", Offset="0x108924C")]
		public BuyStoreItemDirectResponse(BuyStoreItemDirectResponse other)
		{
		}

		[Address(RVA="0x1F890A8", Offset="0x1F890A8", VA="0x1F890A8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10892BC", Offset="0x10892BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F88E10", Offset="0x1F88E10", VA="0x1F88E10", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108925C", Offset="0x108925C")]
		public BuyStoreItemDirectResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1F88E70", Offset="0x1F88E70", VA="0x1F88E70", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108926C", Offset="0x108926C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F88EE4", Offset="0x1F88EE4", VA="0x1F88EE4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108927C", Offset="0x108927C")]
		public bool Equals(BuyStoreItemDirectResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1F88F48", Offset="0x1F88F48", VA="0x1F88F48", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108928C", Offset="0x108928C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F89138", Offset="0x1F89138", VA="0x1F89138", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10892CC", Offset="0x10892CC")]
		public void MergeFrom(BuyStoreItemDirectResponse other)
		{
		}

		[Address(RVA="0x1F891EC", Offset="0x1F891EC", VA="0x1F891EC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10892DC", Offset="0x10892DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F88FA0", Offset="0x1F88FA0", VA="0x1F88FA0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108929C", Offset="0x108929C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F89008", Offset="0x1F89008", VA="0x1F89008", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10892AC", Offset="0x10892AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050BE8", Offset="0x1050BE8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BuyStoreItemDirectResponse.<>c <>9;

			[Address(RVA="0x1F893A0", Offset="0x1F893A0", VA="0x1F893A0")]
			static <>c()
			{
			}

			[Address(RVA="0x1F89404", Offset="0x1F89404", VA="0x1F89404")]
			public <>c()
			{
			}

			[Address(RVA="0x1F8940C", Offset="0x1F8940C", VA="0x1F8940C")]
			internal BuyStoreItemDirectResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}