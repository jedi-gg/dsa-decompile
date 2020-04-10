using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PlayerActivityIds : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF57900", Offset="0xF57900", VA="0xF57900", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong DailyPvp
		{
			[Address(RVA="0xF5792C", Offset="0xF5792C", VA="0xF5792C")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF57914", Offset="0xF57914", VA="0xF57914")]
		public PlayerActivityIds __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PlayerActivityIds();
		}

		[Address(RVA="0xF57908", Offset="0xF57908", VA="0xF57908", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24DDBB8", Offset="0x24DDBB8", VA="0x24DDBB8")]
		public static void AddDailyPvp(FlatBufferBuilder builder, ulong dailyPvp)
		{
		}

		[Address(RVA="0x24DDB68", Offset="0x24DDB68", VA="0x24DDB68")]
		public static Offset<PlayerActivityIds> CreatePlayerActivityIds(FlatBufferBuilder builder, ulong daily_pvp = 0L)
		{
			return new Offset<PlayerActivityIds>();
		}

		[Address(RVA="0x24DDBF4", Offset="0x24DDBF4", VA="0x24DDBF4")]
		public static Offset<PlayerActivityIds> EndPlayerActivityIds(FlatBufferBuilder builder)
		{
			return new Offset<PlayerActivityIds>();
		}

		[Address(RVA="0x24DDA28", Offset="0x24DDA28", VA="0x24DDA28")]
		public static PlayerActivityIds GetRootAsPlayerActivityIds(FlatBuffers.ByteBuffer _bb)
		{
			return new PlayerActivityIds();
		}

		[Address(RVA="0x24DDA34", Offset="0x24DDA34", VA="0x24DDA34")]
		public static PlayerActivityIds GetRootAsPlayerActivityIds(FlatBuffers.ByteBuffer _bb, PlayerActivityIds obj)
		{
			return new PlayerActivityIds();
		}

		[Address(RVA="0x24DDC74", Offset="0x24DDC74", VA="0x24DDC74")]
		public static void StartPlayerActivityIds(FlatBufferBuilder builder)
		{
		}
	}
}