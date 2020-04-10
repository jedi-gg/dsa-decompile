using Il2CppDummyDll;
using System;
using UnityEngine;

public class UnitDetailsModelTransformOffset : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	public Vector3 Position;

	[FieldOffset(Offset="0x24")]
	public Vector3 Rotation;

	[FieldOffset(Offset="0x30")]
	public Vector3 Scale;

	[Address(RVA="0x11E4D00", Offset="0x11E4D00", VA="0x11E4D00")]
	public UnitDetailsModelTransformOffset()
	{
	}

	[Address(RVA="0x11E4C44", Offset="0x11E4C44", VA="0x11E4C44")]
	[Attribute(Name="ContextMenu", RVA="0x1070FDC", Offset="0x1070FDC")]
	private void CopyTransformProperties()
	{
	}
}