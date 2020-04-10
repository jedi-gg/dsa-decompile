using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public struct DRevSdkLogEventAction
{
	[FieldOffset(Offset="0x0")]
	public readonly long ReferenceId;

	[FieldOffset(Offset="0x8")]
	public readonly string Name;

	[FieldOffset(Offset="0x10")]
	public readonly string St1;

	[FieldOffset(Offset="0x18")]
	public readonly string St2;

	[FieldOffset(Offset="0x20")]
	public readonly string St3;

	[FieldOffset(Offset="0x28")]
	public readonly long? Val;

	[FieldOffset(Offset="0x38")]
	public readonly IDictionary<string, object> Data;

	[Address(RVA="0xEFEBE8", Offset="0xEFEBE8", VA="0xEFEBE8")]
	public DRevSdkLogEventAction(long referenceId, string name, string st1, string st2, string st3, long? val = // 
	// Current member / type: System.Void DRevSdkLogEventAction::.ctor(System.Int64,System.String,System.String,System.String,System.String,System.Nullable`1<System.Int64>,System.Collections.Generic.IDictionary`2<System.String,System.Object>)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void .ctor(System.Int64,System.String,System.String,System.String,System.String,System.Nullable<System.Int64>,System.Collections.Generic.IDictionary<System.String,System.Object>)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x12A86D0", Offset="0x12A86D0", VA="0x12A86D0")]
	public static long GenerateReferenceId()
	{
		return new long();
	}
}