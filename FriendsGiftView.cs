using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class FriendsGiftView : APopupView
{
	[FieldOffset(Offset="0x68")]
	private List<FriendGiftListItemData> _friends;

	private FriendsGiftView.SerializedFields Fields
	{
		[Address(RVA="0x15E8F14", Offset="0x15E8F14", VA="0x15E8F14")]
		get
		{
			return null;
		}
	}

	public RectTransform ListBounds
	{
		[Address(RVA="0x15E8E88", Offset="0x15E8E88", VA="0x15E8E88")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x15E9438", Offset="0x15E9438", VA="0x15E9438")]
	public FriendsGiftView()
	{
	}

	[Address(RVA="0x15E9338", Offset="0x15E9338", VA="0x15E9338")]
	private void BindFriendsListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x15E9254", Offset="0x15E9254", VA="0x15E9254")]
	private void InitializeFriendsListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x15E8FF4", Offset="0x15E8FF4", VA="0x15E8FF4")]
	public void SetData(List<FriendGiftListItemData> friends)
	{
	}

	[Address(RVA="0x15E9114", Offset="0x15E9114", VA="0x15E9114", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x15E91F8", Offset="0x15E91F8", VA="0x15E91F8", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106A564", Offset="0x106A564")]
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect FriendsScrollRect;

		[FieldOffset(Offset="0x38")]
		public UiLabel Title;

		[FieldOffset(Offset="0x40")]
		public UiLabel NoFriendsLabel;

		[FieldOffset(Offset="0x48")]
		public UiColorPalette ColorPalette;

		[Address(RVA="0x15E94A8", Offset="0x15E94A8", VA="0x15E94A8")]
		public SerializedFields()
		{
		}
	}
}