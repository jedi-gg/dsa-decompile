using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class ClubHubRosterFilterSortController : IDispatchHandler<DViewAction>, IDispatchHandler, IDispatchHandler<DClubHubRosterSortRequestedAction>, IDispatchHandler<DFilterSortListItemAction>, IDispatchHandler<DFilterSortViewClosedAction>
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1055F38", Offset="0x1055F38")]
	[FieldOffset(Offset="0x10")]
	private ClubHubRosterSortMode <SelectedSortMode>k__BackingField;

	[Attribute(Name="InjectAttribute", RVA="0x1055F48", Offset="0x1055F48")]
	[FieldOffset(Offset="0x18")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x1055F58", Offset="0x1055F58")]
	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1055F68", Offset="0x1055F68")]
	[FieldOffset(Offset="0x28")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x30")]
	private FilterSortView _view;

	[FieldOffset(Offset="0x38")]
	private List<ClubHubRosterFilterSortController.CustomSort> _customSorts;

	[FieldOffset(Offset="0x40")]
	private List<ClubHubController.RosterEntry> _roster;

	[FieldOffset(Offset="0x48")]
	private bool _isShutdown;

	public ClubHubRosterSortMode SelectedSortMode
	{
		[Address(RVA="0x11B707C", Offset="0x11B707C", VA="0x11B707C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106ED74", Offset="0x106ED74")]
		get
		{
			return new ClubHubRosterSortMode();
		}
		[Address(RVA="0x11BB6F0", Offset="0x11BB6F0", VA="0x11BB6F0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106ED84", Offset="0x106ED84")]
		private set
		{
		}
	}

	public string SelectedSortNameKey
	{
		[Address(RVA="0x11B938C", Offset="0x11B938C", VA="0x11B938C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11BBCD4", Offset="0x11BBCD4", VA="0x11BBCD4")]
	public ClubHubRosterFilterSortController()
	{
	}

	[Address(RVA="0x11BBBC4", Offset="0x11BBBC4", VA="0x11BBBC4")]
	private static int CompareCollectionScore(ClubHubController.RosterEntry a, ClubHubController.RosterEntry b)
	{
		return new int();
	}

	[Address(RVA="0x11BBB1C", Offset="0x11BBB1C", VA="0x11BBB1C")]
	private static int CompareDonationCount(ClubHubController.RosterEntry a, ClubHubController.RosterEntry b)
	{
		return new int();
	}

	[Address(RVA="0x11BBAB8", Offset="0x11BBAB8", VA="0x11BBAB8")]
	private static int CompareJoinDate(ClubHubController.RosterEntry a, ClubHubController.RosterEntry b)
	{
		return new int();
	}

	[Address(RVA="0x11BBC6C", Offset="0x11BBC6C", VA="0x11BBC6C")]
	private static int CompareLastLogin(ClubHubController.RosterEntry a, ClubHubController.RosterEntry b)
	{
		return new int();
	}

	[Address(RVA="0x11BBA10", Offset="0x11BBA10", VA="0x11BBA10")]
	private static int CompareRole(ClubHubController.RosterEntry a, ClubHubController.RosterEntry b)
	{
		return new int();
	}

	[Address(RVA="0x11B8FEC", Offset="0x11B8FEC", VA="0x11B8FEC")]
	public static Comparison<ClubHubController.RosterEntry> GetComparisonFunction(ClubHubRosterSortMode sortMode)
	{
		return null;
	}

	[Address(RVA="0x11BB708", Offset="0x11BB708", VA="0x11BB708", Slot="5")]
	public void HandleDispatchAction(DClubHubRosterSortRequestedAction action)
	{
	}

	[Address(RVA="0x11BB720", Offset="0x11BB720", VA="0x11BB720", Slot="7")]
	public void HandleDispatchAction(DFilterSortViewClosedAction action)
	{
	}

	[Address(RVA="0x11BB754", Offset="0x11BB754", VA="0x11BB754", Slot="4")]
	public void HandleDispatchAction(DViewAction action)
	{
	}

	[Address(RVA="0x11BB7A0", Offset="0x11BB7A0", VA="0x11BB7A0", Slot="6")]
	public void HandleDispatchAction(DFilterSortListItemAction action)
	{
	}

	[Address(RVA="0x11B9FD8", Offset="0x11B9FD8", VA="0x11B9FD8")]
	public void Initialize(Action finished, List<ClubHubController.RosterEntry> roster, ClubHubRosterSortMode sortMode)
	{
	}

	[Address(RVA="0x11BB8C8", Offset="0x11BB8C8", VA="0x11BB8C8")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x11B6BDC", Offset="0x11B6BDC", VA="0x11B6BDC")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x11BB8D0", Offset="0x11BB8D0", VA="0x11BB8D0")]
	private static void Sort(List<ClubHubController.RosterEntry> items, ClubHubRosterSortMode sortMode)
	{
	}

	[Address(RVA="0x11BB8A8", Offset="0x11BB8A8", VA="0x11BB8A8")]
	private void SortRoster(ClubHubRosterSortMode sortMode)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B68C", Offset="0x104B68C")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubHubRosterFilterSortController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[FieldOffset(Offset="0x20")]
		public Converter<ClubHubRosterFilterSortController.CustomSort, string> <>9__1;

		[Address(RVA="0x11BB6F8", Offset="0x11BB6F8", VA="0x11BB6F8")]
		public <>c__DisplayClass6_0()
		{
		}

		[Address(RVA="0x11BBCDC", Offset="0x11BBCDC", VA="0x11BBCDC")]
		internal void <Initialize>b__0(FilterSortView view)
		{
		}

		[Address(RVA="0x11BBE30", Offset="0x11BBE30", VA="0x11BBE30")]
		internal string <Initialize>b__1(ClubHubRosterFilterSortController.CustomSort s)
		{
			return null;
		}
	}

	private class CustomSort
	{
		[FieldOffset(Offset="0x10")]
		public string NameKey;

		[FieldOffset(Offset="0x18")]
		public Comparison<ClubHubController.RosterEntry> Comparer;

		[Address(RVA="0x11BB700", Offset="0x11BB700", VA="0x11BB700")]
		public CustomSort()
		{
		}
	}
}