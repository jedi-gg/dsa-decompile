using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct OccasionSegment : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56EC0", Offset="0xF56EC0", VA="0xF56EC0", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint DurationS
		{
			[Address(RVA="0xF56EFC", Offset="0xF56EFC", VA="0xF56EFC")]
			get
			{
				return new uint();
			}
		}

		public sbyte Id
		{
			[Address(RVA="0xF56EEC", Offset="0xF56EEC", VA="0xF56EEC")]
			get
			{
				return new sbyte();
			}
		}

		public uint OffsetS
		{
			[Address(RVA="0xF56EF4", Offset="0xF56EF4", VA="0xF56EF4")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF56ED4", Offset="0xF56ED4", VA="0xF56ED4")]
		public OccasionSegment __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new OccasionSegment();
		}

		[Address(RVA="0xF56EC8", Offset="0xF56EC8", VA="0xF56EC8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D7F94", Offset="0x24D7F94", VA="0x24D7F94")]
		public static void AddDurationS(FlatBufferBuilder builder, uint durationS)
		{
		}

		[Address(RVA="0x24D800C", Offset="0x24D800C", VA="0x24D800C")]
		public static void AddId(FlatBufferBuilder builder, sbyte id)
		{
		}

		[Address(RVA="0x24D7FD0", Offset="0x24D7FD0", VA="0x24D7FD0")]
		public static void AddOffsetS(FlatBufferBuilder builder, uint offsetS)
		{
		}

		[Address(RVA="0x24D7F1C", Offset="0x24D7F1C", VA="0x24D7F1C")]
		public static Offset<OccasionSegment> CreateOccasionSegment(FlatBufferBuilder builder, sbyte id = 0, uint offset_s = 0, uint duration_s = 0)
		{
			return new Offset<OccasionSegment>();
		}

		[Address(RVA="0x24D8048", Offset="0x24D8048", VA="0x24D8048")]
		public static Offset<OccasionSegment> EndOccasionSegment(FlatBufferBuilder builder)
		{
			return new Offset<OccasionSegment>();
		}

		[Address(RVA="0x24D7D28", Offset="0x24D7D28", VA="0x24D7D28")]
		public static OccasionSegment GetRootAsOccasionSegment(FlatBuffers.ByteBuffer _bb)
		{
			return new OccasionSegment();
		}

		[Address(RVA="0x24D7D34", Offset="0x24D7D34", VA="0x24D7D34")]
		public static OccasionSegment GetRootAsOccasionSegment(FlatBuffers.ByteBuffer _bb, OccasionSegment obj)
		{
			return new OccasionSegment();
		}

		[Address(RVA="0x24D80C8", Offset="0x24D80C8", VA="0x24D80C8")]
		public static void StartOccasionSegment(FlatBufferBuilder builder)
		{
		}
	}
}