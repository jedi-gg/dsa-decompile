using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ClubDungeonDoorSelectViewSequencer : ViewSequencer
{
	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private List<ViewSequencer.RuntimeBinding> _runtimeBindings;

	[Address(RVA="0x11AEDF4", Offset="0x11AEDF4", VA="0x11AEDF4")]
	public ClubDungeonDoorSelectViewSequencer()
	{
	}

	[Address(RVA="0x11AEC64", Offset="0x11AEC64", VA="0x11AEC64", Slot="7")]
	protected override void ApplyOverrides(AView view)
	{
	}

	[Address(RVA="0x11AEA38", Offset="0x11AEA38", VA="0x11AEA38", Slot="5")]
	public override void Initialize(Action<ASequenceAction> actionPreInitializeCallback = // 
	// Current member / type: System.Void ClubDungeonDoorSelectViewSequencer::Initialize(System.Action`1<Glunies.Sequencer.ASequenceAction>)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void Initialize(System.Action<Glunies.Sequencer.ASequenceAction>)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B94C", Offset="0x104B94C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ViewSequencer.RuntimeBinding bindingOverride;

		[Address(RVA="0x11AEC5C", Offset="0x11AEC5C", VA="0x11AEC5C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11AEDFC", Offset="0x11AEDFC", VA="0x11AEDFC")]
		internal bool <Initialize>b__0(Binding b)
		{
			return new bool();
		}
	}

	public enum RuntimeBindingType
	{
		[FieldOffset(Offset="0x0")]
		Door,
		[FieldOffset(Offset="0x0")]
		DoorOriginalPos,
		[FieldOffset(Offset="0x0")]
		CenterPos,
		[FieldOffset(Offset="0x0")]
		ContinueButton,
		[FieldOffset(Offset="0x0")]
		FullscreenInput
	}
}