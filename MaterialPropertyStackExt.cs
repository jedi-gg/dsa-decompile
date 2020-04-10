using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class MaterialPropertyStackExt
{
	[Address(RVA="0x11DB0C0", Offset="0x11DB0C0", VA="0x11DB0C0")]
	private static MaterialPropertyStack GetOrCreateMps(GameObject go, List<Renderer> renderers = // 
	// Current member / type: MaterialPropertyStack MaterialPropertyStackExt::GetOrCreateMps(UnityEngine.GameObject,System.Collections.Generic.List`1<UnityEngine.Renderer>)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: MaterialPropertyStack GetOrCreateMps(UnityEngine.GameObject,System.Collections.Generic.List<UnityEngine.Renderer>)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x11DB0BC", Offset="0x11DB0BC", VA="0x11DB0BC")]
	public static void MaterialStackCreate(GameObject go, List<Renderer> renderers)
	{
	}

	[Address(RVA="0x11DB5A0", Offset="0x11DB5A0", VA="0x11DB5A0")]
	public static void MaterialStackEndColor(GameObject go, int stackId, int propertyId)
	{
	}

	[Address(RVA="0x11DB2C0", Offset="0x11DB2C0", VA="0x11DB2C0")]
	public static void MaterialStackEndFloat(GameObject go, int stackId, int propertyId)
	{
	}

	[Address(RVA="0x11DB674", Offset="0x11DB674", VA="0x11DB674")]
	public static Color MaterialStackGetColor(GameObject go, int propertyId)
	{
		return new Color();
	}

	[Address(RVA="0x11DB394", Offset="0x11DB394", VA="0x11DB394")]
	public static float MaterialStackGetFloat(GameObject go, int propertyId)
	{
		return new float();
	}

	[Address(RVA="0x11DB464", Offset="0x11DB464", VA="0x11DB464")]
	public static void MaterialStackSetColor(GameObject go, ref int stackId, int propertyId, Color value)
	{
	}

	[Address(RVA="0x11DB1A8", Offset="0x11DB1A8", VA="0x11DB1A8")]
	public static void MaterialStackSetFloat(GameObject go, ref int stackId, int propertyId, float value)
	{
	}
}