using Gamedata;
using Il2CppDummyDll;
using System;

public class SpellCardPromoteProgressTracker : ASpellCardProgressTracker
{
	[FieldOffset(Offset="0x20")]
	public readonly long TokensOwned;

	[FieldOffset(Offset="0x28")]
	public readonly long TokensRequired;

	[FieldOffset(Offset="0x30")]
	public readonly long TokenCost;

	[FieldOffset(Offset="0x38")]
	public readonly bool UnlocksSpell;

	[Address(RVA="0x1241794", Offset="0x1241794", VA="0x1241794")]
	public SpellCardPromoteProgressTracker([Attribute(Name="TupleElementNamesAttribute", RVA="0x1090F94", Offset="0x1090F94")] ValueTuple<Spell, long, long, long> data, bool unlocksSpell)
	{
	}
}