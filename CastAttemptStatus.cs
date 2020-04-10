using Il2CppDummyDll;
using System;

public enum CastAttemptStatus
{
	[FieldOffset(Offset="0x0")]
	Success,
	[FieldOffset(Offset="0x0")]
	GenericFailure,
	[FieldOffset(Offset="0x0")]
	NotEnoughMana,
	[FieldOffset(Offset="0x0")]
	CasterSilenced,
	[FieldOffset(Offset="0x0")]
	CastFailed,
	[FieldOffset(Offset="0x0")]
	AbilityOnCooldown
}