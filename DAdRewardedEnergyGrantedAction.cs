using Il2CppDummyDll;
using Serverproto;
using System;

public struct DAdRewardedEnergyGrantedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly AdRewardedEnergyResponse Response;

	[Address(RVA="0xF023A8", Offset="0xF023A8", VA="0xF023A8")]
	public DAdRewardedEnergyGrantedAction(AdRewardedEnergyResponse response)
	{
	}
}