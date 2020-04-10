using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PackOpeningCardSequencer : Sequencer
{
	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private List<PackOpeningCardSequencer.RuntimeBinding> _runtimeBindings;

	[Address(RVA="0x12FFEF8", Offset="0x12FFEF8", VA="0x12FFEF8")]
	public PackOpeningCardSequencer()
	{
	}

	[Address(RVA="0x12FFD30", Offset="0x12FFD30", VA="0x12FFD30", Slot="7")]
	protected virtual void ApplyOverrides(PackOpeningCardWidget card)
	{
	}

	[Address(RVA="0x12FFCD4", Offset="0x12FFCD4", VA="0x12FFCD4")]
	public void EndImmediately()
	{
	}

	[Address(RVA="0x12FF9E4", Offset="0x12FF9E4", VA="0x12FF9E4", Slot="5")]
	public override void Initialize(Action<ASequenceAction> actionPreInitializeCallback = // 
	// Current member / type: System.Void PackOpeningCardSequencer::Initialize(System.Action`1<Glunies.Sequencer.ASequenceAction>)
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


	[Address(RVA="0x12FFC0C", Offset="0x12FFC0C", VA="0x12FFC0C")]
	public void Play(PackOpeningCardWidget card, float durationS = 0f)
	{
	}

	[Address(RVA="0x12FFC64", Offset="0x12FFC64", VA="0x12FFC64")]
	public void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C3FC", Offset="0x104C3FC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public PackOpeningCardSequencer.RuntimeBinding bindingOverride;

		[Address(RVA="0x12FFBFC", Offset="0x12FFBFC", VA="0x12FFBFC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x12FFF00", Offset="0x12FFF00", VA="0x12FFF00")]
		internal bool <Initialize>b__0(Binding b)
		{
			return new bool();
		}
	}

	[Serializable]
	public class RuntimeBinding
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106AF74", Offset="0x106AF74")]
		[FieldOffset(Offset="0x10")]
		private Binding <Binding>k__BackingField;

		[FieldOffset(Offset="0x18")]
		public BindingDefinition Definition;

		public Binding Binding
		{
			[Address(RVA="0x12FFE14", Offset="0x12FFE14", VA="0x12FFE14")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B4FC", Offset="0x108B4FC")]
			get
			{
				return null;
			}
			[Address(RVA="0x12FFC04", Offset="0x12FFC04", VA="0x12FFC04")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B50C", Offset="0x108B50C")]
			set
			{
			}
		}

		[Address(RVA="0x12FFF48", Offset="0x12FFF48", VA="0x12FFF48")]
		public RuntimeBinding()
		{
		}
	}

	public enum RuntimeBindingType
	{
		[FieldOffset(Offset="0x0")]
		Card,
		[FieldOffset(Offset="0x0")]
		CardPos,
		[FieldOffset(Offset="0x0")]
		CardRotation,
		[FieldOffset(Offset="0x0")]
		SorcererHands
	}
}