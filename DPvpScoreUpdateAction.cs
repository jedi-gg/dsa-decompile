using Il2CppDummyDll;
using Serverproto;
using System;

public struct DPvpScoreUpdateAction
{
	[FieldOffset(Offset="0x0")]
	public readonly Serverproto.PvpScore PvpScore;

	[Address(RVA="0xEFEB8C", Offset="0xEFEB8C", VA="0xEFEB8C")]
	public DPvpScoreUpdateAction(Serverproto.PvpScore pvpScore)
	{
	}
}