using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ScrollRectInputToggler : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private RectTransform _scrollRectViewportTransform;

	[FieldOffset(Offset="0x20")]
	private RectTransform _scrollRectContentTransform;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private ScrollRect _scrollRect;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private Graphic _scrollRectInputHandler;

	[Address(RVA="0x2C40768", Offset="0x2C40768", VA="0x2C40768")]
	public ScrollRectInputToggler()
	{
	}

	[Address(RVA="0x2C40440", Offset="0x2C40440", VA="0x2C40440")]
	private void Awake()
	{
	}

	[Address(RVA="0x2C40550", Offset="0x2C40550", VA="0x2C40550")]
	private void OnRectTransformDimensionsChange()
	{
	}
}