using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum PurchaseLimitGranularity
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061C3C", Offset="0x1061C3C")]
		[FieldOffset(Offset="0x0")]
		InvalidPurchaseLimitGranularity,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061C74", Offset="0x1061C74")]
		[FieldOffset(Offset="0x0")]
		DayPurchaseLimitGranularity,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061CAC", Offset="0x1061CAC")]
		[FieldOffset(Offset="0x0")]
		LifetimePurchaseLimitGranularity
	}
}