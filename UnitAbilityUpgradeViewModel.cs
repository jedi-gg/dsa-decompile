using Gamedata;
using Il2CppDummyDll;
using System;

public class UnitAbilityUpgradeViewModel : AAbilityUpgradeViewModel
{
	[FieldOffset(Offset="0x30")]
	public UnitAbility? UnitAbilityDef;

	[FieldOffset(Offset="0x48")]
	public bool UnitIsOwned;

	[FieldOffset(Offset="0x50")]
	public ulong UnitLevel;

	[FieldOffset(Offset="0x58")]
	public ulong UnitGearTier;

	[FieldOffset(Offset="0x60")]
	public ulong UnitId;

	[FieldOffset(Offset="0x68")]
	public int AbilityId;

	[Address(RVA="0x11DEBA8", Offset="0x11DEBA8", VA="0x11DEBA8")]
	public UnitAbilityUpgradeViewModel()
	{
	}
}