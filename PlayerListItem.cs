using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Button _listItemButton;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private RectTransform _avatarContainer;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private RawImage _avatar;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private UiLabel _nameLabel;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private UiLabel _levelLabel;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private UiLabel _clubNameLabel;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private Image _vipBg;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private UiLabel _rankLabel;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private UiLabel _rankDeltaLabel;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private GameObject _rankDeltaPositiveArrow;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private GameObject _rankDeltaNegativeArrow;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private Image _bg;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private UiLabel _scoreLabel;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private LabelButton _unblockButton;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private GameObject _clubLeaderIcon;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private GameObject _clubNameContainer;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private Image _rankIcon;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private LabelButton _utilityButton;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private PlayerRankSpriteLookup _playerRankSpriteLookup;

	[FieldOffset(Offset="0xC0")]
	protected DispatchSystem _dispatch;

	[FieldOffset(Offset="0xC8")]
	private SingleAssetRegistry _singleAssetRegistry;

	[FieldOffset(Offset="0xD0")]
	private PlayerListItemData _data;

	[FieldOffset(Offset="0xD8")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0xE0")]
	private UiColorPalette _colorPalette;

	[FieldOffset(Offset="0xE8")]
	private DPlayerListItemUtilityAction _utilityAction;

	public PlayerListItemData Data
	{
		[Address(RVA="0x133CB9C", Offset="0x133CB9C", VA="0x133CB9C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x133DD00", Offset="0x133DD00", VA="0x133DD00")]
	public PlayerListItem()
	{
	}

	[Address(RVA="0x133DB88", Offset="0x133DB88", VA="0x133DB88")]
	private void Clicked()
	{
	}

	[Address(RVA="0x133D94C", Offset="0x133D94C", VA="0x133D94C")]
	public void ConfigureRankIcon(int rankPosition)
	{
	}

	[Address(RVA="0x133CBA4", Offset="0x133CBA4", VA="0x133CBA4", Slot="7")]
	public virtual void Initialize(WidgetDependencyContainer dependencies, UiColorPalette colorPalette)
	{
	}

	[Address(RVA="0x133D654", Offset="0x133D654", VA="0x133D654")]
	public void SetBackgroundColor(UnityEngine.Color color)
	{
	}

	[Address(RVA="0x133D264", Offset="0x133D264", VA="0x133D264")]
	private void SetClubName(string clubName)
	{
	}

	[Address(RVA="0x133D51C", Offset="0x133D51C", VA="0x133D51C")]
	private void SetClubRole(ClubRole clubRole)
	{
	}

	[Address(RVA="0x133CE80", Offset="0x133CE80", VA="0x133CE80")]
	public void SetData(PlayerListItemData item, int index)
	{
	}

	[Address(RVA="0x133D590", Offset="0x133D590", VA="0x133D590")]
	private void SetIcon(string iconPath)
	{
	}

	[Address(RVA="0x133D1E8", Offset="0x133D1E8", VA="0x133D1E8")]
	private void SetLevel(ulong level)
	{
	}

	[Address(RVA="0x133D1AC", Offset="0x133D1AC", VA="0x133D1AC")]
	private void SetName(string username)
	{
	}

	[Address(RVA="0x133D6BC", Offset="0x133D6BC", VA="0x133D6BC")]
	public void SetRank(int rank)
	{
	}

	[Address(RVA="0x133D330", Offset="0x133D330", VA="0x133D330")]
	private void SetRank(int? rank)
	{
	}

	[Address(RVA="0x133D738", Offset="0x133D738", VA="0x133D738")]
	public void SetRankDelta(int rankDelta)
	{
	}

	[Address(RVA="0x133D3B4", Offset="0x133D3B4", VA="0x133D3B4")]
	private void SetRankDelta(int? rankDelta)
	{
	}

	[Address(RVA="0x133D438", Offset="0x133D438", VA="0x133D438")]
	private void SetScore(ulong? score)
	{
	}

	[Address(RVA="0x133D558", Offset="0x133D558", VA="0x133D558")]
	public void SetUnblockButtonInteractable(bool interactable)
	{
	}

	[Address(RVA="0x133DB54", Offset="0x133DB54", VA="0x133DB54")]
	public void SetUtilityAction(DPlayerListItemUtilityAction action)
	{
	}

	[Address(RVA="0x133D85C", Offset="0x133D85C", VA="0x133D85C")]
	public void ShowAvatar(bool showing)
	{
	}

	[Address(RVA="0x133D8AC", Offset="0x133D8AC", VA="0x133D8AC")]
	public void ShowLevel(bool showing)
	{
	}

	[Address(RVA="0x133D8FC", Offset="0x133D8FC", VA="0x133D8FC")]
	public void ShowRankIcon(bool showing)
	{
	}

	[Address(RVA="0x133DAD4", Offset="0x133DAD4", VA="0x133DAD4")]
	public void ShowUtilityButton(bool show)
	{
	}

	[Address(RVA="0x133D2E0", Offset="0x133D2E0", VA="0x133D2E0")]
	private void ShowVipBg(bool showVip)
	{
	}

	[Address(RVA="0x133CDDC", Offset="0x133CDDC", VA="0x133CDDC", Slot="4")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x133DC10", Offset="0x133DC10", VA="0x133DC10")]
	private void UnblockClicked()
	{
	}

	[Address(RVA="0x133DC98", Offset="0x133DC98", VA="0x133DC98")]
	private void UtilityButtonClicked()
	{
	}
}