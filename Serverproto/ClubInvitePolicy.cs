using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum ClubInvitePolicy
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x10619D4", Offset="0x10619D4")]
		[FieldOffset(Offset="0x0")]
		InvalidInvitePolicy,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061A0C", Offset="0x1061A0C")]
		[FieldOffset(Offset="0x0")]
		OpenInvitePolicy,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061A44", Offset="0x1061A44")]
		[FieldOffset(Offset="0x0")]
		RequestInvitePolicy,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061A7C", Offset="0x1061A7C")]
		[FieldOffset(Offset="0x0")]
		InviteOnlyInvitePolicy
	}
}