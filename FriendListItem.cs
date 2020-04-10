using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class FriendListItem : PlayerListItem
{
	[FieldOffset(Offset="0xF0")]
	[SerializeField]
	private Button _cancelFriendRequestButton;

	[FieldOffset(Offset="0xF8")]
	[SerializeField]
	private Button _rejectFriendInviteButton;

	[FieldOffset(Offset="0x100")]
	[SerializeField]
	private Button _acceptFriendInviteButton;

	[Address(RVA="0x12CB4E8", Offset="0x12CB4E8", VA="0x12CB4E8")]
	public FriendListItem()
	{
	}

	[Address(RVA="0x12CB460", Offset="0x12CB460", VA="0x12CB460")]
	private void AcceptFriendInvite()
	{
	}

	[Address(RVA="0x12CB350", Offset="0x12CB350", VA="0x12CB350")]
	private void CancelFriendRequest()
	{
	}

	[Address(RVA="0x12CB024", Offset="0x12CB024", VA="0x12CB024", Slot="7")]
	public override void Initialize(WidgetDependencyContainer dependencies, UiColorPalette colorPalette)
	{
	}

	[Address(RVA="0x12CB3D8", Offset="0x12CB3D8", VA="0x12CB3D8")]
	private void RejectFriendInvite()
	{
	}

	[Address(RVA="0x12CB278", Offset="0x12CB278", VA="0x12CB278")]
	public void SetFriendStatus(FriendStatus status)
	{
	}

	[Address(RVA="0x12CB1B8", Offset="0x12CB1B8", VA="0x12CB1B8", Slot="4")]
	public override void Shutdown()
	{
	}
}