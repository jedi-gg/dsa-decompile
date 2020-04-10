using Gamedata;
using Il2CppDummyDll;
using System;

public abstract class ASpellCardProgressTracker : ACardProgressTracker
{
	[FieldOffset(Offset="0x10")]
	public readonly Spell SpellDef;

	[Address(RVA="0x10F4EC8", Offset="0x10F4EC8", VA="0x10F4EC8")]
	public ASpellCardProgressTracker(Spell spellDef)
	{
	}
}