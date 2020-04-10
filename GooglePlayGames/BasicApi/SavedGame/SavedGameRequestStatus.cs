using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi.SavedGame
{
	public enum SavedGameRequestStatus
	{
		[FieldOffset(Offset="0x0")]
		BadInputError = -4,
		[FieldOffset(Offset="0x0")]
		AuthenticationError = -3,
		[FieldOffset(Offset="0x0")]
		InternalError = -2,
		[FieldOffset(Offset="0x0")]
		TimeoutError = -1,
		[FieldOffset(Offset="0x0")]
		Success = 1
	}
}