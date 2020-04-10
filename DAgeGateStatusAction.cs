using Il2CppDummyDll;
using Serverproto;
using System;

public struct DAgeGateStatusAction
{
	[FieldOffset(Offset="0x0")]
	public readonly AgeGateStatus Status;

	[Address(RVA="0xF02444", Offset="0xF02444", VA="0xF02444")]
	public DAgeGateStatusAction(AgeGateStatus status)
	{
	}
}