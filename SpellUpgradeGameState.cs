using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class SpellUpgradeGameState : AGameState
{
	[Address(RVA="0x1246DC4", Offset="0x1246DC4", VA="0x1246DC4")]
	public SpellUpgradeGameState()
	{
	}

	[Address(RVA="0x1246D64", Offset="0x1246D64", VA="0x1246D64", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class Context : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x20")]
		public ulong SpellDefId;

		[FieldOffset(Offset="0x28")]
		public readonly bool AllowUpgrade;

		[FieldOffset(Offset="0x30")]
		public readonly List<ulong> SpellCycleList;

		[FieldOffset(Offset="0x38")]
		public int SelectedAbilityLevelIndex;

		[Address(RVA="0x1246DCC", Offset="0x1246DCC", VA="0x1246DCC")]
		public Context(ulong spellDefId, bool allowUpgrade = true, int selectedAbilityLevelIndex = -1, List<ulong> spellCycleList = // 
		// Current member / type: System.Void SpellUpgradeGameState/Context::.ctor(System.UInt64,System.Boolean,System.Int32,System.Collections.Generic.List`1<System.UInt64>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(System.UInt64,System.Boolean,System.Int32,System.Collections.Generic.List<System.UInt64>)
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