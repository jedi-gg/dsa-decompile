using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum ResponseCode
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062F9C", Offset="0x1062F9C")]
		[FieldOffset(Offset="0x0")]
		Ok = 0,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062FD4", Offset="0x1062FD4")]
		[FieldOffset(Offset="0x0")]
		Error = 2001,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106300C", Offset="0x106300C")]
		[FieldOffset(Offset="0x0")]
		InvalidClientVersion = 2002,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1063044", Offset="0x1063044")]
		[FieldOffset(Offset="0x0")]
		NotFound = 2003,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106307C", Offset="0x106307C")]
		[FieldOffset(Offset="0x0")]
		Unauthorized = 2004,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10630B4", Offset="0x10630B4")]
		[FieldOffset(Offset="0x0")]
		BadRequest = 2005,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10630EC", Offset="0x10630EC")]
		[FieldOffset(Offset="0x0")]
		DuplicateName = 2006,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1063124", Offset="0x1063124")]
		[FieldOffset(Offset="0x0")]
		ClubIsFull = 2007,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106315C", Offset="0x106315C")]
		[FieldOffset(Offset="0x0")]
		ClubInviteAlreadyExists = 2008,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1063194", Offset="0x1063194")]
		[FieldOffset(Offset="0x0")]
		ClubInvitesAreClosed = 2009,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10631CC", Offset="0x10631CC")]
		[FieldOffset(Offset="0x0")]
		ClubJoinIsLocked = 2010,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1063204", Offset="0x1063204")]
		[FieldOffset(Offset="0x0")]
		PlayerIsAlreadyInClub = 2011,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106323C", Offset="0x106323C")]
		[FieldOffset(Offset="0x0")]
		InsufficientPlayerLevel = 2012,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1063274", Offset="0x1063274")]
		[FieldOffset(Offset="0x0")]
		TemporaryBan = 2013,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10632AC", Offset="0x10632AC")]
		[FieldOffset(Offset="0x0")]
		PermanentBan = 2014,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10632E4", Offset="0x10632E4")]
		[FieldOffset(Offset="0x0")]
		InvalidAuthToken = 2015,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106331C", Offset="0x106331C")]
		[FieldOffset(Offset="0x0")]
		KothPlayerRankHasChanged = 2016,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1063354", Offset="0x1063354")]
		[FieldOffset(Offset="0x0")]
		KothOpponentIsUnavailable = 2017,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106338C", Offset="0x106338C")]
		[FieldOffset(Offset="0x0")]
		KothAttackerIsUnavailable = 2018,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10633C4", Offset="0x10633C4")]
		[FieldOffset(Offset="0x0")]
		ClubWarInvalidPhase = 2019,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10633FC", Offset="0x10633FC")]
		[FieldOffset(Offset="0x0")]
		ClubWarDefenseSlotNotEmpty = 2020,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1063434", Offset="0x1063434")]
		[FieldOffset(Offset="0x0")]
		ClubWarDefenseNotAvailable = 2021,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106346C", Offset="0x106346C")]
		[FieldOffset(Offset="0x0")]
		ClubWarNodeOwnerChanged = 2022,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10634A4", Offset="0x10634A4")]
		[FieldOffset(Offset="0x0")]
		ClubWarDefenseAlreadyDefeated = 2023,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10634DC", Offset="0x10634DC")]
		[FieldOffset(Offset="0x0")]
		NoClub = 2024,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1063514", Offset="0x1063514")]
		[FieldOffset(Offset="0x0")]
		PlayerAlreadyClaimedClubReward = 2025,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106354C", Offset="0x106354C")]
		[FieldOffset(Offset="0x0")]
		ClubWarNodeDefenseAlreadyUnderAttack = 2026,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1063584", Offset="0x1063584")]
		[FieldOffset(Offset="0x0")]
		ClubDonationFulfilled = 2027,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10635BC", Offset="0x10635BC")]
		[FieldOffset(Offset="0x0")]
		RequestedFriendHasFullFriendList = 2028,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10635F4", Offset="0x10635F4")]
		[FieldOffset(Offset="0x0")]
		RequestedFriendSelf = 2029,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106362C", Offset="0x106362C")]
		[FieldOffset(Offset="0x0")]
		RequestedFriendInviteExpired = 2030,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1063664", Offset="0x1063664")]
		[FieldOffset(Offset="0x0")]
		RequestedFriendHasPendingInvite = 2031,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106369C", Offset="0x106369C")]
		[FieldOffset(Offset="0x0")]
		RequestedFriendshipExist = 2032,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10636D4", Offset="0x10636D4")]
		[FieldOffset(Offset="0x0")]
		PlayerHasFullFriendList = 2033,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106370C", Offset="0x106370C")]
		[FieldOffset(Offset="0x0")]
		KothOpponentSquadChanged = 2034,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1063744", Offset="0x1063744")]
		[FieldOffset(Offset="0x0")]
		ChatMessageThrottled = 2035
	}
}