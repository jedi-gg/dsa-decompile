using Il2CppDummyDll;
using System;

namespace Csdk.GluCentralServices
{
	public class ShowConsentResult
	{
		[FieldOffset(Offset="0x10")]
		public readonly string Status;

		[FieldOffset(Offset="0x18")]
		public readonly Exception Error;

		[FieldOffset(Offset="0x20")]
		public readonly string Placement;

		[Address(RVA="0x21DEDBC", Offset="0x21DEDBC", VA="0x21DEDBC")]
		public ShowConsentResult(string status, Exception error, string placement)
		{
		}
	}
}