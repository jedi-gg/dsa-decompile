using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class KothBattleHistoryOpponentWidget : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Button _profileButton;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UnitListItem[] _unitListItems;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private SpellListItem[] _spellListItems;

	[Attribute(Name="HeaderAttribute", RVA="0x105A24C", Offset="0x105A24C")]
	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private RawImage _avatarImage;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private Image _vipBg;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private UiLabel _levelLabel;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private UiLabel _nameLabel;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private UiLabel _clubNameLabel;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private UiLabel _rankLabel;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private UiLabel _powerLabel;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private UiLabel _timeElapsed;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private Image _defeatIcon;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private Image _victoryIcon;

	[FieldOffset(Offset="0x90")]
	private SingleAssetRegistry _avatarAssetRegistry;

	[FieldOffset(Offset="0x98")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0xA0")]
	private LocalizationManager _locManager;

	[FieldOffset(Offset="0xA8")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0xB0")]
	private string _playerId;

	[FieldOffset(Offset="0xB8")]
	private ulong _playerRank;

	[Address(RVA="0x11CA7F0", Offset="0x11CA7F0", VA="0x11CA7F0")]
	public KothBattleHistoryOpponentWidget()
	{
	}

	[Address(RVA="0x11C98A0", Offset="0x11C98A0", VA="0x11C98A0")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11CA744", Offset="0x11CA744", VA="0x11CA744")]
	private void ProfileClicked()
	{
	}

	[Address(RVA="0x11C9C04", Offset="0x11C9C04", VA="0x11C9C04")]
	public void SetItem(KothBattleHistory battleHistory)
	{
	}

	[Address(RVA="0x11C9EF0", Offset="0x11C9EF0", VA="0x11C9EF0")]
	private void SetKothLobbyOpponentData(KothLobbyOpponent player)
	{
	}

	[Address(RVA="0x11C9AC0", Offset="0x11C9AC0", VA="0x11C9AC0", Slot="4")]
	public override void Shutdown()
	{
	}
}