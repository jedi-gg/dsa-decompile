using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DoubleFilledImage : Image
{
	[FieldOffset(Offset="0x0")]
	private readonly static Vector3[] s_xy;

	[FieldOffset(Offset="0x8")]
	private readonly static Vector3[] s_uv;

	[Attribute(Name="RangeAttribute", RVA="0x105DC20", Offset="0x105DC20")]
	[FieldOffset(Offset="0xE0")]
	[SerializeField]
	private float _reverseFillAmount;

	private Sprite ActiveSprite
	{
		[Address(RVA="0x1204164", Offset="0x1204164", VA="0x1204164")]
		get
		{
			return null;
		}
	}

	public float ReverseFillAmount
	{
		[Address(RVA="0x1203F7C", Offset="0x1203F7C", VA="0x1203F7C")]
		get
		{
			return new float();
		}
		[Address(RVA="0x1203F84", Offset="0x1203F84", VA="0x1203F84")]
		set
		{
		}
	}

	[Address(RVA="0x12049F4", Offset="0x12049F4", VA="0x12049F4")]
	static DoubleFilledImage()
	{
	}

	[Address(RVA="0x120498C", Offset="0x120498C", VA="0x120498C")]
	public DoubleFilledImage()
	{
	}

	[Address(RVA="0x1204038", Offset="0x1204038", VA="0x1204038", Slot="4")]
	protected override void Awake()
	{
	}

	[Address(RVA="0x1204208", Offset="0x1204208", VA="0x1204208")]
	private void GenerateSprite(VertexHelper toFill, bool preserveAspect)
	{
	}

	[Address(RVA="0x12040A0", Offset="0x12040A0", VA="0x12040A0", Slot="44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Address(RVA="0x120403C", Offset="0x120403C", VA="0x120403C")]
	private void ResetImage()
	{
	}
}