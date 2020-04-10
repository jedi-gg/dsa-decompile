using Il2CppDummyDll;
using System;

public struct DCampaignNodeDetailsBattleRestrictionAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DCampaignNodeDetailsBattleRestrictionAction.Type RestrictionType;

	[FieldOffset(Offset="0x8")]
	public readonly ulong DefinitionId;

	[Address(RVA="0xF03258", Offset="0xF03258", VA="0xF03258")]
	public DCampaignNodeDetailsBattleRestrictionAction(DCampaignNodeDetailsBattleRestrictionAction.Type restrictionType, ulong definitionId)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Unit,
		[FieldOffset(Offset="0x0")]
		Spell
	}
}