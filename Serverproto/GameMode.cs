using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum GameMode
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x10629B4", Offset="0x10629B4")]
		[FieldOffset(Offset="0x0")]
		Invalid,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10629EC", Offset="0x10629EC")]
		[FieldOffset(Offset="0x0")]
		Campaign,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062A24", Offset="0x1062A24")]
		[FieldOffset(Offset="0x0")]
		Battle,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062A5C", Offset="0x1062A5C")]
		[FieldOffset(Offset="0x0")]
		Coop,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062A94", Offset="0x1062A94")]
		[FieldOffset(Offset="0x0")]
		Pvp,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062ACC", Offset="0x1062ACC")]
		[FieldOffset(Offset="0x0")]
		Event,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062B04", Offset="0x1062B04")]
		[FieldOffset(Offset="0x0")]
		Tower,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062B3C", Offset="0x1062B3C")]
		[FieldOffset(Offset="0x0")]
		ClubDungeon,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062B74", Offset="0x1062B74")]
		[FieldOffset(Offset="0x0")]
		Koth,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062BAC", Offset="0x1062BAC")]
		[FieldOffset(Offset="0x0")]
		KothDefense,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062BE4", Offset="0x1062BE4")]
		[FieldOffset(Offset="0x0")]
		ClubWar
	}
}