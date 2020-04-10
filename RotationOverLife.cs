using Il2CppDummyDll;
using System;
using UnityEngine;

public class RotationOverLife : MonoBehaviour
{
	[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1051EF8", Offset="0x1051EF8")]
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private AnimationCurve _rotCurveX;

	[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1051F44", Offset="0x1051F44")]
	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private AnimationCurve _rotCurveY;

	[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1051F90", Offset="0x1051F90")]
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private AnimationCurve _rotCurveZ;

	[Address(RVA="0x2C3C960", Offset="0x2C3C960", VA="0x2C3C960")]
	public RotationOverLife()
	{
	}

	[Address(RVA="0x2C3C870", Offset="0x2C3C870", VA="0x2C3C870")]
	private void Update()
	{
	}
}