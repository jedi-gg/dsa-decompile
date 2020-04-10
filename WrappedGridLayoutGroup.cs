using Il2CppDummyDll;
using System;
using UnityEngine;

public class WrappedGridLayoutGroup : AWrappedLayoutGroup
{
	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private WrappedGridLayoutGroup.Corner _startCorner;

	[FieldOffset(Offset="0x7C")]
	[SerializeField]
	private WrappedGridLayoutGroup.Axis _startAxis;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private Vector2 _cellSize;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private Vector2 _spacing;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private WrappedGridLayoutGroup.ConstraintType _constraint;

	[FieldOffset(Offset="0x94")]
	[SerializeField]
	private int _constraintCount;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private bool _cellSizeIsListItemSize;

	[FieldOffset(Offset="0x99")]
	[SerializeField]
	private bool _centerAlignIncompleteAxis;

	public Vector2 CellSize
	{
		[Address(RVA="0x15A4D70", Offset="0x15A4D70", VA="0x15A4D70")]
		get
		{
			return new Vector2();
		}
		[Address(RVA="0x15A4D78", Offset="0x15A4D78", VA="0x15A4D78")]
		set
		{
		}
	}

	public WrappedGridLayoutGroup.ConstraintType Constraint
	{
		[Address(RVA="0x15A4E58", Offset="0x15A4E58", VA="0x15A4E58")]
		get
		{
			return new WrappedGridLayoutGroup.ConstraintType();
		}
		[Address(RVA="0x15A4E60", Offset="0x15A4E60", VA="0x15A4E60")]
		set
		{
		}
	}

	public int ConstraintCount
	{
		[Address(RVA="0x15A4EC4", Offset="0x15A4EC4", VA="0x15A4EC4")]
		get
		{
			return new int();
		}
		[Address(RVA="0x15A4ECC", Offset="0x15A4ECC", VA="0x15A4ECC")]
		set
		{
		}
	}

	public Vector2 Spacing
	{
		[Address(RVA="0x15A4DE4", Offset="0x15A4DE4", VA="0x15A4DE4")]
		get
		{
			return new Vector2();
		}
		[Address(RVA="0x15A4DEC", Offset="0x15A4DEC", VA="0x15A4DEC")]
		set
		{
		}
	}

	public WrappedGridLayoutGroup.Axis StartAxis
	{
		[Address(RVA="0x15A4D04", Offset="0x15A4D04", VA="0x15A4D04")]
		get
		{
			return new WrappedGridLayoutGroup.Axis();
		}
		[Address(RVA="0x15A4D0C", Offset="0x15A4D0C", VA="0x15A4D0C")]
		set
		{
		}
	}

	public WrappedGridLayoutGroup.Corner StartCorner
	{
		[Address(RVA="0x15A4C98", Offset="0x15A4C98", VA="0x15A4C98")]
		get
		{
			return new WrappedGridLayoutGroup.Corner();
		}
		[Address(RVA="0x15A4CA0", Offset="0x15A4CA0", VA="0x15A4CA0")]
		set
		{
		}
	}

	[Address(RVA="0x15A62B4", Offset="0x15A62B4", VA="0x15A62B4")]
	public WrappedGridLayoutGroup()
	{
	}

	[Address(RVA="0x15A4F64", Offset="0x15A4F64", VA="0x15A4F64", Slot="28")]
	public override void CalculateLayoutInputHorizontal()
	{
	}

	[Address(RVA="0x15A5144", Offset="0x15A5144", VA="0x15A5144", Slot="29")]
	public override void CalculateLayoutInputVertical()
	{
	}

	[Address(RVA="0x15A6180", Offset="0x15A6180", VA="0x15A6180", Slot="43")]
	protected override float GetItemSpacing(RectTransform.Axis axis)
	{
		return new float();
	}

	[Address(RVA="0x15A5FF4", Offset="0x15A5FF4", VA="0x15A5FF4")]
	private int GetWrappedAxisIndex(int originalIndex, int itemCountAlongAxis)
	{
		return new int();
	}

	[Address(RVA="0x15A5F44", Offset="0x15A5F44", VA="0x15A5F44", Slot="40")]
	public override int GetWrappedIndex(int originalIndex)
	{
		return new int();
	}

	[Address(RVA="0x15A6134", Offset="0x15A6134", VA="0x15A6134", Slot="42")]
	protected override void InitializeItemCountAlongNonScrollAxis()
	{
	}

	[Address(RVA="0x15A60C8", Offset="0x15A60C8", VA="0x15A60C8", Slot="41")]
	protected override void InitializeItemDimensions(RectTransform listItem)
	{
	}

	[Address(RVA="0x15A53A8", Offset="0x15A53A8", VA="0x15A53A8")]
	private void SetCellsAlongAxis(int axis)
	{
	}

	[Address(RVA="0x15A61A8", Offset="0x15A61A8", VA="0x15A61A8")]
	protected new void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size)
	{
	}

	[Address(RVA="0x15A6198", Offset="0x15A6198", VA="0x15A6198", Slot="44")]
	protected override void SetLayoutElementPositions()
	{
	}

	[Address(RVA="0x15A53A0", Offset="0x15A53A0", VA="0x15A53A0", Slot="37")]
	public override void SetLayoutHorizontal()
	{
	}

	[Address(RVA="0x15A5F3C", Offset="0x15A5F3C", VA="0x15A5F3C", Slot="38")]
	public override void SetLayoutVertical()
	{
	}

	public enum Axis
	{
		[FieldOffset(Offset="0x0")]
		Horizontal,
		[FieldOffset(Offset="0x0")]
		Vertical
	}

	public enum ConstraintType
	{
		[FieldOffset(Offset="0x0")]
		Flexible,
		[FieldOffset(Offset="0x0")]
		FixedColumnCount,
		[FieldOffset(Offset="0x0")]
		FixedRowCount
	}

	public enum Corner
	{
		[FieldOffset(Offset="0x0")]
		UpperLeft,
		[FieldOffset(Offset="0x0")]
		UpperRight,
		[FieldOffset(Offset="0x0")]
		LowerLeft,
		[FieldOffset(Offset="0x0")]
		LowerRight
	}
}