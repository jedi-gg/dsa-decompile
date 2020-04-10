using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerActivityListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x30")]
	protected LocalizationManager _lm;

	[FieldOffset(Offset="0x38")]
	private BadgingController _badgingController;

	[FieldOffset(Offset="0x40")]
	protected PlayerActivity _activity;

	[FieldOffset(Offset="0x48")]
	private DailyEnergyGiftListItemData _energyData;

	[FieldOffset(Offset="0x50")]
	private UiTimerLabel _energyTimerLabel;

	[FieldOffset(Offset="0x58")]
	protected bool _selected;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private Button _listItemButton;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	protected UiLabel _titleLabel;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	protected UiLabel _descriptionLabel;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	protected UiLabel _progressLabel;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private GameObject _completeCheckmark;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private GameObject _energyGiftExpireTimerContainer;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private UiLabel _energyGiftExpireTimerLabel;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private UiLabel _energyGiftPrefixLabel;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	protected Graphic _selectedGraphic;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private UnityEngine.Color _selectedColor;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private UnityEngine.Color _unselectedColor;

	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	private UnityEngine.Color _dailyOptionalSelectedColor;

	[FieldOffset(Offset="0xD8")]
	[SerializeField]
	private UnityEngine.Color _dailyOptionalUnselectedColor;

	[FieldOffset(Offset="0xE8")]
	[SerializeField]
	private Image _progressFill;

	[FieldOffset(Offset="0xF0")]
	[SerializeField]
	private Badge _badge;

	[FieldOffset(Offset="0xF8")]
	[SerializeField]
	private GameObject _adIcon;

	[Address(RVA="0x132E924", Offset="0x132E924", VA="0x132E924")]
	public PlayerActivityListItem()
	{
	}

	[Address(RVA="0x132DA48", Offset="0x132DA48", VA="0x132DA48")]
	public void Initialize(WidgetDependencyContainer dependencies, object inventoryItemOwner)
	{
	}

	[Address(RVA="0x132DE90", Offset="0x132DE90", VA="0x132DE90")]
	private void ListItemButtonClicked()
	{
	}

	[Address(RVA="0x132DF5C", Offset="0x132DF5C", VA="0x132DF5C")]
	public void SetData(PlayerActivity activity)
	{
	}

	[Address(RVA="0x132E47C", Offset="0x132E47C", VA="0x132E47C")]
	public void SetData(DailyEnergyGiftListItemData data)
	{
	}

	[Address(RVA="0x132E814", Offset="0x132E814", VA="0x132E814")]
	public void SetSelected(bool selected)
	{
	}

	[Address(RVA="0x132DBD8", Offset="0x132DBD8", VA="0x132DBD8", Slot="4")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x132DCB0", Offset="0x132DCB0", VA="0x132DCB0", Slot="5")]
	public override void TickUpdate()
	{
	}
}