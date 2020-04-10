using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct SquadSelectorWeight : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3A5A0", Offset="0xF3A5A0", VA="0xF3A5A0", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Squad
		{
			[Address(RVA="0xF3A5D4", Offset="0xF3A5D4", VA="0xF3A5D4")]
			get
			{
				return new ulong();
			}
		}

		public float Weight
		{
			[Address(RVA="0xF3A5CC", Offset="0xF3A5CC", VA="0xF3A5CC")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF3A5B4", Offset="0xF3A5B4", VA="0xF3A5B4")]
		public SquadSelectorWeight __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new SquadSelectorWeight();
		}

		[Address(RVA="0xF3A5A8", Offset="0xF3A5A8", VA="0xF3A5A8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22DF1C8", Offset="0x22DF1C8", VA="0x22DF1C8")]
		public static void AddSquad(FlatBufferBuilder builder, ulong squad)
		{
		}

		[Address(RVA="0x22DF204", Offset="0x22DF204", VA="0x22DF204")]
		public static void AddWeight(FlatBufferBuilder builder, float weight)
		{
		}

		[Address(RVA="0x22DF160", Offset="0x22DF160", VA="0x22DF160")]
		public static Offset<SquadSelectorWeight> CreateSquadSelectorWeight(FlatBufferBuilder builder, float weight = 0f, ulong squad = 0L)
		{
			return new Offset<SquadSelectorWeight>();
		}

		[Address(RVA="0x22DF248", Offset="0x22DF248", VA="0x22DF248")]
		public static Offset<SquadSelectorWeight> EndSquadSelectorWeight(FlatBufferBuilder builder)
		{
			return new Offset<SquadSelectorWeight>();
		}

		[Address(RVA="0x22DEFCC", Offset="0x22DEFCC", VA="0x22DEFCC")]
		public static SquadSelectorWeight GetRootAsSquadSelectorWeight(FlatBuffers.ByteBuffer _bb)
		{
			return new SquadSelectorWeight();
		}

		[Address(RVA="0x22DEFD8", Offset="0x22DEFD8", VA="0x22DEFD8")]
		public static SquadSelectorWeight GetRootAsSquadSelectorWeight(FlatBuffers.ByteBuffer _bb, SquadSelectorWeight obj)
		{
			return new SquadSelectorWeight();
		}

		[Address(RVA="0x22DF2C8", Offset="0x22DF2C8", VA="0x22DF2C8")]
		public static void StartSquadSelectorWeight(FlatBufferBuilder builder)
		{
		}
	}
}