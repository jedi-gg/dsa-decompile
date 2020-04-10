using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum ClubMessageType
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061AB4", Offset="0x1061AB4")]
		[FieldOffset(Offset="0x0")]
		InvalidMessageType,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061AEC", Offset="0x1061AEC")]
		[FieldOffset(Offset="0x0")]
		ChatMessageType,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061B24", Offset="0x1061B24")]
		[FieldOffset(Offset="0x0")]
		EmailMessageType
	}
}