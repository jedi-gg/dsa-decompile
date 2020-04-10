using Glunies;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public abstract class AChatService : AGameServiceClient
	{
		[Address(RVA="0x2C46828", Offset="0x2C46828", VA="0x2C46828")]
		protected AChatService()
		{
		}

		[Address(RVA="0x2C46448", Offset="0x2C46448", VA="0x2C46448")]
		public void BlockUser(BlockChatUserRequest request, Action<BlockChatUserResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AChatService::BlockUser(Serverproto.BlockChatUserRequest,System.Action`1<Serverproto.BlockChatUserResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void BlockUser(Serverproto.BlockChatUserRequest,System.Action<Serverproto.BlockChatUserResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4653C", Offset="0x2C4653C", VA="0x2C4653C", Slot="8")]
		protected virtual void BlockUserServiceSuccess(BlockChatUserResponse response)
		{
		}

		[Address(RVA="0x2C45FEC", Offset="0x2C45FEC", VA="0x2C45FEC")]
		protected void CacheResponse(ChatReportRequest request, ChatReportResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C461DC", Offset="0x2C461DC", VA="0x2C461DC")]
		protected void CacheResponse(ChatMessage request, ChatMessageResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C463CC", Offset="0x2C463CC", VA="0x2C463CC")]
		protected void CacheResponse(GetBlockedChatUsersRequest request, GetBlockedChatUsersResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C465BC", Offset="0x2C465BC", VA="0x2C465BC")]
		protected void CacheResponse(BlockChatUserRequest request, BlockChatUserResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C467AC", Offset="0x2C467AC", VA="0x2C467AC")]
		protected void CacheResponse(UnblockChatUserRequest request, UnblockChatUserResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x2C45E78", Offset="0x2C45E78", VA="0x2C45E78")]
		public void ChatReport(ChatReportRequest request, Action<ChatReportResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AChatService::ChatReport(Serverproto.ChatReportRequest,System.Action`1<Serverproto.ChatReportResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ChatReport(Serverproto.ChatReportRequest,System.Action<Serverproto.ChatReportResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C45F6C", Offset="0x2C45F6C", VA="0x2C45F6C", Slot="5")]
		protected virtual void ChatReportServiceSuccess(ChatReportResponse response)
		{
		}

		[Address(RVA="0x2C46258", Offset="0x2C46258", VA="0x2C46258")]
		public void GetBlockedUsers(GetBlockedChatUsersRequest request, Action<GetBlockedChatUsersResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AChatService::GetBlockedUsers(Serverproto.GetBlockedChatUsersRequest,System.Action`1<Serverproto.GetBlockedChatUsersResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void GetBlockedUsers(Serverproto.GetBlockedChatUsersRequest,System.Action<Serverproto.GetBlockedChatUsersResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4634C", Offset="0x2C4634C", VA="0x2C4634C", Slot="7")]
		protected virtual void GetBlockedUsersServiceSuccess(GetBlockedChatUsersResponse response)
		{
		}

		[Address(RVA="0x2C45F70", Offset="0x2C45F70", VA="0x2C45F70")]
		protected ChatReportResponse GetCachedResponse(ChatReportRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C46160", Offset="0x2C46160", VA="0x2C46160")]
		protected ChatMessageResponse GetCachedResponse(ChatMessage request)
		{
			return null;
		}

		[Address(RVA="0x2C46350", Offset="0x2C46350", VA="0x2C46350")]
		protected GetBlockedChatUsersResponse GetCachedResponse(GetBlockedChatUsersRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C46540", Offset="0x2C46540", VA="0x2C46540")]
		protected BlockChatUserResponse GetCachedResponse(BlockChatUserRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C46730", Offset="0x2C46730", VA="0x2C46730")]
		protected UnblockChatUserResponse GetCachedResponse(UnblockChatUserRequest request)
		{
			return null;
		}

		[Address(RVA="0x2C46068", Offset="0x2C46068", VA="0x2C46068")]
		public void SendMessage(ChatMessage request, Action<ChatMessageResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AChatService::SendMessage(Serverproto.ChatMessage,System.Action`1<Serverproto.ChatMessageResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void SendMessage(Serverproto.ChatMessage,System.Action<Serverproto.ChatMessageResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4615C", Offset="0x2C4615C", VA="0x2C4615C", Slot="6")]
		protected virtual void SendMessageServiceSuccess(ChatMessageResponse response)
		{
		}

		[Address(RVA="0x2C46638", Offset="0x2C46638", VA="0x2C46638")]
		public void UnblockUser(UnblockChatUserRequest request, Action<UnblockChatUserResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AChatService::UnblockUser(Serverproto.UnblockChatUserRequest,System.Action`1<Serverproto.UnblockChatUserResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void UnblockUser(Serverproto.UnblockChatUserRequest,System.Action<Serverproto.UnblockChatUserResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2C4672C", Offset="0x2C4672C", VA="0x2C4672C", Slot="9")]
		protected virtual void UnblockUserServiceSuccess(UnblockChatUserResponse response)
		{
		}
	}
}