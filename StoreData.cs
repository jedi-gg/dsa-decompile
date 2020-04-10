using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class StoreData
{
	[FieldOffset(Offset="0x10")]
	public List<StoreTabData> TabData;

	[Address(RVA="0x122BEF0", Offset="0x122BEF0", VA="0x122BEF0")]
	public StoreData(StoreResponse response, Func<string, bool> itemIapValidityChecker)
	{
	}

	[Address(RVA="0x122D4B4", Offset="0x122D4B4", VA="0x122D4B4")]
	public bool CanPurchaseItem(ulong itemId)
	{
		return new bool();
	}

	[Address(RVA="0x122B4C0", Offset="0x122B4C0", VA="0x122B4C0")]
	public StoreItemData GetItem(ulong itemId)
	{
		return null;
	}

	[Address(RVA="0x122B138", Offset="0x122B138", VA="0x122B138")]
	public StoreTabData GetTab(ulong tabId)
	{
		return null;
	}

	[Address(RVA="0x122A8B4", Offset="0x122A8B4", VA="0x122A8B4")]
	public int GetTabIndex(ulong tabId)
	{
		return new int();
	}

	[Address(RVA="0x122B7A8", Offset="0x122B7A8", VA="0x122B7A8")]
	public int GetTabIndexWithItem(ulong itemId)
	{
		return new int();
	}

	[Address(RVA="0x1227E18", Offset="0x1227E18", VA="0x1227E18")]
	public bool RemoveExpiredItems()
	{
		return new bool();
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CD3C", Offset="0x104CD3C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static StoreData.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Comparison<StoreTabData> <>9__1_0;

		[Address(RVA="0x122D620", Offset="0x122D620", VA="0x122D620")]
		static <>c()
		{
		}

		[Address(RVA="0x122D684", Offset="0x122D684", VA="0x122D684")]
		public <>c()
		{
		}

		[Address(RVA="0x122D68C", Offset="0x122D68C", VA="0x122D68C")]
		internal int <.ctor>b__1_0(StoreTabData a, StoreTabData b)
		{
			return new int();
		}
	}
}