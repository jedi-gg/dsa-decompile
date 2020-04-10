using Gamedata;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public static class BattleRestrictionEvaluator
{
	[Address(RVA="0x128DF3C", Offset="0x128DF3C", VA="0x128DF3C")]
	public static List<Gamedata.Spell?> GetAllowedSpellDefs(IEnumerable<Gamedata.Spell?> spellDefinitions, BattleRestriction? restriction)
	{
		return null;
	}

	[Address(RVA="0x128DD80", Offset="0x128DD80", VA="0x128DD80")]
	public static List<Serverproto.Spell> GetAllowedSpells(IEnumerable<Serverproto.Spell> spellInventory, BattleRestriction? restriction, ref List<Serverproto.Spell> ownedIneligibleSpells)
	{
		return null;
	}

	[Address(RVA="0x128C77C", Offset="0x128C77C", VA="0x128C77C")]
	public static List<Gamedata.Unit?> GetAllowedUnitDefs(IEnumerable<Gamedata.Unit?> unitDefinitions, BattleRestriction? restriction, UnitSorter unitSorter)
	{
		return null;
	}

	[Address(RVA="0x128C5C0", Offset="0x128C5C0", VA="0x128C5C0")]
	public static List<Serverproto.Unit> GetAllowedUnits(IEnumerable<Serverproto.Unit> unitInventory, BattleRestriction? restriction, ref List<Serverproto.Unit> ownedIneligibleUnits)
	{
		return null;
	}

	[Address(RVA="0x128D464", Offset="0x128D464", VA="0x128D464")]
	public static int GetCountOfEligibleRequiredFilteredUnits(IEnumerable<Serverproto.Unit> units, BattleRestriction? restriction)
	{
		return new int();
	}

	[Address(RVA="0x128CF44", Offset="0x128CF44", VA="0x128CF44")]
	public static int GetCountOfEligibleUnits(IEnumerable<Serverproto.Unit> units, BattleRestriction? restriction)
	{
		return new int();
	}

	[Address(RVA="0x128DBE4", Offset="0x128DBE4", VA="0x128DBE4")]
	public static bool IsSpellAllowed(Serverproto.Spell spell, BattleRestriction? restriction)
	{
		return new bool();
	}

	[Address(RVA="0x128C554", Offset="0x128C554", VA="0x128C554")]
	public static bool IsUnitAllowed(Serverproto.Unit unit, BattleRestriction? restriction)
	{
		return new bool();
	}

	[Address(RVA="0x128D72C", Offset="0x128D72C", VA="0x128D72C")]
	public static bool IsUnitNoLongerEligibleForSquad(Serverproto.Unit unit, Serverproto.Unit unitBeingReplaced, IEnumerable<Serverproto.Unit> squadUnits, BattleRestriction? restriction)
	{
		return new bool();
	}

	[Address(RVA="0x128BE58", Offset="0x128BE58", VA="0x128BE58")]
	public static bool PlayerInventoryPassesRestriction(IEnumerable<Serverproto.Unit> unitInventory, IEnumerable<Serverproto.Spell> spellInventory, BattleRestriction? restriction, PersistedPlayerBattleUnits unitBattleStates = // 
	// Current member / type: System.Boolean BattleRestrictionEvaluator::PlayerInventoryPassesRestriction(System.Collections.Generic.IEnumerable`1<Serverproto.Unit>,System.Collections.Generic.IEnumerable`1<Serverproto.Spell>,System.Nullable`1<Gamedata.BattleRestriction>,PersistedPlayerBattleUnits)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Boolean PlayerInventoryPassesRestriction(System.Collections.Generic.IEnumerable<Serverproto.Unit>,System.Collections.Generic.IEnumerable<Serverproto.Spell>,System.Nullable<Gamedata.BattleRestriction>,PersistedPlayerBattleUnits)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x128B64C", Offset="0x128B64C", VA="0x128B64C")]
	private static bool SpellCollectionContainsAllRequiredSpells(IEnumerable<Serverproto.Spell> spells, BattleRestriction? restriction)
	{
		return new bool();
	}

	[Address(RVA="0x128E0A0", Offset="0x128E0A0", VA="0x128E0A0")]
	private static bool SpellDefPassesFilter(Gamedata.Spell spellDef, BattleRestriction? restriction)
	{
		return new bool();
	}

	[Address(RVA="0x128DC18", Offset="0x128DC18", VA="0x128DC18")]
	private static bool SpellPassesFilter(Serverproto.Spell spell, BattleRestriction? restriction)
	{
		return new bool();
	}

	[Address(RVA="0x128BD1C", Offset="0x128BD1C", VA="0x128BD1C")]
	private static bool SpellsPassFilter(List<Serverproto.Spell> spells, BattleRestriction? restriction)
	{
		return new bool();
	}

	[Address(RVA="0x128AD74", Offset="0x128AD74", VA="0x128AD74")]
	public static bool SquadPassesAllRestrictions(List<Serverproto.Unit> units, List<Serverproto.Spell> spells, BattleRestriction? restriction)
	{
		return new bool();
	}

	[Address(RVA="0x128AE78", Offset="0x128AE78", VA="0x128AE78")]
	private static bool UnitCollectionContainsAllRequiredUnits(IEnumerable<Serverproto.Unit> units, BattleRestriction? restriction, PersistedPlayerBattleUnits unitBattleStates = // 
	// Current member / type: System.Boolean BattleRestrictionEvaluator::UnitCollectionContainsAllRequiredUnits(System.Collections.Generic.IEnumerable`1<Serverproto.Unit>,System.Nullable`1<Gamedata.BattleRestriction>,PersistedPlayerBattleUnits)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Boolean UnitCollectionContainsAllRequiredUnits(System.Collections.Generic.IEnumerable<Serverproto.Unit>,System.Nullable<Gamedata.BattleRestriction>,PersistedPlayerBattleUnits)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x128E46C", Offset="0x128E46C", VA="0x128E46C")]
	private static bool UnitDefPassesCategoryFilter(Gamedata.Unit unitDef, UnitFilter? filter)
	{
		return new bool();
	}

	[Address(RVA="0x128CBE0", Offset="0x128CBE0", VA="0x128CBE0")]
	private static bool UnitDefPassesFilter(Gamedata.Unit unitDef, BattleRestriction? restriction)
	{
		return new bool();
	}

	[Address(RVA="0x128CDE0", Offset="0x128CDE0", VA="0x128CDE0")]
	private static bool UnitDefPassesRequiredUnitFilter(Gamedata.Unit unitDef, BattleRestriction? restriction)
	{
		return new bool();
	}

	[Address(RVA="0x128C410", Offset="0x128C410", VA="0x128C410")]
	private static bool UnitPassesFilter(Serverproto.Unit unit, BattleRestriction? restriction)
	{
		return new bool();
	}

	[Address(RVA="0x128E344", Offset="0x128E344", VA="0x128E344")]
	private static bool UnitPassesFilter(Serverproto.Unit unit, UnitFilter? filter)
	{
		return new bool();
	}

	[Address(RVA="0x128C22C", Offset="0x128C22C", VA="0x128C22C")]
	private static bool UnitPassesRequiredUnitFilter(Serverproto.Unit unit, BattleRestriction? restriction)
	{
		return new bool();
	}

	[Address(RVA="0x128BAC0", Offset="0x128BAC0", VA="0x128BAC0")]
	private static bool UnitsPassFilter(List<Serverproto.Unit> units, BattleRestriction? restriction)
	{
		return new bool();
	}
}