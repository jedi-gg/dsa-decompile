using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="RequireComponent", RVA="0x10490E0", Offset="0x10490E0")]
public class AnimatedDoubleFilledImage : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private DoubleFilledImage _doubleFilledImage;

	[Attribute(Name="RangeAttribute", RVA="0x105E88C", Offset="0x105E88C")]
	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private float _length;

	[FieldOffset(Offset="0x24")]
	[SerializeField]
	private float _speed;

	[Address(RVA="0x115BEC4", Offset="0x115BEC4", VA="0x115BEC4")]
	public AnimatedDoubleFilledImage()
	{
	}

	[Address(RVA="0x115BBD0", Offset="0x115BBD0", VA="0x115BBD0")]
	private void Awake()
	{
	}

	[Address(RVA="0x115BCD0", Offset="0x115BCD0", VA="0x115BCD0")]
	private void Update()
	{
	}
}