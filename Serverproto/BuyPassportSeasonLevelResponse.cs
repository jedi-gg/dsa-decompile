using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BuyPassportSeasonLevelResponse : IMessage<BuyPassportSeasonLevelResponse>, IMessage, IEquatable<BuyPassportSeasonLevelResponse>, IDeepCloneable<BuyPassportSeasonLevelResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BuyPassportSeasonLevelResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B1F0", Offset="0x109B1F0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F85428", Offset="0x1F85428", VA="0x1F85428")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B210", Offset="0x109B210")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1F855F8", Offset="0x1F855F8", VA="0x1F855F8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F85600", Offset="0x1F85600", VA="0x1F85600")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B1E0", Offset="0x109B1E0")]
		public static MessageParser<BuyPassportSeasonLevelResponse> Parser
		{
			[Address(RVA="0x1F853C0", Offset="0x1F853C0", VA="0x1F853C0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B200", Offset="0x109B200")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F85518", Offset="0x1F85518", VA="0x1F85518", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F85AC0", Offset="0x1F85AC0", VA="0x1F85AC0")]
		static BuyPassportSeasonLevelResponse()
		{
		}

		[Address(RVA="0x1F85574", Offset="0x1F85574", VA="0x1F85574")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10866EC", Offset="0x10866EC")]
		public BuyPassportSeasonLevelResponse()
		{
		}

		[Address(RVA="0x1F8557C", Offset="0x1F8557C", VA="0x1F8557C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10866FC", Offset="0x10866FC")]
		public BuyPassportSeasonLevelResponse(BuyPassportSeasonLevelResponse other)
		{
		}

		[Address(RVA="0x1F858A0", Offset="0x1F858A0", VA="0x1F858A0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108676C", Offset="0x108676C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F85608", Offset="0x1F85608", VA="0x1F85608", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108670C", Offset="0x108670C")]
		public BuyPassportSeasonLevelResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1F85668", Offset="0x1F85668", VA="0x1F85668", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108671C", Offset="0x108671C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F856DC", Offset="0x1F856DC", VA="0x1F856DC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108672C", Offset="0x108672C")]
		public bool Equals(BuyPassportSeasonLevelResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1F85740", Offset="0x1F85740", VA="0x1F85740", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108673C", Offset="0x108673C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F85930", Offset="0x1F85930", VA="0x1F85930", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108677C", Offset="0x108677C")]
		public void MergeFrom(BuyPassportSeasonLevelResponse other)
		{
		}

		[Address(RVA="0x1F859E4", Offset="0x1F859E4", VA="0x1F859E4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108678C", Offset="0x108678C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F85798", Offset="0x1F85798", VA="0x1F85798", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108674C", Offset="0x108674C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F85800", Offset="0x1F85800", VA="0x1F85800", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108675C", Offset="0x108675C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10507E8", Offset="0x10507E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BuyPassportSeasonLevelResponse.<>c <>9;

			[Address(RVA="0x1F85B98", Offset="0x1F85B98", VA="0x1F85B98")]
			static <>c()
			{
			}

			[Address(RVA="0x1F85BFC", Offset="0x1F85BFC", VA="0x1F85BFC")]
			public <>c()
			{
			}

			[Address(RVA="0x1F85C04", Offset="0x1F85C04", VA="0x1F85C04")]
			internal BuyPassportSeasonLevelResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}