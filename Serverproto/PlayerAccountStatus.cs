using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum PlayerAccountStatus
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062064", Offset="0x1062064")]
		[FieldOffset(Offset="0x0")]
		Active,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106209C", Offset="0x106209C")]
		[FieldOffset(Offset="0x0")]
		TempBan,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10620D4", Offset="0x10620D4")]
		[FieldOffset(Offset="0x0")]
		PermBan
	}
}