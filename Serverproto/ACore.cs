using Glunies;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public abstract class ACore : AGameServiceClient
	{
		[Address(RVA="0x15F9DBC", Offset="0x15F9DBC", VA="0x15F9DBC")]
		protected ACore()
		{
		}

		[Address(RVA="0x15F95FC", Offset="0x15F95FC", VA="0x15F95FC")]
		public void Auth(AuthRequest request, Action<AuthResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ACore::Auth(Serverproto.AuthRequest,System.Action`1<Serverproto.AuthResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void Auth(Serverproto.AuthRequest,System.Action<Serverproto.AuthResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F96F0", Offset="0x15F96F0", VA="0x15F96F0", Slot="5")]
		protected virtual void AuthServiceSuccess(AuthResponse response)
		{
		}

		[Address(RVA="0x15F9BCC", Offset="0x15F9BCC", VA="0x15F9BCC")]
		public void AuthToken(AuthTokenRequest request, Action<AuthTokenResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ACore::AuthToken(Serverproto.AuthTokenRequest,System.Action`1<Serverproto.AuthTokenResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void AuthToken(Serverproto.AuthTokenRequest,System.Action<Serverproto.AuthTokenResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F9CC0", Offset="0x15F9CC0", VA="0x15F9CC0", Slot="8")]
		protected virtual void AuthTokenServiceSuccess(AuthTokenResponse response)
		{
		}

		[Address(RVA="0x15F9770", Offset="0x15F9770", VA="0x15F9770")]
		protected void CacheResponse(AuthRequest request, AuthResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15F9960", Offset="0x15F9960", VA="0x15F9960")]
		protected void CacheResponse(MetadataRequest request, MetadataResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15F9B50", Offset="0x15F9B50", VA="0x15F9B50")]
		protected void CacheResponse(CheatRequest request, CheatResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15F9D40", Offset="0x15F9D40", VA="0x15F9D40")]
		protected void CacheResponse(AuthTokenRequest request, AuthTokenResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15F99DC", Offset="0x15F99DC", VA="0x15F99DC")]
		public void Cheat(CheatRequest request, Action<CheatResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ACore::Cheat(Serverproto.CheatRequest,System.Action`1<Serverproto.CheatResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void Cheat(Serverproto.CheatRequest,System.Action<Serverproto.CheatResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F9AD0", Offset="0x15F9AD0", VA="0x15F9AD0", Slot="7")]
		protected virtual void CheatServiceSuccess(CheatResponse response)
		{
		}

		[Address(RVA="0x15F96F4", Offset="0x15F96F4", VA="0x15F96F4")]
		protected AuthResponse GetCachedResponse(AuthRequest request)
		{
			return null;
		}

		[Address(RVA="0x15F98E4", Offset="0x15F98E4", VA="0x15F98E4")]
		protected MetadataResponse GetCachedResponse(MetadataRequest request)
		{
			return null;
		}

		[Address(RVA="0x15F9AD4", Offset="0x15F9AD4", VA="0x15F9AD4")]
		protected CheatResponse GetCachedResponse(CheatRequest request)
		{
			return null;
		}

		[Address(RVA="0x15F9CC4", Offset="0x15F9CC4", VA="0x15F9CC4")]
		protected AuthTokenResponse GetCachedResponse(AuthTokenRequest request)
		{
			return null;
		}

		[Address(RVA="0x15F97EC", Offset="0x15F97EC", VA="0x15F97EC")]
		public void Meta(MetadataRequest request, Action<MetadataResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.ACore::Meta(Serverproto.MetadataRequest,System.Action`1<Serverproto.MetadataResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void Meta(Serverproto.MetadataRequest,System.Action<Serverproto.MetadataResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F98E0", Offset="0x15F98E0", VA="0x15F98E0", Slot="6")]
		protected virtual void MetaServiceSuccess(MetadataResponse response)
		{
		}
	}
}