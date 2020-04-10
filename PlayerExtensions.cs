using Il2CppDummyDll;
using Serverproto;
using System;
using System.Runtime.CompilerServices;
using TMPro;

public static class PlayerExtensions
{
	[FieldOffset(Offset="0x0")]
	public const int MIN_USERNAME_LENGTH = 4;

	[FieldOffset(Offset="0x0")]
	public const int MAX_USERNAME_LENGTH = 14;

	[Address(RVA="0x133AE40", Offset="0x133AE40", VA="0x133AE40")]
	public static string CreatePrettyPlayerIdString(Player player)
	{
		return null;
	}

	[Address(RVA="0x133B0D4", Offset="0x133B0D4", VA="0x133B0D4")]
	public static int GetEnergyGenerateBonusCountRemaining(Player player, ulong energyItemId, uint generateFrequencySeconds)
	{
		return new int();
	}

	[Address(RVA="0x133055C", Offset="0x133055C", VA="0x133055C")]
	public static long GetItemCount(Player player, ulong contentId)
	{
		return new long();
	}

	[Address(RVA="0x133B0B8", Offset="0x133B0B8", VA="0x133B0B8")]
	public static bool IsEnergyGenerateBonusActive(Player player, ulong energyItemId, uint generateFrequencySeconds)
	{
		return new bool();
	}

	[Address(RVA="0x132D288", Offset="0x132D288", VA="0x132D288")]
	public static bool IsInAnyClub(Player player)
	{
		return new bool();
	}

	[Address(RVA="0x133ADD0", Offset="0x133ADD0", VA="0x133ADD0")]
	public static bool IsUsernameValid(string name)
	{
		return new bool();
	}

	[Address(RVA="0x133AF84", Offset="0x133AF84", VA="0x133AF84")]
	public static char UsernameInputValidator(TMP_FontAsset fontAsset, string text, int charIndex, char addedChar)
	{
		return new char();
	}
}