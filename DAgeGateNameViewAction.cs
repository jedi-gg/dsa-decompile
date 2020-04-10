using Il2CppDummyDll;
using System;

public struct DAgeGateNameViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DAgeGateNameViewAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly string Name;

	[Address(RVA="0xF02438", Offset="0xF02438", VA="0xF02438")]
	public DAgeGateNameViewAction(DAgeGateNameViewAction.Type actionType, string name)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Entered,
		[FieldOffset(Offset="0x0")]
		Submitted
	}
}