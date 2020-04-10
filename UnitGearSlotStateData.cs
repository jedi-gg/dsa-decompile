using Il2CppDummyDll;
using System;
using UnityEngine;

[Serializable]
public class UnitGearSlotStateData
{
	[FieldOffset(Offset="0x10")]
	public Color EquippedColor;

	[FieldOffset(Offset="0x20")]
	public Color UnequippedColor;

	[FieldOffset(Offset="0x30")]
	public Color CanEquipColor;

	[FieldOffset(Offset="0x40")]
	public Color CanEquipFailsRequirementsColor;

	[FieldOffset(Offset="0x50")]
	public Color CanCraftColor;

	[FieldOffset(Offset="0x60")]
	public Color CanCraftFailsRequirementsColor;

	[FieldOffset(Offset="0x70")]
	public Sprite EquippedSprite;

	[FieldOffset(Offset="0x78")]
	public Sprite CanCraftSprite;

	[FieldOffset(Offset="0x80")]
	public Sprite CanEquipSprite;

	[FieldOffset(Offset="0x88")]
	public Sprite FindSprite;

	[Address(RVA="0x11F4FBC", Offset="0x11F4FBC", VA="0x11F4FBC")]
	public UnitGearSlotStateData()
	{
	}
}