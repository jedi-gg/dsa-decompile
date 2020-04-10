using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitSelectorSelectorWeight : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0BE58", Offset="0xF0BE58", VA="0xF0BE58", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Selector
		{
			[Address(RVA="0xF0BE8C", Offset="0xF0BE8C", VA="0xF0BE8C")]
			get
			{
				return new ulong();
			}
		}

		public float Weight
		{
			[Address(RVA="0xF0BE84", Offset="0xF0BE84", VA="0xF0BE84")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF0BE6C", Offset="0xF0BE6C", VA="0xF0BE6C")]
		public UnitSelectorSelectorWeight __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitSelectorSelectorWeight();
		}

		[Address(RVA="0xF0BE60", Offset="0xF0BE60", VA="0xF0BE60", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x167D990", Offset="0x167D990", VA="0x167D990")]
		public static void AddSelector(FlatBufferBuilder builder, ulong selector)
		{
		}

		[Address(RVA="0x167D9CC", Offset="0x167D9CC", VA="0x167D9CC")]
		public static void AddWeight(FlatBufferBuilder builder, float weight)
		{
		}

		[Address(RVA="0x167D928", Offset="0x167D928", VA="0x167D928")]
		public static Offset<UnitSelectorSelectorWeight> CreateUnitSelectorSelectorWeight(FlatBufferBuilder builder, float weight = 0f, ulong selector = 0L)
		{
			return new Offset<UnitSelectorSelectorWeight>();
		}

		[Address(RVA="0x167DA10", Offset="0x167DA10", VA="0x167DA10")]
		public static Offset<UnitSelectorSelectorWeight> EndUnitSelectorSelectorWeight(FlatBufferBuilder builder)
		{
			return new Offset<UnitSelectorSelectorWeight>();
		}

		[Address(RVA="0x167D794", Offset="0x167D794", VA="0x167D794")]
		public static UnitSelectorSelectorWeight GetRootAsUnitSelectorSelectorWeight(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitSelectorSelectorWeight();
		}

		[Address(RVA="0x167D7A0", Offset="0x167D7A0", VA="0x167D7A0")]
		public static UnitSelectorSelectorWeight GetRootAsUnitSelectorSelectorWeight(FlatBuffers.ByteBuffer _bb, UnitSelectorSelectorWeight obj)
		{
			return new UnitSelectorSelectorWeight();
		}

		[Address(RVA="0x167DA90", Offset="0x167DA90", VA="0x167DA90")]
		public static void StartUnitSelectorSelectorWeight(FlatBufferBuilder builder)
		{
		}
	}
}