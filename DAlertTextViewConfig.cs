using Il2CppDummyDll;
using System;

public struct DAlertTextViewConfig
{
	[FieldOffset(Offset="0x0")]
	public readonly AlertTextView.Style Style;

	[FieldOffset(Offset="0x4")]
	public readonly AlertTextView.AudioType AudioType;

	[Address(RVA="0xF02518", Offset="0xF02518", VA="0xF02518")]
	public DAlertTextViewConfig(AlertTextView.Style style, AlertTextView.AudioType audioType)
	{
	}

	[Address(RVA="0xF02520", Offset="0xF02520", VA="0xF02520")]
	public DAlertTextViewConfig(AlertTextView.Style style)
	{
	}

	[Address(RVA="0xF02528", Offset="0xF02528", VA="0xF02528")]
	public DAlertTextViewConfig(AlertTextView.AudioType audioType)
	{
	}

	[Address(RVA="0x153CC24", Offset="0x153CC24", VA="0x153CC24")]
	public static DAlertTextViewConfig Default()
	{
		return new DAlertTextViewConfig();
	}

	[Address(RVA="0x153CC54", Offset="0x153CC54", VA="0x153CC54")]
	public static DAlertTextViewConfig Negative()
	{
		return new DAlertTextViewConfig();
	}
}