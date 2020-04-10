using Il2CppDummyDll;
using Serverproto;
using System;
using System.Runtime.CompilerServices;
using TMPro;

public static class ClubExtensions
{
	[FieldOffset(Offset="0x0")]
	public const int MIN_CLUB_NAME_LENGTH = 4;

	[FieldOffset(Offset="0x0")]
	public const int MAX_CLUB_NAME_LENGTH = 64;

	[FieldOffset(Offset="0x0")]
	public const int MAX_CLUB_DESCRIPTION_LENGTH = 256;

	[FieldOffset(Offset="0x0")]
	private readonly static ClubRole s_minimumRoleToSendInvites;

	[FieldOffset(Offset="0x4")]
	private readonly static ClubRole s_minimumRoleToManageInvites;

	[FieldOffset(Offset="0x8")]
	private readonly static ClubRole s_minimumRoleToManageSettings;

	[FieldOffset(Offset="0xC")]
	private readonly static ClubRole s_minimumRoleToPromoteDemote;

	[FieldOffset(Offset="0x10")]
	private readonly static ClubRole s_minimumRoleToKick;

	[FieldOffset(Offset="0x14")]
	private readonly static ClubRole s_minimumRoleToSetClubWarNodeTarget;

	[FieldOffset(Offset="0x18")]
	private readonly static ClubRole s_minimumRoleToMoveClubWarSquad;

	[Address(RVA="0x11B67FC", Offset="0x11B67FC", VA="0x11B67FC")]
	static ClubExtensions()
	{
	}

	[Address(RVA="0x11B6518", Offset="0x11B6518", VA="0x11B6518")]
	public static bool AllowsDemoting(ClubRole role, ClubRole otherRole)
	{
		return new bool();
	}

	[Address(RVA="0x11B65B4", Offset="0x11B65B4", VA="0x11B65B4")]
	public static bool AllowsKicking(ClubRole role, ClubRole otherRole)
	{
		return new bool();
	}

	[Address(RVA="0x11B63A4", Offset="0x11B63A4", VA="0x11B63A4")]
	public static bool AllowsManagingInvites(ClubRole role)
	{
		return new bool();
	}

	[Address(RVA="0x11B6418", Offset="0x11B6418", VA="0x11B6418")]
	public static bool AllowsManagingSettings(ClubRole role)
	{
		return new bool();
	}

	[Address(RVA="0x11B66B4", Offset="0x11B66B4", VA="0x11B66B4")]
	public static bool AllowsMoveClubWarSquad(ClubRole role)
	{
		return new bool();
	}

	[Address(RVA="0x11B648C", Offset="0x11B648C", VA="0x11B648C")]
	public static bool AllowsPromoting(ClubRole role, ClubRole otherRole)
	{
		return new bool();
	}

	[Address(RVA="0x11B6330", Offset="0x11B6330", VA="0x11B6330")]
	public static bool AllowsSendingInvites(ClubRole role)
	{
		return new bool();
	}

	[Address(RVA="0x11B6640", Offset="0x11B6640", VA="0x11B6640")]
	public static bool AllowsSetClubWarNodeTarget(ClubRole role)
	{
		return new bool();
	}

	[Address(RVA="0x11B624C", Offset="0x11B624C", VA="0x11B624C")]
	public static char ClubDescriptionInputValidator(TMP_FontAsset fontAsset, string text, int charIndex, char addedChar)
	{
		return new char();
	}

	[Address(RVA="0x11B6140", Offset="0x11B6140", VA="0x11B6140")]
	public static char ClubNameInputValidator(TMP_FontAsset fontAsset, string text, int charIndex, char addedChar)
	{
		return new char();
	}

	[Address(RVA="0x11B6728", Offset="0x11B6728", VA="0x11B6728")]
	public static string GetLocalizationKey(ClubInvitePolicy invitePolicy)
	{
		return null;
	}

	[Address(RVA="0x11B6790", Offset="0x11B6790", VA="0x11B6790")]
	public static string GetLocalizationKey(ClubRole role)
	{
		return null;
	}
}