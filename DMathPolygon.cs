using Il2CppDummyDll;
using System;
using UnityEngine;

public struct DMathPolygon
{
	[FieldOffset(Offset="0x0")]
	public readonly Vector3[] Vertices;

	[Address(RVA="0xEFE3CC", Offset="0xEFE3CC", VA="0xEFE3CC")]
	public DMathPolygon(Vector3[] verts)
	{
	}

	[Address(RVA="0xEFE3D4", Offset="0xEFE3D4", VA="0xEFE3D4")]
	public bool Contains(Vector3 point, float radius)
	{
		return new bool();
	}

	[Address(RVA="0xEFE3FC", Offset="0xEFE3FC", VA="0xEFE3FC")]
	private bool IsWestOfEdge(Vector3 lowerVert, Vector3 higherVert, Vector3 point)
	{
		return new bool();
	}

	[Address(RVA="0xEFE3E4", Offset="0xEFE3E4", VA="0xEFE3E4")]
	private bool IsWestOfEdgeSafe(Vector3 vertA, Vector3 vertB, Vector3 point)
	{
		return new bool();
	}

	[Address(RVA="0xEFE3DC", Offset="0xEFE3DC", VA="0xEFE3DC")]
	private bool OnVertex(Vector3 point)
	{
		return new bool();
	}
}