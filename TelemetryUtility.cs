using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class TelemetryUtility
{
	[Attribute(Name="InjectAttribute", RVA="0x105C090", Offset="0x105C090")]
	[FieldOffset(Offset="0x10")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x105C0A0", Offset="0x105C0A0")]
	[FieldOffset(Offset="0x18")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105C0B0", Offset="0x105C0B0")]
	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatchSystem;

	[Address(RVA="0x13258E4", Offset="0x13258E4", VA="0x13258E4")]
	public TelemetryUtility()
	{
	}

	[Address(RVA="0x1324ADC", Offset="0x1324ADC", VA="0x1324ADC")]
	public ABattleGameState.TelemetryInfo SendBattlePrepareTelemetry(string battleId, string battleMode, IList<ulong> unitIds, ulong leaderUnitId, IList<ulong> spellIds, InventoryDelta inventoryDelta = // 
	// Current member / type: ABattleGameState/TelemetryInfo TelemetryUtility::SendBattlePrepareTelemetry(System.String,System.String,System.Collections.Generic.IList`1<System.UInt64>,System.UInt64,System.Collections.Generic.IList`1<System.UInt64>,Serverproto.InventoryDelta,System.Nullable`1<System.Int64>,System.String,System.Collections.Generic.Dictionary`2<System.String,System.Object>)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: ABattleGameState/TelemetryInfo SendBattlePrepareTelemetry(System.String,System.String,System.Collections.Generic.IList<System.UInt64>,System.UInt64,System.Collections.Generic.IList<System.UInt64>,Serverproto.InventoryDelta,System.Nullable<System.Int64>,System.String,System.Collections.Generic.Dictionary<System.String,System.Object>)
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