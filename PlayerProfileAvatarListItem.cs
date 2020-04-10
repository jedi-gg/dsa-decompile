using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerProfileAvatarListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x30")]
	private SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x38")]
	private InventoryItem? _avatar;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private RawImage _avatarImage;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private Image _selectionBorder;

	[Address(RVA="0x133EA70", Offset="0x133EA70", VA="0x133EA70")]
	public PlayerProfileAvatarListItem()
	{
	}

	[Address(RVA="0x133E9CC", Offset="0x133E9CC", VA="0x133E9CC")]
	private void Clicked()
	{
	}

	[Address(RVA="0x133E6C0", Offset="0x133E6C0", VA="0x133E6C0")]
	public void Initialize(WidgetDependencyContainer dependencies, object inventoryItemOwner)
	{
	}

	[Address(RVA="0x133E830", Offset="0x133E830", VA="0x133E830")]
	public void SetData(InventoryItem? avatar, bool isSelected)
	{
	}

	[Address(RVA="0x133E7B4", Offset="0x133E7B4", VA="0x133E7B4", Slot="4")]
	public override void Shutdown()
	{
	}
}