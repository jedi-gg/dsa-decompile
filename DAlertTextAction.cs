using Il2CppDummyDll;
using System;

public struct DAlertTextAction
{
	[FieldOffset(Offset="0x0")]
	public readonly string Text;

	[FieldOffset(Offset="0x8")]
	public readonly float? Arg0;

	[FieldOffset(Offset="0x10")]
	public readonly DAlertTextViewConfig Config;

	[Address(RVA="0xF024A0", Offset="0xF024A0", VA="0xF024A0")]
	public DAlertTextAction(string text)
	{
	}

	[Address(RVA="0xF024AC", Offset="0xF024AC", VA="0xF024AC")]
	public DAlertTextAction(string text, DAlertTextViewConfig config)
	{
	}

	[Address(RVA="0xF024B8", Offset="0xF024B8", VA="0xF024B8")]
	public DAlertTextAction(string text, float? arg0, DAlertTextViewConfig config)
	{
	}
}