using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleSpawnPoint : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0AB80", Offset="0xF0AB80", VA="0xF0AB80", Slot="5")]
			get
			{
				return null;
			}
		}

		public Gamedata.UnitType UnitType
		{
			[Address(RVA="0xF0ABAC", Offset="0xF0ABAC", VA="0xF0ABAC")]
			get
			{
				return new Gamedata.UnitType();
			}
		}

		public float X
		{
			[Address(RVA="0xF0ABB4", Offset="0xF0ABB4", VA="0xF0ABB4")]
			get
			{
				return new float();
			}
		}

		public float Y
		{
			[Address(RVA="0xF0ABBC", Offset="0xF0ABBC", VA="0xF0ABBC")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF0AB94", Offset="0xF0AB94", VA="0xF0AB94")]
		public BattleSpawnPoint __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleSpawnPoint();
		}

		[Address(RVA="0xF0AB88", Offset="0xF0AB88", VA="0xF0AB88", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15F6154", Offset="0x15F6154", VA="0x15F6154")]
		public static void AddUnitType(FlatBufferBuilder builder, Gamedata.UnitType unitType)
		{
		}

		[Address(RVA="0x15F6110", Offset="0x15F6110", VA="0x15F6110")]
		public static void AddX(FlatBufferBuilder builder, float x)
		{
		}

		[Address(RVA="0x15F60CC", Offset="0x15F60CC", VA="0x15F60CC")]
		public static void AddY(FlatBufferBuilder builder, float y)
		{
		}

		[Address(RVA="0x15F6054", Offset="0x15F6054", VA="0x15F6054")]
		public static Offset<BattleSpawnPoint> CreateBattleSpawnPoint(FlatBufferBuilder builder, Gamedata.UnitType unit_type = 0, float x = 0f, float y = 0f)
		{
			return new Offset<BattleSpawnPoint>();
		}

		[Address(RVA="0x15F6190", Offset="0x15F6190", VA="0x15F6190")]
		public static Offset<BattleSpawnPoint> EndBattleSpawnPoint(FlatBufferBuilder builder)
		{
			return new Offset<BattleSpawnPoint>();
		}

		[Address(RVA="0x15F5E58", Offset="0x15F5E58", VA="0x15F5E58")]
		public static BattleSpawnPoint GetRootAsBattleSpawnPoint(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleSpawnPoint();
		}

		[Address(RVA="0x15F5E64", Offset="0x15F5E64", VA="0x15F5E64")]
		public static BattleSpawnPoint GetRootAsBattleSpawnPoint(FlatBuffers.ByteBuffer _bb, BattleSpawnPoint obj)
		{
			return new BattleSpawnPoint();
		}

		[Address(RVA="0x15F6210", Offset="0x15F6210", VA="0x15F6210")]
		public static void StartBattleSpawnPoint(FlatBufferBuilder builder)
		{
		}
	}
}