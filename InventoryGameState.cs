using Glunies;
using Il2CppDummyDll;
using System;
using Zenject;

public class InventoryGameState : AGameState, IDispatchHandler<DTabViewIndexSelectedAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1059618", Offset="0x1059618")]
	[FieldOffset(Offset="0x30")]
	private DiContainer _diContainer;

	[Attribute(Name="InjectAttribute", RVA="0x1059628", Offset="0x1059628")]
	[FieldOffset(Offset="0x38")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1059638", Offset="0x1059638")]
	[FieldOffset(Offset="0x40")]
	private HudController _hudController;

	[Attribute(Name="InjectAttribute", RVA="0x1059648", Offset="0x1059648")]
	[FieldOffset(Offset="0x48")]
	private GameStateMachine _gameStateMachine;

	[FieldOffset(Offset="0x50")]
	private TabViewController<InventoryTabView> _tabViewController;

	[Address(RVA="0x136C36C", Offset="0x136C36C", VA="0x136C36C")]
	public InventoryGameState()
	{
	}

	[Address(RVA="0x136BD3C", Offset="0x136BD3C", VA="0x136BD3C", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	[Address(RVA="0x136BF28", Offset="0x136BF28", VA="0x136BF28", Slot="5")]
	public override void Exiting()
	{
	}

	[Address(RVA="0x136BFBC", Offset="0x136BFBC", VA="0x136BFBC", Slot="12")]
	public void HandleDispatchAction(DTabViewIndexSelectedAction action)
	{
	}

	[Address(RVA="0x136BFC0", Offset="0x136BFC0", VA="0x136BFC0")]
	private void LoadTab(InventoryGameState.Tab tab)
	{
	}

	[Address(RVA="0x136C040", Offset="0x136C040", VA="0x136C040")]
	private void LoadTab(InventoryGameState.Context context)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C1DC", Offset="0x104C1DC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public InventoryGameState <>4__this;

		[FieldOffset(Offset="0x18")]
		public InventoryGameState.Context inventoryContext;

		[Address(RVA="0x136BED8", Offset="0x136BED8", VA="0x136BED8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x136C374", Offset="0x136C374", VA="0x136C374")]
		internal void <Entering>b__0()
		{
		}
	}

	public class Context : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x1C")]
		public readonly InventoryGameState.Tab SelectedTab;

		[FieldOffset(Offset="0x20")]
		public readonly int FilterIndex;

		[FieldOffset(Offset="0x24")]
		public readonly int SortIndex;

		[Address(RVA="0x136BEE0", Offset="0x136BEE0", VA="0x136BEE0")]
		public Context(InventoryGameState.Tab selectedTab, int filterIndex = -1, int sortIndex = -1)
		{
		}
	}

	public enum Tab
	{
		[FieldOffset(Offset="0x0")]
		Characters,
		[FieldOffset(Offset="0x0")]
		Spells,
		[FieldOffset(Offset="0x0")]
		Emotes,
		[FieldOffset(Offset="0x0")]
		Pins
	}
}