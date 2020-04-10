using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public struct DSpecialOfferDynamicMessageAction
{
	[FieldOffset(Offset="0x0")]
	public readonly IList<StoreItem> SpecialOffers;

	[Address(RVA="0xEFF62C", Offset="0xEFF62C", VA="0xEFF62C")]
	public DSpecialOfferDynamicMessageAction(IList<StoreItem> specialOffers)
	{
	}
}