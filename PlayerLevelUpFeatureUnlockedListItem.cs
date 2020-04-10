using Il2CppDummyDll;
using System;
using UnityEngine;

public class PlayerLevelUpFeatureUnlockedListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private UiLabel _featureNameLabel;

	[Address(RVA="0x133C3E0", Offset="0x133C3E0", VA="0x133C3E0")]
	public PlayerLevelUpFeatureUnlockedListItem()
	{
	}

	[Address(RVA="0x133C3A4", Offset="0x133C3A4", VA="0x133C3A4")]
	public void SetData(string featureName)
	{
	}
}