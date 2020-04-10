using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi.SavedGame
{
	public enum ConflictResolutionStrategy
	{
		[FieldOffset(Offset="0x0")]
		UseLongestPlaytime,
		[FieldOffset(Offset="0x0")]
		UseOriginal,
		[FieldOffset(Offset="0x0")]
		UseUnmerged,
		[FieldOffset(Offset="0x0")]
		UseManual,
		[FieldOffset(Offset="0x0")]
		UseLastKnownGood,
		[FieldOffset(Offset="0x0")]
		UseMostRecentlySaved
	}
}