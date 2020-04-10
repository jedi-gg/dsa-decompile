using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ClubInviteManagementListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x30")]
	private SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x38")]
	private ClubInvite _invite;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private RawImage _playerAvatarImage;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private UiLabel _playerName;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private UiLabel _playerLevel;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private Button _approveButton;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private Button _rejectButton;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Image _vipBg;

	[Address(RVA="0x11BE27C", Offset="0x11BE27C", VA="0x11BE27C")]
	public ClubInviteManagementListItem()
	{
	}

	[Address(RVA="0x11BE16C", Offset="0x11BE16C", VA="0x11BE16C")]
	private void ApproveClicked()
	{
	}

	[Address(RVA="0x11BDD94", Offset="0x11BDD94", VA="0x11BDD94")]
	public void Initialize(WidgetDependencyContainer dependencies, object inventoryItemOwner)
	{
	}

	[Address(RVA="0x11BE1F4", Offset="0x11BE1F4", VA="0x11BE1F4")]
	private void RejectClicked()
	{
	}

	[Address(RVA="0x11BDF88", Offset="0x11BDF88", VA="0x11BDF88")]
	public void SetData(ClubInvite invite, Gamedata.InventoryItem? avatarItem)
	{
	}

	[Address(RVA="0x11BDEEC", Offset="0x11BDEEC", VA="0x11BDEEC", Slot="4")]
	public override void Shutdown()
	{
	}
}