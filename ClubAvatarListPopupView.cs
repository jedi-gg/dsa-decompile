using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class ClubAvatarListPopupView : APopupView
{
	[FieldOffset(Offset="0x68")]
	private IReadOnlyList<InventoryItem?> _icons;

	private ClubAvatarListPopupView.SerializedFields Fields
	{
		[Address(RVA="0x1468290", Offset="0x1468290", VA="0x1468290")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x146870C", Offset="0x146870C", VA="0x146870C")]
	public ClubAvatarListPopupView()
	{
	}

	[Address(RVA="0x14685A0", Offset="0x14685A0", VA="0x14685A0")]
	private void BindAvatarListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x14684B0", Offset="0x14684B0", VA="0x14684B0")]
	private void InitializeAvatarListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x1468164", Offset="0x1468164", VA="0x1468164")]
	public void SetIcons(IReadOnlyList<InventoryItem?> icons)
	{
	}

	[Address(RVA="0x1468370", Offset="0x1468370", VA="0x1468370", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1468454", Offset="0x1468454", VA="0x1468454", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect AvatarScrollRect;

		[Address(RVA="0x1468714", Offset="0x1468714", VA="0x1468714")]
		public SerializedFields()
		{
		}
	}
}