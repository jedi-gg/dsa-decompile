using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies
{
	public class BundleManager : ILoggable<LogCategory>, BundleManager.ITest
	{
		[FieldOffset(Offset="0x0")]
		public const string MANIFEST_BUNDLE_NAME = "manifest";

		[FieldOffset(Offset="0x0")]
		private const string MANIFEST_ASSET_NAME = "AssetBundleManifest";

		[FieldOffset(Offset="0x0")]
		private const string METADATA_FILE_NAME = "metadata";

		[FieldOffset(Offset="0x0")]
		private const float BUNDLE_HANDLE_UPDATE_THROTTLE_S = 0.5f;

		[FieldOffset(Offset="0x0")]
		private const long BUNDLE_CACHE_SIZE = 943718400L;

		[FieldOffset(Offset="0x0")]
		private const string INCLUDED_MANIFEST_BUNDLE_NAME = "included_manifest";

		[FieldOffset(Offset="0x0")]
		private readonly static string INCLUDED_BUNDLES_PATH;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1063EEC", Offset="0x1063EEC")]
		[FieldOffset(Offset="0x10")]
		private AssetBundleMetadata <Metadata>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1063EFC", Offset="0x1063EFC")]
		[FieldOffset(Offset="0x18")]
		private AssetBundleManifest <Manifest>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1063F0C", Offset="0x1063F0C")]
		[FieldOffset(Offset="0x20")]
		private AssetBundleManifest <IncludedManifest>k__BackingField;

		[FieldOffset(Offset="0x0")]
		private const long MEBIBYTE = 1048576L;

		[Attribute(Name="InjectAttribute", RVA="0x1063F1C", Offset="0x1063F1C")]
		[FieldOffset(Offset="0x28")]
		private HttpService _httpService;

		[Attribute(Name="InjectAttribute", RVA="0x1063F2C", Offset="0x1063F2C")]
		[FieldOffset(Offset="0x30")]
		private DispatchSystem _dispatchSystem;

		[FieldOffset(Offset="0x38")]
		private string _assetUrl;

		[FieldOffset(Offset="0x40")]
		private AsyncOperator<BundleManager.OpenBundleOperation> _loadBundleOperator;

		[FieldOffset(Offset="0x48")]
		private HashSet<string> _cachedDownloadableBundleNames;

		[FieldOffset(Offset="0x50")]
		private HashSet<string> _cachedIncludedBundleNames;

		[FieldOffset(Offset="0x58")]
		private Dictionary<string, BundleManager.AssetBundleHandle> _cachedBundleHandles;

		[FieldOffset(Offset="0x60")]
		private float _nextBundleHandleUpdateTimeS;

		private AssetBundleManifest IncludedManifest
		{
			[Address(RVA="0x141909C", Offset="0x141909C", VA="0x141909C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A1F4", Offset="0x108A1F4")]
			get
			{
				return null;
			}
			[Address(RVA="0x14190A4", Offset="0x14190A4", VA="0x14190A4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A204", Offset="0x108A204")]
			set
			{
			}
		}

		public LogCategory LogCategory
		{
			[Address(RVA="0x1419074", Offset="0x1419074", VA="0x1419074", Slot="4")]
			get
			{
				return new LogCategory();
			}
		}

		public AssetBundleManifest Manifest
		{
			[Address(RVA="0x141908C", Offset="0x141908C", VA="0x141908C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A1D4", Offset="0x108A1D4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1419094", Offset="0x1419094", VA="0x1419094")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A1E4", Offset="0x108A1E4")]
			private set
			{
			}
		}

		public AssetBundleMetadata Metadata
		{
			[Address(RVA="0x141907C", Offset="0x141907C", VA="0x141907C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A1B4", Offset="0x108A1B4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1419084", Offset="0x1419084", VA="0x1419084")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A1C4", Offset="0x108A1C4")]
			private set
			{
			}
		}

		[Address(RVA="0x141B0D8", Offset="0x141B0D8", VA="0x141B0D8")]
		static BundleManager()
		{
		}

		[Address(RVA="0x14190AC", Offset="0x14190AC", VA="0x14190AC")]
		public BundleManager()
		{
		}

		[Address(RVA="0x14197CC", Offset="0x14197CC", VA="0x14197CC")]
		public bool BundleExists(string bundleName)
		{
			return new bool();
		}

		[Address(RVA="0x141A56C", Offset="0x141A56C", VA="0x141A56C")]
		private void BundleRequestFinished(BundleManager.OpenBundleOperation operation)
		{
		}

		[Address(RVA="0x141A018", Offset="0x141A018", VA="0x141A018")]
		public void CloseBundle(string bundleName, bool unloadAllLoadedObjects)
		{
		}

		[Address(RVA="0x1419CDC", Offset="0x1419CDC", VA="0x1419CDC")]
		public void EnsureAllBundlesUnloaded()
		{
		}

		[Address(RVA="0x141AB40", Offset="0x141AB40", VA="0x141AB40")]
		private BundleManager.AssetBundleHandle GetBundleHandle(string bundleName)
		{
			return null;
		}

		[Address(RVA="0x1419768", Offset="0x1419768", VA="0x1419768")]
		private string GetBundleUrl(string bundleName)
		{
			return null;
		}

		[Address(RVA="0x141A754", Offset="0x141A754", VA="0x141A754")]
		private BundleManager.AssetBundleHandle.DContext GetHandleContext(string bundleName, Hash128 bundleHash = // 
		// Current member / type: Glunies.BundleManager/AssetBundleHandle/DContext Glunies.BundleManager::GetHandleContext(System.String,UnityEngine.Hash128)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: Glunies.BundleManager/AssetBundleHandle/DContext GetHandleContext(System.String,UnityEngine.Hash128)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x141AEF4", Offset="0x141AEF4", VA="0x141AEF4")]
		private string GetIncludedBundlePath(string bundleName)
		{
			return null;
		}

		[Address(RVA="0x1419BE4", Offset="0x1419BE4", VA="0x1419BE4")]
		private BundleManager.AssetBundleHandle GetIncludedManifestBundleHandle()
		{
			return null;
		}

		[Address(RVA="0x141A65C", Offset="0x141A65C", VA="0x141A65C")]
		private BundleManager.AssetBundleHandle GetManifestBundleHandle()
		{
			return null;
		}

		[Address(RVA="0x141B034", Offset="0x141B034", VA="0x141B034", Slot="6")]
		private bool Glunies.BundleManager.ITest.IsBundleLoaded(string bundleName)
		{
			return new bool();
		}

		[Address(RVA="0x141AF90", Offset="0x141AF90", VA="0x141AF90", Slot="5")]
		private bool Glunies.BundleManager.ITest.IsBundleUnloaded(string bundleName)
		{
			return new bool();
		}

		[Address(RVA="0x141A8D8", Offset="0x141A8D8", VA="0x141A8D8")]
		private void InstallManifest(BundleManager.AssetBundleHandle manifestBundle, Action finished)
		{
		}

		[Address(RVA="0x14194E4", Offset="0x14194E4", VA="0x14194E4")]
		public bool IsBundleDownloaded(string bundleName)
		{
			return new bool();
		}

		[Address(RVA="0x1419640", Offset="0x1419640", VA="0x1419640")]
		private bool IsBundleIncluded(string bundleName, Hash128 bundleHash)
		{
			return new bool();
		}

		[Address(RVA="0x1419918", Offset="0x1419918", VA="0x1419918")]
		public void LoadManifest(string assetUrl, Action<bool> finished)
		{
		}

		[Address(RVA="0x1419ECC", Offset="0x1419ECC", VA="0x1419ECC")]
		public IAsyncRequest OpenBundle(string bundleName, Action<AssetBundle> finished, bool silent = false)
		{
			return null;
		}

		[Address(RVA="0x1419ED4", Offset="0x1419ED4", VA="0x1419ED4")]
		private BundleManager.OpenBundleOperation RequestBundle(string bundleName, Action<AssetBundle> finished, bool silent)
		{
			return null;
		}

		[Address(RVA="0x1419BA4", Offset="0x1419BA4", VA="0x1419BA4")]
		private void SetupBundleCache()
		{
		}

		[Address(RVA="0x14191C8", Offset="0x14191C8", VA="0x14191C8")]
		public void Shutdown()
		{
		}

		[Address(RVA="0x141A338", Offset="0x141A338", VA="0x141A338")]
		public void TickUpdate()
		{
		}

		[Address(RVA="0x1419404", Offset="0x1419404", VA="0x1419404")]
		public void UnloadManifest()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050E28", Offset="0x1050E28")]
		private sealed class <>c__DisplayClass25_0
		{
			[FieldOffset(Offset="0x10")]
			public BundleManager.AssetBundleHandle includedManifestBundle;

			[FieldOffset(Offset="0x18")]
			public BundleManager <>4__this;

			[FieldOffset(Offset="0x20")]
			public string metadataUrl;

			[FieldOffset(Offset="0x28")]
			public Action<bool> finished;

			[Address(RVA="0x1419B9C", Offset="0x1419B9C", VA="0x1419B9C")]
			public <>c__DisplayClass25_0()
			{
			}

			[Address(RVA="0x141B170", Offset="0x141B170", VA="0x141B170")]
			internal void <LoadManifest>b__0(Action executed)
			{
			}

			[Address(RVA="0x141B3DC", Offset="0x141B3DC", VA="0x141B3DC")]
			internal void <LoadManifest>b__1(Action executed)
			{
			}

			[Address(RVA="0x141B790", Offset="0x141B790", VA="0x141B790")]
			internal void <LoadManifest>b__2()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050E38", Offset="0x1050E38")]
		private sealed class <>c__DisplayClass25_1
		{
			[FieldOffset(Offset="0x10")]
			public Action executed;

			[FieldOffset(Offset="0x18")]
			public BundleManager.<>c__DisplayClass25_0 CS$<>8__locals1;

			[Address(RVA="0x141B248", Offset="0x141B248", VA="0x141B248")]
			public <>c__DisplayClass25_1()
			{
			}

			[Address(RVA="0x141B83C", Offset="0x141B83C", VA="0x141B83C")]
			internal void <LoadManifest>b__3()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050E48", Offset="0x1050E48")]
		private sealed class <>c__DisplayClass25_2
		{
			[FieldOffset(Offset="0x10")]
			public Action executed;

			[FieldOffset(Offset="0x18")]
			public BundleManager.<>c__DisplayClass25_0 CS$<>8__locals2;

			[Address(RVA="0x141B504", Offset="0x141B504", VA="0x141B504")]
			public <>c__DisplayClass25_2()
			{
			}

			[Address(RVA="0x141B8A8", Offset="0x141B8A8", VA="0x141B8A8")]
			internal void <LoadManifest>b__4(byte[] data)
			{
			}

			[Address(RVA="0x141BAB8", Offset="0x141BAB8", VA="0x141BAB8")]
			internal void <LoadManifest>b__5(long errorCode, byte[] data)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050E58", Offset="0x1050E58")]
		private sealed class <>c__DisplayClass25_3
		{
			[FieldOffset(Offset="0x10")]
			public BundleManager.AssetBundleHandle manifestBundle;

			[FieldOffset(Offset="0x18")]
			public BundleManager.<>c__DisplayClass25_2 CS$<>8__locals3;

			[Address(RVA="0x141BAB0", Offset="0x141BAB0", VA="0x141BAB0")]
			public <>c__DisplayClass25_3()
			{
			}

			[Address(RVA="0x141BBD0", Offset="0x141BBD0", VA="0x141BBD0")]
			internal void <LoadManifest>b__6()
			{
			}
		}

		private class AssetBundleHandle : ILoggable<LogCategory>
		{
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106CA24", Offset="0x106CA24")]
			[FieldOffset(Offset="0x10")]
			private BundleManager.AssetBundleHandle.State <CurrentState>k__BackingField;

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106CA34", Offset="0x106CA34")]
			[FieldOffset(Offset="0x14")]
			private bool <IsDownloading>k__BackingField;

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106CA44", Offset="0x106CA44")]
			[FieldOffset(Offset="0x18")]
			private AssetBundle <Bundle>k__BackingField;

			[FieldOffset(Offset="0x20")]
			public List<BundleManager.AssetBundleHandle> Dependencies;

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106CA54", Offset="0x106CA54")]
			[FieldOffset(Offset="0x28")]
			private bool <IsSilent>k__BackingField;

			[FieldOffset(Offset="0x30")]
			private BundleManager.AssetBundleHandle.DContext _context;

			[FieldOffset(Offset="0x70")]
			private List<Action> _loadFinishedCallbacks;

			[FieldOffset(Offset="0x78")]
			private bool _unloadAllLoadedObjects;

			[FieldOffset(Offset="0x7C")]
			private int _refCount;

			[FieldOffset(Offset="0x80")]
			private IWebRequestHandle _loadRequest;

			public AssetBundle Bundle
			{
				[Address(RVA="0x141A64C", Offset="0x141A64C", VA="0x141A64C")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E330", Offset="0x108E330")]
				get
				{
					return null;
				}
				[Address(RVA="0x141BC74", Offset="0x141BC74", VA="0x141BC74")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E340", Offset="0x108E340")]
				private set
				{
				}
			}

			public Hash128 BundleHash
			{
				[Address(RVA="0x141BC4C", Offset="0x141BC4C", VA="0x141BC4C")]
				get
				{
					return new Hash128();
				}
			}

			public string BundleName
			{
				[Address(RVA="0x1419EC4", Offset="0x1419EC4", VA="0x1419EC4")]
				get
				{
					return null;
				}
			}

			public string BundlePath
			{
				[Address(RVA="0x141AB30", Offset="0x141AB30", VA="0x141AB30")]
				get
				{
					return null;
				}
			}

			public BundleManager.AssetBundleHandle.State CurrentState
			{
				[Address(RVA="0x1419EBC", Offset="0x1419EBC", VA="0x1419EBC")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E2F0", Offset="0x108E2F0")]
				get
				{
					return new BundleManager.AssetBundleHandle.State();
				}
				[Address(RVA="0x141BC58", Offset="0x141BC58", VA="0x141BC58")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E300", Offset="0x108E300")]
				private set
				{
				}
			}

			public bool IsDownloading
			{
				[Address(RVA="0x141BC60", Offset="0x141BC60", VA="0x141BC60")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E310", Offset="0x108E310")]
				get
				{
					return new bool();
				}
				[Address(RVA="0x141BC68", Offset="0x141BC68", VA="0x141BC68")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E320", Offset="0x108E320")]
				private set
				{
				}
			}

			private bool IsSilent
			{
				[Address(RVA="0x141C0E0", Offset="0x141C0E0", VA="0x141C0E0")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E350", Offset="0x108E350")]
				get
				{
					return new bool();
				}
				[Address(RVA="0x141C074", Offset="0x141C074", VA="0x141C074")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E360", Offset="0x108E360")]
				set
				{
				}
			}

			public LogCategory LogCategory
			{
				[Address(RVA="0x141BC44", Offset="0x141BC44", VA="0x141BC44", Slot="4")]
				get
				{
					return new LogCategory();
				}
			}

			[Address(RVA="0x141A840", Offset="0x141A840", VA="0x141A840")]
			public AssetBundleHandle(BundleManager.AssetBundleHandle.DContext context)
			{
			}

			[Address(RVA="0x141ADD4", Offset="0x141ADD4", VA="0x141ADD4")]
			public AssetBundleHandle(BundleManager.AssetBundleHandle.DContext context, int numDependencies)
			{
			}

			[Address(RVA="0x141C590", Offset="0x141C590", VA="0x141C590")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E370", Offset="0x108E370")]
			private void <LoadBundle>b__29_0(AsyncOperation asyncOp)
			{
			}

			[Address(RVA="0x141AE84", Offset="0x141AE84", VA="0x141AE84")]
			public void AddDependency(BundleManager.AssetBundleHandle handle)
			{
			}

			[Address(RVA="0x141A210", Offset="0x141A210", VA="0x141A210")]
			public void Close(bool unloadAllLoadedObjects)
			{
			}

			[Address(RVA="0x141C24C", Offset="0x141C24C", VA="0x141C24C")]
			private void FinishLoadBundle()
			{
			}

			[Address(RVA="0x141C1A8", Offset="0x141C1A8", VA="0x141C1A8")]
			private bool IsDownloaded()
			{
				return new bool();
			}

			[Address(RVA="0x141BC7C", Offset="0x141BC7C", VA="0x141BC7C")]
			private void LoadBundle()
			{
			}

			[Address(RVA="0x141C450", Offset="0x141C450", VA="0x141C450")]
			private void LoadBundleFailure(long errorCode, byte[] data)
			{
			}

			[Address(RVA="0x141C244", Offset="0x141C244", VA="0x141C244")]
			private void LoadBundleSuccess(AssetBundle bundle)
			{
			}

			[Address(RVA="0x141B250", Offset="0x141B250", VA="0x141B250")]
			public void Open(Action finished, bool silent = false)
			{
			}

			[Address(RVA="0x141BEB4", Offset="0x141BEB4", VA="0x141BEB4")]
			private void ReportDownloadStatus()
			{
			}

			[Address(RVA="0x1419314", Offset="0x1419314", VA="0x1419314")]
			public void Shutdown()
			{
			}

			[Address(RVA="0x141A508", Offset="0x141A508", VA="0x141A508")]
			public void TickUpdate()
			{
			}

			[Address(RVA="0x141C0E8", Offset="0x141C0E8", VA="0x141C0E8")]
			private void UnloadBundle()
			{
			}

			[Address(RVA="0x141C080", Offset="0x141C080", VA="0x141C080")]
			private void UpdateState(BundleManager.AssetBundleHandle.State newState)
			{
			}

			public struct DContext
			{
				[FieldOffset(Offset="0x0")]
				public string BundleName;

				[FieldOffset(Offset="0x8")]
				public string BundlePath;

				[FieldOffset(Offset="0x10")]
				public Hash128 BundleHash;

				[FieldOffset(Offset="0x20")]
				public uint Crc;

				[FieldOffset(Offset="0x24")]
				public bool IsIncluded;

				[FieldOffset(Offset="0x28")]
				public ulong DownloadSizeBytes;

				[FieldOffset(Offset="0x30")]
				public DispatchSystem DispatchSystem;

				[FieldOffset(Offset="0x38")]
				public HttpService HttpService;
			}

			public enum State
			{
				[FieldOffset(Offset="0x0")]
				Unloaded,
				[FieldOffset(Offset="0x0")]
				WaitingForCache,
				[FieldOffset(Offset="0x0")]
				Loading,
				[FieldOffset(Offset="0x0")]
				Loaded
			}
		}

		public interface ITest
		{
			bool IsBundleLoaded(string bundleName);

			bool IsBundleUnloaded(string bundleName);
		}

		private class OpenBundleOperation : AAsyncOperation
		{
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106CA64", Offset="0x106CA64")]
			[FieldOffset(Offset="0x20")]
			private BundleManager.AssetBundleHandle <BundleHandle>k__BackingField;

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106CA74", Offset="0x106CA74")]
			[FieldOffset(Offset="0x28")]
			private Action<AssetBundle> <Finished>k__BackingField;

			[FieldOffset(Offset="0x30")]
			private int _numBundlesOpening;

			public BundleManager.AssetBundleHandle BundleHandle
			{
				[Address(RVA="0x141A644", Offset="0x141A644", VA="0x141A644")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E380", Offset="0x108E380")]
				get
				{
					return null;
				}
				[Address(RVA="0x141C764", Offset="0x141C764", VA="0x141C764")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E390", Offset="0x108E390")]
				private set
				{
				}
			}

			public Action<AssetBundle> Finished
			{
				[Address(RVA="0x141A654", Offset="0x141A654", VA="0x141A654")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E3A0", Offset="0x108E3A0")]
				get
				{
					return null;
				}
				[Address(RVA="0x141C76C", Offset="0x141C76C", VA="0x141C76C")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E3B0", Offset="0x108E3B0")]
				private set
				{
				}
			}

			[Address(RVA="0x141AB38", Offset="0x141AB38", VA="0x141AB38")]
			public OpenBundleOperation()
			{
			}

			[Address(RVA="0x141CD08", Offset="0x141CD08", VA="0x141CD08")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E3C0", Offset="0x108E3C0")]
			private void <OpenBundles>b__12_0()
			{
			}

			[Address(RVA="0x141CD18", Offset="0x141CD18", VA="0x141CD18")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E3D0", Offset="0x108E3D0")]
			private void <OpenBundles>b__12_1()
			{
			}

			[Address(RVA="0x141CA34", Offset="0x141CA34", VA="0x141CA34")]
			private bool AllBundlesLoaded()
			{
				return new bool();
			}

			[Address(RVA="0x141CBA4", Offset="0x141CBA4", VA="0x141CBA4")]
			private void CloseBundles()
			{
			}

			[Address(RVA="0x141CCF8", Offset="0x141CCF8", VA="0x141CCF8", Slot="8")]
			protected override void OnAbort()
			{
			}

			[Address(RVA="0x141C9A4", Offset="0x141C9A4", VA="0x141C9A4", Slot="7")]
			protected override void OnUpdate()
			{
			}

			[Address(RVA="0x141C774", Offset="0x141C774", VA="0x141C774")]
			private void OpenBundles(HttpService httpService, bool silent)
			{
			}

			[Address(RVA="0x141C97C", Offset="0x141C97C", VA="0x141C97C", Slot="6")]
			public override void Shutdown()
			{
			}

			[Address(RVA="0x141ADB8", Offset="0x141ADB8", VA="0x141ADB8")]
			public void StartOperation(BundleManager.AssetBundleHandle bundleHandle, HttpService httpService, bool silent, Action<AssetBundle> finished)
			{
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051688", Offset="0x1051688")]
			[Serializable]
			private sealed class <>c
			{
				[FieldOffset(Offset="0x0")]
				public readonly static BundleManager.OpenBundleOperation.<>c <>9;

				[FieldOffset(Offset="0x8")]
				public static Predicate<BundleManager.AssetBundleHandle> <>9__14_0;

				[Address(RVA="0x141CD28", Offset="0x141CD28", VA="0x141CD28")]
				static <>c()
				{
				}

				[Address(RVA="0x141CD8C", Offset="0x141CD8C", VA="0x141CD8C")]
				public <>c()
				{
				}

				[Address(RVA="0x141CD94", Offset="0x141CD94", VA="0x141CD94")]
				internal bool <AllBundlesLoaded>b__14_0(BundleManager.AssetBundleHandle b)
				{
					return new bool();
				}
			}
		}
	}
}