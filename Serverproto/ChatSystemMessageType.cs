using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum ChatSystemMessageType
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x106192C", Offset="0x106192C")]
		[FieldOffset(Offset="0x0")]
		InvalidAdminMessage,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061964", Offset="0x1061964")]
		[FieldOffset(Offset="0x0")]
		ClubSystemMessage,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106199C", Offset="0x106199C")]
		[FieldOffset(Offset="0x0")]
		GlobalSystemMessage
	}
}