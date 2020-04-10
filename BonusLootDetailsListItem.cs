using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BonusLootDetailsListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	public UiLabel _title;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	public UiLabel _description;

	[Address(RVA="0x111F32C", Offset="0x111F32C", VA="0x111F32C")]
	public BonusLootDetailsListItem()
	{
	}

	[Address(RVA="0x111F22C", Offset="0x111F22C", VA="0x111F22C")]
	public void Initialize(WidgetDependencyContainer dependencyContainer)
	{
	}

	[Address(RVA="0x111F260", Offset="0x111F260", VA="0x111F260")]
	public void SetData(BonusLootDetailsItemData item)
	{
	}
}