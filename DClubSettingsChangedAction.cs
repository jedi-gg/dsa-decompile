using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClubSettingsChangedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly Serverproto.Club Club;

	[Address(RVA="0xF04108", Offset="0xF04108", VA="0xF04108")]
	public DClubSettingsChangedAction(Serverproto.Club club)
	{
	}
}