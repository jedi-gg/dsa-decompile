using Il2CppDummyDll;
using System;
using UnityEngine;

public abstract class AWrappedHorizontalOrVerticalLayoutGroup : AWrappedLayoutGroup
{
	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private float _spacing;

	[FieldOffset(Offset="0x7C")]
	[SerializeField]
	private bool _autoExpandListItemDimensions;

	public float Spacing
	{
		[Address(RVA="0x10F5244", Offset="0x10F5244", VA="0x10F5244")]
		get
		{
			return new float();
		}
		[Address(RVA="0x10F524C", Offset="0x10F524C", VA="0x10F524C")]
		set
		{
		}
	}

	[Address(RVA="0x10F5F7C", Offset="0x10F5F7C", VA="0x10F5F7C")]
	protected AWrappedHorizontalOrVerticalLayoutGroup()
	{
	}

	[Address(RVA="0x10F55A0", Offset="0x10F55A0", VA="0x10F55A0")]
	protected void CalcAlongAxis(int axis, bool isVertical)
	{
	}

	[Address(RVA="0x10F583C", Offset="0x10F583C", VA="0x10F583C")]
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, out float min, out float preferred, out float flexible)
	{
		min = 0f;
		preferred = 0f;
		flexible = 0f;
	}

	[Address(RVA="0x10F53F0", Offset="0x10F53F0", VA="0x10F53F0", Slot="43")]
	protected override float GetItemSpacing(RectTransform.Axis axis)
	{
		return new float();
	}

	[Address(RVA="0x10F52B0", Offset="0x10F52B0", VA="0x10F52B0", Slot="40")]
	public override int GetWrappedIndex(int originalIndex)
	{
		return new int();
	}

	[Address(RVA="0x10F53E4", Offset="0x10F53E4", VA="0x10F53E4", Slot="42")]
	protected override void InitializeItemCountAlongNonScrollAxis()
	{
	}

	[Address(RVA="0x10F5388", Offset="0x10F5388", VA="0x10F5388", Slot="41")]
	protected override void InitializeItemDimensions(RectTransform listItem)
	{
	}

	[Address(RVA="0x10F53F8", Offset="0x10F53F8", VA="0x10F53F8")]
	protected new void SetChildAlongAxis(RectTransform rect, int axis, float pos)
	{
	}

	[Address(RVA="0x10F596C", Offset="0x10F596C", VA="0x10F596C")]
	protected void SetChildrenAlongAxis(int axis, bool isVertical)
	{
	}
}