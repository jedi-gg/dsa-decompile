using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public enum CardProgressTrackerCategory : sbyte
	{
		[FieldOffset(Offset="0x0")]
		Invalid,
		[FieldOffset(Offset="0x0")]
		UnitUnlock,
		[FieldOffset(Offset="0x0")]
		UnitPromotion,
		[FieldOffset(Offset="0x0")]
		UnitGearUpgrade,
		[FieldOffset(Offset="0x0")]
		UnitAbilityUpgrade,
		[FieldOffset(Offset="0x0")]
		SpellUnlock,
		[FieldOffset(Offset="0x0")]
		SpellPromotion
	}
}