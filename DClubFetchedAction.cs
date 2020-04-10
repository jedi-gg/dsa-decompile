using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClubFetchedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly Serverproto.Club Club;

	[Address(RVA="0xF03A54", Offset="0xF03A54", VA="0xF03A54")]
	public DClubFetchedAction(Serverproto.Club club)
	{
	}
}