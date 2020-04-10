using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class GenericActionPopupViewController : APopupController
{
	public override bool ShouldBeRestoredFromHistory
	{
		[Address(RVA="0x14EC26C", Offset="0x14EC26C", VA="0x14EC26C", Slot="7")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x14EC4CC", Offset="0x14EC4CC", VA="0x14EC4CC")]
	public GenericActionPopupViewController()
	{
	}

	[Address(RVA="0x14EC274", Offset="0x14EC274", VA="0x14EC274", Slot="8")]
	public override void Initialize(ITransitionContext transitionContext, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BFEC", Offset="0x104BFEC")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public GenericActionPopupViewController.Context context;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x14EC3F0", Offset="0x14EC3F0", VA="0x14EC3F0")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x14EC4DC", Offset="0x14EC4DC", VA="0x14EC4DC")]
		internal void <Initialize>b__0(GenericActionPopupView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly RectTransform PopperTransform;

		[FieldOffset(Offset="0x18")]
		public readonly RectTransform BoundsTransform;

		[FieldOffset(Offset="0x20")]
		public readonly IReadOnlyList<DGenericActionPopupButtonConfig> ButtonConfigs;

		[FieldOffset(Offset="0x28")]
		public readonly GenericActionPopupViewDirection Direction;

		[Address(RVA="0x14EC5F4", Offset="0x14EC5F4", VA="0x14EC5F4")]
		public Context(RectTransform popperTransform, IReadOnlyList<DGenericActionPopupButtonConfig> buttonConfigs, RectTransform boundsTransform = // 
		// Current member / type: System.Void GenericActionPopupViewController/Context::.ctor(UnityEngine.RectTransform,System.Collections.Generic.IReadOnlyList`1<DGenericActionPopupButtonConfig>,UnityEngine.RectTransform,GenericActionPopupViewDirection)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(UnityEngine.RectTransform,System.Collections.Generic.IReadOnlyList<DGenericActionPopupButtonConfig>,UnityEngine.RectTransform,GenericActionPopupViewDirection)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}
}