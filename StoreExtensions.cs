using Il2CppDummyDll;
using Serverproto;
using System;
using System.Runtime.CompilerServices;

public static class StoreExtensions
{
	[FieldOffset(Offset="0x0")]
	private const int PURCHASE_LIMIT_TIMER_BUFFER_S = 1;

	[Address(RVA="0x122BDF8", Offset="0x122BDF8", VA="0x122BDF8")]
	public static bool IsLimited(PurchaseLimits purchaseLimits)
	{
		return new bool();
	}

	[Address(RVA="0x122D3B8", Offset="0x122D3B8", VA="0x122D3B8")]
	public static string PlatformIapProductId(StoreItem storeItem)
	{
		return null;
	}
}