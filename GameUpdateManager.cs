using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using System;
using Zenject;

public class GameUpdateManager : ITickable
{
	[Attribute(Name="InjectAttribute", RVA="0x105F930", Offset="0x105F930")]
	[FieldOffset(Offset="0x10")]
	private AudioSystem _audioSystem;

	[Attribute(Name="InjectAttribute", RVA="0x105F940", Offset="0x105F940")]
	[FieldOffset(Offset="0x18")]
	private GameStateMachine _stateMachine;

	[Attribute(Name="InjectAttribute", RVA="0x105F950", Offset="0x105F950")]
	[FieldOffset(Offset="0x20")]
	private SystemDialogManager _systemDialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x105F960", Offset="0x105F960")]
	[FieldOffset(Offset="0x28")]
	private EnergyGenerateController _energyGenerateController;

	[Attribute(Name="InjectAttribute", RVA="0x105F970", Offset="0x105F970")]
	[FieldOffset(Offset="0x30")]
	private UiAnimatedGradientEffectController _uiAnimatedGradientEffectController;

	[Attribute(Name="InjectAttribute", RVA="0x105F980", Offset="0x105F980")]
	[FieldOffset(Offset="0x38")]
	private BackdropController _backdropController;

	[Attribute(Name="InjectAttribute", RVA="0x105F990", Offset="0x105F990")]
	[FieldOffset(Offset="0x40")]
	private DownloadOverlayController _downloadOverlayController;

	[Attribute(Name="InjectAttribute", RVA="0x105F9A0", Offset="0x105F9A0")]
	[FieldOffset(Offset="0x48")]
	private UiInputReactController _uiInputReactController;

	[Attribute(Name="InjectAttribute", RVA="0x105F9B0", Offset="0x105F9B0")]
	[FieldOffset(Offset="0x50")]
	private CostController _costController;

	[Attribute(Name="InjectAttribute", RVA="0x105F9C0", Offset="0x105F9C0")]
	[FieldOffset(Offset="0x58")]
	private GameServiceManager _gameServiceManager;

	[Attribute(Name="InjectAttribute", RVA="0x105F9D0", Offset="0x105F9D0")]
	[FieldOffset(Offset="0x60")]
	private BattleInviteMessageController _battleInviteMessageController;

	[Attribute(Name="InjectAttribute", RVA="0x105F9E0", Offset="0x105F9E0")]
	[FieldOffset(Offset="0x68")]
	private ContextualMessageController _contextualMessageController;

	[Attribute(Name="InjectAttribute", RVA="0x105F9F0", Offset="0x105F9F0")]
	[FieldOffset(Offset="0x70")]
	private IGameServiceTransport _gameServiceTransport;

	[Attribute(Name="InjectAttribute", RVA="0x105FA00", Offset="0x105FA00")]
	[FieldOffset(Offset="0x78")]
	private RevSdkController _revSdkController;

	[Attribute(Name="InjectAttribute", RVA="0x105FA10", Offset="0x105FA10")]
	[FieldOffset(Offset="0x80")]
	private ChatDomainController _chatDc;

	[Address(RVA="0x15EC4C0", Offset="0x15EC4C0", VA="0x15EC4C0")]
	public GameUpdateManager()
	{
	}

	[Address(RVA="0x15EC278", Offset="0x15EC278", VA="0x15EC278", Slot="4")]
	public void Tick()
	{
	}
}