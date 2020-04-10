using Glunies;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public abstract class ACampaignService : AGameServiceClient
	{
		[Address(RVA="0x2C45E10", Offset="0x2C45E10", VA="0x2C45E10")]
		protected ACampaignService()
		{
		}

		[Address(RVA="0x2C45A30", Offset="0x2C45A30", VA="0x2C45A30")]
		public void BuyPveRefresh(BuyPveRefreshRequest request, Action<BuyPveRefreshResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ACampaignService::BuyPveRefresh(Serverproto.BuyPveRefreshRequest,System.Action`1<Serverproto.BuyPveRefreshResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void BuyPveRefresh(Serverproto.BuyPveRefreshRequest,System.Action<Serverproto.BuyPveRefreshResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C45B24", Offset="0x2C45B24", VA="0x2C45B24", Slot="6")]
		protected virtual void BuyPveRefreshServiceSuccess(BuyPveRefreshResponse response)
		{
		}

		[Address(RVA="0x2C459B4", Offset="0x2C459B4", VA="0x2C459B4")]
		protected void CacheResponse(CampaignMapDetailRequest request, CampaignMapDetailResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C45BA4", Offset="0x2C45BA4", VA="0x2C45BA4")]
		protected void CacheResponse(BuyPveRefreshRequest request, BuyPveRefreshResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C45D94", Offset="0x2C45D94", VA="0x2C45D94")]
		protected void CacheResponse(CampaignDetailRequest request, CampaignDetailResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C45C20", Offset="0x2C45C20", VA="0x2C45C20")]
		public void CampaignDetail(CampaignDetailRequest request, Action<CampaignDetailResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ACampaignService::CampaignDetail(Serverproto.CampaignDetailRequest,System.Action`1<Serverproto.CampaignDetailResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void CampaignDetail(Serverproto.CampaignDetailRequest,System.Action<Serverproto.CampaignDetailResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C45D14", Offset="0x2C45D14", VA="0x2C45D14", Slot="7")]
		protected virtual void CampaignDetailServiceSuccess(CampaignDetailResponse response)
		{
		}

		[Address(RVA="0x2C45840", Offset="0x2C45840", VA="0x2C45840")]
		public void CampaignMapDetail(CampaignMapDetailRequest request, Action<CampaignMapDetailResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ACampaignService::CampaignMapDetail(Serverproto.CampaignMapDetailRequest,System.Action`1<Serverproto.CampaignMapDetailResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void CampaignMapDetail(Serverproto.CampaignMapDetailRequest,System.Action<Serverproto.CampaignMapDetailResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C45934", Offset="0x2C45934", VA="0x2C45934", Slot="5")]
		protected virtual void CampaignMapDetailServiceSuccess(CampaignMapDetailResponse response)
		{
		}

		[Address(RVA="0x2C45938", Offset="0x2C45938", VA="0x2C45938")]
		protected CampaignMapDetailResponse GetCachedResponse(CampaignMapDetailRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C45B28", Offset="0x2C45B28", VA="0x2C45B28")]
		protected BuyPveRefreshResponse GetCachedResponse(BuyPveRefreshRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C45D18", Offset="0x2C45D18", VA="0x2C45D18")]
		protected CampaignDetailResponse GetCachedResponse(CampaignDetailRequest request)
		{
			return null;
		}
	}
}