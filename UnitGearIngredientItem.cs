using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UnitGearIngredientItem : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x20")]
	private int _columnIndex;

	[FieldOffset(Offset="0x28")]
	private ulong _itemId;

	[FieldOffset(Offset="0x30")]
	private bool _hasEnoughOfItem;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private InventoryItemListItem _inventoryItemListItem;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private GameObject _selectedIcon;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private Graphic _selectedHorizontalLine;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private Button _clickHandler;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private PressEventHandler _pressHandler;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private GameObject _findIcon;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Graphic _craftIcon;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private UnityEngine.Color _canCraftColor;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private UnityEngine.Color _cannotCraftColor;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private GameObject _selectedIngredientNotch;

	public bool HasEnoughOfItem
	{
		[Address(RVA="0x11F47A0", Offset="0x11F47A0", VA="0x11F47A0")]
		get
		{
			return new bool();
		}
	}

	public bool IsSelected
	{
		[Address(RVA="0x11F4D08", Offset="0x11F4D08", VA="0x11F4D08")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11F4E78", Offset="0x11F4E78", VA="0x11F4E78")]
	public UnitGearIngredientItem()
	{
	}

	[Address(RVA="0x11F4D38", Offset="0x11F4D38", VA="0x11F4D38")]
	private void ButtonClicked()
	{
	}

	[Address(RVA="0x11F4DD8", Offset="0x11F4DD8", VA="0x11F4DD8")]
	private void ButtonLongPressed()
	{
	}

	[Address(RVA="0x11F3A3C", Offset="0x11F3A3C", VA="0x11F3A3C")]
	public void Initialize(WidgetDependencyContainer dependencies, int columnIndex)
	{
	}

	[Address(RVA="0x11F47A8", Offset="0x11F47A8", VA="0x11F47A8")]
	public void SelectItem(bool selected, UnityEngine.Color color)
	{
	}

	[Address(RVA="0x11F3F48", Offset="0x11F3F48", VA="0x11F3F48")]
	public void SetData(InventoryItem item, long ownedCount, long requiredCount, bool hasRecipe, bool canCraft, bool canCraftRequired)
	{
	}

	[Address(RVA="0x11F3CE0", Offset="0x11F3CE0", VA="0x11F3CE0")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x11F4B18", Offset="0x11F4B18", VA="0x11F4B18")]
	public void TryPlayCraftGearAnimation(float scale, float duration, float elasticity)
	{
	}

	[Address(RVA="0x11F49F0", Offset="0x11F49F0", VA="0x11F49F0")]
	public void TryShowSelectedIngredientNotch()
	{
	}
}