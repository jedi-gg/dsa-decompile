using Il2CppDummyDll;
using System;
using UnityEngine;

public static class GlobalShaderPropertyUtil
{
	[FieldOffset(Offset="0x0")]
	private readonly static int s_scrimColorHash;

	[FieldOffset(Offset="0x4")]
	private readonly static Color s_scrimColorDefault;

	[Address(RVA="0x14ECC10", Offset="0x14ECC10", VA="0x14ECC10")]
	static GlobalShaderPropertyUtil()
	{
	}

	[Address(RVA="0x14ECAAC", Offset="0x14ECAAC", VA="0x14ECAAC")]
	public static void ClearAllProperties()
	{
	}

	[Address(RVA="0x14ECB08", Offset="0x14ECB08", VA="0x14ECB08")]
	public static void ClearScrimColor()
	{
	}

	[Address(RVA="0x14ECB74", Offset="0x14ECB74", VA="0x14ECB74")]
	public static void SetScrimColor(Color color)
	{
	}
}