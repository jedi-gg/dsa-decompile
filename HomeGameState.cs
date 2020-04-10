using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using System;

public class HomeGameState : AGameState
{
	[Attribute(Name="InjectAttribute", RVA="0x1058B04", Offset="0x1058B04")]
	[FieldOffset(Offset="0x30")]
	private GameStateMachineNavigationTracker _gameStateMachineNavigationTracker;

	[Attribute(Name="InjectAttribute", RVA="0x1058B14", Offset="0x1058B14")]
	[FieldOffset(Offset="0x38")]
	private IAssetDownloader _assetDownloader;

	[Attribute(Name="InjectAttribute", RVA="0x1058B24", Offset="0x1058B24")]
	[FieldOffset(Offset="0x40")]
	private AudioSystem _audioSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1058B34", Offset="0x1058B34")]
	[FieldOffset(Offset="0x48")]
	private IGameServiceTransport _gameServiceTransport;

	[Attribute(Name="InjectAttribute", RVA="0x1058B44", Offset="0x1058B44")]
	[FieldOffset(Offset="0x50")]
	private SharedPrefs _sharedPrefs;

	public override bool ShowGlobalBackdrop
	{
		[Address(RVA="0x116F004", Offset="0x116F004", VA="0x116F004", Slot="10")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x116F2A0", Offset="0x116F2A0", VA="0x116F2A0")]
	public HomeGameState()
	{
	}

	[Address(RVA="0x116F00C", Offset="0x116F00C", VA="0x116F00C", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class Context : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x1C")]
		public bool ShowBattleSelectionOnInit;

		[Address(RVA="0x116F2A8", Offset="0x116F2A8", VA="0x116F2A8")]
		public Context()
		{
		}

		[Address(RVA="0x116F2D0", Offset="0x116F2D0", VA="0x116F2D0")]
		public Context(bool showBattleSelectionOnInit)
		{
		}
	}
}