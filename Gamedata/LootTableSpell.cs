using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct LootTableSpell : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56958", Offset="0xF56958", VA="0xF56958", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong SpellId
		{
			[Address(RVA="0xF5698C", Offset="0xF5698C", VA="0xF5698C")]
			get
			{
				return new ulong();
			}
		}

		public float Weight
		{
			[Address(RVA="0xF56984", Offset="0xF56984", VA="0xF56984")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF5696C", Offset="0xF5696C", VA="0xF5696C")]
		public LootTableSpell __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new LootTableSpell();
		}

		[Address(RVA="0xF56960", Offset="0xF56960", VA="0xF56960", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D58A4", Offset="0x24D58A4", VA="0x24D58A4")]
		public static void AddSpellId(FlatBufferBuilder builder, ulong spellId)
		{
		}

		[Address(RVA="0x24D58E0", Offset="0x24D58E0", VA="0x24D58E0")]
		public static void AddWeight(FlatBufferBuilder builder, float weight)
		{
		}

		[Address(RVA="0x24D583C", Offset="0x24D583C", VA="0x24D583C")]
		public static Offset<LootTableSpell> CreateLootTableSpell(FlatBufferBuilder builder, float weight = 0f, ulong spell_id = 0L)
		{
			return new Offset<LootTableSpell>();
		}

		[Address(RVA="0x24D5924", Offset="0x24D5924", VA="0x24D5924")]
		public static Offset<LootTableSpell> EndLootTableSpell(FlatBufferBuilder builder)
		{
			return new Offset<LootTableSpell>();
		}

		[Address(RVA="0x24D56A8", Offset="0x24D56A8", VA="0x24D56A8")]
		public static LootTableSpell GetRootAsLootTableSpell(FlatBuffers.ByteBuffer _bb)
		{
			return new LootTableSpell();
		}

		[Address(RVA="0x24D56B4", Offset="0x24D56B4", VA="0x24D56B4")]
		public static LootTableSpell GetRootAsLootTableSpell(FlatBuffers.ByteBuffer _bb, LootTableSpell obj)
		{
			return new LootTableSpell();
		}

		[Address(RVA="0x24D59A4", Offset="0x24D59A4", VA="0x24D59A4")]
		public static void StartLootTableSpell(FlatBufferBuilder builder)
		{
		}
	}
}