using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerXpContainer : MonoBehaviour, IDispatchHandler<DPlayerChangeAction>, IDispatchHandler, IDispatchHandler<DPlayerLevelUpAction>, IDispatchHandler<DInventoryDeltaProcessedAction>, IDispatchHandler<DPlayerProfileAction>
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x20")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x28")]
	private SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x38")]
	private ulong _xpItemId;

	[FieldOffset(Offset="0x40")]
	private Player _player;

	[FieldOffset(Offset="0x48")]
	private string _localPlayerId;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private Button _playerProfileButton;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private UiLabel _playerLevelLabel;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private UiLabel _playerNameLabel;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private GameObject _progressBar;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private Image _playerLevelProgressFillImage;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private RawImage _playerAvatarImage;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private GameObject _vipBg;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private UiLabel _xpProgressLabel;

	public RectTransform AvatarRectTransform
	{
		[Address(RVA="0x1344E0C", Offset="0x1344E0C", VA="0x1344E0C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x13457E4", Offset="0x13457E4", VA="0x13457E4")]
	public PlayerXpContainer()
	{
	}

	[Address(RVA="0x13457EC", Offset="0x13457EC", VA="0x13457EC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070FBC", Offset="0x1070FBC")]
	private void <Initialize>b__2_0()
	{
	}

	[Address(RVA="0x13453A0", Offset="0x13453A0", VA="0x13453A0", Slot="4")]
	public void HandleDispatchAction(DPlayerChangeAction action)
	{
	}

	[Address(RVA="0x1345420", Offset="0x1345420", VA="0x1345420", Slot="5")]
	public void HandleDispatchAction(DPlayerLevelUpAction action)
	{
	}

	[Address(RVA="0x1345454", Offset="0x1345454", VA="0x1345454", Slot="6")]
	public void HandleDispatchAction(DInventoryDeltaProcessedAction action)
	{
	}

	[Address(RVA="0x13456E0", Offset="0x13456E0", VA="0x13456E0", Slot="7")]
	public void HandleDispatchAction(DPlayerProfileAction action)
	{
	}

	[Address(RVA="0x1343CB8", Offset="0x1343CB8", VA="0x1343CB8")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x13453E0", Offset="0x13453E0", VA="0x13453E0")]
	private bool IsLocalPlayer()
	{
		return new bool();
	}

	[Address(RVA="0x1342DA8", Offset="0x1342DA8", VA="0x1342DA8")]
	public void SetPlayer(Player player)
	{
	}

	[Address(RVA="0x1345750", Offset="0x1345750", VA="0x1345750")]
	public void ShowLabels(bool showing)
	{
	}

	[Address(RVA="0x1342EAC", Offset="0x1342EAC", VA="0x1342EAC")]
	public void ShowXpProgress(bool show)
	{
	}

	[Address(RVA="0x1344104", Offset="0x1344104", VA="0x1344104")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1345208", Offset="0x1345208", VA="0x1345208")]
	private void UpdatePlayerAvatar()
	{
	}

	[Address(RVA="0x1344E84", Offset="0x1344E84", VA="0x1344E84")]
	private void UpdatePlayerLevel()
	{
	}

	[Address(RVA="0x13451B0", Offset="0x13451B0", VA="0x13451B0")]
	public void UpdatePlayerUsername()
	{
	}

	[Address(RVA="0x134534C", Offset="0x134534C", VA="0x134534C")]
	private void UpdateVipBg()
	{
	}
}