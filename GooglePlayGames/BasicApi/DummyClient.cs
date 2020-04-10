using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using Il2CppDummyDll;
using System;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.BasicApi
{
	public class DummyClient : IPlayGamesClient
	{
		[Address(RVA="0x1EC3C60", Offset="0x1EC3C60", VA="0x1EC3C60")]
		public DummyClient()
		{
		}

		[Address(RVA="0x1EC3180", Offset="0x1EC3180", VA="0x1EC3180", Slot="4")]
		public void Authenticate(bool silent, Action<SignInStatus> callback)
		{
		}

		[Address(RVA="0x1EC32EC", Offset="0x1EC32EC", VA="0x1EC32EC", Slot="12")]
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		[Address(RVA="0x1EC3B44", Offset="0x1EC3B44", VA="0x1EC3B44", Slot="34")]
		public IEventsClient GetEventsClient()
		{
			return null;
		}

		[Address(RVA="0x1EC3C0C", Offset="0x1EC3C0C", VA="0x1EC3C0C", Slot="37")]
		public IUserProfile[] GetFriends()
		{
			return null;
		}

		[Address(RVA="0x1EC3270", Offset="0x1EC3270", VA="0x1EC3270", Slot="10")]
		public string GetIdToken()
		{
			return null;
		}

		[Address(RVA="0x1EC3B78", Offset="0x1EC3B78", VA="0x1EC3B78")]
		public Invitation GetInvitationFromNotification()
		{
			return null;
		}

		[Address(RVA="0x1EC33A0", Offset="0x1EC33A0", VA="0x1EC33A0", Slot="15")]
		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		[Address(RVA="0x1EC3AFC", Offset="0x1EC3AFC", VA="0x1EC3AFC", Slot="31")]
		public IRealTimeMultiplayerClient GetRtmpClient()
		{
			return null;
		}

		[Address(RVA="0x1EC3B2C", Offset="0x1EC3B2C", VA="0x1EC3B2C", Slot="33")]
		public ISavedGameClient GetSavedGameClient()
		{
			return null;
		}

		[Address(RVA="0x1EC32D4", Offset="0x1EC32D4", VA="0x1EC32D4", Slot="11")]
		public string GetServerAuthCode()
		{
			return null;
		}

		[Address(RVA="0x1EC3B14", Offset="0x1EC3B14", VA="0x1EC3B14", Slot="32")]
		public ITurnBasedMultiplayerClient GetTbmpClient()
		{
			return null;
		}

		[Address(RVA="0x1EC3424", Offset="0x1EC3424", VA="0x1EC3424", Slot="9")]
		public string GetUserDisplayName()
		{
			return null;
		}

		[Address(RVA="0x1EC3350", Offset="0x1EC3350", VA="0x1EC3350", Slot="13")]
		public string GetUserEmail()
		{
			return null;
		}

		[Address(RVA="0x1EC3288", Offset="0x1EC3288", VA="0x1EC3288", Slot="7")]
		public string GetUserId()
		{
			return null;
		}

		[Address(RVA="0x1EC3470", Offset="0x1EC3470", VA="0x1EC3470", Slot="14")]
		public string GetUserImageUrl()
		{
			return null;
		}

		[Address(RVA="0x1EC3B5C", Offset="0x1EC3B5C", VA="0x1EC3B5C", Slot="35")]
		public IVideoClient GetVideoClient()
		{
			return null;
		}

		[Address(RVA="0x1EC3B90", Offset="0x1EC3B90", VA="0x1EC3B90")]
		public bool HasInvitationFromNotification()
		{
			return new bool();
		}

		[Address(RVA="0x1EC3AE4", Offset="0x1EC3AE4", VA="0x1EC3AE4", Slot="30")]
		public bool HasPermissions(string[] scopes)
		{
			return new bool();
		}

		[Address(RVA="0x1EC3628", Offset="0x1EC3628", VA="0x1EC3628", Slot="20")]
		public void IncrementAchievement(string achId, int steps, Action<bool> callback)
		{
		}

		[Address(RVA="0x1EC3254", Offset="0x1EC3254", VA="0x1EC3254", Slot="5")]
		public bool IsAuthenticated()
		{
			return new bool();
		}

		[Address(RVA="0x1EC37C8", Offset="0x1EC37C8", VA="0x1EC37C8", Slot="26")]
		public int LeaderboardMaxResults()
		{
			return new int();
		}

		[Address(RVA="0x1EC34F0", Offset="0x1EC34F0", VA="0x1EC34F0", Slot="17")]
		public void LoadAchievements(Action<Achievement[]> callback)
		{
		}

		[Address(RVA="0x1EC3BA8", Offset="0x1EC3BA8", VA="0x1EC3BA8", Slot="8")]
		public void LoadFriends(Action<bool> callback)
		{
		}

		[Address(RVA="0x1EC38F4", Offset="0x1EC38F4", VA="0x1EC38F4", Slot="25")]
		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
		}

		[Address(RVA="0x1EC37D0", Offset="0x1EC37D0", VA="0x1EC37D0", Slot="24")]
		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		[Address(RVA="0x1EC3488", Offset="0x1EC3488", VA="0x1EC3488", Slot="16")]
		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
		{
		}

		[Address(RVA="0x1EC31E8", Offset="0x1EC31E8", VA="0x1EC31E8")]
		private static void LogUsage()
		{
		}

		[Address(RVA="0x1EC3B74", Offset="0x1EC3B74", VA="0x1EC3B74", Slot="36")]
		public void RegisterInvitationDelegate(InvitationReceivedDelegate invitationDelegate)
		{
		}

		[Address(RVA="0x1EC3A7C", Offset="0x1EC3A7C", VA="0x1EC3A7C", Slot="29")]
		public void RequestPermissions(string[] scopes, Action<SignInStatus> callback)
		{
		}

		[Address(RVA="0x1EC35C0", Offset="0x1EC35C0", VA="0x1EC35C0", Slot="19")]
		public void RevealAchievement(string achId, Action<bool> callback)
		{
		}

		[Address(RVA="0x1EC3C5C", Offset="0x1EC3C5C", VA="0x1EC3C5C", Slot="38")]
		public void SetGravityForPopups(Gravity gravity)
		{
		}

		[Address(RVA="0x1EC3690", Offset="0x1EC3690", VA="0x1EC3690", Slot="21")]
		public void SetStepsAtLeast(string achId, int steps, Action<bool> callback)
		{
		}

		[Address(RVA="0x1EC36F8", Offset="0x1EC36F8", VA="0x1EC36F8", Slot="22")]
		public void ShowAchievementsUI(Action<UIStatus> callback)
		{
		}

		[Address(RVA="0x1EC3760", Offset="0x1EC3760", VA="0x1EC3760", Slot="23")]
		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback)
		{
		}

		[Address(RVA="0x1EC326C", Offset="0x1EC326C", VA="0x1EC326C", Slot="6")]
		public void SignOut()
		{
		}

		[Address(RVA="0x1EC39AC", Offset="0x1EC39AC", VA="0x1EC39AC", Slot="27")]
		public void SubmitScore(string leaderboardId, long score, Action<bool> callback)
		{
		}

		[Address(RVA="0x1EC3A14", Offset="0x1EC3A14", VA="0x1EC3A14", Slot="28")]
		public void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> callback)
		{
		}

		[Address(RVA="0x1EC3558", Offset="0x1EC3558", VA="0x1EC3558", Slot="18")]
		public void UnlockAchievement(string achId, Action<bool> callback)
		{
		}
	}
}