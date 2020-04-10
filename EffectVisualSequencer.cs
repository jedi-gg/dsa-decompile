using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class EffectVisualSequencer : Sequencer
{
	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private List<EffectVisualSequencer.RuntimeBinding> _runtimeBindings;

	[FieldOffset(Offset="0x58")]
	private EffectVisualSequencer.DVisualContext _context;

	public EffectVisualSequencer.DVisualContext Context
	{
		[Address(RVA="0x12064A4", Offset="0x12064A4", VA="0x12064A4")]
		get
		{
			return new EffectVisualSequencer.DVisualContext();
		}
	}

	[Address(RVA="0x1206AE0", Offset="0x1206AE0", VA="0x1206AE0")]
	public EffectVisualSequencer()
	{
	}

	[Address(RVA="0x1206728", Offset="0x1206728", VA="0x1206728")]
	private void ApplyOverrides(float duration, GameObject caster = // 
	// Current member / type: System.Void EffectVisualSequencer::ApplyOverrides(System.Single,UnityEngine.GameObject,UnityEngine.GameObject,UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.GameObject)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void ApplyOverrides(System.Single,UnityEngine.GameObject,UnityEngine.GameObject,UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.GameObject)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x12064AC", Offset="0x12064AC", VA="0x12064AC", Slot="5")]
	public override void Initialize(Action<ASequenceAction> actionPreInitializeCallback = // 
	// Current member / type: System.Void EffectVisualSequencer::Initialize(System.Action`1<Glunies.Sequencer.ASequenceAction>)
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


	[Address(RVA="0x12066D4", Offset="0x12066D4", VA="0x12066D4")]
	public void Play(float duration, GameObject caster, GameObject target, GameObject groundPlane, EffectVisualSequencer.DVisualContext context)
	{
	}

	[Address(RVA="0x12068B8", Offset="0x12068B8", VA="0x12068B8")]
	public void Play(float duration, GameObject caster, Vector3 targetPos, GameObject groundPlane, EffectVisualSequencer.DVisualContext context)
	{
	}

	[Address(RVA="0x120690C", Offset="0x120690C", VA="0x120690C")]
	public void Play(float duration, Vector3 originPos, Vector3 targetPos, GameObject groundPlane, EffectVisualSequencer.DVisualContext context)
	{
	}

	[Address(RVA="0x12069F4", Offset="0x12069F4", VA="0x12069F4", Slot="6")]
	protected override void PlayAction(ASequenceAction action)
	{
	}

	[Address(RVA="0x120697C", Offset="0x120697C", VA="0x120697C")]
	public void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BD4C", Offset="0x104BD4C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public EffectVisualSequencer.RuntimeBinding bindingOverride;

		[Address(RVA="0x12066C4", Offset="0x12066C4", VA="0x12066C4")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1206AE8", Offset="0x1206AE8", VA="0x1206AE8")]
		internal bool <Initialize>b__0(Binding b)
		{
			return new bool();
		}
	}

	public struct DVisualContext
	{
		[FieldOffset(Offset="0x0")]
		public readonly ushort SourceId;

		[Address(RVA="0xEFD11C", Offset="0xEFD11C", VA="0xEFD11C")]
		public DVisualContext(ushort sourceId)
		{
		}
	}

	[Serializable]
	public class RuntimeBinding
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106A474", Offset="0x106A474")]
		[FieldOffset(Offset="0x10")]
		private Binding <Binding>k__BackingField;

		[FieldOffset(Offset="0x18")]
		public BindingDefinition Definition;

		public Binding Binding
		{
			[Address(RVA="0x12069EC", Offset="0x12069EC", VA="0x12069EC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B2B8", Offset="0x108B2B8")]
			get
			{
				return null;
			}
			[Address(RVA="0x12066CC", Offset="0x12066CC", VA="0x12066CC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B2C8", Offset="0x108B2C8")]
			set
			{
			}
		}

		[Address(RVA="0x1206B38", Offset="0x1206B38", VA="0x1206B38")]
		public RuntimeBinding()
		{
		}
	}

	public enum RuntimeBindingType
	{
		[FieldOffset(Offset="0x0")]
		Caster,
		[FieldOffset(Offset="0x0")]
		Target,
		[FieldOffset(Offset="0x0")]
		TargetPos,
		[FieldOffset(Offset="0x0")]
		Duration,
		[FieldOffset(Offset="0x0")]
		RemainingTime,
		[FieldOffset(Offset="0x0")]
		GroundPlane,
		[FieldOffset(Offset="0x0")]
		OriginPos
	}
}