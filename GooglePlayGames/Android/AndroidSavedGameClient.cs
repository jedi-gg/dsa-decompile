using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidSavedGameClient : ISavedGameClient
	{
		[FieldOffset(Offset="0x0")]
		private readonly static Regex ValidFilenameRegex;

		[FieldOffset(Offset="0x10")]
		private AndroidJavaObject mSnapshotsClient;

		[Address(RVA="0x1EB240C", Offset="0x1EB240C", VA="0x1EB240C")]
		static AndroidSavedGameClient()
		{
		}

		[Address(RVA="0x1EAFE08", Offset="0x1EAFE08", VA="0x1EAFE08")]
		public AndroidSavedGameClient(AndroidJavaObject account)
		{
		}

		[Address(RVA="0x1EB140C", Offset="0x1EB140C", VA="0x1EB140C")]
		private static AndroidJavaObject AsMetadataChange(SavedGameMetadataUpdate update)
		{
			return null;
		}

		[Address(RVA="0x1EB0D68", Offset="0x1EB0D68", VA="0x1EB0D68", Slot="8")]
		public void CommitUpdate(ISavedGameMetadata metadata, SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, Action<SavedGameRequestStatus, ISavedGameMetadata> callback)
		{
		}

		[Address(RVA="0x1EB2228", Offset="0x1EB2228", VA="0x1EB2228", Slot="10")]
		public void Delete(ISavedGameMetadata metadata)
		{
		}

		[Address(RVA="0x1EB1EF8", Offset="0x1EB1EF8", VA="0x1EB1EF8", Slot="9")]
		public void FetchAllSavedGames(DataSource source, Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback)
		{
		}

		[Address(RVA="0x1EB03E0", Offset="0x1EB03E0", VA="0x1EB03E0")]
		private void InternalOpen(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		[Address(RVA="0x1EB0348", Offset="0x1EB0348", VA="0x1EB0348")]
		internal static bool IsValidFilename(string filename)
		{
			return new bool();
		}

		[Address(RVA="0x1EB005C", Offset="0x1EB005C", VA="0x1EB005C", Slot="4")]
		public void OpenWithAutomaticConflictResolution(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		[Address(RVA="0x1EB07F8", Offset="0x1EB07F8", VA="0x1EB07F8", Slot="5")]
		public void OpenWithManualConflictResolution(string filename, DataSource source, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		[Address(RVA="0x1EB09A0", Offset="0x1EB09A0", VA="0x1EB09A0", Slot="6")]
		public void ReadBinaryData(ISavedGameMetadata metadata, Action<SavedGameRequestStatus, byte[]> completedCallback)
		{
		}

		[Address(RVA="0x1EB0C20", Offset="0x1EB0C20", VA="0x1EB0C20", Slot="7")]
		public void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, Action<SelectUIStatus, ISavedGameMetadata> callback)
		{
		}

		[Address(RVA="0x1EB02AC", Offset="0x1EB02AC", VA="0x1EB02AC")]
		private ConflictCallback ToOnGameThread(ConflictCallback conflictCallback)
		{
			return null;
		}

		[Address(RVA="0x1F5CC5C", Offset="0x1F5CC5C", VA="0x1F5CC5C")]
		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EA58", Offset="0x104EA58")]
		private sealed class <>c__DisplayClass11_0
		{
			[FieldOffset(Offset="0x10")]
			public ConflictCallback conflictCallback;

			[Address(RVA="0x1EB2404", Offset="0x1EB2404", VA="0x1EB2404")]
			public <>c__DisplayClass11_0()
			{
			}

			[Address(RVA="0x1EB2484", Offset="0x1EB2484", VA="0x1EB2484")]
			internal void <ToOnGameThread>b__0(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EA68", Offset="0x104EA68")]
		private sealed class <>c__DisplayClass11_1
		{
			[FieldOffset(Offset="0x10")]
			public IConflictResolver resolver;

			[FieldOffset(Offset="0x18")]
			public ISavedGameMetadata original;

			[FieldOffset(Offset="0x20")]
			public byte[] originalData;

			[FieldOffset(Offset="0x28")]
			public ISavedGameMetadata unmerged;

			[FieldOffset(Offset="0x30")]
			public byte[] unmergedData;

			[FieldOffset(Offset="0x38")]
			public AndroidSavedGameClient.<>c__DisplayClass11_0 CS$<>8__locals1;

			[Address(RVA="0x1EB2604", Offset="0x1EB2604", VA="0x1EB2604")]
			public <>c__DisplayClass11_1()
			{
			}

			[Address(RVA="0x1EB260C", Offset="0x1EB260C", VA="0x1EB260C")]
			internal void <ToOnGameThread>b__1()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EA78", Offset="0x104EA78")]
		private sealed class <>c__DisplayClass15_0<T1, T2>
		{
			[FieldOffset(Offset="0x0")]
			public Action<T1, T2> toConvert;

			[Address(RVA="0x1D8D270", Offset="0x1D8D270", VA="0x1D8D270")]
			public <>c__DisplayClass15_0()
			{
			}

			[Address(RVA="0x1D8D29C", Offset="0x1D8D29C", VA="0x1D8D29C")]
			internal void <ToOnGameThread>b__0(T1 val1, T2 val2)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EA88", Offset="0x104EA88")]
		private sealed class <>c__DisplayClass15_1<T1, T2>
		{
			[FieldOffset(Offset="0x0")]
			public T1 val1;

			[FieldOffset(Offset="0x0")]
			public T2 val2;

			[FieldOffset(Offset="0x0")]
			public AndroidSavedGameClient.<>c__DisplayClass15_0<T1, T2> CS$<>8__locals1;

			[Address(RVA="0x1D8D518", Offset="0x1D8D518", VA="0x1D8D518")]
			public <>c__DisplayClass15_1()
			{
			}

			[Address(RVA="0x1D8D544", Offset="0x1D8D544", VA="0x1D8D544")]
			internal void <ToOnGameThread>b__1()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EA18", Offset="0x104EA18")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset="0x10")]
			public ConflictResolutionStrategy resolutionStrategy;

			[FieldOffset(Offset="0x18")]
			public Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback;

			[Address(RVA="0x1EB02A4", Offset="0x1EB02A4", VA="0x1EB02A4")]
			public <>c__DisplayClass3_0()
			{
			}

			[Address(RVA="0x1EB2680", Offset="0x1EB2680", VA="0x1EB2680")]
			internal void <OpenWithAutomaticConflictResolution>b__0(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EA28", Offset="0x104EA28")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidSavedGameClient <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback;

			[FieldOffset(Offset="0x20")]
			public string filename;

			[FieldOffset(Offset="0x28")]
			public DataSource source;

			[FieldOffset(Offset="0x2C")]
			public ConflictResolutionStrategy resolutionStrategy;

			[FieldOffset(Offset="0x30")]
			public bool prefetchDataOnConflict;

			[FieldOffset(Offset="0x38")]
			public ConflictCallback conflictCallback;

			[FieldOffset(Offset="0x40")]
			public Action <>9__2;

			[Address(RVA="0x1EB0998", Offset="0x1EB0998", VA="0x1EB0998")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x1EB2A34", Offset="0x1EB2A34", VA="0x1EB2A34")]
			internal void <InternalOpen>b__0(AndroidJavaObject dataOrConflict)
			{
			}

			[Address(RVA="0x1EB310C", Offset="0x1EB310C", VA="0x1EB310C")]
			internal void <InternalOpen>b__1(AndroidJavaObject exception)
			{
			}

			[Address(RVA="0x1EB309C", Offset="0x1EB309C", VA="0x1EB309C")]
			internal void <InternalOpen>b__2()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EA38", Offset="0x104EA38")]
		private sealed class <>c__DisplayClass8_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<SavedGameRequestStatus, ISavedGameMetadata> callback;

			[Address(RVA="0x1EB1404", Offset="0x1EB1404", VA="0x1EB1404")]
			public <>c__DisplayClass8_0()
			{
			}

			[Address(RVA="0x1EB3174", Offset="0x1EB3174", VA="0x1EB3174")]
			internal void <CommitUpdate>b__0(AndroidJavaObject snapshotMetadata)
			{
			}

			[Address(RVA="0x1EB327C", Offset="0x1EB327C", VA="0x1EB327C")]
			internal void <CommitUpdate>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EA48", Offset="0x104EA48")]
		private sealed class <>c__DisplayClass9_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback;

			[Address(RVA="0x1EB2220", Offset="0x1EB2220", VA="0x1EB2220")]
			public <>c__DisplayClass9_0()
			{
			}

			[Address(RVA="0x1EB3318", Offset="0x1EB3318", VA="0x1EB3318")]
			internal void <FetchAllSavedGames>b__0(AndroidJavaObject annotatedData)
			{
			}

			[Address(RVA="0x1EB3848", Offset="0x1EB3848", VA="0x1EB3848")]
			internal void <FetchAllSavedGames>b__1(AndroidJavaObject exception)
			{
			}
		}

		private class AndroidConflictResolver : IConflictResolver
		{
			[FieldOffset(Offset="0x10")]
			private readonly AndroidJavaObject mSnapshotsClient;

			[FieldOffset(Offset="0x18")]
			private readonly AndroidJavaObject mConflict;

			[FieldOffset(Offset="0x20")]
			private readonly AndroidSnapshotMetadata mOriginal;

			[FieldOffset(Offset="0x28")]
			private readonly AndroidSnapshotMetadata mUnmerged;

			[FieldOffset(Offset="0x30")]
			private readonly Action<SavedGameRequestStatus, ISavedGameMetadata> mCompleteCallback;

			[FieldOffset(Offset="0x38")]
			private readonly Action mRetryFileOpen;

			[Address(RVA="0x1EB2FA0", Offset="0x1EB2FA0", VA="0x1EB2FA0")]
			internal AndroidConflictResolver(AndroidJavaObject snapshotClient, AndroidJavaObject conflict, AndroidSnapshotMetadata original, AndroidSnapshotMetadata unmerged, Action<SavedGameRequestStatus, ISavedGameMetadata> completeCallback, Action retryOpen)
			{
			}

			[Address(RVA="0x1EB4560", Offset="0x1EB4560", VA="0x1EB4560")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108DDAC", Offset="0x108DDAC")]
			private void <ChooseMetadata>b__8_0(AndroidJavaObject dataOrConflict)
			{
			}

			[Address(RVA="0x1EB4590", Offset="0x1EB4590", VA="0x1EB4590")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108DDBC", Offset="0x108DDBC")]
			private void <ChooseMetadata>b__8_1(AndroidJavaObject exception)
			{
			}

			[Address(RVA="0x1EB44C8", Offset="0x1EB44C8", VA="0x1EB44C8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108DD8C", Offset="0x108DD8C")]
			private void <ResolveConflict>b__7_0(AndroidJavaObject dataOrConflict)
			{
			}

			[Address(RVA="0x1EB44F8", Offset="0x1EB44F8", VA="0x1EB44F8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108DD9C", Offset="0x108DD9C")]
			private void <ResolveConflict>b__7_1(AndroidJavaObject exception)
			{
			}

			[Address(RVA="0x1EB410C", Offset="0x1EB410C", VA="0x1EB410C", Slot="4")]
			public void ChooseMetadata(ISavedGameMetadata chosenMetadata)
			{
			}

			[Address(RVA="0x1EB38D4", Offset="0x1EB38D4", VA="0x1EB38D4", Slot="5")]
			public void ResolveConflict(ISavedGameMetadata chosenMetadata, SavedGameMetadataUpdate metadataUpdate, byte[] updatedData)
			{
			}
		}
	}
}