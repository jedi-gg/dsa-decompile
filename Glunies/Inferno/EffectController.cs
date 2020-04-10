using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Inferno
{
	public class EffectController : AInfernoController, IDispatchHandler<DEffectMenuViewAction>, IDispatchHandler, IDispatchHandler<DUnitAssetAction>
	{
		[FieldOffset(Offset="0x0")]
		private const string TARGET_ASSET_ID = "prefabs/Target";

		[Attribute(Name="InjectAttribute", RVA="0x10648C8", Offset="0x10648C8")]
		[FieldOffset(Offset="0x28")]
		private DispatchSystem _dispatchSystem;

		[Attribute(Name="InjectAttribute", RVA="0x10648D8", Offset="0x10648D8")]
		[FieldOffset(Offset="0x30")]
		private SingleAssetRegistry _targetAssetRegistry;

		[Attribute(Name="InjectAttribute", RVA="0x10648E8", Offset="0x10648E8")]
		[FieldOffset(Offset="0x38")]
		private SingleAssetRegistry _unitAssetRegistry;

		[Attribute(Name="InjectAttribute", RVA="0x106492C", Offset="0x106492C")]
		[FieldOffset(Offset="0x40")]
		private AssetIdCache _assetIdCache;

		[Attribute(Name="InjectAttribute", RVA="0x106493C", Offset="0x106493C")]
		[FieldOffset(Offset="0x48")]
		private AssetManifestController _assetManifest;

		[Attribute(Name="InjectAttribute", RVA="0x106494C", Offset="0x106494C")]
		[FieldOffset(Offset="0x50")]
		private EffectVisualPlayer _visualManager;

		[FieldOffset(Offset="0x58")]
		private GameObject _target;

		[FieldOffset(Offset="0x60")]
		private List<string> _cachedEffectAssetIds;

		private Glunies.Inferno.EffectView EffectView
		{
			[Address(RVA="0x1520F6C", Offset="0x1520F6C", VA="0x1520F6C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1521BA0", Offset="0x1521BA0", VA="0x1521BA0")]
		public EffectController()
		{
		}

		[Address(RVA="0x1521C10", Offset="0x1521C10", VA="0x1521C10")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A7E0", Offset="0x108A7E0")]
		private void <CreateTarget>b__8_0(AssetHandle assetHandle)
		{
		}

		[Address(RVA="0x15214F4", Offset="0x15214F4", VA="0x15214F4")]
		private List<string> CollectEffectAssetIds(string unitBundleName)
		{
			return null;
		}

		[Address(RVA="0x1521308", Offset="0x1521308", VA="0x1521308")]
		private void CreateTarget()
		{
		}

		[Address(RVA="0x15213D0", Offset="0x15213D0", VA="0x15213D0")]
		private void DestroyTarget()
		{
		}

		[Address(RVA="0x152116C", Offset="0x152116C", VA="0x152116C", Slot="7")]
		public void HandleDispatchAction(DEffectMenuViewAction action)
		{
		}

		[Address(RVA="0x1521424", Offset="0x1521424", VA="0x1521424", Slot="8")]
		public void HandleDispatchAction(DUnitAssetAction action)
		{
		}

		[Address(RVA="0x1520BA8", Offset="0x1520BA8", VA="0x1520BA8", Slot="4")]
		public override void Initialize(Action finished)
		{
		}

		[Address(RVA="0x15211AC", Offset="0x15211AC", VA="0x15211AC")]
		private void PlayEffectVisual(string assetId, float expireTime)
		{
		}

		[Address(RVA="0x1520C94", Offset="0x1520C94", VA="0x1520C94", Slot="5")]
		public override void Shutdown()
		{
		}

		[Address(RVA="0x15212DC", Offset="0x15212DC", VA="0x15212DC")]
		private void StopEffectVisual()
		{
		}

		[Address(RVA="0x1520CF4", Offset="0x1520CF4", VA="0x1520CF4", Slot="6")]
		public override void TickUpdate()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10511E8", Offset="0x10511E8")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset="0x10")]
			public Action finished;

			[Address(RVA="0x1520C8C", Offset="0x1520C8C", VA="0x1520C8C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Address(RVA="0x1521C80", Offset="0x1521C80", VA="0x1521C80")]
			internal void <Initialize>b__0(Glunies.Inferno.EffectView view)
			{
			}
		}
	}
}