using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Inferno
{
	public struct DCameraAction
	{
		[FieldOffset(Offset="0x0")]
		public readonly DCameraAction.Type ActionType;

		[FieldOffset(Offset="0x8")]
		public readonly Transform LookAtTarget;

		[FieldOffset(Offset="0x10")]
		public readonly float ZoomPercent;

		[FieldOffset(Offset="0x14")]
		public readonly CameraDragAction DragAction;

		[Address(RVA="0xF01C8C", Offset="0xF01C8C", VA="0xF01C8C")]
		public DCameraAction(DCameraAction.Type actionType, Transform lookAtTarget = // 
		// Current member / type: System.Void Glunies.Inferno.DCameraAction::.ctor(Glunies.Inferno.DCameraAction/Type,UnityEngine.Transform,System.Single)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(Glunies.Inferno.DCameraAction/Type,UnityEngine.Transform,System.Single)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0xF01CA4", Offset="0xF01CA4", VA="0xF01CA4")]
		public DCameraAction(CameraDragAction dragAction)
		{
		}

		public enum Type
		{
			[FieldOffset(Offset="0x0")]
			LookAt,
			[FieldOffset(Offset="0x0")]
			Zoom,
			[FieldOffset(Offset="0x0")]
			SwitchDragAction
		}
	}
}