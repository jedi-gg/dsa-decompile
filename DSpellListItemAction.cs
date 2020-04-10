using Il2CppDummyDll;
using System;

public struct DSpellListItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong SpellDefinitionId;

	[FieldOffset(Offset="0x8")]
	public readonly object OwnerIdentifier;

	[Address(RVA="0xEFF760", Offset="0xEFF760", VA="0xEFF760")]
	public DSpellListItemAction(ulong spellDefinitionId, object ownerIdentifier)
	{
	}
}