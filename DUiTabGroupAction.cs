using Il2CppDummyDll;
using System;

public struct DUiTabGroupAction
{
	[FieldOffset(Offset="0x0")]
	public readonly UiTabGroup TabGroup;

	[FieldOffset(Offset="0x8")]
	public readonly int Index;

	[Address(RVA="0xEFFC98", Offset="0xEFFC98", VA="0xEFFC98")]
	public DUiTabGroupAction(UiTabGroup tabGroup, int index)
	{
	}
}