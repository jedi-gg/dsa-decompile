using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="ExecuteInEditMode", RVA="0x104839C", Offset="0x104839C")]
[Attribute(Name="RequireComponent", RVA="0x104839C", Offset="0x104839C")]
public class BackdropCloud : ABackdropAnimatable
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private float _speedMin;

	[FieldOffset(Offset="0x1C")]
	[SerializeField]
	private float _speedMax;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private float _delayTimeMin;

	[FieldOffset(Offset="0x24")]
	[SerializeField]
	private float _delayTimeMax;

	[FieldOffset(Offset="0x28")]
	private DrivenRectTransformTracker _drivenRectTracker;

	[FieldOffset(Offset="0x30")]
	private RectTransform _rectTransform;

	[FieldOffset(Offset="0x38")]
	private Vector2 _canvasResolution;

	[FieldOffset(Offset="0x40")]
	private float _startX;

	[FieldOffset(Offset="0x44")]
	private float _delayTimer;

	[FieldOffset(Offset="0x48")]
	private float _speed;

	[Address(RVA="0x115EB84", Offset="0x115EB84", VA="0x115EB84")]
	public BackdropCloud()
	{
	}

	[Address(RVA="0x115E77C", Offset="0x115E77C", VA="0x115E77C", Slot="4")]
	public override void Initialize()
	{
	}

	[Address(RVA="0x115EB78", Offset="0x115EB78", VA="0x115EB78")]
	private void OnDisable()
	{
	}

	[Address(RVA="0x115E978", Offset="0x115E978", VA="0x115E978")]
	private void Reinitialize()
	{
	}

	[Address(RVA="0x115EB4C", Offset="0x115EB4C", VA="0x115EB4C")]
	private void ResetDelayTimer()
	{
	}

	[Address(RVA="0x115EAE4", Offset="0x115EAE4", VA="0x115EAE4")]
	private void SetAnchoredX(float x)
	{
	}

	[Address(RVA="0x115E9A4", Offset="0x115E9A4", VA="0x115E9A4", Slot="5")]
	public override void TickUpdate()
	{
	}
}