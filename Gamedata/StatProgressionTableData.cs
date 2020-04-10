using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct StatProgressionTableData : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public float BaseMultiplier
		{
			[Address(RVA="0xF3A6E4", Offset="0xF3A6E4", VA="0xF3A6E4")]
			get
			{
				return new float();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3A6B8", Offset="0xF3A6B8", VA="0xF3A6B8", Slot="5")]
			get
			{
				return null;
			}
		}

		public float Defense
		{
			[Address(RVA="0xF3A6F4", Offset="0xF3A6F4", VA="0xF3A6F4")]
			get
			{
				return new float();
			}
		}

		public float Health
		{
			[Address(RVA="0xF3A6FC", Offset="0xF3A6FC", VA="0xF3A6FC")]
			get
			{
				return new float();
			}
		}

		public float Offense
		{
			[Address(RVA="0xF3A6EC", Offset="0xF3A6EC", VA="0xF3A6EC")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF3A6CC", Offset="0xF3A6CC", VA="0xF3A6CC")]
		public StatProgressionTableData __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new StatProgressionTableData();
		}

		[Address(RVA="0xF3A6C0", Offset="0xF3A6C0", VA="0xF3A6C0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22DFC28", Offset="0x22DFC28", VA="0x22DFC28")]
		public static void AddBaseMultiplier(FlatBufferBuilder builder, float baseMultiplier)
		{
		}

		[Address(RVA="0x22DFBA0", Offset="0x22DFBA0", VA="0x22DFBA0")]
		public static void AddDefense(FlatBufferBuilder builder, float defense)
		{
		}

		[Address(RVA="0x22DFB5C", Offset="0x22DFB5C", VA="0x22DFB5C")]
		public static void AddHealth(FlatBufferBuilder builder, float health)
		{
		}

		[Address(RVA="0x22DFBE4", Offset="0x22DFBE4", VA="0x22DFBE4")]
		public static void AddOffense(FlatBufferBuilder builder, float offense)
		{
		}

		[Address(RVA="0x22DFACC", Offset="0x22DFACC", VA="0x22DFACC")]
		public static Offset<StatProgressionTableData> CreateStatProgressionTableData(FlatBufferBuilder builder, float base_multiplier = 0f, float offense = 0f, float defense = 0f, float health = 0f)
		{
			return new Offset<StatProgressionTableData>();
		}

		[Address(RVA="0x22DFC6C", Offset="0x22DFC6C", VA="0x22DFC6C")]
		public static Offset<StatProgressionTableData> EndStatProgressionTableData(FlatBufferBuilder builder)
		{
			return new Offset<StatProgressionTableData>();
		}

		[Address(RVA="0x22DF860", Offset="0x22DF860", VA="0x22DF860")]
		public static StatProgressionTableData GetRootAsStatProgressionTableData(FlatBuffers.ByteBuffer _bb)
		{
			return new StatProgressionTableData();
		}

		[Address(RVA="0x22DF86C", Offset="0x22DF86C", VA="0x22DF86C")]
		public static StatProgressionTableData GetRootAsStatProgressionTableData(FlatBuffers.ByteBuffer _bb, StatProgressionTableData obj)
		{
			return new StatProgressionTableData();
		}

		[Address(RVA="0x22DFCEC", Offset="0x22DFCEC", VA="0x22DFCEC")]
		public static void StartStatProgressionTableData(FlatBufferBuilder builder)
		{
		}
	}
}