using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UiAnimatedGradientEffect : BaseMeshEffect
{
	[FieldOffset(Offset="0x0")]
	private readonly static int s_offsetHash;

	[FieldOffset(Offset="0x4")]
	private readonly static int s_gradientStartColorHash;

	[FieldOffset(Offset="0x8")]
	private readonly static int s_gradientEndColorHash;

	[FieldOffset(Offset="0x20")]
	private UiAnimatedGradientEffect.Mode _mode;

	[FieldOffset(Offset="0x28")]
	private Material _instancedMaterial;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UiAnimatedGradientEffect.Type _gradientType;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private Material _material;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private Color _startGradientColor;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private Color _endGradientColor;

	[Address(RVA="0x158329C", Offset="0x158329C", VA="0x158329C")]
	static UiAnimatedGradientEffect()
	{
	}

	[Address(RVA="0x1583258", Offset="0x1583258", VA="0x1583258")]
	public UiAnimatedGradientEffect()
	{
	}

	[Address(RVA="0x1582EA4", Offset="0x1582EA4", VA="0x1582EA4", Slot="4")]
	protected override void Awake()
	{
	}

	[Address(RVA="0x1582CDC", Offset="0x1582CDC", VA="0x1582CDC", Slot="20")]
	public override void ModifyMesh(VertexHelper helper)
	{
	}

	[Address(RVA="0x15830E8", Offset="0x15830E8", VA="0x15830E8", Slot="8")]
	protected override void OnDestroy()
	{
	}

	[Address(RVA="0x158322C", Offset="0x158322C", VA="0x158322C", Slot="7")]
	protected override void OnDisable()
	{
	}

	[Address(RVA="0x15829DC", Offset="0x15829DC", VA="0x15829DC")]
	public void SetMode(UiAnimatedGradientEffect.Mode mode)
	{
	}

	[Address(RVA="0x1582C44", Offset="0x1582C44", VA="0x1582C44")]
	public void SetOffset(float offset)
	{
	}

	public enum Mode
	{
		[FieldOffset(Offset="0x0")]
		Disabled,
		[FieldOffset(Offset="0x0")]
		StartAnimation,
		[FieldOffset(Offset="0x0")]
		EndAnimation
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Horizontal,
		[FieldOffset(Offset="0x0")]
		Vertical
	}
}