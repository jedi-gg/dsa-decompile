using Il2CppDummyDll;
using Serverproto;
using System;

public struct DBattleEncounterAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleEncounterAction.Type ActionType;

	[FieldOffset(Offset="0x4")]
	public readonly int EncounterIndex;

	[FieldOffset(Offset="0x8")]
	public readonly BattleLib_Bootstrap.Types.Encounter Encounter;

	[FieldOffset(Offset="0x10")]
	public readonly BattleLib_Bootstrap.Types.Encounter NextEncounter;

	[Address(RVA="0xF02BEC", Offset="0xF02BEC", VA="0xF02BEC")]
	public DBattleEncounterAction(DBattleEncounterAction.Type actionType, int encounterIndex, BattleLib_Bootstrap.Types.Encounter encounter, BattleLib_Bootstrap.Types.Encounter nextEncounter)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Started,
		[FieldOffset(Offset="0x0")]
		Ended,
		[FieldOffset(Offset="0x0")]
		SpawnedNotYetStarted
	}
}