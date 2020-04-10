using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PersistentReward : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF574B0", Offset="0xF574B0", VA="0xF574B0", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint Goal
		{
			[Address(RVA="0xF574E4", Offset="0xF574E4", VA="0xF574E4")]
			get
			{
				return new uint();
			}
		}

		public ulong ItemId
		{
			[Address(RVA="0xF574DC", Offset="0xF574DC", VA="0xF574DC")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF574C4", Offset="0xF574C4", VA="0xF574C4")]
		public PersistentReward __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PersistentReward();
		}

		[Address(RVA="0xF574B8", Offset="0xF574B8", VA="0xF574B8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24DB540", Offset="0x24DB540", VA="0x24DB540")]
		public static void AddGoal(FlatBufferBuilder builder, uint goal)
		{
		}

		[Address(RVA="0x24DB504", Offset="0x24DB504", VA="0x24DB504")]
		public static void AddItemId(FlatBufferBuilder builder, ulong itemId)
		{
		}

		[Address(RVA="0x24DB49C", Offset="0x24DB49C", VA="0x24DB49C")]
		public static Offset<PersistentReward> CreatePersistentReward(FlatBufferBuilder builder, ulong item_id = 0L, uint goal = 0)
		{
			return new Offset<PersistentReward>();
		}

		[Address(RVA="0x24DB57C", Offset="0x24DB57C", VA="0x24DB57C")]
		public static Offset<PersistentReward> EndPersistentReward(FlatBufferBuilder builder)
		{
			return new Offset<PersistentReward>();
		}

		[Address(RVA="0x24DB2F4", Offset="0x24DB2F4", VA="0x24DB2F4")]
		public static PersistentReward GetRootAsPersistentReward(FlatBuffers.ByteBuffer _bb)
		{
			return new PersistentReward();
		}

		[Address(RVA="0x24DB300", Offset="0x24DB300", VA="0x24DB300")]
		public static PersistentReward GetRootAsPersistentReward(FlatBuffers.ByteBuffer _bb, PersistentReward obj)
		{
			return new PersistentReward();
		}

		[Address(RVA="0x24DB5FC", Offset="0x24DB5FC", VA="0x24DB5FC")]
		public static void StartPersistentReward(FlatBufferBuilder builder)
		{
		}
	}
}