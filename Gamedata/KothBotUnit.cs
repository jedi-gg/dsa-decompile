using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct KothBotUnit : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5ADD8", Offset="0xF5ADD8", VA="0xF5ADD8", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint GearTier
		{
			[Address(RVA="0xF5AE14", Offset="0xF5AE14", VA="0xF5AE14")]
			get
			{
				return new uint();
			}
		}

		public uint Level
		{
			[Address(RVA="0xF5AE0C", Offset="0xF5AE0C", VA="0xF5AE0C")]
			get
			{
				return new uint();
			}
		}

		public uint StarLevel
		{
			[Address(RVA="0xF5AE1C", Offset="0xF5AE1C", VA="0xF5AE1C")]
			get
			{
				return new uint();
			}
		}

		public ulong Unit
		{
			[Address(RVA="0xF5AE04", Offset="0xF5AE04", VA="0xF5AE04")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF5ADEC", Offset="0xF5ADEC", VA="0xF5ADEC")]
		public KothBotUnit __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new KothBotUnit();
		}

		[Address(RVA="0xF5ADE0", Offset="0xF5ADE0", VA="0xF5ADE0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2519B70", Offset="0x2519B70", VA="0x2519B70")]
		public static void AddGearTier(FlatBufferBuilder builder, uint gearTier)
		{
		}

		[Address(RVA="0x2519BAC", Offset="0x2519BAC", VA="0x2519BAC")]
		public static void AddLevel(FlatBufferBuilder builder, uint level)
		{
		}

		[Address(RVA="0x2519B34", Offset="0x2519B34", VA="0x2519B34")]
		public static void AddStarLevel(FlatBufferBuilder builder, uint starLevel)
		{
		}

		[Address(RVA="0x2519AF8", Offset="0x2519AF8", VA="0x2519AF8")]
		public static void AddUnit(FlatBufferBuilder builder, ulong unit)
		{
		}

		[Address(RVA="0x2519A68", Offset="0x2519A68", VA="0x2519A68")]
		public static Offset<KothBotUnit> CreateKothBotUnit(FlatBufferBuilder builder, ulong unit = 0L, uint level = 0, uint gear_tier = 0, uint star_level = 0)
		{
			return new Offset<KothBotUnit>();
		}

		[Address(RVA="0x2519BE8", Offset="0x2519BE8", VA="0x2519BE8")]
		public static Offset<KothBotUnit> EndKothBotUnit(FlatBufferBuilder builder)
		{
			return new Offset<KothBotUnit>();
		}

		[Address(RVA="0x2519808", Offset="0x2519808", VA="0x2519808")]
		public static KothBotUnit GetRootAsKothBotUnit(FlatBuffers.ByteBuffer _bb)
		{
			return new KothBotUnit();
		}

		[Address(RVA="0x2519814", Offset="0x2519814", VA="0x2519814")]
		public static KothBotUnit GetRootAsKothBotUnit(FlatBuffers.ByteBuffer _bb, KothBotUnit obj)
		{
			return new KothBotUnit();
		}

		[Address(RVA="0x2519C68", Offset="0x2519C68", VA="0x2519C68")]
		public static void StartKothBotUnit(FlatBufferBuilder builder)
		{
		}
	}
}