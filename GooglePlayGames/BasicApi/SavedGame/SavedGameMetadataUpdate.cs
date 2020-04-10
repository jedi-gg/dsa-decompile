using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi.SavedGame
{
	public struct SavedGameMetadataUpdate
	{
		[FieldOffset(Offset="0x0")]
		private readonly bool mDescriptionUpdated;

		[FieldOffset(Offset="0x8")]
		private readonly string mNewDescription;

		[FieldOffset(Offset="0x10")]
		private readonly bool mCoverImageUpdated;

		[FieldOffset(Offset="0x18")]
		private readonly byte[] mNewPngCoverImage;

		[FieldOffset(Offset="0x20")]
		private readonly TimeSpan? mNewPlayedTime;

		public bool IsCoverImageUpdated
		{
			[Address(RVA="0xF0012C", Offset="0xF0012C", VA="0xF0012C")]
			get
			{
				return new bool();
			}
		}

		public bool IsDescriptionUpdated
		{
			[Address(RVA="0xF0011C", Offset="0xF0011C", VA="0xF0011C")]
			get
			{
				return new bool();
			}
		}

		public bool IsPlayedTimeUpdated
		{
			[Address(RVA="0xF0013C", Offset="0xF0013C", VA="0xF0013C")]
			get
			{
				return new bool();
			}
		}

		public string UpdatedDescription
		{
			[Address(RVA="0xF00124", Offset="0xF00124", VA="0xF00124")]
			get
			{
				return null;
			}
		}

		public TimeSpan? UpdatedPlayedTime
		{
			[Address(RVA="0xF00144", Offset="0xF00144", VA="0xF00144")]
			get
			{
				return null;
			}
		}

		public byte[] UpdatedPngCoverImage
		{
			[Address(RVA="0xF00134", Offset="0xF00134", VA="0xF00134")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF000E0", Offset="0xF000E0", VA="0xF000E0")]
		private SavedGameMetadataUpdate(SavedGameMetadataUpdate.Builder builder)
		{
		}

		public struct Builder
		{
			[FieldOffset(Offset="0x0")]
			internal bool mDescriptionUpdated;

			[FieldOffset(Offset="0x8")]
			internal string mNewDescription;

			[FieldOffset(Offset="0x10")]
			internal bool mCoverImageUpdated;

			[FieldOffset(Offset="0x18")]
			internal byte[] mNewPngCoverImage;

			[FieldOffset(Offset="0x20")]
			internal TimeSpan? mNewPlayedTime;

			[Address(RVA="0xF001D4", Offset="0xF001D4", VA="0xF001D4")]
			public SavedGameMetadataUpdate Build()
			{
				return new SavedGameMetadataUpdate();
			}

			[Address(RVA="0xF0019C", Offset="0xF0019C", VA="0xF0019C")]
			public SavedGameMetadataUpdate.Builder WithUpdatedDescription(string description)
			{
				return new SavedGameMetadataUpdate.Builder();
			}

			[Address(RVA="0xF001CC", Offset="0xF001CC", VA="0xF001CC")]
			public SavedGameMetadataUpdate.Builder WithUpdatedPlayedTime(TimeSpan newPlayedTime)
			{
				return new SavedGameMetadataUpdate.Builder();
			}

			[Address(RVA="0xF001A4", Offset="0xF001A4", VA="0xF001A4")]
			public SavedGameMetadataUpdate.Builder WithUpdatedPngCoverImage(byte[] newPngCoverImage)
			{
				return new SavedGameMetadataUpdate.Builder();
			}
		}
	}
}