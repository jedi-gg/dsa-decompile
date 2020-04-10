using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using System;
using Zenject;

namespace Glunies.Inferno
{
	public class Bootstrapper : IInitializable, IDisposable
	{
		[Attribute(Name="InjectAttribute", RVA="0x10647E8", Offset="0x10647E8")]
		[FieldOffset(Offset="0x10")]
		private DiContainer _infernoContainer;

		[Attribute(Name="InjectAttribute", RVA="0x10647F8", Offset="0x10647F8")]
		[FieldOffset(Offset="0x18")]
		private AssetManager _assetManager;

		[Attribute(Name="InjectAttribute", RVA="0x1064808", Offset="0x1064808")]
		[FieldOffset(Offset="0x20")]
		private AssetManifestController _assetManifestController;

		[Attribute(Name="InjectAttribute", RVA="0x1064818", Offset="0x1064818")]
		[FieldOffset(Offset="0x28")]
		private DispatchSystem _dispatchSystem;

		[Attribute(Name="InjectAttribute", RVA="0x1064828", Offset="0x1064828")]
		[FieldOffset(Offset="0x30")]
		private InputSystem _inputSystem;

		[Attribute(Name="InjectAttribute", RVA="0x1064838", Offset="0x1064838")]
		[FieldOffset(Offset="0x38")]
		private ViewController _viewController;

		[Attribute(Name="InjectAttribute", RVA="0x1064848", Offset="0x1064848")]
		[FieldOffset(Offset="0x40")]
		private InfernoStateMachine _stateMachine;

		[Attribute(Name="InjectAttribute", RVA="0x1064858", Offset="0x1064858")]
		[FieldOffset(Offset="0x48")]
		private Procrastinator _procrastinator;

		[Attribute(Name="InjectAttribute", RVA="0x1064868", Offset="0x1064868")]
		[FieldOffset(Offset="0x50")]
		private ScrimController _scrimController;

		[Attribute(Name="InjectAttribute", RVA="0x1064878", Offset="0x1064878")]
		[FieldOffset(Offset="0x58")]
		private AudioSystem _audioSystem;

		[FieldOffset(Offset="0x60")]
		private SyncJobExecutor _executor;

		[FieldOffset(Offset="0x68")]
		private bool _isShutdown;

		[Address(RVA="0x151F304", Offset="0x151F304", VA="0x151F304")]
		public Bootstrapper()
		{
		}

		[Address(RVA="0x151F170", Offset="0x151F170", VA="0x151F170", Slot="5")]
		public void Dispose()
		{
		}

		[Address(RVA="0x151F264", Offset="0x151F264", VA="0x151F264")]
		private void FinishBootup()
		{
		}

		[Address(RVA="0x151ED94", Offset="0x151ED94", VA="0x151ED94", Slot="4")]
		public void Initialize()
		{
		}
	}
}