using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ClubActivityTierListItem : WrappedScrollRectListItem, IDispatchHandler<DSelectClubActivityTierAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Button _listItemButton;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UiLabel _titleLabel;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private UiLabel _descriptionLabel;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private UiLabel _progressLabel;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private GameObject _completeCheckmark;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private Graphic _selectedGraphic;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private Color _selectedColor;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Color _unselectedColor;

	[FieldOffset(Offset="0x78")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x80")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x88")]
	private DClubActivityTierData? _data;

	[Address(RVA="0x1465830", Offset="0x1465830", VA="0x1465830")]
	public ClubActivityTierListItem()
	{
	}

	[Address(RVA="0x1465698", Offset="0x1465698", VA="0x1465698", Slot="7")]
	public void HandleDispatchAction(DSelectClubActivityTierAction action)
	{
	}

	[Address(RVA="0x14651A4", Offset="0x14651A4", VA="0x14651A4")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1465754", Offset="0x1465754", VA="0x1465754")]
	private void ListItemClicked()
	{
	}

	[Address(RVA="0x146533C", Offset="0x146533C", VA="0x146533C")]
	public void SetData(DClubActivityTierData data)
	{
	}

	[Address(RVA="0x1465608", Offset="0x1465608", VA="0x1465608")]
	public void SetSelected(bool selected)
	{
	}

	[Address(RVA="0x14652B4", Offset="0x14652B4", VA="0x14652B4", Slot="4")]
	public override void Shutdown()
	{
	}
}