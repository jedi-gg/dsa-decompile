using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubDungeonRewardGroup : IMessage<ClubDungeonRewardGroup>, IMessage, IEquatable<ClubDungeonRewardGroup>, IDeepCloneable<ClubDungeonRewardGroup>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubDungeonRewardGroup> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int StartNodeIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong startNodeId_;

		[FieldOffset(Offset="0x0")]
		public const int EndNodeIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong endNodeId_;

		[FieldOffset(Offset="0x0")]
		public const int RewardsFieldNumber = 3;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ItemCount> _repeated_rewards_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<ItemCount> rewards_;

		[FieldOffset(Offset="0x0")]
		public const int RewardRangesFieldNumber = 4;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ItemCountRange> _repeated_rewardRanges_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<ItemCountRange> rewardRanges_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10956C0", Offset="0x10956C0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FF3D58", Offset="0x1FF3D58", VA="0x1FF3D58")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10956F0", Offset="0x10956F0")]
		public ulong EndNodeId
		{
			[Address(RVA="0x1FF40A4", Offset="0x1FF40A4", VA="0x1FF40A4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FF40AC", Offset="0x1FF40AC", VA="0x1FF40AC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10956B0", Offset="0x10956B0")]
		public static MessageParser<ClubDungeonRewardGroup> Parser
		{
			[Address(RVA="0x1FF3CF0", Offset="0x1FF3CF0", VA="0x1FF3CF0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10956D0", Offset="0x10956D0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FF3E44", Offset="0x1FF3E44", VA="0x1FF3E44", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095710", Offset="0x1095710")]
		public RepeatedField<ItemCountRange> RewardRanges
		{
			[Address(RVA="0x1FF40BC", Offset="0x1FF40BC", VA="0x1FF40BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095700", Offset="0x1095700")]
		public RepeatedField<ItemCount> Rewards
		{
			[Address(RVA="0x1FF40B4", Offset="0x1FF40B4", VA="0x1FF40B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10956E0", Offset="0x10956E0")]
		public ulong StartNodeId
		{
			[Address(RVA="0x1FF4094", Offset="0x1FF4094", VA="0x1FF4094")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FF409C", Offset="0x1FF409C", VA="0x1FF409C")]
			set
			{
			}
		}

		[Address(RVA="0x1FF4900", Offset="0x1FF4900", VA="0x1FF4900")]
		static ClubDungeonRewardGroup()
		{
		}

		[Address(RVA="0x1FF3EA0", Offset="0x1FF3EA0", VA="0x1FF3EA0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C7DC", Offset="0x107C7DC")]
		public ClubDungeonRewardGroup()
		{
		}

		[Address(RVA="0x1FF3F38", Offset="0x1FF3F38", VA="0x1FF3F38")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C7EC", Offset="0x107C7EC")]
		public ClubDungeonRewardGroup(ClubDungeonRewardGroup other)
		{
		}

		[Address(RVA="0x1FF4528", Offset="0x1FF4528", VA="0x1FF4528", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C85C", Offset="0x107C85C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FF4034", Offset="0x1FF4034", VA="0x1FF4034", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C7FC", Offset="0x107C7FC")]
		public ClubDungeonRewardGroup Clone()
		{
			return null;
		}

		[Address(RVA="0x1FF40C4", Offset="0x1FF40C4", VA="0x1FF40C4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C80C", Offset="0x107C80C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF4138", Offset="0x1FF4138", VA="0x1FF4138", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C81C", Offset="0x107C81C")]
		public bool Equals(ClubDungeonRewardGroup other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF4238", Offset="0x1FF4238", VA="0x1FF4238", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C82C", Offset="0x107C82C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FF46A0", Offset="0x1FF46A0", VA="0x1FF46A0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C86C", Offset="0x107C86C")]
		public void MergeFrom(ClubDungeonRewardGroup other)
		{
		}

		[Address(RVA="0x1FF4774", Offset="0x1FF4774", VA="0x1FF4774", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C87C", Offset="0x107C87C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FF4308", Offset="0x1FF4308", VA="0x1FF4308", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C83C", Offset="0x107C83C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FF4370", Offset="0x1FF4370", VA="0x1FF4370", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C84C", Offset="0x107C84C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F968", Offset="0x104F968")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubDungeonRewardGroup.<>c <>9;

			[Address(RVA="0x1FF4A70", Offset="0x1FF4A70", VA="0x1FF4A70")]
			static <>c()
			{
			}

			[Address(RVA="0x1FF4AD4", Offset="0x1FF4AD4", VA="0x1FF4AD4")]
			public <>c()
			{
			}

			[Address(RVA="0x1FF4ADC", Offset="0x1FF4ADC", VA="0x1FF4ADC")]
			internal ClubDungeonRewardGroup <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}