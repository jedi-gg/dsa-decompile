using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct StoreAdRewardEntry : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3A9F8", Offset="0xF3A9F8", VA="0xF3A9F8", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Loot
		{
			[Address(RVA="0xF3AA2C", Offset="0xF3AA2C", VA="0xF3AA2C")]
			get
			{
				return new ulong();
			}
		}

		public uint MaxClaims
		{
			[Address(RVA="0xF3AA24", Offset="0xF3AA24", VA="0xF3AA24")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF3AA0C", Offset="0xF3AA0C", VA="0xF3AA0C")]
		public StoreAdRewardEntry __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new StoreAdRewardEntry();
		}

		[Address(RVA="0xF3AA00", Offset="0xF3AA00", VA="0xF3AA00", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22E5C44", Offset="0x22E5C44", VA="0x22E5C44")]
		public static void AddLoot(FlatBufferBuilder builder, ulong loot)
		{
		}

		[Address(RVA="0x22E5C80", Offset="0x22E5C80", VA="0x22E5C80")]
		public static void AddMaxClaims(FlatBufferBuilder builder, uint maxClaims)
		{
		}

		[Address(RVA="0x22E5BDC", Offset="0x22E5BDC", VA="0x22E5BDC")]
		public static Offset<StoreAdRewardEntry> CreateStoreAdRewardEntry(FlatBufferBuilder builder, uint max_claims = 0, ulong loot = 0L)
		{
			return new Offset<StoreAdRewardEntry>();
		}

		[Address(RVA="0x22E5CBC", Offset="0x22E5CBC", VA="0x22E5CBC")]
		public static Offset<StoreAdRewardEntry> EndStoreAdRewardEntry(FlatBufferBuilder builder)
		{
			return new Offset<StoreAdRewardEntry>();
		}

		[Address(RVA="0x22E5A34", Offset="0x22E5A34", VA="0x22E5A34")]
		public static StoreAdRewardEntry GetRootAsStoreAdRewardEntry(FlatBuffers.ByteBuffer _bb)
		{
			return new StoreAdRewardEntry();
		}

		[Address(RVA="0x22E5A40", Offset="0x22E5A40", VA="0x22E5A40")]
		public static StoreAdRewardEntry GetRootAsStoreAdRewardEntry(FlatBuffers.ByteBuffer _bb, StoreAdRewardEntry obj)
		{
			return new StoreAdRewardEntry();
		}

		[Address(RVA="0x22E5D3C", Offset="0x22E5D3C", VA="0x22E5D3C")]
		public static void StartStoreAdRewardEntry(FlatBufferBuilder builder)
		{
		}
	}
}