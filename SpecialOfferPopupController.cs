using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class SpecialOfferPopupController : APopupController, IDispatchHandler<DStoreItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105C7E0", Offset="0x105C7E0")]
	[FieldOffset(Offset="0x38")]
	private StoreDomainController _storeDc;

	[FieldOffset(Offset="0x40")]
	private SpecialOfferPopupView _view;

	[FieldOffset(Offset="0x48")]
	private StoreItem _storeItem;

	public override bool ShouldBeRestoredFromHistory
	{
		[Address(RVA="0x1240B08", Offset="0x1240B08", VA="0x1240B08", Slot="7")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1241190", Offset="0x1241190", VA="0x1241190")]
	public SpecialOfferPopupController()
	{
	}

	[Address(RVA="0x1240EEC", Offset="0x1240EEC", VA="0x1240EEC", Slot="14")]
	public void HandleDispatchAction(DStoreItemAction action)
	{
	}

	[Address(RVA="0x1240B10", Offset="0x1240B10", VA="0x1240B10", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x1240DA0", Offset="0x1240DA0", VA="0x1240DA0", Slot="9")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x1240E14", Offset="0x1240E14", VA="0x1240E14", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CA7C", Offset="0x104CA7C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public SpecialOfferPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x1240D98", Offset="0x1240D98", VA="0x1240D98")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1241198", Offset="0x1241198", VA="0x1241198")]
		internal void <Initialize>b__0(SpecialOfferPopupView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly StoreItem StoreItem;

		[Address(RVA="0x1241500", Offset="0x1241500", VA="0x1241500")]
		public Context(StoreItem storeItem)
		{
		}
	}
}