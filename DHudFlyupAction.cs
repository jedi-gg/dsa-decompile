using Il2CppDummyDll;
using System;
using UnityEngine;

public struct DHudFlyupAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong ItemId;

	[FieldOffset(Offset="0x8")]
	public readonly long ItemCount;

	[FieldOffset(Offset="0x10")]
	public RectTransform SourceRect;

	[Address(RVA="0xEFDAB0", Offset="0xEFDAB0", VA="0xEFDAB0")]
	public DHudFlyupAction(ulong itemId, long itemCount, RectTransform sourceRect)
	{
	}
}