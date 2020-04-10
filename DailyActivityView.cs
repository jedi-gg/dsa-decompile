using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class DailyActivityView : APlayerActivityView, IDispatchHandler<DDailyEnergyGiftListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1057748", Offset="0x1057748")]
	[FieldOffset(Offset="0x88")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0x90")]
	private List<DailyEnergyGiftListItemData> _energyGiftItems;

	[FieldOffset(Offset="0x98")]
	private DailyEnergyGiftListItemData _selectedDailyEnergyGift;

	[FieldOffset(Offset="0xA0")]
	private int _numEnergyGiftsReadyToClaim;

	[FieldOffset(Offset="0xA8")]
	private UiTimerLabel _resetTimerLabel;

	[FieldOffset(Offset="0xB0")]
	private Texture _xpTexture;

	protected override BadgingSource BadgingSource
	{
		[Address(RVA="0x12AD68C", Offset="0x12AD68C", VA="0x12AD68C", Slot="28")]
		get
		{
			return new BadgingSource();
		}
	}

	private DailyActivityView.SerializedFields Fields
	{
		[Address(RVA="0x12AC740", Offset="0x12AC740", VA="0x12AC740")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12AD694", Offset="0x12AD694", VA="0x12AD694")]
	public DailyActivityView()
	{
	}

	[Address(RVA="0x12AD69C", Offset="0x12AD69C", VA="0x12AD69C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F3C4", Offset="0x106F3C4")]
	private void <ViewAssetLoaded>b__8_0(AssetHandle handle)
	{
	}

	[Address(RVA="0x12AD2EC", Offset="0x12AD2EC", VA="0x12AD2EC", Slot="25")]
	protected override void BindActivityListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x12AD498", Offset="0x12AD498", VA="0x12AD498", Slot="26")]
	protected override void BindRewardListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x12ACA64", Offset="0x12ACA64", VA="0x12ACA64", Slot="23")]
	public override void CelebrateClaimActivity(InventoryDelta delta)
	{
	}

	[Address(RVA="0x12ABD7C", Offset="0x12ABD7C", VA="0x12ABD7C")]
	public void CelebrateCompleteAllClaimActivity(InventoryDelta delta)
	{
	}

	[Address(RVA="0x12AB39C", Offset="0x12AB39C", VA="0x12AB39C")]
	public void CelebrateEnergyClaim(InventoryDelta delta)
	{
	}

	[Address(RVA="0x12AD5E8", Offset="0x12AD5E8", VA="0x12AD5E8", Slot="27")]
	protected override void ClaimClicked()
	{
	}

	[Address(RVA="0x12ACE90", Offset="0x12ACE90", VA="0x12ACE90", Slot="29")]
	public void HandleDispatchAction(DDailyEnergyGiftListItemAction action)
	{
	}

	[Address(RVA="0x12AC820", Offset="0x12AC820", VA="0x12AC820")]
	private void SelectDailyEnergyGift(DailyEnergyGiftListItemData energyData)
	{
	}

	[Address(RVA="0x12AD2E0", Offset="0x12AD2E0", VA="0x12AD2E0", Slot="24")]
	protected override void SelectPlayerActivity(PlayerActivity activity)
	{
	}

	[Address(RVA="0x12AACD8", Offset="0x12AACD8", VA="0x12AACD8")]
	public void SetData(IEnumerable<PlayerActivity> activities, List<DailyEnergyGiftListItemData> energyGiftItems)
	{
	}

	[Address(RVA="0x12AAA58", Offset="0x12AAA58", VA="0x12AAA58")]
	public bool ShouldHandleSpellListItemAction(DSpellListItemAction action)
	{
		return new bool();
	}

	[Address(RVA="0x12AA8CC", Offset="0x12AA8CC", VA="0x12AA8CC")]
	public bool ShouldHandleUnitListItemAction(DUnitListItemAction action)
	{
		return new bool();
	}

	[Address(RVA="0x12A9DA8", Offset="0x12A9DA8", VA="0x12A9DA8")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x12ACE94", Offset="0x12ACE94", VA="0x12ACE94", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x12AD250", Offset="0x12AD250", VA="0x12AD250", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : APlayerActivityView.PlayerActivitySerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106A354", Offset="0x106A354")]
		[FieldOffset(Offset="0x60")]
		public UiLabel ResetTimerLabel;

		[FieldOffset(Offset="0x68")]
		public PlayerXpContainer PlayerXpContainer;

		[FieldOffset(Offset="0x70")]
		public PlayerActivityBanner CompleteAllActivityBanner;

		[Address(RVA="0x12AD714", Offset="0x12AD714", VA="0x12AD714")]
		public SerializedFields()
		{
		}
	}
}