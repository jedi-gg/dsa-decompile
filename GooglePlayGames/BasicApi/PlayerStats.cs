using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi
{
	public class PlayerStats
	{
		[FieldOffset(Offset="0x0")]
		private static float UNSET_VALUE;

		[FieldOffset(Offset="0x10")]
		private bool mValid;

		[FieldOffset(Offset="0x14")]
		private int mNumberOfPurchases;

		[FieldOffset(Offset="0x18")]
		private float mAvgSessionLength;

		[FieldOffset(Offset="0x1C")]
		private int mDaysSinceLastPlayed;

		[FieldOffset(Offset="0x20")]
		private int mNumberOfSessions;

		[FieldOffset(Offset="0x24")]
		private float mSessPercentile;

		[FieldOffset(Offset="0x28")]
		private float mSpendPercentile;

		[FieldOffset(Offset="0x2C")]
		private float mSpendProbability;

		[FieldOffset(Offset="0x30")]
		private float mChurnProbability;

		[FieldOffset(Offset="0x34")]
		private float mHighSpenderProbability;

		[FieldOffset(Offset="0x38")]
		private float mTotalSpendNext28Days;

		public float AvgSessionLength
		{
			[Address(RVA="0x12D19A0", Offset="0x12D19A0", VA="0x12D19A0")]
			get
			{
				return new float();
			}
		}

		public float ChurnProbability
		{
			[Address(RVA="0x12D19D0", Offset="0x12D19D0", VA="0x12D19D0")]
			get
			{
				return new float();
			}
		}

		public int DaysSinceLastPlayed
		{
			[Address(RVA="0x12D19A8", Offset="0x12D19A8", VA="0x12D19A8")]
			get
			{
				return new int();
			}
		}

		public float HighSpenderProbability
		{
			[Address(RVA="0x12D19D8", Offset="0x12D19D8", VA="0x12D19D8")]
			get
			{
				return new float();
			}
		}

		public int NumberOfPurchases
		{
			[Address(RVA="0x12D1998", Offset="0x12D1998", VA="0x12D1998")]
			get
			{
				return new int();
			}
		}

		public int NumberOfSessions
		{
			[Address(RVA="0x12D19B0", Offset="0x12D19B0", VA="0x12D19B0")]
			get
			{
				return new int();
			}
		}

		public float SessPercentile
		{
			[Address(RVA="0x12D19B8", Offset="0x12D19B8", VA="0x12D19B8")]
			get
			{
				return new float();
			}
		}

		public float SpendPercentile
		{
			[Address(RVA="0x12D19C0", Offset="0x12D19C0", VA="0x12D19C0")]
			get
			{
				return new float();
			}
		}

		public float SpendProbability
		{
			[Address(RVA="0x12D19C8", Offset="0x12D19C8", VA="0x12D19C8")]
			get
			{
				return new float();
			}
		}

		public float TotalSpendNext28Days
		{
			[Address(RVA="0x12D19E0", Offset="0x12D19E0", VA="0x12D19E0")]
			get
			{
				return new float();
			}
		}

		public bool Valid
		{
			[Address(RVA="0x12D1990", Offset="0x12D1990", VA="0x12D1990")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x12D1E5C", Offset="0x12D1E5C", VA="0x12D1E5C")]
		static PlayerStats()
		{
		}

		[Address(RVA="0x12D18D4", Offset="0x12D18D4", VA="0x12D18D4")]
		public PlayerStats(int numberOfPurchases, float avgSessionLength, int daysSinceLastPlayed, int numberOfSessions, float sessPercentile, float spendPercentile, float spendProbability, float churnProbability, float highSpenderProbability, float totalSpendNext28Days)
		{
		}

		[Address(RVA="0x12D1968", Offset="0x12D1968", VA="0x12D1968")]
		public PlayerStats()
		{
		}

		[Address(RVA="0x12D1A64", Offset="0x12D1A64", VA="0x12D1A64")]
		public bool HasAvgSessionLength()
		{
			return new bool();
		}

		[Address(RVA="0x12D1CDC", Offset="0x12D1CDC", VA="0x12D1CDC")]
		public bool HasChurnProbability()
		{
			return new bool();
		}

		[Address(RVA="0x12D1AE4", Offset="0x12D1AE4", VA="0x12D1AE4")]
		public bool HasDaysSinceLastPlayed()
		{
			return new bool();
		}

		[Address(RVA="0x12D1D5C", Offset="0x12D1D5C", VA="0x12D1D5C")]
		public bool HasHighSpenderProbability()
		{
			return new bool();
		}

		[Address(RVA="0x12D19E8", Offset="0x12D19E8", VA="0x12D19E8")]
		public bool HasNumberOfPurchases()
		{
			return new bool();
		}

		[Address(RVA="0x12D1B60", Offset="0x12D1B60", VA="0x12D1B60")]
		public bool HasNumberOfSessions()
		{
			return new bool();
		}

		[Address(RVA="0x12D1BDC", Offset="0x12D1BDC", VA="0x12D1BDC")]
		public bool HasSessPercentile()
		{
			return new bool();
		}

		[Address(RVA="0x12D1C5C", Offset="0x12D1C5C", VA="0x12D1C5C")]
		public bool HasSpendPercentile()
		{
			return new bool();
		}

		[Address(RVA="0x12D1DDC", Offset="0x12D1DDC", VA="0x12D1DDC")]
		public bool HasTotalSpendNext28Days()
		{
			return new bool();
		}
	}
}