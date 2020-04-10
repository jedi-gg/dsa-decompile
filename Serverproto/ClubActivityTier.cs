using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubActivityTier : IMessage<ClubActivityTier>, IMessage, IEquatable<ClubActivityTier>, IDeepCloneable<ClubActivityTier>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubActivityTier> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int NameFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string name_;

		[FieldOffset(Offset="0x0")]
		public const int DescriptionFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string description_;

		[FieldOffset(Offset="0x0")]
		public const int RequiredValueFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong requiredValue_;

		[FieldOffset(Offset="0x0")]
		public const int RewardsFieldNumber = 4;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ItemCount> _repeated_rewards_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<ItemCount> rewards_;

		[FieldOffset(Offset="0x0")]
		public const int RewardRangesFieldNumber = 5;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ItemCountRange> _repeated_rewardRanges_codec;

		[FieldOffset(Offset="0x38")]
		private readonly RepeatedField<ItemCountRange> rewardRanges_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094BC0", Offset="0x1094BC0")]
		public string Description
		{
			[Address(RVA="0x1A4A2D8", Offset="0x1A4A2D8", VA="0x1A4A2D8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A4A2E0", Offset="0x1A4A2E0", VA="0x1A4A2E0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094B90", Offset="0x1094B90")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A49EF4", Offset="0x1A49EF4", VA="0x1A49EF4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094BB0", Offset="0x1094BB0")]
		public string Name
		{
			[Address(RVA="0x1A4A260", Offset="0x1A4A260", VA="0x1A4A260")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A4A268", Offset="0x1A4A268", VA="0x1A4A268")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094B80", Offset="0x1094B80")]
		public static MessageParser<ClubActivityTier> Parser
		{
			[Address(RVA="0x1A49394", Offset="0x1A49394", VA="0x1A49394")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094BA0", Offset="0x1094BA0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A49FE4", Offset="0x1A49FE4", VA="0x1A49FE4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094BD0", Offset="0x1094BD0")]
		public ulong RequiredValue
		{
			[Address(RVA="0x1A4A350", Offset="0x1A4A350", VA="0x1A4A350")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A4A358", Offset="0x1A4A358", VA="0x1A4A358")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094BF0", Offset="0x1094BF0")]
		public RepeatedField<ItemCountRange> RewardRanges
		{
			[Address(RVA="0x1A4A368", Offset="0x1A4A368", VA="0x1A4A368")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094BE0", Offset="0x1094BE0")]
		public RepeatedField<ItemCount> Rewards
		{
			[Address(RVA="0x1A4A360", Offset="0x1A4A360", VA="0x1A4A360")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A4ADB0", Offset="0x1A4ADB0", VA="0x1A4ADB0")]
		static ClubActivityTier()
		{
		}

		[Address(RVA="0x1A4A040", Offset="0x1A4A040", VA="0x1A4A040")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AC5C", Offset="0x107AC5C")]
		public ClubActivityTier()
		{
		}

		[Address(RVA="0x1A4A0E8", Offset="0x1A4A0E8", VA="0x1A4A0E8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AC6C", Offset="0x107AC6C")]
		public ClubActivityTier(ClubActivityTier other)
		{
		}

		[Address(RVA="0x1A4A8E0", Offset="0x1A4A8E0", VA="0x1A4A8E0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ACDC", Offset="0x107ACDC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A4A200", Offset="0x1A4A200", VA="0x1A4A200", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AC7C", Offset="0x107AC7C")]
		public ClubActivityTier Clone()
		{
			return null;
		}

		[Address(RVA="0x1A4A370", Offset="0x1A4A370", VA="0x1A4A370", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AC8C", Offset="0x107AC8C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A4A3E4", Offset="0x1A4A3E4", VA="0x1A4A3E4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AC9C", Offset="0x107AC9C")]
		public bool Equals(ClubActivityTier other)
		{
			return new bool();
		}

		[Address(RVA="0x1A4A4FC", Offset="0x1A4A4FC", VA="0x1A4A4FC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ACAC", Offset="0x107ACAC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A4AACC", Offset="0x1A4AACC", VA="0x1A4AACC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ACEC", Offset="0x107ACEC")]
		public void MergeFrom(ClubActivityTier other)
		{
		}

		[Address(RVA="0x1A4ABEC", Offset="0x1A4ABEC", VA="0x1A4ABEC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ACFC", Offset="0x107ACFC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A4A638", Offset="0x1A4A638", VA="0x1A4A638", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ACBC", Offset="0x107ACBC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A4A6A0", Offset="0x1A4A6A0", VA="0x1A4A6A0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ACCC", Offset="0x107ACCC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F6E8", Offset="0x104F6E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubActivityTier.<>c <>9;

			[Address(RVA="0x1A4AF20", Offset="0x1A4AF20", VA="0x1A4AF20")]
			static <>c()
			{
			}

			[Address(RVA="0x1A4AF84", Offset="0x1A4AF84", VA="0x1A4AF84")]
			public <>c()
			{
			}

			[Address(RVA="0x1A4AF8C", Offset="0x1A4AF8C", VA="0x1A4AF8C")]
			internal ClubActivityTier <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}