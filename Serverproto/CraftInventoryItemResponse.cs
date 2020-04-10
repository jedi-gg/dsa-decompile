using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CraftInventoryItemResponse : IMessage<CraftInventoryItemResponse>, IMessage, IEquatable<CraftInventoryItemResponse>, IDeepCloneable<CraftInventoryItemResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CraftInventoryItemResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098AC0", Offset="0x1098AC0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EF37E0", Offset="0x1EF37E0", VA="0x1EF37E0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098AE0", Offset="0x1098AE0")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1EF39B0", Offset="0x1EF39B0", VA="0x1EF39B0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EF39B8", Offset="0x1EF39B8", VA="0x1EF39B8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098AB0", Offset="0x1098AB0")]
		public static MessageParser<CraftInventoryItemResponse> Parser
		{
			[Address(RVA="0x1EF3778", Offset="0x1EF3778", VA="0x1EF3778")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098AD0", Offset="0x1098AD0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EF38D0", Offset="0x1EF38D0", VA="0x1EF38D0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EF3E78", Offset="0x1EF3E78", VA="0x1EF3E78")]
		static CraftInventoryItemResponse()
		{
		}

		[Address(RVA="0x1EF392C", Offset="0x1EF392C", VA="0x1EF392C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081DCC", Offset="0x1081DCC")]
		public CraftInventoryItemResponse()
		{
		}

		[Address(RVA="0x1EF3934", Offset="0x1EF3934", VA="0x1EF3934")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081DDC", Offset="0x1081DDC")]
		public CraftInventoryItemResponse(CraftInventoryItemResponse other)
		{
		}

		[Address(RVA="0x1EF3C58", Offset="0x1EF3C58", VA="0x1EF3C58", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081E4C", Offset="0x1081E4C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EF39C0", Offset="0x1EF39C0", VA="0x1EF39C0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081DEC", Offset="0x1081DEC")]
		public CraftInventoryItemResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1EF3A20", Offset="0x1EF3A20", VA="0x1EF3A20", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081DFC", Offset="0x1081DFC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF3A94", Offset="0x1EF3A94", VA="0x1EF3A94", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081E0C", Offset="0x1081E0C")]
		public bool Equals(CraftInventoryItemResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF3AF8", Offset="0x1EF3AF8", VA="0x1EF3AF8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081E1C", Offset="0x1081E1C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EF3CE8", Offset="0x1EF3CE8", VA="0x1EF3CE8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081E5C", Offset="0x1081E5C")]
		public void MergeFrom(CraftInventoryItemResponse other)
		{
		}

		[Address(RVA="0x1EF3D9C", Offset="0x1EF3D9C", VA="0x1EF3D9C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081E6C", Offset="0x1081E6C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EF3B50", Offset="0x1EF3B50", VA="0x1EF3B50", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081E2C", Offset="0x1081E2C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EF3BB8", Offset="0x1EF3BB8", VA="0x1EF3BB8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081E3C", Offset="0x1081E3C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050148", Offset="0x1050148")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CraftInventoryItemResponse.<>c <>9;

			[Address(RVA="0x1EF3F50", Offset="0x1EF3F50", VA="0x1EF3F50")]
			static <>c()
			{
			}

			[Address(RVA="0x1EF3FB4", Offset="0x1EF3FB4", VA="0x1EF3FB4")]
			public <>c()
			{
			}

			[Address(RVA="0x1EF3FBC", Offset="0x1EF3FBC", VA="0x1EF3FBC")]
			internal CraftInventoryItemResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}