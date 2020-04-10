using Il2CppDummyDll;
using System;
using UnityEngine;

public class BobOnYAxis : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private float _speedMetersPerSecond;

	[Attribute(Name="RangeAttribute", RVA="0x1051E2C", Offset="0x1051E2C")]
	[FieldOffset(Offset="0x1C")]
	[SerializeField]
	private float _phaseOffset;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private float _movementRangeInUnits;

	[FieldOffset(Offset="0x24")]
	private float _initialYPosition;

	[FieldOffset(Offset="0x28")]
	private float _pingpong;

	[Address(RVA="0x111F1E0", Offset="0x111F1E0", VA="0x111F1E0")]
	public BobOnYAxis()
	{
	}

	[Address(RVA="0x111F024", Offset="0x111F024", VA="0x111F024")]
	private void Awake()
	{
	}

	[Address(RVA="0x111F064", Offset="0x111F064", VA="0x111F064")]
	private void FixedUpdate()
	{
	}
}