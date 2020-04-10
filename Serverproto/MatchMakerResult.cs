using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum MatchMakerResult
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061694", Offset="0x1061694")]
		[FieldOffset(Offset="0x0")]
		Failed,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10616CC", Offset="0x10616CC")]
		[FieldOffset(Offset="0x0")]
		Success,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061704", Offset="0x1061704")]
		[FieldOffset(Offset="0x0")]
		Declined,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106173C", Offset="0x106173C")]
		[FieldOffset(Offset="0x0")]
		Canceled
	}
}