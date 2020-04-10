using Il2CppDummyDll;
using System;
using UnityEngine;

public class UiSafeArea : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private RectTransform _rectTransform;

	[FieldOffset(Offset="0x20")]
	private Rect _nativeSafeArea;

	[Address(RVA="0x158B2C0", Offset="0x158B2C0", VA="0x158B2C0")]
	public UiSafeArea()
	{
	}

	[Address(RVA="0x158AFF0", Offset="0x158AFF0", VA="0x158AFF0", Slot="4")]
	protected virtual void Awake()
	{
	}

	[Address(RVA="0x158B280", Offset="0x158B280", VA="0x158B280")]
	private static Rect GetSafeArea()
	{
		return new Rect();
	}

	[Address(RVA="0x158B074", Offset="0x158B074", VA="0x158B074")]
	private void SizeToSafeArea()
	{
	}

	[Address(RVA="0x158B228", Offset="0x158B228", VA="0x158B228", Slot="5")]
	protected virtual void Update()
	{
	}
}