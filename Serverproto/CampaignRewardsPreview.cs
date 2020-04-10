using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CampaignRewardsPreview : IMessage<CampaignRewardsPreview>, IMessage, IEquatable<CampaignRewardsPreview>, IDeepCloneable<CampaignRewardsPreview>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CampaignRewardsPreview> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CampaignIdentifierFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.CampaignIdentifier campaignIdentifier_;

		[FieldOffset(Offset="0x0")]
		public const int PossibleRewardsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ItemCount> _repeated_possibleRewards_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<ItemCount> possibleRewards_;

		[FieldOffset(Offset="0x0")]
		public const int FirstTimeRewardsFieldNumber = 3;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ItemCount> _repeated_firstTimeRewards_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<ItemCount> firstTimeRewards_;

		[FieldOffset(Offset="0x0")]
		public const int PossibleRewardRangesFieldNumber = 4;

		[FieldOffset(Offset="0x18")]
		private readonly static FieldCodec<ItemCountRange> _repeated_possibleRewardRanges_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<ItemCountRange> possibleRewardRanges_;

		[FieldOffset(Offset="0x0")]
		public const int FirstTimeRewardRangesFieldNumber = 5;

		[FieldOffset(Offset="0x20")]
		private readonly static FieldCodec<ItemCountRange> _repeated_firstTimeRewardRanges_codec;

		[FieldOffset(Offset="0x38")]
		private readonly RepeatedField<ItemCountRange> firstTimeRewardRanges_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096CF0", Offset="0x1096CF0")]
		public Serverproto.CampaignIdentifier CampaignIdentifier
		{
			[Address(RVA="0x1F95734", Offset="0x1F95734", VA="0x1F95734")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F9573C", Offset="0x1F9573C", VA="0x1F9573C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096CD0", Offset="0x1096CD0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F953EC", Offset="0x1F953EC", VA="0x1F953EC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096D30", Offset="0x1096D30")]
		public RepeatedField<ItemCountRange> FirstTimeRewardRanges
		{
			[Address(RVA="0x1F957BC", Offset="0x1F957BC", VA="0x1F957BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096D10", Offset="0x1096D10")]
		public RepeatedField<ItemCount> FirstTimeRewards
		{
			[Address(RVA="0x1F957AC", Offset="0x1F957AC", VA="0x1F957AC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096CC0", Offset="0x1096CC0")]
		public static MessageParser<CampaignRewardsPreview> Parser
		{
			[Address(RVA="0x1F95384", Offset="0x1F95384", VA="0x1F95384")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096CE0", Offset="0x1096CE0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F954DC", Offset="0x1F954DC", VA="0x1F954DC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096D20", Offset="0x1096D20")]
		public RepeatedField<ItemCountRange> PossibleRewardRanges
		{
			[Address(RVA="0x1F957B4", Offset="0x1F957B4", VA="0x1F957B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096D00", Offset="0x1096D00")]
		public RepeatedField<ItemCount> PossibleRewards
		{
			[Address(RVA="0x1F957A4", Offset="0x1F957A4", VA="0x1F957A4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F961B0", Offset="0x1F961B0", VA="0x1F961B0")]
		static CampaignRewardsPreview()
		{
		}

		[Address(RVA="0x1F95538", Offset="0x1F95538", VA="0x1F95538")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F32C", Offset="0x107F32C")]
		public CampaignRewardsPreview()
		{
		}

		[Address(RVA="0x1F95608", Offset="0x1F95608", VA="0x1F95608")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F33C", Offset="0x107F33C")]
		public CampaignRewardsPreview(CampaignRewardsPreview other)
		{
		}

		[Address(RVA="0x1F95CA4", Offset="0x1F95CA4", VA="0x1F95CA4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F3AC", Offset="0x107F3AC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F95744", Offset="0x1F95744", VA="0x1F95744", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F34C", Offset="0x107F34C")]
		public CampaignRewardsPreview Clone()
		{
			return null;
		}

		[Address(RVA="0x1F957C4", Offset="0x1F957C4", VA="0x1F957C4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F35C", Offset="0x107F35C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F95838", Offset="0x1F95838", VA="0x1F95838", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F36C", Offset="0x107F36C")]
		public bool Equals(CampaignRewardsPreview other)
		{
			return new bool();
		}

		[Address(RVA="0x1F95988", Offset="0x1F95988", VA="0x1F95988", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F37C", Offset="0x107F37C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F95E40", Offset="0x1F95E40", VA="0x1F95E40", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F3BC", Offset="0x107F3BC")]
		public void MergeFrom(CampaignRewardsPreview other)
		{
		}

		[Address(RVA="0x1F95F98", Offset="0x1F95F98", VA="0x1F95F98", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F3CC", Offset="0x107F3CC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F95A7C", Offset="0x1F95A7C", VA="0x1F95A7C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F38C", Offset="0x107F38C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F95AE4", Offset="0x1F95AE4", VA="0x1F95AE4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F39C", Offset="0x107F39C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FD68", Offset="0x104FD68")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CampaignRewardsPreview.<>c <>9;

			[Address(RVA="0x1F96368", Offset="0x1F96368", VA="0x1F96368")]
			static <>c()
			{
			}

			[Address(RVA="0x1F963CC", Offset="0x1F963CC", VA="0x1F963CC")]
			public <>c()
			{
			}

			[Address(RVA="0x1F963D4", Offset="0x1F963D4", VA="0x1F963D4")]
			internal CampaignRewardsPreview <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}