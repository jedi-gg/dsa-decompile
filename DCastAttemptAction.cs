using Il2CppDummyDll;
using System;

public struct DCastAttemptAction
{
	[FieldOffset(Offset="0x0")]
	public readonly CastAttemptStatus Status;

	[FieldOffset(Offset="0x4")]
	public readonly byte SourceId;

	[FieldOffset(Offset="0x5")]
	public readonly byte AbilityId;

	[FieldOffset(Offset="0x8")]
	public readonly AbilitySourceType SourceType;

	[FieldOffset(Offset="0xC")]
	public readonly uint FailureCode;

	[FieldOffset(Offset="0x10")]
	public readonly uint CooldownRemaining;

	[Address(RVA="0xF03350", Offset="0xF03350", VA="0xF03350")]
	public DCastAttemptAction(CastAttemptStatus status, byte sourceId, byte abilityId, AbilitySourceType sourceType, uint failureCode = 0, uint cooldownRemaining = 0)
	{
	}
}