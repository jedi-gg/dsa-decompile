using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class FriendGiftListItem : PlayerListItem
{
	[FieldOffset(Offset="0xF0")]
	[SerializeField]
	private Button _selectAFriendGiftButton;

	[Address(RVA="0x12CAF7C", Offset="0x12CAF7C", VA="0x12CAF7C")]
	public FriendGiftListItem()
	{
	}

	[Address(RVA="0x12CAD80", Offset="0x12CAD80", VA="0x12CAD80", Slot="7")]
	public override void Initialize(WidgetDependencyContainer dependencies, UiColorPalette colorPalette)
	{
	}

	[Address(RVA="0x12CAEF4", Offset="0x12CAEF4", VA="0x12CAEF4")]
	private void SelectAFriendGift()
	{
	}

	[Address(RVA="0x12CAEA4", Offset="0x12CAEA4", VA="0x12CAEA4")]
	public void ShowSendGiftButton(bool show)
	{
	}

	[Address(RVA="0x12CAE4C", Offset="0x12CAE4C", VA="0x12CAE4C", Slot="4")]
	public override void Shutdown()
	{
	}
}