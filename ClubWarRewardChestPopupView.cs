using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ClubWarRewardChestPopupView : APopupView, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1057398", Offset="0x1057398")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x10573A8", Offset="0x10573A8")]
	[FieldOffset(Offset="0x70")]
	private SingleAssetRegistry _chestRegistry;

	[FieldOffset(Offset="0x78")]
	private IList<InventoryItem> _rewards;

	[FieldOffset(Offset="0x80")]
	private Sequence _showSequence;

	private ClubWarRewardChestPopupView.SerializedFields Fields
	{
		[Address(RVA="0x14D7EA0", Offset="0x14D7EA0", VA="0x14D7EA0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14D8638", Offset="0x14D8638", VA="0x14D8638")]
	public ClubWarRewardChestPopupView()
	{
	}

	[Address(RVA="0x14D8640", Offset="0x14D8640", VA="0x14D8640")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F2B4", Offset="0x106F2B4")]
	private void <SetData>b__0_0(AssetHandle assetHandle)
	{
	}

	[Address(RVA="0x14D8454", Offset="0x14D8454", VA="0x14D8454")]
	private void BindRewardListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x14D7F80", Offset="0x14D7F80", VA="0x14D7F80", Slot="22")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x14D8358", Offset="0x14D8358", VA="0x14D8358")]
	private void InitializeRewardListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x14D7BF4", Offset="0x14D7BF4", VA="0x14D7BF4")]
	public void SetData(ClubWarReward chest)
	{
	}

	[Address(RVA="0x14D8144", Offset="0x14D8144", VA="0x14D8144", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x14D8314", Offset="0x14D8314", VA="0x14D8314", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x14D826C", Offset="0x14D826C", VA="0x14D826C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public UnityEngine.GameObject ChestRoot;

		[FieldOffset(Offset="0x38")]
		public UiLabel PlayerName;

		[FieldOffset(Offset="0x40")]
		public UiLabel ChestName;

		[FieldOffset(Offset="0x48")]
		public WrappedScrollRect RewardsScrollRect;

		[FieldOffset(Offset="0x50")]
		public CanvasGroup WindowRoot;

		[Address(RVA="0x14D8764", Offset="0x14D8764", VA="0x14D8764")]
		public SerializedFields()
		{
		}
	}
}