using GooglePlayGames.BasicApi.SavedGame;
using Il2CppDummyDll;
using System;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidSnapshotMetadata : ISavedGameMetadata
	{
		[FieldOffset(Offset="0x10")]
		private AndroidJavaObject mJavaSnapshot;

		[FieldOffset(Offset="0x18")]
		private AndroidJavaObject mJavaMetadata;

		[FieldOffset(Offset="0x20")]
		private AndroidJavaObject mJavaContents;

		public string CoverImageURL
		{
			[Address(RVA="0x1EB4700", Offset="0x1EB4700", VA="0x1EB4700", Slot="7")]
			get
			{
				return null;
			}
		}

		public string Description
		{
			[Address(RVA="0x1EB467C", Offset="0x1EB467C", VA="0x1EB467C", Slot="6")]
			get
			{
				return null;
			}
		}

		public string Filename
		{
			[Address(RVA="0x1EB45F8", Offset="0x1EB45F8", VA="0x1EB45F8", Slot="5")]
			get
			{
				return null;
			}
		}

		public bool IsOpen
		{
			[Address(RVA="0x1EB0B8C", Offset="0x1EB0B8C", VA="0x1EB0B8C", Slot="4")]
			get
			{
				return new bool();
			}
		}

		public AndroidJavaObject JavaContents
		{
			[Address(RVA="0x1EB0C18", Offset="0x1EB0C18", VA="0x1EB0C18")]
			get
			{
				return null;
			}
		}

		public AndroidJavaObject JavaMetadata
		{
			[Address(RVA="0x1EB23FC", Offset="0x1EB23FC", VA="0x1EB23FC")]
			get
			{
				return null;
			}
		}

		public AndroidJavaObject JavaSnapshot
		{
			[Address(RVA="0x1EB1EF0", Offset="0x1EB1EF0", VA="0x1EB1EF0")]
			get
			{
				return null;
			}
		}

		public DateTime LastModifiedTimestamp
		{
			[Address(RVA="0x1EB483C", Offset="0x1EB483C", VA="0x1EB483C", Slot="9")]
			get
			{
				return new DateTime();
			}
		}

		public TimeSpan TotalTimePlayed
		{
			[Address(RVA="0x1EB4784", Offset="0x1EB4784", VA="0x1EB4784", Slot="8")]
			get
			{
				return new TimeSpan();
			}
		}

		[Address(RVA="0x1EB2EBC", Offset="0x1EB2EBC", VA="0x1EB2EBC")]
		public AndroidSnapshotMetadata(AndroidJavaObject javaSnapshot)
		{
		}

		[Address(RVA="0x1EB3240", Offset="0x1EB3240", VA="0x1EB3240")]
		public AndroidSnapshotMetadata(AndroidJavaObject javaMetadata, AndroidJavaObject javaContents)
		{
		}
	}
}