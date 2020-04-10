using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class MatchMakerRequest : IMessage<MatchMakerRequest>, IMessage, IEquatable<MatchMakerRequest>, IDeepCloneable<MatchMakerRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<MatchMakerRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerInfoFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private MatchMakerPlayerInfo playerInfo_;

		[FieldOffset(Offset="0x0")]
		public const int MatchTypeFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private Serverproto.MatchType matchType_;

		[FieldOffset(Offset="0x0")]
		public const int CampaignIdentifierFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private Serverproto.CampaignIdentifier campaignIdentifier_;

		[FieldOffset(Offset="0x0")]
		public const int PowerRatingFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong powerRating_;

		[FieldOffset(Offset="0x0")]
		public const int EventIdFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private EventIdentifier eventId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10925B8", Offset="0x10925B8")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x10925B8", Offset="0x10925B8")]
		public Serverproto.CampaignIdentifier CampaignIdentifier
		{
			[Address(RVA="0x1A1D5CC", Offset="0x1A1D5CC", VA="0x1A1D5CC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A1D5D4", Offset="0x1A1D5D4", VA="0x1A1D5D4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092578", Offset="0x1092578")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A1D3B8", Offset="0x1A1D3B8", VA="0x1A1D3B8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092600", Offset="0x1092600")]
		public EventIdentifier EventId
		{
			[Address(RVA="0x1A1D5DC", Offset="0x1A1D5DC", VA="0x1A1D5DC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A1D5E4", Offset="0x1A1D5E4", VA="0x1A1D5E4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10925A8", Offset="0x10925A8")]
		public Serverproto.MatchType MatchType
		{
			[Address(RVA="0x1A1D64C", Offset="0x1A1D64C", VA="0x1A1D64C")]
			get
			{
				return new Serverproto.MatchType();
			}
			[Address(RVA="0x1A1D654", Offset="0x1A1D654", VA="0x1A1D654")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092568", Offset="0x1092568")]
		public static MessageParser<MatchMakerRequest> Parser
		{
			[Address(RVA="0x1A1D350", Offset="0x1A1D350", VA="0x1A1D350")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092588", Offset="0x1092588")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A1D4A8", Offset="0x1A1D4A8", VA="0x1A1D4A8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092598", Offset="0x1092598")]
		public MatchMakerPlayerInfo PlayerInfo
		{
			[Address(RVA="0x1A1D5BC", Offset="0x1A1D5BC", VA="0x1A1D5BC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A1D5C4", Offset="0x1A1D5C4", VA="0x1A1D5C4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10925F0", Offset="0x10925F0")]
		public ulong PowerRating
		{
			[Address(RVA="0x1A1D65C", Offset="0x1A1D65C", VA="0x1A1D65C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A1D664", Offset="0x1A1D664", VA="0x1A1D664")]
			set
			{
			}
		}

		[Address(RVA="0x1A1DF50", Offset="0x1A1DF50", VA="0x1A1DF50")]
		static MatchMakerRequest()
		{
		}

		[Address(RVA="0x1A1D504", Offset="0x1A1D504", VA="0x1A1D504")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076AAC", Offset="0x1076AAC")]
		public MatchMakerRequest()
		{
		}

		[Address(RVA="0x1A1D50C", Offset="0x1A1D50C", VA="0x1A1D50C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076ABC", Offset="0x1076ABC")]
		public MatchMakerRequest(MatchMakerRequest other)
		{
		}

		[Address(RVA="0x1A1DAC4", Offset="0x1A1DAC4", VA="0x1A1DAC4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076B2C", Offset="0x1076B2C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A1D5EC", Offset="0x1A1D5EC", VA="0x1A1D5EC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076ACC", Offset="0x1076ACC")]
		public MatchMakerRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A1D66C", Offset="0x1A1D66C", VA="0x1A1D66C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076ADC", Offset="0x1076ADC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A1D6E0", Offset="0x1A1D6E0", VA="0x1A1D6E0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076AEC", Offset="0x1076AEC")]
		public bool Equals(MatchMakerRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A1D78C", Offset="0x1A1D78C", VA="0x1A1D78C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076AFC", Offset="0x1076AFC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A1DC4C", Offset="0x1A1DC4C", VA="0x1A1DC4C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076B3C", Offset="0x1076B3C")]
		public void MergeFrom(MatchMakerRequest other)
		{
		}

		[Address(RVA="0x1A1DDB0", Offset="0x1A1DDB0", VA="0x1A1DDB0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076B4C", Offset="0x1076B4C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A1D85C", Offset="0x1A1D85C", VA="0x1A1D85C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076B0C", Offset="0x1076B0C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A1D8C4", Offset="0x1A1D8C4", VA="0x1A1D8C4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076B1C", Offset="0x1076B1C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F0B8", Offset="0x104F0B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static MatchMakerRequest.<>c <>9;

			[Address(RVA="0x1A1E028", Offset="0x1A1E028", VA="0x1A1E028")]
			static <>c()
			{
			}

			[Address(RVA="0x1A1E08C", Offset="0x1A1E08C", VA="0x1A1E08C")]
			public <>c()
			{
			}

			[Address(RVA="0x1A1E094", Offset="0x1A1E094", VA="0x1A1E094")]
			internal MatchMakerRequest <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}