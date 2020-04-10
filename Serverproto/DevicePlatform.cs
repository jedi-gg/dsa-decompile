using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum DevicePlatform
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061314", Offset="0x1061314")]
		[FieldOffset(Offset="0x0")]
		InvalidDevicePlatform,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106134C", Offset="0x106134C")]
		[FieldOffset(Offset="0x0")]
		IosDevicePlatform,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061384", Offset="0x1061384")]
		[FieldOffset(Offset="0x0")]
		AndroidDevicePlatform
	}
}