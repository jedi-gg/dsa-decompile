using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleBuffIconUiData : ScriptableObject
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private BattleBuffIconUiDatum[] _iconData;

	[FieldOffset(Offset="0x20")]
	private Dictionary<uint, BattleBuffIconUiDatum> _datumLookup;

	[Address(RVA="0x1138058", Offset="0x1138058", VA="0x1138058")]
	public BattleBuffIconUiData()
	{
	}

	[Address(RVA="0x1137F30", Offset="0x1137F30", VA="0x1137F30")]
	public BattleBuffIconUiDatum Get(uint effectType)
	{
		return null;
	}

	[Address(RVA="0x1137480", Offset="0x1137480", VA="0x1137480")]
	public BattleBuffIconUiDatum[] GetAllData()
	{
		return null;
	}

	[Address(RVA="0x1137E78", Offset="0x1137E78", VA="0x1137E78")]
	public BattleBuffIconUiDatum GetFromLocKeyName(string locKeyName)
	{
		return null;
	}
}