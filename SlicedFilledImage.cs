using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class SlicedFilledImage : Image
{
	[FieldOffset(Offset="0x0")]
	private readonly static Vector2[] s_VertScratch;

	[FieldOffset(Offset="0x8")]
	private readonly static Vector2[] s_UVScratch;

	private Sprite ActiveSprite
	{
		[Address(RVA="0x14C663C", Offset="0x14C663C", VA="0x14C663C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14C7DFC", Offset="0x14C7DFC", VA="0x14C7DFC")]
	static SlicedFilledImage()
	{
	}

	[Address(RVA="0x14C7D94", Offset="0x14C7D94", VA="0x14C7D94")]
	public SlicedFilledImage()
	{
	}

	[Address(RVA="0x14C730C", Offset="0x14C730C", VA="0x14C730C")]
	private void AddFilledQuad(VertexHelper toFill, int x, int y)
	{
	}

	[Address(RVA="0x14C6510", Offset="0x14C6510", VA="0x14C6510", Slot="4")]
	protected override void Awake()
	{
	}

	[Address(RVA="0x14C6E88", Offset="0x14C6E88", VA="0x14C6E88")]
	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect)
	{
	}

	[Address(RVA="0x14C66E0", Offset="0x14C66E0", VA="0x14C66E0")]
	private void GenerateSprite(VertexHelper toFill, bool preserveAspect)
	{
	}

	[Address(RVA="0x14C7ACC", Offset="0x14C7ACC", VA="0x14C7ACC")]
	private float GetXVertPercent(int vertIndex)
	{
		return new float();
	}

	[Address(RVA="0x14C7C30", Offset="0x14C7C30", VA="0x14C7C30")]
	private float GetYVertPercent(int vertIndex)
	{
		return new float();
	}

	[Address(RVA="0x14C6578", Offset="0x14C6578", VA="0x14C6578", Slot="44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Address(RVA="0x14C7244", Offset="0x14C7244", VA="0x14C7244")]
	private bool QuadIsEntirelyBeyondFill(int x, int y)
	{
		return new bool();
	}

	[Address(RVA="0x14C6514", Offset="0x14C6514", VA="0x14C6514")]
	private void ResetImage()
	{
	}
}