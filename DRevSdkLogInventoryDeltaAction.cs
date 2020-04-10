using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public struct DRevSdkLogInventoryDeltaAction
{
	[FieldOffset(Offset="0x0")]
	public readonly long ReferenceId;

	[FieldOffset(Offset="0x8")]
	public readonly string Name;

	[FieldOffset(Offset="0x10")]
	public readonly string St3;

	[FieldOffset(Offset="0x18")]
	public readonly InventoryDelta Delta;

	[FieldOffset(Offset="0x20")]
	public readonly IDictionary<string, object> Data;

	[Address(RVA="0xEFEC44", Offset="0xEFEC44", VA="0xEFEC44")]
	public DRevSdkLogInventoryDeltaAction(long referenceId, string name, string st3, InventoryDelta delta, IDictionary<string, object> data = // 
	// Current member / type: System.Void DRevSdkLogInventoryDeltaAction::.ctor(System.Int64,System.String,System.String,Serverproto.InventoryDelta,System.Collections.Generic.IDictionary`2<System.String,System.Object>)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void .ctor(System.Int64,System.String,System.String,Serverproto.InventoryDelta,System.Collections.Generic.IDictionary<System.String,System.Object>)
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