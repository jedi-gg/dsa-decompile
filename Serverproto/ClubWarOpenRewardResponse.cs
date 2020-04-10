using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarOpenRewardResponse : IMessage<ClubWarOpenRewardResponse>, IMessage, IEquatable<ClubWarOpenRewardResponse>, IDeepCloneable<ClubWarOpenRewardResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarOpenRewardResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int RewardFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ClubWarReward reward_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096300", Offset="0x1096300")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B26A70", Offset="0x1B26A70", VA="0x1B26A70")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096320", Offset="0x1096320")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1B15A40", Offset="0x1B15A40", VA="0x1B15A40")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B26C50", Offset="0x1B26C50", VA="0x1B26C50")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10962F0", Offset="0x10962F0")]
		public static MessageParser<ClubWarOpenRewardResponse> Parser
		{
			[Address(RVA="0x1B26A08", Offset="0x1B26A08", VA="0x1B26A08")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096310", Offset="0x1096310")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B26B60", Offset="0x1B26B60", VA="0x1B26B60", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096330", Offset="0x1096330")]
		public ClubWarReward Reward
		{
			[Address(RVA="0x1B26C58", Offset="0x1B26C58", VA="0x1B26C58")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B26CC0", Offset="0x1B26CC0", VA="0x1B26CC0")]
			set
			{
			}
		}

		[Address(RVA="0x1B274C4", Offset="0x1B274C4", VA="0x1B274C4")]
		static ClubWarOpenRewardResponse()
		{
		}

		[Address(RVA="0x1B26BBC", Offset="0x1B26BBC", VA="0x1B26BBC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E40C", Offset="0x107E40C")]
		public ClubWarOpenRewardResponse()
		{
		}

		[Address(RVA="0x1B26BC4", Offset="0x1B26BC4", VA="0x1B26BC4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E41C", Offset="0x107E41C")]
		public ClubWarOpenRewardResponse(ClubWarOpenRewardResponse other)
		{
		}

		[Address(RVA="0x1B26FE4", Offset="0x1B26FE4", VA="0x1B26FE4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E48C", Offset="0x107E48C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B26CC8", Offset="0x1B26CC8", VA="0x1B26CC8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E42C", Offset="0x107E42C")]
		public ClubWarOpenRewardResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B26D28", Offset="0x1B26D28", VA="0x1B26D28", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E43C", Offset="0x107E43C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B26D9C", Offset="0x1B26D9C", VA="0x1B26D9C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E44C", Offset="0x107E44C")]
		public bool Equals(ClubWarOpenRewardResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B26E14", Offset="0x1B26E14", VA="0x1B26E14", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E45C", Offset="0x107E45C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B270B8", Offset="0x1B270B8", VA="0x1B270B8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E49C", Offset="0x107E49C")]
		public void MergeFrom(ClubWarOpenRewardResponse other)
		{
		}

		[Address(RVA="0x1B273B4", Offset="0x1B273B4", VA="0x1B273B4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E4AC", Offset="0x107E4AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B26E84", Offset="0x1B26E84", VA="0x1B26E84", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E46C", Offset="0x107E46C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B26EEC", Offset="0x1B26EEC", VA="0x1B26EEC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E47C", Offset="0x107E47C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FC08", Offset="0x104FC08")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarOpenRewardResponse.<>c <>9;

			[Address(RVA="0x1B2759C", Offset="0x1B2759C", VA="0x1B2759C")]
			static <>c()
			{
			}

			[Address(RVA="0x1B27600", Offset="0x1B27600", VA="0x1B27600")]
			public <>c()
			{
			}

			[Address(RVA="0x1B27608", Offset="0x1B27608", VA="0x1B27608")]
			internal ClubWarOpenRewardResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}