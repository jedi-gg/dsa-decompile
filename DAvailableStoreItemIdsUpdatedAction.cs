using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public struct DAvailableStoreItemIdsUpdatedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly IList<ulong> StoreItemIds;

	[Address(RVA="0xF027FC", Offset="0xF027FC", VA="0xF027FC")]
	public DAvailableStoreItemIdsUpdatedAction(IList<ulong> storeItemIds)
	{
	}
}