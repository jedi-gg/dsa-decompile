using Il2CppDummyDll;
using System;

public struct DSettingsViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DSettingsViewAction.Type ActionType;

	[Address(RVA="0xEFF328", Offset="0xEFF328", VA="0xEFF328")]
	public DSettingsViewAction(DSettingsViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		OpenSupport,
		[FieldOffset(Offset="0x0")]
		OpenCredits,
		[FieldOffset(Offset="0x0")]
		OpenGdprSettings,
		[FieldOffset(Offset="0x0")]
		OpenCCPAView,
		[FieldOffset(Offset="0x0")]
		WatchIntroCinematic
	}
}