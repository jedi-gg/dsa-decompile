using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class PackOpeningGameState : AGameState
{
	[Address(RVA="0x13049A0", Offset="0x13049A0", VA="0x13049A0")]
	public PackOpeningGameState()
	{
	}

	[Address(RVA="0x1304940", Offset="0x1304940", VA="0x1304940", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class Context : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x20")]
		public readonly InventoryDelta InventoryDelta;

		[FieldOffset(Offset="0x28")]
		public readonly PackOpeningGameState.Context.InitialState State;

		[FieldOffset(Offset="0x30")]
		public readonly long? PassportSeasonPurchaseTelemetryRefId;

		[FieldOffset(Offset="0x40")]
		public readonly StoreItemData BuyAgainItem;

		[Address(RVA="0x1303F40", Offset="0x1303F40", VA="0x1303F40")]
		public Context(InventoryDelta inventoryDelta, PackOpeningGameState.Context.InitialState state = 0, long? passportSeasonPurchaseTelemetryRefId = // 
		// Current member / type: System.Void PackOpeningGameState/Context::.ctor(Serverproto.InventoryDelta,PackOpeningGameState/Context/InitialState,System.Nullable`1<System.Int64>,StoreItemData)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(Serverproto.InventoryDelta,PackOpeningGameState/Context/InitialState,System.Nullable<System.Int64>,StoreItemData)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		public enum InitialState
		{
			[FieldOffset(Offset="0x0")]
			Default,
			[FieldOffset(Offset="0x0")]
			FlipCardAutomatically,
			[FieldOffset(Offset="0x0")]
			AllItemSummary
		}
	}
}