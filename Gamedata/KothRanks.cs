using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct KothRanks : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56108", Offset="0xF56108", VA="0xF56108", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong InboxMessage
		{
			[Address(RVA="0xF56144", Offset="0xF56144", VA="0xF56144")]
			get
			{
				return new ulong();
			}
		}

		public uint KothRankMax
		{
			[Address(RVA="0xF5613C", Offset="0xF5613C", VA="0xF5613C")]
			get
			{
				return new uint();
			}
		}

		public uint KothRankMin
		{
			[Address(RVA="0xF56134", Offset="0xF56134", VA="0xF56134")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF5611C", Offset="0xF5611C", VA="0xF5611C")]
		public KothRanks __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new KothRanks();
		}

		[Address(RVA="0xF56110", Offset="0xF56110", VA="0xF56110", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D12EC", Offset="0x24D12EC", VA="0x24D12EC")]
		public static void AddInboxMessage(FlatBufferBuilder builder, ulong inboxMessage)
		{
		}

		[Address(RVA="0x24D1328", Offset="0x24D1328", VA="0x24D1328")]
		public static void AddKothRankMax(FlatBufferBuilder builder, uint kothRankMax)
		{
		}

		[Address(RVA="0x24D1364", Offset="0x24D1364", VA="0x24D1364")]
		public static void AddKothRankMin(FlatBufferBuilder builder, uint kothRankMin)
		{
		}

		[Address(RVA="0x24D1274", Offset="0x24D1274", VA="0x24D1274")]
		public static Offset<KothRanks> CreateKothRanks(FlatBufferBuilder builder, uint koth_rank_min = 0, uint koth_rank_max = 0, ulong inbox_message = 0L)
		{
			return new Offset<KothRanks>();
		}

		[Address(RVA="0x24D13A0", Offset="0x24D13A0", VA="0x24D13A0")]
		public static Offset<KothRanks> EndKothRanks(FlatBufferBuilder builder)
		{
			return new Offset<KothRanks>();
		}

		[Address(RVA="0x24D1450", Offset="0x24D1450", VA="0x24D1450")]
		public static void FinishKothRanksBuffer(FlatBufferBuilder builder, Offset<KothRanks> offset)
		{
		}

		[Address(RVA="0x24D1064", Offset="0x24D1064", VA="0x24D1064")]
		public static KothRanks GetRootAsKothRanks(FlatBuffers.ByteBuffer _bb)
		{
			return new KothRanks();
		}

		[Address(RVA="0x24D1070", Offset="0x24D1070", VA="0x24D1070")]
		public static KothRanks GetRootAsKothRanks(FlatBuffers.ByteBuffer _bb, KothRanks obj)
		{
			return new KothRanks();
		}

		[Address(RVA="0x24D1420", Offset="0x24D1420", VA="0x24D1420")]
		public static void StartKothRanks(FlatBufferBuilder builder)
		{
		}
	}
}