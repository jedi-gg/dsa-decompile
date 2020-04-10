using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ClubInvitesListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private UiLabel _clubNameLabel;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private Graphic _background;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private UnityEngine.Color _oddBgColor;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private UnityEngine.Color _evenBgColor;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private RawImage _icon;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private GameObject _incomingButtonsRoot;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Button _viewInviteButton;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private GameObject _outgoingButtonsRoot;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private Button _viewClubButton;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private Button _cancelRequestButton;

	[FieldOffset(Offset="0x88")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x90")]
	private SingleAssetRegistry _singleAssetRegistry;

	[FieldOffset(Offset="0x98")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0xA0")]
	private ClubInvite _invite;

	[Address(RVA="0x11C0B3C", Offset="0x11C0B3C", VA="0x11C0B3C")]
	public ClubInvitesListItem()
	{
	}

	[Address(RVA="0x11C0AB4", Offset="0x11C0AB4", VA="0x11C0AB4")]
	private void CancelInviteClicked()
	{
	}

	[Address(RVA="0x11C041C", Offset="0x11C041C", VA="0x11C041C")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11C06E0", Offset="0x11C06E0", VA="0x11C06E0")]
	public void SetData(ClubInvite invite, int index, Gamedata.InventoryItem? clubAvatar, bool isJoinRequest)
	{
	}

	[Address(RVA="0x11C05FC", Offset="0x11C05FC", VA="0x11C05FC", Slot="4")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x11C0A2C", Offset="0x11C0A2C", VA="0x11C0A2C")]
	private void ViewClubClicked()
	{
	}

	[Address(RVA="0x11C09A4", Offset="0x11C09A4", VA="0x11C09A4")]
	private void ViewInviteClicked()
	{
	}
}