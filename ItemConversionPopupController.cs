using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class ItemConversionPopupController : APopupController, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1059954", Offset="0x1059954")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x40")]
	private ItemConversionPopupController.Context _context;

	[Address(RVA="0x137EC98", Offset="0x137EC98", VA="0x137EC98")]
	public ItemConversionPopupController()
	{
	}

	[Address(RVA="0x137E70C", Offset="0x137E70C", VA="0x137E70C")]
	private ValueTuple<List<ItemConversionPopupController.ConversionData>, List<ItemConversionPopupController.ConversionData>> BuildConversionLists(IReadOnlyList<InventoryItemConversion> conversions)
	{
		return new ValueTuple<List<ItemConversionPopupController.ConversionData>, List<ItemConversionPopupController.ConversionData>>();
	}

	[Address(RVA="0x137E5E4", Offset="0x137E5E4", VA="0x137E5E4", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x137E5EC", Offset="0x137E5EC", VA="0x137E5EC", Slot="14")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x137E48C", Offset="0x137E48C", VA="0x137E48C", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C24C", Offset="0x104C24C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ItemConversionPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x137E5DC", Offset="0x137E5DC", VA="0x137E5DC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x137ECA0", Offset="0x137ECA0", VA="0x137ECA0")]
		internal void <Initialize>b__0(ItemConversionPopupView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly IReadOnlyList<InventoryItemConversion> Conversions;

		[Address(RVA="0x137EE38", Offset="0x137EE38", VA="0x137EE38")]
		public Context(IReadOnlyList<InventoryItemConversion> conversions)
		{
		}
	}

	public class ConversionData
	{
		[FieldOffset(Offset="0x10")]
		public readonly Gamedata.InventoryItem? Item;

		[FieldOffset(Offset="0x28")]
		public readonly long Count;

		[Address(RVA="0x137EC54", Offset="0x137EC54", VA="0x137EC54")]
		public ConversionData(Gamedata.InventoryItem? item, long count)
		{
		}
	}
}