using Glunies;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public abstract class ABattleService : AGameServiceClient
	{
		[Address(RVA="0x2C457D8", Offset="0x2C457D8", VA="0x2C457D8")]
		protected ABattleService()
		{
		}

		[Address(RVA="0x2C42AC8", Offset="0x2C42AC8", VA="0x2C42AC8")]
		protected void CacheResponse(PveBattleStartRequest request, PveBattleStartResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C42CB8", Offset="0x2C42CB8", VA="0x2C42CB8")]
		protected void CacheResponse(PveBattleEndRequest request, PveBattleEndResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C42EA8", Offset="0x2C42EA8", VA="0x2C42EA8")]
		protected void CacheResponse(PvpFindMatchRequest request, PvpFindMatchResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C43098", Offset="0x2C43098", VA="0x2C43098")]
		protected void CacheResponse(CoopFindMatchRequest request, CoopFindMatchResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C43288", Offset="0x2C43288", VA="0x2C43288")]
		protected void CacheResponse(CoopInviteToMatchRequest request, CoopFindMatchResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C43478", Offset="0x2C43478", VA="0x2C43478")]
		protected void CacheResponse(CoopAcceptMatchRequest request, CoopFindMatchResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C43668", Offset="0x2C43668", VA="0x2C43668")]
		protected void CacheResponse(DeclineMatchRequest request, DeclineMatchResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C4385C", Offset="0x2C4385C", VA="0x2C4385C")]
		protected void CacheResponse(CancelMatchmakingRequest request, CancelMatchmakingResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C43A4C", Offset="0x2C43A4C", VA="0x2C43A4C")]
		protected void CacheResponse(MultiplayerBattleEndRequest request, MultiplayerBattleEndResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C43C3C", Offset="0x2C43C3C", VA="0x2C43C3C")]
		protected void CacheResponse(MultiplayerBattleResultRequest request, MultiplayerBattleResultResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C43E2C", Offset="0x2C43E2C", VA="0x2C43E2C")]
		protected void CacheResponse(InstantBattleRequest request, InstantBattleResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C4401C", Offset="0x2C4401C", VA="0x2C4401C")]
		protected void CacheResponse(EventBattleStartRequest request, EventBattleStartResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C4420C", Offset="0x2C4420C", VA="0x2C4420C")]
		protected void CacheResponse(EventBattleEndRequest request, EventBattleEndResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C443FC", Offset="0x2C443FC", VA="0x2C443FC")]
		protected void CacheResponse(InstantBattleEventRequest request, InstantBattleEventResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C445EC", Offset="0x2C445EC", VA="0x2C445EC")]
		protected void CacheResponse(InstantBattleAllDailyEventsRequest request, InstantBattleAllDailyEventsResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C447DC", Offset="0x2C447DC", VA="0x2C447DC")]
		protected void CacheResponse(TowerBattleStartRequest request, TowerBattleStartResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C449CC", Offset="0x2C449CC", VA="0x2C449CC")]
		protected void CacheResponse(TowerBattleEndRequest request, TowerBattleEndResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C44BBC", Offset="0x2C44BBC", VA="0x2C44BBC")]
		protected void CacheResponse(TowerAutoWinRequest request, TowerAutoWinResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C44DAC", Offset="0x2C44DAC", VA="0x2C44DAC")]
		protected void CacheResponse(ClubDungeonBattleStartRequest request, ClubDungeonBattleStartResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C44F9C", Offset="0x2C44F9C", VA="0x2C44F9C")]
		protected void CacheResponse(ClubDungeonBattleEndRequest request, ClubDungeonBattleEndResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C4518C", Offset="0x2C4518C", VA="0x2C4518C")]
		protected void CacheResponse(KothBattleStartRequest request, KothBattleStartResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C4537C", Offset="0x2C4537C", VA="0x2C4537C")]
		protected void CacheResponse(KothBattleResultRequest request, KothBattleResultResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C4556C", Offset="0x2C4556C", VA="0x2C4556C")]
		protected void CacheResponse(ClubWarBattleStartRequest request, ClubWarBattleStartResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C4575C", Offset="0x2C4575C", VA="0x2C4575C")]
		protected void CacheResponse(ClubWarBattleResultRequest request, ClubWarBattleResultResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C436E4", Offset="0x2C436E4", VA="0x2C436E4")]
		public void CancelMatchmaking(CancelMatchmakingRequest request, Action<CancelMatchmakingResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::CancelMatchmaking(Serverproto.CancelMatchmakingRequest,System.Action`1<Serverproto.CancelMatchmakingResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void CancelMatchmaking(Serverproto.CancelMatchmakingRequest,System.Action<Serverproto.CancelMatchmakingResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C437DC", Offset="0x2C437DC", VA="0x2C437DC", Slot="12")]
		protected virtual void CancelMatchmakingServiceSuccess(CancelMatchmakingResponse response)
		{
		}

		[Address(RVA="0x2C44E28", Offset="0x2C44E28", VA="0x2C44E28")]
		public void ClubDungeonBattleEnd(ClubDungeonBattleEndRequest request, Action<ClubDungeonBattleEndResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::ClubDungeonBattleEnd(Serverproto.ClubDungeonBattleEndRequest,System.Action`1<Serverproto.ClubDungeonBattleEndResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubDungeonBattleEnd(Serverproto.ClubDungeonBattleEndRequest,System.Action<Serverproto.ClubDungeonBattleEndResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C44F1C", Offset="0x2C44F1C", VA="0x2C44F1C", Slot="24")]
		protected virtual void ClubDungeonBattleEndServiceSuccess(ClubDungeonBattleEndResponse response)
		{
		}

		[Address(RVA="0x2C44C38", Offset="0x2C44C38", VA="0x2C44C38")]
		public void ClubDungeonBattleStart(ClubDungeonBattleStartRequest request, Action<ClubDungeonBattleStartResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::ClubDungeonBattleStart(Serverproto.ClubDungeonBattleStartRequest,System.Action`1<Serverproto.ClubDungeonBattleStartResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubDungeonBattleStart(Serverproto.ClubDungeonBattleStartRequest,System.Action<Serverproto.ClubDungeonBattleStartResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C44D2C", Offset="0x2C44D2C", VA="0x2C44D2C", Slot="23")]
		protected virtual void ClubDungeonBattleStartServiceSuccess(ClubDungeonBattleStartResponse response)
		{
		}

		[Address(RVA="0x2C455E8", Offset="0x2C455E8", VA="0x2C455E8")]
		public void ClubWarBattleResult(ClubWarBattleResultRequest request, Action<ClubWarBattleResultResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::ClubWarBattleResult(Serverproto.ClubWarBattleResultRequest,System.Action`1<Serverproto.ClubWarBattleResultResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubWarBattleResult(Serverproto.ClubWarBattleResultRequest,System.Action<Serverproto.ClubWarBattleResultResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C456DC", Offset="0x2C456DC", VA="0x2C456DC", Slot="28")]
		protected virtual void ClubWarBattleResultServiceSuccess(ClubWarBattleResultResponse response)
		{
		}

		[Address(RVA="0x2C453F8", Offset="0x2C453F8", VA="0x2C453F8")]
		public void ClubWarBattleStart(ClubWarBattleStartRequest request, Action<ClubWarBattleStartResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::ClubWarBattleStart(Serverproto.ClubWarBattleStartRequest,System.Action`1<Serverproto.ClubWarBattleStartResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubWarBattleStart(Serverproto.ClubWarBattleStartRequest,System.Action<Serverproto.ClubWarBattleStartResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C454EC", Offset="0x2C454EC", VA="0x2C454EC", Slot="27")]
		protected virtual void ClubWarBattleStartServiceSuccess(ClubWarBattleStartResponse response)
		{
		}

		[Address(RVA="0x2C43304", Offset="0x2C43304", VA="0x2C43304")]
		public void CoopAcceptMatch(CoopAcceptMatchRequest request, Action<CoopFindMatchResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::CoopAcceptMatch(Serverproto.CoopAcceptMatchRequest,System.Action`1<Serverproto.CoopFindMatchResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void CoopAcceptMatch(Serverproto.CoopAcceptMatchRequest,System.Action<Serverproto.CoopFindMatchResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C433F8", Offset="0x2C433F8", VA="0x2C433F8", Slot="10")]
		protected virtual void CoopAcceptMatchServiceSuccess(CoopFindMatchResponse response)
		{
		}

		[Address(RVA="0x2C42F24", Offset="0x2C42F24", VA="0x2C42F24")]
		public void CoopFindMatch(CoopFindMatchRequest request, Action<CoopFindMatchResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::CoopFindMatch(Serverproto.CoopFindMatchRequest,System.Action`1<Serverproto.CoopFindMatchResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void CoopFindMatch(Serverproto.CoopFindMatchRequest,System.Action<Serverproto.CoopFindMatchResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C43018", Offset="0x2C43018", VA="0x2C43018", Slot="8")]
		protected virtual void CoopFindMatchServiceSuccess(CoopFindMatchResponse response)
		{
		}

		[Address(RVA="0x2C43114", Offset="0x2C43114", VA="0x2C43114")]
		public void CoopInviteToMatch(CoopInviteToMatchRequest request, Action<CoopFindMatchResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::CoopInviteToMatch(Serverproto.CoopInviteToMatchRequest,System.Action`1<Serverproto.CoopFindMatchResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void CoopInviteToMatch(Serverproto.CoopInviteToMatchRequest,System.Action<Serverproto.CoopFindMatchResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C43208", Offset="0x2C43208", VA="0x2C43208", Slot="9")]
		protected virtual void CoopInviteToMatchServiceSuccess(CoopFindMatchResponse response)
		{
		}

		[Address(RVA="0x2C434F4", Offset="0x2C434F4", VA="0x2C434F4")]
		public void DeclineMatch(DeclineMatchRequest request, Action<DeclineMatchResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::DeclineMatch(Serverproto.DeclineMatchRequest,System.Action`1<Serverproto.DeclineMatchResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void DeclineMatch(Serverproto.DeclineMatchRequest,System.Action<Serverproto.DeclineMatchResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C435E8", Offset="0x2C435E8", VA="0x2C435E8", Slot="11")]
		protected virtual void DeclineMatchServiceSuccess(DeclineMatchResponse response)
		{
		}

		[Address(RVA="0x2C44098", Offset="0x2C44098", VA="0x2C44098")]
		public void EventBattleEnd(EventBattleEndRequest request, Action<EventBattleEndResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::EventBattleEnd(Serverproto.EventBattleEndRequest,System.Action`1<Serverproto.EventBattleEndResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void EventBattleEnd(Serverproto.EventBattleEndRequest,System.Action<Serverproto.EventBattleEndResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4418C", Offset="0x2C4418C", VA="0x2C4418C", Slot="17")]
		protected virtual void EventBattleEndServiceSuccess(EventBattleEndResponse response)
		{
		}

		[Address(RVA="0x2C43EA8", Offset="0x2C43EA8", VA="0x2C43EA8")]
		public void EventBattleStart(EventBattleStartRequest request, Action<EventBattleStartResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::EventBattleStart(Serverproto.EventBattleStartRequest,System.Action`1<Serverproto.EventBattleStartResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void EventBattleStart(Serverproto.EventBattleStartRequest,System.Action<Serverproto.EventBattleStartResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C43F9C", Offset="0x2C43F9C", VA="0x2C43F9C", Slot="16")]
		protected virtual void EventBattleStartServiceSuccess(EventBattleStartResponse response)
		{
		}

		[Address(RVA="0x2C42A4C", Offset="0x2C42A4C", VA="0x2C42A4C")]
		protected PveBattleStartResponse GetCachedResponse(PveBattleStartRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C42C3C", Offset="0x2C42C3C", VA="0x2C42C3C")]
		protected PveBattleEndResponse GetCachedResponse(PveBattleEndRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C42E2C", Offset="0x2C42E2C", VA="0x2C42E2C")]
		protected PvpFindMatchResponse GetCachedResponse(PvpFindMatchRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C4301C", Offset="0x2C4301C", VA="0x2C4301C")]
		protected CoopFindMatchResponse GetCachedResponse(CoopFindMatchRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C4320C", Offset="0x2C4320C", VA="0x2C4320C")]
		protected CoopFindMatchResponse GetCachedResponse(CoopInviteToMatchRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C433FC", Offset="0x2C433FC", VA="0x2C433FC")]
		protected CoopFindMatchResponse GetCachedResponse(CoopAcceptMatchRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C435EC", Offset="0x2C435EC", VA="0x2C435EC")]
		protected DeclineMatchResponse GetCachedResponse(DeclineMatchRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C437E0", Offset="0x2C437E0", VA="0x2C437E0")]
		protected CancelMatchmakingResponse GetCachedResponse(CancelMatchmakingRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C439D0", Offset="0x2C439D0", VA="0x2C439D0")]
		protected MultiplayerBattleEndResponse GetCachedResponse(MultiplayerBattleEndRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C43BC0", Offset="0x2C43BC0", VA="0x2C43BC0")]
		protected MultiplayerBattleResultResponse GetCachedResponse(MultiplayerBattleResultRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C43DB0", Offset="0x2C43DB0", VA="0x2C43DB0")]
		protected InstantBattleResponse GetCachedResponse(InstantBattleRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C43FA0", Offset="0x2C43FA0", VA="0x2C43FA0")]
		protected EventBattleStartResponse GetCachedResponse(EventBattleStartRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C44190", Offset="0x2C44190", VA="0x2C44190")]
		protected EventBattleEndResponse GetCachedResponse(EventBattleEndRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C44380", Offset="0x2C44380", VA="0x2C44380")]
		protected InstantBattleEventResponse GetCachedResponse(InstantBattleEventRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C44570", Offset="0x2C44570", VA="0x2C44570")]
		protected InstantBattleAllDailyEventsResponse GetCachedResponse(InstantBattleAllDailyEventsRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C44760", Offset="0x2C44760", VA="0x2C44760")]
		protected TowerBattleStartResponse GetCachedResponse(TowerBattleStartRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C44950", Offset="0x2C44950", VA="0x2C44950")]
		protected TowerBattleEndResponse GetCachedResponse(TowerBattleEndRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C44B40", Offset="0x2C44B40", VA="0x2C44B40")]
		protected TowerAutoWinResponse GetCachedResponse(TowerAutoWinRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C44D30", Offset="0x2C44D30", VA="0x2C44D30")]
		protected ClubDungeonBattleStartResponse GetCachedResponse(ClubDungeonBattleStartRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C44F20", Offset="0x2C44F20", VA="0x2C44F20")]
		protected ClubDungeonBattleEndResponse GetCachedResponse(ClubDungeonBattleEndRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C45110", Offset="0x2C45110", VA="0x2C45110")]
		protected KothBattleStartResponse GetCachedResponse(KothBattleStartRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C45300", Offset="0x2C45300", VA="0x2C45300")]
		protected KothBattleResultResponse GetCachedResponse(KothBattleResultRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C454F0", Offset="0x2C454F0", VA="0x2C454F0")]
		protected ClubWarBattleStartResponse GetCachedResponse(ClubWarBattleStartRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C456E0", Offset="0x2C456E0", VA="0x2C456E0")]
		protected ClubWarBattleResultResponse GetCachedResponse(ClubWarBattleResultRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C43CB8", Offset="0x2C43CB8", VA="0x2C43CB8")]
		public void InstantBattle(InstantBattleRequest request, Action<InstantBattleResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::InstantBattle(Serverproto.InstantBattleRequest,System.Action`1<Serverproto.InstantBattleResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void InstantBattle(Serverproto.InstantBattleRequest,System.Action<Serverproto.InstantBattleResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C44478", Offset="0x2C44478", VA="0x2C44478")]
		public void InstantBattleAllDailyEvents(InstantBattleAllDailyEventsRequest request, Action<InstantBattleAllDailyEventsResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::InstantBattleAllDailyEvents(Serverproto.InstantBattleAllDailyEventsRequest,System.Action`1<Serverproto.InstantBattleAllDailyEventsResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void InstantBattleAllDailyEvents(Serverproto.InstantBattleAllDailyEventsRequest,System.Action<Serverproto.InstantBattleAllDailyEventsResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4456C", Offset="0x2C4456C", VA="0x2C4456C", Slot="19")]
		protected virtual void InstantBattleAllDailyEventsServiceSuccess(InstantBattleAllDailyEventsResponse response)
		{
		}

		[Address(RVA="0x2C44288", Offset="0x2C44288", VA="0x2C44288")]
		public void InstantBattleEvent(InstantBattleEventRequest request, Action<InstantBattleEventResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::InstantBattleEvent(Serverproto.InstantBattleEventRequest,System.Action`1<Serverproto.InstantBattleEventResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void InstantBattleEvent(Serverproto.InstantBattleEventRequest,System.Action<Serverproto.InstantBattleEventResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4437C", Offset="0x2C4437C", VA="0x2C4437C", Slot="18")]
		protected virtual void InstantBattleEventServiceSuccess(InstantBattleEventResponse response)
		{
		}

		[Address(RVA="0x2C43DAC", Offset="0x2C43DAC", VA="0x2C43DAC", Slot="15")]
		protected virtual void InstantBattleServiceSuccess(InstantBattleResponse response)
		{
		}

		[Address(RVA="0x2C45208", Offset="0x2C45208", VA="0x2C45208")]
		public void KothBattleResult(KothBattleResultRequest request, Action<KothBattleResultResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::KothBattleResult(Serverproto.KothBattleResultRequest,System.Action`1<Serverproto.KothBattleResultResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void KothBattleResult(Serverproto.KothBattleResultRequest,System.Action<Serverproto.KothBattleResultResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C452FC", Offset="0x2C452FC", VA="0x2C452FC", Slot="26")]
		protected virtual void KothBattleResultServiceSuccess(KothBattleResultResponse response)
		{
		}

		[Address(RVA="0x2C45018", Offset="0x2C45018", VA="0x2C45018")]
		public void KothBattleStart(KothBattleStartRequest request, Action<KothBattleStartResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::KothBattleStart(Serverproto.KothBattleStartRequest,System.Action`1<Serverproto.KothBattleStartResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void KothBattleStart(Serverproto.KothBattleStartRequest,System.Action<Serverproto.KothBattleStartResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4510C", Offset="0x2C4510C", VA="0x2C4510C", Slot="25")]
		protected virtual void KothBattleStartServiceSuccess(KothBattleStartResponse response)
		{
		}

		[Address(RVA="0x2C438D8", Offset="0x2C438D8", VA="0x2C438D8")]
		public void MultiplayerBattleEnd(MultiplayerBattleEndRequest request, Action<MultiplayerBattleEndResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::MultiplayerBattleEnd(Serverproto.MultiplayerBattleEndRequest,System.Action`1<Serverproto.MultiplayerBattleEndResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void MultiplayerBattleEnd(Serverproto.MultiplayerBattleEndRequest,System.Action<Serverproto.MultiplayerBattleEndResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C439CC", Offset="0x2C439CC", VA="0x2C439CC", Slot="13")]
		protected virtual void MultiplayerBattleEndServiceSuccess(MultiplayerBattleEndResponse response)
		{
		}

		[Address(RVA="0x2C43AC8", Offset="0x2C43AC8", VA="0x2C43AC8")]
		public void MultiplayerBattleResult(MultiplayerBattleResultRequest request, Action<MultiplayerBattleResultResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::MultiplayerBattleResult(Serverproto.MultiplayerBattleResultRequest,System.Action`1<Serverproto.MultiplayerBattleResultResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void MultiplayerBattleResult(Serverproto.MultiplayerBattleResultRequest,System.Action<Serverproto.MultiplayerBattleResultResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C43BBC", Offset="0x2C43BBC", VA="0x2C43BBC", Slot="14")]
		protected virtual void MultiplayerBattleResultServiceSuccess(MultiplayerBattleResultResponse response)
		{
		}

		[Address(RVA="0x2C42B44", Offset="0x2C42B44", VA="0x2C42B44")]
		public void PveBattleEnd(PveBattleEndRequest request, Action<PveBattleEndResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::PveBattleEnd(Serverproto.PveBattleEndRequest,System.Action`1<Serverproto.PveBattleEndResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void PveBattleEnd(Serverproto.PveBattleEndRequest,System.Action<Serverproto.PveBattleEndResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C42C38", Offset="0x2C42C38", VA="0x2C42C38", Slot="6")]
		protected virtual void PveBattleEndServiceSuccess(PveBattleEndResponse response)
		{
		}

		[Address(RVA="0x2C42954", Offset="0x2C42954", VA="0x2C42954")]
		public void PveBattleStart(PveBattleStartRequest request, Action<PveBattleStartResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::PveBattleStart(Serverproto.PveBattleStartRequest,System.Action`1<Serverproto.PveBattleStartResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void PveBattleStart(Serverproto.PveBattleStartRequest,System.Action<Serverproto.PveBattleStartResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C42A48", Offset="0x2C42A48", VA="0x2C42A48", Slot="5")]
		protected virtual void PveBattleStartServiceSuccess(PveBattleStartResponse response)
		{
		}

		[Address(RVA="0x2C42D34", Offset="0x2C42D34", VA="0x2C42D34")]
		public void PvpFindMatch(PvpFindMatchRequest request, Action<PvpFindMatchResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::PvpFindMatch(Serverproto.PvpFindMatchRequest,System.Action`1<Serverproto.PvpFindMatchResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void PvpFindMatch(Serverproto.PvpFindMatchRequest,System.Action<Serverproto.PvpFindMatchResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C42E28", Offset="0x2C42E28", VA="0x2C42E28", Slot="7")]
		protected virtual void PvpFindMatchServiceSuccess(PvpFindMatchResponse response)
		{
		}

		[Address(RVA="0x2C44A48", Offset="0x2C44A48", VA="0x2C44A48")]
		public void TowerAutoWin(TowerAutoWinRequest request, Action<TowerAutoWinResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::TowerAutoWin(Serverproto.TowerAutoWinRequest,System.Action`1<Serverproto.TowerAutoWinResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void TowerAutoWin(Serverproto.TowerAutoWinRequest,System.Action<Serverproto.TowerAutoWinResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C44B3C", Offset="0x2C44B3C", VA="0x2C44B3C", Slot="22")]
		protected virtual void TowerAutoWinServiceSuccess(TowerAutoWinResponse response)
		{
		}

		[Address(RVA="0x2C44858", Offset="0x2C44858", VA="0x2C44858")]
		public void TowerBattleEnd(TowerBattleEndRequest request, Action<TowerBattleEndResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::TowerBattleEnd(Serverproto.TowerBattleEndRequest,System.Action`1<Serverproto.TowerBattleEndResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void TowerBattleEnd(Serverproto.TowerBattleEndRequest,System.Action<Serverproto.TowerBattleEndResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4494C", Offset="0x2C4494C", VA="0x2C4494C", Slot="21")]
		protected virtual void TowerBattleEndServiceSuccess(TowerBattleEndResponse response)
		{
		}

		[Address(RVA="0x2C44668", Offset="0x2C44668", VA="0x2C44668")]
		public void TowerBattleStart(TowerBattleStartRequest request, Action<TowerBattleStartResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ABattleService::TowerBattleStart(Serverproto.TowerBattleStartRequest,System.Action`1<Serverproto.TowerBattleStartResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void TowerBattleStart(Serverproto.TowerBattleStartRequest,System.Action<Serverproto.TowerBattleStartResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4475C", Offset="0x2C4475C", VA="0x2C4475C", Slot="20")]
		protected virtual void TowerBattleStartServiceSuccess(TowerBattleStartResponse response)
		{
		}
	}
}