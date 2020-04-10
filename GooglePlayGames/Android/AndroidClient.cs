using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.Android
{
	public class AndroidClient : IPlayGamesClient
	{
		[FieldOffset(Offset="0x10")]
		private readonly object GameServicesLock;

		[FieldOffset(Offset="0x18")]
		private readonly object AuthStateLock;

		[FieldOffset(Offset="0x20")]
		private readonly PlayGamesClientConfiguration mConfiguration;

		[FieldOffset(Offset="0x50")]
		private AndroidTurnBasedMultiplayerClient mTurnBasedClient;

		[FieldOffset(Offset="0x58")]
		private IRealTimeMultiplayerClient mRealTimeClient;

		[FieldOffset(Offset="0x60")]
		private ISavedGameClient mSavedGameClient;

		[FieldOffset(Offset="0x68")]
		private IEventsClient mEventsClient;

		[FieldOffset(Offset="0x70")]
		private IVideoClient mVideoClient;

		[FieldOffset(Offset="0x78")]
		private AndroidTokenClient mTokenClient;

		[FieldOffset(Offset="0x80")]
		private Action<Invitation, bool> mInvitationDelegate;

		[FieldOffset(Offset="0x88")]
		private Player mUser;

		[FieldOffset(Offset="0x90")]
		private AndroidClient.AuthState mAuthState;

		[FieldOffset(Offset="0x98")]
		private AndroidJavaClass mGamesClass;

		[FieldOffset(Offset="0x0")]
		private static string TasksClassName;

		[FieldOffset(Offset="0xA0")]
		private AndroidJavaObject mInvitationCallback;

		[FieldOffset(Offset="0xA8")]
		private readonly int mLeaderboardMaxResults;

		[Address(RVA="0x1622924", Offset="0x1622924", VA="0x1622924")]
		static AndroidClient()
		{
		}

		[Address(RVA="0x161B62C", Offset="0x161B62C", VA="0x161B62C")]
		internal AndroidClient(PlayGamesClientConfiguration configuration)
		{
		}

		[Address(RVA="0x1F5BC68", Offset="0x1F5BC68", VA="0x1F5BC68")]
		private static Action<T> AsOnGameThreadCallback<T>(Action<T> callback)
		{
			return null;
		}

		[Address(RVA="0x1F5C900", Offset="0x1F5C900", VA="0x1F5C900")]
		private static Action<T1, T2> AsOnGameThreadCallback<T1, T2>(Action<T1, T2> toInvokeOnGameThread)
		{
			return null;
		}

		[Address(RVA="0x161B8A4", Offset="0x161B8A4", VA="0x161B8A4", Slot="4")]
		public void Authenticate(bool silent, Action<SignInStatus> callback)
		{
		}

		[Address(RVA="0x16204BC", Offset="0x16204BC", VA="0x16204BC")]
		private LeaderboardScoreData CreateLeaderboardScoreData(string leaderboardId, LeaderboardCollection collection, LeaderboardTimeSpan timespan, ResponseStatus status, AndroidJavaObject leaderboardScoresJava)
		{
			return null;
		}

		[Address(RVA="0x161DF54", Offset="0x161DF54", VA="0x161DF54")]
		private AndroidJavaObject getAchievementsClient()
		{
			return null;
		}

		[Address(RVA="0x161C2B4", Offset="0x161C2B4", VA="0x161C2B4", Slot="12")]
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		[Address(RVA="0x1622508", Offset="0x1622508", VA="0x1622508", Slot="34")]
		public IEventsClient GetEventsClient()
		{
			return null;
		}

		[Address(RVA="0x161C454", Offset="0x161C454", VA="0x161C454", Slot="37")]
		public IUserProfile[] GetFriends()
		{
			return null;
		}

		[Address(RVA="0x161CD6C", Offset="0x161CD6C", VA="0x161CD6C")]
		private AndroidJavaObject getGamesClient()
		{
			return null;
		}

		[Address(RVA="0x161C15C", Offset="0x161C15C", VA="0x161C15C", Slot="10")]
		public string GetIdToken()
		{
			return null;
		}

		[Address(RVA="0x161C880", Offset="0x161C880", VA="0x161C880")]
		private AndroidJavaObject getInvitationsClient()
		{
			return null;
		}

		[Address(RVA="0x161FE38", Offset="0x161FE38", VA="0x161FE38")]
		private AndroidJavaObject getLeaderboardsClient()
		{
			return null;
		}

		[Address(RVA="0x161DA58", Offset="0x161DA58", VA="0x161DA58")]
		private AndroidJavaObject getPlayersClient()
		{
			return null;
		}

		[Address(RVA="0x161CEC8", Offset="0x161CEC8", VA="0x161CEC8", Slot="15")]
		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		[Address(RVA="0x161D258", Offset="0x161D258", VA="0x161D258")]
		private AndroidJavaObject getPlayerStatsClient()
		{
			return null;
		}

		[Address(RVA="0x16222E4", Offset="0x16222E4", VA="0x16222E4", Slot="31")]
		public IRealTimeMultiplayerClient GetRtmpClient()
		{
			return null;
		}

		[Address(RVA="0x1622458", Offset="0x1622458", VA="0x1622458", Slot="33")]
		public ISavedGameClient GetSavedGameClient()
		{
			return null;
		}

		[Address(RVA="0x161C208", Offset="0x161C208", VA="0x161C208", Slot="11")]
		public string GetServerAuthCode()
		{
			return null;
		}

		[Address(RVA="0x16223A8", Offset="0x16223A8", VA="0x16223A8", Slot="32")]
		public ITurnBasedMultiplayerClient GetTbmpClient()
		{
			return null;
		}

		[Address(RVA="0x161EB38", Offset="0x161EB38", VA="0x161EB38")]
		private Action<UIStatus> GetUiSignOutCallbackOnGameThread(Action<UIStatus> callback)
		{
			return null;
		}

		[Address(RVA="0x161CA30", Offset="0x161CA30", VA="0x161CA30", Slot="9")]
		public string GetUserDisplayName()
		{
			return null;
		}

		[Address(RVA="0x161BFF8", Offset="0x161BFF8", VA="0x161BFF8", Slot="13")]
		public string GetUserEmail()
		{
			return null;
		}

		[Address(RVA="0x161C9DC", Offset="0x161C9DC", VA="0x161C9DC", Slot="7")]
		public string GetUserId()
		{
			return null;
		}

		[Address(RVA="0x161CA84", Offset="0x161CA84", VA="0x161CA84", Slot="14")]
		public string GetUserImageUrl()
		{
			return null;
		}

		[Address(RVA="0x16225B8", Offset="0x16225B8", VA="0x16225B8", Slot="35")]
		public IVideoClient GetVideoClient()
		{
			return null;
		}

		[Address(RVA="0x16227C8", Offset="0x16227C8", VA="0x16227C8")]
		private AndroidJavaObject getVideosClient()
		{
			return null;
		}

		[Address(RVA="0x16222A8", Offset="0x16222A8", VA="0x16222A8", Slot="30")]
		public bool HasPermissions(string[] scopes)
		{
			return new bool();
		}

		[Address(RVA="0x161E530", Offset="0x161E530", VA="0x161E530", Slot="20")]
		public void IncrementAchievement(string achId, int steps, Action<bool> callback)
		{
		}

		[Address(RVA="0x161BFC0", Offset="0x161BFC0", VA="0x161BFC0")]
		private void InitializeGameServices()
		{
		}

		[Address(RVA="0x161BB28", Offset="0x161BB28", VA="0x161BB28")]
		private void InitializeTokenClient()
		{
		}

		[Address(RVA="0x1388634", Offset="0x1388634", VA="0x1388634")]
		private static void InvokeCallbackOnGameThread<T>(Action<T> callback, T data)
		{
		}

		[Address(RVA="0x1388278", Offset="0x1388278", VA="0x1388278")]
		private static void InvokeCallbackOnGameThread<T1, T2>(Action<T1, T2> callback, T1 t1, T2 t2)
		{
		}

		[Address(RVA="0x161C0A4", Offset="0x161C0A4", VA="0x161C0A4", Slot="5")]
		public bool IsAuthenticated()
		{
			return new bool();
		}

		[Address(RVA="0x161EFC0", Offset="0x161EFC0", VA="0x161EFC0", Slot="26")]
		public int LeaderboardMaxResults()
		{
			return new int();
		}

		[Address(RVA="0x161DBC4", Offset="0x161DBC4", VA="0x161DBC4", Slot="17")]
		public void LoadAchievements(Action<Achievement[]> callback)
		{
		}

		[Address(RVA="0x161C360", Offset="0x161C360", VA="0x161C360", Slot="8")]
		public void LoadFriends(Action<bool> callback)
		{
		}

		[Address(RVA="0x161FFD0", Offset="0x161FFD0", VA="0x161FFD0", Slot="25")]
		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
		}

		[Address(RVA="0x161F8C8", Offset="0x161F8C8", VA="0x161F8C8", Slot="24")]
		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		[Address(RVA="0x161D3B4", Offset="0x161D3B4", VA="0x161D3B4", Slot="16")]
		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
		{
		}

		[Address(RVA="0x161B790", Offset="0x161B790", VA="0x161B790", Slot="36")]
		public void RegisterInvitationDelegate(InvitationReceivedDelegate invitationDelegate)
		{
		}

		[Address(RVA="0x162189C", Offset="0x162189C", VA="0x162189C", Slot="29")]
		public void RequestPermissions(string[] scopes, Action<SignInStatus> callback)
		{
		}

		[Address(RVA="0x161E2F0", Offset="0x161E2F0", VA="0x161E2F0", Slot="19")]
		public void RevealAchievement(string achId, Action<bool> callback)
		{
		}

		[Address(RVA="0x161CAD8", Offset="0x161CAD8", VA="0x161CAD8", Slot="38")]
		public void SetGravityForPopups(Gravity gravity)
		{
		}

		[Address(RVA="0x161E7E0", Offset="0x161E7E0", VA="0x161E7E0", Slot="21")]
		public void SetStepsAtLeast(string achId, int steps, Action<bool> callback)
		{
		}

		[Address(RVA="0x161EA90", Offset="0x161EA90", VA="0x161EA90", Slot="22")]
		public void ShowAchievementsUI(Action<UIStatus> callback)
		{
		}

		[Address(RVA="0x161EFC8", Offset="0x161EFC8", VA="0x161EFC8", Slot="23")]
		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback)
		{
		}

		[Address(RVA="0x161C4A0", Offset="0x161C4A0", VA="0x161C4A0", Slot="6")]
		public void SignOut()
		{
		}

		[Address(RVA="0x161C4A8", Offset="0x161C4A8", VA="0x161C4A8")]
		public void SignOut(Action uiCallback)
		{
		}

		[Address(RVA="0x1621304", Offset="0x1621304", VA="0x1621304", Slot="27")]
		public void SubmitScore(string leaderboardId, long score, Action<bool> callback)
		{
		}

		[Address(RVA="0x16215A4", Offset="0x16215A4", VA="0x16215A4", Slot="28")]
		public void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> callback)
		{
		}

		[Address(RVA="0x161E0B0", Offset="0x161E0B0", VA="0x161E0B0", Slot="18")]
		public void UnlockAchievement(string achId, Action<bool> callback)
		{
		}

		[Address(RVA="0x16219F8", Offset="0x16219F8", VA="0x16219F8")]
		private void UpdateClients()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E728", Offset="0x104E728")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AndroidClient.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Action<Achievement[]> <>9__18_2;

			[Address(RVA="0x1622980", Offset="0x1622980", VA="0x1622980")]
			static <>c()
			{
			}

			[Address(RVA="0x16229E4", Offset="0x16229E4", VA="0x16229E4")]
			public <>c()
			{
			}

			[Address(RVA="0x16229EC", Offset="0x16229EC", VA="0x16229EC")]
			internal void <Authenticate>b__18_2(Achievement[] ignore)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E748", Offset="0x104E748")]
		[Serializable]
		private sealed class <>c__19<T>
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AndroidClient.<>c__19<T> <>9;

			[FieldOffset(Offset="0x0")]
			public static Action<T> <>9__19_0;

			[Address(RVA="0x1D8B948", Offset="0x1D8B948", VA="0x1D8B948")]
			static <>c__19()
			{
			}

			[Address(RVA="0x1D8BA20", Offset="0x1D8BA20", VA="0x1D8BA20")]
			public <>c__19()
			{
			}

			[Address(RVA="0x1D8BA4C", Offset="0x1D8BA4C", VA="0x1D8BA4C")]
			internal void <AsOnGameThreadCallback>b__19_0(T u003cp0u003e)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E708", Offset="0x104E708")]
		private sealed class <>c__DisplayClass18_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidClient <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action<SignInStatus> callback;

			[Address(RVA="0x161BB20", Offset="0x161BB20", VA="0x161BB20")]
			public <>c__DisplayClass18_0()
			{
			}

			[Address(RVA="0x16229F0", Offset="0x16229F0", VA="0x16229F0")]
			internal void <Authenticate>b__0(int result)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E718", Offset="0x104E718")]
		private sealed class <>c__DisplayClass18_1
		{
			[FieldOffset(Offset="0x10")]
			public AndroidJavaObject taskGetPlayer;

			[FieldOffset(Offset="0x18")]
			public AndroidJavaObject taskIsCaptureSupported;

			[FieldOffset(Offset="0x20")]
			public AndroidJavaObject taskGetActivationHint;

			[FieldOffset(Offset="0x28")]
			public AndroidClient.<>c__DisplayClass18_0 CS$<>8__locals1;

			[Address(RVA="0x1623AB0", Offset="0x1623AB0", VA="0x1623AB0")]
			public <>c__DisplayClass18_1()
			{
			}

			[Address(RVA="0x1623DE0", Offset="0x1623DE0", VA="0x1623DE0")]
			internal void <Authenticate>b__1(AndroidJavaObject completeTask)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E738", Offset="0x104E738")]
		private sealed class <>c__DisplayClass19_0<T>
		{
			[FieldOffset(Offset="0x0")]
			public Action<T> callback;

			[Address(RVA="0x1D8BB58", Offset="0x1D8BB58", VA="0x1D8BB58")]
			public <>c__DisplayClass19_0()
			{
			}

			[Address(RVA="0x1D8BB84", Offset="0x1D8BB84", VA="0x1D8BB84")]
			internal void <AsOnGameThreadCallback>b__1(T result)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E758", Offset="0x104E758")]
		private sealed class <>c__DisplayClass20_0<T>
		{
			[FieldOffset(Offset="0x0")]
			public Action<T> callback;

			[FieldOffset(Offset="0x0")]
			public T data;

			[Address(RVA="0x1D8BCC8", Offset="0x1D8BCC8", VA="0x1D8BCC8")]
			public <>c__DisplayClass20_0()
			{
			}

			[Address(RVA="0x1D8BCF4", Offset="0x1D8BCF4", VA="0x1D8BCF4")]
			internal void <InvokeCallbackOnGameThread>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E768", Offset="0x104E768")]
		private sealed class <>c__DisplayClass21_0<T1, T2>
		{
			[FieldOffset(Offset="0x0")]
			public Action<T1, T2> toInvokeOnGameThread;

			[Address(RVA="0x1D8BF54", Offset="0x1D8BF54", VA="0x1D8BF54")]
			public <>c__DisplayClass21_0()
			{
			}

			[Address(RVA="0x1D8BF80", Offset="0x1D8BF80", VA="0x1D8BF80")]
			internal void <AsOnGameThreadCallback>b__0(T1 result1, T2 result2)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E778", Offset="0x104E778")]
		private sealed class <>c__DisplayClass21_1<T1, T2>
		{
			[FieldOffset(Offset="0x0")]
			public T1 result1;

			[FieldOffset(Offset="0x0")]
			public T2 result2;

			[FieldOffset(Offset="0x0")]
			public AndroidClient.<>c__DisplayClass21_0<T1, T2> CS$<>8__locals1;

			[Address(RVA="0x1D8C238", Offset="0x1D8C238", VA="0x1D8C238")]
			public <>c__DisplayClass21_1()
			{
			}

			[Address(RVA="0x1D8C264", Offset="0x1D8C264", VA="0x1D8C264")]
			internal void <AsOnGameThreadCallback>b__1()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E788", Offset="0x104E788")]
		private sealed class <>c__DisplayClass22_0<T1, T2>
		{
			[FieldOffset(Offset="0x0")]
			public Action<T1, T2> callback;

			[FieldOffset(Offset="0x0")]
			public T1 t1;

			[FieldOffset(Offset="0x0")]
			public T2 t2;

			[Address(RVA="0x1D8C36C", Offset="0x1D8C36C", VA="0x1D8C36C")]
			public <>c__DisplayClass22_0()
			{
			}

			[Address(RVA="0x1D8C398", Offset="0x1D8C398", VA="0x1D8C398")]
			internal void <InvokeCallbackOnGameThread>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E798", Offset="0x104E798")]
		private sealed class <>c__DisplayClass33_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidClient <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action uiCallback;

			[Address(RVA="0x161C878", Offset="0x161C878", VA="0x161C878")]
			public <>c__DisplayClass33_0()
			{
			}

			[Address(RVA="0x1625794", Offset="0x1625794", VA="0x1625794")]
			internal void <SignOut>b__0(AndroidJavaObject completedTask)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E7A8", Offset="0x104E7A8")]
		private sealed class <>c__DisplayClass38_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<CommonStatusCodes, PlayerStats> callback;

			[Address(RVA="0x161D250", Offset="0x161D250", VA="0x161D250")]
			public <>c__DisplayClass38_0()
			{
			}

			[Address(RVA="0x1625824", Offset="0x1625824", VA="0x1625824")]
			internal void <GetPlayerStats>b__0(AndroidJavaObject annotatedData)
			{
			}

			[Address(RVA="0x1625CE4", Offset="0x1625CE4", VA="0x1625CE4")]
			internal void <GetPlayerStats>b__1(AndroidJavaObject e)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E7B8", Offset="0x104E7B8")]
		private sealed class <>c__DisplayClass39_0
		{
			[FieldOffset(Offset="0x10")]
			public string[] userIds;

			[FieldOffset(Offset="0x18")]
			public Action<IUserProfile[]> callback;

			[Address(RVA="0x161DA50", Offset="0x161DA50", VA="0x161DA50")]
			public <>c__DisplayClass39_0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E7C8", Offset="0x104E7C8")]
		private sealed class <>c__DisplayClass39_1
		{
			[FieldOffset(Offset="0x10")]
			public IUserProfile[] users;

			[FieldOffset(Offset="0x18")]
			public int count;

			[FieldOffset(Offset="0x20")]
			public object countLock;

			[FieldOffset(Offset="0x28")]
			public int resultCount;

			[FieldOffset(Offset="0x30")]
			public AndroidClient.<>c__DisplayClass39_0 CS$<>8__locals1;

			[FieldOffset(Offset="0x38")]
			public Action<AndroidJavaObject> <>9__0;

			[Address(RVA="0x161DBB4", Offset="0x161DBB4", VA="0x161DBB4")]
			public <>c__DisplayClass39_1()
			{
			}

			[Address(RVA="0x1625DB0", Offset="0x1625DB0", VA="0x1625DB0")]
			internal void <LoadUsers>b__0(AndroidJavaObject annotatedData)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E7D8", Offset="0x104E7D8")]
		private sealed class <>c__DisplayClass39_2
		{
			[FieldOffset(Offset="0x10")]
			public int i;

			[FieldOffset(Offset="0x18")]
			public AndroidClient.<>c__DisplayClass39_1 CS$<>8__locals2;

			[Address(RVA="0x161DBBC", Offset="0x161DBBC", VA="0x161DBBC")]
			public <>c__DisplayClass39_2()
			{
			}

			[Address(RVA="0x1626144", Offset="0x1626144", VA="0x1626144")]
			internal void <LoadUsers>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E7E8", Offset="0x104E7E8")]
		private sealed class <>c__DisplayClass40_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<Achievement[]> callback;

			[Address(RVA="0x161DF4C", Offset="0x161DF4C", VA="0x161DF4C")]
			public <>c__DisplayClass40_0()
			{
			}

			[Address(RVA="0x162639C", Offset="0x162639C", VA="0x162639C")]
			internal void <LoadAchievements>b__0(AndroidJavaObject annotatedData)
			{
			}

			[Address(RVA="0x1626D8C", Offset="0x1626D8C", VA="0x1626D8C")]
			internal void <LoadAchievements>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E7F8", Offset="0x104E7F8")]
		private sealed class <>c__DisplayClass48_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidClient <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action<UIStatus> callback;

			[Address(RVA="0x161F8C0", Offset="0x161F8C0", VA="0x161F8C0")]
			public <>c__DisplayClass48_0()
			{
			}

			[Address(RVA="0x1626E54", Offset="0x1626E54", VA="0x1626E54")]
			internal void <GetUiSignOutCallbackOnGameThread>b__0(UIStatus status)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E808", Offset="0x104E808")]
		private sealed class <>c__DisplayClass48_1
		{
			[FieldOffset(Offset="0x10")]
			public UIStatus status;

			[FieldOffset(Offset="0x18")]
			public AndroidClient.<>c__DisplayClass48_0 CS$<>8__locals1;

			[Address(RVA="0x1626F94", Offset="0x1626F94", VA="0x1626F94")]
			public <>c__DisplayClass48_1()
			{
			}

			[Address(RVA="0x1626F9C", Offset="0x1626F9C", VA="0x1626F9C")]
			internal void <GetUiSignOutCallbackOnGameThread>b__1()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E818", Offset="0x104E818")]
		private sealed class <>c__DisplayClass49_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<LeaderboardScoreData> callback;

			[FieldOffset(Offset="0x18")]
			public AndroidClient <>4__this;

			[FieldOffset(Offset="0x20")]
			public string leaderboardId;

			[FieldOffset(Offset="0x28")]
			public LeaderboardCollection collection;

			[FieldOffset(Offset="0x2C")]
			public LeaderboardTimeSpan timeSpan;

			[Address(RVA="0x161FE30", Offset="0x161FE30", VA="0x161FE30")]
			public <>c__DisplayClass49_0()
			{
			}

			[Address(RVA="0x1627038", Offset="0x1627038", VA="0x1627038")]
			internal void <LoadScores>b__0(AndroidJavaObject annotatedData)
			{
			}

			[Address(RVA="0x16272B4", Offset="0x16272B4", VA="0x16272B4")]
			internal void <LoadScores>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E828", Offset="0x104E828")]
		private sealed class <>c__DisplayClass50_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<LeaderboardScoreData> callback;

			[FieldOffset(Offset="0x18")]
			public AndroidClient <>4__this;

			[FieldOffset(Offset="0x20")]
			public ScorePageToken token;

			[Address(RVA="0x1620494", Offset="0x1620494", VA="0x1620494")]
			public <>c__DisplayClass50_0()
			{
			}

			[Address(RVA="0x1627390", Offset="0x1627390", VA="0x1627390")]
			internal void <LoadMoreScores>b__0(AndroidJavaObject annotatedData)
			{
			}

			[Address(RVA="0x162766C", Offset="0x162766C", VA="0x162766C")]
			internal void <LoadMoreScores>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E838", Offset="0x104E838")]
		private sealed class <>c__DisplayClass54_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidClient <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action<SignInStatus> callback;

			[Address(RVA="0x16219F0", Offset="0x16219F0", VA="0x16219F0")]
			public <>c__DisplayClass54_0()
			{
			}

			[Address(RVA="0x1627768", Offset="0x1627768", VA="0x1627768")]
			internal void <RequestPermissions>b__0(SignInStatus code)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E848", Offset="0x104E848")]
		private sealed class <>c__DisplayClass62_0
		{
			[FieldOffset(Offset="0x10")]
			public InvitationReceivedDelegate invitationDelegate;

			[Address(RVA="0x1622668", Offset="0x1622668", VA="0x1622668")]
			public <>c__DisplayClass62_0()
			{
			}

			[Address(RVA="0x16277F0", Offset="0x16277F0", VA="0x16277F0")]
			internal void <RegisterInvitationDelegate>b__0(Invitation invitation, bool autoAccept)
			{
			}
		}

		private enum AuthState
		{
			[FieldOffset(Offset="0x0")]
			Unauthenticated,
			[FieldOffset(Offset="0x0")]
			Authenticated
		}

		private class InvitationCallbackProxy : AndroidJavaProxy
		{
			[FieldOffset(Offset="0x20")]
			private Action<Invitation, bool> mInvitationDelegate;

			[Address(RVA="0x1623AB8", Offset="0x1623AB8", VA="0x1623AB8")]
			public InvitationCallbackProxy(Action<Invitation, bool> invitationDelegate)
			{
			}

			[Address(RVA="0x1627838", Offset="0x1627838", VA="0x1627838")]
			public void onInvitationReceived(AndroidJavaObject invitation)
			{
			}

			[Address(RVA="0x16278B8", Offset="0x16278B8", VA="0x16278B8")]
			public void onInvitationRemoved(string invitationId)
			{
			}
		}
	}
}