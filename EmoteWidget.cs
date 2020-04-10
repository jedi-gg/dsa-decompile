using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class EmoteWidget : MonoBehaviour
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1057CD4", Offset="0x1057CD4")]
	[FieldOffset(Offset="0x18")]
	private bool <IsPlaying>k__BackingField;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private RawImage _image;

	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x30")]
	private SingleAssetRegistry _emoteDataRegistry;

	[FieldOffset(Offset="0x38")]
	private SingleAssetRegistry _emoteIconRegistry;

	[FieldOffset(Offset="0x40")]
	private object _ownerIdentifier;

	[FieldOffset(Offset="0x48")]
	private EmoteData _data;

	[FieldOffset(Offset="0x50")]
	private EmoteData _tempData;

	[FieldOffset(Offset="0x58")]
	private Texture _icon;

	[FieldOffset(Offset="0x60")]
	private float _playTimeS;

	[FieldOffset(Offset="0x64")]
	private bool _playAfterLoad;

	[FieldOffset(Offset="0x65")]
	private bool _loop;

	private EmoteData Data
	{
		[Address(RVA="0x120CB44", Offset="0x120CB44", VA="0x120CB44")]
		get
		{
			return null;
		}
	}

	public RawImage Image
	{
		[Address(RVA="0x12092EC", Offset="0x12092EC", VA="0x12092EC")]
		get
		{
			return null;
		}
	}

	public bool IsPlaying
	{
		[Address(RVA="0x120CA20", Offset="0x120CA20", VA="0x120CA20")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F5A4", Offset="0x106F5A4")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x120CA28", Offset="0x120CA28", VA="0x120CA28")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F5B4", Offset="0x106F5B4")]
		private set
		{
		}
	}

	[Address(RVA="0x120CC04", Offset="0x120CC04", VA="0x120CC04")]
	public EmoteWidget()
	{
	}

	[Address(RVA="0x1208B18", Offset="0x1208B18", VA="0x1208B18")]
	public void Initialize(WidgetDependencyContainer dependencies, object ownerIdentifier = // 
	// Current member / type: System.Void EmoteWidget::Initialize(Glunies.WidgetDependencyContainer,System.Object)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void Initialize(Glunies.WidgetDependencyContainer,System.Object)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x12092F4", Offset="0x12092F4", VA="0x12092F4")]
	public void LoadEmote(InventoryItem emoteItem)
	{
	}

	[Address(RVA="0x120947C", Offset="0x120947C", VA="0x120947C")]
	public void LoadIcon(InventoryItem emoteItem, Action finished = // 
	// Current member / type: System.Void EmoteWidget::LoadIcon(Gamedata.InventoryItem,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void LoadIcon(Gamedata.InventoryItem,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x12097C8", Offset="0x12097C8", VA="0x12097C8")]
	public void Play(bool loop = false)
	{
	}

	[Address(RVA="0x120CBD4", Offset="0x120CBD4", VA="0x120CBD4")]
	public void Play(EmoteData data)
	{
	}

	[Address(RVA="0x120CA34", Offset="0x120CA34", VA="0x120CA34")]
	private void ResetEmote()
	{
	}

	[Address(RVA="0x1208CE8", Offset="0x1208CE8", VA="0x1208CE8")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x12091A8", Offset="0x12091A8", VA="0x12091A8")]
	public void Stop()
	{
	}

	[Address(RVA="0x1208D40", Offset="0x1208D40", VA="0x1208D40")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x12095AC", Offset="0x12095AC", VA="0x12095AC")]
	public void UnloadEmote()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BD5C", Offset="0x104BD5C")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset="0x10")]
		public EmoteWidget <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x120CB34", Offset="0x120CB34", VA="0x120CB34")]
		public <>c__DisplayClass8_0()
		{
		}

		[Address(RVA="0x120CC0C", Offset="0x120CC0C", VA="0x120CC0C")]
		internal void <LoadIcon>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BD6C", Offset="0x104BD6C")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset="0x10")]
		public EmoteWidget <>4__this;

		[FieldOffset(Offset="0x18")]
		public InventoryItem emoteItem;

		[Address(RVA="0x120CB3C", Offset="0x120CB3C", VA="0x120CB3C")]
		public <>c__DisplayClass9_0()
		{
		}

		[Address(RVA="0x120CC94", Offset="0x120CC94", VA="0x120CC94")]
		internal void <LoadEmote>b__0(Action done)
		{
		}

		[Address(RVA="0x120CCDC", Offset="0x120CCDC", VA="0x120CCDC")]
		internal void <LoadEmote>b__1(Action done)
		{
		}

		[Address(RVA="0x120CE60", Offset="0x120CE60", VA="0x120CE60")]
		internal void <LoadEmote>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BD7C", Offset="0x104BD7C")]
	private sealed class <>c__DisplayClass9_1
	{
		[FieldOffset(Offset="0x10")]
		public Action done;

		[FieldOffset(Offset="0x18")]
		public EmoteWidget.<>c__DisplayClass9_0 CS$<>8__locals1;

		[Address(RVA="0x120CE58", Offset="0x120CE58", VA="0x120CE58")]
		public <>c__DisplayClass9_1()
		{
		}

		[Address(RVA="0x120CEE8", Offset="0x120CEE8", VA="0x120CEE8")]
		internal void <LoadEmote>b__3(AssetHandle handle)
		{
		}
	}
}