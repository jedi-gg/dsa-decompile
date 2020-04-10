using Il2CppDummyDll;
using System;

namespace Glunies
{
	public enum InternalServiceError : long
	{
		[FieldOffset(Offset="0x0")]
		ConnectionFailure = 1000,
		[FieldOffset(Offset="0x0")]
		FIRST_INTERNAL_ERROR = 1000,
		[FieldOffset(Offset="0x0")]
		ParseException = 1001,
		[FieldOffset(Offset="0x0")]
		ServerError = 1002,
		[FieldOffset(Offset="0x0")]
		InvalidClientVersion = 1003,
		[FieldOffset(Offset="0x0")]
		DiskFull = 1004,
		[FieldOffset(Offset="0x0")]
		AssetBundleError = 1005
	}
}