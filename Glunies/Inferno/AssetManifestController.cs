using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Glunies.Inferno
{
	public class AssetManifestController
	{
		[FieldOffset(Offset="0x0")]
		private const string ASSET_MANIFEST_ID = "asset_manifest/AssetManifest";

		[FieldOffset(Offset="0x0")]
		private const string EFFECT_VISUAL_ASSET_KEY = "effect";

		[FieldOffset(Offset="0x0")]
		private const string UNIT_ASSET_KEY = "unit";

		[FieldOffset(Offset="0x0")]
		private const string ENVIRONMENT_ASSET_KEY = "environment";

		[FieldOffset(Offset="0x0")]
		private const string ABILITY_PREVIEW_ASSET_KEY = "ability_preview";

		[Attribute(Name="InjectAttribute", RVA="0x10647D8", Offset="0x10647D8")]
		[FieldOffset(Offset="0x10")]
		private AssetRegistry _assetRegistry;

		[FieldOffset(Offset="0x18")]
		private AssetManifest _assetManifest;

		[Address(RVA="0x151C6FC", Offset="0x151C6FC", VA="0x151C6FC")]
		public AssetManifestController()
		{
		}

		[Address(RVA="0x151C698", Offset="0x151C698", VA="0x151C698")]
		public List<string> GetAbilityPreviewAssetIds()
		{
			return null;
		}

		[Address(RVA="0x151C5D0", Offset="0x151C5D0", VA="0x151C5D0")]
		public List<string> GetEffectVisualAssetIds()
		{
			return null;
		}

		[Address(RVA="0x151C634", Offset="0x151C634", VA="0x151C634")]
		public List<string> GetEnvironmentAssetIds()
		{
			return null;
		}

		[Address(RVA="0x151C56C", Offset="0x151C56C", VA="0x151C56C")]
		public List<string> GetUnitAssetIds()
		{
			return null;
		}

		[Address(RVA="0x151C440", Offset="0x151C440", VA="0x151C440")]
		public void LoadManifest(Action finished)
		{
		}

		[Address(RVA="0x151C538", Offset="0x151C538", VA="0x151C538")]
		public void Shutdown()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10511A8", Offset="0x10511A8")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x10")]
			public AssetManifestController <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action finished;

			[Address(RVA="0x151C530", Offset="0x151C530", VA="0x151C530")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x151C704", Offset="0x151C704", VA="0x151C704")]
			internal void <LoadManifest>b__0(AssetHandle handle)
			{
			}
		}
	}
}