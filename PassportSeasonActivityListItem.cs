using Il2CppDummyDll;
using System;
using UnityEngine;

public class PassportSeasonActivityListItem : PlayerActivityListItem
{
	[Attribute(Name="HeaderAttribute", RVA="0x105AC90", Offset="0x105AC90")]
	[FieldOffset(Offset="0x100")]
	[SerializeField]
	private PassportSeasonActivityListItem.ColorGroup _freeColors;

	[FieldOffset(Offset="0x108")]
	[SerializeField]
	private PassportSeasonActivityListItem.ColorGroup _premiumColors;

	[FieldOffset(Offset="0x110")]
	[SerializeField]
	private PassportSeasonActivityListItem.ColorGroup _premiumLockedColors;

	[FieldOffset(Offset="0x118")]
	[SerializeField]
	private PassportSeasonActivityListItem.ColorGroup _selectedColors;

	[FieldOffset(Offset="0x120")]
	[SerializeField]
	private GameObject _lockIcon;

	[FieldOffset(Offset="0x128")]
	[SerializeField]
	private GameObject _premiumActivityContainer;

	[Address(RVA="0x13FB788", Offset="0x13FB788", VA="0x13FB788")]
	public PassportSeasonActivityListItem()
	{
	}

	[Address(RVA="0x13FB658", Offset="0x13FB658", VA="0x13FB658")]
	private void SetColors(PassportSeasonActivityListItem.ColorGroup cg)
	{
	}

	[Address(RVA="0x13FB4F8", Offset="0x13FB4F8", VA="0x13FB4F8")]
	public void SetIsPlayerPremium(bool playerIsPremium)
	{
	}

	[Serializable]
	public class ColorGroup
	{
		[FieldOffset(Offset="0x10")]
		public Color Background;

		[FieldOffset(Offset="0x20")]
		public Color PrimaryText;

		[FieldOffset(Offset="0x30")]
		public Color SecondaryText;

		[Address(RVA="0x13FB790", Offset="0x13FB790", VA="0x13FB790")]
		public ColorGroup()
		{
		}
	}
}