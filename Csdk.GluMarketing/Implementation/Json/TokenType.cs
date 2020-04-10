using Il2CppDummyDll;
using System;

namespace Csdk.GluMarketing.Implementation.Json
{
	internal enum TokenType
	{
		[FieldOffset(Offset="0x0")]
		String,
		[FieldOffset(Offset="0x0")]
		Number,
		[FieldOffset(Offset="0x0")]
		Bool,
		[FieldOffset(Offset="0x0")]
		Null,
		[FieldOffset(Offset="0x0")]
		Comma,
		[FieldOffset(Offset="0x0")]
		OpeningCurlyBracket,
		[FieldOffset(Offset="0x0")]
		ClosingCurlyBracket,
		[FieldOffset(Offset="0x0")]
		OpeningSquareBracket,
		[FieldOffset(Offset="0x0")]
		ClosingSquareBracket,
		[FieldOffset(Offset="0x0")]
		Colon,
		[FieldOffset(Offset="0x0")]
		Unknown,
		[FieldOffset(Offset="0x0")]
		Eof
	}
}