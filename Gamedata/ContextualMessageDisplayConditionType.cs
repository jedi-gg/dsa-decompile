using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public enum ContextualMessageDisplayConditionType : sbyte
	{
		[FieldOffset(Offset="0x0")]
		NONE,
		[FieldOffset(Offset="0x0")]
		UnitCanBeTrained,
		[FieldOffset(Offset="0x0")]
		UnitCanBeUnlocked,
		[FieldOffset(Offset="0x0")]
		SpellCanBeUnlocked,
		[FieldOffset(Offset="0x0")]
		UnitCanEquipGear,
		[FieldOffset(Offset="0x0")]
		PlayerActivityCanBeClaimed,
		[FieldOffset(Offset="0x0")]
		UnitAbilityCanBeUpgraded,
		[FieldOffset(Offset="0x0")]
		UnitCanBePromoted,
		[FieldOffset(Offset="0x0")]
		PlayerIsInClub,
		[FieldOffset(Offset="0x0")]
		PassportSeasonActive,
		[FieldOffset(Offset="0x0")]
		CampaignHasInstantBattleAvailable,
		[FieldOffset(Offset="0x0")]
		HeroCanEquipGear,
		[FieldOffset(Offset="0x0")]
		VillainCanEquipGear,
		[FieldOffset(Offset="0x0")]
		HeroCanBeTrained,
		[FieldOffset(Offset="0x0")]
		VillainCanBeTrained,
		[FieldOffset(Offset="0x0")]
		CanEquipAndDoesntOwnGearItem,
		[FieldOffset(Offset="0x0")]
		AnyUnitCanCraftAnyUnownedGearAtGearTier
	}
}