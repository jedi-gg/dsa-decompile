using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class APlayerActivityView : AStandardView, IDispatchHandler<DDailyActivityListItemAction>, IDispatchHandler, IDispatchHandler<DInventoryItemListItemAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105B5E4", Offset="0x105B5E4")]
	[FieldOffset(Offset="0x68")]
	protected GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x70")]
	protected List<PlayerActivity> _activities;

	[FieldOffset(Offset="0x78")]
	protected PlayerActivity _selectedPlayerActivity;

	[FieldOffset(Offset="0x80")]
	protected IList<InventoryItem> _activityRewardItems;

	protected virtual BadgingSource BadgingSource
	{
		[Address(RVA="0x10EF59C", Offset="0x10EF59C", VA="0x10EF59C", Slot="28")]
		get
		{
			return new BadgingSource();
		}
	}

	private APlayerActivityView.PlayerActivitySerializedFields Fields
	{
		[Address(RVA="0x10ED59C", Offset="0x10ED59C", VA="0x10ED59C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x10EF5A4", Offset="0x10EF5A4", VA="0x10EF5A4")]
	protected APlayerActivityView()
	{
	}

	[Address(RVA="0x10EEEF0", Offset="0x10EEEF0", VA="0x10EEEF0", Slot="25")]
	protected virtual void BindActivityListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x10EF0F8", Offset="0x10EF0F8", VA="0x10EF0F8", Slot="26")]
	protected virtual void BindRewardListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x10ED834", Offset="0x10ED834", VA="0x10ED834", Slot="23")]
	public virtual void CelebrateClaimActivity(InventoryDelta delta)
	{
	}

	[Address(RVA="0x10EF2F0", Offset="0x10EF2F0", VA="0x10EF2F0", Slot="27")]
	protected virtual void ClaimClicked()
	{
	}

	[Address(RVA="0x10EF4C4", Offset="0x10EF4C4", VA="0x10EF4C4")]
	private void DeepLinkClicked()
	{
	}

	[Address(RVA="0x10EDC00", Offset="0x10EDC00", VA="0x10EDC00", Slot="21")]
	public void HandleDispatchAction(DDailyActivityListItemAction action)
	{
	}

	[Address(RVA="0x10EDC10", Offset="0x10EDC10", VA="0x10EDC10", Slot="22")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x10EEDF4", Offset="0x10EEDF4", VA="0x10EEDF4")]
	private void InitializeActivityListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x10EEFFC", Offset="0x10EEFFC", VA="0x10EEFFC")]
	private void InitializeRewardListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x10ED67C", Offset="0x10ED67C", VA="0x10ED67C")]
	public void SelectFirstActivityWithReward(ulong rewardItemId)
	{
	}

	[Address(RVA="0x10ED44C", Offset="0x10ED44C", VA="0x10ED44C")]
	public void SelectPlayerActivity(ulong playerActivityId)
	{
	}

	[Address(RVA="0x10EE384", Offset="0x10EE384", VA="0x10EE384", Slot="24")]
	protected virtual void SelectPlayerActivity(PlayerActivity activity)
	{
	}

	[Address(RVA="0x10EECC4", Offset="0x10EECC4", VA="0x10EECC4")]
	protected void SetActivityListEmpty()
	{
	}

	[Address(RVA="0x10EDDD4", Offset="0x10EDDD4", VA="0x10EDDD4")]
	protected static int SortActivities(PlayerActivity a, PlayerActivity b)
	{
		return new int();
	}

	[Address(RVA="0x10EDFB8", Offset="0x10EDFB8", VA="0x10EDFB8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x10EE244", Offset="0x10EE244", VA="0x10EE244", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class PlayerActivitySerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106B434", Offset="0x106B434")]
		[FieldOffset(Offset="0x28")]
		public WrappedScrollRect ActivityScrollRect;

		[FieldOffset(Offset="0x30")]
		public UiLabel AllActivitesCompleteLabel;

		[FieldOffset(Offset="0x38")]
		public Button ClaimButton;

		[FieldOffset(Offset="0x40")]
		public Button GoButton;

		[FieldOffset(Offset="0x48")]
		public WrappedScrollRect RewardsScrollRect;

		[FieldOffset(Offset="0x50")]
		public UiLabel RewardsLabel;

		[FieldOffset(Offset="0x58")]
		public ParticleSystem ClaimVfx;

		[Address(RVA="0x10EF5AC", Offset="0x10EF5AC", VA="0x10EF5AC")]
		public PlayerActivitySerializedFields()
		{
		}
	}
}