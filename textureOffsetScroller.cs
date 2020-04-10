using Il2CppDummyDll;
using System;
using UnityEngine;

public class textureOffsetScroller : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	public float XScrollSpeed;

	[FieldOffset(Offset="0x1C")]
	public float YScrollSpeed;

	[FieldOffset(Offset="0x20")]
	private Material myMaterial;

	[FieldOffset(Offset="0x28")]
	private float xOffset;

	[FieldOffset(Offset="0x2C")]
	private float yOffset;

	[Address(RVA="0x234197C", Offset="0x234197C", VA="0x234197C")]
	public textureOffsetScroller()
	{
	}

	[Address(RVA="0x23417CC", Offset="0x23417CC", VA="0x23417CC")]
	private void Awake()
	{
	}

	[Address(RVA="0x2341878", Offset="0x2341878", VA="0x2341878")]
	private void Update()
	{
	}
}