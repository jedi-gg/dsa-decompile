using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class UnequipSorcererStoneResponse : IMessage<UnequipSorcererStoneResponse>, IMessage, IEquatable<UnequipSorcererStoneResponse>, IDeepCloneable<UnequipSorcererStoneResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<UnequipSorcererStoneResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099270", Offset="0x1099270")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x14B03B4", Offset="0x14B03B4", VA="0x14B03B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099290", Offset="0x1099290")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x14B0584", Offset="0x14B0584", VA="0x14B0584")]
			get
			{
				return null;
			}
			[Address(RVA="0x14B058C", Offset="0x14B058C", VA="0x14B058C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099260", Offset="0x1099260")]
		public static MessageParser<UnequipSorcererStoneResponse> Parser
		{
			[Address(RVA="0x14B034C", Offset="0x14B034C", VA="0x14B034C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099280", Offset="0x1099280")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x14B04A4", Offset="0x14B04A4", VA="0x14B04A4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x14B0A4C", Offset="0x14B0A4C", VA="0x14B0A4C")]
		static UnequipSorcererStoneResponse()
		{
		}

		[Address(RVA="0x14B0500", Offset="0x14B0500", VA="0x14B0500")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082CEC", Offset="0x1082CEC")]
		public UnequipSorcererStoneResponse()
		{
		}

		[Address(RVA="0x14B0508", Offset="0x14B0508", VA="0x14B0508")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082CFC", Offset="0x1082CFC")]
		public UnequipSorcererStoneResponse(UnequipSorcererStoneResponse other)
		{
		}

		[Address(RVA="0x14B082C", Offset="0x14B082C", VA="0x14B082C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082D6C", Offset="0x1082D6C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x14B0594", Offset="0x14B0594", VA="0x14B0594", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082D0C", Offset="0x1082D0C")]
		public UnequipSorcererStoneResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x14B05F4", Offset="0x14B05F4", VA="0x14B05F4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082D1C", Offset="0x1082D1C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x14B0668", Offset="0x14B0668", VA="0x14B0668", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082D2C", Offset="0x1082D2C")]
		public bool Equals(UnequipSorcererStoneResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x14B06CC", Offset="0x14B06CC", VA="0x14B06CC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082D3C", Offset="0x1082D3C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x14B08BC", Offset="0x14B08BC", VA="0x14B08BC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082D7C", Offset="0x1082D7C")]
		public void MergeFrom(UnequipSorcererStoneResponse other)
		{
		}

		[Address(RVA="0x14B0970", Offset="0x14B0970", VA="0x14B0970", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082D8C", Offset="0x1082D8C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x14B0724", Offset="0x14B0724", VA="0x14B0724", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082D4C", Offset="0x1082D4C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x14B078C", Offset="0x14B078C", VA="0x14B078C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082D5C", Offset="0x1082D5C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10502A8", Offset="0x10502A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static UnequipSorcererStoneResponse.<>c <>9;

			[Address(RVA="0x14B0B24", Offset="0x14B0B24", VA="0x14B0B24")]
			static <>c()
			{
			}

			[Address(RVA="0x14B0B88", Offset="0x14B0B88", VA="0x14B0B88")]
			public <>c()
			{
			}

			[Address(RVA="0x14B0B90", Offset="0x14B0B90", VA="0x14B0B90")]
			internal UnequipSorcererStoneResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}