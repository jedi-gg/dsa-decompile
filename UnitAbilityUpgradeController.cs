using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class UnitAbilityUpgradeController : AFeatureController, IDispatchHandler<DAbilityUpgradeViewAction>, IDispatchHandler, IDispatchHandler<DAbilityUpgradeViewCycleAction>, IDispatchHandler<DAbilityUpgradeViewFindAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x10523E0", Offset="0x10523E0")]
	[FieldOffset(Offset="0x68")]
	private InventoryService _inventoryService;

	[Attribute(Name="InjectAttribute", RVA="0x10523F0", Offset="0x10523F0")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1052400", Offset="0x1052400")]
	[FieldOffset(Offset="0x78")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1052410", Offset="0x1052410")]
	[FieldOffset(Offset="0x80")]
	private BattleBuffIconPressedPopupController _battleBuffIconPressedPopupController;

	[Attribute(Name="InjectAttribute", RVA="0x1052420", Offset="0x1052420")]
	[FieldOffset(Offset="0x88")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x90")]
	private UnitAbilityUpgradeGameState.Context _context;

	[FieldOffset(Offset="0x98")]
	private UnitAbilityUpgradeView _view;

	[FieldOffset(Offset="0xA0")]
	private UnitAbilityUpgradeViewModel _viewModel;

	[FieldOffset(Offset="0xA8")]
	private List<UnitAbility?> _unitAbilities;

	[Address(RVA="0x15A0ADC", Offset="0x15A0ADC", VA="0x15A0ADC")]
	public UnitAbilityUpgradeController()
	{
	}

	[Address(RVA="0x15A0494", Offset="0x15A0494", VA="0x15A0494", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x159F3F0", Offset="0x159F3F0", VA="0x159F3F0", Slot="13")]
	public void HandleDispatchAction(DAbilityUpgradeViewAction action)
	{
	}

	[Address(RVA="0x159F63C", Offset="0x159F63C", VA="0x159F63C", Slot="14")]
	public void HandleDispatchAction(DAbilityUpgradeViewCycleAction action)
	{
	}

	[Address(RVA="0x15A02C8", Offset="0x15A02C8", VA="0x15A02C8", Slot="15")]
	public void HandleDispatchAction(DAbilityUpgradeViewFindAction action)
	{
	}

	[Address(RVA="0x15A04E4", Offset="0x15A04E4", VA="0x15A04E4")]
	private void IncrementViewModelLevel()
	{
	}

	[Address(RVA="0x159EF1C", Offset="0x159EF1C", VA="0x159EF1C", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x159F870", Offset="0x159F870", VA="0x159F870")]
	private void PopulateViewModelData()
	{
	}

	[Address(RVA="0x15A0728", Offset="0x15A0728", VA="0x15A0728")]
	private void SendAbilityUpgradeTelemetry(AbilityUpgradeRequest request, AbilityUpgradeResponse response)
	{
	}

	[Address(RVA="0x159F33C", Offset="0x159F33C", VA="0x159F33C", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x159F374", Offset="0x159F374", VA="0x159F374", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104ADCC", Offset="0x104ADCC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static UnitAbilityUpgradeController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Comparison<UnitAbility?> <>9__0_0;

		[Address(RVA="0x15A0B6C", Offset="0x15A0B6C", VA="0x15A0B6C")]
		static <>c()
		{
		}

		[Address(RVA="0x15A0BD0", Offset="0x15A0BD0", VA="0x15A0BD0")]
		public <>c()
		{
		}

		[Address(RVA="0x15A0BD8", Offset="0x15A0BD8", VA="0x15A0BD8")]
		internal int <Initialize>b__0_0(UnitAbility? a, UnitAbility? b)
		{
			return new int();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AD9C", Offset="0x104AD9C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitAbilityUpgradeController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x11DCF64", Offset="0x11DCF64", VA="0x11DCF64")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11DCF6C", Offset="0x11DCF6C", VA="0x11DCF6C")]
		internal void <Initialize>b__1(Action finished)
		{
		}

		[Address(RVA="0x11DD060", Offset="0x11DD060", VA="0x11DD060")]
		internal void <Initialize>b__2(Action jobFinished)
		{
		}

		[Address(RVA="0x11DD14C", Offset="0x11DD14C", VA="0x11DD14C")]
		internal void <Initialize>b__3()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104ADAC", Offset="0x104ADAC")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action finished;

		[FieldOffset(Offset="0x18")]
		public UnitAbilityUpgradeController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x11DD058", Offset="0x11DD058", VA="0x11DD058")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x11DD2F0", Offset="0x11DD2F0", VA="0x11DD2F0")]
		internal void <Initialize>b__4(UnitAbilityUpgradeView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104ADBC", Offset="0x104ADBC")]
	private sealed class <>c__DisplayClass0_2
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[Address(RVA="0x11DD144", Offset="0x11DD144", VA="0x11DD144")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x11DD384", Offset="0x11DD384", VA="0x11DD384")]
		internal void <Initialize>b__5(UnitDetailsScene _)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104ADDC", Offset="0x104ADDC")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitAbilityUpgradeController <>4__this;

		[FieldOffset(Offset="0x18")]
		public AbilityUpgradeRequest request;

		[Address(RVA="0x11DD398", Offset="0x11DD398", VA="0x11DD398")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x11DD3A0", Offset="0x11DD3A0", VA="0x11DD3A0")]
		internal void <HandleDispatchAction>b__0(AbilityUpgradeResponse response)
		{
		}

		[Address(RVA="0x11DD44C", Offset="0x11DD44C", VA="0x11DD44C")]
		internal void <HandleDispatchAction>b__1(long failureCode)
		{
		}

		[Address(RVA="0x11DD568", Offset="0x11DD568", VA="0x11DD568")]
		internal void <HandleDispatchAction>b__2()
		{
		}
	}
}