using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct EnergyIdMapping : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5A0C0", Offset="0xF5A0C0", VA="0xF5A0C0", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong EnergyConstants
		{
			[Address(RVA="0xF5A0F4", Offset="0xF5A0F4", VA="0xF5A0F4")]
			get
			{
				return new ulong();
			}
		}

		public ulong ItemId
		{
			[Address(RVA="0xF5A0EC", Offset="0xF5A0EC", VA="0xF5A0EC")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF5A0D4", Offset="0xF5A0D4", VA="0xF5A0D4")]
		public EnergyIdMapping __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new EnergyIdMapping();
		}

		[Address(RVA="0xF5A0C8", Offset="0xF5A0C8", VA="0xF5A0C8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2511420", Offset="0x2511420", VA="0x2511420")]
		public static void AddEnergyConstants(FlatBufferBuilder builder, ulong energyConstants)
		{
		}

		[Address(RVA="0x251145C", Offset="0x251145C", VA="0x251145C")]
		public static void AddItemId(FlatBufferBuilder builder, ulong itemId)
		{
		}

		[Address(RVA="0x25113B8", Offset="0x25113B8", VA="0x25113B8")]
		public static Offset<EnergyIdMapping> CreateEnergyIdMapping(FlatBufferBuilder builder, ulong item_id = 0L, ulong energy_constants = 0L)
		{
			return new Offset<EnergyIdMapping>();
		}

		[Address(RVA="0x2511498", Offset="0x2511498", VA="0x2511498")]
		public static Offset<EnergyIdMapping> EndEnergyIdMapping(FlatBufferBuilder builder)
		{
			return new Offset<EnergyIdMapping>();
		}

		[Address(RVA="0x251120C", Offset="0x251120C", VA="0x251120C")]
		public static EnergyIdMapping GetRootAsEnergyIdMapping(FlatBuffers.ByteBuffer _bb)
		{
			return new EnergyIdMapping();
		}

		[Address(RVA="0x2511218", Offset="0x2511218", VA="0x2511218")]
		public static EnergyIdMapping GetRootAsEnergyIdMapping(FlatBuffers.ByteBuffer _bb, EnergyIdMapping obj)
		{
			return new EnergyIdMapping();
		}

		[Address(RVA="0x2511518", Offset="0x2511518", VA="0x2511518")]
		public static void StartEnergyIdMapping(FlatBufferBuilder builder)
		{
		}
	}
}