using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class StoreItemDetailsController : APopupController, IDispatchHandler<DStoreItemDetailsViewAction>, IDispatchHandler, IDispatchHandler<DStoreItemDetailsDropListItemAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105D2A8", Offset="0x105D2A8")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105D2B8", Offset="0x105D2B8")]
	[FieldOffset(Offset="0x40")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x105D2C8", Offset="0x105D2C8")]
	[FieldOffset(Offset="0x48")]
	private StoreService _storeService;

	[FieldOffset(Offset="0x50")]
	private StoreItemDetailsView _view;

	[FieldOffset(Offset="0x58")]
	private StoreItemDetail _details;

	[FieldOffset(Offset="0x60")]
	private ITransitionContext _context;

	[FieldOffset(Offset="0x68")]
	private bool _allowNavigateAway;

	[Address(RVA="0x1234A8C", Offset="0x1234A8C", VA="0x1234A8C")]
	public StoreItemDetailsController()
	{
	}

	[Address(RVA="0x12348A4", Offset="0x12348A4", VA="0x12348A4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070B74", Offset="0x1070B74")]
	private void <ParseResponse>g__AddChanceItem|8_1(ulong itemId, uint min, uint max)
	{
	}

	[Address(RVA="0x12341F0", Offset="0x12341F0", VA="0x12341F0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070B64", Offset="0x1070B64")]
	private void <ParseResponse>g__AddGuaranteedItem|8_0(ulong itemId, uint min, uint max, bool isClubGift)
	{
	}

	[Address(RVA="0x12328F4", Offset="0x12328F4", VA="0x12328F4", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x12343E4", Offset="0x12343E4", VA="0x12343E4")]
	private bool GetTrueMinMaxForGrantWithMultipleOptionsAllWithTheSameId(StoreItemGrant grant, out uint trueMin, out uint trueMax)
	{
		trueMin = 0;
		trueMax = 0;
		return new bool();
	}

	[Address(RVA="0x12328FC", Offset="0x12328FC", VA="0x12328FC", Slot="14")]
	public void HandleDispatchAction(DStoreItemDetailsViewAction action)
	{
	}

	[Address(RVA="0x1232B94", Offset="0x1232B94", VA="0x1232B94", Slot="15")]
	public void HandleDispatchAction(DStoreItemDetailsDropListItemAction action)
	{
	}

	[Address(RVA="0x12322FC", Offset="0x12322FC", VA="0x12322FC", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x1232CC8", Offset="0x1232CC8", VA="0x1232CC8")]
	private void LoadView(Action finished)
	{
	}

	[Address(RVA="0x12330B0", Offset="0x12330B0", VA="0x12330B0")]
	private void ParseResponse(StoreItemResponse response)
	{
	}

	[Address(RVA="0x1232DAC", Offset="0x1232DAC", VA="0x1232DAC")]
	private void RequestStoreItemDetails(Action finished)
	{
	}

	[Address(RVA="0x123283C", Offset="0x123283C", VA="0x123283C", Slot="9")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x1232800", Offset="0x1232800", VA="0x1232800", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CD5C", Offset="0x104CD5C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public StoreItemDetailsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public StoreItemDetailsController.StoreContext storeContext;

		[FieldOffset(Offset="0x20")]
		public Action completed;

		[Address(RVA="0x12327E8", Offset="0x12327E8", VA="0x12327E8")]
		public <>c__DisplayClass0_0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CD6C", Offset="0x104CD6C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public StoreItemData storeItem;

		[FieldOffset(Offset="0x18")]
		public StoreItemDetailsController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x12327F0", Offset="0x12327F0", VA="0x12327F0")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x1234AAC", Offset="0x1234AAC", VA="0x1234AAC")]
		internal void <Initialize>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CD7C", Offset="0x104CD7C")]
	private sealed class <>c__DisplayClass0_2
	{
		[FieldOffset(Offset="0x10")]
		public StoreItemDetailsController.ShipmentContext shipmentContext;

		[FieldOffset(Offset="0x18")]
		public StoreItemDetailsController.<>c__DisplayClass0_0 CS$<>8__locals2;

		[Address(RVA="0x12327F8", Offset="0x12327F8", VA="0x12327F8")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x1234D44", Offset="0x1234D44", VA="0x1234D44")]
		internal void <Initialize>b__1()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CD8C", Offset="0x104CD8C")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset="0x10")]
		public StoreItemDetailsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x1232DA4", Offset="0x1232DA4", VA="0x1232DA4")]
		public <>c__DisplayClass6_0()
		{
		}

		[Address(RVA="0x12350D0", Offset="0x12350D0", VA="0x12350D0")]
		internal void <LoadView>b__0(StoreItemDetailsView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CD9C", Offset="0x104CD9C")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset="0x10")]
		public StoreItemDetailsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x12330A0", Offset="0x12330A0", VA="0x12330A0")]
		public <>c__DisplayClass7_0()
		{
		}

		[Address(RVA="0x1235128", Offset="0x1235128", VA="0x1235128")]
		internal void <RequestStoreItemDetails>b__0(StoreItemResponse response)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CDAC", Offset="0x104CDAC")]
	private sealed class <>c__DisplayClass7_1
	{
		[FieldOffset(Offset="0x10")]
		public StoreItemRequest request;

		[FieldOffset(Offset="0x18")]
		public StoreItemDetailsController.<>c__DisplayClass7_0 CS$<>8__locals1;

		[Address(RVA="0x12330A8", Offset="0x12330A8", VA="0x12330A8")]
		public <>c__DisplayClass7_1()
		{
		}

		[Address(RVA="0x1235188", Offset="0x1235188", VA="0x1235188")]
		internal void <RequestStoreItemDetails>b__1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CDBC", Offset="0x104CDBC")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset="0x10")]
		public ulong itemId;

		[Address(RVA="0x1234A9C", Offset="0x1234A9C", VA="0x1234A9C")]
		public <>c__DisplayClass8_0()
		{
		}

		[Address(RVA="0x12352C4", Offset="0x12352C4", VA="0x12352C4")]
		internal bool <ParseResponse>b__2(StoreItemDropDetail i)
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CDCC", Offset="0x104CDCC")]
	private sealed class <>c__DisplayClass8_1
	{
		[FieldOffset(Offset="0x10")]
		public ulong itemId;

		[Address(RVA="0x1234AA4", Offset="0x1234AA4", VA="0x1234AA4")]
		public <>c__DisplayClass8_1()
		{
		}

		[Address(RVA="0x1235300", Offset="0x1235300", VA="0x1235300")]
		internal bool <ParseResponse>b__3(StoreItemDropDetail i)
		{
			return new bool();
		}
	}

	public class ShipmentContext : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly StoreItem Item;

		[FieldOffset(Offset="0x18")]
		public readonly string ShipmentItemId;

		[Address(RVA="0x123533C", Offset="0x123533C", VA="0x123533C")]
		public ShipmentContext(StoreItem item, string shipmentItemId)
		{
		}
	}

	public class StoreContext : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly StoreItemData Item;

		[FieldOffset(Offset="0x18")]
		public readonly bool ShowPurchaseAgain;

		[FieldOffset(Offset="0x20")]
		public readonly object StoreActionOwnerIdentifier;

		[FieldOffset(Offset="0x28")]
		public readonly bool AllowNavigateAway;

		[Address(RVA="0x1228B80", Offset="0x1228B80", VA="0x1228B80")]
		public StoreContext(StoreItemData item, object storeActionOwnerIdentifier, bool showPurchaseAgain = false, bool allowNavigateAway = true)
		{
		}
	}
}