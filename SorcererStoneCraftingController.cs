using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class SorcererStoneCraftingController : APopupController, IDispatchHandler<DSorcererStoneCraftingViewAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105C750", Offset="0x105C750")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105C760", Offset="0x105C760")]
	[FieldOffset(Offset="0x40")]
	private InventoryService _inventoryService;

	[FieldOffset(Offset="0x48")]
	private SorcererStoneCraftingController.Context _context;

	[FieldOffset(Offset="0x50")]
	private Gamedata.InventoryItem? _stoneItem;

	[Address(RVA="0x123B164", Offset="0x123B164", VA="0x123B164")]
	public SorcererStoneCraftingController()
	{
	}

	[Address(RVA="0x123AF24", Offset="0x123AF24", VA="0x123AF24")]
	private void CraftStone()
	{
	}

	[Address(RVA="0x123B154", Offset="0x123B154", VA="0x123B154", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x123AE70", Offset="0x123AE70", VA="0x123AE70", Slot="14")]
	public void HandleDispatchAction(DSorcererStoneCraftingViewAction action)
	{
	}

	[Address(RVA="0x123AB40", Offset="0x123AB40", VA="0x123AB40", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CA4C", Offset="0x104CA4C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public SorcererStoneCraftingController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x123AE68", Offset="0x123AE68", VA="0x123AE68")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x123B16C", Offset="0x123B16C", VA="0x123B16C")]
		internal void <Initialize>b__0(SorcererStoneCraftingView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CA5C", Offset="0x104CA5C")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public SorcererStoneCraftingController <>4__this;

		[FieldOffset(Offset="0x18")]
		public CraftInventoryItemRequest request;

		[Address(RVA="0x123B15C", Offset="0x123B15C", VA="0x123B15C")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x123BAAC", Offset="0x123BAAC", VA="0x123BAAC")]
		internal void <CraftStone>b__0(CraftInventoryItemResponse response)
		{
		}

		[Address(RVA="0x123BC18", Offset="0x123BC18", VA="0x123BC18")]
		internal void <CraftStone>b__1(long failureCode)
		{
		}

		[Address(RVA="0x123BD20", Offset="0x123BD20", VA="0x123BD20")]
		internal void <CraftStone>b__2()
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly ulong ItemId;

		[Address(RVA="0x123BD94", Offset="0x123BD94", VA="0x123BD94")]
		public Context(ulong itemId)
		{
		}
	}
}