using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum PushNotificationProvider
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x106150C", Offset="0x106150C")]
		[FieldOffset(Offset="0x0")]
		Invalid,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061544", Offset="0x1061544")]
		[FieldOffset(Offset="0x0")]
		Apns,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106157C", Offset="0x106157C")]
		[FieldOffset(Offset="0x0")]
		Fcm
	}
}