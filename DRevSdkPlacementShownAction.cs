using Il2CppDummyDll;
using Serverproto;
using System;

public struct DRevSdkPlacementShownAction
{
	[FieldOffset(Offset="0x0")]
	public readonly RevSdkRewardType RewardType;

	[FieldOffset(Offset="0x4")]
	public readonly bool Success;

	[Address(RVA="0xEFED00", Offset="0xEFED00", VA="0xEFED00")]
	public DRevSdkPlacementShownAction(RevSdkRewardType rewardType, bool success)
	{
	}
}