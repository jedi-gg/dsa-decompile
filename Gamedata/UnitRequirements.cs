using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitRequirements : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0BD28", Offset="0xF0BD28", VA="0xF0BD28", Slot="5")]
			get
			{
				return null;
			}
		}

		public byte GearTier
		{
			[Address(RVA="0xF0BD5C", Offset="0xF0BD5C", VA="0xF0BD5C")]
			get
			{
				return new byte();
			}
		}

		public byte Level
		{
			[Address(RVA="0xF0BD54", Offset="0xF0BD54", VA="0xF0BD54")]
			get
			{
				return new byte();
			}
		}

		[Address(RVA="0xF0BD3C", Offset="0xF0BD3C", VA="0xF0BD3C")]
		public UnitRequirements __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitRequirements();
		}

		[Address(RVA="0xF0BD30", Offset="0xF0BD30", VA="0xF0BD30", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x167CDA8", Offset="0x167CDA8", VA="0x167CDA8")]
		public static void AddGearTier(FlatBufferBuilder builder, byte gearTier)
		{
		}

		[Address(RVA="0x167CDE4", Offset="0x167CDE4", VA="0x167CDE4")]
		public static void AddLevel(FlatBufferBuilder builder, byte level)
		{
		}

		[Address(RVA="0x167CD40", Offset="0x167CD40", VA="0x167CD40")]
		public static Offset<UnitRequirements> CreateUnitRequirements(FlatBufferBuilder builder, byte level = 0, byte gear_tier = 0)
		{
			return new Offset<UnitRequirements>();
		}

		[Address(RVA="0x167CE20", Offset="0x167CE20", VA="0x167CE20")]
		public static Offset<UnitRequirements> EndUnitRequirements(FlatBufferBuilder builder)
		{
			return new Offset<UnitRequirements>();
		}

		[Address(RVA="0x167CBB4", Offset="0x167CBB4", VA="0x167CBB4")]
		public static UnitRequirements GetRootAsUnitRequirements(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitRequirements();
		}

		[Address(RVA="0x167CBC0", Offset="0x167CBC0", VA="0x167CBC0")]
		public static UnitRequirements GetRootAsUnitRequirements(FlatBuffers.ByteBuffer _bb, UnitRequirements obj)
		{
			return new UnitRequirements();
		}

		[Address(RVA="0x167CEA0", Offset="0x167CEA0", VA="0x167CEA0")]
		public static void StartUnitRequirements(FlatBufferBuilder builder)
		{
		}
	}
}