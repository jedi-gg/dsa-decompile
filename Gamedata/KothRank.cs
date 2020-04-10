using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct KothRank : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5AE70", Offset="0xF5AE70", VA="0xF5AE70", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong DailyPayoutInboxMsg
		{
			[Address(RVA="0xF5AEB4", Offset="0xF5AEB4", VA="0xF5AEB4")]
			get
			{
				return new ulong();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF5AE9C", Offset="0xF5AE9C", VA="0xF5AE9C")]
			get
			{
				return new ulong();
			}
		}

		public uint KothRankMax
		{
			[Address(RVA="0xF5AEAC", Offset="0xF5AEAC", VA="0xF5AEAC")]
			get
			{
				return new uint();
			}
		}

		public uint KothRankMin
		{
			[Address(RVA="0xF5AEA4", Offset="0xF5AEA4", VA="0xF5AEA4")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF5AE84", Offset="0xF5AE84", VA="0xF5AE84")]
		public KothRank __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new KothRank();
		}

		[Address(RVA="0xF5AE78", Offset="0xF5AE78", VA="0xF5AE78", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2519FAC", Offset="0x2519FAC", VA="0x2519FAC")]
		public static void AddDailyPayoutInboxMsg(FlatBufferBuilder builder, ulong dailyPayoutInboxMsg)
		{
		}

		[Address(RVA="0x2519FE8", Offset="0x2519FE8", VA="0x2519FE8")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x251A024", Offset="0x251A024", VA="0x251A024")]
		public static void AddKothRankMax(FlatBufferBuilder builder, uint kothRankMax)
		{
		}

		[Address(RVA="0x251A060", Offset="0x251A060", VA="0x251A060")]
		public static void AddKothRankMin(FlatBufferBuilder builder, uint kothRankMin)
		{
		}

		[Address(RVA="0x2519F1C", Offset="0x2519F1C", VA="0x2519F1C")]
		public static Offset<KothRank> CreateKothRank(FlatBufferBuilder builder, ulong id = 0L, uint koth_rank_min = 0, uint koth_rank_max = 0, ulong daily_payout_inbox_msg = 0L)
		{
			return new Offset<KothRank>();
		}

		[Address(RVA="0x251A09C", Offset="0x251A09C", VA="0x251A09C")]
		public static Offset<KothRank> EndKothRank(FlatBufferBuilder builder)
		{
			return new Offset<KothRank>();
		}

		[Address(RVA="0x251A14C", Offset="0x251A14C", VA="0x251A14C")]
		public static void FinishKothRankBuffer(FlatBufferBuilder builder, Offset<KothRank> offset)
		{
		}

		[Address(RVA="0x2519CA0", Offset="0x2519CA0", VA="0x2519CA0")]
		public static KothRank GetRootAsKothRank(FlatBuffers.ByteBuffer _bb)
		{
			return new KothRank();
		}

		[Address(RVA="0x2519CAC", Offset="0x2519CAC", VA="0x2519CAC")]
		public static KothRank GetRootAsKothRank(FlatBuffers.ByteBuffer _bb, KothRank obj)
		{
			return new KothRank();
		}

		[Address(RVA="0x251A11C", Offset="0x251A11C", VA="0x251A11C")]
		public static void StartKothRank(FlatBufferBuilder builder)
		{
		}
	}
}