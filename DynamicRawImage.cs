using DG.Tweening;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicRawImage
{
	[FieldOffset(Offset="0x0")]
	private const float FADE_DELAY = 0.5f;

	[FieldOffset(Offset="0x0")]
	private const float FADE_DURATION = 0.3f;

	[FieldOffset(Offset="0x10")]
	private RawImage _rawImage;

	[FieldOffset(Offset="0x18")]
	private Sequence _revealSeq;

	[FieldOffset(Offset="0x20")]
	private Sequence _swapSeq;

	[FieldOffset(Offset="0x28")]
	private Queue<Texture> _swapTextures;

	[Address(RVA="0x1205CF8", Offset="0x1205CF8", VA="0x1205CF8")]
	public DynamicRawImage(RawImage rawImage)
	{
	}

	[Address(RVA="0x1206078", Offset="0x1206078", VA="0x1206078")]
	public void Reveal()
	{
	}

	[Address(RVA="0x1206244", Offset="0x1206244", VA="0x1206244")]
	private void SequenceComplete()
	{
	}

	[Address(RVA="0x12060E4", Offset="0x12060E4", VA="0x12060E4")]
	public void SetTexture(Texture texture)
	{
	}

	[Address(RVA="0x1205FCC", Offset="0x1205FCC", VA="0x1205FCC")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1206188", Offset="0x1206188", VA="0x1206188")]
	private void SwapTexture()
	{
	}
}