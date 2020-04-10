using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public abstract class AWrappedLayoutGroup : LayoutGroup
{
	[FieldOffset(Offset="0x0")]
	private const int EXTRA_ROWS_OR_COLUMNS = 1;

	[FieldOffset(Offset="0x58")]
	protected Vector2 _itemDimensions;

	[FieldOffset(Offset="0x60")]
	protected RectTransform.Axis _scrollAxis;

	[FieldOffset(Offset="0x64")]
	protected int _timesWrapped;

	[FieldOffset(Offset="0x68")]
	protected int _itemCountAlongScrollAxis;

	[FieldOffset(Offset="0x6C")]
	protected int _itemCountAlongNonScrollAxis;

	[FieldOffset(Offset="0x70")]
	private Vector2 _viewportDimensions;

	public float FrontPadding
	{
		[Address(RVA="0x10F600C", Offset="0x10F600C", VA="0x10F600C")]
		get
		{
			return new float();
		}
	}

	public int ItemCountAlongNonScrollAxis
	{
		[Address(RVA="0x10F5FA0", Offset="0x10F5FA0", VA="0x10F5FA0")]
		get
		{
			return new int();
		}
	}

	public int ItemCountAlongScrollAxis
	{
		[Address(RVA="0x10F5FA8", Offset="0x10F5FA8", VA="0x10F5FA8")]
		get
		{
			return new int();
		}
	}

	public float ItemSizeAlongScrollAxis
	{
		[Address(RVA="0x10F5FB0", Offset="0x10F5FB0", VA="0x10F5FB0")]
		get
		{
			return new float();
		}
	}

	public int TotalItemCount
	{
		[Address(RVA="0x10F5F94", Offset="0x10F5F94", VA="0x10F5F94")]
		get
		{
			return new int();
		}
	}

	[Address(RVA="0x10F5F8C", Offset="0x10F5F8C", VA="0x10F5F8C")]
	protected AWrappedLayoutGroup()
	{
	}

	[Address(RVA="0x10F5FF4", Offset="0x10F5FF4", VA="0x10F5FF4")]
	private float GetItemDimension(RectTransform.Axis axis)
	{
		return new float();
	}

	protected abstract float GetItemSpacing(RectTransform.Axis axis);

	[Address(RVA="0x10F6364", Offset="0x10F6364", VA="0x10F6364")]
	private float GetPadding(RectTransform.Axis axis)
	{
		return new float();
	}

	[Address(RVA="0x10F63BC", Offset="0x10F63BC", VA="0x10F63BC")]
	private float GetViewportSize(RectTransform.Axis axis)
	{
		return new float();
	}

	[Address(RVA="0x10F60D4", Offset="0x10F60D4", VA="0x10F60D4")]
	protected int GetVisibleItemCount(RectTransform.Axis axis, AWrappedLayoutGroup.RoundingMode roundingMode)
	{
		return new int();
	}

	public abstract int GetWrappedIndex(int originalIndex);

	[Address(RVA="0x10F6064", Offset="0x10F6064", VA="0x10F6064")]
	public void Initialize(RectTransform.Axis scrollAxis, RectTransform listItem, Vector2 viewportDimensions)
	{
	}

	protected abstract void InitializeItemCountAlongNonScrollAxis();

	protected abstract void InitializeItemDimensions(RectTransform listItem);

	protected abstract void SetLayoutElementPositions();

	[Address(RVA="0x10F6218", Offset="0x10F6218", VA="0x10F6218")]
	public void SetTimesWrapped(int timesWrapped, Action preLayoutAction)
	{
	}

	[Address(RVA="0x10F6258", Offset="0x10F6258", VA="0x10F6258")]
	public void UpdateRectSizeToFitContent(int dataCount)
	{
	}

	protected enum RoundingMode
	{
		[FieldOffset(Offset="0x0")]
		Floor,
		[FieldOffset(Offset="0x0")]
		Ceiling
	}
}