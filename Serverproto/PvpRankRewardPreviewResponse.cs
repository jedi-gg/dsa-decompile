using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PvpRankRewardPreviewResponse : IMessage<PvpRankRewardPreviewResponse>, IMessage, IEquatable<PvpRankRewardPreviewResponse>, IDeepCloneable<PvpRankRewardPreviewResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PvpRankRewardPreviewResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int RankRewardPreviewsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<PvpRankRewardPreview> _repeated_rankRewardPreviews_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<PvpRankRewardPreview> rankRewardPreviews_;

		[FieldOffset(Offset="0x0")]
		public const int NextPayoutTimeFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong nextPayoutTime_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AEF0", Offset="0x109AEF0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x201B17C", Offset="0x201B17C", VA="0x201B17C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AF20", Offset="0x109AF20")]
		public ulong NextPayoutTime
		{
			[Address(RVA="0x201B440", Offset="0x201B440", VA="0x201B440")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x201B448", Offset="0x201B448", VA="0x201B448")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AEE0", Offset="0x109AEE0")]
		public static MessageParser<PvpRankRewardPreviewResponse> Parser
		{
			[Address(RVA="0x201B114", Offset="0x201B114", VA="0x201B114")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AF00", Offset="0x109AF00")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x201B26C", Offset="0x201B26C", VA="0x201B26C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AF10", Offset="0x109AF10")]
		public RepeatedField<PvpRankRewardPreview> RankRewardPreviews
		{
			[Address(RVA="0x201B438", Offset="0x201B438", VA="0x201B438")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x201BA28", Offset="0x201BA28", VA="0x201BA28")]
		static PvpRankRewardPreviewResponse()
		{
		}

		[Address(RVA="0x201B2C8", Offset="0x201B2C8", VA="0x201B2C8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085F5C", Offset="0x1085F5C")]
		public PvpRankRewardPreviewResponse()
		{
		}

		[Address(RVA="0x201B338", Offset="0x201B338", VA="0x201B338")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085F6C", Offset="0x1085F6C")]
		public PvpRankRewardPreviewResponse(PvpRankRewardPreviewResponse other)
		{
		}

		[Address(RVA="0x201B78C", Offset="0x201B78C", VA="0x201B78C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085FDC", Offset="0x1085FDC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x201B3D8", Offset="0x201B3D8", VA="0x201B3D8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085F7C", Offset="0x1085F7C")]
		public PvpRankRewardPreviewResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x201B450", Offset="0x201B450", VA="0x201B450", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085F8C", Offset="0x1085F8C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x201B4C4", Offset="0x201B4C4", VA="0x201B4C4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085F9C", Offset="0x1085F9C")]
		public bool Equals(PvpRankRewardPreviewResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x201B584", Offset="0x201B584", VA="0x201B584", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085FAC", Offset="0x1085FAC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x201B880", Offset="0x201B880", VA="0x201B880", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085FEC", Offset="0x1085FEC")]
		public void MergeFrom(PvpRankRewardPreviewResponse other)
		{
		}

		[Address(RVA="0x201B91C", Offset="0x201B91C", VA="0x201B91C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085FFC", Offset="0x1085FFC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x201B608", Offset="0x201B608", VA="0x201B608", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085FBC", Offset="0x1085FBC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x201B670", Offset="0x201B670", VA="0x201B670", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085FCC", Offset="0x1085FCC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050738", Offset="0x1050738")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PvpRankRewardPreviewResponse.<>c <>9;

			[Address(RVA="0x201BB48", Offset="0x201BB48", VA="0x201BB48")]
			static <>c()
			{
			}

			[Address(RVA="0x201BBAC", Offset="0x201BBAC", VA="0x201BBAC")]
			public <>c()
			{
			}

			[Address(RVA="0x201BBB4", Offset="0x201BBB4", VA="0x201BBB4")]
			internal PvpRankRewardPreviewResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}