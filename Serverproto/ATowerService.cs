using Glunies;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public abstract class ATowerService : AGameServiceClient
	{
		[Address(RVA="0x1604924", Offset="0x1604924", VA="0x1604924")]
		protected ATowerService()
		{
		}

		[Address(RVA="0x16042D8", Offset="0x16042D8", VA="0x16042D8")]
		protected void CacheResponse(TowerRequest request, TowerResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x16044C8", Offset="0x16044C8", VA="0x16044C8")]
		protected void CacheResponse(TowerStatusRequest request, TowerStatusResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x16046B8", Offset="0x16046B8", VA="0x16046B8")]
		protected void CacheResponse(RefreshTowerRequest request, RefreshTowerResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x16048A8", Offset="0x16048A8", VA="0x16048A8")]
		protected void CacheResponse(ClaimTowerProgressionLootRequest request, ClaimTowerProgressionLootResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x1604734", Offset="0x1604734", VA="0x1604734")]
		public void ClaimTowerProgressionLoot(ClaimTowerProgressionLootRequest request, Action<ClaimTowerProgressionLootResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ATowerService::ClaimTowerProgressionLoot(Serverproto.ClaimTowerProgressionLootRequest,System.Action`1<Serverproto.ClaimTowerProgressionLootResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ClaimTowerProgressionLoot(Serverproto.ClaimTowerProgressionLootRequest,System.Action<Serverproto.ClaimTowerProgressionLootResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1604828", Offset="0x1604828", VA="0x1604828", Slot="8")]
		protected virtual void ClaimTowerProgressionLootServiceSuccess(ClaimTowerProgressionLootResponse response)
		{
		}

		[Address(RVA="0x160425C", Offset="0x160425C", VA="0x160425C")]
		protected TowerResponse GetCachedResponse(TowerRequest request)
		{
			return null;
		}

		[Address(RVA="0x160444C", Offset="0x160444C", VA="0x160444C")]
		protected TowerStatusResponse GetCachedResponse(TowerStatusRequest request)
		{
			return null;
		}

		[Address(RVA="0x160463C", Offset="0x160463C", VA="0x160463C")]
		protected RefreshTowerResponse GetCachedResponse(RefreshTowerRequest request)
		{
			return null;
		}

		[Address(RVA="0x160482C", Offset="0x160482C", VA="0x160482C")]
		protected ClaimTowerProgressionLootResponse GetCachedResponse(ClaimTowerProgressionLootRequest request)
		{
			return null;
		}

		[Address(RVA="0x1604544", Offset="0x1604544", VA="0x1604544")]
		public void RefreshTower(RefreshTowerRequest request, Action<RefreshTowerResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ATowerService::RefreshTower(Serverproto.RefreshTowerRequest,System.Action`1<Serverproto.RefreshTowerResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void RefreshTower(Serverproto.RefreshTowerRequest,System.Action<Serverproto.RefreshTowerResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1604638", Offset="0x1604638", VA="0x1604638", Slot="7")]
		protected virtual void RefreshTowerServiceSuccess(RefreshTowerResponse response)
		{
		}

		[Address(RVA="0x1604164", Offset="0x1604164", VA="0x1604164")]
		public void Tower(TowerRequest request, Action<TowerResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ATowerService::Tower(Serverproto.TowerRequest,System.Action`1<Serverproto.TowerResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void Tower(Serverproto.TowerRequest,System.Action<Serverproto.TowerResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1604258", Offset="0x1604258", VA="0x1604258", Slot="5")]
		protected virtual void TowerServiceSuccess(TowerResponse response)
		{
		}

		[Address(RVA="0x1604354", Offset="0x1604354", VA="0x1604354")]
		public void TowerStatus(TowerStatusRequest request, Action<TowerStatusResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ATowerService::TowerStatus(Serverproto.TowerStatusRequest,System.Action`1<Serverproto.TowerStatusResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void TowerStatus(Serverproto.TowerStatusRequest,System.Action<Serverproto.TowerStatusResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1604448", Offset="0x1604448", VA="0x1604448", Slot="6")]
		protected virtual void TowerStatusServiceSuccess(TowerStatusResponse response)
		{
		}
	}
}