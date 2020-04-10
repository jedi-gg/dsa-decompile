using Glunies;
using Il2CppDummyDll;
using System;

namespace Glunies.Inferno
{
	public struct DUnitAssetAction
	{
		[FieldOffset(Offset="0x0")]
		public DUnitAssetAction.Type ActionType;

		[FieldOffset(Offset="0x8")]
		public AssetHandle Unit;

		[Address(RVA="0xF01F34", Offset="0xF01F34", VA="0xF01F34")]
		public DUnitAssetAction(DUnitAssetAction.Type actionType, AssetHandle unit = // 
		// Current member / type: System.Void Glunies.Inferno.DUnitAssetAction::.ctor(Glunies.Inferno.DUnitAssetAction/Type,Glunies.AssetHandle)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(Glunies.Inferno.DUnitAssetAction/Type,Glunies.AssetHandle)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		public enum Type
		{
			[FieldOffset(Offset="0x0")]
			Loaded,
			[FieldOffset(Offset="0x0")]
			Unloaded
		}
	}
}