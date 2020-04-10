using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi
{
	public class Achievement
	{
		[FieldOffset(Offset="0x0")]
		private readonly static DateTime UnixEpoch;

		[FieldOffset(Offset="0x10")]
		private string mId;

		[FieldOffset(Offset="0x18")]
		private bool mIsIncremental;

		[FieldOffset(Offset="0x19")]
		private bool mIsRevealed;

		[FieldOffset(Offset="0x1A")]
		private bool mIsUnlocked;

		[FieldOffset(Offset="0x1C")]
		private int mCurrentSteps;

		[FieldOffset(Offset="0x20")]
		private int mTotalSteps;

		[FieldOffset(Offset="0x28")]
		private string mDescription;

		[FieldOffset(Offset="0x30")]
		private string mName;

		[FieldOffset(Offset="0x38")]
		private long mLastModifiedTime;

		[FieldOffset(Offset="0x40")]
		private ulong mPoints;

		[FieldOffset(Offset="0x48")]
		private string mRevealedImageUrl;

		[FieldOffset(Offset="0x50")]
		private string mUnlockedImageUrl;

		public int CurrentSteps
		{
			[Address(RVA="0x1EC2EDC", Offset="0x1EC2EDC", VA="0x1EC2EDC")]
			get
			{
				return new int();
			}
			[Address(RVA="0x1EC2EE4", Offset="0x1EC2EE4", VA="0x1EC2EE4")]
			set
			{
			}
		}

		public string Description
		{
			[Address(RVA="0x1EC2F34", Offset="0x1EC2F34", VA="0x1EC2F34")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EC2F3C", Offset="0x1EC2F3C", VA="0x1EC2F3C")]
			set
			{
			}
		}

		public string Id
		{
			[Address(RVA="0x1EC2F24", Offset="0x1EC2F24", VA="0x1EC2F24")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EC2F2C", Offset="0x1EC2F2C", VA="0x1EC2F2C")]
			set
			{
			}
		}

		public bool IsIncremental
		{
			[Address(RVA="0x1EC2EC8", Offset="0x1EC2EC8", VA="0x1EC2EC8")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1EC2ED0", Offset="0x1EC2ED0", VA="0x1EC2ED0")]
			set
			{
			}
		}

		public bool IsRevealed
		{
			[Address(RVA="0x1EC2F10", Offset="0x1EC2F10", VA="0x1EC2F10")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1EC2F18", Offset="0x1EC2F18", VA="0x1EC2F18")]
			set
			{
			}
		}

		public bool IsUnlocked
		{
			[Address(RVA="0x1EC2EFC", Offset="0x1EC2EFC", VA="0x1EC2EFC")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1EC2F04", Offset="0x1EC2F04", VA="0x1EC2F04")]
			set
			{
			}
		}

		public DateTime LastModifiedTime
		{
			[Address(RVA="0x1EC2F54", Offset="0x1EC2F54", VA="0x1EC2F54")]
			get
			{
				return new DateTime();
			}
			[Address(RVA="0x1EC2FE4", Offset="0x1EC2FE4", VA="0x1EC2FE4")]
			set
			{
			}
		}

		public string Name
		{
			[Address(RVA="0x1EC2F44", Offset="0x1EC2F44", VA="0x1EC2F44")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EC2F4C", Offset="0x1EC2F4C", VA="0x1EC2F4C")]
			set
			{
			}
		}

		public ulong Points
		{
			[Address(RVA="0x1EC30AC", Offset="0x1EC30AC", VA="0x1EC30AC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EC30B4", Offset="0x1EC30B4", VA="0x1EC30B4")]
			set
			{
			}
		}

		public string RevealedImageUrl
		{
			[Address(RVA="0x1EC30BC", Offset="0x1EC30BC", VA="0x1EC30BC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EC30C4", Offset="0x1EC30C4", VA="0x1EC30C4")]
			set
			{
			}
		}

		public int TotalSteps
		{
			[Address(RVA="0x1EC2EEC", Offset="0x1EC2EEC", VA="0x1EC2EEC")]
			get
			{
				return new int();
			}
			[Address(RVA="0x1EC2EF4", Offset="0x1EC2EF4", VA="0x1EC2EF4")]
			set
			{
			}
		}

		public string UnlockedImageUrl
		{
			[Address(RVA="0x1EC30CC", Offset="0x1EC30CC", VA="0x1EC30CC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EC30D4", Offset="0x1EC30D4", VA="0x1EC30D4")]
			set
			{
			}
		}

		[Address(RVA="0x1EC30DC", Offset="0x1EC30DC", VA="0x1EC30DC")]
		static Achievement()
		{
		}

		[Address(RVA="0x1EC2E50", Offset="0x1EC2E50", VA="0x1EC2E50")]
		public Achievement()
		{
		}

		[Address(RVA="0x1EC2ADC", Offset="0x1EC2ADC", VA="0x1EC2ADC", Slot="3")]
		public override string ToString()
		{
			return null;
		}
	}
}