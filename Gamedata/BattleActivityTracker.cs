using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleActivityTracker : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0A0A8", Offset="0xF0A0A8", VA="0xF0A0A8", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0A0D4", Offset="0xF0A0D4", VA="0xF0A0D4")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF0A0BC", Offset="0xF0A0BC", VA="0xF0A0BC")]
		public BattleActivityTracker __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleActivityTracker();
		}

		[Address(RVA="0xF0A0B0", Offset="0xF0A0B0", VA="0xF0A0B0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15EFAD8", Offset="0x15EFAD8", VA="0x15EFAD8")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x15EFA88", Offset="0x15EFA88", VA="0x15EFA88")]
		public static Offset<BattleActivityTracker> CreateBattleActivityTracker(FlatBufferBuilder builder, ulong id = 0L)
		{
			return new Offset<BattleActivityTracker>();
		}

		[Address(RVA="0x15EFB14", Offset="0x15EFB14", VA="0x15EFB14")]
		public static Offset<BattleActivityTracker> EndBattleActivityTracker(FlatBufferBuilder builder)
		{
			return new Offset<BattleActivityTracker>();
		}

		[Address(RVA="0x15EFBC4", Offset="0x15EFBC4", VA="0x15EFBC4")]
		public static void FinishBattleActivityTrackerBuffer(FlatBufferBuilder builder, Offset<BattleActivityTracker> offset)
		{
		}

		[Address(RVA="0x15EF948", Offset="0x15EF948", VA="0x15EF948")]
		public static BattleActivityTracker GetRootAsBattleActivityTracker(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleActivityTracker();
		}

		[Address(RVA="0x15EF954", Offset="0x15EF954", VA="0x15EF954")]
		public static BattleActivityTracker GetRootAsBattleActivityTracker(FlatBuffers.ByteBuffer _bb, BattleActivityTracker obj)
		{
			return new BattleActivityTracker();
		}

		[Address(RVA="0x15EFB94", Offset="0x15EFB94", VA="0x15EFB94")]
		public static void StartBattleActivityTracker(FlatBufferBuilder builder)
		{
		}
	}
}