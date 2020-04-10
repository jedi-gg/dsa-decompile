using Il2CppDummyDll;
using System;

public struct DAudioSnapshotAction
{
	[FieldOffset(Offset="0x0")]
	public readonly string SnapshotName;

	[FieldOffset(Offset="0x8")]
	public readonly float TransitionDuration;

	[Address(RVA="0xF027A4", Offset="0xF027A4", VA="0xF027A4")]
	public DAudioSnapshotAction(string snapshotName, float transitionDuration = 0.4f)
	{
	}
}