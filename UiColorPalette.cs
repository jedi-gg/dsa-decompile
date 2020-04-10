using Gamedata;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class UiColorPalette : ScriptableObject
{
	[FieldOffset(Offset="0x18")]
	public UnityEngine.Color EvenLeaderboardRowColor;

	[FieldOffset(Offset="0x28")]
	public UnityEngine.Color OddLeaderboardRowColor;

	[FieldOffset(Offset="0x38")]
	public UnityEngine.Color PlayerLeaderboardRowColor;

	[FieldOffset(Offset="0x48")]
	public UnityEngine.Color SelectedRowColor;

	[FieldOffset(Offset="0x58")]
	public UnityEngine.Color IncomingMessageColor;

	[FieldOffset(Offset="0x68")]
	public UnityEngine.Color OutgoingMessageColor;

	[FieldOffset(Offset="0x78")]
	public UnityEngine.Color AdminMessageColor;

	[FieldOffset(Offset="0x88")]
	public UnityEngine.Color ClubWarTeamAColor;

	[FieldOffset(Offset="0x98")]
	public UnityEngine.Color ClubWarTeamBColor;

	[FieldOffset(Offset="0xA8")]
	public UnityEngine.Color ClubWarTeamCColor;

	[Address(RVA="0x1585204", Offset="0x1585204", VA="0x1585204")]
	public UiColorPalette()
	{
	}

	[Address(RVA="0x15851B8", Offset="0x15851B8", VA="0x15851B8")]
	public UnityEngine.Color GetColorForClubWarTeam(ClubWarTeam team)
	{
		return new UnityEngine.Color();
	}
}