using Gamedata;
using Il2CppDummyDll;
using System;

public class SpellUpgradeViewModel : AAbilityUpgradeViewModel
{
	[FieldOffset(Offset="0x30")]
	public Spell? SpellDef;

	[FieldOffset(Offset="0x48")]
	public bool SpellIsOwned;

	[Address(RVA="0x1246674", Offset="0x1246674", VA="0x1246674")]
	public SpellUpgradeViewModel()
	{
	}
}