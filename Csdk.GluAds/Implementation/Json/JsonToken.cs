using Il2CppDummyDll;
using System;

namespace Csdk.GluAds.Implementation.Json
{
	internal struct JsonToken
	{
		[FieldOffset(Offset="0x0")]
		public readonly Csdk.GluAds.Implementation.Json.TokenType Type;

		[FieldOffset(Offset="0x8")]
		public readonly object Value;

		[Address(RVA="0xF05AF4", Offset="0xF05AF4", VA="0xF05AF4")]
		public JsonToken(Csdk.GluAds.Implementation.Json.TokenType type, object value)
		{
		}
	}
}