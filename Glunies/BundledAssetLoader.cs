using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Glunies
{
	public class BundledAssetLoader : AAssetLoader
	{
		[Attribute(Name="InjectAttribute", RVA="0x1063EDC", Offset="0x1063EDC")]
		[FieldOffset(Offset="0x40")]
		private BundleManager _bundleManager;

		[FieldOffset(Offset="0x48")]
		private AsyncOperator<BundledAssetLoader.AssetLoadOp> _loadAssetOperator;

		protected override int NumActiveRequests
		{
			[Address(RVA="0x1420078", Offset="0x1420078", VA="0x1420078", Slot="9")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x141F520", Offset="0x141F520", VA="0x141F520")]
		public BundledAssetLoader()
		{
		}

		[Address(RVA="0x141F640", Offset="0x141F640", VA="0x141F640", Slot="6")]
		public override IAsyncRequest LoadAssetAsync(string assetId, bool persistent, Action<AssetHandle> finished)
		{
			return null;
		}

		[Address(RVA="0x141FAC8", Offset="0x141FAC8", VA="0x141FAC8")]
		private void LoadAssetOpFinished(BundledAssetLoader.AssetLoadOp operation)
		{
		}

		[Address(RVA="0x141F784", Offset="0x141F784", VA="0x141F784")]
		private void RequestAsset(AssetLoadRequest request)
		{
		}

		[Address(RVA="0x141F5D4", Offset="0x141F5D4", VA="0x141F5D4", Slot="5")]
		public override void Shutdown()
		{
		}

		[Address(RVA="0x141FA5C", Offset="0x141FA5C", VA="0x141FA5C", Slot="8")]
		public override void TickUpdate()
		{
		}

		[Address(RVA="0x141F89C", Offset="0x141F89C", VA="0x141F89C", Slot="7")]
		public override void UnloadAsset(AssetHandle assetHandle)
		{
		}

		private class AssetLoadOp : AAsyncOperation
		{
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106C9F4", Offset="0x106C9F4")]
			[FieldOffset(Offset="0x20")]
			private AssetLoadRequest <Request>k__BackingField;

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106CA04", Offset="0x106CA04")]
			[FieldOffset(Offset="0x28")]
			private AssetBundle <Bundle>k__BackingField;

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106CA14", Offset="0x106CA14")]
			[FieldOffset(Offset="0x30")]
			private Scene? <Scene>k__BackingField;

			[FieldOffset(Offset="0x38")]
			private IAsyncRequest _bundleRequest;

			[FieldOffset(Offset="0x40")]
			private AsyncOperation _assetRequest;

			[FieldOffset(Offset="0x48")]
			private UnityEngine.Object _asset;

			[FieldOffset(Offset="0x50")]
			private Procrastinator _procrastinator;

			public UnityEngine.Object Asset
			{
				[Address(RVA="0x141FE54", Offset="0x141FE54", VA="0x141FE54")]
				get
				{
					return null;
				}
			}

			public AssetId AssetId
			{
				[Address(RVA="0x141FE14", Offset="0x141FE14", VA="0x141FE14")]
				get
				{
					return null;
				}
			}

			public AssetBundle Bundle
			{
				[Address(RVA="0x141FE0C", Offset="0x141FE0C", VA="0x141FE0C")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E2A0", Offset="0x108E2A0")]
				get
				{
					return null;
				}
				[Address(RVA="0x14200F8", Offset="0x14200F8", VA="0x14200F8")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E2B0", Offset="0x108E2B0")]
				private set
				{
				}
			}

			public bool Persistent
			{
				[Address(RVA="0x141FF40", Offset="0x141FF40", VA="0x141FF40")]
				get
				{
					return new bool();
				}
			}

			public AssetLoadRequest Request
			{
				[Address(RVA="0x141FE44", Offset="0x141FE44", VA="0x141FE44")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E280", Offset="0x108E280")]
				get
				{
					return null;
				}
				[Address(RVA="0x14200F0", Offset="0x14200F0", VA="0x14200F0")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E290", Offset="0x108E290")]
				private set
				{
				}
			}

			public Scene? Scene
			{
				[Address(RVA="0x141FE4C", Offset="0x141FE4C", VA="0x141FE4C")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E2C0", Offset="0x108E2C0")]
				get
				{
					return null;
				}
				[Address(RVA="0x1420100", Offset="0x1420100", VA="0x1420100")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E2D0", Offset="0x108E2D0")]
				private set
				{
				}
			}

			[Address(RVA="0x141FF70", Offset="0x141FF70", VA="0x141FF70")]
			public AssetLoadOp(AssetLoadRequest request)
			{
			}

			[Address(RVA="0x142084C", Offset="0x142084C", VA="0x142084C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E2E0", Offset="0x108E2E0")]
			private void <RequestAssetSync>b__26_0()
			{
			}

			[Address(RVA="0x1420660", Offset="0x1420660", VA="0x1420660")]
			private void BundleLoadAborted()
			{
			}

			[Address(RVA="0x1420434", Offset="0x1420434", VA="0x1420434")]
			private void BundleLoaded(AssetBundle bundle)
			{
			}

			[Address(RVA="0x142033C", Offset="0x142033C", VA="0x142033C", Slot="8")]
			protected override void OnAbort()
			{
			}

			[Address(RVA="0x142013C", Offset="0x142013C", VA="0x142013C", Slot="7")]
			protected override void OnUpdate()
			{
			}

			[Address(RVA="0x14204DC", Offset="0x14204DC", VA="0x14204DC")]
			private void RequestAsset()
			{
			}

			[Address(RVA="0x1420670", Offset="0x1420670", VA="0x1420670")]
			private void RequestAssetSync()
			{
			}

			[Address(RVA="0x1420108", Offset="0x1420108", VA="0x1420108", Slot="6")]
			public override void Shutdown()
			{
			}

			[Address(RVA="0x141FFB4", Offset="0x141FFB4", VA="0x141FFB4")]
			public void StartOperation(BundleManager bundleManager, Procrastinator procrastinator)
			{
			}
		}
	}
}