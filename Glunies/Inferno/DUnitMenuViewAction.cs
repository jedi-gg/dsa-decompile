using Il2CppDummyDll;
using System;

namespace Glunies.Inferno
{
	public struct DUnitMenuViewAction
	{
		[FieldOffset(Offset="0x0")]
		public readonly DUnitMenuViewAction.Type ActionType;

		[FieldOffset(Offset="0x8")]
		public readonly string AssetId;

		[Address(RVA="0xF02068", Offset="0xF02068", VA="0xF02068")]
		public DUnitMenuViewAction(DUnitMenuViewAction.Type actionType, string assetId = // 
		// Current member / type: System.Void Glunies.Inferno.DUnitMenuViewAction::.ctor(Glunies.Inferno.DUnitMenuViewAction/Type,System.String)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(Glunies.Inferno.DUnitMenuViewAction/Type,System.String)
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
			UnitSelected,
			[FieldOffset(Offset="0x0")]
			UnloadUnit
		}
	}
}