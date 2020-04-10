using Il2CppDummyDll;
using Serverproto;
using System;

public class ClubActivityPlayerData
{
	[FieldOffset(Offset="0x10")]
	public readonly PlayerProfileSimple Player;

	[FieldOffset(Offset="0x18")]
	public ulong CurrentValue;

	[Address(RVA="0x1464F50", Offset="0x1464F50", VA="0x1464F50")]
	public ClubActivityPlayerData(PlayerProfileSimple player)
	{
	}
}