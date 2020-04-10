using Il2CppDummyDll;
using System;

public struct DFilterSortListItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly FilterSortListItem.Type Type;

	[FieldOffset(Offset="0x4")]
	public readonly int Index;

	[Address(RVA="0xF05270", Offset="0xF05270", VA="0xF05270")]
	public DFilterSortListItemAction(FilterSortListItem.Type type, int index)
	{
	}
}