using Gamedata;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClubWarHealthBar : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private UiLabel _idLabel;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private UiLabel _idLabelHome;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Image _healthBarFill;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private Image _pip;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private int _maxPips;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private UiColorPalette _colorPalette;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private GameObject _homeBaseRoot;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private GameObject _normalNodeRoot;

	[FieldOffset(Offset="0x58")]
	private List<Image> _pips;

	[Address(RVA="0x14CF574", Offset="0x14CF574", VA="0x14CF574")]
	public ClubWarHealthBar()
	{
	}

	[Address(RVA="0x14CF260", Offset="0x14CF260", VA="0x14CF260")]
	public void SetDefenderCounts(ulong numDefeated, ulong totalDefenders)
	{
	}

	[Address(RVA="0x14CF0F4", Offset="0x14CF0F4", VA="0x14CF0F4")]
	public void SetIdLabel(string id)
	{
	}

	[Address(RVA="0x14CF504", Offset="0x14CF504", VA="0x14CF504")]
	public void SetNodeType(ClubWarNodeType nodeType)
	{
	}

	[Address(RVA="0x14CF2E0", Offset="0x14CF2E0", VA="0x14CF2E0")]
	private void SetPipCount(int pipCount)
	{
	}

	[Address(RVA="0x14CF160", Offset="0x14CF160", VA="0x14CF160")]
	public void SetTeamColor(ClubWarTeam team)
	{
	}
}