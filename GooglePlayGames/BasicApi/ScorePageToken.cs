using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi
{
	public class ScorePageToken
	{
		[FieldOffset(Offset="0x10")]
		private string mId;

		[FieldOffset(Offset="0x18")]
		private object mInternalObject;

		[FieldOffset(Offset="0x20")]
		private LeaderboardCollection mCollection;

		[FieldOffset(Offset="0x24")]
		private LeaderboardTimeSpan mTimespan;

		[FieldOffset(Offset="0x28")]
		private ScorePageDirection mDirection;

		public LeaderboardCollection Collection
		{
			[Address(RVA="0x12D2A28", Offset="0x12D2A28", VA="0x12D2A28")]
			get
			{
				return new LeaderboardCollection();
			}
		}

		public ScorePageDirection Direction
		{
			[Address(RVA="0x12D2A38", Offset="0x12D2A38", VA="0x12D2A38")]
			get
			{
				return new ScorePageDirection();
			}
		}

		internal object InternalObject
		{
			[Address(RVA="0x12D2A48", Offset="0x12D2A48", VA="0x12D2A48")]
			get
			{
				return null;
			}
		}

		public string LeaderboardId
		{
			[Address(RVA="0x12D2A40", Offset="0x12D2A40", VA="0x12D2A40")]
			get
			{
				return null;
			}
		}

		public LeaderboardTimeSpan TimeSpan
		{
			[Address(RVA="0x12D2A30", Offset="0x12D2A30", VA="0x12D2A30")]
			get
			{
				return new LeaderboardTimeSpan();
			}
		}

		[Address(RVA="0x12D29D4", Offset="0x12D29D4", VA="0x12D29D4")]
		internal ScorePageToken(object internalObject, string id, LeaderboardCollection collection, LeaderboardTimeSpan timespan, ScorePageDirection direction)
		{
		}
	}
}