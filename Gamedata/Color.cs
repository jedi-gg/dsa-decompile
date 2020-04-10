using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct Color : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public float A
		{
			[Address(RVA="0xF44428", Offset="0xF44428", VA="0xF44428")]
			get
			{
				return new float();
			}
		}

		public int B
		{
			[Address(RVA="0xF44420", Offset="0xF44420", VA="0xF44420")]
			get
			{
				return new int();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF443E4", Offset="0xF443E4", VA="0xF443E4", Slot="5")]
			get
			{
				return null;
			}
		}

		public int G
		{
			[Address(RVA="0xF44418", Offset="0xF44418", VA="0xF44418")]
			get
			{
				return new int();
			}
		}

		public int R
		{
			[Address(RVA="0xF44410", Offset="0xF44410", VA="0xF44410")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF443F8", Offset="0xF443F8", VA="0xF443F8")]
		public Color __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new Color();
		}

		[Address(RVA="0xF443EC", Offset="0xF443EC", VA="0xF443EC", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2329C20", Offset="0x2329C20", VA="0x2329C20")]
		public static void AddA(FlatBufferBuilder builder, float a)
		{
		}

		[Address(RVA="0x2329C64", Offset="0x2329C64", VA="0x2329C64")]
		public static void AddB(FlatBufferBuilder builder, int b)
		{
		}

		[Address(RVA="0x2329CA0", Offset="0x2329CA0", VA="0x2329CA0")]
		public static void AddG(FlatBufferBuilder builder, int g)
		{
		}

		[Address(RVA="0x2329CDC", Offset="0x2329CDC", VA="0x2329CDC")]
		public static void AddR(FlatBufferBuilder builder, int r)
		{
		}

		[Address(RVA="0x2329B90", Offset="0x2329B90", VA="0x2329B90")]
		public static Offset<Color> CreateColor(FlatBufferBuilder builder, int r = 0, int g = 0, int b = 0, float a = 0f)
		{
			return new Offset<Color>();
		}

		[Address(RVA="0x2329D18", Offset="0x2329D18", VA="0x2329D18")]
		public static Offset<Color> EndColor(FlatBufferBuilder builder)
		{
			return new Offset<Color>();
		}

		[Address(RVA="0x2329DC8", Offset="0x2329DC8", VA="0x2329DC8")]
		public static void FinishColorBuffer(FlatBufferBuilder builder, Offset<Color> offset)
		{
		}

		[Address(RVA="0x2329918", Offset="0x2329918", VA="0x2329918")]
		public static Color GetRootAsColor(FlatBuffers.ByteBuffer _bb)
		{
			return new Color();
		}

		[Address(RVA="0x2329924", Offset="0x2329924", VA="0x2329924")]
		public static Color GetRootAsColor(FlatBuffers.ByteBuffer _bb, Color obj)
		{
			return new Color();
		}

		[Address(RVA="0x2329D98", Offset="0x2329D98", VA="0x2329D98")]
		public static void StartColor(FlatBufferBuilder builder)
		{
		}
	}
}