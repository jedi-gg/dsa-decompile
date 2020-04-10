using Il2CppDummyDll;
using System;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	public class PlayGamesScore : IScore
	{
		[FieldOffset(Offset="0x10")]
		private string mLbId;

		[FieldOffset(Offset="0x18")]
		private long mValue;

		[FieldOffset(Offset="0x20")]
		private ulong mRank;

		[FieldOffset(Offset="0x28")]
		private string mPlayerId;

		[FieldOffset(Offset="0x30")]
		private string mMetadata;

		[FieldOffset(Offset="0x38")]
		private DateTime mDate;

		public DateTime date
		{
			[Address(RVA="0x12DF56C", Offset="0x12DF56C", VA="0x12DF56C", Slot="9")]
			get
			{
				return new DateTime();
			}
		}

		public string formattedValue
		{
			[Address(RVA="0x12DF574", Offset="0x12DF574", VA="0x12DF574", Slot="10")]
			get
			{
				return null;
			}
		}

		public string leaderboardID
		{
			[Address(RVA="0x12DF4AC", Offset="0x12DF4AC", VA="0x12DF4AC", Slot="5")]
			get
			{
				return null;
			}
			[Address(RVA="0x12DF554", Offset="0x12DF554", VA="0x12DF554", Slot="6")]
			set
			{
			}
		}

		public string metaData
		{
			[Address(RVA="0x12DF588", Offset="0x12DF588", VA="0x12DF588")]
			get
			{
				return null;
			}
		}

		public int rank
		{
			[Address(RVA="0x12DF580", Offset="0x12DF580", VA="0x12DF580", Slot="12")]
			get
			{
				return new int();
			}
		}

		public string userID
		{
			[Address(RVA="0x12D8700", Offset="0x12D8700", VA="0x12D8700", Slot="11")]
			get
			{
				return null;
			}
		}

		public long @value
		{
			[Address(RVA="0x12DF55C", Offset="0x12DF55C", VA="0x12DF55C", Slot="7")]
			get
			{
				return new long();
			}
			[Address(RVA="0x12DF564", Offset="0x12DF564", VA="0x12DF564", Slot="8")]
			set
			{
			}
		}

		[Address(RVA="0x12DF3D4", Offset="0x12DF3D4", VA="0x12DF3D4")]
		internal PlayGamesScore(DateTime date, string leaderboardId, ulong rank, string playerId, ulong value, string metadata)
		{
		}

		[Address(RVA="0x12DF4B4", Offset="0x12DF4B4", VA="0x12DF4B4", Slot="4")]
		public void ReportScore(Action<bool> callback)
		{
		}
	}
}