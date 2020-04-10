using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class UnitInventoryFilterSortController : IDispatchHandler<DViewAction>, IDispatchHandler, IDispatchHandler<DUnitInventoryFilterSortRequestAction>, IDispatchHandler<DFilterSortViewClosedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x10596A8", Offset="0x10596A8")]
	[FieldOffset(Offset="0x10")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x10596B8", Offset="0x10596B8")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x10596C8", Offset="0x10596C8")]
	[FieldOffset(Offset="0x20")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x10596D8", Offset="0x10596D8")]
	[FieldOffset(Offset="0x28")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x10596E8", Offset="0x10596E8")]
	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x10596F8", Offset="0x10596F8")]
	[FieldOffset(Offset="0x38")]
	private UnitSorter _unitSorter;

	[FieldOffset(Offset="0x40")]
	private FilterSortView _view;

	[FieldOffset(Offset="0x48")]
	private List<Unit?> _allUnitDefs;

	[FieldOffset(Offset="0x50")]
	private List<Unit?> _filteredUnitDefs;

	[FieldOffset(Offset="0x58")]
	private List<UnitCategory?> _unitCategories;

	[FieldOffset(Offset="0x60")]
	private List<UnitInventoryFilterSortController.CustomFilter> _customFilters;

	[FieldOffset(Offset="0x68")]
	private List<UnitInventoryFilterSortController.CustomSort> _customSorts;

	[FieldOffset(Offset="0x70")]
	private int _selectedFilterIndex;

	[FieldOffset(Offset="0x74")]
	private int _selectedSortIndex;

	[FieldOffset(Offset="0x78")]
	private bool _isShutdown;

	public List<Unit?> FilteredUnits
	{
		[Address(RVA="0x1501900", Offset="0x1501900", VA="0x1501900")]
		get
		{
			return null;
		}
	}

	public int SelectedFilterIndex
	{
		[Address(RVA="0x1501908", Offset="0x1501908", VA="0x1501908")]
		get
		{
			return new int();
		}
	}

	public int SelectedSortIndex
	{
		[Address(RVA="0x1501910", Offset="0x1501910", VA="0x1501910")]
		get
		{
			return new int();
		}
	}

	[Address(RVA="0x1503584", Offset="0x1503584", VA="0x1503584")]
	public UnitInventoryFilterSortController()
	{
	}

	[Address(RVA="0x1503594", Offset="0x1503594", VA="0x1503594")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FF84", Offset="0x106FF84")]
	private bool <BuildCustomFilterList>b__17_0(Unit? unitDef)
	{
		return new bool();
	}

	[Address(RVA="0x1503638", Offset="0x1503638", VA="0x1503638")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FF94", Offset="0x106FF94")]
	private bool <BuildCustomFilterList>b__17_1(Unit? unitDef)
	{
		return new bool();
	}

	[Address(RVA="0x15036DC", Offset="0x15036DC", VA="0x15036DC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FFA4", Offset="0x106FFA4")]
	private void <BuildCustomSortList>b__18_0(ulong unitDefId, UiLabel label)
	{
	}

	[Address(RVA="0x1503894", Offset="0x1503894", VA="0x1503894")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FFB4", Offset="0x106FFB4")]
	private void <BuildCustomSortList>b__18_1(ulong unitDefId, UiLabel label)
	{
	}

	[Address(RVA="0x1504834", Offset="0x1504834", VA="0x1504834")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070044", Offset="0x1070044")]
	private void <BuildCustomSortList>b__18_10(ulong unitDefId, UiLabel label)
	{
	}

	[Address(RVA="0x1503A4C", Offset="0x1503A4C", VA="0x1503A4C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FFC4", Offset="0x106FFC4")]
	private void <BuildCustomSortList>b__18_2(ulong unitDefId, UiLabel label)
	{
	}

	[Address(RVA="0x1503C04", Offset="0x1503C04", VA="0x1503C04")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FFD4", Offset="0x106FFD4")]
	private void <BuildCustomSortList>b__18_3(ulong unitDefId, UiLabel label)
	{
	}

	[Address(RVA="0x1503DBC", Offset="0x1503DBC", VA="0x1503DBC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FFE4", Offset="0x106FFE4")]
	private void <BuildCustomSortList>b__18_4(ulong unitDefId, UiLabel label)
	{
	}

	[Address(RVA="0x1503F7C", Offset="0x1503F7C", VA="0x1503F7C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FFF4", Offset="0x106FFF4")]
	private void <BuildCustomSortList>b__18_5(ulong unitDefId, UiLabel label)
	{
	}

	[Address(RVA="0x150413C", Offset="0x150413C", VA="0x150413C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070004", Offset="0x1070004")]
	private void <BuildCustomSortList>b__18_6(ulong unitDefId, UiLabel label)
	{
	}

	[Address(RVA="0x15042F4", Offset="0x15042F4", VA="0x15042F4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070014", Offset="0x1070014")]
	private void <BuildCustomSortList>b__18_7(ulong unitDefId, UiLabel label)
	{
	}

	[Address(RVA="0x15044B4", Offset="0x15044B4", VA="0x15044B4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070024", Offset="0x1070024")]
	private void <BuildCustomSortList>b__18_8(ulong unitDefId, UiLabel label)
	{
	}

	[Address(RVA="0x1504674", Offset="0x1504674", VA="0x1504674")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070034", Offset="0x1070034")]
	private void <BuildCustomSortList>b__18_9(ulong unitDefId, UiLabel label)
	{
	}

	[Address(RVA="0x1501FA8", Offset="0x1501FA8", VA="0x1501FA8")]
	private void BuildCustomFilterList()
	{
	}

	[Address(RVA="0x1502148", Offset="0x1502148", VA="0x1502148")]
	private void BuildCustomSortList()
	{
	}

	[Address(RVA="0x1502BC4", Offset="0x1502BC4", VA="0x1502BC4")]
	private void FilterUnits(int filterIndex)
	{
	}

	[Address(RVA="0x1503048", Offset="0x1503048", VA="0x1503048")]
	public string GetSelectedFilterNameKey()
	{
		return null;
	}

	[Address(RVA="0x150320C", Offset="0x150320C", VA="0x150320C")]
	public string GetSelectedSortNameKey()
	{
		return null;
	}

	[Address(RVA="0x1503398", Offset="0x1503398", VA="0x1503398", Slot="5")]
	public void HandleDispatchAction(DUnitInventoryFilterSortRequestAction action)
	{
	}

	[Address(RVA="0x15033B0", Offset="0x15033B0", VA="0x15033B0", Slot="6")]
	public void HandleDispatchAction(DFilterSortViewClosedAction action)
	{
	}

	[Address(RVA="0x1503480", Offset="0x1503480", VA="0x1503480", Slot="4")]
	public void HandleDispatchAction(DViewAction action)
	{
	}

	[Address(RVA="0x1501918", Offset="0x1501918", VA="0x1501918")]
	public void Initialize(Action finished, int selectedFilterIndex = -1, int selectedSortIndex = -1)
	{
	}

	[Address(RVA="0x15034CC", Offset="0x15034CC", VA="0x15034CC")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x1502FD4", Offset="0x1502FD4", VA="0x1502FD4")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1502EF8", Offset="0x1502EF8", VA="0x1502EF8")]
	private void SortUnits(int sortIndex)
	{
	}

	[Address(RVA="0x15032A8", Offset="0x15032A8", VA="0x15032A8")]
	public bool TrySetCustomSortLabel(ulong unitId, UiLabel label)
	{
		return new bool();
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C1EC", Offset="0x104C1EC")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitInventoryFilterSortController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[FieldOffset(Offset="0x20")]
		public Converter<UnitCategory?, string> <>9__2;

		[FieldOffset(Offset="0x28")]
		public Converter<UnitInventoryFilterSortController.CustomSort, string> <>9__3;

		[Address(RVA="0x1501FA0", Offset="0x1501FA0", VA="0x1501FA0")]
		public <>c__DisplayClass6_0()
		{
		}

		[Address(RVA="0x15049F4", Offset="0x15049F4", VA="0x15049F4")]
		internal int <Initialize>b__0(UnitCategory? a, UnitCategory? b)
		{
			return new int();
		}

		[Address(RVA="0x1504B70", Offset="0x1504B70", VA="0x1504B70")]
		internal void <Initialize>b__1(FilterSortView view)
		{
		}

		[Address(RVA="0x1504F8C", Offset="0x1504F8C", VA="0x1504F8C")]
		internal string <Initialize>b__2(UnitCategory? c)
		{
			return null;
		}

		[Address(RVA="0x150503C", Offset="0x150503C", VA="0x150503C")]
		internal string <Initialize>b__3(UnitInventoryFilterSortController.CustomSort s)
		{
			return null;
		}
	}

	private class CustomFilter
	{
		[FieldOffset(Offset="0x10")]
		public string NameKey;

		[FieldOffset(Offset="0x18")]
		public Predicate<Unit?> FilterPassCondition;

		[Address(RVA="0x1503574", Offset="0x1503574", VA="0x1503574")]
		public CustomFilter()
		{
		}
	}

	private class CustomSort
	{
		[FieldOffset(Offset="0x10")]
		public string NameKey;

		[FieldOffset(Offset="0x18")]
		public Comparison<Unit?> Comparer;

		[FieldOffset(Offset="0x20")]
		public Action<ulong, UiLabel> SetCustomLabelAction;

		[Address(RVA="0x150357C", Offset="0x150357C", VA="0x150357C")]
		public CustomSort()
		{
		}
	}
}