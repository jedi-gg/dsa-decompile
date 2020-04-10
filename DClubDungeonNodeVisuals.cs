using Gamedata;
using Il2CppDummyDll;
using System;
using UnityEngine;

[Serializable]
public struct DClubDungeonNodeVisuals
{
	[FieldOffset(Offset="0x0")]
	[SerializeField]
	private Sprite _normalSprite;

	[FieldOffset(Offset="0x8")]
	[SerializeField]
	private Sprite _normalSelectedSprite;

	[FieldOffset(Offset="0x10")]
	[SerializeField]
	private Sprite _miniBossSprite;

	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private Sprite _miniBossSelectedSprite;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private Sprite _bossSprite;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Sprite _bossSelectedSprite;

	[Address(RVA="0xF03830", Offset="0xF03830", VA="0xF03830")]
	public Sprite GetSelectedSprite(ClubDungeonNodeType nodeType)
	{
		return null;
	}

	[Address(RVA="0xF03808", Offset="0xF03808", VA="0xF03808")]
	public Sprite GetSprite(ClubDungeonNodeType nodeType)
	{
		return null;
	}
}