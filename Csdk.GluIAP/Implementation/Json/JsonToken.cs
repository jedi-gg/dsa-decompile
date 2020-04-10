using Il2CppDummyDll;
using System;

namespace Csdk.GluIAP.Implementation.Json
{
	internal struct JsonToken
	{
		[FieldOffset(Offset="0x0")]
		public readonly Csdk.GluIAP.Implementation.Json.TokenType Type;

		[FieldOffset(Offset="0x8")]
		public readonly object Value;

		[Address(RVA="0xF37F2C", Offset="0xF37F2C", VA="0xF37F2C")]
		public JsonToken(Csdk.GluIAP.Implementation.Json.TokenType type, object value)
		{
		}
	}
}