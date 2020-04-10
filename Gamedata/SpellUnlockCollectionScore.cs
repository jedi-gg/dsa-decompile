using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct SpellUnlockCollectionScore : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3A320", Offset="0xF3A320", VA="0xF3A320", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Spell
		{
			[Address(RVA="0xF3A34C", Offset="0xF3A34C", VA="0xF3A34C")]
			get
			{
				return new ulong();
			}
		}

		public uint Value
		{
			[Address(RVA="0xF3A354", Offset="0xF3A354", VA="0xF3A354")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF3A334", Offset="0xF3A334", VA="0xF3A334")]
		public SpellUnlockCollectionScore __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new SpellUnlockCollectionScore();
		}

		[Address(RVA="0xF3A328", Offset="0xF3A328", VA="0xF3A328", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22DDBD4", Offset="0x22DDBD4", VA="0x22DDBD4")]
		public static void AddSpell(FlatBufferBuilder builder, ulong spell)
		{
		}

		[Address(RVA="0x22DDC10", Offset="0x22DDC10", VA="0x22DDC10")]
		public static void AddValue(FlatBufferBuilder builder, uint value)
		{
		}

		[Address(RVA="0x22DDB6C", Offset="0x22DDB6C", VA="0x22DDB6C")]
		public static Offset<SpellUnlockCollectionScore> CreateSpellUnlockCollectionScore(FlatBufferBuilder builder, ulong spell = 0L, uint value = 0)
		{
			return new Offset<SpellUnlockCollectionScore>();
		}

		[Address(RVA="0x22DDC4C", Offset="0x22DDC4C", VA="0x22DDC4C")]
		public static Offset<SpellUnlockCollectionScore> EndSpellUnlockCollectionScore(FlatBufferBuilder builder)
		{
			return new Offset<SpellUnlockCollectionScore>();
		}

		[Address(RVA="0x22DD9C4", Offset="0x22DD9C4", VA="0x22DD9C4")]
		public static SpellUnlockCollectionScore GetRootAsSpellUnlockCollectionScore(FlatBuffers.ByteBuffer _bb)
		{
			return new SpellUnlockCollectionScore();
		}

		[Address(RVA="0x22DD9D0", Offset="0x22DD9D0", VA="0x22DD9D0")]
		public static SpellUnlockCollectionScore GetRootAsSpellUnlockCollectionScore(FlatBuffers.ByteBuffer _bb, SpellUnlockCollectionScore obj)
		{
			return new SpellUnlockCollectionScore();
		}

		[Address(RVA="0x22DDCCC", Offset="0x22DDCCC", VA="0x22DDCCC")]
		public static void StartSpellUnlockCollectionScore(FlatBufferBuilder builder)
		{
		}
	}
}