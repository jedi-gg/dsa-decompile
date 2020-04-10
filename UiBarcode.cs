using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiBarcode : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	private const int CODE_93_STRIP_LENGTH = 9;

	[FieldOffset(Offset="0x0")]
	private readonly static Dictionary<char, BitArray> s_charEncoding;

	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private Color _whiteColor;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Color _blackColor;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private UiBarcodeModule _module;

	[Address(RVA="0x15840E4", Offset="0x15840E4", VA="0x15840E4")]
	static UiBarcode()
	{
	}

	[Address(RVA="0x15840A0", Offset="0x15840A0", VA="0x15840A0")]
	public UiBarcode()
	{
	}

	[Address(RVA="0x1583FC0", Offset="0x1583FC0", VA="0x1583FC0")]
	private static BitArray FromBinary(int binary)
	{
		return null;
	}

	[Address(RVA="0x1583824", Offset="0x1583824", VA="0x1583824")]
	public void SetText(string text)
	{
	}
}