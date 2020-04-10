using Il2CppDummyDll;
using System;
using UnityEngine;

public class BackdropStar : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private RectTransform _rectTransform;

	[FieldOffset(Offset="0x20")]
	private Vector2 _canvasReferenceResolution;

	[FieldOffset(Offset="0x28")]
	private float _minStartingX;

	[FieldOffset(Offset="0x2C")]
	private float _maxStartingX;

	[FieldOffset(Offset="0x30")]
	private float _slope;

	[FieldOffset(Offset="0x34")]
	private float _yIntercept;

	[FieldOffset(Offset="0x38")]
	private float _speed;

	[FieldOffset(Offset="0x3C")]
	private float _speedScale;

	[FieldOffset(Offset="0x40")]
	private float _delayTimer;

	[FieldOffset(Offset="0x44")]
	[SerializeField]
	private float _sizeMin;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private float _sizeMax;

	[FieldOffset(Offset="0x4C")]
	[SerializeField]
	private float _speedMin;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private float _speedMax;

	[FieldOffset(Offset="0x54")]
	[SerializeField]
	private float _delayTimeMin;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private float _delayTimeMax;

	[Attribute(Name="RangeAttribute", RVA="0x1052870", Offset="0x1052870")]
	[FieldOffset(Offset="0x5C")]
	[SerializeField]
	private float _angle;

	[Address(RVA="0x115FFF0", Offset="0x115FFF0", VA="0x115FFF0")]
	public BackdropStar()
	{
	}

	[Address(RVA="0x115FB3C", Offset="0x115FB3C", VA="0x115FB3C")]
	public void Initialize()
	{
	}

	[Address(RVA="0x115FCF4", Offset="0x115FCF4", VA="0x115FCF4")]
	private void Reinitialize()
	{
	}

	[Address(RVA="0x115FCC8", Offset="0x115FCC8", VA="0x115FCC8")]
	private void ResetDelayTimer()
	{
	}

	[Address(RVA="0x115FE10", Offset="0x115FE10", VA="0x115FE10")]
	public void TickUpdate()
	{
	}
}