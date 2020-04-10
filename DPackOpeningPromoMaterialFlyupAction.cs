using Il2CppDummyDll;
using System;
using UnityEngine;

public struct DPackOpeningPromoMaterialFlyupAction
{
	[FieldOffset(Offset="0x0")]
	public readonly long ItemCount;

	[FieldOffset(Offset="0x8")]
	public readonly Texture ItemTexture;

	[FieldOffset(Offset="0x10")]
	public readonly Vector3 SourceScreenPos;

	[FieldOffset(Offset="0x1C")]
	public readonly Vector3 TargetPos;

	[Address(RVA="0xEFE5CC", Offset="0xEFE5CC", VA="0xEFE5CC")]
	public DPackOpeningPromoMaterialFlyupAction(long itemCount, Texture itemTexture, Vector3 sourceScreenPos, Vector3 targetPos)
	{
	}
}