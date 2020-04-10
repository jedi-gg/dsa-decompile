using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class UiTabGroup : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x20")]
	private BadgingController _badgingController;

	[FieldOffset(Offset="0x28")]
	private UiInputReactController _inputReactController;

	[FieldOffset(Offset="0x30")]
	private FeatureLockController _featureLockController;

	[FieldOffset(Offset="0x38")]
	private int _selectedIndex;

	[FieldOffset(Offset="0x3C")]
	private int _previousSelectedIndex;

	[FieldOffset(Offset="0x40")]
	private bool _initialized;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private List<UiTab> _tabs;

	public int SelectedIndex
	{
		[Address(RVA="0x158D548", Offset="0x158D548", VA="0x158D548")]
		get
		{
			return new int();
		}
	}

	public int TabCount
	{
		[Address(RVA="0x158D550", Offset="0x158D550", VA="0x158D550")]
		get
		{
			return new int();
		}
	}

	[Address(RVA="0x158E3A8", Offset="0x158E3A8", VA="0x158E3A8")]
	public UiTabGroup()
	{
	}

	[Address(RVA="0x158DBA4", Offset="0x158DBA4", VA="0x158DBA4")]
	public void AppendTab(UiTab tab)
	{
	}

	[Address(RVA="0x158DF70", Offset="0x158DF70", VA="0x158DF70")]
	public UiTab GetTab(int index)
	{
		return null;
	}

	[Address(RVA="0x158E01C", Offset="0x158E01C", VA="0x158E01C")]
	public int GetTabIndex(UiTab tab)
	{
		return new int();
	}

	[Address(RVA="0x158D5B0", Offset="0x158D5B0", VA="0x158D5B0")]
	public void Initialize(WidgetDependencyContainer dependencies, int? selectedTabIndex = // 
	// Current member / type: System.Void UiTabGroup::Initialize(Glunies.WidgetDependencyContainer,System.Nullable`1<System.Int32>)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void Initialize(Glunies.WidgetDependencyContainer,System.Nullable<System.Int32>)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x158D7BC", Offset="0x158D7BC", VA="0x158D7BC")]
	private void InitializeTab(UiTab tab, int tabIndex)
	{
	}

	[Address(RVA="0x158DC60", Offset="0x158DC60", VA="0x158DC60")]
	public void RemoveTab(UiTab tab)
	{
	}

	[Address(RVA="0x158E394", Offset="0x158E394", VA="0x158E394")]
	public void RevertToPreviousSelectedIndex()
	{
	}

	[Address(RVA="0x158E0F4", Offset="0x158E0F4", VA="0x158E0F4")]
	public bool SetSelectedTab(int index, bool force = false)
	{
		return new bool();
	}

	[Address(RVA="0x158DA18", Offset="0x158DA18", VA="0x158DA18")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x158D970", Offset="0x158D970", VA="0x158D970")]
	public void TabClicked(int index)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CF8C", Offset="0x104CF8C")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset="0x10")]
		public UiTabGroup <>4__this;

		[FieldOffset(Offset="0x18")]
		public int tabIndex;

		[Address(RVA="0x158E3A0", Offset="0x158E3A0", VA="0x158E3A0")]
		public <>c__DisplayClass13_0()
		{
		}

		[Address(RVA="0x158E3B8", Offset="0x158E3B8", VA="0x158E3B8")]
		internal void <InitializeTab>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CF6C", Offset="0x104CF6C")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset="0x10")]
		public int tabIndexClosure;

		[FieldOffset(Offset="0x18")]
		public UiTabGroup <>4__this;

		[Address(RVA="0x158DF68", Offset="0x158DF68", VA="0x158DF68")]
		public <>c__DisplayClass7_0()
		{
		}

		[Address(RVA="0x158E3EC", Offset="0x158E3EC", VA="0x158E3EC")]
		internal void <RemoveTab>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CF7C", Offset="0x104CF7C")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset="0x10")]
		public UiTab tab;

		[Address(RVA="0x158E0EC", Offset="0x158E0EC", VA="0x158E0EC")]
		public <>c__DisplayClass9_0()
		{
		}

		[Address(RVA="0x158E420", Offset="0x158E420", VA="0x158E420")]
		internal bool <GetTabIndex>b__0(UiTab _tab)
		{
			return new bool();
		}
	}
}