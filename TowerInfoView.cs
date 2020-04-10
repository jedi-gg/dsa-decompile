using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class TowerInfoView : APopupView, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105D950", Offset="0x105D950")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x70")]
	private Sequence _showSequence;

	[FieldOffset(Offset="0x78")]
	private IList<ItemCountRange> _rewardItems;

	private TowerInfoView.SerializedFields Fields
	{
		[Address(RVA="0x1436088", Offset="0x1436088", VA="0x1436088")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14369E4", Offset="0x14369E4", VA="0x14369E4")]
	public TowerInfoView()
	{
	}

	[Address(RVA="0x14367FC", Offset="0x14367FC", VA="0x14367FC")]
	private void BindRewardListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x1436168", Offset="0x1436168", VA="0x1436168", Slot="22")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x1436700", Offset="0x1436700", VA="0x1436700")]
	private void InitializeRewardListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x1435EC4", Offset="0x1435EC4", VA="0x1435EC4")]
	public void SetData(TowerMap towerMap)
	{
	}

	[Address(RVA="0x143632C", Offset="0x143632C", VA="0x143632C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x14366BC", Offset="0x14366BC", VA="0x14366BC", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x1436624", Offset="0x1436624", VA="0x1436624", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106C044", Offset="0x106C044")]
		[FieldOffset(Offset="0x30")]
		public UiLabel TowerNameLabel;

		[FieldOffset(Offset="0x38")]
		public WrappedScrollRect RewardsScrollRect;

		[FieldOffset(Offset="0x40")]
		public CanvasGroup WindowRoot;

		[Address(RVA="0x14369EC", Offset="0x14369EC", VA="0x14369EC")]
		public SerializedFields()
		{
		}
	}
}