using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;

public struct DAbilityCardIconLoadedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly BattleLib_Bootstrap.Types.Ability Ability;

	[FieldOffset(Offset="0x8")]
	public readonly Texture IconTexture;

	[Address(RVA="0xF022DC", Offset="0xF022DC", VA="0xF022DC")]
	public DAbilityCardIconLoadedAction(BattleLib_Bootstrap.Types.Ability ability, Texture iconTexture)
	{
	}
}