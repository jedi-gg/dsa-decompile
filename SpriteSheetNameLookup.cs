using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

[Attribute(Name="CreateAssetMenuAttribute", RVA="0x1049144", Offset="0x1049144")]
public class SpriteSheetNameLookup : ScriptableObject
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private List<Sprite> _sprites;

	[Address(RVA="0x12480E8", Offset="0x12480E8", VA="0x12480E8")]
	public SpriteSheetNameLookup()
	{
	}

	[Address(RVA="0x1247F9C", Offset="0x1247F9C", VA="0x1247F9C")]
	public Sprite GetSprite(string spriteName)
	{
		return null;
	}
}