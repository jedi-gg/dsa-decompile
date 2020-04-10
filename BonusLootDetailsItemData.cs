using Il2CppDummyDll;
using System;

public class BonusLootDetailsItemData
{
	[FieldOffset(Offset="0x10")]
	public readonly string Title;

	[FieldOffset(Offset="0x18")]
	public readonly string Description;

	[Address(RVA="0x111F1F4", Offset="0x111F1F4", VA="0x111F1F4")]
	public BonusLootDetailsItemData(string title, string description)
	{
	}
}