using Il2CppDummyDll;
using System;

public struct DEmphasizeUnitAbilityStrength
{
	[FieldOffset(Offset="0x0")]
	public readonly byte TargetUnitId;

	[FieldOffset(Offset="0x4")]
	public readonly BattleAbilityStrength Strength;

	[Address(RVA="0xF04F58", Offset="0xF04F58", VA="0xF04F58")]
	public DEmphasizeUnitAbilityStrength(byte targetUnitId, BattleAbilityStrength strength)
	{
	}
}