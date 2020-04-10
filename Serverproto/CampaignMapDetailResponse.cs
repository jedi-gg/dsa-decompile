using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CampaignMapDetailResponse : IMessage<CampaignMapDetailResponse>, IMessage, IEquatable<CampaignMapDetailResponse>, IDeepCloneable<CampaignMapDetailResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CampaignMapDetailResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int NodesFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<CampaignNode> _repeated_nodes_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<CampaignNode> nodes_;

		[FieldOffset(Offset="0x0")]
		public const int RewardPlayerActivityIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong rewardPlayerActivityId_;

		[FieldOffset(Offset="0x0")]
		public const int ActiveBonusDescriptorFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private BattleNodeOverrideDescriptor activeBonusDescriptor_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10942B8", Offset="0x10942B8")]
		public BattleNodeOverrideDescriptor ActiveBonusDescriptor
		{
			[Address(RVA="0x1F90954", Offset="0x1F90954", VA="0x1F90954")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F9095C", Offset="0x1F9095C", VA="0x1F9095C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094278", Offset="0x1094278")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F906E8", Offset="0x1F906E8", VA="0x1F906E8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094298", Offset="0x1094298")]
		public RepeatedField<CampaignNode> Nodes
		{
			[Address(RVA="0x1F909C4", Offset="0x1F909C4", VA="0x1F909C4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094268", Offset="0x1094268")]
		public static MessageParser<CampaignMapDetailResponse> Parser
		{
			[Address(RVA="0x1F90680", Offset="0x1F90680", VA="0x1F90680")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094288", Offset="0x1094288")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F907D4", Offset="0x1F907D4", VA="0x1F907D4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10942A8", Offset="0x10942A8")]
		public ulong RewardPlayerActivityId
		{
			[Address(RVA="0x1F909CC", Offset="0x1F909CC", VA="0x1F909CC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F909D4", Offset="0x1F909D4", VA="0x1F909D4")]
			set
			{
			}
		}

		[Address(RVA="0x1F91128", Offset="0x1F91128", VA="0x1F91128")]
		static CampaignMapDetailResponse()
		{
		}

		[Address(RVA="0x1F90830", Offset="0x1F90830", VA="0x1F90830")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079B2C", Offset="0x1079B2C")]
		public CampaignMapDetailResponse()
		{
		}

		[Address(RVA="0x1F908A0", Offset="0x1F908A0", VA="0x1F908A0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079B3C", Offset="0x1079B3C")]
		public CampaignMapDetailResponse(CampaignMapDetailResponse other)
		{
		}

		[Address(RVA="0x1F90D9C", Offset="0x1F90D9C", VA="0x1F90D9C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079BAC", Offset="0x1079BAC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F90964", Offset="0x1F90964", VA="0x1F90964", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079B4C", Offset="0x1079B4C")]
		public CampaignMapDetailResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1F909DC", Offset="0x1F909DC", VA="0x1F909DC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079B5C", Offset="0x1079B5C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F90A50", Offset="0x1F90A50", VA="0x1F90A50", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079B6C", Offset="0x1079B6C")]
		public bool Equals(CampaignMapDetailResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1F90B24", Offset="0x1F90B24", VA="0x1F90B24", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079B7C", Offset="0x1079B7C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F90ECC", Offset="0x1F90ECC", VA="0x1F90ECC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079BBC", Offset="0x1079BBC")]
		public void MergeFrom(CampaignMapDetailResponse other)
		{
		}

		[Address(RVA="0x1F90FB8", Offset="0x1F90FB8", VA="0x1F90FB8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079BCC", Offset="0x1079BCC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F90BC0", Offset="0x1F90BC0", VA="0x1F90BC0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079B8C", Offset="0x1079B8C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F90C28", Offset="0x1F90C28", VA="0x1F90C28", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079B9C", Offset="0x1079B9C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F558", Offset="0x104F558")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CampaignMapDetailResponse.<>c <>9;

			[Address(RVA="0x1F91248", Offset="0x1F91248", VA="0x1F91248")]
			static <>c()
			{
			}

			[Address(RVA="0x1F912AC", Offset="0x1F912AC", VA="0x1F912AC")]
			public <>c()
			{
			}

			[Address(RVA="0x1F912B4", Offset="0x1F912B4", VA="0x1F912B4")]
			internal CampaignMapDetailResponse <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}