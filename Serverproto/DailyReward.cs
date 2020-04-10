using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class DailyReward : IMessage<DailyReward>, IMessage, IEquatable<DailyReward>, IDeepCloneable<DailyReward>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<DailyReward> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int RewardIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong rewardId_;

		[FieldOffset(Offset="0x0")]
		public const int TierIndexFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong tierIndex_;

		[FieldOffset(Offset="0x0")]
		public const int RewardIndexFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong rewardIndex_;

		[FieldOffset(Offset="0x0")]
		public const int ResetTimeFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong resetTime_;

		[FieldOffset(Offset="0x0")]
		public const int CompletedFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private bool completed_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B800", Offset="0x109B800")]
		public bool Completed
		{
			[Address(RVA="0x1EF7220", Offset="0x1EF7220", VA="0x1EF7220")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1EF7228", Offset="0x1EF7228", VA="0x1EF7228")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B7A0", Offset="0x109B7A0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EF6F58", Offset="0x1EF6F58", VA="0x1EF6F58")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B790", Offset="0x109B790")]
		public static MessageParser<DailyReward> Parser
		{
			[Address(RVA="0x1EF6EF0", Offset="0x1EF6EF0", VA="0x1EF6EF0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B7B0", Offset="0x109B7B0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EF7048", Offset="0x1EF7048", VA="0x1EF7048", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B7F0", Offset="0x109B7F0")]
		public ulong ResetTime
		{
			[Address(RVA="0x1EF7210", Offset="0x1EF7210", VA="0x1EF7210")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EF7218", Offset="0x1EF7218", VA="0x1EF7218")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B7C0", Offset="0x109B7C0")]
		public ulong RewardId
		{
			[Address(RVA="0x1EF71E0", Offset="0x1EF71E0", VA="0x1EF71E0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EF71E8", Offset="0x1EF71E8", VA="0x1EF71E8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B7E0", Offset="0x109B7E0")]
		public ulong RewardIndex
		{
			[Address(RVA="0x1EF7200", Offset="0x1EF7200", VA="0x1EF7200")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EF7208", Offset="0x1EF7208", VA="0x1EF7208")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B7D0", Offset="0x109B7D0")]
		public ulong TierIndex
		{
			[Address(RVA="0x1EF71F0", Offset="0x1EF71F0", VA="0x1EF71F0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EF71F8", Offset="0x1EF71F8", VA="0x1EF71F8")]
			set
			{
			}
		}

		[Address(RVA="0x1EF797C", Offset="0x1EF797C", VA="0x1EF797C")]
		static DailyReward()
		{
		}

		[Address(RVA="0x1EF70A4", Offset="0x1EF70A4", VA="0x1EF70A4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108734C", Offset="0x108734C")]
		public DailyReward()
		{
		}

		[Address(RVA="0x1EF70AC", Offset="0x1EF70AC", VA="0x1EF70AC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108735C", Offset="0x108735C")]
		public DailyReward(DailyReward other)
		{
		}

		[Address(RVA="0x1EF7680", Offset="0x1EF7680", VA="0x1EF7680", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10873CC", Offset="0x10873CC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EF7180", Offset="0x1EF7180", VA="0x1EF7180", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108736C", Offset="0x108736C")]
		public DailyReward Clone()
		{
			return null;
		}

		[Address(RVA="0x1EF7234", Offset="0x1EF7234", VA="0x1EF7234", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108737C", Offset="0x108737C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF72A8", Offset="0x1EF72A8", VA="0x1EF72A8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108738C", Offset="0x108738C")]
		public bool Equals(DailyReward other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF7334", Offset="0x1EF7334", VA="0x1EF7334", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108739C", Offset="0x108739C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EF77E4", Offset="0x1EF77E4", VA="0x1EF77E4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10873DC", Offset="0x10873DC")]
		public void MergeFrom(DailyReward other)
		{
		}

		[Address(RVA="0x1EF7854", Offset="0x1EF7854", VA="0x1EF7854", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10873EC", Offset="0x10873EC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EF7414", Offset="0x1EF7414", VA="0x1EF7414", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10873AC", Offset="0x10873AC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EF747C", Offset="0x1EF747C", VA="0x1EF747C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10873BC", Offset="0x10873BC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050908", Offset="0x1050908")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DailyReward.<>c <>9;

			[Address(RVA="0x1EF7A54", Offset="0x1EF7A54", VA="0x1EF7A54")]
			static <>c()
			{
			}

			[Address(RVA="0x1EF7AB8", Offset="0x1EF7AB8", VA="0x1EF7AB8")]
			public <>c()
			{
			}

			[Address(RVA="0x1EF7AC0", Offset="0x1EF7AC0", VA="0x1EF7AC0")]
			internal DailyReward <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}