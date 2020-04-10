using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ClubDungeonLeaderboardPopupView : APopupView, IDispatchHandler<DUiTabGroupAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x68")]
	private int _allClubsTabIndex;

	[FieldOffset(Offset="0x6C")]
	private int _myClubTabIndex;

	[FieldOffset(Offset="0x70")]
	private IReadOnlyList<ClubLeaderboardEntry> _clubs;

	[FieldOffset(Offset="0x78")]
	private IReadOnlyList<PlayerListItemData> _players;

	private ClubDungeonLeaderboardPopupView.SerializedFields Fields
	{
		[Address(RVA="0x11B0A88", Offset="0x11B0A88", VA="0x11B0A88")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11B1558", Offset="0x11B1558", VA="0x11B1558")]
	public ClubDungeonLeaderboardPopupView()
	{
	}

	[Address(RVA="0x11B10CC", Offset="0x11B10CC", VA="0x11B10CC")]
	private void BindClubListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x11B139C", Offset="0x11B139C", VA="0x11B139C")]
	private void BindPlayerListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x11B0B68", Offset="0x11B0B68", VA="0x11B0B68", Slot="22")]
	public void HandleDispatchAction(DUiTabGroupAction action)
	{
	}

	[Address(RVA="0x11B0FEC", Offset="0x11B0FEC", VA="0x11B0FEC")]
	private void InitializeClubListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11B12B8", Offset="0x11B12B8", VA="0x11B12B8")]
	private void InitializePlayerListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11B0A2C", Offset="0x11B0A2C", VA="0x11B0A2C")]
	public void SelectAllClubsTab()
	{
	}

	[Address(RVA="0x11B09E0", Offset="0x11B09E0", VA="0x11B09E0")]
	public void SelectMyClubTab()
	{
	}

	[Address(RVA="0x11B014C", Offset="0x11B014C", VA="0x11B014C")]
	public void SetData(IReadOnlyList<ClubLeaderboardEntry> entries)
	{
	}

	[Address(RVA="0x11B0634", Offset="0x11B0634", VA="0x11B0634")]
	public void SetData(IReadOnlyList<PlayerListItemData> entries)
	{
	}

	[Address(RVA="0x11AFCBC", Offset="0x11AFCBC", VA="0x11AFCBC")]
	public void ShowErrorMessage(bool showing)
	{
	}

	[Address(RVA="0x11AFC74", Offset="0x11AFC74", VA="0x11AFC74")]
	public void ShowSpinner(bool showing)
	{
	}

	[Address(RVA="0x11B0C94", Offset="0x11B0C94", VA="0x11B0C94", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11B0F10", Offset="0x11B0F10", VA="0x11B0F10", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public UiTab AllClubsTab;

		[FieldOffset(Offset="0x38")]
		public UiTab MyClubTab;

		[FieldOffset(Offset="0x40")]
		public UiTabGroup TabGroup;

		[FieldOffset(Offset="0x48")]
		public UnityEngine.GameObject TabGroupInputBlocker;

		[FieldOffset(Offset="0x50")]
		public UnityEngine.GameObject LoadingScrim;

		[FieldOffset(Offset="0x58")]
		public WrappedScrollRect ClubsScrollRect;

		[FieldOffset(Offset="0x60")]
		public WrappedScrollRect PlayersScrollRect;

		[FieldOffset(Offset="0x68")]
		public UiLabel HeadingLabel;

		[FieldOffset(Offset="0x70")]
		public UiLabel ErrorLabel;

		[FieldOffset(Offset="0x78")]
		public UiColorPalette ColorPalette;

		[Address(RVA="0x11B1560", Offset="0x11B1560", VA="0x11B1560")]
		public SerializedFields()
		{
		}
	}
}