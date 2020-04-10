using Il2CppDummyDll;
using System;
using UnityEngine.SceneManagement;

namespace Glunies
{
	public class SingleAssetRegistry : ILoggable<LogCategory>, IAssetGetter
	{
		[FieldOffset(Offset="0x10")]
		private IAsyncRequest _activeRequest;

		[FieldOffset(Offset="0x18")]
		private AssetHandle _loadedAsset;

		[FieldOffset(Offset="0x20")]
		private Action<AssetHandle> _delayedFinish;

		[Attribute(Name="InjectAttribute", RVA="0x1063F5C", Offset="0x1063F5C")]
		[FieldOffset(Offset="0x28")]
		private AssetManager _assetManager;

		[Attribute(Name="InjectAttribute", RVA="0x1063F6C", Offset="0x1063F6C")]
		[FieldOffset(Offset="0x30")]
		private Procrastinator _procrastinator;

		public LogCategory LogCategory
		{
			[Address(RVA="0x16144FC", Offset="0x16144FC", VA="0x16144FC", Slot="4")]
			get
			{
				return new LogCategory();
			}
		}

		[Address(RVA="0x1614840", Offset="0x1614840", VA="0x1614840")]
		public SingleAssetRegistry()
		{
		}

		[Address(RVA="0x16147C4", Offset="0x16147C4", VA="0x16147C4")]
		private void AssetLoaded(AssetHandle asset, Action<AssetHandle> finished)
		{
		}

		[Address(RVA="0x1614504", Offset="0x1614504", VA="0x1614504", Slot="5")]
		public void GetAsset(string assetId, bool persistent, Action<AssetHandle> finished)
		{
		}

		[Address(RVA="0x16A9B48", Offset="0x16A9B48", VA="0x16A9B48")]
		public T GetLoadedAsset<T>()
		where T : Object
		{
			return null;
		}

		[Address(RVA="0x16147B0", Offset="0x16147B0", VA="0x16147B0")]
		public Scene? GetScene()
		{
			return null;
		}

		[Address(RVA="0x16146BC", Offset="0x16146BC", VA="0x16146BC")]
		public void Unload()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050E68", Offset="0x1050E68")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x10")]
			public SingleAssetRegistry <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action<AssetHandle> finished;

			[Address(RVA="0x16146B4", Offset="0x16146B4", VA="0x16146B4")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x1614848", Offset="0x1614848", VA="0x1614848")]
			internal void <GetAsset>b__0()
			{
			}

			[Address(RVA="0x16148D0", Offset="0x16148D0", VA="0x16148D0")]
			internal void <GetAsset>b__1(AssetHandle asset)
			{
			}
		}
	}
}