using Il2CppDummyDll;
using System;
using UnityEngine;

public class StaticTransform : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private bool _staticPosition;

	[FieldOffset(Offset="0x1C")]
	[SerializeField]
	private StaticTransform.RelativeSpace _positionSpace;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private Vector3 _worldPosition;

	[FieldOffset(Offset="0x2C")]
	[SerializeField]
	private bool _staticRotation;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private StaticTransform.RelativeSpace _rotationSpace;

	[FieldOffset(Offset="0x34")]
	[SerializeField]
	private Vector3 _worldRotation;

	[Address(RVA="0x122783C", Offset="0x122783C", VA="0x122783C")]
	public StaticTransform()
	{
	}

	[Address(RVA="0x1227618", Offset="0x1227618", VA="0x1227618")]
	private void LateUpdate()
	{
	}

	public enum RelativeSpace
	{
		[FieldOffset(Offset="0x0")]
		World,
		[FieldOffset(Offset="0x0")]
		Local
	}
}