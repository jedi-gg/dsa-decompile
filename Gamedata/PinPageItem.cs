using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PinPageItem : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF57718", Offset="0xF57718", VA="0xF57718", Slot="5")]
			get
			{
				return null;
			}
		}

		public bool Mystery
		{
			[Address(RVA="0xF57754", Offset="0xF57754", VA="0xF57754")]
			get
			{
				return new bool();
			}
		}

		public bool ObscureIcon
		{
			[Address(RVA="0xF5775C", Offset="0xF5775C", VA="0xF5775C")]
			get
			{
				return new bool();
			}
		}

		public ulong Pin
		{
			[Address(RVA="0xF57744", Offset="0xF57744", VA="0xF57744")]
			get
			{
				return new ulong();
			}
		}

		public ulong PlayerActivity
		{
			[Address(RVA="0xF5774C", Offset="0xF5774C", VA="0xF5774C")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF5772C", Offset="0xF5772C", VA="0xF5772C")]
		public PinPageItem __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PinPageItem();
		}

		[Address(RVA="0xF57720", Offset="0xF57720", VA="0xF57720", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24DC988", Offset="0x24DC988", VA="0x24DC988")]
		public static void AddMystery(FlatBufferBuilder builder, bool mystery)
		{
		}

		[Address(RVA="0x24DC94C", Offset="0x24DC94C", VA="0x24DC94C")]
		public static void AddObscureIcon(FlatBufferBuilder builder, bool obscureIcon)
		{
		}

		[Address(RVA="0x24DC910", Offset="0x24DC910", VA="0x24DC910")]
		public static void AddPin(FlatBufferBuilder builder, ulong pin)
		{
		}

		[Address(RVA="0x24DC8D4", Offset="0x24DC8D4", VA="0x24DC8D4")]
		public static void AddPlayerActivity(FlatBufferBuilder builder, ulong playerActivity)
		{
		}

		[Address(RVA="0x24DC844", Offset="0x24DC844", VA="0x24DC844")]
		public static Offset<PinPageItem> CreatePinPageItem(FlatBufferBuilder builder, ulong pin = 0L, ulong player_activity = 0L, bool mystery = false, bool obscure_icon = false)
		{
			return new Offset<PinPageItem>();
		}

		[Address(RVA="0x24DC9C4", Offset="0x24DC9C4", VA="0x24DC9C4")]
		public static Offset<PinPageItem> EndPinPageItem(FlatBufferBuilder builder)
		{
			return new Offset<PinPageItem>();
		}

		[Address(RVA="0x24DC5E8", Offset="0x24DC5E8", VA="0x24DC5E8")]
		public static PinPageItem GetRootAsPinPageItem(FlatBuffers.ByteBuffer _bb)
		{
			return new PinPageItem();
		}

		[Address(RVA="0x24DC5F4", Offset="0x24DC5F4", VA="0x24DC5F4")]
		public static PinPageItem GetRootAsPinPageItem(FlatBuffers.ByteBuffer _bb, PinPageItem obj)
		{
			return new PinPageItem();
		}

		[Address(RVA="0x24DCA44", Offset="0x24DCA44", VA="0x24DCA44")]
		public static void StartPinPageItem(FlatBufferBuilder builder)
		{
		}
	}
}