using Il2CppDummyDll;
using System;

public struct DCCPAViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DCCPAViewAction.Type ActionType;

	[Address(RVA="0xF030FC", Offset="0xF030FC", VA="0xF030FC")]
	public DCCPAViewAction(DCCPAViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		OpenPrivacyPolicy
	}
}