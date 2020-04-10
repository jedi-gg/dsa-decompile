using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class CircleLayoutGroup : LayoutGroup
{
	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private float _startingAngleOffset;

	[FieldOffset(Offset="0x5C")]
	[SerializeField]
	private float _distanceOffset;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private bool _clockwise;

	[Address(RVA="0x1463CD4", Offset="0x1463CD4", VA="0x1463CD4")]
	public CircleLayoutGroup()
	{
	}

	[Address(RVA="0x1463CC8", Offset="0x1463CC8", VA="0x1463CC8", Slot="28")]
	public override void CalculateLayoutInputHorizontal()
	{
	}

	[Address(RVA="0x14638CC", Offset="0x14638CC", VA="0x14638CC", Slot="29")]
	public override void CalculateLayoutInputVertical()
	{
	}

	[Address(RVA="0x14638D0", Offset="0x14638D0", VA="0x14638D0")]
	private void LayoutCircle()
	{
	}

	[Address(RVA="0x1463CCC", Offset="0x1463CCC", VA="0x1463CCC", Slot="37")]
	public override void SetLayoutHorizontal()
	{
	}

	[Address(RVA="0x1463CD0", Offset="0x1463CD0", VA="0x1463CD0", Slot="38")]
	public override void SetLayoutVertical()
	{
	}
}