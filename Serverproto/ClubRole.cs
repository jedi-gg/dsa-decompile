using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum ClubRole
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061B5C", Offset="0x1061B5C")]
		[FieldOffset(Offset="0x0")]
		InvalidRole,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061B94", Offset="0x1061B94")]
		[FieldOffset(Offset="0x0")]
		MemberRole,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061BCC", Offset="0x1061BCC")]
		[FieldOffset(Offset="0x0")]
		CoLeaderRole,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061C04", Offset="0x1061C04")]
		[FieldOffset(Offset="0x0")]
		LeaderRole
	}
}