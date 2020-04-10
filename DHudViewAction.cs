using Il2CppDummyDll;
using System;

public struct DHudViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DHudViewAction.Type ActionType;

	[Address(RVA="0xEFDBC8", Offset="0xEFDBC8", VA="0xEFDBC8")]
	public DHudViewAction(DHudViewAction.Type type)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Home,
		[FieldOffset(Offset="0x0")]
		Back,
		[FieldOffset(Offset="0x0")]
		Settings
	}
}