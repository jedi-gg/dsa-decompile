using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class CastPreviewSequencer : Sequencer
{
	[FieldOffset(Offset="0x4C")]
	[SerializeField]
	private bool _rotateToPreview;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private List<CastPreviewSequencer.RuntimeBinding> _runtimeBindings;

	public bool RotateToPreview
	{
		[Address(RVA="0x1196830", Offset="0x1196830", VA="0x1196830")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1196D2C", Offset="0x1196D2C", VA="0x1196D2C")]
	public CastPreviewSequencer()
	{
	}

	[Address(RVA="0x1196B3C", Offset="0x1196B3C", VA="0x1196B3C")]
	private void ApplyOverrides(GameObject caster)
	{
	}

	[Address(RVA="0x1196838", Offset="0x1196838", VA="0x1196838", Slot="5")]
	public override void Initialize(Action<ASequenceAction> actionPreInitializeCallback = // 
	// Current member / type: System.Void CastPreviewSequencer::Initialize(System.Action`1<Glunies.Sequencer.ASequenceAction>)
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


	[Address(RVA="0x1196A60", Offset="0x1196A60", VA="0x1196A60")]
	public void Play(BattleUnit caster)
	{
	}

	[Address(RVA="0x1196C14", Offset="0x1196C14", VA="0x1196C14")]
	public void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BD3C", Offset="0x104BD3C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public CastPreviewSequencer.RuntimeBinding bindingOverride;

		[Address(RVA="0x1196A50", Offset="0x1196A50", VA="0x1196A50")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1196D3C", Offset="0x1196D3C", VA="0x1196D3C")]
		internal bool <Initialize>b__0(Binding b)
		{
			return new bool();
		}
	}

	[Serializable]
	public class RuntimeBinding
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106A464", Offset="0x106A464")]
		[FieldOffset(Offset="0x10")]
		private Binding <Binding>k__BackingField;

		[FieldOffset(Offset="0x18")]
		public BindingDefinition Definition;

		public Binding Binding
		{
			[Address(RVA="0x1196D24", Offset="0x1196D24", VA="0x1196D24")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B298", Offset="0x108B298")]
			get
			{
				return null;
			}
			[Address(RVA="0x1196A58", Offset="0x1196A58", VA="0x1196A58")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B2A8", Offset="0x108B2A8")]
			set
			{
			}
		}

		[Address(RVA="0x1196D84", Offset="0x1196D84", VA="0x1196D84")]
		public RuntimeBinding()
		{
		}
	}

	public enum RuntimeBindingType
	{
		[FieldOffset(Offset="0x0")]
		Caster
	}
}