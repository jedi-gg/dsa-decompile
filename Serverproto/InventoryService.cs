using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public class InventoryService : AInventoryService
	{
		[Attribute(Name="InjectAttribute", RVA="0x1063B3C", Offset="0x1063B3C")]
		[FieldOffset(Offset="0x50")]
		private IPlayerAuthenticator _playerAuthenticator;

		[Attribute(Name="InjectAttribute", RVA="0x1063B4C", Offset="0x1063B4C")]
		[FieldOffset(Offset="0x58")]
		private GamedataManager _gamedataManager;

		[Address(RVA="0x1A90BBC", Offset="0x1A90BBC", VA="0x1A90BBC")]
		public InventoryService()
		{
		}

		[Address(RVA="0x1A9095C", Offset="0x1A9095C", VA="0x1A9095C", Slot="12")]
		protected override void AbilityUpgradeServiceSuccess(AbilityUpgradeResponse response)
		{
		}

		[Address(RVA="0x1A90B7C", Offset="0x1A90B7C", VA="0x1A90B7C", Slot="20")]
		protected override void BuyAndEquipAllGearServiceSuccess(BuyAndEquipAllGearResponse response)
		{
		}

		[Address(RVA="0x1A90B3C", Offset="0x1A90B3C", VA="0x1A90B3C", Slot="19")]
		protected override void BuyAndEquipGearServiceSuccess(BuyAndEquipGearResponse response)
		{
		}

		[Address(RVA="0x1A9085C", Offset="0x1A9085C", VA="0x1A9085C", Slot="7")]
		protected override void CraftItemServiceSuccess(CraftInventoryItemResponse response)
		{
		}

		[Address(RVA="0x1A908DC", Offset="0x1A908DC", VA="0x1A908DC", Slot="9")]
		protected override void EquipAllGearServiceSuccess(EquipAllGearResponse response)
		{
		}

		[Address(RVA="0x1A909DC", Offset="0x1A909DC", VA="0x1A909DC", Slot="15")]
		protected override void EquipEmoteServiceSuccess(EquipEmoteResponse response)
		{
		}

		[Address(RVA="0x1A9089C", Offset="0x1A9089C", VA="0x1A9089C", Slot="8")]
		protected override void EquipGearServiceSuccess(EquipGearResponse response)
		{
		}

		[Address(RVA="0x1A90A7C", Offset="0x1A90A7C", VA="0x1A90A7C", Slot="16")]
		protected override void EquipSorcererStoneServiceSuccess(EquipSorcererStoneResponse response)
		{
		}

		[Address(RVA="0x1A9091C", Offset="0x1A9091C", VA="0x1A9091C", Slot="10")]
		protected override void GearTierUpServiceSuccess(GearTierUpResponse response)
		{
		}

		[Address(RVA="0x1A90794", Offset="0x1A90794", VA="0x1A90794")]
		private void HandleInventoryDelta(InventoryDelta delta)
		{
		}

		[Address(RVA="0x1A90754", Offset="0x1A90754", VA="0x1A90754", Slot="5")]
		protected override void PromoteUnitServiceSuccess(PromoteUnitResponse response)
		{
		}

		[Address(RVA="0x1A9099C", Offset="0x1A9099C", VA="0x1A9099C", Slot="13")]
		protected override void SpellUpgradeServiceSuccess(SpellUpgradeResponse response)
		{
		}

		[Address(RVA="0x1A90AFC", Offset="0x1A90AFC", VA="0x1A90AFC", Slot="18")]
		protected override void SwapSorcererStoneServiceSuccess(SwapSorcererStoneResponse response)
		{
		}

		[Address(RVA="0x1A9081C", Offset="0x1A9081C", VA="0x1A9081C", Slot="6")]
		protected override void TrainUnitServiceSuccess(TrainUnitResponse response)
		{
		}

		[Address(RVA="0x1A90ABC", Offset="0x1A90ABC", VA="0x1A90ABC", Slot="17")]
		protected override void UnequipSorcererStoneServiceSuccess(UnequipSorcererStoneResponse response)
		{
		}
	}
}