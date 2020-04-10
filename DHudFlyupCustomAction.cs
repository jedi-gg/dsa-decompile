using Il2CppDummyDll;
using System;
using UnityEngine;

public struct DHudFlyupCustomAction
{
	[FieldOffset(Offset="0x0")]
	public readonly long ItemCount;

	[FieldOffset(Offset="0x8")]
	public Texture ItemTexture;

	[FieldOffset(Offset="0x10")]
	public RectTransform SourceRect;

	[FieldOffset(Offset="0x18")]
	public RectTransform TargetRect;

	[Address(RVA="0xEFDB08", Offset="0xEFDB08", VA="0xEFDB08")]
	public DHudFlyupCustomAction(long itemCount, Texture itemTexture, RectTransform sourceRect, RectTransform targetRect)
	{
	}
}