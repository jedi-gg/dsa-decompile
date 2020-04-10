using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class SorcererStoneListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x38")]
	private SingleAssetRegistry _iconAssetRegistry;

	[FieldOffset(Offset="0x40")]
	private ulong _sorcererStoneId;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private RawImage _icon;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private GameObject _selectedState;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private UiLabel _ownedCountLabel;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private UiLabel _statChangeLabel;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private GameObject _canCraftIndicator;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private Material _unownedMaterial;

	[Attribute(Name="RangeAttribute", RVA="0x105C690", Offset="0x105C690")]
	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private float _unownedAlpha;

	[Address(RVA="0x123CF78", Offset="0x123CF78", VA="0x123CF78")]
	public SorcererStoneListItem()
	{
	}

	[Address(RVA="0x123CEF4", Offset="0x123CEF4", VA="0x123CEF4")]
	private void ButtonClicked()
	{
	}

	[Address(RVA="0x123CA58", Offset="0x123CA58", VA="0x123CA58")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x123CBCC", Offset="0x123CBCC", VA="0x123CBCC")]
	public void SetData(InventoryItem? item, long ownedCount, bool selected, bool canCraft)
	{
	}

	[Address(RVA="0x123CB68", Offset="0x123CB68", VA="0x123CB68", Slot="4")]
	public override void Shutdown()
	{
	}
}