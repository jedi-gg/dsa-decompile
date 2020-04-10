using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public enum PurchaseLimitGranularity : sbyte
	{
		[FieldOffset(Offset="0x0")]
		INVALID,
		[FieldOffset(Offset="0x0")]
		Day,
		[FieldOffset(Offset="0x0")]
		Lifetime,
		[FieldOffset(Offset="0x0")]
		Occasional
	}
}