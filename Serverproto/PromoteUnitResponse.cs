using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PromoteUnitResponse : IMessage<PromoteUnitResponse>, IMessage, IEquatable<PromoteUnitResponse>, IDeepCloneable<PromoteUnitResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PromoteUnitResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098920", Offset="0x1098920")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x2011130", Offset="0x2011130", VA="0x2011130")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098940", Offset="0x1098940")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x2011300", Offset="0x2011300", VA="0x2011300")]
			get
			{
				return null;
			}
			[Address(RVA="0x2011308", Offset="0x2011308", VA="0x2011308")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098910", Offset="0x1098910")]
		public static MessageParser<PromoteUnitResponse> Parser
		{
			[Address(RVA="0x20110C8", Offset="0x20110C8", VA="0x20110C8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098930", Offset="0x1098930")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x2011220", Offset="0x2011220", VA="0x2011220", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x20117C8", Offset="0x20117C8", VA="0x20117C8")]
		static PromoteUnitResponse()
		{
		}

		[Address(RVA="0x201127C", Offset="0x201127C", VA="0x201127C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10819AC", Offset="0x10819AC")]
		public PromoteUnitResponse()
		{
		}

		[Address(RVA="0x2011284", Offset="0x2011284", VA="0x2011284")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10819BC", Offset="0x10819BC")]
		public PromoteUnitResponse(PromoteUnitResponse other)
		{
		}

		[Address(RVA="0x20115A8", Offset="0x20115A8", VA="0x20115A8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081A2C", Offset="0x1081A2C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x2011310", Offset="0x2011310", VA="0x2011310", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10819CC", Offset="0x10819CC")]
		public PromoteUnitResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x2011370", Offset="0x2011370", VA="0x2011370", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10819DC", Offset="0x10819DC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x20113E4", Offset="0x20113E4", VA="0x20113E4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10819EC", Offset="0x10819EC")]
		public bool Equals(PromoteUnitResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x2011448", Offset="0x2011448", VA="0x2011448", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10819FC", Offset="0x10819FC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2011638", Offset="0x2011638", VA="0x2011638", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081A3C", Offset="0x1081A3C")]
		public void MergeFrom(PromoteUnitResponse other)
		{
		}

		[Address(RVA="0x20116EC", Offset="0x20116EC", VA="0x20116EC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081A4C", Offset="0x1081A4C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x20114A0", Offset="0x20114A0", VA="0x20114A0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081A0C", Offset="0x1081A0C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x2011508", Offset="0x2011508", VA="0x2011508", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081A1C", Offset="0x1081A1C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10500E8", Offset="0x10500E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PromoteUnitResponse.<>c <>9;

			[Address(RVA="0x20118A0", Offset="0x20118A0", VA="0x20118A0")]
			static <>c()
			{
			}

			[Address(RVA="0x2011904", Offset="0x2011904", VA="0x2011904")]
			public <>c()
			{
			}

			[Address(RVA="0x201190C", Offset="0x201190C", VA="0x201190C")]
			internal PromoteUnitResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}