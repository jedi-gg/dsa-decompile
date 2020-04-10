using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubDungeonRewardGroupListItem : WrappedScrollRectListItem, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private WrappedScrollRect _rewardsScrollRect;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UiLabel _nameLabel;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private GameObject _highlightedBackground;

	[FieldOffset(Offset="0x40")]
	private WidgetDependencyContainer _dependencies;

	[FieldOffset(Offset="0x48")]
	private DClubDungeonRewardGroup _rewardGroup;

	[Address(RVA="0x11B3B54", Offset="0x11B3B54", VA="0x11B3B54")]
	public ClubDungeonRewardGroupListItem()
	{
	}

	[Address(RVA="0x11B3A0C", Offset="0x11B3A0C", VA="0x11B3A0C")]
	private void BindRewardListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x11B3770", Offset="0x11B3770", VA="0x11B3770", Slot="7")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x11B3514", Offset="0x11B3514", VA="0x11B3514")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11B3930", Offset="0x11B3930", VA="0x11B3930")]
	private void InitializeRewardListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11B3680", Offset="0x11B3680", VA="0x11B3680")]
	public void SetData(DClubDungeonRewardGroup rewardGroup)
	{
	}

	[Address(RVA="0x11B3610", Offset="0x11B3610", VA="0x11B3610", Slot="4")]
	public override void Shutdown()
	{
	}
}