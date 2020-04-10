using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FilterSortView : AView, IDispatchHandler<DFilterSortListItemAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x0")]
	public const int DEFAULT_SORT_INDEX = -1;

	[FieldOffset(Offset="0x68")]
	private List<string> _filters;

	[FieldOffset(Offset="0x70")]
	private List<string> _sorts;

	[FieldOffset(Offset="0x78")]
	private int _selectedFilter;

	[FieldOffset(Offset="0x7C")]
	private int _selectedSort;

	[FieldOffset(Offset="0x80")]
	private float _minFilterSortParentSizeX;

	[FieldOffset(Offset="0x84")]
	private float _maxFilterSortParentSizeX;

	[FieldOffset(Offset="0x88")]
	private Sequence _showTween;

	public override ViewDepth Depth
	{
		[Address(RVA="0x12C8024", Offset="0x12C8024", VA="0x12C8024", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private FilterSortView.SerializedFields Fields
	{
		[Address(RVA="0x12C83DC", Offset="0x12C83DC", VA="0x12C83DC")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12C9118", Offset="0x12C9118", VA="0x12C9118")]
	public FilterSortView()
	{
	}

	[Address(RVA="0x12C9128", Offset="0x12C9128", VA="0x12C9128")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F784", Offset="0x106F784")]
	private void <ViewAssetLoaded>b__5_0(Button b)
	{
	}

	[Address(RVA="0x12C91D8", Offset="0x12C91D8", VA="0x12C91D8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F794", Offset="0x106F794")]
	private void <ViewAssetLoaded>b__5_1()
	{
	}

	[Address(RVA="0x12C8E18", Offset="0x12C8E18", VA="0x12C8E18")]
	private void BindFilterListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x12C9008", Offset="0x12C9008", VA="0x12C9008")]
	private void BindSortListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x12C84BC", Offset="0x12C84BC", VA="0x12C84BC", Slot="21")]
	public void HandleDispatchAction(DFilterSortListItemAction action)
	{
	}

	[Address(RVA="0x12C8D38", Offset="0x12C8D38", VA="0x12C8D38")]
	private void InitializeFilterListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x12C8F28", Offset="0x12C8F28", VA="0x12C8F28")]
	private void InitializeSortListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x12C802C", Offset="0x12C802C", VA="0x12C802C")]
	public void SetData(List<string> filters, List<string> sorts, int selectedFilter = -1, int selectedSort = -1)
	{
	}

	[Address(RVA="0x12C85C8", Offset="0x12C85C8", VA="0x12C85C8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x12C8D04", Offset="0x12C8D04", VA="0x12C8D04", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x12C8ACC", Offset="0x12C8ACC", VA="0x12C8ACC", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BE8C", Offset="0x104BE8C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static FilterSortView.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<Button> <>9__6_0;

		[Address(RVA="0x12C925C", Offset="0x12C925C", VA="0x12C925C")]
		static <>c()
		{
		}

		[Address(RVA="0x12C92C0", Offset="0x12C92C0", VA="0x12C92C0")]
		public <>c()
		{
		}

		[Address(RVA="0x12C92C8", Offset="0x12C92C8", VA="0x12C92C8")]
		internal void <ViewShuttingDown>b__6_0(Button b)
		{
		}
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106A4F4", Offset="0x106A4F4")]
		[FieldOffset(Offset="0x28")]
		public List<Button> CloseButtons;

		[FieldOffset(Offset="0x30")]
		public RectTransform FilterSortParent;

		[FieldOffset(Offset="0x38")]
		public RectTransform FilterParent;

		[FieldOffset(Offset="0x40")]
		public FilterSortListItem FilterAllListItem;

		[FieldOffset(Offset="0x48")]
		public WrappedScrollRect FilterScrollRect;

		[FieldOffset(Offset="0x50")]
		public RectTransform SortParent;

		[FieldOffset(Offset="0x58")]
		public FilterSortListItem SortDefaultListItem;

		[FieldOffset(Offset="0x60")]
		public WrappedScrollRect SortScrollRect;

		[Address(RVA="0x12C9310", Offset="0x12C9310", VA="0x12C9310")]
		public SerializedFields()
		{
		}
	}
}