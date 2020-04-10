using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct CurrencyIds : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF59AC0", Offset="0xF59AC0", VA="0xF59AC0", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Club
		{
			[Address(RVA="0xF59B0C", Offset="0xF59B0C", VA="0xF59B0C")]
			get
			{
				return new ulong();
			}
		}

		public ulong ClubDungeon
		{
			[Address(RVA="0xF59B14", Offset="0xF59B14", VA="0xF59B14")]
			get
			{
				return new ulong();
			}
		}

		public ulong DailyPvpReward
		{
			[Address(RVA="0xF59B34", Offset="0xF59B34", VA="0xF59B34")]
			get
			{
				return new ulong();
			}
		}

		public ulong GrandCampaign
		{
			[Address(RVA="0xF59B2C", Offset="0xF59B2C", VA="0xF59B2C")]
			get
			{
				return new ulong();
			}
		}

		public ulong Grind
		{
			[Address(RVA="0xF59AEC", Offset="0xF59AEC", VA="0xF59AEC")]
			get
			{
				return new ulong();
			}
		}

		public ulong Premium
		{
			[Address(RVA="0xF59AF4", Offset="0xF59AF4", VA="0xF59AF4")]
			get
			{
				return new ulong();
			}
		}

		public ulong Pvp
		{
			[Address(RVA="0xF59B1C", Offset="0xF59B1C", VA="0xF59B1C")]
			get
			{
				return new ulong();
			}
		}

		public ulong ShardShop
		{
			[Address(RVA="0xF59AFC", Offset="0xF59AFC", VA="0xF59AFC")]
			get
			{
				return new ulong();
			}
		}

		public ulong Social
		{
			[Address(RVA="0xF59B24", Offset="0xF59B24", VA="0xF59B24")]
			get
			{
				return new ulong();
			}
		}

		public ulong Tower
		{
			[Address(RVA="0xF59B04", Offset="0xF59B04", VA="0xF59B04")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF59AD4", Offset="0xF59AD4", VA="0xF59AD4")]
		public CurrencyIds __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new CurrencyIds();
		}

		[Address(RVA="0xF59AC8", Offset="0xF59AC8", VA="0xF59AC8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x250DA5C", Offset="0x250DA5C", VA="0x250DA5C")]
		public static void AddClub(FlatBufferBuilder builder, ulong club)
		{
		}

		[Address(RVA="0x250DA20", Offset="0x250DA20", VA="0x250DA20")]
		public static void AddClubDungeon(FlatBufferBuilder builder, ulong clubDungeon)
		{
		}

		[Address(RVA="0x250D930", Offset="0x250D930", VA="0x250D930")]
		public static void AddDailyPvpReward(FlatBufferBuilder builder, ulong dailyPvpReward)
		{
		}

		[Address(RVA="0x250D96C", Offset="0x250D96C", VA="0x250D96C")]
		public static void AddGrandCampaign(FlatBufferBuilder builder, ulong grandCampaign)
		{
		}

		[Address(RVA="0x250DB4C", Offset="0x250DB4C", VA="0x250DB4C")]
		public static void AddGrind(FlatBufferBuilder builder, ulong grind)
		{
		}

		[Address(RVA="0x250DB10", Offset="0x250DB10", VA="0x250DB10")]
		public static void AddPremium(FlatBufferBuilder builder, ulong premium)
		{
		}

		[Address(RVA="0x250D9E4", Offset="0x250D9E4", VA="0x250D9E4")]
		public static void AddPvp(FlatBufferBuilder builder, ulong pvp)
		{
		}

		[Address(RVA="0x250DAD4", Offset="0x250DAD4", VA="0x250DAD4")]
		public static void AddShardShop(FlatBufferBuilder builder, ulong shardShop)
		{
		}

		[Address(RVA="0x250D9A8", Offset="0x250D9A8", VA="0x250D9A8")]
		public static void AddSocial(FlatBufferBuilder builder, ulong social)
		{
		}

		[Address(RVA="0x250DA98", Offset="0x250DA98", VA="0x250DA98")]
		public static void AddTower(FlatBufferBuilder builder, ulong tower)
		{
		}

		[Address(RVA="0x250D82C", Offset="0x250D82C", VA="0x250D82C")]
		public static Offset<CurrencyIds> CreateCurrencyIds(FlatBufferBuilder builder, ulong grind = 0L, ulong premium = 0L, ulong shard_shop = 0L, ulong tower = 0L, ulong club = 0L, ulong club_dungeon = 0L, ulong pvp = 0L, ulong social = 0L, ulong grand_campaign = 0L, ulong daily_pvp_reward = 0L)
		{
			return new Offset<CurrencyIds>();
		}

		[Address(RVA="0x250DB88", Offset="0x250DB88", VA="0x250DB88")]
		public static Offset<CurrencyIds> EndCurrencyIds(FlatBufferBuilder builder)
		{
			return new Offset<CurrencyIds>();
		}

		[Address(RVA="0x250D320", Offset="0x250D320", VA="0x250D320")]
		public static CurrencyIds GetRootAsCurrencyIds(FlatBuffers.ByteBuffer _bb)
		{
			return new CurrencyIds();
		}

		[Address(RVA="0x250D32C", Offset="0x250D32C", VA="0x250D32C")]
		public static CurrencyIds GetRootAsCurrencyIds(FlatBuffers.ByteBuffer _bb, CurrencyIds obj)
		{
			return new CurrencyIds();
		}

		[Address(RVA="0x250DC08", Offset="0x250DC08", VA="0x250DC08")]
		public static void StartCurrencyIds(FlatBufferBuilder builder)
		{
		}
	}
}