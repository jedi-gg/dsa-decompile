using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CampaignMap : IMessage<CampaignMap>, IMessage, IEquatable<CampaignMap>, IDeepCloneable<CampaignMap>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CampaignMap> _parser;

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

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094060", Offset="0x1094060")]
		public BattleNodeOverrideDescriptor ActiveBonusDescriptor
		{
			[Address(RVA="0x1F8F3CC", Offset="0x1F8F3CC", VA="0x1F8F3CC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F8F3D4", Offset="0x1F8F3D4", VA="0x1F8F3D4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094020", Offset="0x1094020")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F8F160", Offset="0x1F8F160", VA="0x1F8F160")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094040", Offset="0x1094040")]
		public RepeatedField<CampaignNode> Nodes
		{
			[Address(RVA="0x1F8F43C", Offset="0x1F8F43C", VA="0x1F8F43C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094010", Offset="0x1094010")]
		public static MessageParser<CampaignMap> Parser
		{
			[Address(RVA="0x1F8E5F4", Offset="0x1F8E5F4", VA="0x1F8E5F4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094030", Offset="0x1094030")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F8F24C", Offset="0x1F8F24C", VA="0x1F8F24C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094050", Offset="0x1094050")]
		public ulong RewardPlayerActivityId
		{
			[Address(RVA="0x1F8F444", Offset="0x1F8F444", VA="0x1F8F444")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F8F44C", Offset="0x1F8F44C", VA="0x1F8F44C")]
			set
			{
			}
		}

		[Address(RVA="0x1F8FBA0", Offset="0x1F8FBA0", VA="0x1F8FBA0")]
		static CampaignMap()
		{
		}

		[Address(RVA="0x1F8F2A8", Offset="0x1F8F2A8", VA="0x1F8F2A8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107980C", Offset="0x107980C")]
		public CampaignMap()
		{
		}

		[Address(RVA="0x1F8F318", Offset="0x1F8F318", VA="0x1F8F318")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107981C", Offset="0x107981C")]
		public CampaignMap(CampaignMap other)
		{
		}

		[Address(RVA="0x1F8F814", Offset="0x1F8F814", VA="0x1F8F814", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107988C", Offset="0x107988C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F8F3DC", Offset="0x1F8F3DC", VA="0x1F8F3DC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107982C", Offset="0x107982C")]
		public CampaignMap Clone()
		{
			return null;
		}

		[Address(RVA="0x1F8F454", Offset="0x1F8F454", VA="0x1F8F454", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107983C", Offset="0x107983C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F8F4C8", Offset="0x1F8F4C8", VA="0x1F8F4C8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107984C", Offset="0x107984C")]
		public bool Equals(CampaignMap other)
		{
			return new bool();
		}

		[Address(RVA="0x1F8F59C", Offset="0x1F8F59C", VA="0x1F8F59C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107985C", Offset="0x107985C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F8F944", Offset="0x1F8F944", VA="0x1F8F944", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107989C", Offset="0x107989C")]
		public void MergeFrom(CampaignMap other)
		{
		}

		[Address(RVA="0x1F8FA30", Offset="0x1F8FA30", VA="0x1F8FA30", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10798AC", Offset="0x10798AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F8F638", Offset="0x1F8F638", VA="0x1F8F638", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107986C", Offset="0x107986C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F8F6A0", Offset="0x1F8F6A0", VA="0x1F8F6A0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107987C", Offset="0x107987C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F518", Offset="0x104F518")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CampaignMap.<>c <>9;

			[Address(RVA="0x1F8FD28", Offset="0x1F8FD28", VA="0x1F8FD28")]
			static <>c()
			{
			}

			[Address(RVA="0x1F8FD8C", Offset="0x1F8FD8C", VA="0x1F8FD8C")]
			public <>c()
			{
			}

			[Address(RVA="0x1F8FD94", Offset="0x1F8FD94", VA="0x1F8FD94")]
			internal CampaignMap <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}