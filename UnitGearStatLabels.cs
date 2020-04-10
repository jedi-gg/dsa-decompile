using Il2CppDummyDll;
using System;
using UnityEngine;

public class UnitGearStatLabels : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private RectTransform _rectTransform;

	[FieldOffset(Offset="0x20")]
	private float _height;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private UiLabel _statNameLabel;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UiLabel _statValueLabel;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private UiLabel _statBaseValueLabel;

	[Address(RVA="0x11F54F4", Offset="0x11F54F4", VA="0x11F54F4")]
	public UnitGearStatLabels()
	{
	}

	[Address(RVA="0x11F5468", Offset="0x11F5468", VA="0x11F5468")]
	private void Awake()
	{
	}

	[Address(RVA="0x11F4FC4", Offset="0x11F4FC4", VA="0x11F4FC4")]
	public void SetStatData(int currentStatIndex, string statName, int statValue, int baseValue, bool slotEquipped)
	{
	}

	[Address(RVA="0x11F5250", Offset="0x11F5250", VA="0x11F5250")]
	public void SetStatData(int currentStatIndex, string statName, float statValue, float baseValue, bool slotEquipped, string floatFormat = "N", string statValueFormat = // 
	// Current member / type: System.Void UnitGearStatLabels::SetStatData(System.Int32,System.String,System.Single,System.Single,System.Boolean,System.String,System.String)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void SetStatData(System.Int32,System.String,System.Single,System.Single,System.Boolean,System.String,System.String)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x11F51D4", Offset="0x11F51D4", VA="0x11F51D4")]
	private void SetYPos(int currentStatIndex)
	{
	}
}