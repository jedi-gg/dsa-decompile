using Il2CppDummyDll;
using System;

namespace Glunies.Inferno
{
	public struct DAbilityPreviewMenuViewAction
	{
		[FieldOffset(Offset="0x0")]
		public readonly DAbilityPreviewMenuViewAction.Type ActionType;

		[FieldOffset(Offset="0x8")]
		public readonly string PreviewAssetId;

		[FieldOffset(Offset="0x10")]
		public readonly float? InterruptAtS;

		[Address(RVA="0xF01C34", Offset="0xF01C34", VA="0xF01C34")]
		public DAbilityPreviewMenuViewAction(DAbilityPreviewMenuViewAction.Type actionType, string previewAssetId = // 
		// Current member / type: System.Void Glunies.Inferno.DAbilityPreviewMenuViewAction::.ctor(Glunies.Inferno.DAbilityPreviewMenuViewAction/Type,System.String,System.Nullable`1<System.Single>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(Glunies.Inferno.DAbilityPreviewMenuViewAction/Type,System.String,System.Nullable<System.Single>)
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
			LoadPreview,
			[FieldOffset(Offset="0x0")]
			ReloadPreview,
			[FieldOffset(Offset="0x0")]
			UnloadPreview,
			[FieldOffset(Offset="0x0")]
			PlayPreview
		}
	}
}