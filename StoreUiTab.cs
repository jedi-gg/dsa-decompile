using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class StoreUiTab : UiTab
{
	[FieldOffset(Offset="0x60")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x68")]
	private ulong _storeTabId;

	[FieldOffset(Offset="0x70")]
	private DateTime? _freeItemAvailableTime;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private RawImage _icon;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private GameObject _freeIndicator;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private UiLabel _freeLabel;

	public ulong Id
	{
		[Address(RVA="0x131650C", Offset="0x131650C", VA="0x131650C")]
		get
		{
			return new ulong();
		}
	}

	[Address(RVA="0x1316C54", Offset="0x1316C54", VA="0x1316C54")]
	public StoreUiTab()
	{
	}

	[Address(RVA="0x1316514", Offset="0x1316514", VA="0x1316514")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1316750", Offset="0x1316750", VA="0x1316750")]
	public void SetData(StoreTabData storeTab)
	{
	}

	[Address(RVA="0x1316668", Offset="0x1316668", VA="0x1316668")]
	public void ShowFreeIndicator(bool show, string textKey = // 
	// Current member / type: System.Void StoreUiTab::ShowFreeIndicator(System.Boolean,System.String)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void ShowFreeIndicator(System.Boolean,System.String)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1316548", Offset="0x1316548", VA="0x1316548")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1316550", Offset="0x1316550", VA="0x1316550")]
	public void TickUpdate()
	{
	}
}