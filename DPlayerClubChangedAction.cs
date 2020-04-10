using Il2CppDummyDll;
using Serverproto;
using System;

public struct DPlayerClubChangedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly Serverproto.Club Club;

	[Address(RVA="0xEFE894", Offset="0xEFE894", VA="0xEFE894")]
	public DPlayerClubChangedAction(Serverproto.Club club)
	{
	}
}