using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Glunies
{
	public class AssetRegistry : ILoggable<LogCategory>, IAssetGetter
	{
		[FieldOffset(Offset="0x10")]
		private List<IAsyncRequest> _activeRequests;

		[FieldOffset(Offset="0x18")]
		private List<AssetHandle> _loadedAssets;

		[Attribute(Name="InjectAttribute", RVA="0x1063E8C", Offset="0x1063E8C")]
		[FieldOffset(Offset="0x20")]
		private AssetManager _assetManager;

		public bool HasActiveRequest
		{
			[Address(RVA="0x14FED98", Offset="0x14FED98", VA="0x14FED98")]
			get
			{
				return new bool();
			}
		}

		public LogCategory LogCategory
		{
			[Address(RVA="0x14FED90", Offset="0x14FED90", VA="0x14FED90", Slot="4")]
			get
			{
				return new LogCategory();
			}
		}

		[Address(RVA="0x14FF22C", Offset="0x14FF22C", VA="0x14FF22C")]
		public AssetRegistry()
		{
		}

		[Address(RVA="0x14FF2C4", Offset="0x14FF2C4", VA="0x14FF2C4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A1A4", Offset="0x108A1A4")]
		private void <Unload>b__6_0(AssetHandle a)
		{
		}

		[Address(RVA="0x14FF13C", Offset="0x14FF13C", VA="0x14FF13C")]
		private void AssetCollectionLoaded(IAsyncRequest request, AssetCollection collection, Action<AssetCollection> finished)
		{
		}

		[Address(RVA="0x14FF060", Offset="0x14FF060", VA="0x14FF060")]
		private void AssetLoaded(IAsyncRequest request, AssetHandle asset, Action<AssetHandle> finished)
		{
		}

		[Address(RVA="0x14F7794", Offset="0x14F7794", VA="0x14F7794", Slot="5")]
		public void GetAsset(string assetId, bool persistent, Action<AssetHandle> finished)
		{
		}

		[Address(RVA="0x14FEE0C", Offset="0x14FEE0C", VA="0x14FEE0C")]
		public void GetAssets(string[] assetIds, Action<AssetCollection> finished)
		{
		}

		[Address(RVA="0x14F7D0C", Offset="0x14F7D0C", VA="0x14F7D0C")]
		public void Unload()
		{
		}

		[Address(RVA="0x14FEF44", Offset="0x14FEF44", VA="0x14FEF44")]
		public bool UnloadHandle(AssetHandle handle)
		{
			return new bool();
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050DE8", Offset="0x1050DE8")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset="0x10")]
			public AssetRegistry <>4__this;

			[FieldOffset(Offset="0x18")]
			public IAsyncRequest loadRequest;

			[FieldOffset(Offset="0x20")]
			public Action<AssetHandle> finished;

			[Address(RVA="0x14FEE04", Offset="0x14FEE04", VA="0x14FEE04")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x14FF310", Offset="0x14FF310", VA="0x14FF310")]
			internal void <GetAsset>b__0(AssetHandle asset)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050DF8", Offset="0x1050DF8")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x10")]
			public AssetRegistry <>4__this;

			[FieldOffset(Offset="0x18")]
			public IAsyncRequest loadRequest;

			[FieldOffset(Offset="0x20")]
			public Action<AssetCollection> finished;

			[Address(RVA="0x14FEF3C", Offset="0x14FEF3C", VA="0x14FEF3C")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x14FF358", Offset="0x14FF358", VA="0x14FF358")]
			internal void <GetAssets>b__0(AssetCollection collection)
			{
			}
		}
	}
}