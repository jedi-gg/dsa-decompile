using Glunies.Audio;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class AssetDependentInitializer : IAssetDependentInitializer
{
	[Attribute(Name="InjectAttribute", RVA="0x1054C74", Offset="0x1054C74")]
	[FieldOffset(Offset="0x10")]
	private AudioSystem _audioSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1054C84", Offset="0x1054C84")]
	[FieldOffset(Offset="0x18")]
	private ContextualMessageController _contextualMessageController;

	[Attribute(Name="InjectAttribute", RVA="0x1054C94", Offset="0x1054C94")]
	[FieldOffset(Offset="0x20")]
	private HudController _hudController;

	[Attribute(Name="InjectAttribute", RVA="0x1054CA4", Offset="0x1054CA4")]
	[FieldOffset(Offset="0x28")]
	private BattleStateTransitionController _battleStateTransitionController;

	[Attribute(Name="InjectAttribute", RVA="0x1054CB4", Offset="0x1054CB4")]
	[FieldOffset(Offset="0x30")]
	private PlayerCollectionPowerController _playerCollectionPowerController;

	[Attribute(Name="InjectAttribute", RVA="0x1054CC4", Offset="0x1054CC4")]
	[FieldOffset(Offset="0x38")]
	private BattleInviteMessageController _battleInviteController;

	[Attribute(Name="InjectAttribute", RVA="0x1054CD4", Offset="0x1054CD4")]
	[FieldOffset(Offset="0x40")]
	private AlertTextController _alertTextController;

	[Attribute(Name="InjectAttribute", RVA="0x1054CE4", Offset="0x1054CE4")]
	[FieldOffset(Offset="0x48")]
	private AppRatingController _appRatingController;

	[Attribute(Name="InjectAttribute", RVA="0x1054CF4", Offset="0x1054CF4")]
	[FieldOffset(Offset="0x50")]
	private FontManager _fontManager;

	[Attribute(Name="InjectAttribute", RVA="0x1054D04", Offset="0x1054D04")]
	[FieldOffset(Offset="0x58")]
	private SystemDialogManager _systemDialogManager;

	[FieldOffset(Offset="0x60")]
	private List<IAssetDependentLifecycleObject> _assetDependentInitializers;

	[FieldOffset(Offset="0x68")]
	private bool _isInitialized;

	public bool IsInitialized
	{
		[Address(RVA="0x115D0B8", Offset="0x115D0B8", VA="0x115D0B8", Slot="4")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x115D800", Offset="0x115D800", VA="0x115D800")]
	public AssetDependentInitializer()
	{
	}

	[Address(RVA="0x115D0C0", Offset="0x115D0C0", VA="0x115D0C0", Slot="5")]
	public void LoadAssets(Action finished)
	{
	}

	[Address(RVA="0x115D5D0", Offset="0x115D5D0", VA="0x115D5D0", Slot="6")]
	public void ReleaseAssets()
	{
	}

	[Address(RVA="0x115D6E8", Offset="0x115D6E8", VA="0x115D6E8", Slot="7")]
	public void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B43C", Offset="0x104B43C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public Action finished;

		[FieldOffset(Offset="0x18")]
		public AssetDependentInitializer <>4__this;

		[Address(RVA="0x115D5C8", Offset="0x115D5C8", VA="0x115D5C8")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x115D808", Offset="0x115D808", VA="0x115D808")]
		internal void <LoadAssets>b__0()
		{
		}
	}
}