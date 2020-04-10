using Gamedata;
using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UnitListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	protected DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x30")]
	protected SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x38")]
	protected SingleAssetRegistry _sorcererStoneAssetRegistry;

	[FieldOffset(Offset="0x40")]
	protected GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x48")]
	protected LocalizationManager _lm;

	[FieldOffset(Offset="0x50")]
	protected ulong _unitDefinitionId;

	[FieldOffset(Offset="0x58")]
	private object _ownerIdentifier;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	protected AudioClipGroup _clickAudioClipGroup;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	protected Button _clickHandler;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	protected PressEventHandler _pressHandler;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	protected RawImage _unitImage;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	protected UnitRarityWidget _rarityWidget;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	protected UiLabel _rarityNumberLabel;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	protected UiLabel _levelLabel;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	protected UiLabel _levelNumberLabel;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	protected Graphic _gearColorImage;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	protected GameObject _gearLabelContainer;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	protected UiLabel _gearLabel;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	protected Image _roleIcon;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	protected GameObject _healthBarContainer;

	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	protected Image _healthBar;

	[FieldOffset(Offset="0xD0")]
	[SerializeField]
	protected Image _deadIcon;

	[FieldOffset(Offset="0xD8")]
	[SerializeField]
	protected Image _bottomPartFill;

	[FieldOffset(Offset="0xE0")]
	[SerializeField]
	protected GameObject _selectedState;

	[FieldOffset(Offset="0xE8")]
	[SerializeField]
	protected GameObject _ineligibleContainer;

	[FieldOffset(Offset="0xF0")]
	[SerializeField]
	protected GameObject _noLongerEligibleContainer;

	[FieldOffset(Offset="0xF8")]
	[SerializeField]
	protected UiLabel _noLongerEligibleLabel;

	[FieldOffset(Offset="0x100")]
	[SerializeField]
	protected GameObject _activeBonusContainer;

	[FieldOffset(Offset="0x108")]
	[SerializeField]
	protected GameObject _leaderBadge;

	[FieldOffset(Offset="0x110")]
	[SerializeField]
	protected GameObject _affinityContainer;

	[FieldOffset(Offset="0x118")]
	[SerializeField]
	protected Image _affinityImage;

	[FieldOffset(Offset="0x120")]
	[SerializeField]
	protected SpriteSheetNameLookup _unitRoleSpriteLookup;

	[FieldOffset(Offset="0x128")]
	[SerializeField]
	protected GameObject _sorcererStoneContainer;

	[FieldOffset(Offset="0x130")]
	[SerializeField]
	protected RawImage _sorcererStoneImage;

	[FieldOffset(Offset="0x138")]
	[SerializeField]
	protected Image _gearLabelBg;

	[Address(RVA="0x1505DA0", Offset="0x1505DA0", VA="0x1505DA0")]
	public UnitListItem()
	{
	}

	[Address(RVA="0x1508CA4", Offset="0x1508CA4", VA="0x1508CA4")]
	public void HideHealth()
	{
	}

	[Address(RVA="0x15051B4", Offset="0x15051B4", VA="0x15051B4", Slot="7")]
	public virtual void Initialize(WidgetDependencyContainer dependencies, object ownerIdentifier)
	{
	}

	[Address(RVA="0x1509DA0", Offset="0x1509DA0", VA="0x1509DA0")]
	private void ListItemClicked()
	{
	}

	[Address(RVA="0x1509E94", Offset="0x1509E94", VA="0x1509E94")]
	private void ListItemPressed()
	{
	}

	[Address(RVA="0x1508A90", Offset="0x1508A90", VA="0x1508A90")]
	public void SetActiveBonusEnabled(bool enabled)
	{
	}

	[Address(RVA="0x1509200", Offset="0x1509200", VA="0x1509200")]
	private void SetAffinity(UnitCategory? affinity)
	{
	}

	[Address(RVA="0x1509A58", Offset="0x1509A58", VA="0x1509A58")]
	public void SetBottomPartFillAmount(float fillAmount)
	{
	}

	[Address(RVA="0x1508B40", Offset="0x1508B40", VA="0x1508B40")]
	public void SetEligible(bool eligible)
	{
	}

	[Address(RVA="0x1509B08", Offset="0x1509B08", VA="0x1509B08")]
	public void SetLeader(bool isLeader)
	{
	}

	[Address(RVA="0x1509120", Offset="0x1509120", VA="0x1509120")]
	private void SetRole(UnitCategory role)
	{
	}

	[Address(RVA="0x15089E0", Offset="0x15089E0", VA="0x15089E0")]
	public void SetSelected(bool selected)
	{
	}

	[Address(RVA="0x1509634", Offset="0x1509634", VA="0x1509634")]
	private void SetSorcererStone(ulong stoneId)
	{
	}

	[Address(RVA="0x1509380", Offset="0x1509380", VA="0x1509380")]
	private void SetStatInfo(ulong level, ulong rarity, ulong gearTier)
	{
	}

	[Address(RVA="0x1507A14", Offset="0x1507A14", VA="0x1507A14")]
	public void SetUnit(Serverproto.Unit unit)
	{
	}

	[Address(RVA="0x1507B14", Offset="0x1507B14", VA="0x1507B14")]
	public void SetUnit(Gamedata.Unit unitDef)
	{
	}

	[Address(RVA="0x1508DB8", Offset="0x1508DB8", VA="0x1508DB8")]
	public void SetUnit(EnemyUnitPreview enemyPreview, Serverproto.UnitStatOverride statOverride)
	{
	}

	[Address(RVA="0x1505C78", Offset="0x1505C78", VA="0x1505C78", Slot="9")]
	protected virtual void SetUnitDefinitionData(Gamedata.Unit unitDef)
	{
	}

	[Address(RVA="0x150908C", Offset="0x150908C", VA="0x150908C")]
	private void SetUnitIcon(string iconAssetId)
	{
	}

	[Address(RVA="0x1505B44", Offset="0x1505B44", VA="0x1505B44", Slot="8")]
	protected virtual void SetUnitInstanceData(Serverproto.Unit unit, Gamedata.Unit unitDef)
	{
	}

	[Address(RVA="0x1508BF4", Offset="0x1508BF4", VA="0x1508BF4")]
	public void SetUnitIsNoLongerEligible(bool noLongerEligible)
	{
	}

	[Address(RVA="0x1509990", Offset="0x1509990", VA="0x1509990")]
	public void ShowBottomPartFill(bool showing)
	{
	}

	[Address(RVA="0x1509808", Offset="0x1509808", VA="0x1509808")]
	public void ShowHealth(bool isAlive, float healthPercent)
	{
	}

	[Address(RVA="0x150551C", Offset="0x150551C", VA="0x150551C", Slot="4")]
	public override void Shutdown()
	{
	}
}