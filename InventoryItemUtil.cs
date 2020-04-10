using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemUtil
{
	[Attribute(Name="InjectAttribute", RVA="0x105FAE0", Offset="0x105FAE0")]
	[FieldOffset(Offset="0x10")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105FAF0", Offset="0x105FAF0")]
	[FieldOffset(Offset="0x18")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x20")]
	private Dictionary<UiLabel, UnityEngine.Color> _defaultLabelColors;

	[Address(RVA="0x1371A38", Offset="0x1371A38", VA="0x1371A38")]
	public InventoryItemUtil()
	{
	}

	[Address(RVA="0x136DBE0", Offset="0x136DBE0", VA="0x136DBE0")]
	public void CacheInitialColor(UiLabel label)
	{
	}

	[Address(RVA="0x1371948", Offset="0x1371948", VA="0x1371948")]
	public void ResetToInitialColor(UiLabel label)
	{
	}

	[Address(RVA="0x136D73C", Offset="0x136D73C", VA="0x136D73C")]
	public void SetInventoryItemName(InventoryItem? item, UiLabel label)
	{
	}
}