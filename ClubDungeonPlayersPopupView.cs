using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class ClubDungeonPlayersPopupView : APopupView
{
	[FieldOffset(Offset="0x68")]
	private IReadOnlyList<PlayerListItemData> _players;

	private ClubDungeonPlayersPopupView.SerializedFields Fields
	{
		[Address(RVA="0x11B303C", Offset="0x11B303C", VA="0x11B303C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11B34F4", Offset="0x11B34F4", VA="0x11B34F4")]
	public ClubDungeonPlayersPopupView()
	{
	}

	[Address(RVA="0x11B333C", Offset="0x11B333C", VA="0x11B333C")]
	private void BindPlayer(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x11B325C", Offset="0x11B325C", VA="0x11B325C")]
	private void InitializePlayer(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11B2E5C", Offset="0x11B2E5C", VA="0x11B2E5C")]
	public void SetData(List<PlayerListItemData> players)
	{
	}

	[Address(RVA="0x11B311C", Offset="0x11B311C", VA="0x11B311C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11B3200", Offset="0x11B3200", VA="0x11B3200", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public UiLabel HeaderLabel;

		[FieldOffset(Offset="0x38")]
		public WrappedScrollRect PlayersScrollRect;

		[FieldOffset(Offset="0x40")]
		public UiColorPalette ColorPalette;

		[Address(RVA="0x11B34FC", Offset="0x11B34FC", VA="0x11B34FC")]
		public SerializedFields()
		{
		}
	}
}