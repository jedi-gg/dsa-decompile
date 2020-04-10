using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum StoreItemSize
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x10625A4", Offset="0x10625A4")]
		[FieldOffset(Offset="0x0")]
		InvalidStoreItemSize,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10625DC", Offset="0x10625DC")]
		[FieldOffset(Offset="0x0")]
		ThinStoreItemSize,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062614", Offset="0x1062614")]
		[FieldOffset(Offset="0x0")]
		MediumStoreItemSize,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106264C", Offset="0x106264C")]
		[FieldOffset(Offset="0x0")]
		WideStoreItemSize,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062684", Offset="0x1062684")]
		[FieldOffset(Offset="0x0")]
		SquareStoreItemSize,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10626BC", Offset="0x10626BC")]
		[FieldOffset(Offset="0x0")]
		SpecialOfferStoreItemSize
	}
}