using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleUnitDetailPopupView : APopupView
{
	[FieldOffset(Offset="0x68")]
	private Sequence _popInSequence;

	[FieldOffset(Offset="0x70")]
	private HashSet<uint> _uniqueIcons;

	private BattleUnitDetailPopupView.SerializedFields Fields
	{
		[Address(RVA="0x129E574", Offset="0x129E574", VA="0x129E574")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x129E728", Offset="0x129E728", VA="0x129E728")]
	public BattleUnitDetailPopupView()
	{
	}

	[Address(RVA="0x129DBCC", Offset="0x129DBCC", VA="0x129DBCC")]
	public void ShowForUnit(BattleUnit unit, BattleUnitDetailPopupController.AnchorPos anchorPos)
	{
	}

	[Address(RVA="0x129E654", Offset="0x129E654", VA="0x129E654", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x129E6E4", Offset="0x129E6E4", VA="0x129E6E4", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public RectTransform RightSidePlacement;

		[FieldOffset(Offset="0x38")]
		public RectTransform LeftSidePlacement;

		[FieldOffset(Offset="0x40")]
		public RectTransform WindowRoot;

		[FieldOffset(Offset="0x48")]
		public CanvasGroup TweenRoot;

		[FieldOffset(Offset="0x50")]
		public UiLabel UnitNameLabel;

		[FieldOffset(Offset="0x58")]
		public BattleBuffIconUiData BuffIconData;

		[FieldOffset(Offset="0x60")]
		public BattleUnitDetailPopupEffectListItem EffectListItem;

		[Address(RVA="0x129E798", Offset="0x129E798", VA="0x129E798")]
		public SerializedFields()
		{
		}
	}
}