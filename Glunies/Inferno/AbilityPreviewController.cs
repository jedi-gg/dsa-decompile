using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Glunies.Inferno
{
	public class AbilityPreviewController : AInfernoController, IDispatchHandler<DAbilityPreviewMenuViewAction>, IDispatchHandler, IDispatchHandler<DUnitAssetAction>
	{
		[FieldOffset(Offset="0x0")]
		private const string SHARED_UNIT_BUNDLE_NAME = "unit__shared";

		[Attribute(Name="InjectAttribute", RVA="0x1064714", Offset="0x1064714")]
		[FieldOffset(Offset="0x28")]
		private DispatchSystem _dispatchSystem;

		[Attribute(Name="InjectAttribute", RVA="0x1064724", Offset="0x1064724")]
		[FieldOffset(Offset="0x30")]
		private AssetIdCache _assetIdCache;

		[Attribute(Name="InjectAttribute", RVA="0x1064734", Offset="0x1064734")]
		[FieldOffset(Offset="0x38")]
		private AssetManifestController _assetManifest;

		[Attribute(Name="InjectAttribute", RVA="0x1064744", Offset="0x1064744")]
		[FieldOffset(Offset="0x40")]
		private SingleAssetRegistry _unitAssetRegistry;

		[Attribute(Name="InjectAttribute", RVA="0x1064788", Offset="0x1064788")]
		[FieldOffset(Offset="0x48")]
		private SingleAssetRegistry _previewAssetRegistry;

		[Attribute(Name="InjectAttribute", RVA="0x1064798", Offset="0x1064798")]
		[FieldOffset(Offset="0x50")]
		private EffectVisualPlayer _effectVisualPlayer;

		[FieldOffset(Offset="0x58")]
		private List<string> _cachedpreviewAssetIds;

		[FieldOffset(Offset="0x60")]
		private AbilityPreview _loadedPreview;

		[FieldOffset(Offset="0x68")]
		private string _loadedPreviewAssetId;

		private AbilityPreviewView PreviewView
		{
			[Address(RVA="0x142DBB8", Offset="0x142DBB8", VA="0x142DBB8")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x142E098", Offset="0x142E098", VA="0x142E098")]
		public AbilityPreviewController()
		{
		}

		[Address(RVA="0x142DC3C", Offset="0x142DC3C", VA="0x142DC3C")]
		private List<string> CollectSimAssetIds(string unitBundleName)
		{
			return null;
		}

		[Address(RVA="0x142D7FC", Offset="0x142D7FC", VA="0x142D7FC", Slot="7")]
		public void HandleDispatchAction(DAbilityPreviewMenuViewAction action)
		{
		}

		[Address(RVA="0x142DAC4", Offset="0x142DAC4", VA="0x142DAC4", Slot="8")]
		public void HandleDispatchAction(DUnitAssetAction action)
		{
		}

		[Address(RVA="0x142D4F8", Offset="0x142D4F8", VA="0x142D4F8", Slot="4")]
		public override void Initialize(Action finished)
		{
		}

		[Address(RVA="0x142D88C", Offset="0x142D88C", VA="0x142D88C")]
		private void LoadPreview(string previewAssetId)
		{
		}

		[Address(RVA="0x142D9D0", Offset="0x142D9D0", VA="0x142D9D0")]
		private void PreviewAbility(float? interruptAtS)
		{
		}

		[Address(RVA="0x142D5E0", Offset="0x142D5E0", VA="0x142D5E0", Slot="5")]
		public override void Shutdown()
		{
		}

		[Address(RVA="0x142D764", Offset="0x142D764", VA="0x142D764", Slot="6")]
		public override void TickUpdate()
		{
		}

		[Address(RVA="0x142D670", Offset="0x142D670", VA="0x142D670")]
		private void UnloadPreview(bool updateView = false)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051188", Offset="0x1051188")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset="0x10")]
			public Action finished;

			[Address(RVA="0x142D5D8", Offset="0x142D5D8", VA="0x142D5D8")]
			public <>c__DisplayClass0_0()
			{
			}

			[Address(RVA="0x142E108", Offset="0x142E108", VA="0x142E108")]
			internal void <Initialize>b__0(AbilityPreviewView view)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051198", Offset="0x1051198")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x10")]
			public AbilityPreviewController <>4__this;

			[FieldOffset(Offset="0x18")]
			public string previewAssetId;

			[Address(RVA="0x142E090", Offset="0x142E090", VA="0x142E090")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x142E138", Offset="0x142E138", VA="0x142E138")]
			internal void <LoadPreview>b__0(AssetHandle handle)
			{
			}
		}
	}
}