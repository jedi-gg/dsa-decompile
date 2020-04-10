using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct AchievementCollectionScore : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public ulong Achievement
		{
			[Address(RVA="0xF09B4C", Offset="0xF09B4C", VA="0xF09B4C")]
			get
			{
				return new ulong();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF09B20", Offset="0xF09B20", VA="0xF09B20", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint Value
		{
			[Address(RVA="0xF09B54", Offset="0xF09B54", VA="0xF09B54")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF09B34", Offset="0xF09B34", VA="0xF09B34")]
		public AchievementCollectionScore __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new AchievementCollectionScore();
		}

		[Address(RVA="0xF09B28", Offset="0xF09B28", VA="0xF09B28", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15ED158", Offset="0x15ED158", VA="0x15ED158")]
		public static void AddAchievement(FlatBufferBuilder builder, ulong achievement)
		{
		}

		[Address(RVA="0x15ED194", Offset="0x15ED194", VA="0x15ED194")]
		public static void AddValue(FlatBufferBuilder builder, uint value)
		{
		}

		[Address(RVA="0x15ED0F0", Offset="0x15ED0F0", VA="0x15ED0F0")]
		public static Offset<AchievementCollectionScore> CreateAchievementCollectionScore(FlatBufferBuilder builder, ulong achievement = 0L, uint value = 0)
		{
			return new Offset<AchievementCollectionScore>();
		}

		[Address(RVA="0x15ED1D0", Offset="0x15ED1D0", VA="0x15ED1D0")]
		public static Offset<AchievementCollectionScore> EndAchievementCollectionScore(FlatBufferBuilder builder)
		{
			return new Offset<AchievementCollectionScore>();
		}

		[Address(RVA="0x15ECF48", Offset="0x15ECF48", VA="0x15ECF48")]
		public static AchievementCollectionScore GetRootAsAchievementCollectionScore(FlatBuffers.ByteBuffer _bb)
		{
			return new AchievementCollectionScore();
		}

		[Address(RVA="0x15ECF54", Offset="0x15ECF54", VA="0x15ECF54")]
		public static AchievementCollectionScore GetRootAsAchievementCollectionScore(FlatBuffers.ByteBuffer _bb, AchievementCollectionScore obj)
		{
			return new AchievementCollectionScore();
		}

		[Address(RVA="0x15ED250", Offset="0x15ED250", VA="0x15ED250")]
		public static void StartAchievementCollectionScore(FlatBufferBuilder builder)
		{
		}
	}
}