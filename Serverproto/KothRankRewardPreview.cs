using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class KothRankRewardPreview : IMessage<KothRankRewardPreview>, IMessage, IEquatable<KothRankRewardPreview>, IDeepCloneable<KothRankRewardPreview>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<KothRankRewardPreview> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int KothMinRankFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong kothMinRank_;

		[FieldOffset(Offset="0x0")]
		public const int KothMaxRankFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong kothMaxRank_;

		[FieldOffset(Offset="0x0")]
		public const int DailyPayoutFieldNumber = 3;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ItemCount> _repeated_dailyPayout_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<ItemCount> dailyPayout_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B550", Offset="0x109B550")]
		public RepeatedField<ItemCount> DailyPayout
		{
			[Address(RVA="0x1AA1660", Offset="0x1AA1660", VA="0x1AA1660")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B510", Offset="0x109B510")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1AA1350", Offset="0x1AA1350", VA="0x1AA1350")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B540", Offset="0x109B540")]
		public ulong KothMaxRank
		{
			[Address(RVA="0x1AA1650", Offset="0x1AA1650", VA="0x1AA1650")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AA1658", Offset="0x1AA1658", VA="0x1AA1658")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B530", Offset="0x109B530")]
		public ulong KothMinRank
		{
			[Address(RVA="0x1AA1640", Offset="0x1AA1640", VA="0x1AA1640")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AA1648", Offset="0x1AA1648", VA="0x1AA1648")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B500", Offset="0x109B500")]
		public static MessageParser<KothRankRewardPreview> Parser
		{
			[Address(RVA="0x1AA12E8", Offset="0x1AA12E8", VA="0x1AA12E8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B520", Offset="0x109B520")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1AA1440", Offset="0x1AA1440", VA="0x1AA1440", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1AA1D50", Offset="0x1AA1D50", VA="0x1AA1D50")]
		static KothRankRewardPreview()
		{
		}

		[Address(RVA="0x1AA149C", Offset="0x1AA149C", VA="0x1AA149C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086DCC", Offset="0x1086DCC")]
		public KothRankRewardPreview()
		{
		}

		[Address(RVA="0x1AA150C", Offset="0x1AA150C", VA="0x1AA150C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086DDC", Offset="0x1086DDC")]
		public KothRankRewardPreview(KothRankRewardPreview other)
		{
		}

		[Address(RVA="0x1AA1A34", Offset="0x1AA1A34", VA="0x1AA1A34", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086E4C", Offset="0x1086E4C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1AA15E0", Offset="0x1AA15E0", VA="0x1AA15E0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086DEC", Offset="0x1086DEC")]
		public KothRankRewardPreview Clone()
		{
			return null;
		}

		[Address(RVA="0x1AA1668", Offset="0x1AA1668", VA="0x1AA1668", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086DFC", Offset="0x1086DFC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1AA16DC", Offset="0x1AA16DC", VA="0x1AA16DC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086E0C", Offset="0x1086E0C")]
		public bool Equals(KothRankRewardPreview other)
		{
			return new bool();
		}

		[Address(RVA="0x1AA17AC", Offset="0x1AA17AC", VA="0x1AA17AC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086E1C", Offset="0x1086E1C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1AA1B6C", Offset="0x1AA1B6C", VA="0x1AA1B6C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086E5C", Offset="0x1086E5C")]
		public void MergeFrom(KothRankRewardPreview other)
		{
		}

		[Address(RVA="0x1AA1C14", Offset="0x1AA1C14", VA="0x1AA1C14", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086E6C", Offset="0x1086E6C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1AA1858", Offset="0x1AA1858", VA="0x1AA1858", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086E2C", Offset="0x1086E2C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1AA18C0", Offset="0x1AA18C0", VA="0x1AA18C0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086E3C", Offset="0x1086E3C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050888", Offset="0x1050888")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static KothRankRewardPreview.<>c <>9;

			[Address(RVA="0x1A152E0", Offset="0x1A152E0", VA="0x1A152E0")]
			static <>c()
			{
			}

			[Address(RVA="0x1A15344", Offset="0x1A15344", VA="0x1A15344")]
			public <>c()
			{
			}

			[Address(RVA="0x1A1534C", Offset="0x1A1534C", VA="0x1A1534C")]
			internal KothRankRewardPreview <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}