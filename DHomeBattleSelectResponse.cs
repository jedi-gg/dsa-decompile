using Il2CppDummyDll;
using Serverproto;
using System;

public struct DHomeBattleSelectResponse
{
	[FieldOffset(Offset="0x0")]
	public readonly HomeBattleSelectResponse BattleSelectResponse;

	[Address(RVA="0xEFD5F4", Offset="0xEFD5F4", VA="0xEFD5F4")]
	public DHomeBattleSelectResponse(HomeBattleSelectResponse battleSelectResponse)
	{
	}
}