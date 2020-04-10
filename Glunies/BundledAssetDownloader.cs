using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies
{
	public class BundledAssetDownloader : IAssetDownloader, ILoggable<LogCategory>
	{
		[FieldOffset(Offset="0x0")]
		private const string ASSET_URL_FORMAT = "{0}/assets/{1}-{2}/";

		[FieldOffset(Offset="0x0")]
		private const ulong BYTES_IN_MB = 1048576L;

		[FieldOffset(Offset="0x0")]
		private const ulong DOWNLOAD_SIZE_PROMPT_THRESHOLD = 10485760L;

		[Attribute(Name="InjectAttribute", RVA="0x1063E9C", Offset="0x1063E9C")]
		[FieldOffset(Offset="0x10")]
		private BundleManager _bundleManager;

		[Attribute(Name="InjectAttribute", RVA="0x1063EAC", Offset="0x1063EAC")]
		[FieldOffset(Offset="0x18")]
		private SystemDialogManager _systemDialogManager;

		[Attribute(Name="InjectAttribute", RVA="0x1063EBC", Offset="0x1063EBC")]
		[FieldOffset(Offset="0x20")]
		private LocalizationManager _lm;

		[Attribute(Name="InjectAttribute", RVA="0x1063ECC", Offset="0x1063ECC")]
		[FieldOffset(Offset="0x28")]
		private DispatchSystem _dispatch;

		[FieldOffset(Offset="0x30")]
		private string _downloadedManifestVersion;

		[FieldOffset(Offset="0x38")]
		private string _downloadPromptedManifestVersion;

		[FieldOffset(Offset="0x40")]
		private BundledAssetDownloader.BackgroundDownloadOperator _backgroundDownloadOperator;

		[FieldOffset(Offset="0x48")]
		private BundledAssetDownloader.BatchDownloadOperator _tutorialAssetsDownloadOperator;

		public string DownloadedManifestVersion
		{
			[Address(RVA="0x141CE98", Offset="0x141CE98", VA="0x141CE98", Slot="5")]
			get
			{
				return null;
			}
		}

		public bool IsManifestLoaded
		{
			[Address(RVA="0x141CE18", Offset="0x141CE18", VA="0x141CE18", Slot="4")]
			get
			{
				return new bool();
			}
		}

		public LogCategory LogCategory
		{
			[Address(RVA="0x141CE10", Offset="0x141CE10", VA="0x141CE10", Slot="17")]
			get
			{
				return new LogCategory();
			}
		}

		[Address(RVA="0x141E10C", Offset="0x141E10C", VA="0x141E10C")]
		public BundledAssetDownloader()
		{
		}

		[Address(RVA="0x141CEA0", Offset="0x141CEA0", VA="0x141CEA0")]
		private string GetPlatformString()
		{
			return null;
		}

		[Address(RVA="0x141D65C", Offset="0x141D65C", VA="0x141D65C", Slot="15")]
		public ulong GetTutorialAssetsDownloadSizeBytes()
		{
			return new ulong();
		}

		[Address(RVA="0x141CEE8", Offset="0x141CEE8", VA="0x141CEE8", Slot="6")]
		public void Initialize()
		{
		}

		[Address(RVA="0x141D1E0", Offset="0x141D1E0", VA="0x141D1E0", Slot="9")]
		public void LoadManifest(string contentUrl, string version, Action<bool> finished)
		{
		}

		[Address(RVA="0x141D410", Offset="0x141D410", VA="0x141D410", Slot="10")]
		public void LoadManifest(string assetUrl, Action<bool> finished)
		{
		}

		[Address(RVA="0x141D5AC", Offset="0x141D5AC", VA="0x141D5AC", Slot="14")]
		public bool NeedsToDownloadTutorialAssets()
		{
			return new bool();
		}

		[Address(RVA="0x141DB84", Offset="0x141DB84", VA="0x141DB84")]
		private void SetBundlesToDownload()
		{
		}

		[Address(RVA="0x141CFC4", Offset="0x141CFC4", VA="0x141CFC4", Slot="7")]
		public void Shutdown()
		{
		}

		[Address(RVA="0x141D454", Offset="0x141D454", VA="0x141D454", Slot="11")]
		public void StartBackgroundDownloads()
		{
		}

		[Address(RVA="0x141D988", Offset="0x141D988", VA="0x141D988", Slot="16")]
		public void StartTutorialAssetsDownloads()
		{
		}

		[Address(RVA="0x141D46C", Offset="0x141D46C", VA="0x141D46C", Slot="12")]
		public void StopBackgroundDownloads()
		{
		}

		[Address(RVA="0x141D194", Offset="0x141D194", VA="0x141D194", Slot="8")]
		public void TickUpdate()
		{
		}

		[Address(RVA="0x141D9A0", Offset="0x141D9A0", VA="0x141D9A0", Slot="13")]
		public void TryShowLargeDownloadPrompt(Action finished)
		{
		}

		[Address(RVA="0x141E0A8", Offset="0x141E0A8", VA="0x141E0A8")]
		private void TutorialAssetsDownloadCompleted()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050E08", Offset="0x1050E08")]
		private sealed class <>c__DisplayClass10_0
		{
			[FieldOffset(Offset="0x10")]
			public BundledAssetDownloader <>4__this;

			[FieldOffset(Offset="0x18")]
			public string assetUrl;

			[FieldOffset(Offset="0x20")]
			public bool manifestLoaded;

			[FieldOffset(Offset="0x28")]
			public string version;

			[FieldOffset(Offset="0x30")]
			public bool wasDownloadingBackgroundAssets;

			[FieldOffset(Offset="0x38")]
			public Action<bool> finished;

			[Address(RVA="0x141D400", Offset="0x141D400", VA="0x141D400")]
			public <>c__DisplayClass10_0()
			{
			}

			[Address(RVA="0x141E114", Offset="0x141E114", VA="0x141E114")]
			internal void <LoadManifest>b__0(Action executed)
			{
			}

			[Address(RVA="0x141E200", Offset="0x141E200", VA="0x141E200")]
			internal void <LoadManifest>b__1()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050E18", Offset="0x1050E18")]
		private sealed class <>c__DisplayClass10_1
		{
			[FieldOffset(Offset="0x10")]
			public Action executed;

			[FieldOffset(Offset="0x18")]
			public BundledAssetDownloader.<>c__DisplayClass10_0 CS$<>8__locals1;

			[Address(RVA="0x141E1F8", Offset="0x141E1F8", VA="0x141E1F8")]
			public <>c__DisplayClass10_1()
			{
			}

			[Address(RVA="0x141E310", Offset="0x141E310", VA="0x141E310")]
			internal void <LoadManifest>b__2(bool success)
			{
			}
		}

		private abstract class ADownloadOperator
		{
			[FieldOffset(Offset="0x10")]
			protected BundleManager _bundleManager;

			[FieldOffset(Offset="0x18")]
			protected List<BundleInfo> _assetsToDownload;

			[FieldOffset(Offset="0x20")]
			protected AsyncOperator<BundledAssetDownloader.DownloadBundleOperation> _downloadOperator;

			[FieldOffset(Offset="0x28")]
			protected List<BundledAssetDownloader.DownloadBundleOperation> _activeDownloadOperations;

			[FieldOffset(Offset="0x30")]
			protected List<BundledAssetDownloader.DownloadBundleOperation> _inactiveDownloadOperations;

			[FieldOffset(Offset="0x38")]
			protected bool _shouldStartNewDownloads;

			[FieldOffset(Offset="0x3C")]
			protected float _downloadCountdownS;

			[FieldOffset(Offset="0x40")]
			protected bool _isDownloadingLocked;

			[FieldOffset(Offset="0x48")]
			protected Action _downloadingLockedCallback;

			[FieldOffset(Offset="0x50")]
			protected Action _downloadCompletedCallback;

			public bool ShouldStartNewDownloads
			{
				[Address(RVA="0x141D408", Offset="0x141D408", VA="0x141D408")]
				get
				{
					return new bool();
				}
			}

			[Address(RVA="0x141E36C", Offset="0x141E36C", VA="0x141E36C")]
			public ADownloadOperator(BundleManager bundleManager, Action downloadCompletedCallback = // 
			// Current member / type: System.Void Glunies.BundledAssetDownloader/ADownloadOperator::.ctor(Glunies.BundleManager,System.Action,System.Int32)
			// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
			// 
			// Product version: 2018.1.123.0
			// Exception in: System.Void .ctor(Glunies.BundleManager,System.Action,System.Int32)
			// 
			// Object reference not set to an instance of an object.
			//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
			//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
			//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
			//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
			//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com


			[Address(RVA="0x141E690", Offset="0x141E690", VA="0x141E690")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E260", Offset="0x108E260")]
			private void <GetTotalDownloadSizeBytes>g__AddAllBundleDependencies|12_0(string bundleName, HashSet<string> bundleNames)
			{
			}

			[Address(RVA="0x141DF68", Offset="0x141DF68", VA="0x141DF68")]
			public void ClearAssetDownloadList()
			{
			}

			[Address(RVA="0x141E794", Offset="0x141E794", VA="0x141E794")]
			protected int CompareBundleInfo(BundleInfo x, BundleInfo y)
			{
				return new int();
			}

			[Address(RVA="0x141E9A4", Offset="0x141E9A4", VA="0x141E9A4")]
			protected void DownloadOperationAborted(BundledAssetDownloader.DownloadBundleOperation op)
			{
			}

			[Address(RVA="0x141E84C", Offset="0x141E84C", VA="0x141E84C")]
			protected void DownloadOperationFinished(BundledAssetDownloader.DownloadBundleOperation op)
			{
			}

			[Address(RVA="0x141D66C", Offset="0x141D66C", VA="0x141D66C")]
			public ulong GetTotalDownloadSizeBytes()
			{
				return new ulong();
			}

			[Address(RVA="0x141D5BC", Offset="0x141D5BC", VA="0x141D5BC")]
			public bool HasPendingDownloads()
			{
				return new bool();
			}

			[Address(RVA="0x141E5E8", Offset="0x141E5E8", VA="0x141E5E8")]
			public void LockDownloads(Action locked)
			{
			}

			[Address(RVA="0x141DFC8", Offset="0x141DFC8", VA="0x141DFC8")]
			public void QueueBundleToDownload(BundleInfo bundleInfo)
			{
			}

			[Address(RVA="0x141D01C", Offset="0x141D01C", VA="0x141D01C")]
			public void Shutdown()
			{
			}

			[Address(RVA="0x141E550", Offset="0x141E550", VA="0x141E550", Slot="5")]
			public virtual void StartDownloads()
			{
			}

			[Address(RVA="0x141D47C", Offset="0x141D47C", VA="0x141D47C")]
			public void StopDownloads()
			{
			}

			[Address(RVA="0x141E4F0", Offset="0x141E4F0", VA="0x141E4F0", Slot="4")]
			public virtual void TickUpdate()
			{
			}

			[Address(RVA="0x141E2F8", Offset="0x141E2F8", VA="0x141E2F8")]
			public void UnlockDownloads(bool startDownloads)
			{
			}
		}

		private class BackgroundDownloadOperator : BundledAssetDownloader.ADownloadOperator
		{
			[FieldOffset(Offset="0x0")]
			private const int MAX_ACTIVE_BACKGROUND_DOWNLOADS = 1;

			[FieldOffset(Offset="0x0")]
			private const float BACKGROUND_DOWNLOAD_COOLDOWN_S = 2f;

			[Address(RVA="0x141CFB4", Offset="0x141CFB4", VA="0x141CFB4")]
			public BackgroundDownloadOperator(BundleManager bundleManager, Action downloadCompletedCallback = // 
			// Current member / type: System.Void Glunies.BundledAssetDownloader/BackgroundDownloadOperator::.ctor(Glunies.BundleManager,System.Action)
			// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
			// 
			// Product version: 2018.1.123.0
			// Exception in: System.Void .ctor(Glunies.BundleManager,System.Action)
			// 
			// Object reference not set to an instance of an object.
			//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
			//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
			//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
			//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
			//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com


			[Address(RVA="0x141EF7C", Offset="0x141EF7C", VA="0x141EF7C")]
			private bool CanStartBackgroundDownload()
			{
				return new bool();
			}

			[Address(RVA="0x141ECA8", Offset="0x141ECA8", VA="0x141ECA8")]
			private BundleInfo GetNextBundleToDownload()
			{
				return null;
			}

			[Address(RVA="0x141EA94", Offset="0x141EA94", VA="0x141EA94", Slot="4")]
			public override void TickUpdate()
			{
			}
		}

		private class BatchDownloadOperator : BundledAssetDownloader.ADownloadOperator
		{
			[Address(RVA="0x141CFBC", Offset="0x141CFBC", VA="0x141CFBC")]
			public BatchDownloadOperator(BundleManager bundleManager, Action downloadCompletedCallback = // 
			// Current member / type: System.Void Glunies.BundledAssetDownloader/BatchDownloadOperator::.ctor(Glunies.BundleManager,System.Action)
			// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
			// 
			// Product version: 2018.1.123.0
			// Exception in: System.Void .ctor(Glunies.BundleManager,System.Action)
			// 
			// Object reference not set to an instance of an object.
			//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
			//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
			//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
			//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
			//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com


			[Address(RVA="0x141F040", Offset="0x141F040", VA="0x141F040", Slot="5")]
			public override void StartDownloads()
			{
			}
		}

		private class DownloadBundleOperation : AAsyncOperation, ILoggable<LogCategory>
		{
			[FieldOffset(Offset="0x20")]
			public BundleInfo Bundle;

			[FieldOffset(Offset="0x28")]
			private BundleManager _bundleManager;

			[FieldOffset(Offset="0x30")]
			private IAsyncRequest _bundleRequest;

			[FieldOffset(Offset="0x38")]
			private Action<BundledAssetDownloader.DownloadBundleOperation> _aborted;

			[FieldOffset(Offset="0x40")]
			private bool _silent;

			public LogCategory LogCategory
			{
				[Address(RVA="0x141F2A0", Offset="0x141F2A0", VA="0x141F2A0", Slot="9")]
				get
				{
					return new LogCategory();
				}
			}

			[Address(RVA="0x141EDD4", Offset="0x141EDD4", VA="0x141EDD4")]
			public DownloadBundleOperation(BundleManager bundleManager, Action<BundledAssetDownloader.DownloadBundleOperation> aborted, bool silent)
			{
			}

			[Address(RVA="0x141F3A4", Offset="0x141F3A4", VA="0x141F3A4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E270", Offset="0x108E270")]
			private void <OnAbort>b__6_0()
			{
			}

			[Address(RVA="0x141F2B4", Offset="0x141F2B4", VA="0x141F2B4", Slot="8")]
			protected override void OnAbort()
			{
			}

			[Address(RVA="0x141F2B0", Offset="0x141F2B0", VA="0x141F2B0", Slot="7")]
			protected override void OnUpdate()
			{
			}

			[Address(RVA="0x141EE24", Offset="0x141EE24", VA="0x141EE24")]
			public void StartOperation(BundleInfo bundle)
			{
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051678", Offset="0x1051678")]
			private sealed class <>c__DisplayClass4_0
			{
				[FieldOffset(Offset="0x10")]
				public BundledAssetDownloader.DownloadBundleOperation <>4__this;

				[FieldOffset(Offset="0x18")]
				public BundleInfo bundle;

				[Address(RVA="0x141F2A8", Offset="0x141F2A8", VA="0x141F2A8")]
				public <>c__DisplayClass4_0()
				{
				}

				[Address(RVA="0x141F418", Offset="0x141F418", VA="0x141F418")]
				internal void <StartOperation>b__0(AssetBundle assetBundle)
				{
				}
			}
		}
	}
}