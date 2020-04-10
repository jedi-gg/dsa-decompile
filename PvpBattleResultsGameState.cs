using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class PvpBattleResultsGameState : AGameState
{
	public override bool CanBeNavigatedBackInto
	{
		[Address(RVA="0x128482C", Offset="0x128482C", VA="0x128482C", Slot="8")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1284894", Offset="0x1284894", VA="0x1284894")]
	public PvpBattleResultsGameState()
	{
	}

	[Address(RVA="0x1284834", Offset="0x1284834", VA="0x1284834", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class TransitionContext : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x1C")]
		public readonly bool Victory;

		[FieldOffset(Offset="0x20")]
		public readonly BattleLib_UpdateResult.Types.BattleEnded.Types.Reason Reason;

		[FieldOffset(Offset="0x28")]
		public readonly InventoryDelta Rewards;

		[FieldOffset(Offset="0x30")]
		public readonly ulong OldPvpScore;

		[FieldOffset(Offset="0x38")]
		public readonly ulong NewPvpScore;

		[FieldOffset(Offset="0x40")]
		public readonly ulong Stars;

		[FieldOffset(Offset="0x48")]
		public readonly DGameStateEnvelope? ContinueState;

		[FieldOffset(Offset="0x60")]
		public readonly PvpTakeoverResultResponse PvpTakeoverResult;

		[Address(RVA="0x12821D0", Offset="0x12821D0", VA="0x12821D0")]
		public TransitionContext(bool victory, BattleLib_UpdateResult.Types.BattleEnded.Types.Reason reason, InventoryDelta rewards, ulong oldPvpScore, ulong newPvpScore, ulong stars, DGameStateEnvelope? continueState = // 
		// Current member / type: System.Void PvpBattleResultsGameState/TransitionContext::.ctor(System.Boolean,Serverproto.BattleLib_UpdateResult/Types/BattleEnded/Types/Reason,Serverproto.InventoryDelta,System.UInt64,System.UInt64,System.UInt64,System.Nullable`1<Glunies.DGameStateEnvelope>,Serverproto.PvpTakeoverResultResponse)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(System.Boolean,Serverproto.BattleLib_UpdateResult/Types/BattleEnded/Types/Reason,Serverproto.InventoryDelta,System.UInt64,System.UInt64,System.UInt64,System.Nullable<Glunies.DGameStateEnvelope>,Serverproto.PvpTakeoverResultResponse)
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