using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PurchaseLimit : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF57C68", Offset="0xF57C68", VA="0xF57C68", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint Count
		{
			[Address(RVA="0xF57C9C", Offset="0xF57C9C", VA="0xF57C9C")]
			get
			{
				return new uint();
			}
		}

		public PurchaseLimitGranularity Granularity
		{
			[Address(RVA="0xF57C94", Offset="0xF57C94", VA="0xF57C94")]
			get
			{
				return new PurchaseLimitGranularity();
			}
		}

		[Address(RVA="0xF57C7C", Offset="0xF57C7C", VA="0xF57C7C")]
		public PurchaseLimit __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PurchaseLimit();
		}

		[Address(RVA="0xF57C70", Offset="0xF57C70", VA="0xF57C70", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24DFD40", Offset="0x24DFD40", VA="0x24DFD40")]
		public static void AddCount(FlatBufferBuilder builder, uint count)
		{
		}

		[Address(RVA="0x24DFD7C", Offset="0x24DFD7C", VA="0x24DFD7C")]
		public static void AddGranularity(FlatBufferBuilder builder, PurchaseLimitGranularity granularity)
		{
		}

		[Address(RVA="0x24DFCD8", Offset="0x24DFCD8", VA="0x24DFCD8")]
		public static Offset<PurchaseLimit> CreatePurchaseLimit(FlatBufferBuilder builder, PurchaseLimitGranularity granularity = 0, uint count = 0)
		{
			return new Offset<PurchaseLimit>();
		}

		[Address(RVA="0x24DFDB8", Offset="0x24DFDB8", VA="0x24DFDB8")]
		public static Offset<PurchaseLimit> EndPurchaseLimit(FlatBufferBuilder builder)
		{
			return new Offset<PurchaseLimit>();
		}

		[Address(RVA="0x24DFB34", Offset="0x24DFB34", VA="0x24DFB34")]
		public static PurchaseLimit GetRootAsPurchaseLimit(FlatBuffers.ByteBuffer _bb)
		{
			return new PurchaseLimit();
		}

		[Address(RVA="0x24DFB40", Offset="0x24DFB40", VA="0x24DFB40")]
		public static PurchaseLimit GetRootAsPurchaseLimit(FlatBuffers.ByteBuffer _bb, PurchaseLimit obj)
		{
			return new PurchaseLimit();
		}

		[Address(RVA="0x24DFE38", Offset="0x24DFE38", VA="0x24DFE38")]
		public static void StartPurchaseLimit(FlatBufferBuilder builder)
		{
		}
	}
}