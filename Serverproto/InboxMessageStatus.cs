using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum InboxMessageStatus
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062E84", Offset="0x1062E84")]
		[FieldOffset(Offset="0x0")]
		Invalid,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062EBC", Offset="0x1062EBC")]
		[FieldOffset(Offset="0x0")]
		Unread,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062EF4", Offset="0x1062EF4")]
		[FieldOffset(Offset="0x0")]
		Read,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062F2C", Offset="0x1062F2C")]
		[FieldOffset(Offset="0x0")]
		Claimed,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062F64", Offset="0x1062F64")]
		[FieldOffset(Offset="0x0")]
		Deleted
	}
}