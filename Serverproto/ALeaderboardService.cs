using Glunies;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public abstract class ALeaderboardService : AGameServiceClient
	{
		[Address(RVA="0x15FEAEC", Offset="0x15FEAEC", VA="0x15FEAEC")]
		protected ALeaderboardService()
		{
		}

		[Address(RVA="0x15FE690", Offset="0x15FE690", VA="0x15FE690")]
		protected void CacheResponse(PlayerLeaderboardRequest request, PlayerLeaderboardResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FE880", Offset="0x15FE880", VA="0x15FE880")]
		protected void CacheResponse(ClubLeaderboardRequest request, ClubLeaderboardResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FEA70", Offset="0x15FEA70", VA="0x15FEA70")]
		protected void CacheResponse(ClubMemberLeaderboardRequest request, ClubMemberLeaderboardResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FE70C", Offset="0x15FE70C", VA="0x15FE70C")]
		public void ClubLeaderboard(ClubLeaderboardRequest request, Action<ClubLeaderboardResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ALeaderboardService::ClubLeaderboard(Serverproto.ClubLeaderboardRequest,System.Action`1<Serverproto.ClubLeaderboardResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubLeaderboard(Serverproto.ClubLeaderboardRequest,System.Action<Serverproto.ClubLeaderboardResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FE800", Offset="0x15FE800", VA="0x15FE800", Slot="6")]
		protected virtual void ClubLeaderboardServiceSuccess(ClubLeaderboardResponse response)
		{
		}

		[Address(RVA="0x15FE8FC", Offset="0x15FE8FC", VA="0x15FE8FC")]
		public void ClubMemberLeaderboard(ClubMemberLeaderboardRequest request, Action<ClubMemberLeaderboardResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ALeaderboardService::ClubMemberLeaderboard(Serverproto.ClubMemberLeaderboardRequest,System.Action`1<Serverproto.ClubMemberLeaderboardResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubMemberLeaderboard(Serverproto.ClubMemberLeaderboardRequest,System.Action<Serverproto.ClubMemberLeaderboardResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FE9F0", Offset="0x15FE9F0", VA="0x15FE9F0", Slot="7")]
		protected virtual void ClubMemberLeaderboardServiceSuccess(ClubMemberLeaderboardResponse response)
		{
		}

		[Address(RVA="0x15FE614", Offset="0x15FE614", VA="0x15FE614")]
		protected PlayerLeaderboardResponse GetCachedResponse(PlayerLeaderboardRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FE804", Offset="0x15FE804", VA="0x15FE804")]
		protected ClubLeaderboardResponse GetCachedResponse(ClubLeaderboardRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FE9F4", Offset="0x15FE9F4", VA="0x15FE9F4")]
		protected ClubMemberLeaderboardResponse GetCachedResponse(ClubMemberLeaderboardRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FE51C", Offset="0x15FE51C", VA="0x15FE51C")]
		public void Leaderboard(PlayerLeaderboardRequest request, Action<PlayerLeaderboardResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ALeaderboardService::Leaderboard(Serverproto.PlayerLeaderboardRequest,System.Action`1<Serverproto.PlayerLeaderboardResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void Leaderboard(Serverproto.PlayerLeaderboardRequest,System.Action<Serverproto.PlayerLeaderboardResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FE610", Offset="0x15FE610", VA="0x15FE610", Slot="5")]
		protected virtual void LeaderboardServiceSuccess(PlayerLeaderboardResponse response)
		{
		}
	}
}