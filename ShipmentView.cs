using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipmentView : AStandardView, IDispatchHandler<DUiTabGroupAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105C480", Offset="0x105C480")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDomainController;

	[Attribute(Name="InjectAttribute", RVA="0x105C490", Offset="0x105C490")]
	[FieldOffset(Offset="0x70")]
	private CostController _costController;

	[Attribute(Name="InjectAttribute", RVA="0x105C4A0", Offset="0x105C4A0")]
	[FieldOffset(Offset="0x78")]
	private SingleAssetRegistry _refreshCostRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105C4B0", Offset="0x105C4B0")]
	[FieldOffset(Offset="0x80")]
	private SingleAssetRegistry _buyAllCostRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105C4C0", Offset="0x105C4C0")]
	[FieldOffset(Offset="0x88")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x105C4D0", Offset="0x105C4D0")]
	[FieldOffset(Offset="0x90")]
	private FeatureLockController _featureLockController;

	[FieldOffset(Offset="0x98")]
	private List<Shipment> _shipments;

	[FieldOffset(Offset="0xA0")]
	private UiTimerLabel _resetTimerLabel;

	[FieldOffset(Offset="0xA8")]
	private UiTimerLabel _resetTimerNoRefreshLabel;

	[FieldOffset(Offset="0xB0")]
	private UiTimerLabel _limitedTimeLabel;

	[FieldOffset(Offset="0xB8")]
	private Tweener _pingItemTween;

	[FieldOffset(Offset="0xC0")]
	private ulong _lastActiveShipmentDefId;

	[FieldOffset(Offset="0xC8")]
	private MonoArchetypePool<ShipmentBuyAllCostWidget> _buyAllCostWidgetPool;

	private ShipmentView.SerializedFields Fields
	{
		[Address(RVA="0x14C1428", Offset="0x14C1428", VA="0x14C1428")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14C3540", Offset="0x14C3540", VA="0x14C3540")]
	public ShipmentView()
	{
	}

	[Address(RVA="0x14C3548", Offset="0x14C3548", VA="0x14C3548")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10708A4", Offset="0x10708A4")]
	private void <PingItem>g__TweenCompleted|5_0()
	{
	}

	[Address(RVA="0x14C2DCC", Offset="0x14C2DCC", VA="0x14C2DCC")]
	private void BindItemsListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x14C3030", Offset="0x14C3030", VA="0x14C3030")]
	private void BuyAllButtonClicked()
	{
	}

	[Address(RVA="0x14C340C", Offset="0x14C340C", VA="0x14C340C")]
	private void BuyAllConfirmClicked()
	{
	}

	[Address(RVA="0x14C2F2C", Offset="0x14C2F2C", VA="0x14C2F2C")]
	private void BuyRefreshClicked()
	{
	}

	[Address(RVA="0x14BF7AC", Offset="0x14BF7AC", VA="0x14BF7AC")]
	public void CelebratePurchasedItem(string shipmentItemId)
	{
	}

	[Address(RVA="0x14C34AC", Offset="0x14C34AC", VA="0x14C34AC")]
	private void CloseBuyAll()
	{
	}

	[Address(RVA="0x14C1C34", Offset="0x14C1C34", VA="0x14C1C34")]
	private Shipment GetActiveShipment()
	{
		return null;
	}

	[Address(RVA="0x14C2EE4", Offset="0x14C2EE4", VA="0x14C2EE4")]
	private int GetActiveShipmentIndex()
	{
		return new int();
	}

	[Address(RVA="0x14BD570", Offset="0x14BD570", VA="0x14BD570")]
	public ulong GetSelectedShipmentDefId()
	{
		return new ulong();
	}

	[Address(RVA="0x14BC6D0", Offset="0x14BC6D0", VA="0x14BC6D0")]
	public void GoToShipmentItem(string shipmentId)
	{
	}

	[Address(RVA="0x14C1CF0", Offset="0x14C1CF0", VA="0x14C1CF0", Slot="21")]
	public void HandleDispatchAction(DUiTabGroupAction action)
	{
	}

	[Address(RVA="0x14C2CF0", Offset="0x14C2CF0", VA="0x14C2CF0")]
	private void InitializeItemsListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x14C0F2C", Offset="0x14C0F2C", VA="0x14C0F2C")]
	private void InitializeTabs(List<Shipment> shipments, ulong initialShipmentId)
	{
	}

	[Address(RVA="0x14BC1BC", Offset="0x14BC1BC", VA="0x14BC1BC")]
	public void PingItem(ulong itemId)
	{
	}

	[Address(RVA="0x14BE210", Offset="0x14BE210", VA="0x14BE210")]
	public void ReplaceShipment(Shipment shipment)
	{
	}

	[Address(RVA="0x14BDA5C", Offset="0x14BDA5C", VA="0x14BDA5C")]
	public void SelectShipment(ulong shipmentDefId)
	{
	}

	[Address(RVA="0x14C25FC", Offset="0x14C25FC", VA="0x14C25FC")]
	private void SetBuyAllCost(Shipment shipment)
	{
	}

	[Address(RVA="0x14C2BE8", Offset="0x14C2BE8", VA="0x14C2BE8")]
	private void SetBuyAllUpsell()
	{
	}

	[Address(RVA="0x14BF130", Offset="0x14BF130", VA="0x14BF130")]
	public void SetData(List<Shipment> shipments, ulong initialShipmentId)
	{
	}

	[Address(RVA="0x14C2FC4", Offset="0x14C2FC4", VA="0x14C2FC4")]
	private static int SortShipmentsBySortOrder(Shipment a, Shipment b)
	{
		return new int();
	}

	[Address(RVA="0x14C1508", Offset="0x14C1508", VA="0x14C1508")]
	private void SwitchToActiveShipment()
	{
	}

	[Address(RVA="0x14BB958", Offset="0x14BB958", VA="0x14BB958")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x14C1DB0", Offset="0x14C1DB0", VA="0x14C1DB0", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x14C2364", Offset="0x14C2364", VA="0x14C2364", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public UiLabel TitleLabel;

		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect ItemsScrollRect;

		[FieldOffset(Offset="0x38")]
		public UiTabGroup TabGroup;

		[FieldOffset(Offset="0x40")]
		public UiLabel ResetTimerLabel;

		[FieldOffset(Offset="0x48")]
		public UiLabel ResetTimerNoRefreshLabel;

		[FieldOffset(Offset="0x50")]
		public CostButton PurchaseRefreshButton;

		[FieldOffset(Offset="0x58")]
		public CostButton BuyAllButton;

		[FieldOffset(Offset="0x60")]
		public ClubSupportRequestButton ClubSupportRequestButton;

		[FieldOffset(Offset="0x68")]
		public UnityEngine.GameObject[] LockIcons;

		[FieldOffset(Offset="0x70")]
		public ParticleSystem PurchaseVfx;

		[FieldOffset(Offset="0x78")]
		public UnityEngine.GameObject LimitedTimeContainer;

		[FieldOffset(Offset="0x80")]
		public UiLabel LimitedTimeLabel;

		[FieldOffset(Offset="0x88")]
		public UnityEngine.GameObject VipImage;

		[FieldOffset(Offset="0x90")]
		public UnityEngine.GameObject Footer;

		[FieldOffset(Offset="0x98")]
		public UnityEngine.GameObject FooterNoRefresh;

		[Attribute(Name="HeaderAttribute", RVA="0x106B994", Offset="0x106B994")]
		[FieldOffset(Offset="0xA0")]
		public Graphic ShipmentPingItem;

		[FieldOffset(Offset="0xA8")]
		public float PingScale;

		[FieldOffset(Offset="0xAC")]
		public int PingLoops;

		[FieldOffset(Offset="0xB0")]
		public float PingDuration;

		[FieldOffset(Offset="0xB4")]
		public float PingDelay;

		[Attribute(Name="HeaderAttribute", RVA="0x106B9CC", Offset="0x106B9CC")]
		[FieldOffset(Offset="0xB8")]
		public UnityEngine.GameObject BuyAllConfirmRoot;

		[FieldOffset(Offset="0xC0")]
		public ShipmentBuyAllCostWidget BuyAllCostItemArchetype;

		[FieldOffset(Offset="0xC8")]
		public Button BuyAllScrimButton;

		[FieldOffset(Offset="0xD0")]
		public Button BuyAllCancelButton;

		[FieldOffset(Offset="0xD8")]
		public Button BuyAllConfirmButton;

		[Address(RVA="0x14C36B0", Offset="0x14C36B0", VA="0x14C36B0")]
		public SerializedFields()
		{
		}
	}
}