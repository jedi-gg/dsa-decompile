using Il2CppDummyDll;
using Serverproto;
using System;
using System.Runtime.CompilerServices;

public static class BattleExtensions
{
	[Address(RVA="0x11455F4", Offset="0x11455F4", VA="0x11455F4")]
	public static BattleLib_Bootstrap.Types.Spell GetSpell(BattleLib_Bootstrap.Types.Player player, DBattleAbilityId battleAbilityId)
	{
		return null;
	}

	[Address(RVA="0x114530C", Offset="0x114530C", VA="0x114530C")]
	public static BattleLib_Bootstrap.Types.Ability GetSpellAbility(BattleLib_Bootstrap.Types.Player player, byte abilityId)
	{
		return null;
	}

	[Address(RVA="0x11458CC", Offset="0x11458CC", VA="0x11458CC")]
	public static bool Matches(BattleLib_UpdateResult.Types.AbilityCard abilityCard, DBattleAbilityId abilityId)
	{
		return new bool();
	}

	[Address(RVA="0x1145960", Offset="0x1145960", VA="0x1145960")]
	public static bool Matches(BattleLib_UpdateResult.Types.AbilityCard abilityCard, BattleLib_UpdateResult.Types.AbilityCard other)
	{
		return new bool();
	}
}