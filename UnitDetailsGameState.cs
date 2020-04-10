using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class UnitDetailsGameState : AGameState
{
	public override bool ShowGlobalBackdrop
	{
		[Address(RVA="0x11E3FB0", Offset="0x11E3FB0", VA="0x11E3FB0", Slot="10")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11E4018", Offset="0x11E4018", VA="0x11E4018")]
	public UnitDetailsGameState()
	{
	}

	[Address(RVA="0x11E3FB8", Offset="0x11E3FB8", VA="0x11E3FB8", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class Context : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x20")]
		public readonly string PlayerId;

		[FieldOffset(Offset="0x28")]
		public readonly ulong UnitDefinitionId;

		[FieldOffset(Offset="0x30")]
		public readonly List<ulong> UnitCycleList;

		[FieldOffset(Offset="0x38")]
		public readonly bool PlayFullIntroAnimation;

		[FieldOffset(Offset="0x40")]
		public readonly Unit OldUnitForStatAnim;

		[Address(RVA="0x11E1A54", Offset="0x11E1A54", VA="0x11E1A54")]
		public Context(string playerId, ulong unitDefinitionId, List<ulong> unitCycleList = // 
		// Current member / type: System.Void UnitDetailsGameState/Context::.ctor(System.String,System.UInt64,System.Collections.Generic.List`1<System.UInt64>,System.Boolean,Serverproto.Unit)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(System.String,System.UInt64,System.Collections.Generic.List<System.UInt64>,System.Boolean,Serverproto.Unit)
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