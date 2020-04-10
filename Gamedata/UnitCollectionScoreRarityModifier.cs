using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitCollectionScoreRarityModifier : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0B808", Offset="0xF0B808", VA="0xF0B808", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Unit
		{
			[Address(RVA="0xF0B834", Offset="0xF0B834", VA="0xF0B834")]
			get
			{
				return new ulong();
			}
		}

		public float Value
		{
			[Address(RVA="0xF0B83C", Offset="0xF0B83C", VA="0xF0B83C")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF0B81C", Offset="0xF0B81C", VA="0xF0B81C")]
		public UnitCollectionScoreRarityModifier __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitCollectionScoreRarityModifier();
		}

		[Address(RVA="0xF0B810", Offset="0xF0B810", VA="0xF0B810", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x167A264", Offset="0x167A264", VA="0x167A264")]
		public static void AddUnit(FlatBufferBuilder builder, ulong unit)
		{
		}

		[Address(RVA="0x167A2A0", Offset="0x167A2A0", VA="0x167A2A0")]
		public static void AddValue(FlatBufferBuilder builder, float value)
		{
		}

		[Address(RVA="0x167A1FC", Offset="0x167A1FC", VA="0x167A1FC")]
		public static Offset<UnitCollectionScoreRarityModifier> CreateUnitCollectionScoreRarityModifier(FlatBufferBuilder builder, ulong unit = 0L, float value = 0f)
		{
			return new Offset<UnitCollectionScoreRarityModifier>();
		}

		[Address(RVA="0x167A2E4", Offset="0x167A2E4", VA="0x167A2E4")]
		public static Offset<UnitCollectionScoreRarityModifier> EndUnitCollectionScoreRarityModifier(FlatBufferBuilder builder)
		{
			return new Offset<UnitCollectionScoreRarityModifier>();
		}

		[Address(RVA="0x167A050", Offset="0x167A050", VA="0x167A050")]
		public static UnitCollectionScoreRarityModifier GetRootAsUnitCollectionScoreRarityModifier(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitCollectionScoreRarityModifier();
		}

		[Address(RVA="0x167A05C", Offset="0x167A05C", VA="0x167A05C")]
		public static UnitCollectionScoreRarityModifier GetRootAsUnitCollectionScoreRarityModifier(FlatBuffers.ByteBuffer _bb, UnitCollectionScoreRarityModifier obj)
		{
			return new UnitCollectionScoreRarityModifier();
		}

		[Address(RVA="0x167A364", Offset="0x167A364", VA="0x167A364")]
		public static void StartUnitCollectionScoreRarityModifier(FlatBufferBuilder builder)
		{
		}
	}
}