using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class SorcererStoneGameState : AGameState
{
	[Address(RVA="0x123C7A0", Offset="0x123C7A0", VA="0x123C7A0")]
	public SorcererStoneGameState()
	{
	}

	[Address(RVA="0x123C740", Offset="0x123C740", VA="0x123C740", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class Context : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x20")]
		public ulong UnitId;

		[FieldOffset(Offset="0x28")]
		public readonly List<ulong> UnitCycleList;

		[FieldOffset(Offset="0x30")]
		public int SelectedTabIndex;

		[Address(RVA="0x123C7A8", Offset="0x123C7A8", VA="0x123C7A8")]
		public Context(ulong unitId, List<ulong> unitCycleList = // 
		// Current member / type: System.Void SorcererStoneGameState/Context::.ctor(System.UInt64,System.Collections.Generic.List`1<System.UInt64>,System.Int32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(System.UInt64,System.Collections.Generic.List<System.UInt64>,System.Int32)
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