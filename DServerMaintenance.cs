using Il2CppDummyDll;
using System;

[Serializable]
public struct DServerMaintenance
{
	[FieldOffset(Offset="0x0")]
	public bool UnderMaintenance;

	[FieldOffset(Offset="0x8")]
	public string MaintenanceDuration;

	[FieldOffset(Offset="0x10")]
	public string MessageOverride;

	[FieldOffset(Offset="0x18")]
	public string RawMessageOverride;
}