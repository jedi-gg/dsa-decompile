using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct RectTransformAlignment : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF58450", Offset="0xF58450", VA="0xF58450", Slot="5")]
			get
			{
				return null;
			}
		}

		public RectTransformAlignmentHorizontal X
		{
			[Address(RVA="0xF5847C", Offset="0xF5847C", VA="0xF5847C")]
			get
			{
				return new RectTransformAlignmentHorizontal();
			}
		}

		public RectTransformAlignmentVertical Y
		{
			[Address(RVA="0xF58484", Offset="0xF58484", VA="0xF58484")]
			get
			{
				return new RectTransformAlignmentVertical();
			}
		}

		[Address(RVA="0xF58464", Offset="0xF58464", VA="0xF58464")]
		public RectTransformAlignment __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new RectTransformAlignment();
		}

		[Address(RVA="0xF58458", Offset="0xF58458", VA="0xF58458", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E4E90", Offset="0x24E4E90", VA="0x24E4E90")]
		public static void AddX(FlatBufferBuilder builder, RectTransformAlignmentHorizontal x)
		{
		}

		[Address(RVA="0x24E4E54", Offset="0x24E4E54", VA="0x24E4E54")]
		public static void AddY(FlatBufferBuilder builder, RectTransformAlignmentVertical y)
		{
		}

		[Address(RVA="0x24E4DEC", Offset="0x24E4DEC", VA="0x24E4DEC")]
		public static Offset<RectTransformAlignment> CreateRectTransformAlignment(FlatBufferBuilder builder, RectTransformAlignmentHorizontal x = 0, RectTransformAlignmentVertical y = 0)
		{
			return new Offset<RectTransformAlignment>();
		}

		[Address(RVA="0x24E4ECC", Offset="0x24E4ECC", VA="0x24E4ECC")]
		public static Offset<RectTransformAlignment> EndRectTransformAlignment(FlatBufferBuilder builder)
		{
			return new Offset<RectTransformAlignment>();
		}

		[Address(RVA="0x24E4C48", Offset="0x24E4C48", VA="0x24E4C48")]
		public static RectTransformAlignment GetRootAsRectTransformAlignment(FlatBuffers.ByteBuffer _bb)
		{
			return new RectTransformAlignment();
		}

		[Address(RVA="0x24E4C54", Offset="0x24E4C54", VA="0x24E4C54")]
		public static RectTransformAlignment GetRootAsRectTransformAlignment(FlatBuffers.ByteBuffer _bb, RectTransformAlignment obj)
		{
			return new RectTransformAlignment();
		}

		[Address(RVA="0x24E4F4C", Offset="0x24E4F4C", VA="0x24E4F4C")]
		public static void StartRectTransformAlignment(FlatBufferBuilder builder)
		{
		}
	}
}