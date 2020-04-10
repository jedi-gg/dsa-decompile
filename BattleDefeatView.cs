using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleDefeatView : AStandardView, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler, IDispatchHandler<DInventoryDeltaProcessedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1054AF4", Offset="0x1054AF4")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1054B04", Offset="0x1054B04")]
	[FieldOffset(Offset="0x70")]
	private ItemFindTracker _itemFindTracker;

	[Attribute(Name="InjectAttribute", RVA="0x1054B14", Offset="0x1054B14")]
	[FieldOffset(Offset="0x78")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1054B24", Offset="0x1054B24")]
	[FieldOffset(Offset="0x80")]
	private BadgingController _badgingController;

	[Attribute(Name="InjectAttribute", RVA="0x1054B34", Offset="0x1054B34")]
	[FieldOffset(Offset="0x88")]
	private CostController _costController;

	[FieldOffset(Offset="0x90")]
	private IReadOnlyList<Serverproto.InventoryItem> _rewards;

	[FieldOffset(Offset="0x98")]
	private Gamedata.BattleNode? _currentCampaignNode;

	private BattleDefeatView.SerializedFields Fields
	{
		[Address(RVA="0x113FA5C", Offset="0x113FA5C", VA="0x113FA5C")]
		get
		{
			return null;
		}
	}

	protected override bool WillHandleBackButton
	{
		[Address(RVA="0x1140984", Offset="0x1140984", VA="0x1140984", Slot="19")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x114098C", Offset="0x114098C", VA="0x114098C")]
	public BattleDefeatView()
	{
	}

	[Address(RVA="0x1140994", Offset="0x1140994", VA="0x1140994")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E818", Offset="0x106E818")]
	private void <ViewAssetLoaded>b__5_0()
	{
	}

	[Address(RVA="0x1140A18", Offset="0x1140A18", VA="0x1140A18")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E828", Offset="0x106E828")]
	private void <ViewAssetLoaded>b__5_1()
	{
	}

	[Address(RVA="0x1140A9C", Offset="0x1140A9C", VA="0x1140A9C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E838", Offset="0x106E838")]
	private void <ViewAssetLoaded>b__5_2()
	{
	}

	[Address(RVA="0x11405FC", Offset="0x11405FC", VA="0x11405FC")]
	private void BindRewardListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x113FFA0", Offset="0x113FFA0", VA="0x113FFA0", Slot="21")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x1140154", Offset="0x1140154", VA="0x1140154", Slot="22")]
	public void HandleDispatchAction(DInventoryDeltaProcessedAction action)
	{
	}

	[Address(RVA="0x1140500", Offset="0x1140500", VA="0x1140500")]
	private void InitializeRewardListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x113FED8", Offset="0x113FED8", VA="0x113FED8")]
	public void SetCampaignLimitedAttemptInfo(uint currentNodeAttemptsLimit)
	{
	}

	[Address(RVA="0x113FB3C", Offset="0x113FB3C", VA="0x113FB3C")]
	public void SetCampaignProgressionData(Gamedata.BattleNode? currentCampaignNode)
	{
	}

	[Address(RVA="0x113F818", Offset="0x113F818", VA="0x113F818")]
	public void SetData(BattleResultsGameState.TransitionContext context)
	{
	}

	[Address(RVA="0x113FDBC", Offset="0x113FDBC", VA="0x113FDBC")]
	private void UpdateBattleEntryCostButton()
	{
	}

	[Address(RVA="0x1140158", Offset="0x1140158", VA="0x1140158", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1140378", Offset="0x1140378", VA="0x1140378", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x1069C64", Offset="0x1069C64")]
		[FieldOffset(Offset="0x28")]
		public WrappedScrollRect RewardsScrollRect;

		[FieldOffset(Offset="0x30")]
		public Button ContinueButton;

		[FieldOffset(Offset="0x38")]
		public Button InventoryButton;

		[FieldOffset(Offset="0x40")]
		public Badge InventoryBadge;

		[FieldOffset(Offset="0x48")]
		public CostButton ReplayBattleButton;

		[FieldOffset(Offset="0x50")]
		public UnityEngine.GameObject ReplayLimitedAttemptsContainer;

		[FieldOffset(Offset="0x58")]
		public UiLabel ReplayLimitedAttemptsLabel;

		[FieldOffset(Offset="0x60")]
		public UiLabel EndReasonLabel;

		[Address(RVA="0x1140B20", Offset="0x1140B20", VA="0x1140B20")]
		public SerializedFields()
		{
		}
	}
}