using Il2CppDummyDll;
using System;
using UnityEngine;

public class StoreShowcaseModelTransformOffset : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	public Vector3 Position;

	[FieldOffset(Offset="0x24")]
	public Vector3 Rotation;

	[FieldOffset(Offset="0x30")]
	public Vector3 Scale;

	[Address(RVA="0x1315DB0", Offset="0x1315DB0", VA="0x1315DB0")]
	public StoreShowcaseModelTransformOffset()
	{
	}

	[Address(RVA="0x1315CF4", Offset="0x1315CF4", VA="0x1315CF4")]
	[Attribute(Name="ContextMenu", RVA="0x1070B2C", Offset="0x1070B2C")]
	private void CopyTransformProperties()
	{
	}
}