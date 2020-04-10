using Il2CppDummyDll;
using System;

public struct DConsoleViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DConsoleViewAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly string Command;

	[Address(RVA="0xF049C4", Offset="0xF049C4", VA="0xF049C4")]
	public DConsoleViewAction(DConsoleViewAction.Type actionType, string command)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		CommandSubmitted,
		[FieldOffset(Offset="0x0")]
		Screenshot
	}
}