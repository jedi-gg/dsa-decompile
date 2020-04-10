using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClubListItemClickedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly Serverproto.Club Club;

	[FieldOffset(Offset="0x8")]
	public readonly ClubListItem ClickedItem;

	[Address(RVA="0xF03F80", Offset="0xF03F80", VA="0xF03F80")]
	public DClubListItemClickedAction(Serverproto.Club club, ClubListItem clickedItem)
	{
	}
}