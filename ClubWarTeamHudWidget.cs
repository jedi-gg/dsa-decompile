using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ClubWarTeamHudWidget : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x20")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x28")]
	private ClubWarDomainController _clubWarDc;

	[FieldOffset(Offset="0x30")]
	private LocalizationManager _locManager;

	[FieldOffset(Offset="0x38")]
	private SingleAssetRegistry _clubAvatarRegistry;

	[FieldOffset(Offset="0x40")]
	private ulong _currentScore;

	[FieldOffset(Offset="0x48")]
	private string _clubId;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private Image _background;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private UiLabel _clubNameLabel;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private RawImage _clubAvatarImage;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Image _scoreFillImage;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private TallyLabelUnsigned _scoreLabel;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private UiLabel _nodesLabel;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private UiColorPalette _uiColors;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private TallyLabelUnsigned _scoreGainedLabel;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private float _tallyDuration;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private Button _clickHandler;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private UiLabel _pointRateLabel;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private GameObject _pointRateBonusRoot;

	[Address(RVA="0x14E2D34", Offset="0x14E2D34", VA="0x14E2D34")]
	public ClubWarTeamHudWidget()
	{
	}

	[Address(RVA="0x14E29C4", Offset="0x14E29C4", VA="0x14E29C4")]
	public void AnimateToScore(ulong newScore)
	{
	}

	[Address(RVA="0x14E1F10", Offset="0x14E1F10", VA="0x14E1F10")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x14E25A4", Offset="0x14E25A4", VA="0x14E25A4")]
	private void SetClubInfo(string clubName, ulong avatarId)
	{
	}

	[Address(RVA="0x14E26F4", Offset="0x14E26F4", VA="0x14E26F4")]
	private void SetScore(ulong score, bool setLabel = true)
	{
	}

	[Address(RVA="0x14E2238", Offset="0x14E2238", VA="0x14E2238")]
	public void SetTeam(ClubWarTeam teamId)
	{
	}

	[Address(RVA="0x14E2890", Offset="0x14E2890", VA="0x14E2890")]
	public void SetTeam(ClubProfileSimple club, ClubWarTeam teamId, ulong score)
	{
	}

	[Address(RVA="0x14E2168", Offset="0x14E2168", VA="0x14E2168")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x14E2B5C", Offset="0x14E2B5C", VA="0x14E2B5C")]
	private void Update()
	{
	}

	[Address(RVA="0x14E2C9C", Offset="0x14E2C9C", VA="0x14E2C9C")]
	private void WidgetClicked()
	{
	}
}