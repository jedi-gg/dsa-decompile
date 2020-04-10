using Il2CppDummyDll;
using System;

public struct DDisabledFeatureUpdatedDynamicMessage
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong FeatureIndex;

	[FieldOffset(Offset="0x8")]
	public readonly bool IsDisabled;

	[Address(RVA="0xF04D2C", Offset="0xF04D2C", VA="0xF04D2C")]
	public DDisabledFeatureUpdatedDynamicMessage(ulong featureIndex, bool isDisabled)
	{
	}
}