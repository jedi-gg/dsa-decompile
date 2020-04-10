using Il2CppDummyDll;
using System;
using UnityEngine;

public class PackOpeningModelTransformOffset : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	public Vector3 Position;

	[FieldOffset(Offset="0x24")]
	public Vector3 Rotation;

	[FieldOffset(Offset="0x30")]
	public Vector3 Scale;

	[Address(RVA="0x1304AD4", Offset="0x1304AD4", VA="0x1304AD4")]
	public PackOpeningModelTransformOffset()
	{
	}

	[Address(RVA="0x1304A18", Offset="0x1304A18", VA="0x1304A18")]
	[Attribute(Name="ContextMenu", RVA="0x1070224", Offset="0x1070224")]
	private void CopyTransformProperties()
	{
	}
}