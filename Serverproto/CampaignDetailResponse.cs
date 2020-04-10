using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CampaignDetailResponse : IMessage<CampaignDetailResponse>, IMessage, IEquatable<CampaignDetailResponse>, IDeepCloneable<CampaignDetailResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CampaignDetailResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int NormalMapsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<CampaignMap> _repeated_normalMaps_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<CampaignMap> normalMaps_;

		[FieldOffset(Offset="0x0")]
		public const int HardMapsFieldNumber = 2;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<CampaignMap> _repeated_hardMaps_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<CampaignMap> hardMaps_;

		[FieldOffset(Offset="0x0")]
		public const int BonusLootExpireTimestampFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong bonusLootExpireTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int BonusLootDataFieldNumber = 4;

		[FieldOffset(Offset="0x18")]
		private readonly static FieldCodec<Serverproto.BonusLootData> _repeated_bonusLootData_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<Serverproto.BonusLootData> bonusLootData_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094390", Offset="0x1094390")]
		public RepeatedField<Serverproto.BonusLootData> BonusLootData
		{
			[Address(RVA="0x1F8DBD0", Offset="0x1F8DBD0", VA="0x1F8DBD0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094358", Offset="0x1094358")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1094358", Offset="0x1094358")]
		public ulong BonusLootExpireTimestamp
		{
			[Address(RVA="0x1F8DBC0", Offset="0x1F8DBC0", VA="0x1F8DBC0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F8DBC8", Offset="0x1F8DBC8", VA="0x1F8DBC8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094318", Offset="0x1094318")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F8D868", Offset="0x1F8D868", VA="0x1F8D868")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094348", Offset="0x1094348")]
		public RepeatedField<CampaignMap> HardMaps
		{
			[Address(RVA="0x1F8DBB8", Offset="0x1F8DBB8", VA="0x1F8DBB8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094338", Offset="0x1094338")]
		public RepeatedField<CampaignMap> NormalMaps
		{
			[Address(RVA="0x1F8DBB0", Offset="0x1F8DBB0", VA="0x1F8DBB0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094308", Offset="0x1094308")]
		public static MessageParser<CampaignDetailResponse> Parser
		{
			[Address(RVA="0x1F8D800", Offset="0x1F8D800", VA="0x1F8D800")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094328", Offset="0x1094328")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F8D954", Offset="0x1F8D954", VA="0x1F8D954", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F8E468", Offset="0x1F8E468", VA="0x1F8E468")]
		static CampaignDetailResponse()
		{
		}

		[Address(RVA="0x1F8D9B0", Offset="0x1F8D9B0", VA="0x1F8D9B0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079C8C", Offset="0x1079C8C")]
		public CampaignDetailResponse()
		{
		}

		[Address(RVA="0x1F8DA68", Offset="0x1F8DA68", VA="0x1F8DA68")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079C9C", Offset="0x1079C9C")]
		public CampaignDetailResponse(CampaignDetailResponse other)
		{
		}

		[Address(RVA="0x1F8E050", Offset="0x1F8E050", VA="0x1F8E050", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079D0C", Offset="0x1079D0C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F8DB50", Offset="0x1F8DB50", VA="0x1F8DB50", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079CAC", Offset="0x1079CAC")]
		public CampaignDetailResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1F8DBD8", Offset="0x1F8DBD8", VA="0x1F8DBD8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079CBC", Offset="0x1079CBC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F8DC4C", Offset="0x1F8DC4C", VA="0x1F8DC4C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079CCC", Offset="0x1079CCC")]
		public bool Equals(CampaignDetailResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1F8DD70", Offset="0x1F8DD70", VA="0x1F8DD70", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079CDC", Offset="0x1079CDC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F8E1D0", Offset="0x1F8E1D0", VA="0x1F8E1D0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079D1C", Offset="0x1079D1C")]
		public void MergeFrom(CampaignDetailResponse other)
		{
		}

		[Address(RVA="0x1F8E2C4", Offset="0x1F8E2C4", VA="0x1F8E2C4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079D2C", Offset="0x1079D2C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F8DE40", Offset="0x1F8DE40", VA="0x1F8DE40", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079CEC", Offset="0x1079CEC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F8DEA8", Offset="0x1F8DEA8", VA="0x1F8DEA8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079CFC", Offset="0x1079CFC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F578", Offset="0x104F578")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CampaignDetailResponse.<>c <>9;

			[Address(RVA="0x1F8E65C", Offset="0x1F8E65C", VA="0x1F8E65C")]
			static <>c()
			{
			}

			[Address(RVA="0x1F8E6C0", Offset="0x1F8E6C0", VA="0x1F8E6C0")]
			public <>c()
			{
			}

			[Address(RVA="0x1F8E6C8", Offset="0x1F8E6C8", VA="0x1F8E6C8")]
			internal CampaignDetailResponse <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}