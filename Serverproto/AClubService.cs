using Glunies;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public abstract class AClubService : AGameServiceClient
	{
		[Address(RVA="0x2C4B230", Offset="0x2C4B230", VA="0x2C4B230")]
		protected AClubService()
		{
		}

		[Address(RVA="0x2C47620", Offset="0x2C47620", VA="0x2C47620")]
		public void ApproveInviteToClub(ApproveClubInviteRequest request, Action<ApproveClubInviteResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::ApproveInviteToClub(Serverproto.ApproveClubInviteRequest,System.Action`1<Serverproto.ApproveClubInviteResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ApproveInviteToClub(Serverproto.ApproveClubInviteRequest,System.Action<Serverproto.ApproveClubInviteResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C47714", Offset="0x2C47714", VA="0x2C47714", Slot="12")]
		protected virtual void ApproveInviteToClubServiceSuccess(ApproveClubInviteResponse response)
		{
		}

		[Address(RVA="0x2C48D60", Offset="0x2C48D60", VA="0x2C48D60")]
		public void BonusClubDungeonAttempt(ClaimBonusClubDungeonAttemptRequest request, Action<ClaimBonusClubDungeonAttemptResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::BonusClubDungeonAttempt(Serverproto.ClaimBonusClubDungeonAttemptRequest,System.Action`1<Serverproto.ClaimBonusClubDungeonAttemptResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void BonusClubDungeonAttempt(Serverproto.ClaimBonusClubDungeonAttemptRequest,System.Action<Serverproto.ClaimBonusClubDungeonAttemptResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C48E54", Offset="0x2C48E54", VA="0x2C48E54", Slot="24")]
		protected virtual void BonusClubDungeonAttemptServiceSuccess(ClaimBonusClubDungeonAttemptResponse response)
		{
		}

		[Address(RVA="0x2C46A04", Offset="0x2C46A04", VA="0x2C46A04")]
		protected void CacheResponse(CreateClubRequest request, CreateClubResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C46BF4", Offset="0x2C46BF4", VA="0x2C46BF4")]
		protected void CacheResponse(ClubRequest request, ClubResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C46DE4", Offset="0x2C46DE4", VA="0x2C46DE4")]
		protected void CacheResponse(UpdateClubRequest request, UpdateClubResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C46FD4", Offset="0x2C46FD4", VA="0x2C46FD4")]
		protected void CacheResponse(FindClubsRequest request, FindClubsResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C471C4", Offset="0x2C471C4", VA="0x2C471C4")]
		protected void CacheResponse(ClubInviteRequest request, ClubInviteResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C473B4", Offset="0x2C473B4", VA="0x2C473B4")]
		protected void CacheResponse(CancelClubInviteRequest request, CancelClubInviteResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C475A4", Offset="0x2C475A4", VA="0x2C475A4")]
		protected void CacheResponse(RejectClubInviteRequest request, RejectClubInviteResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C47794", Offset="0x2C47794", VA="0x2C47794")]
		protected void CacheResponse(ApproveClubInviteRequest request, ApproveClubInviteResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C47984", Offset="0x2C47984", VA="0x2C47984")]
		protected void CacheResponse(GetClubInvitesRequest request, GetClubInvitesResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C47B74", Offset="0x2C47B74", VA="0x2C47B74")]
		protected void CacheResponse(PromoteClubMemberRequest request, PromoteClubMemberResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C47D64", Offset="0x2C47D64", VA="0x2C47D64")]
		protected void CacheResponse(DemoteClubMemberRequest request, DemoteClubMemberResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C47F54", Offset="0x2C47F54", VA="0x2C47F54")]
		protected void CacheResponse(KickClubMemberRequest request, KickClubMemberResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C48144", Offset="0x2C48144", VA="0x2C48144")]
		protected void CacheResponse(RequestClubItemRequest request, RequestClubItemResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C48334", Offset="0x2C48334", VA="0x2C48334")]
		protected void CacheResponse(DonateClubItemRequest request, DonateClubItemResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C48524", Offset="0x2C48524", VA="0x2C48524")]
		protected void CacheResponse(ClubDungeonRequest request, ClubDungeonResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C48714", Offset="0x2C48714", VA="0x2C48714")]
		protected void CacheResponse(ClubDungeonStatusRequest request, ClubDungeonStatusResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C48904", Offset="0x2C48904", VA="0x2C48904")]
		protected void CacheResponse(RefreshClubDungeonRequest request, RefreshClubDungeonResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C48AF4", Offset="0x2C48AF4", VA="0x2C48AF4")]
		protected void CacheResponse(ClubDungeonDoorsRequest request, ClubDungeonDoorsResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C48CE4", Offset="0x2C48CE4", VA="0x2C48CE4")]
		protected void CacheResponse(SelectClubDungeonDoorRequest request, SelectClubDungeonDoorResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C48ED4", Offset="0x2C48ED4", VA="0x2C48ED4")]
		protected void CacheResponse(ClaimBonusClubDungeonAttemptRequest request, ClaimBonusClubDungeonAttemptResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C490C4", Offset="0x2C490C4", VA="0x2C490C4")]
		protected void CacheResponse(ClubWarRequest request, ClubWarResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C492B4", Offset="0x2C492B4", VA="0x2C492B4")]
		protected void CacheResponse(ClubWarRegisterMemberRequest request, ClubWarRegisterMemberResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C494A4", Offset="0x2C494A4", VA="0x2C494A4")]
		protected void CacheResponse(ClubWarUnregisterMemberRequest request, ClubWarUnregisterMemberResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C49694", Offset="0x2C49694", VA="0x2C49694")]
		protected void CacheResponse(ClubWarNodeDetailRequest request, ClubWarNodeDetailResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C49884", Offset="0x2C49884", VA="0x2C49884")]
		protected void CacheResponse(ClubWarMakeDefenseRequest request, ClubWarMakeDefenseResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C49A74", Offset="0x2C49A74", VA="0x2C49A74")]
		protected void CacheResponse(ClubWarDeleteDefenseRequest request, ClubWarDeleteDefenseResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C49C64", Offset="0x2C49C64", VA="0x2C49C64")]
		protected void CacheResponse(ClubWarSetDefenseRequest request, ClubWarSetDefenseResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C49E54", Offset="0x2C49E54", VA="0x2C49E54")]
		protected void CacheResponse(ClubWarUnsetDefenseRequest request, ClubWarUnsetDefenseResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C4A044", Offset="0x2C4A044", VA="0x2C4A044")]
		protected void CacheResponse(ClubWarClubDefensesRequest request, ClubWarClubDefensesResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C4A234", Offset="0x2C4A234", VA="0x2C4A234")]
		protected void CacheResponse(ClubWarOpenRewardRequest request, ClubWarOpenRewardResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C4A424", Offset="0x2C4A424", VA="0x2C4A424")]
		protected void CacheResponse(ClubWarRewardsRequest request, ClubWarRewardsResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C4A614", Offset="0x2C4A614", VA="0x2C4A614")]
		protected void CacheResponse(ClubWarSetNodeTargetRequest request, ClubWarSetNodeTargetResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C4A804", Offset="0x2C4A804", VA="0x2C4A804")]
		protected void CacheResponse(ClubWarCaptureUndefendedNodeRequest request, ClubWarCaptureUndefendedNodeResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C4A9F4", Offset="0x2C4A9F4", VA="0x2C4A9F4")]
		protected void CacheResponse(ClubActivitiesRequest request, ClubActivitiesResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C4ABE4", Offset="0x2C4ABE4", VA="0x2C4ABE4")]
		protected void CacheResponse(GetPlayerClubSupportStatusRequest request, GetPlayerClubSupportStatusResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C4ADD4", Offset="0x2C4ADD4", VA="0x2C4ADD4")]
		protected void CacheResponse(RequestClubSupportRequest request, RequestClubSupportResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C4AFC4", Offset="0x2C4AFC4", VA="0x2C4AFC4")]
		protected void CacheResponse(FulfillClubSupportRequest request, FulfillClubSupportResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C4B1B4", Offset="0x2C4B1B4", VA="0x2C4B1B4")]
		protected void CacheResponse(FulfillAllClubSupportRequest request, FulfillAllClubSupportResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C47240", Offset="0x2C47240", VA="0x2C47240")]
		public void CancelInviteToClub(CancelClubInviteRequest request, Action<CancelClubInviteResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::CancelInviteToClub(Serverproto.CancelClubInviteRequest,System.Action`1<Serverproto.CancelClubInviteResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void CancelInviteToClub(Serverproto.CancelClubInviteRequest,System.Action<Serverproto.CancelClubInviteResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C47334", Offset="0x2C47334", VA="0x2C47334", Slot="10")]
		protected virtual void CancelInviteToClubServiceSuccess(CancelClubInviteResponse response)
		{
		}

		[Address(RVA="0x2C4A880", Offset="0x2C4A880", VA="0x2C4A880")]
		public void ClubActivities(ClubActivitiesRequest request, Action<ClubActivitiesResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::ClubActivities(Serverproto.ClubActivitiesRequest,System.Action`1<Serverproto.ClubActivitiesResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubActivities(Serverproto.ClubActivitiesRequest,System.Action<Serverproto.ClubActivitiesResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4A974", Offset="0x2C4A974", VA="0x2C4A974", Slot="38")]
		protected virtual void ClubActivitiesServiceSuccess(ClubActivitiesResponse response)
		{
		}

		[Address(RVA="0x2C483B0", Offset="0x2C483B0", VA="0x2C483B0")]
		public void ClubDungeon(ClubDungeonRequest request, Action<ClubDungeonResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::ClubDungeon(Serverproto.ClubDungeonRequest,System.Action`1<Serverproto.ClubDungeonResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubDungeon(Serverproto.ClubDungeonRequest,System.Action<Serverproto.ClubDungeonResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C48980", Offset="0x2C48980", VA="0x2C48980")]
		public void ClubDungeonDoors(ClubDungeonDoorsRequest request, Action<ClubDungeonDoorsResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::ClubDungeonDoors(Serverproto.ClubDungeonDoorsRequest,System.Action`1<Serverproto.ClubDungeonDoorsResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubDungeonDoors(Serverproto.ClubDungeonDoorsRequest,System.Action<Serverproto.ClubDungeonDoorsResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C48A74", Offset="0x2C48A74", VA="0x2C48A74", Slot="22")]
		protected virtual void ClubDungeonDoorsServiceSuccess(ClubDungeonDoorsResponse response)
		{
		}

		[Address(RVA="0x2C484A4", Offset="0x2C484A4", VA="0x2C484A4", Slot="19")]
		protected virtual void ClubDungeonServiceSuccess(ClubDungeonResponse response)
		{
		}

		[Address(RVA="0x2C485A0", Offset="0x2C485A0", VA="0x2C485A0")]
		public void ClubDungeonStatus(ClubDungeonStatusRequest request, Action<ClubDungeonStatusResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::ClubDungeonStatus(Serverproto.ClubDungeonStatusRequest,System.Action`1<Serverproto.ClubDungeonStatusResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubDungeonStatus(Serverproto.ClubDungeonStatusRequest,System.Action<Serverproto.ClubDungeonStatusResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C48694", Offset="0x2C48694", VA="0x2C48694", Slot="20")]
		protected virtual void ClubDungeonStatusServiceSuccess(ClubDungeonStatusResponse response)
		{
		}

		[Address(RVA="0x2C48F50", Offset="0x2C48F50", VA="0x2C48F50")]
		public void ClubWar(ClubWarRequest request, Action<ClubWarResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::ClubWar(Serverproto.ClubWarRequest,System.Action`1<Serverproto.ClubWarResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubWar(Serverproto.ClubWarRequest,System.Action<Serverproto.ClubWarResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4A690", Offset="0x2C4A690", VA="0x2C4A690")]
		public void ClubWarCaptureUndefendedNode(ClubWarCaptureUndefendedNodeRequest request, Action<ClubWarCaptureUndefendedNodeResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::ClubWarCaptureUndefendedNode(Serverproto.ClubWarCaptureUndefendedNodeRequest,System.Action`1<Serverproto.ClubWarCaptureUndefendedNodeResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubWarCaptureUndefendedNode(Serverproto.ClubWarCaptureUndefendedNodeRequest,System.Action<Serverproto.ClubWarCaptureUndefendedNodeResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4A784", Offset="0x2C4A784", VA="0x2C4A784", Slot="37")]
		protected virtual void ClubWarCaptureUndefendedNodeServiceSuccess(ClubWarCaptureUndefendedNodeResponse response)
		{
		}

		[Address(RVA="0x2C49ED0", Offset="0x2C49ED0", VA="0x2C49ED0")]
		public void ClubWarClubDefenses(ClubWarClubDefensesRequest request, Action<ClubWarClubDefensesResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::ClubWarClubDefenses(Serverproto.ClubWarClubDefensesRequest,System.Action`1<Serverproto.ClubWarClubDefensesResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubWarClubDefenses(Serverproto.ClubWarClubDefensesRequest,System.Action<Serverproto.ClubWarClubDefensesResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C49FC4", Offset="0x2C49FC4", VA="0x2C49FC4", Slot="33")]
		protected virtual void ClubWarClubDefensesServiceSuccess(ClubWarClubDefensesResponse response)
		{
		}

		[Address(RVA="0x2C49900", Offset="0x2C49900", VA="0x2C49900")]
		public void ClubWarDeleteDefense(ClubWarDeleteDefenseRequest request, Action<ClubWarDeleteDefenseResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::ClubWarDeleteDefense(Serverproto.ClubWarDeleteDefenseRequest,System.Action`1<Serverproto.ClubWarDeleteDefenseResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubWarDeleteDefense(Serverproto.ClubWarDeleteDefenseRequest,System.Action<Serverproto.ClubWarDeleteDefenseResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C499F4", Offset="0x2C499F4", VA="0x2C499F4", Slot="30")]
		protected virtual void ClubWarDeleteDefenseServiceSuccess(ClubWarDeleteDefenseResponse response)
		{
		}

		[Address(RVA="0x2C49710", Offset="0x2C49710", VA="0x2C49710")]
		public void ClubWarMakeDefense(ClubWarMakeDefenseRequest request, Action<ClubWarMakeDefenseResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::ClubWarMakeDefense(Serverproto.ClubWarMakeDefenseRequest,System.Action`1<Serverproto.ClubWarMakeDefenseResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubWarMakeDefense(Serverproto.ClubWarMakeDefenseRequest,System.Action<Serverproto.ClubWarMakeDefenseResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C49804", Offset="0x2C49804", VA="0x2C49804", Slot="29")]
		protected virtual void ClubWarMakeDefenseServiceSuccess(ClubWarMakeDefenseResponse response)
		{
		}

		[Address(RVA="0x2C49520", Offset="0x2C49520", VA="0x2C49520")]
		public void ClubWarNodeDetail(ClubWarNodeDetailRequest request, Action<ClubWarNodeDetailResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::ClubWarNodeDetail(Serverproto.ClubWarNodeDetailRequest,System.Action`1<Serverproto.ClubWarNodeDetailResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubWarNodeDetail(Serverproto.ClubWarNodeDetailRequest,System.Action<Serverproto.ClubWarNodeDetailResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C49614", Offset="0x2C49614", VA="0x2C49614", Slot="28")]
		protected virtual void ClubWarNodeDetailServiceSuccess(ClubWarNodeDetailResponse response)
		{
		}

		[Address(RVA="0x2C4A0C0", Offset="0x2C4A0C0", VA="0x2C4A0C0")]
		public void ClubWarOpenReward(ClubWarOpenRewardRequest request, Action<ClubWarOpenRewardResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::ClubWarOpenReward(Serverproto.ClubWarOpenRewardRequest,System.Action`1<Serverproto.ClubWarOpenRewardResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubWarOpenReward(Serverproto.ClubWarOpenRewardRequest,System.Action<Serverproto.ClubWarOpenRewardResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4A1B4", Offset="0x2C4A1B4", VA="0x2C4A1B4", Slot="34")]
		protected virtual void ClubWarOpenRewardServiceSuccess(ClubWarOpenRewardResponse response)
		{
		}

		[Address(RVA="0x2C49140", Offset="0x2C49140", VA="0x2C49140")]
		public void ClubWarRegisterMember(ClubWarRegisterMemberRequest request, Action<ClubWarRegisterMemberResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::ClubWarRegisterMember(Serverproto.ClubWarRegisterMemberRequest,System.Action`1<Serverproto.ClubWarRegisterMemberResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubWarRegisterMember(Serverproto.ClubWarRegisterMemberRequest,System.Action<Serverproto.ClubWarRegisterMemberResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C49234", Offset="0x2C49234", VA="0x2C49234", Slot="26")]
		protected virtual void ClubWarRegisterMemberServiceSuccess(ClubWarRegisterMemberResponse response)
		{
		}

		[Address(RVA="0x2C4A2B0", Offset="0x2C4A2B0", VA="0x2C4A2B0")]
		public void ClubWarRewards(ClubWarRewardsRequest request, Action<ClubWarRewardsResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::ClubWarRewards(Serverproto.ClubWarRewardsRequest,System.Action`1<Serverproto.ClubWarRewardsResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubWarRewards(Serverproto.ClubWarRewardsRequest,System.Action<Serverproto.ClubWarRewardsResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4A3A4", Offset="0x2C4A3A4", VA="0x2C4A3A4", Slot="35")]
		protected virtual void ClubWarRewardsServiceSuccess(ClubWarRewardsResponse response)
		{
		}

		[Address(RVA="0x2C49044", Offset="0x2C49044", VA="0x2C49044", Slot="25")]
		protected virtual void ClubWarServiceSuccess(ClubWarResponse response)
		{
		}

		[Address(RVA="0x2C49AF0", Offset="0x2C49AF0", VA="0x2C49AF0")]
		public void ClubWarSetDefense(ClubWarSetDefenseRequest request, Action<ClubWarSetDefenseResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::ClubWarSetDefense(Serverproto.ClubWarSetDefenseRequest,System.Action`1<Serverproto.ClubWarSetDefenseResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubWarSetDefense(Serverproto.ClubWarSetDefenseRequest,System.Action<Serverproto.ClubWarSetDefenseResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C49BE4", Offset="0x2C49BE4", VA="0x2C49BE4", Slot="31")]
		protected virtual void ClubWarSetDefenseServiceSuccess(ClubWarSetDefenseResponse response)
		{
		}

		[Address(RVA="0x2C4A4A0", Offset="0x2C4A4A0", VA="0x2C4A4A0")]
		public void ClubWarSetNodeTarget(ClubWarSetNodeTargetRequest request, Action<ClubWarSetNodeTargetResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::ClubWarSetNodeTarget(Serverproto.ClubWarSetNodeTargetRequest,System.Action`1<Serverproto.ClubWarSetNodeTargetResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubWarSetNodeTarget(Serverproto.ClubWarSetNodeTargetRequest,System.Action<Serverproto.ClubWarSetNodeTargetResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4A594", Offset="0x2C4A594", VA="0x2C4A594", Slot="36")]
		protected virtual void ClubWarSetNodeTargetServiceSuccess(ClubWarSetNodeTargetResponse response)
		{
		}

		[Address(RVA="0x2C49330", Offset="0x2C49330", VA="0x2C49330")]
		public void ClubWarUnregisterMember(ClubWarUnregisterMemberRequest request, Action<ClubWarUnregisterMemberResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::ClubWarUnregisterMember(Serverproto.ClubWarUnregisterMemberRequest,System.Action`1<Serverproto.ClubWarUnregisterMemberResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubWarUnregisterMember(Serverproto.ClubWarUnregisterMemberRequest,System.Action<Serverproto.ClubWarUnregisterMemberResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C49424", Offset="0x2C49424", VA="0x2C49424", Slot="27")]
		protected virtual void ClubWarUnregisterMemberServiceSuccess(ClubWarUnregisterMemberResponse response)
		{
		}

		[Address(RVA="0x2C49CE0", Offset="0x2C49CE0", VA="0x2C49CE0")]
		public void ClubWarUnsetDefense(ClubWarUnsetDefenseRequest request, Action<ClubWarUnsetDefenseResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::ClubWarUnsetDefense(Serverproto.ClubWarUnsetDefenseRequest,System.Action`1<Serverproto.ClubWarUnsetDefenseResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClubWarUnsetDefense(Serverproto.ClubWarUnsetDefenseRequest,System.Action<Serverproto.ClubWarUnsetDefenseResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C49DD4", Offset="0x2C49DD4", VA="0x2C49DD4", Slot="32")]
		protected virtual void ClubWarUnsetDefenseServiceSuccess(ClubWarUnsetDefenseResponse response)
		{
		}

		[Address(RVA="0x2C46890", Offset="0x2C46890", VA="0x2C46890")]
		public void CreateClub(CreateClubRequest request, Action<CreateClubResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::CreateClub(Serverproto.CreateClubRequest,System.Action`1<Serverproto.CreateClubResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void CreateClub(Serverproto.CreateClubRequest,System.Action<Serverproto.CreateClubResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C46984", Offset="0x2C46984", VA="0x2C46984", Slot="5")]
		protected virtual void CreateClubServiceSuccess(CreateClubResponse response)
		{
		}

		[Address(RVA="0x2C47BF0", Offset="0x2C47BF0", VA="0x2C47BF0")]
		public void DemoteClubMember(DemoteClubMemberRequest request, Action<DemoteClubMemberResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::DemoteClubMember(Serverproto.DemoteClubMemberRequest,System.Action`1<Serverproto.DemoteClubMemberResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void DemoteClubMember(Serverproto.DemoteClubMemberRequest,System.Action<Serverproto.DemoteClubMemberResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C47CE4", Offset="0x2C47CE4", VA="0x2C47CE4", Slot="15")]
		protected virtual void DemoteClubMemberServiceSuccess(DemoteClubMemberResponse response)
		{
		}

		[Address(RVA="0x2C481C0", Offset="0x2C481C0", VA="0x2C481C0")]
		public void DonateClubItem(DonateClubItemRequest request, Action<DonateClubItemResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::DonateClubItem(Serverproto.DonateClubItemRequest,System.Action`1<Serverproto.DonateClubItemResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void DonateClubItem(Serverproto.DonateClubItemRequest,System.Action<Serverproto.DonateClubItemResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C482B4", Offset="0x2C482B4", VA="0x2C482B4", Slot="18")]
		protected virtual void DonateClubItemServiceSuccess(DonateClubItemResponse response)
		{
		}

		[Address(RVA="0x2C46E60", Offset="0x2C46E60", VA="0x2C46E60")]
		public void FindClubs(FindClubsRequest request, Action<FindClubsResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::FindClubs(Serverproto.FindClubsRequest,System.Action`1<Serverproto.FindClubsResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void FindClubs(Serverproto.FindClubsRequest,System.Action<Serverproto.FindClubsResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C46F54", Offset="0x2C46F54", VA="0x2C46F54", Slot="8")]
		protected virtual void FindClubsServiceSuccess(FindClubsResponse response)
		{
		}

		[Address(RVA="0x2C4B040", Offset="0x2C4B040", VA="0x2C4B040")]
		public void FulfillAllClubSupport(FulfillAllClubSupportRequest request, Action<FulfillAllClubSupportResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::FulfillAllClubSupport(Serverproto.FulfillAllClubSupportRequest,System.Action`1<Serverproto.FulfillAllClubSupportResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void FulfillAllClubSupport(Serverproto.FulfillAllClubSupportRequest,System.Action<Serverproto.FulfillAllClubSupportResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4B134", Offset="0x2C4B134", VA="0x2C4B134", Slot="42")]
		protected virtual void FulfillAllClubSupportServiceSuccess(FulfillAllClubSupportResponse response)
		{
		}

		[Address(RVA="0x2C4AE50", Offset="0x2C4AE50", VA="0x2C4AE50")]
		public void FulfillClubSupport(FulfillClubSupportRequest request, Action<FulfillClubSupportResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::FulfillClubSupport(Serverproto.FulfillClubSupportRequest,System.Action`1<Serverproto.FulfillClubSupportResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void FulfillClubSupport(Serverproto.FulfillClubSupportRequest,System.Action<Serverproto.FulfillClubSupportResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4AF44", Offset="0x2C4AF44", VA="0x2C4AF44", Slot="41")]
		protected virtual void FulfillClubSupportServiceSuccess(FulfillClubSupportResponse response)
		{
		}

		[Address(RVA="0x2C46988", Offset="0x2C46988", VA="0x2C46988")]
		protected CreateClubResponse GetCachedResponse(CreateClubRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C46B78", Offset="0x2C46B78", VA="0x2C46B78")]
		protected ClubResponse GetCachedResponse(ClubRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C46D68", Offset="0x2C46D68", VA="0x2C46D68")]
		protected UpdateClubResponse GetCachedResponse(UpdateClubRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C46F58", Offset="0x2C46F58", VA="0x2C46F58")]
		protected FindClubsResponse GetCachedResponse(FindClubsRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C47148", Offset="0x2C47148", VA="0x2C47148")]
		protected ClubInviteResponse GetCachedResponse(ClubInviteRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C47338", Offset="0x2C47338", VA="0x2C47338")]
		protected CancelClubInviteResponse GetCachedResponse(CancelClubInviteRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C47528", Offset="0x2C47528", VA="0x2C47528")]
		protected RejectClubInviteResponse GetCachedResponse(RejectClubInviteRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C47718", Offset="0x2C47718", VA="0x2C47718")]
		protected ApproveClubInviteResponse GetCachedResponse(ApproveClubInviteRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C47908", Offset="0x2C47908", VA="0x2C47908")]
		protected GetClubInvitesResponse GetCachedResponse(GetClubInvitesRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C47AF8", Offset="0x2C47AF8", VA="0x2C47AF8")]
		protected PromoteClubMemberResponse GetCachedResponse(PromoteClubMemberRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C47CE8", Offset="0x2C47CE8", VA="0x2C47CE8")]
		protected DemoteClubMemberResponse GetCachedResponse(DemoteClubMemberRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C47ED8", Offset="0x2C47ED8", VA="0x2C47ED8")]
		protected KickClubMemberResponse GetCachedResponse(KickClubMemberRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C480C8", Offset="0x2C480C8", VA="0x2C480C8")]
		protected RequestClubItemResponse GetCachedResponse(RequestClubItemRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C482B8", Offset="0x2C482B8", VA="0x2C482B8")]
		protected DonateClubItemResponse GetCachedResponse(DonateClubItemRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C484A8", Offset="0x2C484A8", VA="0x2C484A8")]
		protected ClubDungeonResponse GetCachedResponse(ClubDungeonRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C48698", Offset="0x2C48698", VA="0x2C48698")]
		protected ClubDungeonStatusResponse GetCachedResponse(ClubDungeonStatusRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C48888", Offset="0x2C48888", VA="0x2C48888")]
		protected RefreshClubDungeonResponse GetCachedResponse(RefreshClubDungeonRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C48A78", Offset="0x2C48A78", VA="0x2C48A78")]
		protected ClubDungeonDoorsResponse GetCachedResponse(ClubDungeonDoorsRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C48C68", Offset="0x2C48C68", VA="0x2C48C68")]
		protected SelectClubDungeonDoorResponse GetCachedResponse(SelectClubDungeonDoorRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C48E58", Offset="0x2C48E58", VA="0x2C48E58")]
		protected ClaimBonusClubDungeonAttemptResponse GetCachedResponse(ClaimBonusClubDungeonAttemptRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C49048", Offset="0x2C49048", VA="0x2C49048")]
		protected ClubWarResponse GetCachedResponse(ClubWarRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C49238", Offset="0x2C49238", VA="0x2C49238")]
		protected ClubWarRegisterMemberResponse GetCachedResponse(ClubWarRegisterMemberRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C49428", Offset="0x2C49428", VA="0x2C49428")]
		protected ClubWarUnregisterMemberResponse GetCachedResponse(ClubWarUnregisterMemberRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C49618", Offset="0x2C49618", VA="0x2C49618")]
		protected ClubWarNodeDetailResponse GetCachedResponse(ClubWarNodeDetailRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C49808", Offset="0x2C49808", VA="0x2C49808")]
		protected ClubWarMakeDefenseResponse GetCachedResponse(ClubWarMakeDefenseRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C499F8", Offset="0x2C499F8", VA="0x2C499F8")]
		protected ClubWarDeleteDefenseResponse GetCachedResponse(ClubWarDeleteDefenseRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C49BE8", Offset="0x2C49BE8", VA="0x2C49BE8")]
		protected ClubWarSetDefenseResponse GetCachedResponse(ClubWarSetDefenseRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C49DD8", Offset="0x2C49DD8", VA="0x2C49DD8")]
		protected ClubWarUnsetDefenseResponse GetCachedResponse(ClubWarUnsetDefenseRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C49FC8", Offset="0x2C49FC8", VA="0x2C49FC8")]
		protected ClubWarClubDefensesResponse GetCachedResponse(ClubWarClubDefensesRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C4A1B8", Offset="0x2C4A1B8", VA="0x2C4A1B8")]
		protected ClubWarOpenRewardResponse GetCachedResponse(ClubWarOpenRewardRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C4A3A8", Offset="0x2C4A3A8", VA="0x2C4A3A8")]
		protected ClubWarRewardsResponse GetCachedResponse(ClubWarRewardsRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C4A598", Offset="0x2C4A598", VA="0x2C4A598")]
		protected ClubWarSetNodeTargetResponse GetCachedResponse(ClubWarSetNodeTargetRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C4A788", Offset="0x2C4A788", VA="0x2C4A788")]
		protected ClubWarCaptureUndefendedNodeResponse GetCachedResponse(ClubWarCaptureUndefendedNodeRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C4A978", Offset="0x2C4A978", VA="0x2C4A978")]
		protected ClubActivitiesResponse GetCachedResponse(ClubActivitiesRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C4AB68", Offset="0x2C4AB68", VA="0x2C4AB68")]
		protected GetPlayerClubSupportStatusResponse GetCachedResponse(GetPlayerClubSupportStatusRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C4AD58", Offset="0x2C4AD58", VA="0x2C4AD58")]
		protected RequestClubSupportResponse GetCachedResponse(RequestClubSupportRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C4AF48", Offset="0x2C4AF48", VA="0x2C4AF48")]
		protected FulfillClubSupportResponse GetCachedResponse(FulfillClubSupportRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C4B138", Offset="0x2C4B138", VA="0x2C4B138")]
		protected FulfillAllClubSupportResponse GetCachedResponse(FulfillAllClubSupportRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C46A80", Offset="0x2C46A80", VA="0x2C46A80")]
		public void GetClub(ClubRequest request, Action<ClubResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::GetClub(Serverproto.ClubRequest,System.Action`1<Serverproto.ClubResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void GetClub(Serverproto.ClubRequest,System.Action<Serverproto.ClubResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C47810", Offset="0x2C47810", VA="0x2C47810")]
		public void GetClubInvites(GetClubInvitesRequest request, Action<GetClubInvitesResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::GetClubInvites(Serverproto.GetClubInvitesRequest,System.Action`1<Serverproto.GetClubInvitesResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void GetClubInvites(Serverproto.GetClubInvitesRequest,System.Action<Serverproto.GetClubInvitesResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C47904", Offset="0x2C47904", VA="0x2C47904", Slot="13")]
		protected virtual void GetClubInvitesServiceSuccess(GetClubInvitesResponse response)
		{
		}

		[Address(RVA="0x2C46B74", Offset="0x2C46B74", VA="0x2C46B74", Slot="6")]
		protected virtual void GetClubServiceSuccess(ClubResponse response)
		{
		}

		[Address(RVA="0x2C4AA70", Offset="0x2C4AA70", VA="0x2C4AA70")]
		public void GetPlayerClubSupportStatus(GetPlayerClubSupportStatusRequest request, Action<GetPlayerClubSupportStatusResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::GetPlayerClubSupportStatus(Serverproto.GetPlayerClubSupportStatusRequest,System.Action`1<Serverproto.GetPlayerClubSupportStatusResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void GetPlayerClubSupportStatus(Serverproto.GetPlayerClubSupportStatusRequest,System.Action<Serverproto.GetPlayerClubSupportStatusResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4AB64", Offset="0x2C4AB64", VA="0x2C4AB64", Slot="39")]
		protected virtual void GetPlayerClubSupportStatusServiceSuccess(GetPlayerClubSupportStatusResponse response)
		{
		}

		[Address(RVA="0x2C47050", Offset="0x2C47050", VA="0x2C47050")]
		public void InviteToClub(ClubInviteRequest request, Action<ClubInviteResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::InviteToClub(Serverproto.ClubInviteRequest,System.Action`1<Serverproto.ClubInviteResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void InviteToClub(Serverproto.ClubInviteRequest,System.Action<Serverproto.ClubInviteResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C47144", Offset="0x2C47144", VA="0x2C47144", Slot="9")]
		protected virtual void InviteToClubServiceSuccess(ClubInviteResponse response)
		{
		}

		[Address(RVA="0x2C47DE0", Offset="0x2C47DE0", VA="0x2C47DE0")]
		public void KickClubMember(KickClubMemberRequest request, Action<KickClubMemberResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::KickClubMember(Serverproto.KickClubMemberRequest,System.Action`1<Serverproto.KickClubMemberResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void KickClubMember(Serverproto.KickClubMemberRequest,System.Action<Serverproto.KickClubMemberResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C47ED4", Offset="0x2C47ED4", VA="0x2C47ED4", Slot="16")]
		protected virtual void KickClubMemberServiceSuccess(KickClubMemberResponse response)
		{
		}

		[Address(RVA="0x2C47A00", Offset="0x2C47A00", VA="0x2C47A00")]
		public void PromoteClubMember(PromoteClubMemberRequest request, Action<PromoteClubMemberResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::PromoteClubMember(Serverproto.PromoteClubMemberRequest,System.Action`1<Serverproto.PromoteClubMemberResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void PromoteClubMember(Serverproto.PromoteClubMemberRequest,System.Action<Serverproto.PromoteClubMemberResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C47AF4", Offset="0x2C47AF4", VA="0x2C47AF4", Slot="14")]
		protected virtual void PromoteClubMemberServiceSuccess(PromoteClubMemberResponse response)
		{
		}

		[Address(RVA="0x2C48790", Offset="0x2C48790", VA="0x2C48790")]
		public void RefreshClubDungeon(RefreshClubDungeonRequest request, Action<RefreshClubDungeonResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::RefreshClubDungeon(Serverproto.RefreshClubDungeonRequest,System.Action`1<Serverproto.RefreshClubDungeonResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void RefreshClubDungeon(Serverproto.RefreshClubDungeonRequest,System.Action<Serverproto.RefreshClubDungeonResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C48884", Offset="0x2C48884", VA="0x2C48884", Slot="21")]
		protected virtual void RefreshClubDungeonServiceSuccess(RefreshClubDungeonResponse response)
		{
		}

		[Address(RVA="0x2C47430", Offset="0x2C47430", VA="0x2C47430")]
		public void RejectInviteToClub(RejectClubInviteRequest request, Action<RejectClubInviteResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::RejectInviteToClub(Serverproto.RejectClubInviteRequest,System.Action`1<Serverproto.RejectClubInviteResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void RejectInviteToClub(Serverproto.RejectClubInviteRequest,System.Action<Serverproto.RejectClubInviteResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C47524", Offset="0x2C47524", VA="0x2C47524", Slot="11")]
		protected virtual void RejectInviteToClubServiceSuccess(RejectClubInviteResponse response)
		{
		}

		[Address(RVA="0x2C47FD0", Offset="0x2C47FD0", VA="0x2C47FD0")]
		public void RequestClubItem(RequestClubItemRequest request, Action<RequestClubItemResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::RequestClubItem(Serverproto.RequestClubItemRequest,System.Action`1<Serverproto.RequestClubItemResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void RequestClubItem(Serverproto.RequestClubItemRequest,System.Action<Serverproto.RequestClubItemResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C480C4", Offset="0x2C480C4", VA="0x2C480C4", Slot="17")]
		protected virtual void RequestClubItemServiceSuccess(RequestClubItemResponse response)
		{
		}

		[Address(RVA="0x2C4AC60", Offset="0x2C4AC60", VA="0x2C4AC60")]
		public void RequestClubSupport(RequestClubSupportRequest request, Action<RequestClubSupportResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::RequestClubSupport(Serverproto.RequestClubSupportRequest,System.Action`1<Serverproto.RequestClubSupportResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void RequestClubSupport(Serverproto.RequestClubSupportRequest,System.Action<Serverproto.RequestClubSupportResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4AD54", Offset="0x2C4AD54", VA="0x2C4AD54", Slot="40")]
		protected virtual void RequestClubSupportServiceSuccess(RequestClubSupportResponse response)
		{
		}

		[Address(RVA="0x2C48B70", Offset="0x2C48B70", VA="0x2C48B70")]
		public void SelectClubDungeonDoor(SelectClubDungeonDoorRequest request, Action<SelectClubDungeonDoorResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::SelectClubDungeonDoor(Serverproto.SelectClubDungeonDoorRequest,System.Action`1<Serverproto.SelectClubDungeonDoorResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void SelectClubDungeonDoor(Serverproto.SelectClubDungeonDoorRequest,System.Action<Serverproto.SelectClubDungeonDoorResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C48C64", Offset="0x2C48C64", VA="0x2C48C64", Slot="23")]
		protected virtual void SelectClubDungeonDoorServiceSuccess(SelectClubDungeonDoorResponse response)
		{
		}

		[Address(RVA="0x2C46C70", Offset="0x2C46C70", VA="0x2C46C70")]
		public void UpdateClub(UpdateClubRequest request, Action<UpdateClubResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AClubService::UpdateClub(Serverproto.UpdateClubRequest,System.Action`1<Serverproto.UpdateClubResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void UpdateClub(Serverproto.UpdateClubRequest,System.Action<Serverproto.UpdateClubResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C46D64", Offset="0x2C46D64", VA="0x2C46D64", Slot="7")]
		protected virtual void UpdateClubServiceSuccess(UpdateClubResponse response)
		{
		}
	}
}