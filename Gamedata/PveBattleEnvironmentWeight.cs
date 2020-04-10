using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PveBattleEnvironmentWeight : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF57E90", Offset="0xF57E90", VA="0xF57E90", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Environment
		{
			[Address(RVA="0xF57EC4", Offset="0xF57EC4", VA="0xF57EC4")]
			get
			{
				return new ulong();
			}
		}

		public float Weight
		{
			[Address(RVA="0xF57EBC", Offset="0xF57EBC", VA="0xF57EBC")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF57EA4", Offset="0xF57EA4", VA="0xF57EA4")]
		public PveBattleEnvironmentWeight __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PveBattleEnvironmentWeight();
		}

		[Address(RVA="0xF57E98", Offset="0xF57E98", VA="0xF57E98", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E154C", Offset="0x24E154C", VA="0x24E154C")]
		public static void AddEnvironment(FlatBufferBuilder builder, ulong environment)
		{
		}

		[Address(RVA="0x24E1588", Offset="0x24E1588", VA="0x24E1588")]
		public static void AddWeight(FlatBufferBuilder builder, float weight)
		{
		}

		[Address(RVA="0x24E14E4", Offset="0x24E14E4", VA="0x24E14E4")]
		public static Offset<PveBattleEnvironmentWeight> CreatePveBattleEnvironmentWeight(FlatBufferBuilder builder, float weight = 0f, ulong environment = 0L)
		{
			return new Offset<PveBattleEnvironmentWeight>();
		}

		[Address(RVA="0x24E15CC", Offset="0x24E15CC", VA="0x24E15CC")]
		public static Offset<PveBattleEnvironmentWeight> EndPveBattleEnvironmentWeight(FlatBufferBuilder builder)
		{
			return new Offset<PveBattleEnvironmentWeight>();
		}

		[Address(RVA="0x24E1350", Offset="0x24E1350", VA="0x24E1350")]
		public static PveBattleEnvironmentWeight GetRootAsPveBattleEnvironmentWeight(FlatBuffers.ByteBuffer _bb)
		{
			return new PveBattleEnvironmentWeight();
		}

		[Address(RVA="0x24E135C", Offset="0x24E135C", VA="0x24E135C")]
		public static PveBattleEnvironmentWeight GetRootAsPveBattleEnvironmentWeight(FlatBuffers.ByteBuffer _bb, PveBattleEnvironmentWeight obj)
		{
			return new PveBattleEnvironmentWeight();
		}

		[Address(RVA="0x24E164C", Offset="0x24E164C", VA="0x24E164C")]
		public static void StartPveBattleEnvironmentWeight(FlatBufferBuilder builder)
		{
		}
	}
}