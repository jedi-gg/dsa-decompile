using Il2CppDummyDll;
using System;

public struct DStartBuffIconTimerAction
{
	[FieldOffset(Offset="0x0")]
	public readonly uint Id;

	[FieldOffset(Offset="0x4")]
	public readonly byte TargetUnitId;

	[FieldOffset(Offset="0x8")]
	public readonly float DurationS;

	[FieldOffset(Offset="0xC")]
	public readonly BuffIconType BuffIconType;

	[Address(RVA="0xEFF7EC", Offset="0xEFF7EC", VA="0xEFF7EC")]
	public DStartBuffIconTimerAction(uint id, byte targetUnitId, float durationS, BuffIconType buffIconType)
	{
	}
}