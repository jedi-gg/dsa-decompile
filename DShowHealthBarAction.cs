using Il2CppDummyDll;
using System;

public struct DShowHealthBarAction
{
	[FieldOffset(Offset="0x0")]
	public readonly byte TargetUnitId;

	[FieldOffset(Offset="0x4")]
	public readonly HealthBarVisibility Visibility;

	[Address(RVA="0xEFF4BC", Offset="0xEFF4BC", VA="0xEFF4BC")]
	public DShowHealthBarAction(byte targetUnitId, HealthBarVisibility visibility)
	{
	}
}