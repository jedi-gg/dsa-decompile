using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class ShipmentController : AFeatureController, IDispatchHandler<DShipmentViewAction>, IDispatchHandler, IDispatchHandler<DShipmentItemAction>, IDispatchHandler<DInventoryItemBuyAction>, IDispatchHandler<DPurchaseShipmentStorePack>, IDispatchHandler<DClubSupportRequestButtonAction>
{
	[FieldOffset(Offset="0x0")]
	private const ulong SHIPMENT_RESET_DELAY_S = 3L;

	[Attribute(Name="InjectAttribute", RVA="0x105C310", Offset="0x105C310")]
	[FieldOffset(Offset="0x68")]
	private StoreService _storeService;

	[Attribute(Name="InjectAttribute", RVA="0x105C320", Offset="0x105C320")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDomainController;

	[Attribute(Name="InjectAttribute", RVA="0x105C330", Offset="0x105C330")]
	[FieldOffset(Offset="0x78")]
	private GamedataDomainController _gamedataDomainController;

	[Attribute(Name="InjectAttribute", RVA="0x105C340", Offset="0x105C340")]
	[FieldOffset(Offset="0x80")]
	private DialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x105C350", Offset="0x105C350")]
	[FieldOffset(Offset="0x88")]
	private LocalizationManager _locManager;

	[Attribute(Name="InjectAttribute", RVA="0x105C360", Offset="0x105C360")]
	[FieldOffset(Offset="0x90")]
	private HudController _hudController;

	[Attribute(Name="InjectAttribute", RVA="0x105C370", Offset="0x105C370")]
	[FieldOffset(Offset="0x98")]
	private ClubServiceUtility _clubServiceUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105C380", Offset="0x105C380")]
	[FieldOffset(Offset="0xA0")]
	private ClubUtil _clubUtil;

	[FieldOffset(Offset="0xA8")]
	private ShipmentView _shipmentView;

	[FieldOffset(Offset="0xB0")]
	private List<Shipment> _shipments;

	[FieldOffset(Offset="0xB8")]
	private bool _isExpired;

	[FieldOffset(Offset="0xC0")]
	private ShipmentGameState.Context _context;

	[Address(RVA="0x14BEDEC", Offset="0x14BEDEC", VA="0x14BEDEC")]
	public ShipmentController()
	{
	}

	[Address(RVA="0x14BEBFC", Offset="0x14BEBFC", VA="0x14BEBFC")]
	private void BuyAllShipmentItems(ulong shipmentDefId)
	{
	}

	[Address(RVA="0x14BD904", Offset="0x14BD904", VA="0x14BD904", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x14BB7E4", Offset="0x14BB7E4", VA="0x14BB7E4")]
	private void ExpireShipments()
	{
	}

	[Address(RVA="0x14BBAD8", Offset="0x14BBAD8", VA="0x14BBAD8", Slot="13")]
	public void HandleDispatchAction(DShipmentViewAction action)
	{
	}

	[Address(RVA="0x14BCC3C", Offset="0x14BCC3C", VA="0x14BCC3C", Slot="14")]
	public void HandleDispatchAction(DShipmentItemAction action)
	{
	}

	[Address(RVA="0x14BD0D4", Offset="0x14BD0D4", VA="0x14BD0D4", Slot="15")]
	public void HandleDispatchAction(DInventoryItemBuyAction action)
	{
	}

	[Address(RVA="0x14BD390", Offset="0x14BD390", VA="0x14BD390", Slot="16")]
	public void HandleDispatchAction(DPurchaseShipmentStorePack action)
	{
	}

	[Address(RVA="0x14BD398", Offset="0x14BD398", VA="0x14BD398", Slot="17")]
	public void HandleDispatchAction(DClubSupportRequestButtonAction action)
	{
	}

	[Address(RVA="0x14BB288", Offset="0x14BB288", VA="0x14BB288", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x14BD9A4", Offset="0x14BD9A4", VA="0x14BD9A4", Slot="11")]
	protected override bool InternalHandleNewContext(GameStateTransitionContext context)
	{
		return new bool();
	}

	[Address(RVA="0x14BDB88", Offset="0x14BDB88", VA="0x14BDB88")]
	private void LoadView(Action finished)
	{
	}

	[Address(RVA="0x14BCA0C", Offset="0x14BCA0C", VA="0x14BCA0C")]
	private void PurchaseBuyAll(Shipment shipment)
	{
	}

	[Address(RVA="0x14BC848", Offset="0x14BC848", VA="0x14BC848")]
	private void PurchaseRefresh(Shipment shipment)
	{
	}

	[Address(RVA="0x14BD168", Offset="0x14BD168", VA="0x14BD168")]
	private void PurchaseShipmentItem(string shipmentItemId, bool usePackOpening)
	{
	}

	[Address(RVA="0x14BD6D8", Offset="0x14BD6D8", VA="0x14BD6D8")]
	private void RefreshShipment(ulong shipmentDefId, bool useFreeClubSupport, Action success = // 
	// Current member / type: System.Void ShipmentController::RefreshShipment(System.UInt64,System.Boolean,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void RefreshShipment(System.UInt64,System.Boolean,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x14BE834", Offset="0x14BE834", VA="0x14BE834")]
	private void ReloadAllShipments()
	{
	}

	[Address(RVA="0x14BDC6C", Offset="0x14BDC6C", VA="0x14BDC6C")]
	private void RequestShipments(Action finished)
	{
	}

	[Address(RVA="0x14BE888", Offset="0x14BE888", VA="0x14BE888")]
	private void SendBuyShipmentItemTelemetry(BuyShipmentItemRequest request, BuyShipmentItemResponse response)
	{
	}

	[Address(RVA="0x14BCC50", Offset="0x14BCC50", VA="0x14BCC50")]
	private void ShowItemBuyPopup(ShipmentItem shipmentItem)
	{
	}

	[Address(RVA="0x14BB528", Offset="0x14BB528", VA="0x14BB528", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x14BB5B4", Offset="0x14BB5B4", VA="0x14BB5B4", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x14BBBC8", Offset="0x14BBBC8", VA="0x14BBBC8")]
	private void UpdateHud(Shipment shipment)
	{
	}

	[Address(RVA="0x14BE404", Offset="0x14BE404", VA="0x14BE404")]
	private void UpdatePurchasedAllItems(ulong shipmentDefId)
	{
	}

	[Address(RVA="0x14BDDF8", Offset="0x14BDDF8", VA="0x14BDDF8")]
	private void UpdatePurchasedItem(string purchasedItemId)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C94C", Offset="0x104C94C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ShipmentController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x14BB520", Offset="0x14BB520", VA="0x14BB520")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x14BEDF4", Offset="0x14BEDF4", VA="0x14BEDF4")]
		internal void <Initialize>b__0(Action finished)
		{
		}

		[Address(RVA="0x14BEE40", Offset="0x14BEE40", VA="0x14BEE40")]
		internal void <Initialize>b__1()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C96C", Offset="0x104C96C")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset="0x10")]
		public ShipmentController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x14BDC64", Offset="0x14BDC64", VA="0x14BDC64")]
		public <>c__DisplayClass10_0()
		{
		}

		[Address(RVA="0x14BF21C", Offset="0x14BF21C", VA="0x14BF21C")]
		internal void <LoadView>b__0(ShipmentView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C97C", Offset="0x104C97C")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset="0x10")]
		public ShipmentController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x14BDDE8", Offset="0x14BDDE8", VA="0x14BDDE8")]
		public <>c__DisplayClass11_0()
		{
		}

		[Address(RVA="0x14BF274", Offset="0x14BF274", VA="0x14BF274")]
		internal void <RequestShipments>b__0(ShipmentsResponse response)
		{
		}

		[Address(RVA="0x14BF338", Offset="0x14BF338", VA="0x14BF338")]
		internal void <RequestShipments>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C98C", Offset="0x104C98C")]
	private sealed class <>c__DisplayClass14_0
	{
		[FieldOffset(Offset="0x10")]
		public ShipmentController <>4__this;

		[FieldOffset(Offset="0x18")]
		public BuyShipmentItemRequest request;

		[FieldOffset(Offset="0x20")]
		public string shipmentItemId;

		[FieldOffset(Offset="0x28")]
		public bool usePackOpening;

		[Address(RVA="0x14BDDF0", Offset="0x14BDDF0", VA="0x14BDDF0")]
		public <>c__DisplayClass14_0()
		{
		}

		[Address(RVA="0x14BF408", Offset="0x14BF408", VA="0x14BF408")]
		internal void <PurchaseShipmentItem>b__0(BuyShipmentItemResponse response)
		{
		}

		[Address(RVA="0x14BFA4C", Offset="0x14BFA4C", VA="0x14BFA4C")]
		internal void <PurchaseShipmentItem>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C99C", Offset="0x104C99C")]
	private sealed class <>c__DisplayClass17_0
	{
		[FieldOffset(Offset="0x10")]
		public Shipment shipment;

		[FieldOffset(Offset="0x18")]
		public ShipmentController <>4__this;

		[Address(RVA="0x14BE824", Offset="0x14BE824", VA="0x14BE824")]
		public <>c__DisplayClass17_0()
		{
		}

		[Address(RVA="0x14BFB44", Offset="0x14BFB44", VA="0x14BFB44")]
		internal void <PurchaseRefresh>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C9AC", Offset="0x104C9AC")]
	private sealed class <>c__DisplayClass18_0
	{
		[FieldOffset(Offset="0x10")]
		public Action success;

		[FieldOffset(Offset="0x18")]
		public ShipmentController <>4__this;

		[FieldOffset(Offset="0x20")]
		public ulong shipmentDefId;

		[Address(RVA="0x14BE82C", Offset="0x14BE82C", VA="0x14BE82C")]
		public <>c__DisplayClass18_0()
		{
		}

		[Address(RVA="0x14BFCF8", Offset="0x14BFCF8", VA="0x14BFCF8")]
		internal void <RefreshShipment>b__0(RefreshShipmentResponse response)
		{
		}

		[Address(RVA="0x14BFE9C", Offset="0x14BFE9C", VA="0x14BFE9C")]
		internal void <RefreshShipment>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C9BC", Offset="0x104C9BC")]
	private sealed class <>c__DisplayClass23_0
	{
		[FieldOffset(Offset="0x10")]
		public ShipmentController <>4__this;

		[FieldOffset(Offset="0x18")]
		public ulong shipmentDefId;

		[Address(RVA="0x14BEDE4", Offset="0x14BEDE4", VA="0x14BEDE4")]
		public <>c__DisplayClass23_0()
		{
		}

		[Address(RVA="0x14BFF94", Offset="0x14BFF94", VA="0x14BFF94")]
		internal void <BuyAllShipmentItems>b__0(BuyAllShipmentItemsResponse response)
		{
		}

		[Address(RVA="0x14C0184", Offset="0x14C0184", VA="0x14C0184")]
		internal void <BuyAllShipmentItems>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C95C", Offset="0x104C95C")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset="0x10")]
		public ShipmentController <>4__this;

		[FieldOffset(Offset="0x18")]
		public ClubSupportRequest supportRequest;

		[Address(RVA="0x14BD568", Offset="0x14BD568", VA="0x14BD568")]
		public <>c__DisplayClass7_0()
		{
		}

		[Address(RVA="0x14C027C", Offset="0x14C027C", VA="0x14C027C")]
		internal void <HandleDispatchAction>b__0()
		{
		}
	}
}