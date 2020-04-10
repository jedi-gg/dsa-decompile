using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct DayOfWeek : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF59E30", Offset="0xF59E30", VA="0xF59E30", Slot="5")]
			get
			{
				return null;
			}
		}

		public bool Friday
		{
			[Address(RVA="0xF59E84", Offset="0xF59E84", VA="0xF59E84")]
			get
			{
				return new bool();
			}
		}

		public bool Monday
		{
			[Address(RVA="0xF59E64", Offset="0xF59E64", VA="0xF59E64")]
			get
			{
				return new bool();
			}
		}

		public bool Saturday
		{
			[Address(RVA="0xF59E8C", Offset="0xF59E8C", VA="0xF59E8C")]
			get
			{
				return new bool();
			}
		}

		public bool Sunday
		{
			[Address(RVA="0xF59E5C", Offset="0xF59E5C", VA="0xF59E5C")]
			get
			{
				return new bool();
			}
		}

		public bool Thursday
		{
			[Address(RVA="0xF59E7C", Offset="0xF59E7C", VA="0xF59E7C")]
			get
			{
				return new bool();
			}
		}

		public bool Tuesday
		{
			[Address(RVA="0xF59E6C", Offset="0xF59E6C", VA="0xF59E6C")]
			get
			{
				return new bool();
			}
		}

		public bool Wednesday
		{
			[Address(RVA="0xF59E74", Offset="0xF59E74", VA="0xF59E74")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0xF59E44", Offset="0xF59E44", VA="0xF59E44")]
		public Gamedata.DayOfWeek __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new Gamedata.DayOfWeek();
		}

		[Address(RVA="0xF59E38", Offset="0xF59E38", VA="0xF59E38", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x250FAF8", Offset="0x250FAF8", VA="0x250FAF8")]
		public static void AddFriday(FlatBufferBuilder builder, bool friday)
		{
		}

		[Address(RVA="0x250FBE8", Offset="0x250FBE8", VA="0x250FBE8")]
		public static void AddMonday(FlatBufferBuilder builder, bool monday)
		{
		}

		[Address(RVA="0x250FABC", Offset="0x250FABC", VA="0x250FABC")]
		public static void AddSaturday(FlatBufferBuilder builder, bool saturday)
		{
		}

		[Address(RVA="0x250FC24", Offset="0x250FC24", VA="0x250FC24")]
		public static void AddSunday(FlatBufferBuilder builder, bool sunday)
		{
		}

		[Address(RVA="0x250FB34", Offset="0x250FB34", VA="0x250FB34")]
		public static void AddThursday(FlatBufferBuilder builder, bool thursday)
		{
		}

		[Address(RVA="0x250FBAC", Offset="0x250FBAC", VA="0x250FBAC")]
		public static void AddTuesday(FlatBufferBuilder builder, bool tuesday)
		{
		}

		[Address(RVA="0x250FB70", Offset="0x250FB70", VA="0x250FB70")]
		public static void AddWednesday(FlatBufferBuilder builder, bool wednesday)
		{
		}

		[Address(RVA="0x250F9F4", Offset="0x250F9F4", VA="0x250F9F4")]
		public static Offset<Gamedata.DayOfWeek> CreateDayOfWeek(FlatBufferBuilder builder, bool sunday = false, bool monday = false, bool tuesday = false, bool wednesday = false, bool thursday = false, bool friday = false, bool saturday = false)
		{
			return new Offset<Gamedata.DayOfWeek>();
		}

		[Address(RVA="0x250FC60", Offset="0x250FC60", VA="0x250FC60")]
		public static Offset<Gamedata.DayOfWeek> EndDayOfWeek(FlatBufferBuilder builder)
		{
			return new Offset<Gamedata.DayOfWeek>();
		}

		[Address(RVA="0x250F67C", Offset="0x250F67C", VA="0x250F67C")]
		public static Gamedata.DayOfWeek GetRootAsDayOfWeek(FlatBuffers.ByteBuffer _bb)
		{
			return new Gamedata.DayOfWeek();
		}

		[Address(RVA="0x250F688", Offset="0x250F688", VA="0x250F688")]
		public static Gamedata.DayOfWeek GetRootAsDayOfWeek(FlatBuffers.ByteBuffer _bb, Gamedata.DayOfWeek obj)
		{
			return new Gamedata.DayOfWeek();
		}

		[Address(RVA="0x250FCE0", Offset="0x250FCE0", VA="0x250FCE0")]
		public static void StartDayOfWeek(FlatBufferBuilder builder)
		{
		}
	}
}