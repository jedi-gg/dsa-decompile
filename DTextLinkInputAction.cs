using Il2CppDummyDll;
using System;

public struct DTextLinkInputAction
{
	[FieldOffset(Offset="0x0")]
	public readonly UiLabel Label;

	[FieldOffset(Offset="0x8")]
	public readonly int LinkId;

	[Address(RVA="0xEFFA84", Offset="0xEFFA84", VA="0xEFFA84")]
	public DTextLinkInputAction(UiLabel label, int linkId)
	{
	}
}