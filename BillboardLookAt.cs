using Il2CppDummyDll;
using System;
using UnityEngine;

public class BillboardLookAt : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private Camera _mainCamera;

	[FieldOffset(Offset="0x20")]
	private Transform _transform;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Vector3 _finalLocalRotationOffset;

	[Address(RVA="0x111EFAC", Offset="0x111EFAC", VA="0x111EFAC")]
	public BillboardLookAt()
	{
	}

	[Address(RVA="0x111EDF0", Offset="0x111EDF0", VA="0x111EDF0")]
	private void Start()
	{
	}

	[Address(RVA="0x111EE28", Offset="0x111EE28", VA="0x111EE28")]
	private void Update()
	{
	}
}