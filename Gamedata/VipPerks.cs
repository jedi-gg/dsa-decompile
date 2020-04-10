using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct VipPerks : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0C498", Offset="0xF0C498", VA="0xF0C498", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint CavernCrawlBonusAttempts
		{
			[Address(RVA="0xF0C4E4", Offset="0xF0C4E4", VA="0xF0C4E4")]
			get
			{
				return new uint();
			}
		}

		public uint EliteBonusAttempts
		{
			[Address(RVA="0xF0C4DC", Offset="0xF0C4DC", VA="0xF0C4DC")]
			get
			{
				return new uint();
			}
		}

		public uint GrandEnergyRefreshBonus
		{
			[Address(RVA="0xF0C4D4", Offset="0xF0C4D4", VA="0xF0C4D4")]
			get
			{
				return new uint();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0C4C4", Offset="0xF0C4C4", VA="0xF0C4C4")]
			get
			{
				return new ulong();
			}
		}

		public uint PveEnergyRefreshBonus
		{
			[Address(RVA="0xF0C4CC", Offset="0xF0C4CC", VA="0xF0C4CC")]
			get
			{
				return new uint();
			}
		}

		public ulong UpgradePreviewDeepLinkStoreDefId
		{
			[Address(RVA="0xF0C4EC", Offset="0xF0C4EC", VA="0xF0C4EC")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF0C4AC", Offset="0xF0C4AC", VA="0xF0C4AC")]
		public VipPerks __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new VipPerks();
		}

		[Address(RVA="0xF0C4A0", Offset="0xF0C4A0", VA="0xF0C4A0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x1680C94", Offset="0x1680C94", VA="0x1680C94")]
		public static void AddCavernCrawlBonusAttempts(FlatBufferBuilder builder, uint cavernCrawlBonusAttempts)
		{
		}

		[Address(RVA="0x1680CD0", Offset="0x1680CD0", VA="0x1680CD0")]
		public static void AddEliteBonusAttempts(FlatBufferBuilder builder, uint eliteBonusAttempts)
		{
		}

		[Address(RVA="0x1680D0C", Offset="0x1680D0C", VA="0x1680D0C")]
		public static void AddGrandEnergyRefreshBonus(FlatBufferBuilder builder, uint grandEnergyRefreshBonus)
		{
		}

		[Address(RVA="0x1680C58", Offset="0x1680C58", VA="0x1680C58")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x1680D48", Offset="0x1680D48", VA="0x1680D48")]
		public static void AddPveEnergyRefreshBonus(FlatBufferBuilder builder, uint pveEnergyRefreshBonus)
		{
		}

		[Address(RVA="0x1680C1C", Offset="0x1680C1C", VA="0x1680C1C")]
		public static void AddUpgradePreviewDeepLinkStoreDefId(FlatBufferBuilder builder, ulong upgradePreviewDeepLinkStoreDefId)
		{
		}

		[Address(RVA="0x1680B64", Offset="0x1680B64", VA="0x1680B64")]
		public static Offset<VipPerks> CreateVipPerks(FlatBufferBuilder builder, ulong id = 0L, uint pve_energy_refresh_bonus = 0, uint grand_energy_refresh_bonus = 0, uint elite_bonus_attempts = 0, uint cavern_crawl_bonus_attempts = 0, ulong upgrade_preview_deep_link_store_def_id = 0L)
		{
			return new Offset<VipPerks>();
		}

		[Address(RVA="0x1680D84", Offset="0x1680D84", VA="0x1680D84")]
		public static Offset<VipPerks> EndVipPerks(FlatBufferBuilder builder)
		{
			return new Offset<VipPerks>();
		}

		[Address(RVA="0x1680E34", Offset="0x1680E34", VA="0x1680E34")]
		public static void FinishVipPerksBuffer(FlatBufferBuilder builder, Offset<VipPerks> offset)
		{
		}

		[Address(RVA="0x1680818", Offset="0x1680818", VA="0x1680818")]
		public static VipPerks GetRootAsVipPerks(FlatBuffers.ByteBuffer _bb)
		{
			return new VipPerks();
		}

		[Address(RVA="0x1680824", Offset="0x1680824", VA="0x1680824")]
		public static VipPerks GetRootAsVipPerks(FlatBuffers.ByteBuffer _bb, VipPerks obj)
		{
			return new VipPerks();
		}

		[Address(RVA="0x1680E04", Offset="0x1680E04", VA="0x1680E04")]
		public static void StartVipPerks(FlatBufferBuilder builder)
		{
		}
	}
}