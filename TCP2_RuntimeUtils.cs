using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public static class TCP2_RuntimeUtils
{
	[FieldOffset(Offset="0x0")]
	private const string BASE_SHADER_PATH = "Toony Colors Pro 2/";

	[FieldOffset(Offset="0x0")]
	private const string VARIANT_SHADER_PATH = "Hidden/Toony Colors Pro 2/Variants/";

	[FieldOffset(Offset="0x0")]
	private const string BASE_SHADER_NAME = "Desktop";

	[FieldOffset(Offset="0x0")]
	private const string BASE_SHADER_NAME_MOB = "Mobile";

	[FieldOffset(Offset="0x0")]
	private static List<string[]> ShaderVariants;

	[Address(RVA="0x1320A54", Offset="0x1320A54", VA="0x1320A54")]
	static TCP2_RuntimeUtils()
	{
	}

	[Address(RVA="0x132067C", Offset="0x132067C", VA="0x132067C")]
	public static Shader GetShaderWithKeywords(Material material)
	{
		return null;
	}
}