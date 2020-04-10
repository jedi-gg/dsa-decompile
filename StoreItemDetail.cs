using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class StoreItemDetail
{
	[FieldOffset(Offset="0x10")]
	public string TitleText;

	[FieldOffset(Offset="0x18")]
	public string ShortDescriptionText;

	[FieldOffset(Offset="0x20")]
	public string DescriptionText;

	[FieldOffset(Offset="0x28")]
	public List<StoreItemDropDetail> GuaranteedItems;

	[FieldOffset(Offset="0x30")]
	public List<StoreItemDropDetail> ChanceItems;

	[FieldOffset(Offset="0x38")]
	public List<StoreItemGrant> Grants;

	[Address(RVA="0x1232244", Offset="0x1232244", VA="0x1232244")]
	public StoreItemDetail()
	{
	}
}