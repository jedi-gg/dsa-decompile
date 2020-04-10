using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ViewSequencer : Sequencer
{
	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private List<ViewSequencer.RuntimeBinding> _viewRuntimeBindings;

	[Address(RVA="0x15A389C", Offset="0x15A389C", VA="0x15A389C")]
	public ViewSequencer()
	{
	}

	[Address(RVA="0x15A37A0", Offset="0x15A37A0", VA="0x15A37A0", Slot="7")]
	protected virtual void ApplyOverrides(AView view)
	{
	}

	[Address(RVA="0x15A3744", Offset="0x15A3744", VA="0x15A3744")]
	public void EndImmediately()
	{
	}

	[Address(RVA="0x15A3470", Offset="0x15A3470", VA="0x15A3470", Slot="5")]
	public override void Initialize(Action<ASequenceAction> actionPreInitializeCallback = // 
	// Current member / type: System.Void ViewSequencer::Initialize(System.Action`1<Glunies.Sequencer.ASequenceAction>)
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


	[Address(RVA="0x15A3698", Offset="0x15A3698", VA="0x15A3698")]
	public void Play(AView view)
	{
	}

	[Address(RVA="0x15A36D4", Offset="0x15A36D4", VA="0x15A36D4")]
	public void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CE4C", Offset="0x104CE4C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ViewSequencer.RuntimeBinding bindingOverride;

		[Address(RVA="0x15A3688", Offset="0x15A3688", VA="0x15A3688")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x15A38A4", Offset="0x15A38A4", VA="0x15A38A4")]
		internal bool <Initialize>b__0(Binding b)
		{
			return new bool();
		}
	}

	[Serializable]
	public class RuntimeBinding
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106BF1C", Offset="0x106BF1C")]
		[FieldOffset(Offset="0x10")]
		private Binding <Binding>k__BackingField;

		[FieldOffset(Offset="0x18")]
		public BindingDefinition Definition;

		public Binding Binding
		{
			[Address(RVA="0x15A3894", Offset="0x15A3894", VA="0x15A3894")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B8BC", Offset="0x108B8BC")]
			get
			{
				return null;
			}
			[Address(RVA="0x15A3690", Offset="0x15A3690", VA="0x15A3690")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B8CC", Offset="0x108B8CC")]
			set
			{
			}
		}

		[Address(RVA="0x15A38EC", Offset="0x15A38EC", VA="0x15A38EC")]
		public RuntimeBinding()
		{
		}
	}

	public enum ViewRuntimeBindingType
	{
		[FieldOffset(Offset="0x0")]
		View
	}
}