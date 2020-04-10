using Il2CppDummyDll;
using System;

namespace Csdk.GluMarketing.Implementation.Json
{
	internal struct JsonToken
	{
		[FieldOffset(Offset="0x0")]
		public readonly Csdk.GluMarketing.Implementation.Json.TokenType Type;

		[FieldOffset(Offset="0x8")]
		public readonly object Value;

		[Address(RVA="0xF02284", Offset="0xF02284", VA="0xF02284")]
		public JsonToken(Csdk.GluMarketing.Implementation.Json.TokenType type, object value)
		{
		}
	}
}