using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum ChatChannelType
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x106184C", Offset="0x106184C")]
		[FieldOffset(Offset="0x0")]
		InvalidChannel,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061884", Offset="0x1061884")]
		[FieldOffset(Offset="0x0")]
		GlobalChannel,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10618BC", Offset="0x10618BC")]
		[FieldOffset(Offset="0x0")]
		ClubChannel,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10618F4", Offset="0x10618F4")]
		[FieldOffset(Offset="0x0")]
		ClubSystemMessageChannel
	}
}