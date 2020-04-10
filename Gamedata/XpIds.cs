using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct XpIds : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0C690", Offset="0xF0C690", VA="0xF0C690", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong PassportGeneric
		{
			[Address(RVA="0xF0C6C4", Offset="0xF0C6C4", VA="0xF0C6C4")]
			get
			{
				return new ulong();
			}
		}

		public ulong Player
		{
			[Address(RVA="0xF0C6BC", Offset="0xF0C6BC", VA="0xF0C6BC")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF0C6A4", Offset="0xF0C6A4", VA="0xF0C6A4")]
		public XpIds __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new XpIds();
		}

		[Address(RVA="0xF0C698", Offset="0xF0C698", VA="0xF0C698", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x1681D20", Offset="0x1681D20", VA="0x1681D20")]
		public static void AddPassportGeneric(FlatBufferBuilder builder, ulong passportGeneric)
		{
		}

		[Address(RVA="0x1681D5C", Offset="0x1681D5C", VA="0x1681D5C")]
		public static void AddPlayer(FlatBufferBuilder builder, ulong player)
		{
		}

		[Address(RVA="0x1681CB8", Offset="0x1681CB8", VA="0x1681CB8")]
		public static Offset<XpIds> CreateXpIds(FlatBufferBuilder builder, ulong player = 0L, ulong passport_generic = 0L)
		{
			return new Offset<XpIds>();
		}

		[Address(RVA="0x1681D98", Offset="0x1681D98", VA="0x1681D98")]
		public static Offset<XpIds> EndXpIds(FlatBufferBuilder builder)
		{
			return new Offset<XpIds>();
		}

		[Address(RVA="0x1681B0C", Offset="0x1681B0C", VA="0x1681B0C")]
		public static XpIds GetRootAsXpIds(FlatBuffers.ByteBuffer _bb)
		{
			return new XpIds();
		}

		[Address(RVA="0x1681B18", Offset="0x1681B18", VA="0x1681B18")]
		public static XpIds GetRootAsXpIds(FlatBuffers.ByteBuffer _bb, XpIds obj)
		{
			return new XpIds();
		}

		[Address(RVA="0x1681E18", Offset="0x1681E18", VA="0x1681E18")]
		public static void StartXpIds(FlatBufferBuilder builder)
		{
		}
	}
}