using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PvpBattleEnvironmentWeight : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF580C0", Offset="0xF580C0", VA="0xF580C0", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Environment
		{
			[Address(RVA="0xF580F4", Offset="0xF580F4", VA="0xF580F4")]
			get
			{
				return new ulong();
			}
		}

		public float Weight
		{
			[Address(RVA="0xF580EC", Offset="0xF580EC", VA="0xF580EC")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF580D4", Offset="0xF580D4", VA="0xF580D4")]
		public PvpBattleEnvironmentWeight __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PvpBattleEnvironmentWeight();
		}

		[Address(RVA="0xF580C8", Offset="0xF580C8", VA="0xF580C8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E2AE0", Offset="0x24E2AE0", VA="0x24E2AE0")]
		public static void AddEnvironment(FlatBufferBuilder builder, ulong environment)
		{
		}

		[Address(RVA="0x24E2B1C", Offset="0x24E2B1C", VA="0x24E2B1C")]
		public static void AddWeight(FlatBufferBuilder builder, float weight)
		{
		}

		[Address(RVA="0x24E2A78", Offset="0x24E2A78", VA="0x24E2A78")]
		public static Offset<PvpBattleEnvironmentWeight> CreatePvpBattleEnvironmentWeight(FlatBufferBuilder builder, float weight = 0f, ulong environment = 0L)
		{
			return new Offset<PvpBattleEnvironmentWeight>();
		}

		[Address(RVA="0x24E2B60", Offset="0x24E2B60", VA="0x24E2B60")]
		public static Offset<PvpBattleEnvironmentWeight> EndPvpBattleEnvironmentWeight(FlatBufferBuilder builder)
		{
			return new Offset<PvpBattleEnvironmentWeight>();
		}

		[Address(RVA="0x24E28E4", Offset="0x24E28E4", VA="0x24E28E4")]
		public static PvpBattleEnvironmentWeight GetRootAsPvpBattleEnvironmentWeight(FlatBuffers.ByteBuffer _bb)
		{
			return new PvpBattleEnvironmentWeight();
		}

		[Address(RVA="0x24E28F0", Offset="0x24E28F0", VA="0x24E28F0")]
		public static PvpBattleEnvironmentWeight GetRootAsPvpBattleEnvironmentWeight(FlatBuffers.ByteBuffer _bb, PvpBattleEnvironmentWeight obj)
		{
			return new PvpBattleEnvironmentWeight();
		}

		[Address(RVA="0x24E2BE0", Offset="0x24E2BE0", VA="0x24E2BE0")]
		public static void StartPvpBattleEnvironmentWeight(FlatBufferBuilder builder)
		{
		}
	}
}