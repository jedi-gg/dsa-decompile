using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Glunies
{
	public class AssetManager
	{
		[Attribute(Name="InjectAttribute", RVA="0x1063E5C", Offset="0x1063E5C")]
		[FieldOffset(Offset="0x10")]
		private AAssetLoader _assetLoader;

		[Attribute(Name="InjectAttribute", RVA="0x1063E6C", Offset="0x1063E6C")]
		[FieldOffset(Offset="0x18")]
		private IAssetDownloader _assetDownloader;

		[FieldOffset(Offset="0x20")]
		private AsyncOperator<AssetManager.LoadAssetCollectionOp> _loadCollectionOperator;

		[FieldOffset(Offset="0x28")]
		private AssetCollection.Factory _assetCollectionFactory;

		public string DownloadedManifestVersion
		{
			[Address(RVA="0x14FD440", Offset="0x14FD440", VA="0x14FD440")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x14FD500", Offset="0x14FD500", VA="0x14FD500")]
		public AssetManager()
		{
		}

		[Address(RVA="0x14FD868", Offset="0x14FD868", VA="0x14FD868")]
		public void DownloadManifest(string assetUrl, Action<bool> finished)
		{
		}

		[Address(RVA="0x14FDC8C", Offset="0x14FDC8C", VA="0x14FDC8C")]
		public IAsyncRequest GetAssetAsync(string assetId, bool persistent, Action<AssetHandle> finished)
		{
			return null;
		}

		[Address(RVA="0x14FD938", Offset="0x14FD938", VA="0x14FD938")]
		public IAsyncRequest GetAssetCollectionAsync(string[] assetIds, Action<AssetCollection> finished)
		{
			return null;
		}

		[Address(RVA="0x14FD5D4", Offset="0x14FD5D4", VA="0x14FD5D4")]
		public void Initialize()
		{
		}

		[Address(RVA="0x14FE19C", Offset="0x14FE19C", VA="0x14FE19C")]
		private void LoadCollectionFinish(AssetManager.LoadAssetCollectionOp operation)
		{
		}

		[Address(RVA="0x14FD788", Offset="0x14FD788", VA="0x14FD788")]
		public void LoadManifest(string contentUrl, string version, Action<bool> finished)
		{
		}

		[Address(RVA="0x14FE0B8", Offset="0x14FE0B8", VA="0x14FE0B8")]
		public void Lock(Action locked)
		{
		}

		[Address(RVA="0x14FD68C", Offset="0x14FD68C", VA="0x14FD68C")]
		public void Shutdown()
		{
		}

		[Address(RVA="0x14FE13C", Offset="0x14FE13C", VA="0x14FE13C")]
		public void TickUpdate()
		{
		}

		[Address(RVA="0x14FE07C", Offset="0x14FE07C", VA="0x14FE07C")]
		public void UnloadAsset(AssetHandle asset)
		{
		}

		[Address(RVA="0x14FDDB8", Offset="0x14FDDB8", VA="0x14FDDB8")]
		public void UnloadAssets(AssetCollection collection)
		{
		}

		[Address(RVA="0x14FE0EC", Offset="0x14FE0EC", VA="0x14FE0EC")]
		public void Unlock(Action unlocked)
		{
		}

		private class LoadAssetCollectionOp : AAsyncOperation
		{
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106C9E4", Offset="0x106C9E4")]
			[FieldOffset(Offset="0x20")]
			private Action<AssetCollection> <Finished>k__BackingField;

			[FieldOffset(Offset="0x28")]
			private int _numActiveRequests;

			[FieldOffset(Offset="0x30")]
			private List<IAsyncRequest> _loadAssetRequests;

			[FieldOffset(Offset="0x38")]
			private List<AssetHandle> _loadedAssets;

			public Action<AssetCollection> Finished
			{
				[Address(RVA="0x14FE56C", Offset="0x14FE56C", VA="0x14FE56C")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E1CC", Offset="0x108E1CC")]
				get
				{
					return null;
				}
				[Address(RVA="0x14FE574", Offset="0x14FE574", VA="0x14FE574")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E1DC", Offset="0x108E1DC")]
				private set
				{
				}
			}

			[Address(RVA="0x14FDA7C", Offset="0x14FDA7C", VA="0x14FDA7C")]
			public LoadAssetCollectionOp()
			{
			}

			[Address(RVA="0x14FE7BC", Offset="0x14FE7BC", VA="0x14FE7BC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E250", Offset="0x108E250")]
			private void <OnAbort>b__8_0(IAsyncRequest r)
			{
			}

			[Address(RVA="0x14FE4E8", Offset="0x14FE4E8", VA="0x14FE4E8")]
			[Attribute(Name="IteratorStateMachineAttribute", RVA="0x108E1EC", Offset="0x108E1EC")]
			public IEnumerable<AssetHandle> GetAssets()
			{
				return null;
			}

			[Address(RVA="0x14FE7AC", Offset="0x14FE7AC", VA="0x14FE7AC")]
			private void LoadAssetAborted()
			{
			}

			[Address(RVA="0x14FE700", Offset="0x14FE700", VA="0x14FE700")]
			private void LoadAssetFinished(AssetHandle handle)
			{
			}

			[Address(RVA="0x14FE660", Offset="0x14FE660", VA="0x14FE660", Slot="8")]
			protected override void OnAbort()
			{
			}

			[Address(RVA="0x14FE648", Offset="0x14FE648", VA="0x14FE648", Slot="7")]
			protected override void OnUpdate()
			{
			}

			[Address(RVA="0x14FE5B4", Offset="0x14FE5B4", VA="0x14FE5B4", Slot="6")]
			public override void Shutdown()
			{
			}

			[Address(RVA="0x14FDA84", Offset="0x14FDA84", VA="0x14FDA84")]
			public void StartOperation(string[] assetIds, AAssetLoader assetLoader, bool loadFallbacks, Action<AssetCollection> finished)
			{
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051668", Offset="0x1051668")]
			private sealed class <GetAssets>d__4 : IEnumerable<AssetHandle>, IEnumerable, IEnumerator<AssetHandle>, IEnumerator, IDisposable
			{
				[FieldOffset(Offset="0x10")]
				private int <>1__state;

				[FieldOffset(Offset="0x18")]
				private AssetHandle <>2__current;

				[FieldOffset(Offset="0x20")]
				private int <>l__initialThreadId;

				[FieldOffset(Offset="0x28")]
				public AssetManager.LoadAssetCollectionOp <>4__this;

				[FieldOffset(Offset="0x30")]
				private List<AssetHandle>.Enumerator <>7__wrap1;

				private AssetHandle System.Collections.Generic.IEnumerator<Glunies.AssetHandle>.Current
				{
					[Address(RVA="0x14FEA94", Offset="0x14FEA94", VA="0x14FEA94", Slot="6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				private object System.Collections.IEnumerator.Current
				{
					[Address(RVA="0x14FEB04", Offset="0x14FEB04", VA="0x14FEB04", Slot="9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Address(RVA="0x14FE57C", Offset="0x14FE57C", VA="0x14FE57C")]
				[DebuggerHidden]
				public <GetAssets>d__4(int u003cu003e1__state)
				{
				}

				[Address(RVA="0x14FE8C8", Offset="0x14FE8C8", VA="0x14FE8C8")]
				private void <>m__Finally1()
				{
				}

				[Address(RVA="0x14FE920", Offset="0x14FE920", VA="0x14FE920", Slot="8")]
				private bool MoveNext()
				{
					return new bool();
				}

				[Address(RVA="0x14FEB0C", Offset="0x14FEB0C", VA="0x14FEB0C", Slot="4")]
				[DebuggerHidden]
				private IEnumerator<AssetHandle> System.Collections.Generic.IEnumerable<Glunies.AssetHandle>.GetEnumerator()
				{
					return null;
				}

				[Address(RVA="0x14FEBBC", Offset="0x14FEBBC", VA="0x14FEBBC", Slot="5")]
				[DebuggerHidden]
				private IEnumerator System.Collections.IEnumerable.GetEnumerator()
				{
					return null;
				}

				[Address(RVA="0x14FEA9C", Offset="0x14FEA9C", VA="0x14FEA9C", Slot="10")]
				[DebuggerHidden]
				private void System.Collections.IEnumerator.Reset()
				{
				}

				[Address(RVA="0x14FE8AC", Offset="0x14FE8AC", VA="0x14FE8AC", Slot="7")]
				[DebuggerHidden]
				private void System.IDisposable.Dispose()
				{
				}
			}
		}
	}
}