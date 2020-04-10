using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct KothRankData : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5AF08", Offset="0xF5AF08", VA="0xF5AF08", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint EasyMax
		{
			[Address(RVA="0xF5AF44", Offset="0xF5AF44", VA="0xF5AF44")]
			get
			{
				return new uint();
			}
		}

		public uint EasyMin
		{
			[Address(RVA="0xF5AF3C", Offset="0xF5AF3C", VA="0xF5AF3C")]
			get
			{
				return new uint();
			}
		}

		public uint HardMax
		{
			[Address(RVA="0xF5AF64", Offset="0xF5AF64", VA="0xF5AF64")]
			get
			{
				return new uint();
			}
		}

		public uint HardMin
		{
			[Address(RVA="0xF5AF5C", Offset="0xF5AF5C", VA="0xF5AF5C")]
			get
			{
				return new uint();
			}
		}

		public uint MaxRank
		{
			[Address(RVA="0xF5AF34", Offset="0xF5AF34", VA="0xF5AF34")]
			get
			{
				return new uint();
			}
		}

		public uint MediumMax
		{
			[Address(RVA="0xF5AF54", Offset="0xF5AF54", VA="0xF5AF54")]
			get
			{
				return new uint();
			}
		}

		public uint MediumMin
		{
			[Address(RVA="0xF5AF4C", Offset="0xF5AF4C", VA="0xF5AF4C")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF5AF1C", Offset="0xF5AF1C", VA="0xF5AF1C")]
		public KothRankData __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new KothRankData();
		}

		[Address(RVA="0xF5AF10", Offset="0xF5AF10", VA="0xF5AF10", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x251A6EC", Offset="0x251A6EC", VA="0x251A6EC")]
		public static void AddEasyMax(FlatBufferBuilder builder, uint easyMax)
		{
		}

		[Address(RVA="0x251A728", Offset="0x251A728", VA="0x251A728")]
		public static void AddEasyMin(FlatBufferBuilder builder, uint easyMin)
		{
		}

		[Address(RVA="0x251A5FC", Offset="0x251A5FC", VA="0x251A5FC")]
		public static void AddHardMax(FlatBufferBuilder builder, uint hardMax)
		{
		}

		[Address(RVA="0x251A638", Offset="0x251A638", VA="0x251A638")]
		public static void AddHardMin(FlatBufferBuilder builder, uint hardMin)
		{
		}

		[Address(RVA="0x251A764", Offset="0x251A764", VA="0x251A764")]
		public static void AddMaxRank(FlatBufferBuilder builder, uint maxRank)
		{
		}

		[Address(RVA="0x251A674", Offset="0x251A674", VA="0x251A674")]
		public static void AddMediumMax(FlatBufferBuilder builder, uint mediumMax)
		{
		}

		[Address(RVA="0x251A6B0", Offset="0x251A6B0", VA="0x251A6B0")]
		public static void AddMediumMin(FlatBufferBuilder builder, uint mediumMin)
		{
		}

		[Address(RVA="0x251A534", Offset="0x251A534", VA="0x251A534")]
		public static Offset<KothRankData> CreateKothRankData(FlatBufferBuilder builder, uint max_rank = 0, uint easy_min = 0, uint easy_max = 0, uint medium_min = 0, uint medium_max = 0, uint hard_min = 0, uint hard_max = 0)
		{
			return new Offset<KothRankData>();
		}

		[Address(RVA="0x251A7A0", Offset="0x251A7A0", VA="0x251A7A0")]
		public static Offset<KothRankData> EndKothRankData(FlatBufferBuilder builder)
		{
			return new Offset<KothRankData>();
		}

		[Address(RVA="0x251A188", Offset="0x251A188", VA="0x251A188")]
		public static KothRankData GetRootAsKothRankData(FlatBuffers.ByteBuffer _bb)
		{
			return new KothRankData();
		}

		[Address(RVA="0x251A194", Offset="0x251A194", VA="0x251A194")]
		public static KothRankData GetRootAsKothRankData(FlatBuffers.ByteBuffer _bb, KothRankData obj)
		{
			return new KothRankData();
		}

		[Address(RVA="0x251A820", Offset="0x251A820", VA="0x251A820")]
		public static void StartKothRankData(FlatBufferBuilder builder)
		{
		}
	}
}