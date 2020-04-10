using Glunies;
using Il2CppDummyDll;
using System;

namespace Glunies.Inferno
{
	public class DownloadManifestJob : IJob
	{
		[FieldOffset(Offset="0x0")]
		private const string ASSET_URL_PLAYER_PREF_KEY = "inferno-asset-url";

		[FieldOffset(Offset="0x10")]
		private bool _useEditorAssets;

		[FieldOffset(Offset="0x18")]
		private AssetManager _assetManager;

		[FieldOffset(Offset="0x20")]
		private Action _executed;

		[FieldOffset(Offset="0x28")]
		private AssetUrlForm _form;

		[Address(RVA="0x151F130", Offset="0x151F130", VA="0x151F130")]
		public DownloadManifestJob(AssetManager assetManager, bool useEditorAssets)
		{
		}

		[Address(RVA="0x1520824", Offset="0x1520824", VA="0x1520824")]
		private void CreateForm()
		{
		}

		[Address(RVA="0x15206E4", Offset="0x15206E4", VA="0x15206E4")]
		private void DownloadManifest(string assetUrl)
		{
		}

		[Address(RVA="0x1520638", Offset="0x1520638", VA="0x1520638", Slot="4")]
		public void Execute(Action executed)
		{
		}

		[Address(RVA="0x1520904", Offset="0x1520904", VA="0x1520904")]
		private void FinishExecution()
		{
		}

		[Address(RVA="0x1520A08", Offset="0x1520A08", VA="0x1520A08")]
		private AssetUrlForm GetForm()
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10511C8", Offset="0x10511C8")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x10")]
			public string assetUrl;

			[FieldOffset(Offset="0x18")]
			public DownloadManifestJob <>4__this;

			[Address(RVA="0x15208FC", Offset="0x15208FC", VA="0x15208FC")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x1520A8C", Offset="0x1520A8C", VA="0x1520A8C")]
			internal void <DownloadManifest>b__0(bool success)
			{
			}
		}
	}
}