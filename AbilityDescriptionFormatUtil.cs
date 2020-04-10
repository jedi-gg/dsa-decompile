using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class AbilityDescriptionFormatUtil
{
	[FieldOffset(Offset="0x0")]
	private const int MAX_BALANCE_VAR_TOKENS = 20;

	[FieldOffset(Offset="0x0")]
	private static object[] s_balanceVarNumberBuffer;

	[Attribute(Name="InjectAttribute", RVA="0x105FA80", Offset="0x105FA80")]
	[FieldOffset(Offset="0x10")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105FA90", Offset="0x105FA90")]
	[FieldOffset(Offset="0x18")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105FAA0", Offset="0x105FAA0")]
	[FieldOffset(Offset="0x20")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x28")]
	private Dictionary<string, string> _cachedDescriptions;

	[Address(RVA="0x1153B88", Offset="0x1153B88", VA="0x1153B88")]
	static AbilityDescriptionFormatUtil()
	{
	}

	[Address(RVA="0x1153B18", Offset="0x1153B18", VA="0x1153B18")]
	public AbilityDescriptionFormatUtil()
	{
	}

	[Address(RVA="0x1151C7C", Offset="0x1151C7C", VA="0x1151C7C")]
	public void ClearCachedDescriptions()
	{
	}

	[Address(RVA="0x11521A8", Offset="0x11521A8", VA="0x11521A8")]
	private float GetBalanceVarValue(UnitAbility? ability, int balanceVarIndex, Gamedata.Unit? unitDef, Serverproto.Unit unit)
	{
		return new float();
	}

	[Address(RVA="0x1152EA8", Offset="0x1152EA8", VA="0x1152EA8")]
	private float GetBalanceVarValue(UnitAbility? abilityDef, int balanceVarIndex, Gamedata.Unit? unitDef, BattleLib_Bootstrap.Types.Unit unit, BattleLib_Bootstrap.Types.Ability ability)
	{
		return new float();
	}

	[Address(RVA="0x11539F0", Offset="0x11539F0", VA="0x11539F0")]
	private float GetBalanceVarValue(int balanceVarIndex, Gamedata.Spell? spellDef, Serverproto.Spell spell)
	{
		return new float();
	}

	[Address(RVA="0x1153618", Offset="0x1153618", VA="0x1153618")]
	public void SetSpellDescription(UiLabel label, string descriptionKey, ulong spellId)
	{
	}

	[Address(RVA="0x1151CDC", Offset="0x1151CDC", VA="0x1151CDC")]
	public void SetUnitAbilityDescription(UiLabel label, string descriptionKey, ulong unitId, int abilityId)
	{
	}

	[Address(RVA="0x1152940", Offset="0x1152940", VA="0x1152940")]
	public void SetUnitAbilityDescription(UiLabel label, BattleLib_Bootstrap.Types.Unit unit, int abilityId)
	{
	}
}