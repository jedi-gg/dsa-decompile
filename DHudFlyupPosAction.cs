using Il2CppDummyDll;
using System;
using UnityEngine;

public struct DHudFlyupPosAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong ItemId;

	[FieldOffset(Offset="0x8")]
	public readonly long ItemCount;

	[FieldOffset(Offset="0x10")]
	public Vector3 SourceScreenPos;

	[Address(RVA="0xEFDB14", Offset="0xEFDB14", VA="0xEFDB14")]
	public DHudFlyupPosAction(ulong itemId, long itemCount, Vector3 sourceScreenPos)
	{
	}
}