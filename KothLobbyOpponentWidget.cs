using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class KothLobbyOpponentWidget : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private Button _profileButton;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private Button _battleButton;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private UnitListItem[] _unitListItems;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private SpellListItem[] _spellListItems;

	[Attribute(Name="HeaderAttribute", RVA="0x105A4C8", Offset="0x105A4C8")]
	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private RawImage _avatarImage;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private Image _vipBg;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private UiLabel _levelLabel;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private UiLabel _nameLabel;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private UiLabel _clubNameLabel;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private UiLabel _rankLabel;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private UiLabel _powerLabel;

	[FieldOffset(Offset="0x70")]
	private SingleAssetRegistry _avatarAssetRegistry;

	[FieldOffset(Offset="0x78")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x80")]
	private LocalizationManager _locManager;

	[FieldOffset(Offset="0x88")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x90")]
	private string _playerId;

	[FieldOffset(Offset="0x98")]
	private ulong _playerRank;

	public Button BattleButton
	{
		[Address(RVA="0x11D30B0", Offset="0x11D30B0", VA="0x11D30B0")]
		get
		{
			return null;
		}
	}

	public UiLabel NameLabel
	{
		[Address(RVA="0x11D30A0", Offset="0x11D30A0", VA="0x11D30A0")]
		get
		{
			return null;
		}
	}

	public UiLabel PowerLabel
	{
		[Address(RVA="0x11D30A8", Offset="0x11D30A8", VA="0x11D30A8")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11D3F2C", Offset="0x11D3F2C", VA="0x11D3F2C")]
	public KothLobbyOpponentWidget()
	{
	}

	[Address(RVA="0x11D3E7C", Offset="0x11D3E7C", VA="0x11D3E7C")]
	private void BattleClicked()
	{
	}

	[Address(RVA="0x11D3D98", Offset="0x11D3D98", VA="0x11D3D98")]
	public void EnableBattle(bool enable)
	{
	}

	[Address(RVA="0x11D30B8", Offset="0x11D30B8", VA="0x11D30B8")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11D3DD0", Offset="0x11D3DD0", VA="0x11D3DD0")]
	private void ProfileClicked()
	{
	}

	[Address(RVA="0x11D34B4", Offset="0x11D34B4", VA="0x11D34B4")]
	public void SetData(KothLobbyOpponent player)
	{
	}

	[Address(RVA="0x11D333C", Offset="0x11D333C", VA="0x11D333C")]
	public void Shutdown()
	{
	}
}