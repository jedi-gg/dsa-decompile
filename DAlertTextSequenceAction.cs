using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public struct DAlertTextSequenceAction
{
	[FieldOffset(Offset="0x0")]
	public readonly List<string> Text;

	[FieldOffset(Offset="0x8")]
	public readonly DAlertTextViewConfig Config;

	[Address(RVA="0xF02510", Offset="0xF02510", VA="0xF02510")]
	public DAlertTextSequenceAction(List<string> text, DAlertTextViewConfig config)
	{
	}
}