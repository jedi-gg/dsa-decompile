using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum ChatMessageType
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x10617A4", Offset="0x10617A4")]
		[FieldOffset(Offset="0x0")]
		InvalidChatMessage,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10617DC", Offset="0x10617DC")]
		[FieldOffset(Offset="0x0")]
		UserChatMessage,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061814", Offset="0x1061814")]
		[FieldOffset(Offset="0x0")]
		SystemChatMessage
	}
}