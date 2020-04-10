using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class DailyActivityEnergyUtil
{
	[Attribute(Name="InjectAttribute", RVA="0x1057718", Offset="0x1057718")]
	[FieldOffset(Offset="0x10")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1057728", Offset="0x1057728")]
	[FieldOffset(Offset="0x18")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1057738", Offset="0x1057738")]
	[FieldOffset(Offset="0x20")]
	private FeatureLockController _featureLockController;

	[FieldOffset(Offset="0x28")]
	private List<DailyEnergyGiftListItemData> _energyData;

	[Address(RVA="0x12AC738", Offset="0x12AC738", VA="0x12AC738")]
	public DailyActivityEnergyUtil()
	{
	}

	[Address(RVA="0x12AC33C", Offset="0x12AC33C", VA="0x12AC33C")]
	public bool EnergyGiftClaimable()
	{
		return new bool();
	}

	[Address(RVA="0x12A8EBC", Offset="0x12A8EBC", VA="0x12A8EBC")]
	public List<DailyEnergyGiftListItemData> GetEnergyData()
	{
		return null;
	}

	[Address(RVA="0x12AC5A0", Offset="0x12AC5A0", VA="0x12AC5A0")]
	private int SortEnergyData(DailyEnergyGiftListItemData a, DailyEnergyGiftListItemData b)
	{
		return new int();
	}
}