using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PvpRankRewardPreview : IMessage<PvpRankRewardPreview>, IMessage, IEquatable<PvpRankRewardPreview>, IDeepCloneable<PvpRankRewardPreview>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PvpRankRewardPreview> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PvpRankIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong pvpRankId_;

		[FieldOffset(Offset="0x0")]
		public const int WeeklyPayoutFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ItemCount> _repeated_weeklyPayout_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<ItemCount> weeklyPayout_;

		[FieldOffset(Offset="0x0")]
		public const int SeasonPayoutFieldNumber = 3;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ItemCount> _repeated_seasonPayout_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<ItemCount> seasonPayout_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AF40", Offset="0x109AF40")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x2019E9C", Offset="0x2019E9C", VA="0x2019E9C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AF30", Offset="0x109AF30")]
		public static MessageParser<PvpRankRewardPreview> Parser
		{
			[Address(RVA="0x2019E34", Offset="0x2019E34", VA="0x2019E34")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AF50", Offset="0x109AF50")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x2019F8C", Offset="0x2019F8C", VA="0x2019F8C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AF60", Offset="0x109AF60")]
		public ulong PvpRankId
		{
			[Address(RVA="0x201A1B0", Offset="0x201A1B0", VA="0x201A1B0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x201A1B8", Offset="0x201A1B8", VA="0x201A1B8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AF80", Offset="0x109AF80")]
		public RepeatedField<ItemCount> SeasonPayout
		{
			[Address(RVA="0x201A1C8", Offset="0x201A1C8", VA="0x201A1C8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AF70", Offset="0x109AF70")]
		public RepeatedField<ItemCount> WeeklyPayout
		{
			[Address(RVA="0x201A1C0", Offset="0x201A1C0", VA="0x201A1C0")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x201A8FC", Offset="0x201A8FC", VA="0x201A8FC")]
		static PvpRankRewardPreview()
		{
		}

		[Address(RVA="0x2019FE8", Offset="0x2019FE8", VA="0x2019FE8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108600C", Offset="0x108600C")]
		public PvpRankRewardPreview()
		{
		}

		[Address(RVA="0x201A078", Offset="0x201A078", VA="0x201A078")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108601C", Offset="0x108601C")]
		public PvpRankRewardPreview(PvpRankRewardPreview other)
		{
		}

		[Address(RVA="0x201A5AC", Offset="0x201A5AC", VA="0x201A5AC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108608C", Offset="0x108608C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x201A150", Offset="0x201A150", VA="0x201A150", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108602C", Offset="0x108602C")]
		public PvpRankRewardPreview Clone()
		{
			return null;
		}

		[Address(RVA="0x201A1D0", Offset="0x201A1D0", VA="0x201A1D0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108603C", Offset="0x108603C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x201A244", Offset="0x201A244", VA="0x201A244", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108604C", Offset="0x108604C")]
		public bool Equals(PvpRankRewardPreview other)
		{
			return new bool();
		}

		[Address(RVA="0x201A338", Offset="0x201A338", VA="0x201A338", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108605C", Offset="0x108605C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x201A6E0", Offset="0x201A6E0", VA="0x201A6E0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108609C", Offset="0x108609C")]
		public void MergeFrom(PvpRankRewardPreview other)
		{
		}

		[Address(RVA="0x201A7A8", Offset="0x201A7A8", VA="0x201A7A8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10860AC", Offset="0x10860AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x201A3EC", Offset="0x201A3EC", VA="0x201A3EC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108606C", Offset="0x108606C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x201A454", Offset="0x201A454", VA="0x201A454", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108607C", Offset="0x108607C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050748", Offset="0x1050748")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PvpRankRewardPreview.<>c <>9;

			[Address(RVA="0x201AA44", Offset="0x201AA44", VA="0x201AA44")]
			static <>c()
			{
			}

			[Address(RVA="0x201AAA8", Offset="0x201AAA8", VA="0x201AAA8")]
			public <>c()
			{
			}

			[Address(RVA="0x201AAB0", Offset="0x201AAB0", VA="0x201AAB0")]
			internal PvpRankRewardPreview <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}