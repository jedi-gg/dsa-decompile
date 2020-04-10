using Gamedata;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ClubUtil
{
	[Attribute(Name="InjectAttribute", RVA="0x10566CC", Offset="0x10566CC")]
	[FieldOffset(Offset="0x10")]
	private ClubDomainController _clubDc;

	[Attribute(Name="InjectAttribute", RVA="0x10566DC", Offset="0x10566DC")]
	[FieldOffset(Offset="0x18")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x10566EC", Offset="0x10566EC")]
	[FieldOffset(Offset="0x20")]
	private GamedataDomainController _gamedataDc;

	[Address(RVA="0x12682D4", Offset="0x12682D4", VA="0x12682D4")]
	public ClubUtil()
	{
	}

	[Address(RVA="0x1260FBC", Offset="0x1260FBC", VA="0x1260FBC")]
	public Serverproto.ClubSupportRequest GetClubSupportRequestForLocalPlayer(Serverproto.ClubSupportRequestType requestType)
	{
		return null;
	}

	[Address(RVA="0x1260490", Offset="0x1260490", VA="0x1260490")]
	public static ulong GetJoinClubLockDuration(ulong lockLevel, Constants constants)
	{
		return new ulong();
	}

	[Address(RVA="0x126038C", Offset="0x126038C", VA="0x126038C")]
	public static ulong GetNextJoinClubLockLevel(ulong leftClubTimestamp, ulong currentLockLevel, Constants constants)
	{
		return new ulong();
	}
}