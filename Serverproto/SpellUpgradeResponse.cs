using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class SpellUpgradeResponse : IMessage<SpellUpgradeResponse>, IMessage, IEquatable<SpellUpgradeResponse>, IDeepCloneable<SpellUpgradeResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<SpellUpgradeResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099060", Offset="0x1099060")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BD9084", Offset="0x1BD9084", VA="0x1BD9084")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099080", Offset="0x1099080")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1BD9254", Offset="0x1BD9254", VA="0x1BD9254")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BD925C", Offset="0x1BD925C", VA="0x1BD925C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099050", Offset="0x1099050")]
		public static MessageParser<SpellUpgradeResponse> Parser
		{
			[Address(RVA="0x1BD901C", Offset="0x1BD901C", VA="0x1BD901C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099070", Offset="0x1099070")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BD9174", Offset="0x1BD9174", VA="0x1BD9174", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BD971C", Offset="0x1BD971C", VA="0x1BD971C")]
		static SpellUpgradeResponse()
		{
		}

		[Address(RVA="0x1BD91D0", Offset="0x1BD91D0", VA="0x1BD91D0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108276C", Offset="0x108276C")]
		public SpellUpgradeResponse()
		{
		}

		[Address(RVA="0x1BD91D8", Offset="0x1BD91D8", VA="0x1BD91D8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108277C", Offset="0x108277C")]
		public SpellUpgradeResponse(SpellUpgradeResponse other)
		{
		}

		[Address(RVA="0x1BD94FC", Offset="0x1BD94FC", VA="0x1BD94FC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10827EC", Offset="0x10827EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BD9264", Offset="0x1BD9264", VA="0x1BD9264", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108278C", Offset="0x108278C")]
		public SpellUpgradeResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BD92C4", Offset="0x1BD92C4", VA="0x1BD92C4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108279C", Offset="0x108279C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD9338", Offset="0x1BD9338", VA="0x1BD9338", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10827AC", Offset="0x10827AC")]
		public bool Equals(SpellUpgradeResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD939C", Offset="0x1BD939C", VA="0x1BD939C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10827BC", Offset="0x10827BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BD958C", Offset="0x1BD958C", VA="0x1BD958C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10827FC", Offset="0x10827FC")]
		public void MergeFrom(SpellUpgradeResponse other)
		{
		}

		[Address(RVA="0x1BD9640", Offset="0x1BD9640", VA="0x1BD9640", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108280C", Offset="0x108280C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BD93F4", Offset="0x1BD93F4", VA="0x1BD93F4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10827CC", Offset="0x10827CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BD945C", Offset="0x1BD945C", VA="0x1BD945C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10827DC", Offset="0x10827DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050228", Offset="0x1050228")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static SpellUpgradeResponse.<>c <>9;

			[Address(RVA="0x1BD97F4", Offset="0x1BD97F4", VA="0x1BD97F4")]
			static <>c()
			{
			}

			[Address(RVA="0x1BD9858", Offset="0x1BD9858", VA="0x1BD9858")]
			public <>c()
			{
			}

			[Address(RVA="0x1BD9860", Offset="0x1BD9860", VA="0x1BD9860")]
			internal SpellUpgradeResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}