using Il2CppDummyDll;
using System;

public struct DServerInMaintenanceModeAction
{
	[FieldOffset(Offset="0x0")]
	public bool UnderMaintenance;

	[FieldOffset(Offset="0x8")]
	public string MaintenanceDuration;

	[FieldOffset(Offset="0x10")]
	public string MessageOverride;

	[FieldOffset(Offset="0x18")]
	public string RawMessageOverride;

	[Address(RVA="0xEFF168", Offset="0xEFF168", VA="0xEFF168")]
	public DServerInMaintenanceModeAction(bool underMaintenance, string maintenanceDuration, string messageOverride, string rawMessageOverride)
	{
	}
}