using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitStatOverride : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public byte AbilityLevel
		{
			[Address(RVA="0xF0C094", Offset="0xF0C094", VA="0xF0C094")]
			get
			{
				return new byte();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0C050", Offset="0xF0C050", VA="0xF0C050", Slot="5")]
			get
			{
				return null;
			}
		}

		public byte GearTier
		{
			[Address(RVA="0xF0C08C", Offset="0xF0C08C", VA="0xF0C08C")]
			get
			{
				return new byte();
			}
		}

		public float GearTierProgress
		{
			[Address(RVA="0xF0C09C", Offset="0xF0C09C", VA="0xF0C09C")]
			get
			{
				return new float();
			}
		}

		public byte Level
		{
			[Address(RVA="0xF0C07C", Offset="0xF0C07C", VA="0xF0C07C")]
			get
			{
				return new byte();
			}
		}

		public byte Rarity
		{
			[Address(RVA="0xF0C084", Offset="0xF0C084", VA="0xF0C084")]
			get
			{
				return new byte();
			}
		}

		[Address(RVA="0xF0C064", Offset="0xF0C064", VA="0xF0C064")]
		public UnitStatOverride __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitStatOverride();
		}

		[Address(RVA="0xF0C058", Offset="0xF0C058", VA="0xF0C058", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x167E790", Offset="0x167E790", VA="0x167E790")]
		public static void AddAbilityLevel(FlatBufferBuilder builder, byte abilityLevel)
		{
		}

		[Address(RVA="0x167E7CC", Offset="0x167E7CC", VA="0x167E7CC")]
		public static void AddGearTier(FlatBufferBuilder builder, byte gearTier)
		{
		}

		[Address(RVA="0x167E74C", Offset="0x167E74C", VA="0x167E74C")]
		public static void AddGearTierProgress(FlatBufferBuilder builder, float gearTierProgress)
		{
		}

		[Address(RVA="0x167E844", Offset="0x167E844", VA="0x167E844")]
		public static void AddLevel(FlatBufferBuilder builder, byte level)
		{
		}

		[Address(RVA="0x167E808", Offset="0x167E808", VA="0x167E808")]
		public static void AddRarity(FlatBufferBuilder builder, byte rarity)
		{
		}

		[Address(RVA="0x167E6A4", Offset="0x167E6A4", VA="0x167E6A4")]
		public static Offset<UnitStatOverride> CreateUnitStatOverride(FlatBufferBuilder builder, byte level = 0, byte rarity = 0, byte gear_tier = 0, byte ability_level = 0, float gear_tier_progress = 0f)
		{
			return new Offset<UnitStatOverride>();
		}

		[Address(RVA="0x167E880", Offset="0x167E880", VA="0x167E880")]
		public static Offset<UnitStatOverride> EndUnitStatOverride(FlatBufferBuilder builder)
		{
			return new Offset<UnitStatOverride>();
		}

		[Address(RVA="0x167E3C4", Offset="0x167E3C4", VA="0x167E3C4")]
		public static UnitStatOverride GetRootAsUnitStatOverride(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitStatOverride();
		}

		[Address(RVA="0x167E3D0", Offset="0x167E3D0", VA="0x167E3D0")]
		public static UnitStatOverride GetRootAsUnitStatOverride(FlatBuffers.ByteBuffer _bb, UnitStatOverride obj)
		{
			return new UnitStatOverride();
		}

		[Address(RVA="0x167E900", Offset="0x167E900", VA="0x167E900")]
		public static void StartUnitStatOverride(FlatBufferBuilder builder)
		{
		}
	}
}