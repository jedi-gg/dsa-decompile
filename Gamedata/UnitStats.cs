using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitStats : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public float Accuracy
		{
			[Address(RVA="0xF0C16C", Offset="0xF0C16C", VA="0xF0C16C")]
			get
			{
				return new float();
			}
		}

		public float AttackSpeed
		{
			[Address(RVA="0xF0C14C", Offset="0xF0C14C", VA="0xF0C14C")]
			get
			{
				return new float();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0C0F0", Offset="0xF0C0F0", VA="0xF0C0F0", Slot="5")]
			get
			{
				return null;
			}
		}

		public float CritChance
		{
			[Address(RVA="0xF0C13C", Offset="0xF0C13C", VA="0xF0C13C")]
			get
			{
				return new float();
			}
		}

		public float CritPower
		{
			[Address(RVA="0xF0C144", Offset="0xF0C144", VA="0xF0C144")]
			get
			{
				return new float();
			}
		}

		public int Defense
		{
			[Address(RVA="0xF0C124", Offset="0xF0C124", VA="0xF0C124")]
			get
			{
				return new int();
			}
		}

		public float Evasion
		{
			[Address(RVA="0xF0C174", Offset="0xF0C174", VA="0xF0C174")]
			get
			{
				return new float();
			}
		}

		public int Health
		{
			[Address(RVA="0xF0C12C", Offset="0xF0C12C", VA="0xF0C12C")]
			get
			{
				return new int();
			}
		}

		public int Offense
		{
			[Address(RVA="0xF0C11C", Offset="0xF0C11C", VA="0xF0C11C")]
			get
			{
				return new int();
			}
		}

		public float Potency
		{
			[Address(RVA="0xF0C15C", Offset="0xF0C15C", VA="0xF0C15C")]
			get
			{
				return new float();
			}
		}

		public int Recovery
		{
			[Address(RVA="0xF0C134", Offset="0xF0C134", VA="0xF0C134")]
			get
			{
				return new int();
			}
		}

		public int Speed
		{
			[Address(RVA="0xF0C154", Offset="0xF0C154", VA="0xF0C154")]
			get
			{
				return new int();
			}
		}

		public float Tenacity
		{
			[Address(RVA="0xF0C164", Offset="0xF0C164", VA="0xF0C164")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF0C104", Offset="0xF0C104", VA="0xF0C104")]
		public UnitStats __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitStats();
		}

		[Address(RVA="0xF0C0F8", Offset="0xF0C0F8", VA="0xF0C0F8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x167F064", Offset="0x167F064", VA="0x167F064")]
		public static void AddAccuracy(FlatBufferBuilder builder, float accuracy)
		{
		}

		[Address(RVA="0x167F16C", Offset="0x167F16C", VA="0x167F16C")]
		public static void AddAttackSpeed(FlatBufferBuilder builder, float attackSpeed)
		{
		}

		[Address(RVA="0x167F1F4", Offset="0x167F1F4", VA="0x167F1F4")]
		public static void AddCritChance(FlatBufferBuilder builder, float critChance)
		{
		}

		[Address(RVA="0x167F1B0", Offset="0x167F1B0", VA="0x167F1B0")]
		public static void AddCritPower(FlatBufferBuilder builder, float critPower)
		{
		}

		[Address(RVA="0x167F2B0", Offset="0x167F2B0", VA="0x167F2B0")]
		public static void AddDefense(FlatBufferBuilder builder, int defense)
		{
		}

		[Address(RVA="0x167F020", Offset="0x167F020", VA="0x167F020")]
		public static void AddEvasion(FlatBufferBuilder builder, float evasion)
		{
		}

		[Address(RVA="0x167F274", Offset="0x167F274", VA="0x167F274")]
		public static void AddHealth(FlatBufferBuilder builder, int health)
		{
		}

		[Address(RVA="0x167F2EC", Offset="0x167F2EC", VA="0x167F2EC")]
		public static void AddOffense(FlatBufferBuilder builder, int offense)
		{
		}

		[Address(RVA="0x167F0EC", Offset="0x167F0EC", VA="0x167F0EC")]
		public static void AddPotency(FlatBufferBuilder builder, float potency)
		{
		}

		[Address(RVA="0x167F238", Offset="0x167F238", VA="0x167F238")]
		public static void AddRecovery(FlatBufferBuilder builder, int recovery)
		{
		}

		[Address(RVA="0x167F130", Offset="0x167F130", VA="0x167F130")]
		public static void AddSpeed(FlatBufferBuilder builder, int speed)
		{
		}

		[Address(RVA="0x167F0A8", Offset="0x167F0A8", VA="0x167F0A8")]
		public static void AddTenacity(FlatBufferBuilder builder, float tenacity)
		{
		}

		[Address(RVA="0x167EEF0", Offset="0x167EEF0", VA="0x167EEF0")]
		public static Offset<UnitStats> CreateUnitStats(FlatBufferBuilder builder, int offense = 0, int defense = 0, int health = 0, int recovery = 0, float crit_chance = 0f, float crit_power = 0f, float attack_speed = 0f, int speed = 0, float potency = 0f, float tenacity = 0f, float accuracy = 0f, float evasion = 0f)
		{
			return new Offset<UnitStats>();
		}

		[Address(RVA="0x167F328", Offset="0x167F328", VA="0x167F328")]
		public static Offset<UnitStats> EndUnitStats(FlatBufferBuilder builder)
		{
			return new Offset<UnitStats>();
		}

		[Address(RVA="0x167E938", Offset="0x167E938", VA="0x167E938")]
		public static UnitStats GetRootAsUnitStats(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitStats();
		}

		[Address(RVA="0x167E944", Offset="0x167E944", VA="0x167E944")]
		public static UnitStats GetRootAsUnitStats(FlatBuffers.ByteBuffer _bb, UnitStats obj)
		{
			return new UnitStats();
		}

		[Address(RVA="0x167F3A8", Offset="0x167F3A8", VA="0x167F3A8")]
		public static void StartUnitStats(FlatBufferBuilder builder)
		{
		}
	}
}