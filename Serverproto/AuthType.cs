using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum AuthType
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x10613BC", Offset="0x10613BC")]
		[FieldOffset(Offset="0x0")]
		Invalid,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10613F4", Offset="0x10613F4")]
		[FieldOffset(Offset="0x0")]
		Editor,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106142C", Offset="0x106142C")]
		[FieldOffset(Offset="0x0")]
		Gamecenter,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061464", Offset="0x1061464")]
		[FieldOffset(Offset="0x0")]
		GooglePlay,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106149C", Offset="0x106149C")]
		[FieldOffset(Offset="0x0")]
		AnonIos,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10614D4", Offset="0x10614D4")]
		[FieldOffset(Offset="0x0")]
		AnonAndroid
	}
}