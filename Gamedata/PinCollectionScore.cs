using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PinCollectionScore : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF57538", Offset="0xF57538", VA="0xF57538", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Pin
		{
			[Address(RVA="0xF57564", Offset="0xF57564", VA="0xF57564")]
			get
			{
				return new ulong();
			}
		}

		public uint Value
		{
			[Address(RVA="0xF5756C", Offset="0xF5756C", VA="0xF5756C")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF5754C", Offset="0xF5754C", VA="0xF5754C")]
		public PinCollectionScore __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PinCollectionScore();
		}

		[Address(RVA="0xF57540", Offset="0xF57540", VA="0xF57540", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24DB844", Offset="0x24DB844", VA="0x24DB844")]
		public static void AddPin(FlatBufferBuilder builder, ulong pin)
		{
		}

		[Address(RVA="0x24DB880", Offset="0x24DB880", VA="0x24DB880")]
		public static void AddValue(FlatBufferBuilder builder, uint value)
		{
		}

		[Address(RVA="0x24DB7DC", Offset="0x24DB7DC", VA="0x24DB7DC")]
		public static Offset<PinCollectionScore> CreatePinCollectionScore(FlatBufferBuilder builder, ulong pin = 0L, uint value = 0)
		{
			return new Offset<PinCollectionScore>();
		}

		[Address(RVA="0x24DB8BC", Offset="0x24DB8BC", VA="0x24DB8BC")]
		public static Offset<PinCollectionScore> EndPinCollectionScore(FlatBufferBuilder builder)
		{
			return new Offset<PinCollectionScore>();
		}

		[Address(RVA="0x24DB634", Offset="0x24DB634", VA="0x24DB634")]
		public static PinCollectionScore GetRootAsPinCollectionScore(FlatBuffers.ByteBuffer _bb)
		{
			return new PinCollectionScore();
		}

		[Address(RVA="0x24DB640", Offset="0x24DB640", VA="0x24DB640")]
		public static PinCollectionScore GetRootAsPinCollectionScore(FlatBuffers.ByteBuffer _bb, PinCollectionScore obj)
		{
			return new PinCollectionScore();
		}

		[Address(RVA="0x24DB93C", Offset="0x24DB93C", VA="0x24DB93C")]
		public static void StartPinCollectionScore(FlatBufferBuilder builder)
		{
		}
	}
}