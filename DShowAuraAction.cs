using Gamedata;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;

public struct DShowAuraAction
{
	[FieldOffset(Offset="0x0")]
	public Gamedata.Aura Aura;

	[FieldOffset(Offset="0x10")]
	public RectTransform Position;

	[FieldOffset(Offset="0x18")]
	public BattleLib_Bootstrap.Types.Unit Unit;

	[FieldOffset(Offset="0x20")]
	public int AbilityId;

	[Address(RVA="0xEFF42C", Offset="0xEFF42C", VA="0xEFF42C")]
	public DShowAuraAction(Gamedata.Aura aura, RectTransform position, BattleLib_Bootstrap.Types.Unit unit, int abilityId)
	{
	}
}