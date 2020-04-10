using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Attribute(Name="ExecuteInEditMode", RVA="0x1048364", Offset="0x1048364")]
public class AbilityLevelsPreviewLayoutGroup : LayoutGroup
{
	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private float _spacing;

	[FieldOffset(Offset="0x5C")]
	[SerializeField]
	private float _listItemHeightPadding;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private float _minListItemHeight;

	[FieldOffset(Offset="0x68")]
	private List<AbilityUpgradeLevelPreviewListItem> _abilityUpgradeLevelPreviewListItems;

	[Address(RVA="0x1154634", Offset="0x1154634", VA="0x1154634")]
	public AbilityLevelsPreviewLayoutGroup()
	{
	}

	[Address(RVA="0x1153BEC", Offset="0x1153BEC", VA="0x1153BEC", Slot="28")]
	public override void CalculateLayoutInputHorizontal()
	{
	}

	[Address(RVA="0x1153EF0", Offset="0x1153EF0", VA="0x1153EF0", Slot="29")]
	public override void CalculateLayoutInputVertical()
	{
	}

	[Address(RVA="0x11540D0", Offset="0x11540D0", VA="0x11540D0")]
	private float GetListItemHeight(AbilityUpgradeLevelPreviewListItem item)
	{
		return new float();
	}

	[Address(RVA="0x1153CDC", Offset="0x1153CDC", VA="0x1153CDC", Slot="37")]
	public override void SetLayoutHorizontal()
	{
	}

	[Address(RVA="0x1154174", Offset="0x1154174", VA="0x1154174", Slot="38")]
	public override void SetLayoutVertical()
	{
	}
}