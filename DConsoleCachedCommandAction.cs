using Il2CppDummyDll;
using System;

public struct DConsoleCachedCommandAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DConsoleCachedCommandAction.Operation Op;

	[FieldOffset(Offset="0x4")]
	public readonly int Index;

	[FieldOffset(Offset="0x8")]
	public readonly string Command;

	[Address(RVA="0xF048B0", Offset="0xF048B0", VA="0xF048B0")]
	public DConsoleCachedCommandAction(DConsoleCachedCommandAction.Operation op, int index, string command = "")
	{
	}

	public enum Operation
	{
		[FieldOffset(Offset="0x0")]
		Selected,
		[FieldOffset(Offset="0x0")]
		Set,
		[FieldOffset(Offset="0x0")]
		Delete
	}
}