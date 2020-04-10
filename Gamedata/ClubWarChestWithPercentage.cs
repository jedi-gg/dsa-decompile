using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ClubWarChestWithPercentage : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF43F0C", Offset="0xF43F0C", VA="0xF43F0C", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Chest
		{
			[Address(RVA="0xF43F38", Offset="0xF43F38", VA="0xF43F38")]
			get
			{
				return new ulong();
			}
		}

		public float Percentage
		{
			[Address(RVA="0xF43F40", Offset="0xF43F40", VA="0xF43F40")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF43F20", Offset="0xF43F20", VA="0xF43F20")]
		public ClubWarChestWithPercentage __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ClubWarChestWithPercentage();
		}

		[Address(RVA="0xF43F14", Offset="0xF43F14", VA="0xF43F14", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x23266E0", Offset="0x23266E0", VA="0x23266E0")]
		public static void AddChest(FlatBufferBuilder builder, ulong chest)
		{
		}

		[Address(RVA="0x232671C", Offset="0x232671C", VA="0x232671C")]
		public static void AddPercentage(FlatBufferBuilder builder, float percentage)
		{
		}

		[Address(RVA="0x2326678", Offset="0x2326678", VA="0x2326678")]
		public static Offset<ClubWarChestWithPercentage> CreateClubWarChestWithPercentage(FlatBufferBuilder builder, ulong chest = 0L, float percentage = 0f)
		{
			return new Offset<ClubWarChestWithPercentage>();
		}

		[Address(RVA="0x2326760", Offset="0x2326760", VA="0x2326760")]
		public static Offset<ClubWarChestWithPercentage> EndClubWarChestWithPercentage(FlatBufferBuilder builder)
		{
			return new Offset<ClubWarChestWithPercentage>();
		}

		[Address(RVA="0x23264CC", Offset="0x23264CC", VA="0x23264CC")]
		public static ClubWarChestWithPercentage GetRootAsClubWarChestWithPercentage(FlatBuffers.ByteBuffer _bb)
		{
			return new ClubWarChestWithPercentage();
		}

		[Address(RVA="0x23264D8", Offset="0x23264D8", VA="0x23264D8")]
		public static ClubWarChestWithPercentage GetRootAsClubWarChestWithPercentage(FlatBuffers.ByteBuffer _bb, ClubWarChestWithPercentage obj)
		{
			return new ClubWarChestWithPercentage();
		}

		[Address(RVA="0x23267E0", Offset="0x23267E0", VA="0x23267E0")]
		public static void StartClubWarChestWithPercentage(FlatBufferBuilder builder)
		{
		}
	}
}