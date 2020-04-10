using Il2CppDummyDll;
using Serverproto;
using System;

public struct DHomePvpResponse
{
	[FieldOffset(Offset="0x0")]
	public readonly HomePvpResponse PvpResponse;

	[Address(RVA="0xEFD918", Offset="0xEFD918", VA="0xEFD918")]
	public DHomePvpResponse(HomePvpResponse pvpResponse)
	{
	}
}