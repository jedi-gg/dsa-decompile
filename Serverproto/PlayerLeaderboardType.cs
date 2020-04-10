using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum PlayerLeaderboardType
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x10626F4", Offset="0x10626F4")]
		[FieldOffset(Offset="0x0")]
		Invalid,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106272C", Offset="0x106272C")]
		[FieldOffset(Offset="0x0")]
		PvpLocal,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062764", Offset="0x1062764")]
		[FieldOffset(Offset="0x0")]
		PvpGlobal,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106279C", Offset="0x106279C")]
		[FieldOffset(Offset="0x0")]
		Koth
	}
}