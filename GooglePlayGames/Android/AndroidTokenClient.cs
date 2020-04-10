using GooglePlayGames;
using GooglePlayGames.BasicApi;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidTokenClient : TokenClient
	{
		[FieldOffset(Offset="0x0")]
		private const string HelperFragmentClass = "com.google.games.bridge.HelperFragment";

		[FieldOffset(Offset="0x10")]
		private bool requestEmail;

		[FieldOffset(Offset="0x11")]
		private bool requestAuthCode;

		[FieldOffset(Offset="0x12")]
		private bool requestIdToken;

		[FieldOffset(Offset="0x18")]
		private List<string> oauthScopes;

		[FieldOffset(Offset="0x20")]
		private string webClientId;

		[FieldOffset(Offset="0x28")]
		private bool forceRefresh;

		[FieldOffset(Offset="0x29")]
		private bool hidePopups;

		[FieldOffset(Offset="0x30")]
		private string accountName;

		[FieldOffset(Offset="0x38")]
		private AndroidJavaObject account;

		[FieldOffset(Offset="0x40")]
		private string email;

		[FieldOffset(Offset="0x48")]
		private string authCode;

		[FieldOffset(Offset="0x50")]
		private string idToken;

		[Address(RVA="0x1EB6B40", Offset="0x1EB6B40", VA="0x1EB6B40")]
		public AndroidTokenClient()
		{
		}

		[Address(RVA="0x1EB4AD4", Offset="0x1EB4AD4", VA="0x1EB4AD4", Slot="14")]
		public void AddOauthScopes(params string[] scopes)
		{
		}

		[Address(RVA="0x1EB5608", Offset="0x1EB5608", VA="0x1EB5608")]
		private void DoFetchToken(bool silent, Action<int> callback)
		{
		}

		[Address(RVA="0x1EB6180", Offset="0x1EB6180", VA="0x1EB6180")]
		private void DoGetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		[Address(RVA="0x1EB4CA0", Offset="0x1EB4CA0", VA="0x1EB4CA0", Slot="16")]
		public void FetchTokens(bool silent, Action<int> callback)
		{
		}

		[Address(RVA="0x1EB606C", Offset="0x1EB606C", VA="0x1EB606C")]
		public AndroidJavaObject GetAccount()
		{
			return null;
		}

		[Address(RVA="0x1EB6074", Offset="0x1EB6074", VA="0x1EB6074", Slot="7")]
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		[Address(RVA="0x1EB4C90", Offset="0x1EB4C90", VA="0x1EB4C90", Slot="5")]
		public string GetAuthCode()
		{
			return null;
		}

		[Address(RVA="0x1EB4C88", Offset="0x1EB4C88", VA="0x1EB4C88", Slot="4")]
		public string GetEmail()
		{
			return null;
		}

		[Address(RVA="0x1EB4C98", Offset="0x1EB4C98", VA="0x1EB4C98", Slot="6")]
		public string GetIdToken()
		{
			return null;
		}

		[Address(RVA="0x1EB52F0", Offset="0x1EB52F0", VA="0x1EB52F0", Slot="18")]
		public bool HasPermissions(string[] scopes)
		{
			return new bool();
		}

		[Address(RVA="0x1EB4DAC", Offset="0x1EB4DAC", VA="0x1EB4DAC", Slot="17")]
		public void RequestPermissions(string[] scopes, Action<SignInStatus> callback)
		{
		}

		[Address(RVA="0x1EB4ACC", Offset="0x1EB4ACC", VA="0x1EB4ACC", Slot="13")]
		public void SetAccountName(string accountName)
		{
		}

		[Address(RVA="0x1EB4AC0", Offset="0x1EB4AC0", VA="0x1EB4AC0", Slot="15")]
		public void SetHidePopups(bool flag)
		{
		}

		[Address(RVA="0x1EB4A8C", Offset="0x1EB4A8C", VA="0x1EB4A8C", Slot="9")]
		public void SetRequestAuthCode(bool flag, bool forceRefresh)
		{
		}

		[Address(RVA="0x1EB4AA0", Offset="0x1EB4AA0", VA="0x1EB4AA0", Slot="10")]
		public void SetRequestEmail(bool flag)
		{
		}

		[Address(RVA="0x1EB4AAC", Offset="0x1EB4AAC", VA="0x1EB4AAC", Slot="11")]
		public void SetRequestIdToken(bool flag)
		{
		}

		[Address(RVA="0x1EB4AB8", Offset="0x1EB4AB8", VA="0x1EB4AB8", Slot="12")]
		public void SetWebClientId(string webClientId)
		{
		}

		[Address(RVA="0x1EB4B84", Offset="0x1EB4B84", VA="0x1EB4B84", Slot="8")]
		public void Signout()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EA98", Offset="0x104EA98")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AndroidTokenClient.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Action <>9__20_0;

			[Address(RVA="0x1EB6B48", Offset="0x1EB6B48", VA="0x1EB6B48")]
			static <>c()
			{
			}

			[Address(RVA="0x1EB6BAC", Offset="0x1EB6BAC", VA="0x1EB6BAC")]
			public <>c()
			{
			}

			[Address(RVA="0x1EB6BB4", Offset="0x1EB6BB4", VA="0x1EB6BB4")]
			internal void <Signout>b__20_0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EAA8", Offset="0x104EAA8")]
		private sealed class <>c__DisplayClass24_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidTokenClient <>4__this;

			[FieldOffset(Offset="0x18")]
			public bool silent;

			[FieldOffset(Offset="0x20")]
			public Action<int> callback;

			[Address(RVA="0x1EB4DA4", Offset="0x1EB4DA4", VA="0x1EB4DA4")]
			public <>c__DisplayClass24_0()
			{
			}

			[Address(RVA="0x1EB6CF4", Offset="0x1EB6CF4", VA="0x1EB6CF4")]
			internal void <FetchTokens>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EAB8", Offset="0x104EAB8")]
		private sealed class <>c__DisplayClass25_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<SignInStatus> callback;

			[FieldOffset(Offset="0x18")]
			public AndroidTokenClient <>4__this;

			[FieldOffset(Offset="0x20")]
			public string[] scopes;

			[Address(RVA="0x1EB52E8", Offset="0x1EB52E8", VA="0x1EB52E8")]
			public <>c__DisplayClass25_0()
			{
			}

			[Address(RVA="0x1EB6D3C", Offset="0x1EB6D3C", VA="0x1EB6D3C")]
			internal void <RequestPermissions>b__0(AndroidJavaObject accountWithNewScopes)
			{
			}

			[Address(RVA="0x1EB6F30", Offset="0x1EB6F30", VA="0x1EB6F30")]
			internal void <RequestPermissions>b__1(AndroidJavaObject e)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EAC8", Offset="0x104EAC8")]
		private sealed class <>c__DisplayClass27_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidTokenClient <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action<int> callback;

			[Address(RVA="0x1EB5FDC", Offset="0x1EB5FDC", VA="0x1EB5FDC")]
			public <>c__DisplayClass27_0()
			{
			}

			[Address(RVA="0x1EB708C", Offset="0x1EB708C", VA="0x1EB708C")]
			internal void <DoFetchToken>b__0(AndroidJavaObject tokenResult)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EAD8", Offset="0x104EAD8")]
		private sealed class <>c__DisplayClass29_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidTokenClient <>4__this;

			[FieldOffset(Offset="0x18")]
			public bool reAuthenticateIfNeeded;

			[FieldOffset(Offset="0x20")]
			public Action<string> callback;

			[Address(RVA="0x1EB6178", Offset="0x1EB6178", VA="0x1EB6178")]
			public <>c__DisplayClass29_0()
			{
			}

			[Address(RVA="0x1EB728C", Offset="0x1EB728C", VA="0x1EB728C")]
			internal void <GetAnotherServerAuthCode>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EAE8", Offset="0x104EAE8")]
		private sealed class <>c__DisplayClass30_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<string> callback;

			[Address(RVA="0x1EB6B38", Offset="0x1EB6B38", VA="0x1EB6B38")]
			public <>c__DisplayClass30_0()
			{
			}

			[Address(RVA="0x1EB72D4", Offset="0x1EB72D4", VA="0x1EB72D4")]
			internal void <DoGetAnotherServerAuthCode>b__0(AndroidJavaObject tokenResult)
			{
			}
		}

		private class ResultCallbackProxy : AndroidJavaProxy
		{
			[FieldOffset(Offset="0x20")]
			private Action<AndroidJavaObject> mCallback;

			[Address(RVA="0x1EB5FE4", Offset="0x1EB5FE4", VA="0x1EB5FE4")]
			public ResultCallbackProxy(Action<AndroidJavaObject> callback)
			{
			}

			[Address(RVA="0x1EB738C", Offset="0x1EB738C", VA="0x1EB738C")]
			public void onResult(AndroidJavaObject tokenResult)
			{
			}
		}
	}
}