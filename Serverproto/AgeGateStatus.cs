using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum AgeGateStatus
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x10628D4", Offset="0x10628D4")]
		[FieldOffset(Offset="0x0")]
		HasNotSeenAgeGate,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106290C", Offset="0x106290C")]
		[FieldOffset(Offset="0x0")]
		NeedsToSeeAgeGate,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062944", Offset="0x1062944")]
		[FieldOffset(Offset="0x0")]
		FailedAgeGate,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106297C", Offset="0x106297C")]
		[FieldOffset(Offset="0x0")]
		PassedAgeGate
	}
}