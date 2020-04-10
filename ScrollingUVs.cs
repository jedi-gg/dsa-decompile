using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="RequireComponent", RVA="0x10482F0", Offset="0x10482F0")]
public class ScrollingUVs : MonoBehaviour
{
	[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1051FDC", Offset="0x1051FDC")]
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private int _materialIndex;

	[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1052028", Offset="0x1052028")]
	[FieldOffset(Offset="0x1C")]
	[SerializeField]
	private Vector2 _uvAnimationRate;

	[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1052074", Offset="0x1052074")]
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private string _textureName;

	[FieldOffset(Offset="0x30")]
	private Vector2 _uvOffset;

	[FieldOffset(Offset="0x38")]
	private Material _cachedMaterial;

	[Address(RVA="0x2C40B64", Offset="0x2C40B64", VA="0x2C40B64")]
	public ScrollingUVs()
	{
	}

	[Address(RVA="0x2C40870", Offset="0x2C40870", VA="0x2C40870")]
	private void CacheMaterial()
	{
	}

	[Address(RVA="0x2C40A1C", Offset="0x2C40A1C", VA="0x2C40A1C")]
	private void LateUpdate()
	{
	}

	[Address(RVA="0x2C40770", Offset="0x2C40770", VA="0x2C40770")]
	private void Start()
	{
	}
}