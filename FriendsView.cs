using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendsView : AStandardView, IDispatchHandler<DPlayerListItemClickedAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x10585B0", Offset="0x10585B0")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x10585C0", Offset="0x10585C0")]
	[FieldOffset(Offset="0x70")]
	private BadgingController _badgingController;

	[FieldOffset(Offset="0x78")]
	private List<FriendsListItemData> _friends;

	[FieldOffset(Offset="0x80")]
	private List<FriendsListItemData> _invites;

	[FieldOffset(Offset="0x88")]
	private PlayerListItem _selectedFriendListItem;

	[FieldOffset(Offset="0x90")]
	private FriendsView.Tab _tab;

	private FriendsView.SerializedFields Fields
	{
		[Address(RVA="0x15E95EC", Offset="0x15E95EC", VA="0x15E95EC")]
		get
		{
			return null;
		}
	}

	public RectTransform ListBounds
	{
		[Address(RVA="0x15E9560", Offset="0x15E9560", VA="0x15E9560")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x15EA38C", Offset="0x15EA38C", VA="0x15EA38C")]
	public FriendsView()
	{
	}

	[Address(RVA="0x15EA41C", Offset="0x15EA41C", VA="0x15EA41C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FA14", Offset="0x106FA14")]
	private void <ViewAssetLoaded>b__4_0()
	{
	}

	[Address(RVA="0x15EA1B8", Offset="0x15EA1B8", VA="0x15EA1B8")]
	private void BindFriendsListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x15E9FBC", Offset="0x15E9FBC", VA="0x15E9FBC")]
	private void DispatchViewAction(DFriendsViewAction.Type type)
	{
	}

	[Address(RVA="0x15EA354", Offset="0x15EA354", VA="0x15EA354")]
	private void FriendsToggled(bool isOn)
	{
	}

	[Address(RVA="0x15E9B80", Offset="0x15E9B80", VA="0x15E9B80", Slot="21")]
	public void HandleDispatchAction(DPlayerListItemClickedAction action)
	{
	}

	[Address(RVA="0x15EA0D4", Offset="0x15EA0D4", VA="0x15EA0D4")]
	private void InitializeFriendsListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x15EA36C", Offset="0x15EA36C", VA="0x15EA36C")]
	private void InvitesToggled(bool isOn)
	{
	}

	[Address(RVA="0x15E96CC", Offset="0x15E96CC", VA="0x15E96CC")]
	public void SetData(List<FriendsListItemData> friends)
	{
	}

	[Address(RVA="0x15E9998", Offset="0x15E9998", VA="0x15E9998")]
	private void SetFilteredData()
	{
	}

	[Address(RVA="0x15E9B88", Offset="0x15E9B88", VA="0x15E9B88", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x15E9E34", Offset="0x15E9E34", VA="0x15E9E34", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106A52C", Offset="0x106A52C")]
		[FieldOffset(Offset="0x28")]
		public List<Badge> Badges;

		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect FriendsScrollRect;

		[FieldOffset(Offset="0x38")]
		public Button InviteLinkButton;

		[FieldOffset(Offset="0x40")]
		public UiLabel NoFriendsLabel;

		[FieldOffset(Offset="0x48")]
		public UiLabel NoFriendsInvitesLabel;

		[FieldOffset(Offset="0x50")]
		public UiColorPalette ColorPalette;

		[FieldOffset(Offset="0x58")]
		public Toggle FriendsToggle;

		[FieldOffset(Offset="0x60")]
		public Toggle InvitesToggle;

		[FieldOffset(Offset="0x68")]
		public UiLabel FriendsCountLabel;

		[Address(RVA="0x15EA424", Offset="0x15EA424", VA="0x15EA424")]
		public SerializedFields()
		{
		}
	}

	private enum Tab
	{
		[FieldOffset(Offset="0x0")]
		Friends,
		[FieldOffset(Offset="0x0")]
		Invites
	}
}