using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct Milestones : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56A68", Offset="0xF56A68", VA="0xF56A68", Slot="5")]
			get
			{
				return null;
			}
		}

		public MilestoneCategory Category
		{
			[Address(RVA="0xF56A9C", Offset="0xF56A9C", VA="0xF56A9C")]
			get
			{
				return new MilestoneCategory();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF56A94", Offset="0xF56A94", VA="0xF56A94")]
			get
			{
				return new ulong();
			}
		}

		public uint MinValue
		{
			[Address(RVA="0xF56AA4", Offset="0xF56AA4", VA="0xF56AA4")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF56A7C", Offset="0xF56A7C", VA="0xF56A7C")]
		public Milestones __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new Milestones();
		}

		[Address(RVA="0xF56A70", Offset="0xF56A70", VA="0xF56A70", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D6010", Offset="0x24D6010", VA="0x24D6010")]
		public static void AddCategory(FlatBufferBuilder builder, MilestoneCategory category)
		{
		}

		[Address(RVA="0x24D5F98", Offset="0x24D5F98", VA="0x24D5F98")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24D5FD4", Offset="0x24D5FD4", VA="0x24D5FD4")]
		public static void AddMinValue(FlatBufferBuilder builder, uint minValue)
		{
		}

		[Address(RVA="0x24D5F20", Offset="0x24D5F20", VA="0x24D5F20")]
		public static Offset<Milestones> CreateMilestones(FlatBufferBuilder builder, ulong id = 0L, MilestoneCategory category = 0, uint min_value = 0)
		{
			return new Offset<Milestones>();
		}

		[Address(RVA="0x24D604C", Offset="0x24D604C", VA="0x24D604C")]
		public static Offset<Milestones> EndMilestones(FlatBufferBuilder builder)
		{
			return new Offset<Milestones>();
		}

		[Address(RVA="0x24D60FC", Offset="0x24D60FC", VA="0x24D60FC")]
		public static void FinishMilestonesBuffer(FlatBufferBuilder builder, Offset<Milestones> offset)
		{
		}

		[Address(RVA="0x24D5D10", Offset="0x24D5D10", VA="0x24D5D10")]
		public static Milestones GetRootAsMilestones(FlatBuffers.ByteBuffer _bb)
		{
			return new Milestones();
		}

		[Address(RVA="0x24D5D1C", Offset="0x24D5D1C", VA="0x24D5D1C")]
		public static Milestones GetRootAsMilestones(FlatBuffers.ByteBuffer _bb, Milestones obj)
		{
			return new Milestones();
		}

		[Address(RVA="0x24D60CC", Offset="0x24D60CC", VA="0x24D60CC")]
		public static void StartMilestones(FlatBufferBuilder builder)
		{
		}
	}
}