using Glunies;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public abstract class AEventService : AGameServiceClient
	{
		[Address(RVA="0x15FA5E4", Offset="0x15FA5E4", VA="0x15FA5E4")]
		protected AEventService()
		{
		}

		[Address(RVA="0x15F9F98", Offset="0x15F9F98", VA="0x15F9F98")]
		protected void CacheResponse(GetDailyEventsRequest request, GetDailyEventsResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FA188", Offset="0x15FA188", VA="0x15FA188")]
		protected void CacheResponse(GetScheduledEventsRequest request, GetScheduledEventsResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FA378", Offset="0x15FA378", VA="0x15FA378")]
		protected void CacheResponse(RefreshEventBattleLimitRequest request, RefreshEventBattleLimitResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FA568", Offset="0x15FA568", VA="0x15FA568")]
		protected void CacheResponse(GetEventStatusRequest request, GetEventStatusResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15F9F1C", Offset="0x15F9F1C", VA="0x15F9F1C")]
		protected GetDailyEventsResponse GetCachedResponse(GetDailyEventsRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FA10C", Offset="0x15FA10C", VA="0x15FA10C")]
		protected GetScheduledEventsResponse GetCachedResponse(GetScheduledEventsRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FA2FC", Offset="0x15FA2FC", VA="0x15FA2FC")]
		protected RefreshEventBattleLimitResponse GetCachedResponse(RefreshEventBattleLimitRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FA4EC", Offset="0x15FA4EC", VA="0x15FA4EC")]
		protected GetEventStatusResponse GetCachedResponse(GetEventStatusRequest request)
		{
			return null;
		}

		[Address(RVA="0x15F9E24", Offset="0x15F9E24", VA="0x15F9E24")]
		public void GetDailyEvents(GetDailyEventsRequest request, Action<GetDailyEventsResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AEventService::GetDailyEvents(Serverproto.GetDailyEventsRequest,System.Action`1<Serverproto.GetDailyEventsResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void GetDailyEvents(Serverproto.GetDailyEventsRequest,System.Action<Serverproto.GetDailyEventsResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F9F18", Offset="0x15F9F18", VA="0x15F9F18", Slot="5")]
		protected virtual void GetDailyEventsServiceSuccess(GetDailyEventsResponse response)
		{
		}

		[Address(RVA="0x15FA3F4", Offset="0x15FA3F4", VA="0x15FA3F4")]
		public void GetEventStatus(GetEventStatusRequest request, Action<GetEventStatusResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AEventService::GetEventStatus(Serverproto.GetEventStatusRequest,System.Action`1<Serverproto.GetEventStatusResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void GetEventStatus(Serverproto.GetEventStatusRequest,System.Action<Serverproto.GetEventStatusResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FA4E8", Offset="0x15FA4E8", VA="0x15FA4E8", Slot="8")]
		protected virtual void GetEventStatusServiceSuccess(GetEventStatusResponse response)
		{
		}

		[Address(RVA="0x15FA014", Offset="0x15FA014", VA="0x15FA014")]
		public void GetScheduledEvents(GetScheduledEventsRequest request, Action<GetScheduledEventsResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AEventService::GetScheduledEvents(Serverproto.GetScheduledEventsRequest,System.Action`1<Serverproto.GetScheduledEventsResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void GetScheduledEvents(Serverproto.GetScheduledEventsRequest,System.Action<Serverproto.GetScheduledEventsResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FA108", Offset="0x15FA108", VA="0x15FA108", Slot="6")]
		protected virtual void GetScheduledEventsServiceSuccess(GetScheduledEventsResponse response)
		{
		}

		[Address(RVA="0x15FA204", Offset="0x15FA204", VA="0x15FA204")]
		public void RefreshBattleLimit(RefreshEventBattleLimitRequest request, Action<RefreshEventBattleLimitResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AEventService::RefreshBattleLimit(Serverproto.RefreshEventBattleLimitRequest,System.Action`1<Serverproto.RefreshEventBattleLimitResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void RefreshBattleLimit(Serverproto.RefreshEventBattleLimitRequest,System.Action<Serverproto.RefreshEventBattleLimitResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FA2F8", Offset="0x15FA2F8", VA="0x15FA2F8", Slot="7")]
		protected virtual void RefreshBattleLimitServiceSuccess(RefreshEventBattleLimitResponse response)
		{
		}
	}
}