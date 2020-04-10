using Il2CppDummyDll;
using Serverproto;
using System;

public struct DBattleUnitsControllerAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleUnitsControllerAction.ActionType Action;

	[FieldOffset(Offset="0x8")]
	public readonly BattleUnit BattleUnit;

	[FieldOffset(Offset="0x10")]
	public readonly BattleLib_Bootstrap.Types.Unit UnitData;

	[FieldOffset(Offset="0x18")]
	public readonly uint MaxHp;

	[Address(RVA="0xF03058", Offset="0xF03058", VA="0xF03058")]
	public DBattleUnitsControllerAction(DBattleUnitsControllerAction.ActionType action, BattleUnit battleUnit, BattleLib_Bootstrap.Types.Unit unitData = // 
	// Current member / type: System.Void DBattleUnitsControllerAction::.ctor(DBattleUnitsControllerAction/ActionType,BattleUnit,Serverproto.BattleLib_Bootstrap/Types/Unit,System.UInt32)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void .ctor(DBattleUnitsControllerAction/ActionType,BattleUnit,Serverproto.BattleLib_Bootstrap/Types/Unit,System.UInt32)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	public enum ActionType
	{
		[FieldOffset(Offset="0x0")]
		Spawn,
		[FieldOffset(Offset="0x0")]
		Despawn,
		[FieldOffset(Offset="0x0")]
		Release
	}
}