using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class KothRankRewardPreviewResponse : IMessage<KothRankRewardPreviewResponse>, IMessage, IEquatable<KothRankRewardPreviewResponse>, IDeepCloneable<KothRankRewardPreviewResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<KothRankRewardPreviewResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int RankRewardPreviewsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<KothRankRewardPreview> _repeated_rankRewardPreviews_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<KothRankRewardPreview> rankRewardPreviews_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B4D0", Offset="0x109B4D0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A15A1C", Offset="0x1A15A1C", VA="0x1A15A1C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B4C0", Offset="0x109B4C0")]
		public static MessageParser<KothRankRewardPreviewResponse> Parser
		{
			[Address(RVA="0x1A159B4", Offset="0x1A159B4", VA="0x1A159B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B4E0", Offset="0x109B4E0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A15B0C", Offset="0x1A15B0C", VA="0x1A15B0C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B4F0", Offset="0x109B4F0")]
		public RepeatedField<KothRankRewardPreview> RankRewardPreviews
		{
			[Address(RVA="0x1A15CD0", Offset="0x1A15CD0", VA="0x1A15CD0")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A161B8", Offset="0x1A161B8", VA="0x1A161B8")]
		static KothRankRewardPreviewResponse()
		{
		}

		[Address(RVA="0x1A15B68", Offset="0x1A15B68", VA="0x1A15B68")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086D1C", Offset="0x1086D1C")]
		public KothRankRewardPreviewResponse()
		{
		}

		[Address(RVA="0x1A15BD8", Offset="0x1A15BD8", VA="0x1A15BD8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086D2C", Offset="0x1086D2C")]
		public KothRankRewardPreviewResponse(KothRankRewardPreviewResponse other)
		{
		}

		[Address(RVA="0x1A15F88", Offset="0x1A15F88", VA="0x1A15F88", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086D9C", Offset="0x1086D9C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A15C70", Offset="0x1A15C70", VA="0x1A15C70", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086D3C", Offset="0x1086D3C")]
		public KothRankRewardPreviewResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A15CD8", Offset="0x1A15CD8", VA="0x1A15CD8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086D4C", Offset="0x1086D4C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A15D4C", Offset="0x1A15D4C", VA="0x1A15D4C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086D5C", Offset="0x1086D5C")]
		public bool Equals(KothRankRewardPreviewResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A15DFC", Offset="0x1A15DFC", VA="0x1A15DFC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086D6C", Offset="0x1086D6C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A16044", Offset="0x1A16044", VA="0x1A16044", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086DAC", Offset="0x1086DAC")]
		public void MergeFrom(KothRankRewardPreviewResponse other)
		{
		}

		[Address(RVA="0x1A160D4", Offset="0x1A160D4", VA="0x1A160D4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086DBC", Offset="0x1086DBC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A15E5C", Offset="0x1A15E5C", VA="0x1A15E5C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086D7C", Offset="0x1086D7C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A15EC4", Offset="0x1A15EC4", VA="0x1A15EC4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086D8C", Offset="0x1086D8C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050878", Offset="0x1050878")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static KothRankRewardPreviewResponse.<>c <>9;

			[Address(RVA="0x1A162DC", Offset="0x1A162DC", VA="0x1A162DC")]
			static <>c()
			{
			}

			[Address(RVA="0x1A16340", Offset="0x1A16340", VA="0x1A16340")]
			public <>c()
			{
			}

			[Address(RVA="0x1A16348", Offset="0x1A16348", VA="0x1A16348")]
			internal KothRankRewardPreviewResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}