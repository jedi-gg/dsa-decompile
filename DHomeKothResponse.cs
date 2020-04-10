using Il2CppDummyDll;
using Serverproto;
using System;

public struct DHomeKothResponse
{
	[FieldOffset(Offset="0x0")]
	public readonly HomeKothResponse KothResponse;

	[Address(RVA="0xEFD8C4", Offset="0xEFD8C4", VA="0xEFD8C4")]
	public DHomeKothResponse(HomeKothResponse kothResponse)
	{
	}
}