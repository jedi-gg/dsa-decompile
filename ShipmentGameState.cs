using Glunies;
using Il2CppDummyDll;
using System;

public class ShipmentGameState : AGameState
{
	public override bool ShowGlobalBackdrop
	{
		[Address(RVA="0x14C02C8", Offset="0x14C02C8", VA="0x14C02C8", Slot="10")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x14C0330", Offset="0x14C0330", VA="0x14C0330")]
	public ShipmentGameState()
	{
	}

	[Address(RVA="0x14C02D0", Offset="0x14C02D0", VA="0x14C02D0", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class Context : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x20")]
		public ulong SelectedShipmentDefId;

		[FieldOffset(Offset="0x28")]
		public ulong SelectedItemId;

		[FieldOffset(Offset="0x30")]
		public string SelectedShipmentId;

		[Address(RVA="0x14BB0AC", Offset="0x14BB0AC", VA="0x14BB0AC")]
		public Context(ulong selectedShipmentDefId, ulong selectedItemId = 0L, string selectedShipmentId = // 
		// Current member / type: System.Void ShipmentGameState/Context::.ctor(System.UInt64,System.UInt64,System.String)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(System.UInt64,System.UInt64,System.String)
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