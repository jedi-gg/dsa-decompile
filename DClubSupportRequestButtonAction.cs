using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClubSupportRequestButtonAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ClubSupportRequestType RequestType;

	[FieldOffset(Offset="0x8")]
	public readonly object OwnerIdentifier;

	[FieldOffset(Offset="0x10")]
	public readonly object Context;

	[Address(RVA="0xF042D8", Offset="0xF042D8", VA="0xF042D8")]
	public DClubSupportRequestButtonAction(ClubSupportRequestType requestType, object ownerIdentifier, object context)
	{
	}
}