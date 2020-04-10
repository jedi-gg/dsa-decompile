using DG.Tweening;
using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UnitDetailsGearSlot : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x20")]
	private SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x28")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x30")]
	private UnitGearSlotStateData _gearSlotStateData;

	[FieldOffset(Offset="0x38")]
	private UnityEngine.Color _defaultBgColor;

	[FieldOffset(Offset="0x48")]
	private UnityEngine.RectTransform _rectTransform;

	[FieldOffset(Offset="0x50")]
	private Tweener _canEquipTweener;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private UnityEngine.UI.Button _button;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private RawImage _icon;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Image _slotStateIcon;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private Image _background;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private Graphic _canEquipOutline;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private UnityEngine.Color _unequippedIconColor;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private GameObject _selectedIndicator;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private UiLabel _stateLabel;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private GameObject _buyAndEquipIndicator;

	public UnityEngine.UI.Button Button
	{
		[Address(RVA="0x11E4028", Offset="0x11E4028", VA="0x11E4028")]
		get
		{
			return null;
		}
	}

	public UnityEngine.RectTransform RectTransform
	{
		[Address(RVA="0x11E4020", Offset="0x11E4020", VA="0x11E4020")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11E4BA8", Offset="0x11E4BA8", VA="0x11E4BA8")]
	public UnitDetailsGearSlot()
	{
	}

	[Address(RVA="0x11E4B08", Offset="0x11E4B08", VA="0x11E4B08")]
	private void Awake()
	{
	}

	[Address(RVA="0x11E4030", Offset="0x11E4030", VA="0x11E4030")]
	public void Initialize(int index, UnitGearSlotStateData gearSlotStateData, WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11E420C", Offset="0x11E420C", VA="0x11E420C")]
	public void Select(bool isSelected)
	{
	}

	[Address(RVA="0x11E43F8", Offset="0x11E43F8", VA="0x11E43F8")]
	public void SetItem(InventoryItem? gearItem, UnitGearSlotState state, bool canTierUp, UnityEngine.Color canTierUpColor)
	{
	}

	[Address(RVA="0x11E42BC", Offset="0x11E42BC", VA="0x11E42BC")]
	public void ShowBuyAndEquipIndicator(bool show)
	{
	}

	[Address(RVA="0x11E436C", Offset="0x11E436C", VA="0x11E436C")]
	public void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D03C", Offset="0x104D03C")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitDetailsGearSlot <>4__this;

		[FieldOffset(Offset="0x18")]
		public int index;

		[Address(RVA="0x11E4204", Offset="0x11E4204", VA="0x11E4204")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x11E4BB0", Offset="0x11E4BB0", VA="0x11E4BB0")]
		internal void <Initialize>b__0()
		{
		}
	}
}