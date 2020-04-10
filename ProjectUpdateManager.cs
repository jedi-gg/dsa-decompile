using Glunies;
using Il2CppDummyDll;
using System;
using Zenject;

public class ProjectUpdateManager : ITickable
{
	[Attribute(Name="InjectOptionalAttribute", RVA="0x105FA20", Offset="0x105FA20")]
	[FieldOffset(Offset="0x10")]
	private BundleManager _bundleManager;

	[Attribute(Name="InjectAttribute", RVA="0x105FA30", Offset="0x105FA30")]
	[FieldOffset(Offset="0x18")]
	private AAssetLoader _assetLoader;

	[Attribute(Name="InjectAttribute", RVA="0x105FA40", Offset="0x105FA40")]
	[FieldOffset(Offset="0x20")]
	private AssetManager _assetManager;

	[Attribute(Name="InjectAttribute", RVA="0x105FA50", Offset="0x105FA50")]
	[FieldOffset(Offset="0x28")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x105FA60", Offset="0x105FA60")]
	[FieldOffset(Offset="0x30")]
	private Procrastinator _procrastinator;

	[Attribute(Name="InjectAttribute", RVA="0x105FA70", Offset="0x105FA70")]
	[FieldOffset(Offset="0x38")]
	private IAssetDownloader _assetDownloader;

	[Address(RVA="0x127F278", Offset="0x127F278", VA="0x127F278")]
	public ProjectUpdateManager()
	{
	}

	[Address(RVA="0x127F140", Offset="0x127F140", VA="0x127F140", Slot="4")]
	public void Tick()
	{
	}
}