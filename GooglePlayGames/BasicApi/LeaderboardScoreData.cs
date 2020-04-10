using GooglePlayGames;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.BasicApi
{
	public class LeaderboardScoreData
	{
		[FieldOffset(Offset="0x10")]
		private string mId;

		[FieldOffset(Offset="0x18")]
		private ResponseStatus mStatus;

		[FieldOffset(Offset="0x20")]
		private ulong mApproxCount;

		[FieldOffset(Offset="0x28")]
		private string mTitle;

		[FieldOffset(Offset="0x30")]
		private IScore mPlayerScore;

		[FieldOffset(Offset="0x38")]
		private ScorePageToken mPrevPage;

		[FieldOffset(Offset="0x40")]
		private ScorePageToken mNextPage;

		[FieldOffset(Offset="0x48")]
		private List<PlayGamesScore> mScores;

		public ulong ApproximateCount
		{
			[Address(RVA="0x1EC45E0", Offset="0x1EC45E0", VA="0x1EC45E0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EC45E8", Offset="0x1EC45E8", VA="0x1EC45E8")]
			internal set
			{
			}
		}

		public string Id
		{
			[Address(RVA="0x1EC4600", Offset="0x1EC4600", VA="0x1EC4600")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EC4608", Offset="0x1EC4608", VA="0x1EC4608")]
			internal set
			{
			}
		}

		public ScorePageToken NextPageToken
		{
			[Address(RVA="0x1EC4724", Offset="0x1EC4724", VA="0x1EC4724")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EC472C", Offset="0x1EC472C", VA="0x1EC472C")]
			internal set
			{
			}
		}

		public IScore PlayerScore
		{
			[Address(RVA="0x1EC4610", Offset="0x1EC4610", VA="0x1EC4610")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EC4618", Offset="0x1EC4618", VA="0x1EC4618")]
			internal set
			{
			}
		}

		public ScorePageToken PrevPageToken
		{
			[Address(RVA="0x1EC4714", Offset="0x1EC4714", VA="0x1EC4714")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EC471C", Offset="0x1EC471C", VA="0x1EC471C")]
			internal set
			{
			}
		}

		public IScore[] Scores
		{
			[Address(RVA="0x1EC4620", Offset="0x1EC4620", VA="0x1EC4620")]
			get
			{
				return null;
			}
		}

		public ResponseStatus Status
		{
			[Address(RVA="0x1EC45D0", Offset="0x1EC45D0", VA="0x1EC45D0")]
			get
			{
				return new ResponseStatus();
			}
			[Address(RVA="0x1EC45D8", Offset="0x1EC45D8", VA="0x1EC45D8")]
			internal set
			{
			}
		}

		public string Title
		{
			[Address(RVA="0x1EC45F0", Offset="0x1EC45F0", VA="0x1EC45F0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EC45F8", Offset="0x1EC45F8", VA="0x1EC45F8")]
			internal set
			{
			}
		}

		public bool Valid
		{
			[Address(RVA="0x1EC45BC", Offset="0x1EC45BC", VA="0x1EC45BC")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x1EC4538", Offset="0x1EC4538", VA="0x1EC4538")]
		internal LeaderboardScoreData(string leaderboardId)
		{
		}

		[Address(RVA="0x1EC3868", Offset="0x1EC3868", VA="0x1EC3868")]
		internal LeaderboardScoreData(string leaderboardId, ResponseStatus status)
		{
		}

		[Address(RVA="0x1EC4680", Offset="0x1EC4680", VA="0x1EC4680")]
		internal int AddScore(PlayGamesScore score)
		{
			return new int();
		}

		[Address(RVA="0x1EC4734", Offset="0x1EC4734", VA="0x1EC4734", Slot="3")]
		public override string ToString()
		{
			return null;
		}
	}
}