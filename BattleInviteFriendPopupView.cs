using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class BattleInviteFriendPopupView : APopupView, IDispatchHandler<DPlayerProfileListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x10549CC", Offset="0x10549CC")]
	[FieldOffset(Offset="0x68")]
	private CostController _costController;

	[Attribute(Name="InjectAttribute", RVA="0x10549DC", Offset="0x10549DC")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDc;

	[FieldOffset(Offset="0x78")]
	private List<PlayerProfileSimple> _friends;

	[FieldOffset(Offset="0x80")]
	private PlayerProfileSimple _selectedFriend;

	private BattleInviteFriendPopupView.SerializedFields Fields
	{
		[Address(RVA="0x10FEC64", Offset="0x10FEC64", VA="0x10FEC64")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x10FF350", Offset="0x10FF350", VA="0x10FF350")]
	public BattleInviteFriendPopupView()
	{
	}

	[Address(RVA="0x10FF158", Offset="0x10FF158", VA="0x10FF158")]
	private void BindPlayer(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x10FED44", Offset="0x10FED44", VA="0x10FED44", Slot="22")]
	public void HandleDispatchAction(DPlayerProfileListItemAction action)
	{
	}

	[Address(RVA="0x10FF08C", Offset="0x10FF08C", VA="0x10FF08C")]
	private void InitializePlayer(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x10FF2C8", Offset="0x10FF2C8", VA="0x10FF2C8")]
	private void InviteClubClicked()
	{
	}

	[Address(RVA="0x10FF240", Offset="0x10FF240", VA="0x10FF240")]
	private void InviteFriendClicked()
	{
	}

	[Address(RVA="0x10FE394", Offset="0x10FE394", VA="0x10FE394")]
	public void SetData(List<PlayerProfileSimple> friends, Gamedata.InventoryItem? entryCostItem, ulong entryCost)
	{
	}

	[Address(RVA="0x10FEDB8", Offset="0x10FEDB8", VA="0x10FEDB8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x10FEF94", Offset="0x10FEF94", VA="0x10FEF94", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect FriendsScrollRect;

		[FieldOffset(Offset="0x38")]
		public CostButton InviteFriendButton;

		[FieldOffset(Offset="0x40")]
		public CostButton InviteClubButton;

		[Address(RVA="0x10FF358", Offset="0x10FF358", VA="0x10FF358")]
		public SerializedFields()
		{
		}
	}
}