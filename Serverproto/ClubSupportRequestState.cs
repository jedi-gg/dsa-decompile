using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum ClubSupportRequestState
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x10624FC", Offset="0x10624FC")]
		[FieldOffset(Offset="0x0")]
		Unfulfilled,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062534", Offset="0x1062534")]
		[FieldOffset(Offset="0x0")]
		Fulfilled,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106256C", Offset="0x106256C")]
		[FieldOffset(Offset="0x0")]
		Claimed
	}
}