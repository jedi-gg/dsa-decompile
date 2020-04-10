using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitGearSlot : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public bool Accuracy
		{
			[Address(RVA="0xF0B9CC", Offset="0xF0B9CC", VA="0xF0B9CC")]
			get
			{
				return new bool();
			}
		}

		public bool AttackSpeed
		{
			[Address(RVA="0xF0B99C", Offset="0xF0B99C", VA="0xF0B99C")]
			get
			{
				return new bool();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0B940", Offset="0xF0B940", VA="0xF0B940", Slot="5")]
			get
			{
				return null;
			}
		}

		public bool CritChance
		{
			[Address(RVA="0xF0B98C", Offset="0xF0B98C", VA="0xF0B98C")]
			get
			{
				return new bool();
			}
		}

		public bool CritPower
		{
			[Address(RVA="0xF0B994", Offset="0xF0B994", VA="0xF0B994")]
			get
			{
				return new bool();
			}
		}

		public bool Defense
		{
			[Address(RVA="0xF0B974", Offset="0xF0B974", VA="0xF0B974")]
			get
			{
				return new bool();
			}
		}

		public bool Evasion
		{
			[Address(RVA="0xF0B9D4", Offset="0xF0B9D4", VA="0xF0B9D4")]
			get
			{
				return new bool();
			}
		}

		public ulong GearItem
		{
			[Address(RVA="0xF0B9A4", Offset="0xF0B9A4", VA="0xF0B9A4")]
			get
			{
				return new ulong();
			}
		}

		public bool Health
		{
			[Address(RVA="0xF0B97C", Offset="0xF0B97C", VA="0xF0B97C")]
			get
			{
				return new bool();
			}
		}

		public bool Offense
		{
			[Address(RVA="0xF0B96C", Offset="0xF0B96C", VA="0xF0B96C")]
			get
			{
				return new bool();
			}
		}

		public bool Potency
		{
			[Address(RVA="0xF0B9BC", Offset="0xF0B9BC", VA="0xF0B9BC")]
			get
			{
				return new bool();
			}
		}

		public bool Recovery
		{
			[Address(RVA="0xF0B984", Offset="0xF0B984", VA="0xF0B984")]
			get
			{
				return new bool();
			}
		}

		public uint RequiredUnitLevel
		{
			[Address(RVA="0xF0B9AC", Offset="0xF0B9AC", VA="0xF0B9AC")]
			get
			{
				return new uint();
			}
		}

		public bool Speed
		{
			[Address(RVA="0xF0B9B4", Offset="0xF0B9B4", VA="0xF0B9B4")]
			get
			{
				return new bool();
			}
		}

		public bool Tenacity
		{
			[Address(RVA="0xF0B9C4", Offset="0xF0B9C4", VA="0xF0B9C4")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0xF0B954", Offset="0xF0B954", VA="0xF0B954")]
		public UnitGearSlot __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitGearSlot();
		}

		[Address(RVA="0xF0B948", Offset="0xF0B948", VA="0xF0B948", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x167B248", Offset="0x167B248", VA="0x167B248")]
		public static void AddAccuracy(FlatBufferBuilder builder, bool accuracy)
		{
		}

		[Address(RVA="0x167B338", Offset="0x167B338", VA="0x167B338")]
		public static void AddAttackSpeed(FlatBufferBuilder builder, bool attackSpeed)
		{
		}

		[Address(RVA="0x167B3B0", Offset="0x167B3B0", VA="0x167B3B0")]
		public static void AddCritChance(FlatBufferBuilder builder, bool critChance)
		{
		}

		[Address(RVA="0x167B374", Offset="0x167B374", VA="0x167B374")]
		public static void AddCritPower(FlatBufferBuilder builder, bool critPower)
		{
		}

		[Address(RVA="0x167B464", Offset="0x167B464", VA="0x167B464")]
		public static void AddDefense(FlatBufferBuilder builder, bool defense)
		{
		}

		[Address(RVA="0x167B20C", Offset="0x167B20C", VA="0x167B20C")]
		public static void AddEvasion(FlatBufferBuilder builder, bool evasion)
		{
		}

		[Address(RVA="0x167B194", Offset="0x167B194", VA="0x167B194")]
		public static void AddGearItem(FlatBufferBuilder builder, ulong gearItem)
		{
		}

		[Address(RVA="0x167B428", Offset="0x167B428", VA="0x167B428")]
		public static void AddHealth(FlatBufferBuilder builder, bool health)
		{
		}

		[Address(RVA="0x167B4A0", Offset="0x167B4A0", VA="0x167B4A0")]
		public static void AddOffense(FlatBufferBuilder builder, bool offense)
		{
		}

		[Address(RVA="0x167B2C0", Offset="0x167B2C0", VA="0x167B2C0")]
		public static void AddPotency(FlatBufferBuilder builder, bool potency)
		{
		}

		[Address(RVA="0x167B3EC", Offset="0x167B3EC", VA="0x167B3EC")]
		public static void AddRecovery(FlatBufferBuilder builder, bool recovery)
		{
		}

		[Address(RVA="0x167B1D0", Offset="0x167B1D0", VA="0x167B1D0")]
		public static void AddRequiredUnitLevel(FlatBufferBuilder builder, uint requiredUnitLevel)
		{
		}

		[Address(RVA="0x167B2FC", Offset="0x167B2FC", VA="0x167B2FC")]
		public static void AddSpeed(FlatBufferBuilder builder, bool speed)
		{
		}

		[Address(RVA="0x167B284", Offset="0x167B284", VA="0x167B284")]
		public static void AddTenacity(FlatBufferBuilder builder, bool tenacity)
		{
		}

		[Address(RVA="0x167B040", Offset="0x167B040", VA="0x167B040")]
		public static Offset<UnitGearSlot> CreateUnitGearSlot(FlatBufferBuilder builder, bool offense = false, bool defense = false, bool health = false, bool recovery = false, bool crit_chance = false, bool crit_power = false, bool attack_speed = false, ulong gear_item = 0L, uint required_unit_level = 0, bool speed = false, bool potency = false, bool tenacity = false, bool accuracy = false, bool evasion = false)
		{
			return new Offset<UnitGearSlot>();
		}

		[Address(RVA="0x167B4DC", Offset="0x167B4DC", VA="0x167B4DC")]
		public static Offset<UnitGearSlot> EndUnitGearSlot(FlatBufferBuilder builder)
		{
			return new Offset<UnitGearSlot>();
		}

		[Address(RVA="0x167A9E8", Offset="0x167A9E8", VA="0x167A9E8")]
		public static UnitGearSlot GetRootAsUnitGearSlot(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitGearSlot();
		}

		[Address(RVA="0x167A9F4", Offset="0x167A9F4", VA="0x167A9F4")]
		public static UnitGearSlot GetRootAsUnitGearSlot(FlatBuffers.ByteBuffer _bb, UnitGearSlot obj)
		{
			return new UnitGearSlot();
		}

		[Address(RVA="0x167B55C", Offset="0x167B55C", VA="0x167B55C")]
		public static void StartUnitGearSlot(FlatBufferBuilder builder)
		{
		}
	}
}