using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class AbilityUpgradeLevelPreviewListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x38")]
	private SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x40")]
	private int _abilityLevelIndex;

	[FieldOffset(Offset="0x44")]
	[SerializeField]
	private float _deselectedAlpha;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private float _deselectedXOffset;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private RectTransform _root;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private GameObject _checkbox;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private UiLabel _levelPrefixLabel;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private UiLabel _descriptionLabel;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private Image _bg;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private Color _selectedBgColor;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private Color _deselectedBgColor;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private RawImage _upgradeIcon;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private GameObject _lockIcon;

	[Address(RVA="0x1154B3C", Offset="0x1154B3C", VA="0x1154B3C")]
	public AbilityUpgradeLevelPreviewListItem()
	{
	}

	[Address(RVA="0x1154AB8", Offset="0x1154AB8", VA="0x1154AB8")]
	private void ButtonClicked()
	{
	}

	[Address(RVA="0x1154590", Offset="0x1154590", VA="0x1154590")]
	public float GetPreferredHeight()
	{
		return new float();
	}

	[Address(RVA="0x11546A4", Offset="0x11546A4", VA="0x11546A4")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1154820", Offset="0x1154820", VA="0x1154820")]
	public void SetData(string description, int levelIndex, bool owned, string upgradeIcon, bool isLocked)
	{
	}

	[Address(RVA="0x11549D0", Offset="0x11549D0", VA="0x11549D0")]
	public void SetSelected(bool selected)
	{
	}

	[Address(RVA="0x11547B0", Offset="0x11547B0", VA="0x11547B0", Slot="4")]
	public override void Shutdown()
	{
	}
}