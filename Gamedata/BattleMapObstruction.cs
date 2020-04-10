using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleMapObstruction : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0A5A0", Offset="0xF0A5A0", VA="0xF0A5A0", Slot="5")]
			get
			{
				return null;
			}
		}

		public short XEnd
		{
			[Address(RVA="0xF0A5D4", Offset="0xF0A5D4", VA="0xF0A5D4")]
			get
			{
				return new short();
			}
		}

		public short XStart
		{
			[Address(RVA="0xF0A5CC", Offset="0xF0A5CC", VA="0xF0A5CC")]
			get
			{
				return new short();
			}
		}

		public short Y
		{
			[Address(RVA="0xF0A5DC", Offset="0xF0A5DC", VA="0xF0A5DC")]
			get
			{
				return new short();
			}
		}

		[Address(RVA="0xF0A5B4", Offset="0xF0A5B4", VA="0xF0A5B4")]
		public BattleMapObstruction __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleMapObstruction();
		}

		[Address(RVA="0xF0A5A8", Offset="0xF0A5A8", VA="0xF0A5A8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15F2750", Offset="0x15F2750", VA="0x15F2750")]
		public static void AddXEnd(FlatBufferBuilder builder, short xEnd)
		{
		}

		[Address(RVA="0x15F278C", Offset="0x15F278C", VA="0x15F278C")]
		public static void AddXStart(FlatBufferBuilder builder, short xStart)
		{
		}

		[Address(RVA="0x15F2714", Offset="0x15F2714", VA="0x15F2714")]
		public static void AddY(FlatBufferBuilder builder, short y)
		{
		}

		[Address(RVA="0x15F269C", Offset="0x15F269C", VA="0x15F269C")]
		public static Offset<BattleMapObstruction> CreateBattleMapObstruction(FlatBufferBuilder builder, short x_start = 0, short x_end = 0, short y = 0)
		{
			return new Offset<BattleMapObstruction>();
		}

		[Address(RVA="0x15F27C8", Offset="0x15F27C8", VA="0x15F27C8")]
		public static Offset<BattleMapObstruction> EndBattleMapObstruction(FlatBufferBuilder builder)
		{
			return new Offset<BattleMapObstruction>();
		}

		[Address(RVA="0x15F24A8", Offset="0x15F24A8", VA="0x15F24A8")]
		public static BattleMapObstruction GetRootAsBattleMapObstruction(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleMapObstruction();
		}

		[Address(RVA="0x15F24B4", Offset="0x15F24B4", VA="0x15F24B4")]
		public static BattleMapObstruction GetRootAsBattleMapObstruction(FlatBuffers.ByteBuffer _bb, BattleMapObstruction obj)
		{
			return new BattleMapObstruction();
		}

		[Address(RVA="0x15F2848", Offset="0x15F2848", VA="0x15F2848")]
		public static void StartBattleMapObstruction(FlatBufferBuilder builder)
		{
		}
	}
}