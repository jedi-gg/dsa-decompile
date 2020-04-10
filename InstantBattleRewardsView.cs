using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class InstantBattleRewardsView : APopupView, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1059478", Offset="0x1059478")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1059488", Offset="0x1059488")]
	[FieldOffset(Offset="0x70")]
	private ItemFindTracker _itemFindTracker;

	[Attribute(Name="InjectAttribute", RVA="0x1059498", Offset="0x1059498")]
	[FieldOffset(Offset="0x78")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0x80")]
	private List<InventoryItem> _rewards;

	private InstantBattleRewardsView.SerializedFields Fields
	{
		[Address(RVA="0x1369F40", Offset="0x1369F40", VA="0x1369F40")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x136B21C", Offset="0x136B21C", VA="0x136B21C")]
	public InstantBattleRewardsView()
	{
	}

	[Address(RVA="0x136B290", Offset="0x136B290", VA="0x136B290")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FF54", Offset="0x106FF54")]
	private void <ViewAssetLoaded>b__4_0()
	{
	}

	[Address(RVA="0x136B314", Offset="0x136B314", VA="0x136B314")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FF64", Offset="0x106FF64")]
	private void <ViewAssetLoaded>b__4_1()
	{
	}

	[Address(RVA="0x136AB3C", Offset="0x136AB3C", VA="0x136AB3C")]
	private void BindRewardListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x136A06C", Offset="0x136A06C", VA="0x136A06C", Slot="22")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x136A6FC", Offset="0x136A6FC", VA="0x136A6FC")]
	private void InitializeRewardListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x136A020", Offset="0x136A020", VA="0x136A020")]
	public void OverrideTitleText(string text)
	{
	}

	[Address(RVA="0x1369844", Offset="0x1369844", VA="0x1369844")]
	public void SetData(InventoryDelta inventoryDelta)
	{
	}

	[Address(RVA="0x1369764", Offset="0x1369764", VA="0x1369764")]
	public void ShowRebattleButtons(uint maxBattles)
	{
	}

	[Address(RVA="0x136A288", Offset="0x136A288", VA="0x136A288", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x136A5A4", Offset="0x136A5A4", VA="0x136A5A4", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106AB14", Offset="0x106AB14")]
		[FieldOffset(Offset="0x30")]
		public Button RebattleButton;

		[FieldOffset(Offset="0x38")]
		public LabelButton RebattleMultiButton;

		[FieldOffset(Offset="0x40")]
		public int RebattleMultiCount;

		[FieldOffset(Offset="0x48")]
		public WrappedScrollRect RewardsScrollRect;

		[FieldOffset(Offset="0x50")]
		public Button DoneButton;

		[FieldOffset(Offset="0x58")]
		public UiLabel TitleLabel;

		[Address(RVA="0x136B3AC", Offset="0x136B3AC", VA="0x136B3AC")]
		public SerializedFields()
		{
		}
	}
}