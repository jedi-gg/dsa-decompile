using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	public class PlayGamesPlatform : ISocialPlatform
	{
		[FieldOffset(Offset="0x0")]
		private static PlayGamesPlatform sInstance;

		[FieldOffset(Offset="0x8")]
		private static bool sNearbyInitializePending;

		[FieldOffset(Offset="0x10")]
		private static INearbyConnectionClient sNearbyConnectionClient;

		[FieldOffset(Offset="0x10")]
		private readonly PlayGamesClientConfiguration mConfiguration;

		[FieldOffset(Offset="0x40")]
		private PlayGamesLocalUser mLocalUser;

		[FieldOffset(Offset="0x48")]
		private IPlayGamesClient mClient;

		[FieldOffset(Offset="0x50")]
		private string mDefaultLbUi;

		[FieldOffset(Offset="0x58")]
		private Dictionary<string, string> mIdMap;

		public static bool DebugLogEnabled
		{
			[Address(RVA="0x12D9CAC", Offset="0x12D9CAC", VA="0x12D9CAC")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x12D9D08", Offset="0x12D9D08", VA="0x12D9D08")]
			set
			{
			}
		}

		public IEventsClient Events
		{
			[Address(RVA="0x12DA420", Offset="0x12DA420", VA="0x12DA420")]
			get
			{
				return null;
			}
		}

		public static PlayGamesPlatform Instance
		{
			[Address(RVA="0x12D67F4", Offset="0x12D67F4", VA="0x12D67F4")]
			get
			{
				return null;
			}
		}

		public ILocalUser localUser
		{
			[Address(RVA="0x12DA590", Offset="0x12DA590", VA="0x12DA590", Slot="4")]
			get
			{
				return null;
			}
		}

		public static INearbyConnectionClient Nearby
		{
			[Address(RVA="0x12D9F28", Offset="0x12D9F28", VA="0x12D9F28")]
			get
			{
				return null;
			}
		}

		public IRealTimeMultiplayerClient RealTime
		{
			[Address(RVA="0x12DA1F8", Offset="0x12DA1F8", VA="0x12DA1F8")]
			get
			{
				return null;
			}
		}

		public ISavedGameClient SavedGame
		{
			[Address(RVA="0x12DA368", Offset="0x12DA368", VA="0x12DA368")]
			get
			{
				return null;
			}
		}

		public ITurnBasedMultiplayerClient TurnBased
		{
			[Address(RVA="0x12DA2B0", Offset="0x12DA2B0", VA="0x12DA2B0")]
			get
			{
				return null;
			}
		}

		public IVideoClient Video
		{
			[Address(RVA="0x12DA4D8", Offset="0x12DA4D8", VA="0x12DA4D8")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x12DDFD0", Offset="0x12DDFD0", VA="0x12DDFD0")]
		static PlayGamesPlatform()
		{
		}

		[Address(RVA="0x12D9ADC", Offset="0x12D9ADC", VA="0x12D9ADC")]
		internal PlayGamesPlatform(IPlayGamesClient client)
		{
		}

		[Address(RVA="0x12D9BCC", Offset="0x12D9BCC", VA="0x12D9BCC")]
		private PlayGamesPlatform(PlayGamesClientConfiguration configuration)
		{
		}

		[Address(RVA="0x12DA5A0", Offset="0x12DA5A0", VA="0x12DA5A0")]
		public static PlayGamesPlatform Activate()
		{
			return null;
		}

		[Address(RVA="0x12DA728", Offset="0x12DA728", VA="0x12DA728")]
		public void AddIdMapping(string fromId, string toId)
		{
		}

		[Address(RVA="0x12D8878", Offset="0x12D8878", VA="0x12D8878")]
		public void Authenticate(Action<bool> callback)
		{
		}

		[Address(RVA="0x12D88B8", Offset="0x12D88B8", VA="0x12D88B8")]
		public void Authenticate(Action<bool, string> callback)
		{
		}

		[Address(RVA="0x12D8904", Offset="0x12D8904", VA="0x12D8904")]
		public void Authenticate(Action<bool> callback, bool silent)
		{
		}

		[Address(RVA="0x12D8A04", Offset="0x12D8A04", VA="0x12D8A04")]
		public void Authenticate(Action<bool, string> callback, bool silent)
		{
		}

		[Address(RVA="0x12DA7B0", Offset="0x12DA7B0", VA="0x12DA7B0")]
		public void Authenticate(SignInInteractivity signInInteractivity, Action<SignInStatus> callback)
		{
		}

		[Address(RVA="0x12DABBC", Offset="0x12DABBC", VA="0x12DABBC", Slot="5")]
		public void Authenticate(ILocalUser unused, Action<bool> callback)
		{
		}

		[Address(RVA="0x12DABC8", Offset="0x12DABC8", VA="0x12DABC8", Slot="6")]
		public void Authenticate(ILocalUser unused, Action<bool, string> callback)
		{
		}

		[Address(RVA="0x12DC538", Offset="0x12DC538", VA="0x12DC538", Slot="12")]
		public IAchievement CreateAchievement()
		{
			return null;
		}

		[Address(RVA="0x12DD0D8", Offset="0x12DD0D8", VA="0x12DD0D8", Slot="15")]
		public ILeaderboard CreateLeaderboard()
		{
			return null;
		}

		[Address(RVA="0x12DAF40", Offset="0x12DAF40", VA="0x12DAF40")]
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		[Address(RVA="0x12D8C70", Offset="0x12D8C70", VA="0x12D8C70")]
		internal IUserProfile[] GetFriends()
		{
			return null;
		}

		[Address(RVA="0x12D8DAC", Offset="0x12D8DAC", VA="0x12D8DAC")]
		public string GetIdToken()
		{
			return null;
		}

		[Address(RVA="0x12DDB9C", Offset="0x12DDB9C", VA="0x12DDB9C", Slot="7")]
		public bool GetLoading(ILeaderboard board)
		{
			return new bool();
		}

		[Address(RVA="0x12D9894", Offset="0x12D9894", VA="0x12D9894")]
		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		[Address(RVA="0x12DADFC", Offset="0x12DADFC", VA="0x12DADFC")]
		public string GetServerAuthCode()
		{
			return null;
		}

		[Address(RVA="0x12D9084", Offset="0x12D9084", VA="0x12D9084")]
		public string GetUserDisplayName()
		{
			return null;
		}

		[Address(RVA="0x12D96B4", Offset="0x12D96B4", VA="0x12D96B4")]
		public string GetUserEmail()
		{
			return null;
		}

		[Address(RVA="0x12D91A0", Offset="0x12D91A0", VA="0x12D91A0")]
		public string GetUserId()
		{
			return null;
		}

		[Address(RVA="0x12D92AC", Offset="0x12D92AC", VA="0x12D92AC")]
		public string GetUserImageUrl()
		{
			return null;
		}

		[Address(RVA="0x12DDD1C", Offset="0x12DDD1C", VA="0x12DDD1C")]
		internal void HandleLoadingScores(PlayGamesLeaderboard board, LeaderboardScoreData scoreData, Action<bool> callback)
		{
		}

		[Address(RVA="0x12DD9C4", Offset="0x12DD9C4", VA="0x12DD9C4")]
		public bool HasPermission(string scope)
		{
			return new bool();
		}

		[Address(RVA="0x12DDA84", Offset="0x12DDA84", VA="0x12DDA84")]
		public bool HasPermissions(string[] scopes)
		{
			return new bool();
		}

		[Address(RVA="0x12DBBCC", Offset="0x12DBBCC", VA="0x12DBBCC")]
		public void IncrementAchievement(string achievementID, int steps, Action<bool> callback)
		{
		}

		[Address(RVA="0x12D9D6C", Offset="0x12D9D6C", VA="0x12D9D6C")]
		public static void InitializeInstance(PlayGamesClientConfiguration configuration)
		{
		}

		[Address(RVA="0x12DA024", Offset="0x12DA024", VA="0x12DA024")]
		public static void InitializeNearby(Action<INearbyConnectionClient> callback)
		{
		}

		[Address(RVA="0x12D8EC8", Offset="0x12D8EC8", VA="0x12D8EC8")]
		public bool IsAuthenticated()
		{
			return new bool();
		}

		[Address(RVA="0x12DC1F4", Offset="0x12DC1F4", VA="0x12DC1F4", Slot="10")]
		public void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback)
		{
		}

		[Address(RVA="0x12DC398", Offset="0x12DC398", VA="0x12DC398", Slot="11")]
		public void LoadAchievements(Action<IAchievement[]> callback)
		{
		}

		[Address(RVA="0x12D8B08", Offset="0x12D8B08", VA="0x12D8B08", Slot="18")]
		public void LoadFriends(ILocalUser user, Action<bool> callback)
		{
		}

		[Address(RVA="0x12DCF54", Offset="0x12DCF54", VA="0x12DCF54")]
		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
		}

		[Address(RVA="0x12DCC5C", Offset="0x12DCC5C", VA="0x12DCC5C", Slot="14")]
		public void LoadScores(string leaderboardId, Action<IScore[]> callback)
		{
		}

		[Address(RVA="0x12DCDBC", Offset="0x12DCDBC", VA="0x12DCDBC")]
		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		[Address(RVA="0x12D78F4", Offset="0x12D78F4", VA="0x12D78F4", Slot="19")]
		public void LoadScores(ILeaderboard board, Action<bool> callback)
		{
		}

		[Address(RVA="0x12DACA8", Offset="0x12DACA8", VA="0x12DACA8", Slot="8")]
		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
		{
		}

		[Address(RVA="0x12DB788", Offset="0x12DB788", VA="0x12DB788")]
		private string MapId(string id)
		{
			return null;
		}

		[Address(RVA="0x12DDC54", Offset="0x12DDC54", VA="0x12DDC54")]
		public void RegisterInvitationDelegate(InvitationReceivedDelegate deleg)
		{
		}

		[Address(RVA="0x12DB200", Offset="0x12DB200", VA="0x12DB200", Slot="9")]
		public void ReportProgress(string achievementID, double progress, Action<bool> callback)
		{
		}

		[Address(RVA="0x12DC590", Offset="0x12DC590", VA="0x12DC590", Slot="13")]
		public void ReportScore(long score, string board, Action<bool> callback)
		{
		}

		[Address(RVA="0x12DC8A4", Offset="0x12DC8A4", VA="0x12DC8A4")]
		public void ReportScore(long score, string board, string metadata, Action<bool> callback)
		{
		}

		[Address(RVA="0x12DD7C0", Offset="0x12DD7C0", VA="0x12DD7C0")]
		public void RequestPermission(string scope, Action<SignInStatus> callback)
		{
		}

		[Address(RVA="0x12DD888", Offset="0x12DD888", VA="0x12DD888")]
		public void RequestPermissions(string[] scopes, Action<SignInStatus> callback)
		{
		}

		[Address(RVA="0x12DB894", Offset="0x12DB894", VA="0x12DB894")]
		public void RevealAchievement(string achievementID, Action<bool> callback = // 
		// Current member / type: System.Void GooglePlayGames.PlayGamesPlatform::RevealAchievement(System.String,System.Action`1<System.Boolean>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void RevealAchievement(System.String,System.Action<System.Boolean>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x12DD708", Offset="0x12DD708", VA="0x12DD708")]
		public void SetDefaultLeaderboardForUI(string lbid)
		{
		}

		[Address(RVA="0x12DA660", Offset="0x12DA660", VA="0x12DA660")]
		public void SetGravityForPopups(Gravity gravity)
		{
		}

		[Address(RVA="0x12DBEE0", Offset="0x12DBEE0", VA="0x12DBEE0")]
		public void SetStepsAtLeast(string achievementID, int steps, Action<bool> callback)
		{
		}

		[Address(RVA="0x12DD13C", Offset="0x12DD13C", VA="0x12DD13C", Slot="16")]
		public void ShowAchievementsUI()
		{
		}

		[Address(RVA="0x12DD144", Offset="0x12DD144", VA="0x12DD144")]
		public void ShowAchievementsUI(Action<UIStatus> callback)
		{
		}

		[Address(RVA="0x12DD29C", Offset="0x12DD29C", VA="0x12DD29C", Slot="17")]
		public void ShowLeaderboardUI()
		{
		}

		[Address(RVA="0x12DD338", Offset="0x12DD338", VA="0x12DD338")]
		public void ShowLeaderboardUI(string leaderboardId)
		{
		}

		[Address(RVA="0x12DD328", Offset="0x12DD328", VA="0x12DD328")]
		public void ShowLeaderboardUI(string leaderboardId, Action<UIStatus> callback)
		{
		}

		[Address(RVA="0x12DD41C", Offset="0x12DD41C", VA="0x12DD41C")]
		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback)
		{
		}

		[Address(RVA="0x12DABD4", Offset="0x12DABD4", VA="0x12DABD4")]
		public void SignOut()
		{
		}

		[Address(RVA="0x1F5C4B8", Offset="0x1F5C4B8", VA="0x1F5C4B8")]
		private static Action<T> ToOnGameThread<T>(Action<T> toConvert)
		{
			return null;
		}

		[Address(RVA="0x12DBA30", Offset="0x12DBA30", VA="0x12DBA30")]
		public void UnlockAchievement(string achievementID, Action<bool> callback = // 
		// Current member / type: System.Void GooglePlayGames.PlayGamesPlatform::UnlockAchievement(System.String,System.Action`1<System.Boolean>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void UnlockAchievement(System.String,System.Action<System.Boolean>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E648", Offset="0x104E648")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayGamesPlatform.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Action<SignInStatus> <>9__38_0;

			[Address(RVA="0x12DDFD4", Offset="0x12DDFD4", VA="0x12DDFD4")]
			static <>c()
			{
			}

			[Address(RVA="0x12DE038", Offset="0x12DE038", VA="0x12DE038")]
			public <>c()
			{
			}

			[Address(RVA="0x12DE040", Offset="0x12DE040", VA="0x12DE040")]
			internal void <Authenticate>b__38_0(SignInStatus status)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E6E8", Offset="0x104E6E8")]
		[Serializable]
		private sealed class <>c__84<T>
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayGamesPlatform.<>c__84<T> <>9;

			[FieldOffset(Offset="0x0")]
			public static Action<T> <>9__84_0;

			[Address(RVA="0x1D8EF28", Offset="0x1D8EF28", VA="0x1D8EF28")]
			static <>c__84()
			{
			}

			[Address(RVA="0x1D8F000", Offset="0x1D8F000", VA="0x1D8F000")]
			public <>c__84()
			{
			}

			[Address(RVA="0x1D8F02C", Offset="0x1D8F02C", VA="0x1D8F02C")]
			internal void <ToOnGameThread>b__84_0(T u003cp0u003e)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E608", Offset="0x104E608")]
		private sealed class <>c__DisplayClass30_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<INearbyConnectionClient> callback;

			[Address(RVA="0x12DA598", Offset="0x12DA598", VA="0x12DA598")]
			public <>c__DisplayClass30_0()
			{
			}

			[Address(RVA="0x12DE044", Offset="0x12DE044", VA="0x12DE044")]
			internal void <InitializeNearby>b__0(INearbyConnectionClient client)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E618", Offset="0x104E618")]
		private sealed class <>c__DisplayClass36_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<bool> callback;

			[Address(RVA="0x12DA7A0", Offset="0x12DA7A0", VA="0x12DA7A0")]
			public <>c__DisplayClass36_0()
			{
			}

			[Address(RVA="0x12DE144", Offset="0x12DE144", VA="0x12DE144")]
			internal void <Authenticate>b__0(bool success, string msg)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E628", Offset="0x104E628")]
		private sealed class <>c__DisplayClass37_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<bool, string> callback;

			[Address(RVA="0x12DA7A8", Offset="0x12DA7A8", VA="0x12DA7A8")]
			public <>c__DisplayClass37_0()
			{
			}

			[Address(RVA="0x12DE1B4", Offset="0x12DE1B4", VA="0x12DE1B4")]
			internal void <Authenticate>b__0(SignInStatus status)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E638", Offset="0x104E638")]
		private sealed class <>c__DisplayClass38_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<SignInStatus> callback;

			[FieldOffset(Offset="0x18")]
			public PlayGamesPlatform <>4__this;

			[FieldOffset(Offset="0x20")]
			public Action<SignInStatus> <>9__5;

			[Address(RVA="0x12DABB4", Offset="0x12DABB4", VA="0x12DABB4")]
			public <>c__DisplayClass38_0()
			{
			}

			[Address(RVA="0x12DE314", Offset="0x12DE314", VA="0x12DE314")]
			internal void <Authenticate>b__1(SignInStatus code)
			{
			}

			[Address(RVA="0x12DE3BC", Offset="0x12DE3BC", VA="0x12DE3BC")]
			internal void <Authenticate>b__2(SignInStatus code)
			{
			}

			[Address(RVA="0x12DE464", Offset="0x12DE464", VA="0x12DE464")]
			internal void <Authenticate>b__3(SignInStatus silentSignInResultCode)
			{
			}

			[Address(RVA="0x12DE798", Offset="0x12DE798", VA="0x12DE798")]
			internal void <Authenticate>b__4()
			{
			}

			[Address(RVA="0x12DE6C8", Offset="0x12DE6C8", VA="0x12DE6C8")]
			internal void <Authenticate>b__5(SignInStatus interactiveSignInResultCode)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E658", Offset="0x104E658")]
		private sealed class <>c__DisplayClass47_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<string> callback;

			[FieldOffset(Offset="0x18")]
			public PlayGamesPlatform <>4__this;

			[Address(RVA="0x12DB1F8", Offset="0x12DB1F8", VA="0x12DB1F8")]
			public <>c__DisplayClass47_0()
			{
			}

			[Address(RVA="0x12DE7FC", Offset="0x12DE7FC", VA="0x12DE7FC")]
			internal void <GetAnotherServerAuthCode>b__0(SignInStatus status)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E668", Offset="0x104E668")]
		private sealed class <>c__DisplayClass52_0
		{
			[FieldOffset(Offset="0x10")]
			public string achievementID;

			[FieldOffset(Offset="0x18")]
			public double progress;

			[FieldOffset(Offset="0x20")]
			public PlayGamesPlatform <>4__this;

			[FieldOffset(Offset="0x28")]
			public Action<bool> callback;

			[Address(RVA="0x12DB780", Offset="0x12DB780", VA="0x12DB780")]
			public <>c__DisplayClass52_0()
			{
			}

			[Address(RVA="0x12DE998", Offset="0x12DE998", VA="0x12DE998")]
			internal void <ReportProgress>b__0(Achievement[] ach)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E678", Offset="0x104E678")]
		private sealed class <>c__DisplayClass57_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<IAchievementDescription[]> callback;

			[Address(RVA="0x12DC390", Offset="0x12DC390", VA="0x12DC390")]
			public <>c__DisplayClass57_0()
			{
			}

			[Address(RVA="0x12DEF4C", Offset="0x12DEF4C", VA="0x12DEF4C")]
			internal void <LoadAchievementDescriptions>b__0(Achievement[] ach)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E688", Offset="0x104E688")]
		private sealed class <>c__DisplayClass58_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<IAchievement[]> callback;

			[Address(RVA="0x12DC530", Offset="0x12DC530", VA="0x12DC530")]
			public <>c__DisplayClass58_0()
			{
			}

			[Address(RVA="0x12DF0A4", Offset="0x12DF0A4", VA="0x12DF0A4")]
			internal void <LoadAchievements>b__0(Achievement[] ach)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E698", Offset="0x104E698")]
		private sealed class <>c__DisplayClass62_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<IScore[]> callback;

			[Address(RVA="0x12DCDB4", Offset="0x12DCDB4", VA="0x12DCDB4")]
			public <>c__DisplayClass62_0()
			{
			}

			[Address(RVA="0x12DF1FC", Offset="0x12DF1FC", VA="0x12DF1FC")]
			internal void <LoadScores>b__0(LeaderboardScoreData scoreData)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E6A8", Offset="0x104E6A8")]
		private sealed class <>c__DisplayClass74_0
		{
			[FieldOffset(Offset="0x10")]
			public PlayGamesPlatform <>4__this;

			[FieldOffset(Offset="0x18")]
			public ILeaderboard board;

			[FieldOffset(Offset="0x20")]
			public Action<bool> callback;

			[Address(RVA="0x12DD7B8", Offset="0x12DD7B8", VA="0x12DD7B8")]
			public <>c__DisplayClass74_0()
			{
			}

			[Address(RVA="0x12DF288", Offset="0x12DF288", VA="0x12DF288")]
			internal void <LoadScores>b__0(LeaderboardScoreData scoreData)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E6B8", Offset="0x104E6B8")]
		private sealed class <>c__DisplayClass81_0
		{
			[FieldOffset(Offset="0x10")]
			public PlayGamesPlatform <>4__this;

			[FieldOffset(Offset="0x18")]
			public PlayGamesLeaderboard board;

			[FieldOffset(Offset="0x20")]
			public Action<bool> callback;

			[Address(RVA="0x12DDFC8", Offset="0x12DDFC8", VA="0x12DDFC8")]
			public <>c__DisplayClass81_0()
			{
			}

			[Address(RVA="0x12DF38C", Offset="0x12DF38C", VA="0x12DF38C")]
			internal void <HandleLoadingScores>b__0(LeaderboardScoreData nextScoreData)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E6C8", Offset="0x104E6C8")]
		private sealed class <>c__DisplayClass84_0<T>
		{
			[FieldOffset(Offset="0x0")]
			public Action<T> toConvert;

			[Address(RVA="0x1D8F138", Offset="0x1D8F138", VA="0x1D8F138")]
			public <>c__DisplayClass84_0()
			{
			}

			[Address(RVA="0x1D8F164", Offset="0x1D8F164", VA="0x1D8F164")]
			internal void <ToOnGameThread>b__1(T val)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E6D8", Offset="0x104E6D8")]
		private sealed class <>c__DisplayClass84_1<T>
		{
			[FieldOffset(Offset="0x0")]
			public T val;

			[FieldOffset(Offset="0x0")]
			public PlayGamesPlatform.<>c__DisplayClass84_0<T> CS$<>8__locals1;

			[Address(RVA="0x1D8F3A4", Offset="0x1D8F3A4", VA="0x1D8F3A4")]
			public <>c__DisplayClass84_1()
			{
			}

			[Address(RVA="0x1D8F3D0", Offset="0x1D8F3D0", VA="0x1D8F3D0")]
			internal void <ToOnGameThread>b__2()
			{
			}
		}
	}
}