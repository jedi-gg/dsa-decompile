using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class AdRewardedEnergyResponse : IMessage<AdRewardedEnergyResponse>, IMessage, IEquatable<AdRewardedEnergyResponse>, IDeepCloneable<AdRewardedEnergyResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<AdRewardedEnergyResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int DailyAdRewardCountFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong dailyAdRewardCount_;

		[FieldOffset(Offset="0x0")]
		public const int EnergyItemIdFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong energyItemId_;

		[FieldOffset(Offset="0x0")]
		public const int ValidatedFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private bool validated_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B180", Offset="0x109B180")]
		public ulong DailyAdRewardCount
		{
			[Address(RVA="0x160654C", Offset="0x160654C", VA="0x160654C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1606554", Offset="0x1606554", VA="0x1606554")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B150", Offset="0x109B150")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x16062F4", Offset="0x16062F4", VA="0x16062F4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B190", Offset="0x109B190")]
		public ulong EnergyItemId
		{
			[Address(RVA="0x160655C", Offset="0x160655C", VA="0x160655C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1606564", Offset="0x1606564", VA="0x1606564")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B170", Offset="0x109B170")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x16064DC", Offset="0x16064DC", VA="0x16064DC")]
			get
			{
				return null;
			}
			[Address(RVA="0x16064E4", Offset="0x16064E4", VA="0x16064E4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B140", Offset="0x109B140")]
		public static MessageParser<AdRewardedEnergyResponse> Parser
		{
			[Address(RVA="0x160628C", Offset="0x160628C", VA="0x160628C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B160", Offset="0x109B160")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x16063E4", Offset="0x16063E4", VA="0x16063E4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B1A0", Offset="0x109B1A0")]
		public bool Validated
		{
			[Address(RVA="0x160656C", Offset="0x160656C", VA="0x160656C")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1606574", Offset="0x1606574", VA="0x1606574")]
			set
			{
			}
		}

		[Address(RVA="0x1606CCC", Offset="0x1606CCC", VA="0x1606CCC")]
		static AdRewardedEnergyResponse()
		{
		}

		[Address(RVA="0x1606440", Offset="0x1606440", VA="0x1606440")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108658C", Offset="0x108658C")]
		public AdRewardedEnergyResponse()
		{
		}

		[Address(RVA="0x1606448", Offset="0x1606448", VA="0x1606448")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108659C", Offset="0x108659C")]
		public AdRewardedEnergyResponse(AdRewardedEnergyResponse other)
		{
		}

		[Address(RVA="0x160696C", Offset="0x160696C", VA="0x160696C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108660C", Offset="0x108660C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x16064EC", Offset="0x16064EC", VA="0x16064EC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10865AC", Offset="0x10865AC")]
		public AdRewardedEnergyResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1606580", Offset="0x1606580", VA="0x1606580", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10865BC", Offset="0x10865BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x16065F4", Offset="0x16065F4", VA="0x16065F4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10865CC", Offset="0x10865CC")]
		public bool Equals(AdRewardedEnergyResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1606698", Offset="0x1606698", VA="0x1606698", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10865DC", Offset="0x10865DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1606A94", Offset="0x1606A94", VA="0x1606A94", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108661C", Offset="0x108661C")]
		public void MergeFrom(AdRewardedEnergyResponse other)
		{
		}

		[Address(RVA="0x1606B6C", Offset="0x1606B6C", VA="0x1606B6C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108662C", Offset="0x108662C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1606758", Offset="0x1606758", VA="0x1606758", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10865EC", Offset="0x10865EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x16067C0", Offset="0x16067C0", VA="0x16067C0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10865FC", Offset="0x10865FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10507C8", Offset="0x10507C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AdRewardedEnergyResponse.<>c <>9;

			[Address(RVA="0x1606DA4", Offset="0x1606DA4", VA="0x1606DA4")]
			static <>c()
			{
			}

			[Address(RVA="0x1606E08", Offset="0x1606E08", VA="0x1606E08")]
			public <>c()
			{
			}

			[Address(RVA="0x1606E10", Offset="0x1606E10", VA="0x1606E10")]
			internal AdRewardedEnergyResponse <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}