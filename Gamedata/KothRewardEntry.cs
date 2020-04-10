using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct KothRewardEntry : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56198", Offset="0xF56198", VA="0xF56198", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong InboxMessage
		{
			[Address(RVA="0xF561C4", Offset="0xF561C4", VA="0xF561C4")]
			get
			{
				return new ulong();
			}
		}

		public uint KothRankMax
		{
			[Address(RVA="0xF561D4", Offset="0xF561D4", VA="0xF561D4")]
			get
			{
				return new uint();
			}
		}

		public uint KothRankMin
		{
			[Address(RVA="0xF561CC", Offset="0xF561CC", VA="0xF561CC")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF561AC", Offset="0xF561AC", VA="0xF561AC")]
		public KothRewardEntry __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new KothRewardEntry();
		}

		[Address(RVA="0xF561A0", Offset="0xF561A0", VA="0xF561A0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D1714", Offset="0x24D1714", VA="0x24D1714")]
		public static void AddInboxMessage(FlatBufferBuilder builder, ulong inboxMessage)
		{
		}

		[Address(RVA="0x24D1750", Offset="0x24D1750", VA="0x24D1750")]
		public static void AddKothRankMax(FlatBufferBuilder builder, uint kothRankMax)
		{
		}

		[Address(RVA="0x24D178C", Offset="0x24D178C", VA="0x24D178C")]
		public static void AddKothRankMin(FlatBufferBuilder builder, uint kothRankMin)
		{
		}

		[Address(RVA="0x24D169C", Offset="0x24D169C", VA="0x24D169C")]
		public static Offset<KothRewardEntry> CreateKothRewardEntry(FlatBufferBuilder builder, ulong inbox_message = 0L, uint koth_rank_min = 0, uint koth_rank_max = 0)
		{
			return new Offset<KothRewardEntry>();
		}

		[Address(RVA="0x24D17C8", Offset="0x24D17C8", VA="0x24D17C8")]
		public static Offset<KothRewardEntry> EndKothRewardEntry(FlatBufferBuilder builder)
		{
			return new Offset<KothRewardEntry>();
		}

		[Address(RVA="0x24D148C", Offset="0x24D148C", VA="0x24D148C")]
		public static KothRewardEntry GetRootAsKothRewardEntry(FlatBuffers.ByteBuffer _bb)
		{
			return new KothRewardEntry();
		}

		[Address(RVA="0x24D1498", Offset="0x24D1498", VA="0x24D1498")]
		public static KothRewardEntry GetRootAsKothRewardEntry(FlatBuffers.ByteBuffer _bb, KothRewardEntry obj)
		{
			return new KothRewardEntry();
		}

		[Address(RVA="0x24D1848", Offset="0x24D1848", VA="0x24D1848")]
		public static void StartKothRewardEntry(FlatBufferBuilder builder)
		{
		}
	}
}