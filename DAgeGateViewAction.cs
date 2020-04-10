using Il2CppDummyDll;
using System;

public struct DAgeGateViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DAgeGateViewAction.Type ActionType;

	[FieldOffset(Offset="0x4")]
	public readonly int Age;

	[Address(RVA="0xF0244C", Offset="0xF0244C", VA="0xF0244C")]
	public DAgeGateViewAction(DAgeGateViewAction.Type actionType, int age)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Agree,
		[FieldOffset(Offset="0x0")]
		Privacy
	}
}