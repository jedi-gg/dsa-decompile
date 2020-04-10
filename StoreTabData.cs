using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class StoreTabData
{
	[FieldOffset(Offset="0x10")]
	public readonly StoreTab Tab;

	[FieldOffset(Offset="0x18")]
	public List<StoreItemData> ItemData;

	[FieldOffset(Offset="0x20")]
	public StoreItemData ShowcaseItem;

	[FieldOffset(Offset="0x28")]
	public Texture IconTexture;

	[Address(RVA="0x1316194", Offset="0x1316194", VA="0x1316194")]
	public StoreTabData(StoreTab tab)
	{
	}
}