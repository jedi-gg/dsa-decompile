using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi
{
	public enum ResponseStatus
	{
		[FieldOffset(Offset="0x0")]
		Timeout = -5,
		[FieldOffset(Offset="0x0")]
		VersionUpdateRequired = -4,
		[FieldOffset(Offset="0x0")]
		NotAuthorized = -3,
		[FieldOffset(Offset="0x0")]
		InternalError = -2,
		[FieldOffset(Offset="0x0")]
		LicenseCheckFailed = -1,
		[FieldOffset(Offset="0x0")]
		Success = 1,
		[FieldOffset(Offset="0x0")]
		SuccessWithStale = 2
	}
}