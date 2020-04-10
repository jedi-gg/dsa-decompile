using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi.SavedGame
{
	public enum SelectUIStatus
	{
		[FieldOffset(Offset="0x0")]
		UiBusy = -5,
		[FieldOffset(Offset="0x0")]
		BadInputError = -4,
		[FieldOffset(Offset="0x0")]
		AuthenticationError = -3,
		[FieldOffset(Offset="0x0")]
		TimeoutError = -2,
		[FieldOffset(Offset="0x0")]
		InternalError = -1,
		[FieldOffset(Offset="0x0")]
		SavedGameSelected = 1,
		[FieldOffset(Offset="0x0")]
		UserClosedUI = 2
	}
}