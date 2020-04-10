using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ChatSettingsPopupView : APopupView
{
	[FieldOffset(Offset="0x68")]
	private IReadOnlyList<PlayerListItemData> _blockedUsers;

	private ChatSettingsPopupView.SerializedFields Fields
	{
		[Address(RVA="0x11A1CBC", Offset="0x11A1CBC", VA="0x11A1CBC")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11A214C", Offset="0x11A214C", VA="0x11A214C")]
	public ChatSettingsPopupView()
	{
	}

	[Address(RVA="0x11A1FF4", Offset="0x11A1FF4", VA="0x11A1FF4")]
	private void BindPlayerListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x11A1F10", Offset="0x11A1F10", VA="0x11A1F10")]
	private void InitializePlayerListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11A139C", Offset="0x11A139C", VA="0x11A139C")]
	public void SetData(IReadOnlyList<PlayerListItemData> blockedUsers)
	{
	}

	[Address(RVA="0x11A1D9C", Offset="0x11A1D9C", VA="0x11A1D9C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11A1EB4", Offset="0x11A1EB4", VA="0x11A1EB4", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect ScrollRect;

		[FieldOffset(Offset="0x38")]
		public UiColorPalette ColorPalette;

		[FieldOffset(Offset="0x40")]
		public UnityEngine.GameObject ListEmptyLabel;

		[Address(RVA="0x11A2154", Offset="0x11A2154", VA="0x11A2154")]
		public SerializedFields()
		{
		}
	}
}