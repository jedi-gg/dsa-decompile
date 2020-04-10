using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class UiAnimatedGradientEffectController
{
	[FieldOffset(Offset="0x0")]
	private const float WAIT_TIME_S = 3f;

	[FieldOffset(Offset="0x0")]
	private const float TOTAL_ANIMATE_TIME_S = 0.65f;

	[FieldOffset(Offset="0x0")]
	private const float HALF_ANIMATE_TIME_S = 0.325f;

	[FieldOffset(Offset="0x0")]
	private static UiAnimatedGradientEffectController s_instance;

	[FieldOffset(Offset="0x10")]
	private List<UiAnimatedGradientEffect> _animatedGradients;

	[FieldOffset(Offset="0x18")]
	private UiAnimatedGradientEffect.Mode _mode;

	[FieldOffset(Offset="0x1C")]
	private float _timer;

	private float Offset
	{
		[Address(RVA="0x1583340", Offset="0x1583340", VA="0x1583340")]
		get
		{
			return new float();
		}
	}

	[Address(RVA="0x15837A8", Offset="0x15837A8", VA="0x15837A8")]
	public UiAnimatedGradientEffectController()
	{
	}

	[Address(RVA="0x1583360", Offset="0x1583360", VA="0x1583360")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1582FC8", Offset="0x1582FC8", VA="0x1582FC8")]
	public static void Register(UiAnimatedGradientEffect gradientEffect)
	{
	}

	[Address(RVA="0x15833B4", Offset="0x15833B4", VA="0x15833B4")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x158342C", Offset="0x158342C", VA="0x158342C")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x15831A4", Offset="0x15831A4", VA="0x15831A4")]
	public static void Unregister(UiAnimatedGradientEffect gradientEffect)
	{
	}

	[Address(RVA="0x1583524", Offset="0x1583524", VA="0x1583524")]
	private void UpdateGradientMode()
	{
	}

	[Address(RVA="0x1583658", Offset="0x1583658", VA="0x1583658")]
	private void UpdateGradientOffset()
	{
	}
}