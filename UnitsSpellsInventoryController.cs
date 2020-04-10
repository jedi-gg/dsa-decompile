using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class UnitsSpellsInventoryController : AFeatureController, IDispatchHandler<DUnitInventoryViewUnitAction>, IDispatchHandler, IDispatchHandler<DUnitInventoryFilterSortCompleteAction>, IDispatchHandler<DSpellListItemAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1059814", Offset="0x1059814")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1059824", Offset="0x1059824")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1059834", Offset="0x1059834")]
	[FieldOffset(Offset="0x78")]
	private SpellSorter _spellSorter;

	[Attribute(Name="InjectAttribute", RVA="0x1059844", Offset="0x1059844")]
	[FieldOffset(Offset="0x80")]
	private UnitInventoryFilterSortController _filterSortController;

	[FieldOffset(Offset="0x88")]
	private UnitInventoryView _inventoryView;

	[FieldOffset(Offset="0x90")]
	private List<Spell?> _spellDefinitionList;

	[Address(RVA="0x1519C78", Offset="0x1519C78", VA="0x1519C78")]
	public UnitsSpellsInventoryController()
	{
	}

	[Address(RVA="0x1519BC4", Offset="0x1519BC4", VA="0x1519BC4", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x151981C", Offset="0x151981C", VA="0x151981C", Slot="13")]
	public void HandleDispatchAction(DUnitInventoryViewUnitAction action)
	{
	}

	[Address(RVA="0x15199C4", Offset="0x15199C4", VA="0x15199C4", Slot="14")]
	public void HandleDispatchAction(DUnitInventoryFilterSortCompleteAction action)
	{
	}

	[Address(RVA="0x1519A68", Offset="0x1519A68", VA="0x1519A68", Slot="15")]
	public void HandleDispatchAction(DSpellListItemAction action)
	{
	}

	[Address(RVA="0x15194F0", Offset="0x15194F0", VA="0x15194F0", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x1519738", Offset="0x1519738", VA="0x1519738")]
	public void SelectTab(InventoryGameState.Tab tab)
	{
	}

	[Address(RVA="0x15199C8", Offset="0x15199C8", VA="0x15199C8")]
	private void SetViewData()
	{
	}

	[Address(RVA="0x1519704", Offset="0x1519704", VA="0x1519704", Slot="7")]
	public override void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C21C", Offset="0x104C21C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static UnitsSpellsInventoryController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Converter<Unit?, ulong> <>9__3_0;

		[FieldOffset(Offset="0x10")]
		public static Converter<Spell?, ulong> <>9__5_0;

		[Address(RVA="0x1519C80", Offset="0x1519C80", VA="0x1519C80")]
		static <>c()
		{
		}

		[Address(RVA="0x1519CE4", Offset="0x1519CE4", VA="0x1519CE4")]
		public <>c()
		{
		}

		[Address(RVA="0x1519CEC", Offset="0x1519CEC", VA="0x1519CEC")]
		internal ulong <HandleDispatchAction>b__3_0(Unit? d)
		{
			return new ulong();
		}

		[Address(RVA="0x1519D58", Offset="0x1519D58", VA="0x1519D58")]
		internal ulong <HandleDispatchAction>b__5_0(Spell? s)
		{
			return new ulong();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C1FC", Offset="0x104C1FC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitsSpellsInventoryController <>4__this;

		[FieldOffset(Offset="0x18")]
		public InventoryGameState.Context inventoryContext;

		[FieldOffset(Offset="0x20")]
		public GameStateTransitionContext context;

		[Address(RVA="0x15196FC", Offset="0x15196FC", VA="0x15196FC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1519DC4", Offset="0x1519DC4", VA="0x1519DC4")]
		internal void <Initialize>b__0(Action finished)
		{
		}

		[Address(RVA="0x1519EB8", Offset="0x1519EB8", VA="0x1519EB8")]
		internal void <Initialize>b__1(Action finished)
		{
		}

		[Address(RVA="0x1519F2C", Offset="0x1519F2C", VA="0x1519F2C")]
		internal void <Initialize>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C20C", Offset="0x104C20C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action finished;

		[FieldOffset(Offset="0x18")]
		public UnitsSpellsInventoryController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x1519EB0", Offset="0x1519EB0", VA="0x1519EB0")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x151A4BC", Offset="0x151A4BC", VA="0x151A4BC")]
		internal void <Initialize>b__3(UnitInventoryView view)
		{
		}
	}
}