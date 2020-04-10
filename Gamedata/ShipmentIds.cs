using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ShipmentIds : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF58B78", Offset="0xF58B78", VA="0xF58B78", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Club
		{
			[Address(RVA="0xF58BA4", Offset="0xF58BA4", VA="0xF58BA4")]
			get
			{
				return new ulong();
			}
		}

		public ulong Pvp
		{
			[Address(RVA="0xF58BAC", Offset="0xF58BAC", VA="0xF58BAC")]
			get
			{
				return new ulong();
			}
		}

		public ulong Tower
		{
			[Address(RVA="0xF58BB4", Offset="0xF58BB4", VA="0xF58BB4")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF58B8C", Offset="0xF58B8C", VA="0xF58B8C")]
		public ShipmentIds __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ShipmentIds();
		}

		[Address(RVA="0xF58B80", Offset="0xF58B80", VA="0xF58B80", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E9750", Offset="0x24E9750", VA="0x24E9750")]
		public static void AddClub(FlatBufferBuilder builder, ulong club)
		{
		}

		[Address(RVA="0x24E9714", Offset="0x24E9714", VA="0x24E9714")]
		public static void AddPvp(FlatBufferBuilder builder, ulong pvp)
		{
		}

		[Address(RVA="0x24E96D8", Offset="0x24E96D8", VA="0x24E96D8")]
		public static void AddTower(FlatBufferBuilder builder, ulong tower)
		{
		}

		[Address(RVA="0x24E9660", Offset="0x24E9660", VA="0x24E9660")]
		public static Offset<ShipmentIds> CreateShipmentIds(FlatBufferBuilder builder, ulong club = 0L, ulong pvp = 0L, ulong tower = 0L)
		{
			return new Offset<ShipmentIds>();
		}

		[Address(RVA="0x24E978C", Offset="0x24E978C", VA="0x24E978C")]
		public static Offset<ShipmentIds> EndShipmentIds(FlatBufferBuilder builder)
		{
			return new Offset<ShipmentIds>();
		}

		[Address(RVA="0x24E9448", Offset="0x24E9448", VA="0x24E9448")]
		public static ShipmentIds GetRootAsShipmentIds(FlatBuffers.ByteBuffer _bb)
		{
			return new ShipmentIds();
		}

		[Address(RVA="0x24E9454", Offset="0x24E9454", VA="0x24E9454")]
		public static ShipmentIds GetRootAsShipmentIds(FlatBuffers.ByteBuffer _bb, ShipmentIds obj)
		{
			return new ShipmentIds();
		}

		[Address(RVA="0x24E980C", Offset="0x24E980C", VA="0x24E980C")]
		public static void StartShipmentIds(FlatBufferBuilder builder)
		{
		}
	}
}