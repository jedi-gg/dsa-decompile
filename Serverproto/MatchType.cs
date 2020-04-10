using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum MatchType
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x10615B4", Offset="0x10615B4")]
		[FieldOffset(Offset="0x0")]
		Pvp,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10615EC", Offset="0x10615EC")]
		[FieldOffset(Offset="0x0")]
		Coop,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061624", Offset="0x1061624")]
		[FieldOffset(Offset="0x0")]
		Koth,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106165C", Offset="0x106165C")]
		[FieldOffset(Offset="0x0")]
		ClubWar
	}
}