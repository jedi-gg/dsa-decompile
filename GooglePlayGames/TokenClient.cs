using GooglePlayGames.BasicApi;
using System;

namespace GooglePlayGames
{
	internal interface TokenClient
	{
		void AddOauthScopes(params string[] scopes);

		void FetchTokens(bool silent, Action<int> callback);

		void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback);

		string GetAuthCode();

		string GetEmail();

		string GetIdToken();

		bool HasPermissions(string[] scopes);

		void RequestPermissions(string[] scopes, Action<SignInStatus> callback);

		void SetAccountName(string accountName);

		void SetHidePopups(bool flag);

		void SetRequestAuthCode(bool flag, bool forceRefresh);

		void SetRequestEmail(bool flag);

		void SetRequestIdToken(bool flag);

		void SetWebClientId(string webClientId);

		void Signout();
	}
}