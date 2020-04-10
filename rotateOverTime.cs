using Il2CppDummyDll;
using System;
using UnityEngine;

public class rotateOverTime : MonoBehaviour
{
	[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1051EAC", Offset="0x1051EAC")]
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private float _rotationSpeed;

	[Address(RVA="0x23417C4", Offset="0x23417C4", VA="0x23417C4")]
	public rotateOverTime()
	{
	}

	[Address(RVA="0x23416D8", Offset="0x23416D8", VA="0x23416D8")]
	private void FixedUpdate()
	{
	}

	[Address(RVA="0x2341698", Offset="0x2341698", VA="0x2341698")]
	private void Start()
	{
	}
}