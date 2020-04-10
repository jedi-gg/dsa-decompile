using Il2CppDummyDll;
using System;

public struct DRevSdkShowVgp
{
	[FieldOffset(Offset="0x0")]
	public readonly string Placement;

	[FieldOffset(Offset="0x8")]
	public readonly bool AllowGameStateRedirection;

	[Address(RVA="0xEFEE08", Offset="0xEFEE08", VA="0xEFEE08")]
	public DRevSdkShowVgp(string placement, bool allowGameStateRedirection = true)
	{
	}
}