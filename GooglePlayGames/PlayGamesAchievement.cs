using GooglePlayGames.BasicApi;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	internal class PlayGamesAchievement : IAchievement, IAchievementDescription
	{
		[FieldOffset(Offset="0x10")]
		private readonly ReportProgress mProgressCallback;

		[FieldOffset(Offset="0x18")]
		private string mId;

		[FieldOffset(Offset="0x20")]
		private bool mIsIncremental;

		[FieldOffset(Offset="0x24")]
		private int mCurrentSteps;

		[FieldOffset(Offset="0x28")]
		private int mTotalSteps;

		[FieldOffset(Offset="0x30")]
		private double mPercentComplete;

		[FieldOffset(Offset="0x38")]
		private bool mCompleted;

		[FieldOffset(Offset="0x39")]
		private bool mHidden;

		[FieldOffset(Offset="0x40")]
		private DateTime mLastModifiedTime;

		[FieldOffset(Offset="0x48")]
		private string mTitle;

		[FieldOffset(Offset="0x50")]
		private string mRevealedImageUrl;

		[FieldOffset(Offset="0x58")]
		private string mUnlockedImageUrl;

		[FieldOffset(Offset="0x60")]
		private UnityWebRequest mImageFetcher;

		[FieldOffset(Offset="0x68")]
		private Texture2D mImage;

		[FieldOffset(Offset="0x70")]
		private string mDescription;

		[FieldOffset(Offset="0x78")]
		private ulong mPoints;

		public string achievedDescription
		{
			[Address(RVA="0x12D76B8", Offset="0x12D76B8", VA="0x12D76B8", Slot="14")]
			get
			{
				return null;
			}
		}

		public bool completed
		{
			[Address(RVA="0x12D7664", Offset="0x12D7664", VA="0x12D7664", Slot="9")]
			get
			{
				return new bool();
			}
		}

		public int currentSteps
		{
			[Address(RVA="0x12D7684", Offset="0x12D7684", VA="0x12D7684")]
			get
			{
				return new int();
			}
		}

		public bool hidden
		{
			[Address(RVA="0x12D765C", Offset="0x12D765C", VA="0x12D765C", Slot="10")]
			get
			{
				return new bool();
			}
		}

		public string id
		{
			[Address(RVA="0x12D766C", Offset="0x12D766C", VA="0x12D766C", Slot="5")]
			get
			{
				return null;
			}
			[Address(RVA="0x12D7674", Offset="0x12D7674", VA="0x12D7674", Slot="6")]
			set
			{
			}
		}

		public Texture2D image
		{
			[Address(RVA="0x12D76B4", Offset="0x12D76B4", VA="0x12D76B4", Slot="13")]
			get
			{
				return null;
			}
		}

		public bool isIncremental
		{
			[Address(RVA="0x12D767C", Offset="0x12D767C", VA="0x12D767C")]
			get
			{
				return new bool();
			}
		}

		public DateTime lastReportedDate
		{
			[Address(RVA="0x12D76A4", Offset="0x12D76A4", VA="0x12D76A4", Slot="11")]
			get
			{
				return new DateTime();
			}
		}

		public double percentCompleted
		{
			[Address(RVA="0x12D7694", Offset="0x12D7694", VA="0x12D7694", Slot="7")]
			get
			{
				return new double();
			}
			[Address(RVA="0x12D769C", Offset="0x12D769C", VA="0x12D769C", Slot="8")]
			set
			{
			}
		}

		public int points
		{
			[Address(RVA="0x12D76C8", Offset="0x12D76C8", VA="0x12D76C8", Slot="16")]
			get
			{
				return new int();
			}
		}

		public string title
		{
			[Address(RVA="0x12D76AC", Offset="0x12D76AC", VA="0x12D76AC", Slot="12")]
			get
			{
				return null;
			}
		}

		public int totalSteps
		{
			[Address(RVA="0x12D768C", Offset="0x12D768C", VA="0x12D768C")]
			get
			{
				return new int();
			}
		}

		public string unachievedDescription
		{
			[Address(RVA="0x12D76C0", Offset="0x12D76C0", VA="0x12D76C0", Slot="15")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x12D6744", Offset="0x12D6744", VA="0x12D6744")]
		internal PlayGamesAchievement()
		{
		}

		[Address(RVA="0x12D6948", Offset="0x12D6948", VA="0x12D6948")]
		internal PlayGamesAchievement(ReportProgress progressCallback)
		{
		}

		[Address(RVA="0x12D6A2C", Offset="0x12D6A2C", VA="0x12D6A2C")]
		internal PlayGamesAchievement(Achievement ach)
		{
		}

		[Address(RVA="0x12D7518", Offset="0x12D7518", VA="0x12D7518")]
		private Texture2D LoadImage()
		{
			return null;
		}

		[Address(RVA="0x12D6D0C", Offset="0x12D6D0C", VA="0x12D6D0C", Slot="4")]
		public void ReportProgress(Action<bool> callback)
		{
		}
	}
}