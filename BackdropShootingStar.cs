using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="RequireComponent", RVA="0x1048410", Offset="0x1048410")]
public class BackdropShootingStar : ABackdropAnimatable
{
	[FieldOffset(Offset="0x0")]
	private static float SLOPE;

	[FieldOffset(Offset="0x0")]
	private const float SPEED_UP_DURATION = 1f;

	[FieldOffset(Offset="0x0")]
	private const float STAR_FALL_DURATION = 2f;

	[FieldOffset(Offset="0x0")]
	private const float STAR_FADE_IN_DURATION = 0.4f;

	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private RectTransform _spawnContainer;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private CanvasGroup _star;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private float _speedMin;

	[FieldOffset(Offset="0x2C")]
	[SerializeField]
	private float _speedMax;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private float _delayTimeMin;

	[FieldOffset(Offset="0x34")]
	[SerializeField]
	private float _delayTimeMax;

	[FieldOffset(Offset="0x38")]
	private float _delayTimer;

	[FieldOffset(Offset="0x3C")]
	private float _timer;

	[FieldOffset(Offset="0x40")]
	private float _targetSpeed;

	private RectTransform StarRect
	{
		[Address(RVA="0x115F868", Offset="0x115F868", VA="0x115F868")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x115F95C", Offset="0x115F95C", VA="0x115F95C")]
	static BackdropShootingStar()
	{
	}

	[Address(RVA="0x115F954", Offset="0x115F954", VA="0x115F954")]
	public BackdropShootingStar()
	{
	}

	[Address(RVA="0x115F8E0", Offset="0x115F8E0", VA="0x115F8E0")]
	private float GetCurrentSpeed()
	{
		return new float();
	}

	[Address(RVA="0x115F530", Offset="0x115F530", VA="0x115F530", Slot="4")]
	public override void Initialize()
	{
	}

	[Address(RVA="0x115F534", Offset="0x115F534", VA="0x115F534")]
	private void Reinitialize()
	{
	}

	[Address(RVA="0x115F640", Offset="0x115F640", VA="0x115F640", Slot="5")]
	public override void TickUpdate()
	{
	}
}