using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PlayerLevelEnergyConstants : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public uint AdRewardedAmount
		{
			[Address(RVA="0xF579C4", Offset="0xF579C4", VA="0xF579C4")]
			get
			{
				return new uint();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF57980", Offset="0xF57980", VA="0xF57980", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint DailyGiftAmount
		{
			[Address(RVA="0xF579BC", Offset="0xF579BC", VA="0xF579BC")]
			get
			{
				return new uint();
			}
		}

		public uint GeneratedCap
		{
			[Address(RVA="0xF579AC", Offset="0xF579AC", VA="0xF579AC")]
			get
			{
				return new uint();
			}
		}

		public uint RefreshGrantAmount
		{
			[Address(RVA="0xF579B4", Offset="0xF579B4", VA="0xF579B4")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF57994", Offset="0xF57994", VA="0xF57994")]
		public PlayerLevelEnergyConstants __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PlayerLevelEnergyConstants();
		}

		[Address(RVA="0xF57988", Offset="0xF57988", VA="0xF57988", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24DDFB0", Offset="0x24DDFB0", VA="0x24DDFB0")]
		public static void AddAdRewardedAmount(FlatBufferBuilder builder, uint adRewardedAmount)
		{
		}

		[Address(RVA="0x24DDFEC", Offset="0x24DDFEC", VA="0x24DDFEC")]
		public static void AddDailyGiftAmount(FlatBufferBuilder builder, uint dailyGiftAmount)
		{
		}

		[Address(RVA="0x24DE064", Offset="0x24DE064", VA="0x24DE064")]
		public static void AddGeneratedCap(FlatBufferBuilder builder, uint generatedCap)
		{
		}

		[Address(RVA="0x24DE028", Offset="0x24DE028", VA="0x24DE028")]
		public static void AddRefreshGrantAmount(FlatBufferBuilder builder, uint refreshGrantAmount)
		{
		}

		[Address(RVA="0x24DDF20", Offset="0x24DDF20", VA="0x24DDF20")]
		public static Offset<PlayerLevelEnergyConstants> CreatePlayerLevelEnergyConstants(FlatBufferBuilder builder, uint generated_cap = 0, uint refresh_grant_amount = 0, uint daily_gift_amount = 0, uint ad_rewarded_amount = 0)
		{
			return new Offset<PlayerLevelEnergyConstants>();
		}

		[Address(RVA="0x24DE0A0", Offset="0x24DE0A0", VA="0x24DE0A0")]
		public static Offset<PlayerLevelEnergyConstants> EndPlayerLevelEnergyConstants(FlatBufferBuilder builder)
		{
			return new Offset<PlayerLevelEnergyConstants>();
		}

		[Address(RVA="0x24DDCAC", Offset="0x24DDCAC", VA="0x24DDCAC")]
		public static PlayerLevelEnergyConstants GetRootAsPlayerLevelEnergyConstants(FlatBuffers.ByteBuffer _bb)
		{
			return new PlayerLevelEnergyConstants();
		}

		[Address(RVA="0x24DDCB8", Offset="0x24DDCB8", VA="0x24DDCB8")]
		public static PlayerLevelEnergyConstants GetRootAsPlayerLevelEnergyConstants(FlatBuffers.ByteBuffer _bb, PlayerLevelEnergyConstants obj)
		{
			return new PlayerLevelEnergyConstants();
		}

		[Address(RVA="0x24DE120", Offset="0x24DE120", VA="0x24DE120")]
		public static void StartPlayerLevelEnergyConstants(FlatBufferBuilder builder)
		{
		}
	}
}