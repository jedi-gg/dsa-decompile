using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct OccasionRef : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56DA0", Offset="0xF56DA0", VA="0xF56DA0", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong OccasionId
		{
			[Address(RVA="0xF56DCC", Offset="0xF56DCC", VA="0xF56DCC")]
			get
			{
				return new ulong();
			}
		}

		public sbyte SegmentId
		{
			[Address(RVA="0xF56DD4", Offset="0xF56DD4", VA="0xF56DD4")]
			get
			{
				return new sbyte();
			}
		}

		[Address(RVA="0xF56DB4", Offset="0xF56DB4", VA="0xF56DB4")]
		public OccasionRef __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new OccasionRef();
		}

		[Address(RVA="0xF56DA8", Offset="0xF56DA8", VA="0xF56DA8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D7634", Offset="0x24D7634", VA="0x24D7634")]
		public static void AddOccasionId(FlatBufferBuilder builder, ulong occasionId)
		{
		}

		[Address(RVA="0x24D7670", Offset="0x24D7670", VA="0x24D7670")]
		public static void AddSegmentId(FlatBufferBuilder builder, sbyte segmentId)
		{
		}

		[Address(RVA="0x24D75CC", Offset="0x24D75CC", VA="0x24D75CC")]
		public static Offset<OccasionRef> CreateOccasionRef(FlatBufferBuilder builder, ulong occasion_id = 0L, sbyte segment_id = 0)
		{
			return new Offset<OccasionRef>();
		}

		[Address(RVA="0x24D76AC", Offset="0x24D76AC", VA="0x24D76AC")]
		public static Offset<OccasionRef> EndOccasionRef(FlatBufferBuilder builder)
		{
			return new Offset<OccasionRef>();
		}

		[Address(RVA="0x24D7424", Offset="0x24D7424", VA="0x24D7424")]
		public static OccasionRef GetRootAsOccasionRef(FlatBuffers.ByteBuffer _bb)
		{
			return new OccasionRef();
		}

		[Address(RVA="0x24D7430", Offset="0x24D7430", VA="0x24D7430")]
		public static OccasionRef GetRootAsOccasionRef(FlatBuffers.ByteBuffer _bb, OccasionRef obj)
		{
			return new OccasionRef();
		}

		[Address(RVA="0x24D772C", Offset="0x24D772C", VA="0x24D772C")]
		public static void StartOccasionRef(FlatBufferBuilder builder)
		{
		}
	}
}