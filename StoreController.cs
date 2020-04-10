using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class StoreController : AFeatureController, IDispatchHandler<DStoreItemAction>, IDispatchHandler, IDispatchHandler<DRevSdkPurchaseResponseAction>, IDispatchHandler<DViewShownAction>, IDispatchHandler<DViewReleasedAction>, IDispatchHandler<DStoreTabViewedAction>, IDispatchHandler<DRevSdkPlacementShownAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105CC04", Offset="0x105CC04")]
	[FieldOffset(Offset="0x68")]
	private AssetRegistry _tabAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105CC14", Offset="0x105CC14")]
	[FieldOffset(Offset="0x70")]
	private StoreService _storeService;

	[Attribute(Name="InjectAttribute", RVA="0x105CC24", Offset="0x105CC24")]
	[FieldOffset(Offset="0x78")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x105CC34", Offset="0x105CC34")]
	[FieldOffset(Offset="0x80")]
	private RevSdkController _revSdkController;

	[Attribute(Name="InjectAttribute", RVA="0x105CC44", Offset="0x105CC44")]
	[FieldOffset(Offset="0x88")]
	private DialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x105CC54", Offset="0x105CC54")]
	[FieldOffset(Offset="0x90")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105CC64", Offset="0x105CC64")]
	[FieldOffset(Offset="0x98")]
	private ContextualMessageController _contextualMessageController;

	[Attribute(Name="InjectAttribute", RVA="0x105CC74", Offset="0x105CC74")]
	[FieldOffset(Offset="0xA0")]
	private HudController _hudController;

	[Attribute(Name="InjectAttribute", RVA="0x105CC84", Offset="0x105CC84")]
	[FieldOffset(Offset="0xA8")]
	private AccountPrefs _accountPrefs;

	[FieldOffset(Offset="0xB0")]
	private StoreView _view;

	[FieldOffset(Offset="0xB8")]
	private StoreGameState.Context _context;

	[FieldOffset(Offset="0xC0")]
	private StoreItemData _pendingIapStoreItemData;

	[FieldOffset(Offset="0xC8")]
	private StoreItemData _pendingVideoAdItemData;

	[FieldOffset(Offset="0xD0")]
	private ulong? _packOpeningReturnToItemId;

	[FieldOffset(Offset="0xE0")]
	private bool _isShowingDetailsView;

	[FieldOffset(Offset="0xE8")]
	private string _telemetryItemLocation;

	[Address(RVA="0x122C594", Offset="0x122C594", VA="0x122C594")]
	public StoreController()
	{
	}

	[Address(RVA="0x122C59C", Offset="0x122C59C", VA="0x122C59C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070A9C", Offset="0x1070A9C")]
	private void <RestockShelves>b__15_0()
	{
	}

	[Address(RVA="0x122AEC4", Offset="0x122AEC4", VA="0x122AEC4")]
	private void BuyFirstItemOnTab(ulong tabId)
	{
	}

	[Address(RVA="0x1228A40", Offset="0x1228A40", VA="0x1228A40")]
	private void BuyGift(DStoreItemAction action)
	{
	}

	[Address(RVA="0x12283A8", Offset="0x12283A8", VA="0x12283A8")]
	private void BuyItem(DStoreItemAction action)
	{
	}

	[Address(RVA="0x122A5AC", Offset="0x122A5AC", VA="0x122A5AC", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x1228E0C", Offset="0x1228E0C", VA="0x1228E0C")]
	private void HandleBuyResponseSuccess(StoreItemData itemData, BuyStoreItemResponse response)
	{
	}

	[Address(RVA="0x122810C", Offset="0x122810C", VA="0x122810C", Slot="13")]
	public void HandleDispatchAction(DStoreItemAction action)
	{
	}

	[Address(RVA="0x1228BDC", Offset="0x1228BDC", VA="0x1228BDC", Slot="14")]
	public void HandleDispatchAction(DRevSdkPurchaseResponseAction action)
	{
	}

	[Address(RVA="0x1229C94", Offset="0x1229C94", VA="0x1229C94", Slot="15")]
	public void HandleDispatchAction(DViewShownAction action)
	{
	}

	[Address(RVA="0x1229D20", Offset="0x1229D20", VA="0x1229D20", Slot="16")]
	public void HandleDispatchAction(DViewReleasedAction action)
	{
	}

	[Address(RVA="0x1229DBC", Offset="0x1229DBC", VA="0x1229DBC", Slot="17")]
	public void HandleDispatchAction(DStoreTabViewedAction action)
	{
	}

	[Address(RVA="0x122A2FC", Offset="0x122A2FC", VA="0x122A2FC", Slot="18")]
	public void HandleDispatchAction(DRevSdkPlacementShownAction action)
	{
	}

	[Address(RVA="0x12279D4", Offset="0x12279D4", VA="0x12279D4", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x122A7C4", Offset="0x122A7C4", VA="0x122A7C4", Slot="11")]
	protected override bool InternalHandleNewContext(GameStateTransitionContext context)
	{
		return new bool();
	}

	[Address(RVA="0x122A9A0", Offset="0x122A9A0", VA="0x122A9A0")]
	private void LoadStore(Action finished)
	{
	}

	[Address(RVA="0x122AC08", Offset="0x122AC08", VA="0x122AC08")]
	private void LoadStoreTabAssets(Action finished)
	{
	}

	[Address(RVA="0x122AB24", Offset="0x122AB24", VA="0x122AB24")]
	private void LoadStoreView(Action finished)
	{
	}

	[Address(RVA="0x122BAA0", Offset="0x122BAA0", VA="0x122BAA0")]
	private void NavigateToFirstStoreItemWithCostId(StoreGameState.NavigateToFirstStoreItemWithCostId navigateToCostContext)
	{
	}

	[Address(RVA="0x122B294", Offset="0x122B294", VA="0x122B294")]
	private void PurchaseItemViaContext(ulong itemId, string telemetryItemLocation, ulong costItemId)
	{
	}

	[Address(RVA="0x122807C", Offset="0x122807C", VA="0x122807C")]
	private void RestockShelves()
	{
	}

	[Address(RVA="0x1227C70", Offset="0x1227C70", VA="0x1227C70", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x1227D70", Offset="0x1227D70", VA="0x1227D70", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x1229DC0", Offset="0x1229DC0", VA="0x1229DC0")]
	private void UpdateHud(StoreTabData selectedTab)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CC7C", Offset="0x104CC7C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public StoreController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[FieldOffset(Offset="0x20")]
		public Action <>9__1;

		[Address(RVA="0x1227C58", Offset="0x1227C58", VA="0x1227C58")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x122C638", Offset="0x122C638", VA="0x122C638")]
		internal void <Initialize>b__0()
		{
		}

		[Address(RVA="0x122C6D8", Offset="0x122C6D8", VA="0x122C6D8")]
		internal void <Initialize>b__1()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CC9C", Offset="0x104CC9C")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset="0x10")]
		public StoreController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x122AB1C", Offset="0x122AB1C", VA="0x122AB1C")]
		public <>c__DisplayClass11_0()
		{
		}

		[Address(RVA="0x122CC4C", Offset="0x122CC4C", VA="0x122CC4C")]
		internal void <LoadStore>b__0(StoreResponse response)
		{
		}

		[Address(RVA="0x122CD40", Offset="0x122CD40", VA="0x122CD40")]
		internal void <LoadStore>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CCAC", Offset="0x104CCAC")]
	private sealed class <>c__DisplayClass12_0
	{
		[FieldOffset(Offset="0x10")]
		public StoreController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x122AC00", Offset="0x122AC00", VA="0x122AC00")]
		public <>c__DisplayClass12_0()
		{
		}

		[Address(RVA="0x122CDDC", Offset="0x122CDDC", VA="0x122CDDC")]
		internal void <LoadStoreView>b__0(StoreView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CCBC", Offset="0x104CCBC")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset="0x10")]
		public StoreTabData tab;

		[FieldOffset(Offset="0x18")]
		public StoreController <>4__this;

		[Address(RVA="0x122AEBC", Offset="0x122AEBC", VA="0x122AEBC")]
		public <>c__DisplayClass13_0()
		{
		}

		[Address(RVA="0x122CE34", Offset="0x122CE34", VA="0x122CE34")]
		internal void <LoadStoreTabAssets>b__0(Action assetLoadFinished)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CCCC", Offset="0x104CCCC")]
	private sealed class <>c__DisplayClass13_1
	{
		[FieldOffset(Offset="0x10")]
		public Action assetLoadFinished;

		[FieldOffset(Offset="0x18")]
		public StoreController.<>c__DisplayClass13_0 CS$<>8__locals1;

		[Address(RVA="0x122CF60", Offset="0x122CF60", VA="0x122CF60")]
		public <>c__DisplayClass13_1()
		{
		}

		[Address(RVA="0x122CF68", Offset="0x122CF68", VA="0x122CF68")]
		internal void <LoadStoreTabAssets>b__1(AssetHandle assetHandle)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CCDC", Offset="0x104CCDC")]
	private sealed class <>c__DisplayClass19_0
	{
		[FieldOffset(Offset="0x10")]
		public StoreController <>4__this;

		[FieldOffset(Offset="0x18")]
		public DStoreItemAction action;

		[Address(RVA="0x122BDF0", Offset="0x122BDF0", VA="0x122BDF0")]
		public <>c__DisplayClass19_0()
		{
		}

		[Address(RVA="0x122D018", Offset="0x122D018", VA="0x122D018")]
		internal void <BuyItem>b__0(BuyStoreItemResponse response)
		{
		}

		[Address(RVA="0x122D0BC", Offset="0x122D0BC", VA="0x122D0BC")]
		internal void <BuyItem>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CC8C", Offset="0x104CC8C")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset="0x10")]
		public StoreController <>4__this;

		[FieldOffset(Offset="0x18")]
		public StoreItemData itemData;

		[Address(RVA="0x122A5A4", Offset="0x122A5A4", VA="0x122A5A4")]
		public <>c__DisplayClass8_0()
		{
		}

		[Address(RVA="0x122D1E8", Offset="0x122D1E8", VA="0x122D1E8")]
		internal void <HandleDispatchAction>b__0(BuyStoreItemResponse response)
		{
		}

		[Address(RVA="0x122D28C", Offset="0x122D28C", VA="0x122D28C")]
		internal void <HandleDispatchAction>b__1(long failureCode)
		{
		}
	}
}