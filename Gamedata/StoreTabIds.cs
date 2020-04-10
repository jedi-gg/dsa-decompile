using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct StoreTabIds : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3B278", Offset="0xF3B278", VA="0xF3B278", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong DailyPvpRewardTab
		{
			[Address(RVA="0xF3B2B4", Offset="0xF3B2B4", VA="0xF3B2B4")]
			get
			{
				return new ulong();
			}
		}

		public ulong PassportTab
		{
			[Address(RVA="0xF3B2A4", Offset="0xF3B2A4", VA="0xF3B2A4")]
			get
			{
				return new ulong();
			}
		}

		public ulong PremiumCurrencyTab
		{
			[Address(RVA="0xF3B2AC", Offset="0xF3B2AC", VA="0xF3B2AC")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF3B28C", Offset="0xF3B28C", VA="0xF3B28C")]
		public StoreTabIds __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new StoreTabIds();
		}

		[Address(RVA="0xF3B280", Offset="0xF3B280", VA="0xF3B280", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22EB77C", Offset="0x22EB77C", VA="0x22EB77C")]
		public static void AddDailyPvpRewardTab(FlatBufferBuilder builder, ulong dailyPvpRewardTab)
		{
		}

		[Address(RVA="0x22EB7F4", Offset="0x22EB7F4", VA="0x22EB7F4")]
		public static void AddPassportTab(FlatBufferBuilder builder, ulong passportTab)
		{
		}

		[Address(RVA="0x22EB7B8", Offset="0x22EB7B8", VA="0x22EB7B8")]
		public static void AddPremiumCurrencyTab(FlatBufferBuilder builder, ulong premiumCurrencyTab)
		{
		}

		[Address(RVA="0x22EB704", Offset="0x22EB704", VA="0x22EB704")]
		public static Offset<StoreTabIds> CreateStoreTabIds(FlatBufferBuilder builder, ulong passport_tab = 0L, ulong premium_currency_tab = 0L, ulong daily_pvp_reward_tab = 0L)
		{
			return new Offset<StoreTabIds>();
		}

		[Address(RVA="0x22EB830", Offset="0x22EB830", VA="0x22EB830")]
		public static Offset<StoreTabIds> EndStoreTabIds(FlatBufferBuilder builder)
		{
			return new Offset<StoreTabIds>();
		}

		[Address(RVA="0x22EB4EC", Offset="0x22EB4EC", VA="0x22EB4EC")]
		public static StoreTabIds GetRootAsStoreTabIds(FlatBuffers.ByteBuffer _bb)
		{
			return new StoreTabIds();
		}

		[Address(RVA="0x22EB4F8", Offset="0x22EB4F8", VA="0x22EB4F8")]
		public static StoreTabIds GetRootAsStoreTabIds(FlatBuffers.ByteBuffer _bb, StoreTabIds obj)
		{
			return new StoreTabIds();
		}

		[Address(RVA="0x22EB8B0", Offset="0x22EB8B0", VA="0x22EB8B0")]
		public static void StartStoreTabIds(FlatBufferBuilder builder)
		{
		}
	}
}