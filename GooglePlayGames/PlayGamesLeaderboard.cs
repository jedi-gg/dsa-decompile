using GooglePlayGames.BasicApi;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	public class PlayGamesLeaderboard : ILeaderboard
	{
		[FieldOffset(Offset="0x10")]
		private string mId;

		[FieldOffset(Offset="0x18")]
		private UserScope mUserScope;

		[FieldOffset(Offset="0x1C")]
		private Range mRange;

		[FieldOffset(Offset="0x24")]
		private TimeScope mTimeScope;

		[FieldOffset(Offset="0x28")]
		private string[] mFilteredUserIds;

		[FieldOffset(Offset="0x30")]
		private bool mLoading;

		[FieldOffset(Offset="0x38")]
		private IScore mLocalUserScore;

		[FieldOffset(Offset="0x40")]
		private uint mMaxRange;

		[FieldOffset(Offset="0x48")]
		private List<PlayGamesScore> mScoreList;

		[FieldOffset(Offset="0x50")]
		private string mTitle;

		public string id
		{
			[Address(RVA="0x12D8114", Offset="0x12D8114", VA="0x12D8114", Slot="5")]
			get
			{
				return null;
			}
			[Address(RVA="0x12D811C", Offset="0x12D811C", VA="0x12D811C", Slot="11")]
			set
			{
			}
		}

		public bool loading
		{
			[Address(RVA="0x12D8100", Offset="0x12D8100", VA="0x12D8100", Slot="4")]
			get
			{
				return JustDecompileGenerated_get_loading();
			}
			[Address(RVA="0x12D8108", Offset="0x12D8108", VA="0x12D8108")]
			set
			{
				JustDecompileGenerated_set_loading(value);
			}
		}

		public bool JustDecompileGenerated_get_loading()
		{
			return new bool();
		}

		internal void JustDecompileGenerated_set_loading(bool value)
		{
		}

		public IScore localUserScore
		{
			[Address(RVA="0x12D8154", Offset="0x12D8154", VA="0x12D8154", Slot="15")]
			get
			{
				return null;
			}
		}

		public uint maxRange
		{
			[Address(RVA="0x12D815C", Offset="0x12D815C", VA="0x12D815C", Slot="16")]
			get
			{
				return new uint();
			}
		}

		public Range range
		{
			[Address(RVA="0x12D8134", Offset="0x12D8134", VA="0x12D8134", Slot="7")]
			get
			{
				return new Range();
			}
			[Address(RVA="0x12D813C", Offset="0x12D813C", VA="0x12D813C", Slot="13")]
			set
			{
			}
		}

		public int ScoreCount
		{
			[Address(RVA="0x12D8708", Offset="0x12D8708", VA="0x12D8708")]
			get
			{
				return new int();
			}
		}

		public IScore[] scores
		{
			[Address(RVA="0x12D8164", Offset="0x12D8164", VA="0x12D8164", Slot="17")]
			get
			{
				return null;
			}
		}

		public TimeScope timeScope
		{
			[Address(RVA="0x12D8144", Offset="0x12D8144", VA="0x12D8144", Slot="8")]
			get
			{
				return new TimeScope();
			}
			[Address(RVA="0x12D814C", Offset="0x12D814C", VA="0x12D814C", Slot="14")]
			set
			{
			}
		}

		public string title
		{
			[Address(RVA="0x12D8210", Offset="0x12D8210", VA="0x12D8210", Slot="18")]
			get
			{
				return null;
			}
		}

		public UserScope userScope
		{
			[Address(RVA="0x12D8124", Offset="0x12D8124", VA="0x12D8124", Slot="6")]
			get
			{
				return new UserScope();
			}
			[Address(RVA="0x12D812C", Offset="0x12D812C", VA="0x12D812C", Slot="12")]
			set
			{
			}
		}

		[Address(RVA="0x12D77E0", Offset="0x12D77E0", VA="0x12D77E0")]
		public PlayGamesLeaderboard(string id)
		{
		}

		[Address(RVA="0x12D8538", Offset="0x12D8538", VA="0x12D8538")]
		internal int AddScore(PlayGamesScore score)
		{
			return new int();
		}

		[Address(RVA="0x12D8654", Offset="0x12D8654", VA="0x12D8654")]
		internal bool HasAllScores()
		{
			return new bool();
		}

		[Address(RVA="0x12D786C", Offset="0x12D786C", VA="0x12D786C", Slot="10")]
		public void LoadScores(Action<bool> callback)
		{
		}

		[Address(RVA="0x12D8218", Offset="0x12D8218", VA="0x12D8218")]
		internal bool SetFromData(LeaderboardScoreData data)
		{
			return new bool();
		}

		[Address(RVA="0x12D8530", Offset="0x12D8530", VA="0x12D8530")]
		internal void SetLocalUserScore(PlayGamesScore score)
		{
		}

		[Address(RVA="0x12D8520", Offset="0x12D8520", VA="0x12D8520")]
		internal void SetMaxRange(ulong val)
		{
		}

		[Address(RVA="0x12D8528", Offset="0x12D8528", VA="0x12D8528")]
		internal void SetTitle(string value)
		{
		}

		[Address(RVA="0x12D7864", Offset="0x12D7864", VA="0x12D7864", Slot="9")]
		public void SetUserFilter(string[] userIDs)
		{
		}
	}
}