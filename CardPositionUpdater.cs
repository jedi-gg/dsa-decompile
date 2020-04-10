using Il2CppDummyDll;
using System;
using UnityEngine;

public class CardPositionUpdater : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private GameObject geoObj;

	[FieldOffset(Offset="0x20")]
	private Material mat;

	[FieldOffset(Offset="0x28")]
	private float pos;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private GameObject objB;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private GameObject card;

	[FieldOffset(Offset="0x40")]
	private Vector4 holder;

	[FieldOffset(Offset="0x50")]
	private Plane plane;

	[Address(RVA="0x11909CC", Offset="0x11909CC", VA="0x11909CC")]
	public CardPositionUpdater()
	{
	}

	[Address(RVA="0x1190658", Offset="0x1190658", VA="0x1190658")]
	private void Start()
	{
	}

	[Address(RVA="0x1190778", Offset="0x1190778", VA="0x1190778")]
	private void Update()
	{
	}
}