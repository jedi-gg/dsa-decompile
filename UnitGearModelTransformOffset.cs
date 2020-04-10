using Il2CppDummyDll;
using System;
using UnityEngine;

public class UnitGearModelTransformOffset : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	public Vector3 Position;

	[FieldOffset(Offset="0x24")]
	public Vector3 Rotation;

	[FieldOffset(Offset="0x30")]
	public Vector3 Scale;

	[Address(RVA="0x11F4F3C", Offset="0x11F4F3C", VA="0x11F4F3C")]
	public UnitGearModelTransformOffset()
	{
	}

	[Address(RVA="0x11F4E80", Offset="0x11F4E80", VA="0x11F4E80")]
	[Attribute(Name="ContextMenu", RVA="0x1071074", Offset="0x1071074")]
	private void CopyTransformProperties()
	{
	}
}