using Gamedata;
using Il2CppDummyDll;
using System;

public struct DHudConfig
{
	[FieldOffset(Offset="0x0")]
	public HudView.LeftButton LeftButton;

	[FieldOffset(Offset="0x4")]
	public bool LeftButtonEnabled;

	[FieldOffset(Offset="0x8")]
	public HudView.RightButton RightButton;

	[FieldOffset(Offset="0xC")]
	public bool RightButtonEnabled;

	[FieldOffset(Offset="0xD")]
	public bool GrindCurrency;

	[FieldOffset(Offset="0xE")]
	public bool PremiumCurrency;

	[FieldOffset(Offset="0xF")]
	public bool ShardShopCurrency;

	[FieldOffset(Offset="0x10")]
	public bool SocialCurrency;

	[FieldOffset(Offset="0x11")]
	public bool PvpCurrency;

	[FieldOffset(Offset="0x12")]
	public bool TowerCurrency;

	[FieldOffset(Offset="0x13")]
	public bool ClubCurrency;

	[FieldOffset(Offset="0x14")]
	public bool ClubDungeonCurrency;

	[FieldOffset(Offset="0x15")]
	public bool GrandCampaignCurrency;

	[FieldOffset(Offset="0x16")]
	public bool PveEnergy;

	[FieldOffset(Offset="0x17")]
	public bool GrandCampaignEnergy;

	[FieldOffset(Offset="0x18")]
	public bool UnitTrainingMaterials;

	[FieldOffset(Offset="0x20")]
	public HudItemComponent.Data CustomItem1;

	[FieldOffset(Offset="0x28")]
	public HudItemComponent.Data CustomItem2;

	[Address(RVA="0xEFDA5C", Offset="0xEFDA5C", VA="0xEFDA5C")]
	public void AppendCustomData(ulong itemId, InventoryItemType itemType, string imageAssetName)
	{
	}

	[Address(RVA="0x12A7A84", Offset="0x12A7A84", VA="0x12A7A84")]
	public static DHudConfig Default()
	{
		return new DHudConfig();
	}

	[Address(RVA="0xEFDA24", Offset="0xEFDA24", VA="0xEFDA24")]
	public bool EnableCurrency(ulong currencyId, CurrencyIds? currencyIds)
	{
		return new bool();
	}

	[Address(RVA="0x12A7ACC", Offset="0x12A7ACC", VA="0x12A7ACC")]
	public static DHudConfig NoCurrencyAndEnergy()
	{
		return new DHudConfig();
	}
}