using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public class HomeService : AHomeService
	{
		[Address(RVA="0x18D3348", Offset="0x18D3348", VA="0x18D3348")]
		public HomeService()
		{
		}

		[Address(RVA="0x18D28A0", Offset="0x18D28A0", VA="0x18D28A0")]
		public new void Home(HomeRequest request, Action<HomeResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.HomeService::Home(Serverproto.HomeRequest,System.Action`1<Serverproto.HomeResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void Home(Serverproto.HomeRequest,System.Action<Serverproto.HomeResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050A28", Offset="0x1050A28")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset="0x10")]
			public HomeRequest request;

			[FieldOffset(Offset="0x18")]
			public HomeService <>4__this;

			[FieldOffset(Offset="0x20")]
			public Action<HomeResponse> success;

			[Address(RVA="0x18D3340", Offset="0x18D3340", VA="0x18D3340")]
			public <>c__DisplayClass0_0()
			{
			}

			[Address(RVA="0x18D3350", Offset="0x18D3350", VA="0x18D3350")]
			internal void <Home>b__0(HomeResponse response)
			{
			}
		}
	}
}