using Il2CppDummyDll;
using System;

public struct DLockableFeatureUpdatedDynamicMessage
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong FeatureIndex;

	[FieldOffset(Offset="0x8")]
	public readonly bool IsUnlocked;

	[Address(RVA="0xEFE3B4", Offset="0xEFE3B4", VA="0xEFE3B4")]
	public DLockableFeatureUpdatedDynamicMessage(ulong featureIndex, bool isUnlocked)
	{
	}
}