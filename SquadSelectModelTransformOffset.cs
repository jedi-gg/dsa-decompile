using Il2CppDummyDll;
using System;
using UnityEngine;

public class SquadSelectModelTransformOffset : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	public Vector3 Position;

	[FieldOffset(Offset="0x24")]
	public Vector3 Rotation;

	[FieldOffset(Offset="0x30")]
	public Vector3 Scale;

	[Address(RVA="0x12224DC", Offset="0x12224DC", VA="0x12224DC")]
	public SquadSelectModelTransformOffset()
	{
	}

	[Address(RVA="0x1222420", Offset="0x1222420", VA="0x1222420")]
	[Attribute(Name="ContextMenu", RVA="0x1070A14", Offset="0x1070A14")]
	private void CopyTransformProperties()
	{
	}
}