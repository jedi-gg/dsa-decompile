using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct RectTransformOffset : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF584D8", Offset="0xF584D8", VA="0xF584D8", Slot="5")]
			get
			{
				return null;
			}
		}

		public float X
		{
			[Address(RVA="0xF58504", Offset="0xF58504", VA="0xF58504")]
			get
			{
				return new float();
			}
		}

		public float Y
		{
			[Address(RVA="0xF5850C", Offset="0xF5850C", VA="0xF5850C")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF584EC", Offset="0xF584EC", VA="0xF584EC")]
		public RectTransformOffset __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new RectTransformOffset();
		}

		[Address(RVA="0xF584E0", Offset="0xF584E0", VA="0xF584E0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E51DC", Offset="0x24E51DC", VA="0x24E51DC")]
		public static void AddX(FlatBufferBuilder builder, float x)
		{
		}

		[Address(RVA="0x24E5198", Offset="0x24E5198", VA="0x24E5198")]
		public static void AddY(FlatBufferBuilder builder, float y)
		{
		}

		[Address(RVA="0x24E5130", Offset="0x24E5130", VA="0x24E5130")]
		public static Offset<RectTransformOffset> CreateRectTransformOffset(FlatBufferBuilder builder, float x = 0f, float y = 0f)
		{
			return new Offset<RectTransformOffset>();
		}

		[Address(RVA="0x24E5220", Offset="0x24E5220", VA="0x24E5220")]
		public static Offset<RectTransformOffset> EndRectTransformOffset(FlatBufferBuilder builder)
		{
			return new Offset<RectTransformOffset>();
		}

		[Address(RVA="0x24E4F84", Offset="0x24E4F84", VA="0x24E4F84")]
		public static RectTransformOffset GetRootAsRectTransformOffset(FlatBuffers.ByteBuffer _bb)
		{
			return new RectTransformOffset();
		}

		[Address(RVA="0x24E4F90", Offset="0x24E4F90", VA="0x24E4F90")]
		public static RectTransformOffset GetRootAsRectTransformOffset(FlatBuffers.ByteBuffer _bb, RectTransformOffset obj)
		{
			return new RectTransformOffset();
		}

		[Address(RVA="0x24E52A0", Offset="0x24E52A0", VA="0x24E52A0")]
		public static void StartRectTransformOffset(FlatBufferBuilder builder)
		{
		}
	}
}