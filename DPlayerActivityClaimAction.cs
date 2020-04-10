using Il2CppDummyDll;
using System;

public struct DPlayerActivityClaimAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong ActivityId;

	[FieldOffset(Offset="0x8")]
	public readonly ulong SelectedOption;

	[Address(RVA="0xEFE738", Offset="0xEFE738", VA="0xEFE738")]
	public DPlayerActivityClaimAction(ulong activityId, ulong selectedOption = 0L)
	{
	}
}