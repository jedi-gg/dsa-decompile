using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CraftInventoryItemRequest : IMessage<CraftInventoryItemRequest>, IMessage, IEquatable<CraftInventoryItemRequest>, IDeepCloneable<CraftInventoryItemRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CraftInventoryItemRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ItemIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong itemId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098A80", Offset="0x1098A80")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EF3044", Offset="0x1EF3044", VA="0x1EF3044")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098AA0", Offset="0x1098AA0")]
		public ulong ItemId
		{
			[Address(RVA="0x1EF325C", Offset="0x1EF325C", VA="0x1EF325C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EF3264", Offset="0x1EF3264", VA="0x1EF3264")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098A70", Offset="0x1098A70")]
		public static MessageParser<CraftInventoryItemRequest> Parser
		{
			[Address(RVA="0x1EF2FDC", Offset="0x1EF2FDC", VA="0x1EF2FDC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098A90", Offset="0x1098A90")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EF3134", Offset="0x1EF3134", VA="0x1EF3134", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EF35D8", Offset="0x1EF35D8", VA="0x1EF35D8")]
		static CraftInventoryItemRequest()
		{
		}

		[Address(RVA="0x1EF3190", Offset="0x1EF3190", VA="0x1EF3190")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081D1C", Offset="0x1081D1C")]
		public CraftInventoryItemRequest()
		{
		}

		[Address(RVA="0x1EF3198", Offset="0x1EF3198", VA="0x1EF3198")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081D2C", Offset="0x1081D2C")]
		public CraftInventoryItemRequest(CraftInventoryItemRequest other)
		{
		}

		[Address(RVA="0x1EF348C", Offset="0x1EF348C", VA="0x1EF348C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081D9C", Offset="0x1081D9C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EF31FC", Offset="0x1EF31FC", VA="0x1EF31FC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081D3C", Offset="0x1081D3C")]
		public CraftInventoryItemRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1EF326C", Offset="0x1EF326C", VA="0x1EF326C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081D4C", Offset="0x1081D4C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF32E0", Offset="0x1EF32E0", VA="0x1EF32E0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081D5C", Offset="0x1081D5C")]
		public bool Equals(CraftInventoryItemRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF331C", Offset="0x1EF331C", VA="0x1EF331C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081D6C", Offset="0x1081D6C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EF351C", Offset="0x1EF351C", VA="0x1EF351C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081DAC", Offset="0x1081DAC")]
		public void MergeFrom(CraftInventoryItemRequest other)
		{
		}

		[Address(RVA="0x1EF355C", Offset="0x1EF355C", VA="0x1EF355C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081DBC", Offset="0x1081DBC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EF3384", Offset="0x1EF3384", VA="0x1EF3384", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081D7C", Offset="0x1081D7C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EF33EC", Offset="0x1EF33EC", VA="0x1EF33EC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081D8C", Offset="0x1081D8C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050138", Offset="0x1050138")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CraftInventoryItemRequest.<>c <>9;

			[Address(RVA="0x1EF36B0", Offset="0x1EF36B0", VA="0x1EF36B0")]
			static <>c()
			{
			}

			[Address(RVA="0x1EF3714", Offset="0x1EF3714", VA="0x1EF3714")]
			public <>c()
			{
			}

			[Address(RVA="0x1EF371C", Offset="0x1EF371C", VA="0x1EF371C")]
			internal CraftInventoryItemRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}