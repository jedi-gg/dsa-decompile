using Glunies;
using Il2CppDummyDll;
using System;

public struct DShowScrimAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ScrimOptions Options;

	[FieldOffset(Offset="0x8")]
	public readonly string LabelText;

	[FieldOffset(Offset="0x10")]
	public readonly float? LabelTextArg;

	public bool Backdrop
	{
		[Address(RVA="0xEFF52C", Offset="0xEFF52C", VA="0xEFF52C")]
		get
		{
			return new bool();
		}
	}

	public bool Heavy
	{
		[Address(RVA="0xEFF520", Offset="0xEFF520", VA="0xEFF520")]
		get
		{
			return new bool();
		}
	}

	public bool Immediate
	{
		[Address(RVA="0xEFF514", Offset="0xEFF514", VA="0xEFF514")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0xEFF538", Offset="0xEFF538", VA="0xEFF538")]
	public DShowScrimAction(ScrimOptions options, string labelText = // 
	// Current member / type: System.Void DShowScrimAction::.ctor(ScrimOptions,System.String,System.Nullable`1<System.Single>)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void .ctor(ScrimOptions,System.String,System.Nullable<System.Single>)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0xEFF544", Offset="0xEFF544", VA="0xEFF544")]
	public DShowScrimAction(GameStateTransitionContext context)
	{
	}
}