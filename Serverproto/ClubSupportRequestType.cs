using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum ClubSupportRequestType
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062374", Offset="0x1062374")]
		[FieldOffset(Offset="0x0")]
		ClubSupportRequestInvalid,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10623AC", Offset="0x10623AC")]
		[FieldOffset(Offset="0x0")]
		ClubSupportRequestPveEnergy,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10623E4", Offset="0x10623E4")]
		[FieldOffset(Offset="0x0")]
		ClubSupportRequestGrandEnergy,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106241C", Offset="0x106241C")]
		[FieldOffset(Offset="0x0")]
		ClubSupportRequestCampaignAttemptLimit,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062454", Offset="0x1062454")]
		[FieldOffset(Offset="0x0")]
		ClubSupportRequestScheduledEventAttempt,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106248C", Offset="0x106248C")]
		[FieldOffset(Offset="0x0")]
		ClubSupportRequestShipmentRefresh,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10624C4", Offset="0x10624C4")]
		[FieldOffset(Offset="0x0")]
		ClubSupportRequestKothAttempt
	}
}