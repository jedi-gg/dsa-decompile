using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class HomePassportSeasonWidget : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x20")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0x28")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x30")]
	private PassportSeasonUtility _passportSeasonUtility;

	[FieldOffset(Offset="0x38")]
	private AssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x40")]
	private float _passportPreviewNameScrollPercent;

	[FieldOffset(Offset="0x48")]
	private UiTimerLabel _passportSeasonUiTimerLabel;

	[FieldOffset(Offset="0x50")]
	private UiTimerLabel _nextPassportSeasonUiTimerLabel;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private GameObject _passportActiveContainer;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private GameObject _passportInactiveContainer;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private GameObject _passportActivePreviewsContainer;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private GameObject _passportActiveNoPreviewsContainer;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private UiLabel _passportNameLabel;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private RawImage _passportHomeShowcaseImage;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private Texture _defaultShowcaseImage;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private UiLabel _passportActivityPreviewName;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private UiLabel _passportActivityPreviewProgress;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private Image _passportActivityProgressFill;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private UiLabel _passportSeasonTimerLabel;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private UiLabel _nextPassportSeasonTimerLabel;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private RawImage _passportXpImage;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private RawImage _nextPassportLevelRewardImage;

	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	private UiLabel _nextPassportLevelRewardAmountLabel;

	[FieldOffset(Offset="0xD0")]
	[SerializeField]
	private Image _passportLevelXpFill;

	[FieldOffset(Offset="0xD8")]
	[SerializeField]
	private UnityEngine.Color _freeProgressColor;

	[FieldOffset(Offset="0xE8")]
	[SerializeField]
	private UnityEngine.Color _premiumProgressColor;

	[FieldOffset(Offset="0xF8")]
	[SerializeField]
	private UiLabel _nextPassportLevelLabel;

	[FieldOffset(Offset="0x100")]
	[SerializeField]
	private Image _passportIcon;

	[FieldOffset(Offset="0x108")]
	[SerializeField]
	private Sprite _freePassportImage;

	[FieldOffset(Offset="0x110")]
	[SerializeField]
	private Sprite _premiumPassportImage;

	[FieldOffset(Offset="0x118")]
	[SerializeField]
	private float _passportActivityPreviewNameEndOffset;

	[FieldOffset(Offset="0x11C")]
	[SerializeField]
	private float _passportActivityPreviewNameBeginOffset;

	[FieldOffset(Offset="0x120")]
	[SerializeField]
	private float _passportActivityPreviewNameScrollSpeed;

	[FieldOffset(Offset="0x124")]
	[SerializeField]
	private float _passportActivityPreviewNameAlphaChangePct;

	[Address(RVA="0x11703B0", Offset="0x11703B0", VA="0x11703B0")]
	public HomePassportSeasonWidget()
	{
	}

	[Address(RVA="0x116F5C4", Offset="0x116F5C4", VA="0x116F5C4")]
	private void _SetPassportSeason(PassportSeason? season, bool showActivityPreviews)
	{
	}

	[Address(RVA="0x116F300", Offset="0x116F300", VA="0x116F300")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1170104", Offset="0x1170104", VA="0x1170104")]
	private void SetNextLevelReward(PassportSeason? season)
	{
	}

	[Address(RVA="0x116FFEC", Offset="0x116FFEC", VA="0x116FFEC")]
	public void SetPassportActivityPreview(string activityNameKey, ulong currentValue, ulong requiredValue)
	{
	}

	[Address(RVA="0x116F4A4", Offset="0x116F4A4", VA="0x116F4A4")]
	public void SetPassportSeason(PassportSeason? season, bool showActivityPreviews)
	{
	}

	[Address(RVA="0x116F4D8", Offset="0x116F4D8", VA="0x116F4D8")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x116F514", Offset="0x116F514", VA="0x116F514")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x116FD74", Offset="0x116FD74", VA="0x116FD74")]
	private void UpdateActivityNameScroller()
	{
	}
}