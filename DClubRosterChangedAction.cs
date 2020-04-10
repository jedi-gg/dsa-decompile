using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClubRosterChangedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly Serverproto.Club Club;

	[Address(RVA="0xF040B4", Offset="0xF040B4", VA="0xF040B4")]
	public DClubRosterChangedAction(Serverproto.Club club)
	{
	}
}