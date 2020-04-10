using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class SpellUpgradeController : AFeatureController, IDispatchHandler<DAbilityUpgradeViewAction>, IDispatchHandler, IDispatchHandler<DAbilityUpgradeViewFindAction>, IDispatchHandler<DAbilityUpgradeViewCycleAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1052390", Offset="0x1052390")]
	[FieldOffset(Offset="0x68")]
	private InventoryService _inventoryService;

	[Attribute(Name="InjectAttribute", RVA="0x10523A0", Offset="0x10523A0")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x10523B0", Offset="0x10523B0")]
	[FieldOffset(Offset="0x78")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x10523C0", Offset="0x10523C0")]
	[FieldOffset(Offset="0x80")]
	private BattleBuffIconPressedPopupController _battleBuffIconPressedPopupController;

	[Attribute(Name="InjectAttribute", RVA="0x10523D0", Offset="0x10523D0")]
	[FieldOffset(Offset="0x88")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x90")]
	private SpellUpgradeGameState.Context _context;

	[FieldOffset(Offset="0x98")]
	private SpellUpgradeView _view;

	[FieldOffset(Offset="0xA0")]
	private SpellUpgradeViewModel _viewModel;

	[FieldOffset(Offset="0xA8")]
	private List<ulong> _spellCycleList;

	[FieldOffset(Offset="0xB0")]
	private int _currentSpellCycleIndex;

	[Address(RVA="0x124660C", Offset="0x124660C", VA="0x124660C")]
	public SpellUpgradeController()
	{
	}

	[Address(RVA="0x1245D8C", Offset="0x1245D8C", VA="0x1245D8C", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x1244E8C", Offset="0x1244E8C", VA="0x1244E8C", Slot="13")]
	public void HandleDispatchAction(DAbilityUpgradeViewAction action)
	{
	}

	[Address(RVA="0x12450F8", Offset="0x12450F8", VA="0x12450F8", Slot="14")]
	public void HandleDispatchAction(DAbilityUpgradeViewFindAction action)
	{
	}

	[Address(RVA="0x12452C4", Offset="0x12452C4", VA="0x12452C4", Slot="15")]
	public void HandleDispatchAction(DAbilityUpgradeViewCycleAction action)
	{
	}

	[Address(RVA="0x1245DDC", Offset="0x1245DDC", VA="0x1245DDC")]
	private void IncrementViewModelLevel()
	{
	}

	[Address(RVA="0x1244B18", Offset="0x1244B18", VA="0x1244B18", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x1245464", Offset="0x1245464", VA="0x1245464")]
	private void PopulateViewModelData()
	{
	}

	[Address(RVA="0x1245FB8", Offset="0x1245FB8", VA="0x1245FB8")]
	private void SendSpellUnlockTelemetry(SpellUpgradeRequest request, SpellUpgradeResponse response)
	{
	}

	[Address(RVA="0x12462D0", Offset="0x12462D0", VA="0x12462D0")]
	private void SendSpellUpgradeTelemetry(SpellUpgradeRequest request, SpellUpgradeResponse response)
	{
	}

	[Address(RVA="0x1244DD8", Offset="0x1244DD8", VA="0x1244DD8", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x1244E10", Offset="0x1244E10", VA="0x1244E10", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AD6C", Offset="0x104AD6C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public SpellUpgradeController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x1244DD0", Offset="0x1244DD0", VA="0x1244DD0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x124667C", Offset="0x124667C", VA="0x124667C")]
		internal void <Initialize>b__0(Action finished)
		{
		}

		[Address(RVA="0x1246770", Offset="0x1246770", VA="0x1246770")]
		internal void <Initialize>b__1()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AD7C", Offset="0x104AD7C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action finished;

		[FieldOffset(Offset="0x18")]
		public SpellUpgradeController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x1246768", Offset="0x1246768", VA="0x1246768")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x12469C0", Offset="0x12469C0", VA="0x12469C0")]
		internal void <Initialize>b__2(SpellUpgradeView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AD8C", Offset="0x104AD8C")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public bool isUnlock;

		[FieldOffset(Offset="0x18")]
		public SpellUpgradeController <>4__this;

		[FieldOffset(Offset="0x20")]
		public SpellUpgradeRequest request;

		[Address(RVA="0x12450F0", Offset="0x12450F0", VA="0x12450F0")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x1246A54", Offset="0x1246A54", VA="0x1246A54")]
		internal void <HandleDispatchAction>b__0(SpellUpgradeResponse response)
		{
		}

		[Address(RVA="0x1246BE4", Offset="0x1246BE4", VA="0x1246BE4")]
		internal void <HandleDispatchAction>b__1(long failureCode)
		{
		}

		[Address(RVA="0x1246CF0", Offset="0x1246CF0", VA="0x1246CF0")]
		internal void <HandleDispatchAction>b__2()
		{
		}
	}
}