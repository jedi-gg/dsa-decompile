using Il2CppDummyDll;
using System;
using UnityEngine;

public struct DPackOpeningHudItemFlyupAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong ItemId;

	[FieldOffset(Offset="0x8")]
	public readonly long ItemCount;

	[FieldOffset(Offset="0x10")]
	public readonly Texture ItemTexture;

	[FieldOffset(Offset="0x18")]
	public readonly Vector3 SourceScreenPos;

	[Address(RVA="0xEFE56C", Offset="0xEFE56C", VA="0xEFE56C")]
	public DPackOpeningHudItemFlyupAction(ulong itemId, long itemCount, Texture itemTexture, Vector3 sourceScreenPos)
	{
	}
}