using Gamedata;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UnitRarityWidget : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	private readonly static UnityEngine.Color FILLED_COLOR;

	[FieldOffset(Offset="0x10")]
	private readonly static UnityEngine.Color EMPTY_COLOR;

	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private Sprite _emptySprite;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private Sprite _filledSprite;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Image[] _rarityIcons;

	[Address(RVA="0x150C508", Offset="0x150C508", VA="0x150C508")]
	static UnitRarityWidget()
	{
	}

	[Address(RVA="0x150C500", Offset="0x150C500", VA="0x150C500")]
	public UnitRarityWidget()
	{
	}

	[Address(RVA="0x1509BB8", Offset="0x1509BB8", VA="0x1509BB8")]
	public void SetRarity(int rarity)
	{
	}

	[Address(RVA="0x150C480", Offset="0x150C480", VA="0x150C480")]
	public void SetUnit(Serverproto.Unit unit)
	{
	}

	[Address(RVA="0x150C4C0", Offset="0x150C4C0", VA="0x150C4C0")]
	public void SetUnit(Gamedata.Unit unitDef)
	{
	}
}