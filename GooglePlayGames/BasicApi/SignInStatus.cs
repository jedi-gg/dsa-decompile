using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi
{
	public enum SignInStatus
	{
		[FieldOffset(Offset="0x0")]
		Success,
		[FieldOffset(Offset="0x0")]
		UiSignInRequired,
		[FieldOffset(Offset="0x0")]
		DeveloperError,
		[FieldOffset(Offset="0x0")]
		NetworkError,
		[FieldOffset(Offset="0x0")]
		InternalError,
		[FieldOffset(Offset="0x0")]
		Canceled,
		[FieldOffset(Offset="0x0")]
		AlreadyInProgress,
		[FieldOffset(Offset="0x0")]
		Failed,
		[FieldOffset(Offset="0x0")]
		NotAuthenticated
	}
}