using Il2CppDummyDll;
using Serverproto;
using System;

public struct DPlayerChangeAction
{
	[FieldOffset(Offset="0x0")]
	public readonly Serverproto.Player Player;

	[Address(RVA="0xEFE840", Offset="0xEFE840", VA="0xEFE840")]
	public DPlayerChangeAction(Serverproto.Player player)
	{
	}
}