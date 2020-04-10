using Il2CppDummyDll;
using System;

public struct DBattleAbilityCastResultAction
{
	[FieldOffset(Offset="0x0")]
	public readonly bool Success;

	[FieldOffset(Offset="0x4")]
	public readonly DBattleAbilityId BattleAbilityId;

	[FieldOffset(Offset="0x14")]
	public readonly uint FailureCode;

	[Address(RVA="0xF028EC", Offset="0xF028EC", VA="0xF028EC")]
	public DBattleAbilityCastResultAction(bool success, DBattleAbilityId battleAbilityId, uint failureCode = 0)
	{
	}
}