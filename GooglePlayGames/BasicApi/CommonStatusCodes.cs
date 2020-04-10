using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi
{
	public enum CommonStatusCodes
	{
		[FieldOffset(Offset="0x0")]
		SuccessCached = -1,
		[FieldOffset(Offset="0x0")]
		Success = 0,
		[FieldOffset(Offset="0x0")]
		ServiceMissing = 1,
		[FieldOffset(Offset="0x0")]
		ServiceVersionUpdateRequired = 2,
		[FieldOffset(Offset="0x0")]
		ServiceDisabled = 3,
		[FieldOffset(Offset="0x0")]
		SignInRequired = 4,
		[FieldOffset(Offset="0x0")]
		InvalidAccount = 5,
		[FieldOffset(Offset="0x0")]
		ResolutionRequired = 6,
		[FieldOffset(Offset="0x0")]
		NetworkError = 7,
		[FieldOffset(Offset="0x0")]
		InternalError = 8,
		[FieldOffset(Offset="0x0")]
		ServiceInvalid = 9,
		[FieldOffset(Offset="0x0")]
		DeveloperError = 10,
		[FieldOffset(Offset="0x0")]
		LicenseCheckFailed = 11,
		[FieldOffset(Offset="0x0")]
		Error = 13,
		[FieldOffset(Offset="0x0")]
		Interrupted = 14,
		[FieldOffset(Offset="0x0")]
		Timeout = 15,
		[FieldOffset(Offset="0x0")]
		Canceled = 16,
		[FieldOffset(Offset="0x0")]
		ApiNotConnected = 17,
		[FieldOffset(Offset="0x0")]
		AuthApiInvalidCredentials = 3000,
		[FieldOffset(Offset="0x0")]
		AuthApiAccessForbidden = 3001,
		[FieldOffset(Offset="0x0")]
		AuthApiClientError = 3002,
		[FieldOffset(Offset="0x0")]
		AuthApiServerError = 3003,
		[FieldOffset(Offset="0x0")]
		AuthTokenError = 3004,
		[FieldOffset(Offset="0x0")]
		AuthUrlResolution = 3005
	}
}