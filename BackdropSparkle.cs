using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="RequireComponent", RVA="0x1048474", Offset="0x1048474")]
public class BackdropSparkle : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private CanvasRenderer _canvasRenderer;

	[FieldOffset(Offset="0x20")]
	private float _speed;

	[FieldOffset(Offset="0x24")]
	[SerializeField]
	private float _speedRangeMin;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private float _speedRangeMax;

	[FieldOffset(Offset="0x2C")]
	[SerializeField]
	private float _minAlpha;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private float _maxAlpha;

	[Address(RVA="0x115FB34", Offset="0x115FB34", VA="0x115FB34")]
	public BackdropSparkle()
	{
	}

	[Address(RVA="0x115FAB4", Offset="0x115FAB4", VA="0x115FAB4")]
	private void Awake()
	{
	}

	[Address(RVA="0x115F9D4", Offset="0x115F9D4", VA="0x115F9D4")]
	public void TickUpdate()
	{
	}
}