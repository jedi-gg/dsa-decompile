using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinPageComponent : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x20")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x28")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x30")]
	private PinPageItemData.Pool _pinItemDataPool;

	[FieldOffset(Offset="0x38")]
	private List<PinPageItemData> _pinData;

	[FieldOffset(Offset="0x40")]
	private int _activePinCount;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private PinPageItemComponent _pinPageItemArchetype;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private UiLabel _titleLabel;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private Graphic _titleBanner;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private UiLabel _pageLabel;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Graphic _pageCountBg;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private Button _leftNavButton;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private Button _rightNavButton;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private Button _leftNavDisabledButton;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private Button _rightNavDisabledButton;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private List<APinPageLayout> _layouts;

	public int ActivePinCount
	{
		[Address(RVA="0x140F458", Offset="0x140F458", VA="0x140F458")]
		get
		{
			return new int();
		}
	}

	[Address(RVA="0x14102F8", Offset="0x14102F8", VA="0x14102F8")]
	public PinPageComponent()
	{
	}

	[Address(RVA="0x140FB40", Offset="0x140FB40", VA="0x140FB40")]
	private void ClearPinData()
	{
	}

	[Address(RVA="0x141023C", Offset="0x141023C", VA="0x141023C")]
	private void EdgeOfBookClicked()
	{
	}

	[Address(RVA="0x140D6F4", Offset="0x140D6F4", VA="0x140D6F4")]
	public void Initialize(WidgetDependencyContainer dependencies, PinPageItemData.Pool pinDataPool)
	{
	}

	[Address(RVA="0x1410134", Offset="0x1410134", VA="0x1410134")]
	private void LeftNavClicked()
	{
	}

	[Address(RVA="0x140EA54", Offset="0x140EA54", VA="0x140EA54")]
	public void MarkAsNoLongerCurrentPage()
	{
	}

	[Address(RVA="0x140EB80", Offset="0x140EB80", VA="0x140EB80")]
	public void MarkPageAsCurrentPage()
	{
	}

	[Address(RVA="0x14101B8", Offset="0x14101B8", VA="0x14101B8")]
	private void RightNavClicked()
	{
	}

	[Address(RVA="0x140FCA4", Offset="0x140FCA4", VA="0x140FCA4")]
	private void SetData(string titleKey, int currentPage, int maxPages, PinPageLayout layoutType, UnityEngine.Color tabColor, bool canNavigateLeft, bool canNavigateRight)
	{
	}

	[Address(RVA="0x140F090", Offset="0x140F090", VA="0x140F090")]
	public void SetOwnedSetPinCollectionData(List<InventoryItem?> ownedSetPinItems, int startingIndex, int endIndex, string titleKey, int currentPage, int maxPages, UnityEngine.Color tabColor, bool canNavigateLeft, bool canNavigateRight)
	{
	}

	[Address(RVA="0x140F230", Offset="0x140F230", VA="0x140F230")]
	public void SetPinPageData(Func<int, PinPageItem?> pinsAccessor, int pinCount, string titleKey, int currentPage, int maxPages, PinPageLayout layoutType, UnityEngine.Color tabColor, bool canNavigateLeft, bool canNavigateRight)
	{
	}

	[Address(RVA="0x140DCB4", Offset="0x140DCB4", VA="0x140DCB4")]
	public void Shutdown()
	{
	}
}