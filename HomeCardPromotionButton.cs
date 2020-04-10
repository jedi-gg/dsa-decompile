using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class HomeCardPromotionButton : MonoBehaviour, IDispatchHandler<DInventoryDeltaAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private Button _goButton;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Button _findButton;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UiLabel _titleText;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private UiLabel _progressText;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private RawImage _promoMaterialIcon;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private UnitListItem _unitListItem;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private SpellListItem _spellListItem;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private GameObject _progressContainer;

	[FieldOffset(Offset="0x60")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x68")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDc;

	[FieldOffset(Offset="0x78")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x80")]
	private InventoryUtility _inventoryUtility;

	[FieldOffset(Offset="0x88")]
	private SingleAssetRegistry _singleAssetRegistry;

	[FieldOffset(Offset="0x90")]
	private InventoryItem? _promoMaterial;

	[FieldOffset(Offset="0xA8")]
	private Spell? _spell;

	[FieldOffset(Offset="0xC0")]
	private Unit? _unit;

	[FieldOffset(Offset="0xD8")]
	private ACardProgressTracker _tracker;

	[Address(RVA="0x12EC6E4", Offset="0x12EC6E4", VA="0x12EC6E4")]
	public HomeCardPromotionButton()
	{
	}

	[Address(RVA="0x12EBEBC", Offset="0x12EBEBC", VA="0x12EBEBC")]
	private void Clicked()
	{
	}

	[Address(RVA="0x12EC594", Offset="0x12EC594", VA="0x12EC594")]
	private void FindClicked()
	{
	}

	[Address(RVA="0x12EC148", Offset="0x12EC148", VA="0x12EC148")]
	private void GoClicked()
	{
	}

	[Address(RVA="0x12EAE64", Offset="0x12EAE64", VA="0x12EAE64", Slot="4")]
	public void HandleDispatchAction(DInventoryDeltaAction action)
	{
	}

	[Address(RVA="0x12EAA64", Offset="0x12EAA64", VA="0x12EAA64")]
	public void Initialize(WidgetDependencyContainer depencendies)
	{
	}

	[Address(RVA="0x12EB1F4", Offset="0x12EB1F4", VA="0x12EB1F4")]
	public void SetData(ACardProgressTracker tracker)
	{
	}

	[Address(RVA="0x12EAD20", Offset="0x12EAD20", VA="0x12EAD20")]
	public void Shutdown()
	{
	}
}