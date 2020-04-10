using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ClubWarBattleEnvironmentWeight : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF43DC4", Offset="0xF43DC4", VA="0xF43DC4", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Environment
		{
			[Address(RVA="0xF43DF8", Offset="0xF43DF8", VA="0xF43DF8")]
			get
			{
				return new ulong();
			}
		}

		public float Weight
		{
			[Address(RVA="0xF43DF0", Offset="0xF43DF0", VA="0xF43DF0")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF43DD8", Offset="0xF43DD8", VA="0xF43DD8")]
		public ClubWarBattleEnvironmentWeight __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ClubWarBattleEnvironmentWeight();
		}

		[Address(RVA="0xF43DCC", Offset="0xF43DCC", VA="0xF43DCC", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2325E18", Offset="0x2325E18", VA="0x2325E18")]
		public static void AddEnvironment(FlatBufferBuilder builder, ulong environment)
		{
		}

		[Address(RVA="0x2325E54", Offset="0x2325E54", VA="0x2325E54")]
		public static void AddWeight(FlatBufferBuilder builder, float weight)
		{
		}

		[Address(RVA="0x2325DB0", Offset="0x2325DB0", VA="0x2325DB0")]
		public static Offset<ClubWarBattleEnvironmentWeight> CreateClubWarBattleEnvironmentWeight(FlatBufferBuilder builder, float weight = 0f, ulong environment = 0L)
		{
			return new Offset<ClubWarBattleEnvironmentWeight>();
		}

		[Address(RVA="0x2325E98", Offset="0x2325E98", VA="0x2325E98")]
		public static Offset<ClubWarBattleEnvironmentWeight> EndClubWarBattleEnvironmentWeight(FlatBufferBuilder builder)
		{
			return new Offset<ClubWarBattleEnvironmentWeight>();
		}

		[Address(RVA="0x2325C1C", Offset="0x2325C1C", VA="0x2325C1C")]
		public static ClubWarBattleEnvironmentWeight GetRootAsClubWarBattleEnvironmentWeight(FlatBuffers.ByteBuffer _bb)
		{
			return new ClubWarBattleEnvironmentWeight();
		}

		[Address(RVA="0x2325C28", Offset="0x2325C28", VA="0x2325C28")]
		public static ClubWarBattleEnvironmentWeight GetRootAsClubWarBattleEnvironmentWeight(FlatBuffers.ByteBuffer _bb, ClubWarBattleEnvironmentWeight obj)
		{
			return new ClubWarBattleEnvironmentWeight();
		}

		[Address(RVA="0x2325F18", Offset="0x2325F18", VA="0x2325F18")]
		public static void StartClubWarBattleEnvironmentWeight(FlatBufferBuilder builder)
		{
		}
	}
}