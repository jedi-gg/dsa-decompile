using Glunies;
using Il2CppDummyDll;
using System;

public class StoreItemOddsPopupController : APopupController, IDispatchHandler<DStoreItemOddsPopupGrantAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x38")]
	private StoreItemOddsPopupController.Context _context;

	[Address(RVA="0x130F69C", Offset="0x130F69C", VA="0x130F69C")]
	public StoreItemOddsPopupController()
	{
	}

	[Address(RVA="0x130F694", Offset="0x130F694", VA="0x130F694", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x130F580", Offset="0x130F580", VA="0x130F580", Slot="14")]
	public void HandleDispatchAction(DStoreItemOddsPopupGrantAction action)
	{
	}

	[Address(RVA="0x130F428", Offset="0x130F428", VA="0x130F428", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x130ED28", Offset="0x130ED28", VA="0x130ED28")]
	public static bool ShouldDisplayHighPercent(float percentChance)
	{
		return new bool();
	}

	[Address(RVA="0x130ED54", Offset="0x130ED54", VA="0x130ED54")]
	public static bool ShouldDisplayHundredths(float percentChance)
	{
		return new bool();
	}

	[Address(RVA="0x130ED14", Offset="0x130ED14", VA="0x130ED14")]
	public static bool ShouldDisplayLowPercent(float percentChance)
	{
		return new bool();
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CE0C", Offset="0x104CE0C")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public StoreItemOddsPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x130F578", Offset="0x130F578", VA="0x130F578")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x130F6A4", Offset="0x130F6A4", VA="0x130F6A4")]
		internal void <Initialize>b__0(StoreItemOddsPopupView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly StoreItemDetail ItemDetail;

		[Address(RVA="0x130FAA0", Offset="0x130FAA0", VA="0x130FAA0")]
		public Context(StoreItemDetail itemDetail)
		{
		}
	}
}