using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using Zenject;

public class FetchContentJob : IJob, ILoggable<LogCategory>
{
	[FieldOffset(Offset="0x0")]
	public static FetchableContent s_forceFetch;

	[FieldOffset(Offset="0x10")]
	public FetchContentJob.FetchResult LastFetchResult;

	[Attribute(Name="InjectAttribute", RVA="0x1057598", Offset="0x1057598")]
	[FieldOffset(Offset="0x18")]
	private DiContainer _container;

	[Attribute(Name="InjectAttribute", RVA="0x10575A8", Offset="0x10575A8")]
	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x10575B8", Offset="0x10575B8")]
	[FieldOffset(Offset="0x28")]
	private AssetManager _assetManager;

	[Attribute(Name="InjectAttribute", RVA="0x10575C8", Offset="0x10575C8")]
	[FieldOffset(Offset="0x30")]
	private IAssetDependentInitializer _assetDependentInitializer;

	[Attribute(Name="InjectAttribute", RVA="0x10575D8", Offset="0x10575D8")]
	[FieldOffset(Offset="0x38")]
	private IAssetDownloader _assetDownloader;

	public LogCategory LogCategory
	{
		[Address(RVA="0x12C61D0", Offset="0x12C61D0", VA="0x12C61D0", Slot="5")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x12C63E4", Offset="0x12C63E4", VA="0x12C63E4")]
	public FetchContentJob()
	{
	}

	[Address(RVA="0x12C61D8", Offset="0x12C61D8", VA="0x12C61D8", Slot="4")]
	public void Execute(Action executed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BBFC", Offset="0x104BBFC")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public FetchContentJob <>4__this;

		[FieldOffset(Offset="0x18")]
		public FetchContentJob.DownloadUpdatesJob downloadUpdatesJob;

		[Address(RVA="0x12C63DC", Offset="0x12C63DC", VA="0x12C63DC")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x12C63EC", Offset="0x12C63EC", VA="0x12C63EC")]
		internal void <Execute>b__0(Action jobFinished)
		{
		}
	}

	private class DownloadUpdatesJob : IJob
	{
		[FieldOffset(Offset="0x10")]
		public FetchContentJob.FetchResult LastFetchResult;

		[Attribute(Name="InjectAttribute", RVA="0x106A2F4", Offset="0x106A2F4")]
		[FieldOffset(Offset="0x18")]
		private Core _coreService;

		[Attribute(Name="InjectAttribute", RVA="0x106A304", Offset="0x106A304")]
		[FieldOffset(Offset="0x20")]
		private GamedataManager _gamedataManager;

		[Attribute(Name="InjectAttribute", RVA="0x106A314", Offset="0x106A314")]
		[FieldOffset(Offset="0x28")]
		private LocalizationManager _localizationManager;

		[Attribute(Name="InjectAttribute", RVA="0x106A324", Offset="0x106A324")]
		[FieldOffset(Offset="0x30")]
		private AssetManager _assetManager;

		[Attribute(Name="InjectAttribute", RVA="0x106A334", Offset="0x106A334")]
		[FieldOffset(Offset="0x38")]
		private IAssetDependentInitializer _assetDependentInitializer;

		[Attribute(Name="InjectAttribute", RVA="0x106A344", Offset="0x106A344")]
		[FieldOffset(Offset="0x40")]
		private DispatchSystem _dispatch;

		[FieldOffset(Offset="0x48")]
		private MetadataResponse _metadata;

		[Address(RVA="0x12C713C", Offset="0x12C713C", VA="0x12C713C")]
		public DownloadUpdatesJob()
		{
		}

		[Address(RVA="0x12C6850", Offset="0x12C6850", VA="0x12C6850", Slot="4")]
		public void Execute(Action executed)
		{
		}

		[Address(RVA="0x12C6EB0", Offset="0x12C6EB0", VA="0x12C6EB0")]
		private void FetchAssetManifestJob(Action jobFinished)
		{
		}

		[Address(RVA="0x12C6B48", Offset="0x12C6B48", VA="0x12C6B48")]
		private void FetchGamedataJob(Action jobFinished)
		{
		}

		[Address(RVA="0x12C6CFC", Offset="0x12C6CFC", VA="0x12C6CFC")]
		private void FetchLocalizationJob(Action jobFinished)
		{
		}

		[Address(RVA="0x12C6A64", Offset="0x12C6A64", VA="0x12C6A64")]
		private Serverproto.DeviceInfo GetDeviceInfo()
		{
			return null;
		}

		[Address(RVA="0x12C6B38", Offset="0x12C6B38", VA="0x12C6B38")]
		private void HandleLoadResult(FetchContentJob.FetchResult loadResult)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051538", Offset="0x1051538")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FetchContentJob.DownloadUpdatesJob.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<bool> <>9__1_2;

			[Address(RVA="0x12C7144", Offset="0x12C7144", VA="0x12C7144")]
			static <>c()
			{
			}

			[Address(RVA="0x12C71A8", Offset="0x12C71A8", VA="0x12C71A8")]
			public <>c()
			{
			}

			[Address(RVA="0x12C71B0", Offset="0x12C71B0", VA="0x12C71B0")]
			internal bool <Execute>b__1_2()
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051528", Offset="0x1051528")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset="0x10")]
			public FetchContentJob.DownloadUpdatesJob <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action executed;

			[Address(RVA="0x12C6A5C", Offset="0x12C6A5C", VA="0x12C6A5C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Address(RVA="0x12C71B8", Offset="0x12C71B8", VA="0x12C71B8")]
			internal void <Execute>b__0(MetadataResponse response)
			{
			}

			[Address(RVA="0x12C7344", Offset="0x12C7344", VA="0x12C7344")]
			internal void <Execute>b__1(long errorCode)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051548", Offset="0x1051548")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset="0x10")]
			public FetchContentJob.DownloadUpdatesJob <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action jobFinished;

			[Address(RVA="0x12C6CF4", Offset="0x12C6CF4", VA="0x12C6CF4")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x12C7468", Offset="0x12C7468", VA="0x12C7468")]
			internal void <FetchGamedataJob>b__0(FetchContentJob.FetchResult result)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051558", Offset="0x1051558")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x10")]
			public FetchContentJob.DownloadUpdatesJob <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action jobFinished;

			[Address(RVA="0x12C6EA8", Offset="0x12C6EA8", VA="0x12C6EA8")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x12C7588", Offset="0x12C7588", VA="0x12C7588")]
			internal void <FetchLocalizationJob>b__0(FetchContentJob.FetchResult result)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051568", Offset="0x1051568")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset="0x10")]
			public FetchContentJob.DownloadUpdatesJob <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action jobFinished;

			[Address(RVA="0x12C7134", Offset="0x12C7134", VA="0x12C7134")]
			public <>c__DisplayClass6_0()
			{
			}

			[Address(RVA="0x12C779C", Offset="0x12C779C", VA="0x12C779C")]
			internal void <FetchAssetManifestJob>b__0(bool success)
			{
			}
		}
	}

	[Flags]
	public enum FetchResult
	{
		[FieldOffset(Offset="0x0")]
		AlreadyUpToDate = 0,
		[FieldOffset(Offset="0x0")]
		Error = 1,
		[FieldOffset(Offset="0x0")]
		InvalidClientVersion = 2,
		[FieldOffset(Offset="0x0")]
		NewGamedata = 4,
		[FieldOffset(Offset="0x0")]
		NewLocalization = 8,
		[FieldOffset(Offset="0x0")]
		NewAssets = 16
	}
}