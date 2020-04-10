using Il2CppDummyDll;
using System;
using UnityEngine;

[Serializable]
public class BattleBuffIconUiDatum
{
	[FieldOffset(Offset="0x10")]
	public string Name;

	[FieldOffset(Offset="0x18")]
	public uint EffectIconType;

	[FieldOffset(Offset="0x1C")]
	public bool Beneficial;

	[FieldOffset(Offset="0x20")]
	public UnityEngine.Color Color;

	[FieldOffset(Offset="0x30")]
	public Sprite Image;

	[FieldOffset(Offset="0x38")]
	public string LocKeyName;

	[FieldOffset(Offset="0x40")]
	public string LocKeyDescription;

	[FieldOffset(Offset="0x48")]
	public int SortOrder;

	[Address(RVA="0x11380C8", Offset="0x11380C8", VA="0x11380C8")]
	public BattleBuffIconUiDatum()
	{
	}
}