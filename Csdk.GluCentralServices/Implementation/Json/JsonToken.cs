using Il2CppDummyDll;
using System;

namespace Csdk.GluCentralServices.Implementation.Json
{
	internal struct JsonToken
	{
		[FieldOffset(Offset="0x0")]
		public readonly Csdk.GluCentralServices.Implementation.Json.TokenType Type;

		[FieldOffset(Offset="0x8")]
		public readonly object Value;

		[Address(RVA="0xF37A88", Offset="0xF37A88", VA="0xF37A88")]
		public JsonToken(Csdk.GluCentralServices.Implementation.Json.TokenType type, object value)
		{
		}
	}
}