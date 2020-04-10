using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitSelectorUnitWeight : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0BEE0", Offset="0xF0BEE0", VA="0xF0BEE0", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Unit
		{
			[Address(RVA="0xF0BF14", Offset="0xF0BF14", VA="0xF0BF14")]
			get
			{
				return new ulong();
			}
		}

		public float Weight
		{
			[Address(RVA="0xF0BF0C", Offset="0xF0BF0C", VA="0xF0BF0C")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF0BEF4", Offset="0xF0BEF4", VA="0xF0BEF4")]
		public UnitSelectorUnitWeight __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitSelectorUnitWeight();
		}

		[Address(RVA="0xF0BEE8", Offset="0xF0BEE8", VA="0xF0BEE8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x167DCC4", Offset="0x167DCC4", VA="0x167DCC4")]
		public static void AddUnit(FlatBufferBuilder builder, ulong unit)
		{
		}

		[Address(RVA="0x167DD00", Offset="0x167DD00", VA="0x167DD00")]
		public static void AddWeight(FlatBufferBuilder builder, float weight)
		{
		}

		[Address(RVA="0x167DC5C", Offset="0x167DC5C", VA="0x167DC5C")]
		public static Offset<UnitSelectorUnitWeight> CreateUnitSelectorUnitWeight(FlatBufferBuilder builder, float weight = 0f, ulong unit = 0L)
		{
			return new Offset<UnitSelectorUnitWeight>();
		}

		[Address(RVA="0x167DD44", Offset="0x167DD44", VA="0x167DD44")]
		public static Offset<UnitSelectorUnitWeight> EndUnitSelectorUnitWeight(FlatBufferBuilder builder)
		{
			return new Offset<UnitSelectorUnitWeight>();
		}

		[Address(RVA="0x167DAC8", Offset="0x167DAC8", VA="0x167DAC8")]
		public static UnitSelectorUnitWeight GetRootAsUnitSelectorUnitWeight(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitSelectorUnitWeight();
		}

		[Address(RVA="0x167DAD4", Offset="0x167DAD4", VA="0x167DAD4")]
		public static UnitSelectorUnitWeight GetRootAsUnitSelectorUnitWeight(FlatBuffers.ByteBuffer _bb, UnitSelectorUnitWeight obj)
		{
			return new UnitSelectorUnitWeight();
		}

		[Address(RVA="0x167DDC4", Offset="0x167DDC4", VA="0x167DDC4")]
		public static void StartUnitSelectorUnitWeight(FlatBufferBuilder builder)
		{
		}
	}
}