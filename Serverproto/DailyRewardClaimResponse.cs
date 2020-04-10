using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class DailyRewardClaimResponse : IMessage<DailyRewardClaimResponse>, IMessage, IEquatable<DailyRewardClaimResponse>, IDeepCloneable<DailyRewardClaimResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<DailyRewardClaimResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int DailyRewardFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private Serverproto.DailyReward dailyReward_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B8B0", Offset="0x109B8B0")]
		public Serverproto.DailyReward DailyReward
		{
			[Address(RVA="0x1EF8764", Offset="0x1EF8764", VA="0x1EF8764")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EF876C", Offset="0x1EF876C", VA="0x1EF876C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B880", Offset="0x109B880")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EF8574", Offset="0x1EF8574", VA="0x1EF8574")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B8A0", Offset="0x109B8A0")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1EF8754", Offset="0x1EF8754", VA="0x1EF8754")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EF875C", Offset="0x1EF875C", VA="0x1EF875C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B870", Offset="0x109B870")]
		public static MessageParser<DailyRewardClaimResponse> Parser
		{
			[Address(RVA="0x1EF850C", Offset="0x1EF850C", VA="0x1EF850C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B890", Offset="0x109B890")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EF8664", Offset="0x1EF8664", VA="0x1EF8664", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EF8D78", Offset="0x1EF8D78", VA="0x1EF8D78")]
		static DailyRewardClaimResponse()
		{
		}

		[Address(RVA="0x1EF86C0", Offset="0x1EF86C0", VA="0x1EF86C0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10874AC", Offset="0x10874AC")]
		public DailyRewardClaimResponse()
		{
		}

		[Address(RVA="0x1EF86C8", Offset="0x1EF86C8", VA="0x1EF86C8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10874BC", Offset="0x10874BC")]
		public DailyRewardClaimResponse(DailyRewardClaimResponse other)
		{
		}

		[Address(RVA="0x1EF8A90", Offset="0x1EF8A90", VA="0x1EF8A90", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108752C", Offset="0x108752C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EF8774", Offset="0x1EF8774", VA="0x1EF8774", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10874CC", Offset="0x10874CC")]
		public DailyRewardClaimResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1EF87D4", Offset="0x1EF87D4", VA="0x1EF87D4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10874DC", Offset="0x10874DC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF8848", Offset="0x1EF8848", VA="0x1EF8848", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10874EC", Offset="0x10874EC")]
		public bool Equals(DailyRewardClaimResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF88C0", Offset="0x1EF88C0", VA="0x1EF88C0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10874FC", Offset="0x10874FC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EF8B64", Offset="0x1EF8B64", VA="0x1EF8B64", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108753C", Offset="0x108753C")]
		public void MergeFrom(DailyRewardClaimResponse other)
		{
		}

		[Address(RVA="0x1EF8C64", Offset="0x1EF8C64", VA="0x1EF8C64", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108754C", Offset="0x108754C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EF8930", Offset="0x1EF8930", VA="0x1EF8930", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108750C", Offset="0x108750C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EF8998", Offset="0x1EF8998", VA="0x1EF8998", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108751C", Offset="0x108751C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050928", Offset="0x1050928")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DailyRewardClaimResponse.<>c <>9;

			[Address(RVA="0x1EF8E50", Offset="0x1EF8E50", VA="0x1EF8E50")]
			static <>c()
			{
			}

			[Address(RVA="0x1EF8EB4", Offset="0x1EF8EB4", VA="0x1EF8EB4")]
			public <>c()
			{
			}

			[Address(RVA="0x1EF8EBC", Offset="0x1EF8EBC", VA="0x1EF8EBC")]
			internal DailyRewardClaimResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}