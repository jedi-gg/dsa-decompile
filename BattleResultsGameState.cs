using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class BattleResultsGameState : AGameState
{
	public override bool CanBeNavigatedBackInto
	{
		[Address(RVA="0x1293970", Offset="0x1293970", VA="0x1293970", Slot="8")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x12939D8", Offset="0x12939D8", VA="0x12939D8")]
	public BattleResultsGameState()
	{
	}

	[Address(RVA="0x1293978", Offset="0x1293978", VA="0x1293978", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class CampaignTransitionContext : BattleResultsGameState.TransitionContext
	{
		[FieldOffset(Offset="0x58")]
		public readonly BattleSquadSaveInfo SquadInfo;

		[FieldOffset(Offset="0x60")]
		public readonly DCampaignAddress CurrentCampaignAddress;

		[FieldOffset(Offset="0x78")]
		public readonly DCampaignAddress? NextCampaignAddress;

		[Address(RVA="0x12939E0", Offset="0x12939E0", VA="0x12939E0")]
		public CampaignTransitionContext(BattleSquadSaveInfo squadInfo, DCampaignAddress currentCampaignAddress, DCampaignAddress? nextCampaignAddress, bool victory, BattleLib_UpdateResult.Types.BattleEnded.Types.Reason reason, int stars, InventoryDelta rewards, DGameStateEnvelope? continueState = // 
		// Current member / type: System.Void BattleResultsGameState/CampaignTransitionContext::.ctor(Serverproto.BattleSquadSaveInfo,DCampaignAddress,System.Nullable`1<DCampaignAddress>,System.Boolean,Serverproto.BattleLib_UpdateResult/Types/BattleEnded/Types/Reason,System.Int32,Serverproto.InventoryDelta,System.Nullable`1<Glunies.DGameStateEnvelope>,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(Serverproto.BattleSquadSaveInfo,DCampaignAddress,System.Nullable<DCampaignAddress>,System.Boolean,Serverproto.BattleLib_UpdateResult/Types/BattleEnded/Types/Reason,System.Int32,Serverproto.InventoryDelta,System.Nullable<Glunies.DGameStateEnvelope>,System.Boolean)
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

	public class TransitionContext : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x1C")]
		public readonly bool Victory;

		[FieldOffset(Offset="0x20")]
		public readonly BattleLib_UpdateResult.Types.BattleEnded.Types.Reason Reason;

		[FieldOffset(Offset="0x24")]
		public readonly bool ShowStars;

		[FieldOffset(Offset="0x28")]
		public readonly int Stars;

		[FieldOffset(Offset="0x30")]
		public readonly InventoryDelta Rewards;

		[FieldOffset(Offset="0x38")]
		public readonly DGameStateEnvelope? ContinueState;

		[FieldOffset(Offset="0x50")]
		public readonly bool AllowVictoryNavigateAway;

		[Address(RVA="0x1293AB4", Offset="0x1293AB4", VA="0x1293AB4")]
		public TransitionContext(bool victory, BattleLib_UpdateResult.Types.BattleEnded.Types.Reason reason, int stars, InventoryDelta rewards, DGameStateEnvelope? continueState = // 
		// Current member / type: System.Void BattleResultsGameState/TransitionContext::.ctor(System.Boolean,Serverproto.BattleLib_UpdateResult/Types/BattleEnded/Types/Reason,System.Int32,Serverproto.InventoryDelta,System.Nullable`1<Glunies.DGameStateEnvelope>,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(System.Boolean,Serverproto.BattleLib_UpdateResult/Types/BattleEnded/Types/Reason,System.Int32,Serverproto.InventoryDelta,System.Nullable<Glunies.DGameStateEnvelope>,System.Boolean)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1293B3C", Offset="0x1293B3C", VA="0x1293B3C")]
		public TransitionContext(bool victory, BattleLib_UpdateResult.Types.BattleEnded.Types.Reason reason, InventoryDelta rewards, DGameStateEnvelope? continueState = // 
		// Current member / type: System.Void BattleResultsGameState/TransitionContext::.ctor(System.Boolean,Serverproto.BattleLib_UpdateResult/Types/BattleEnded/Types/Reason,Serverproto.InventoryDelta,System.Nullable`1<Glunies.DGameStateEnvelope>,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(System.Boolean,Serverproto.BattleLib_UpdateResult/Types/BattleEnded/Types/Reason,Serverproto.InventoryDelta,System.Nullable<Glunies.DGameStateEnvelope>,System.Boolean)
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