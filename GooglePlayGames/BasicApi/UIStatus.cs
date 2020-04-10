using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi
{
	public enum UIStatus
	{
		[FieldOffset(Offset="0x0")]
		LeftRoom = -18,
		[FieldOffset(Offset="0x0")]
		UiBusy = -12,
		[FieldOffset(Offset="0x0")]
		UserClosedUI = -6,
		[FieldOffset(Offset="0x0")]
		Timeout = -5,
		[FieldOffset(Offset="0x0")]
		VersionUpdateRequired = -4,
		[FieldOffset(Offset="0x0")]
		NotAuthorized = -3,
		[FieldOffset(Offset="0x0")]
		InternalError = -2,
		[FieldOffset(Offset="0x0")]
		Valid = 1
	}
}