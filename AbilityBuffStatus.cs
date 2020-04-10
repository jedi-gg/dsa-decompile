using Il2CppDummyDll;
using System;

[Flags]
public enum AbilityBuffStatus
{
	[FieldOffset(Offset="0x0")]
	None = 0,
	[FieldOffset(Offset="0x0")]
	CritChanceUp = 1,
	[FieldOffset(Offset="0x0")]
	CritChanceDown = 2,
	[FieldOffset(Offset="0x0")]
	CritPowerUp = 4,
	[FieldOffset(Offset="0x0")]
	CritPowerDown = 8,
	[FieldOffset(Offset="0x0")]
	OffenseUp = 16,
	[FieldOffset(Offset="0x0")]
	OffenseDown = 32,
	[FieldOffset(Offset="0x0")]
	Tactics = 64
}