using Il2CppDummyDll;
using Serverproto;
using System;

public struct DHomeTowerStatusResponse
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong CurrentNode;

	[FieldOffset(Offset="0x8")]
	public readonly ulong TotalNodes;

	[Address(RVA="0xEFD9C8", Offset="0xEFD9C8", VA="0xEFD9C8")]
	public DHomeTowerStatusResponse(HomeTowerStatusResponse towerStatus)
	{
	}
}