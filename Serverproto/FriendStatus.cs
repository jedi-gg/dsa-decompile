using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum FriendStatus
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062C1C", Offset="0x1062C1C")]
		[FieldOffset(Offset="0x0")]
		Invalid,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062C54", Offset="0x1062C54")]
		[FieldOffset(Offset="0x0")]
		Friend,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062C8C", Offset="0x1062C8C")]
		[FieldOffset(Offset="0x0")]
		PendingFriendAccept,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062CC4", Offset="0x1062CC4")]
		[FieldOffset(Offset="0x0")]
		PendingSelfAccept
	}
}