using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UiBarcodeModule : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private Image _strip;

	[Address(RVA="0x15848B4", Offset="0x15848B4", VA="0x15848B4")]
	public UiBarcodeModule()
	{
	}

	[Address(RVA="0x1583C18", Offset="0x1583C18", VA="0x1583C18")]
	public void SetValue(BitArray bits, Color whiteColor, Color blackColor)
	{
	}
}