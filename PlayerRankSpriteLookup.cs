using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRankSpriteLookup : ScriptableObject
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private List<Sprite> _rankSprites;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private Sprite _emptyRankSprite;

	[Address(RVA="0x13443D8", Offset="0x13443D8", VA="0x13443D8")]
	public PlayerRankSpriteLookup()
	{
	}

	[Address(RVA="0x133DA24", Offset="0x133DA24", VA="0x133DA24")]
	public Sprite GetRankSprite(int rank)
	{
		return null;
	}
}