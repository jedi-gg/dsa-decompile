using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BonusLootDetailsPopupView : APopupView
{
	[FieldOffset(Offset="0x68")]
	private IList<BonusLootDetailsItemData> _bonusLootDetails;

	private BonusLootDetailsPopupView.SerializedFields Fields
	{
		[Address(RVA="0x111FD4C", Offset="0x111FD4C", VA="0x111FD4C")]
		get
		{
			return null;
		}
	}

	public RectTransform ListBounds
	{
		[Address(RVA="0x111FCC0", Offset="0x111FCC0", VA="0x111FCC0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11201B4", Offset="0x11201B4", VA="0x11201B4")]
	public BonusLootDetailsPopupView()
	{
	}

	[Address(RVA="0x1120064", Offset="0x1120064", VA="0x1120064")]
	private void BindBonusLootDetailsListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x111FF6C", Offset="0x111FF6C", VA="0x111FF6C")]
	private void InitializeBonusLootDetailsListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x111F750", Offset="0x111F750", VA="0x111F750")]
	public void SetData(IList<BonusLootData> bonusLootDetails)
	{
	}

	[Address(RVA="0x111FE2C", Offset="0x111FE2C", VA="0x111FE2C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x111FF10", Offset="0x111FF10", VA="0x111FF10", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect BonusLootRect;

		[Address(RVA="0x1120224", Offset="0x1120224", VA="0x1120224")]
		public SerializedFields()
		{
		}
	}
}