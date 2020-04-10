using Il2CppDummyDll;
using System;

public struct DUnitStatListItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly string StatName;

	[FieldOffset(Offset="0x8")]
	public readonly string StatDescription;

	[Address(RVA="0xEFFFC4", Offset="0xEFFFC4", VA="0xEFFFC4")]
	public DUnitStatListItemAction(string statName, string statDescription)
	{
	}
}