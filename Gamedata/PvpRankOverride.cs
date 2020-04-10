using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PvpRankOverride : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF58248", Offset="0xF58248", VA="0xF58248", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong LootForLoss
		{
			[Address(RVA="0xF58284", Offset="0xF58284", VA="0xF58284")]
			get
			{
				return new ulong();
			}
		}

		public ulong LootForWin
		{
			[Address(RVA="0xF5827C", Offset="0xF5827C", VA="0xF5827C")]
			get
			{
				return new ulong();
			}
		}

		public ulong RankOverride
		{
			[Address(RVA="0xF58274", Offset="0xF58274", VA="0xF58274")]
			get
			{
				return new ulong();
			}
		}

		public ulong SeasonPayoutInboxMsg
		{
			[Address(RVA="0xF58294", Offset="0xF58294", VA="0xF58294")]
			get
			{
				return new ulong();
			}
		}

		public ulong WeeklyPayoutInboxMsg
		{
			[Address(RVA="0xF5828C", Offset="0xF5828C", VA="0xF5828C")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF5825C", Offset="0xF5825C", VA="0xF5825C")]
		public PvpRankOverride __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PvpRankOverride();
		}

		[Address(RVA="0xF58250", Offset="0xF58250", VA="0xF58250", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E3B6C", Offset="0x24E3B6C", VA="0x24E3B6C")]
		public static void AddLootForLoss(FlatBufferBuilder builder, ulong lootForLoss)
		{
		}

		[Address(RVA="0x24E3BA8", Offset="0x24E3BA8", VA="0x24E3BA8")]
		public static void AddLootForWin(FlatBufferBuilder builder, ulong lootForWin)
		{
		}

		[Address(RVA="0x24E3BE4", Offset="0x24E3BE4", VA="0x24E3BE4")]
		public static void AddRankOverride(FlatBufferBuilder builder, ulong rankOverride)
		{
		}

		[Address(RVA="0x24E3AF4", Offset="0x24E3AF4", VA="0x24E3AF4")]
		public static void AddSeasonPayoutInboxMsg(FlatBufferBuilder builder, ulong seasonPayoutInboxMsg)
		{
		}

		[Address(RVA="0x24E3B30", Offset="0x24E3B30", VA="0x24E3B30")]
		public static void AddWeeklyPayoutInboxMsg(FlatBufferBuilder builder, ulong weeklyPayoutInboxMsg)
		{
		}

		[Address(RVA="0x24E3A54", Offset="0x24E3A54", VA="0x24E3A54")]
		public static Offset<PvpRankOverride> CreatePvpRankOverride(FlatBufferBuilder builder, ulong rank_override = 0L, ulong loot_for_win = 0L, ulong loot_for_loss = 0L, ulong weekly_payout_inbox_msg = 0L, ulong season_payout_inbox_msg = 0L)
		{
			return new Offset<PvpRankOverride>();
		}

		[Address(RVA="0x24E3C20", Offset="0x24E3C20", VA="0x24E3C20")]
		public static Offset<PvpRankOverride> EndPvpRankOverride(FlatBufferBuilder builder)
		{
			return new Offset<PvpRankOverride>();
		}

		[Address(RVA="0x24E3764", Offset="0x24E3764", VA="0x24E3764")]
		public static PvpRankOverride GetRootAsPvpRankOverride(FlatBuffers.ByteBuffer _bb)
		{
			return new PvpRankOverride();
		}

		[Address(RVA="0x24E3770", Offset="0x24E3770", VA="0x24E3770")]
		public static PvpRankOverride GetRootAsPvpRankOverride(FlatBuffers.ByteBuffer _bb, PvpRankOverride obj)
		{
			return new PvpRankOverride();
		}

		[Address(RVA="0x24E3CA0", Offset="0x24E3CA0", VA="0x24E3CA0")]
		public static void StartPvpRankOverride(FlatBufferBuilder builder)
		{
		}
	}
}