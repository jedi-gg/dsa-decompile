using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitGearIngredientColumn : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	private const int MAX_INGREDIENTS = 5;

	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x20")]
	private CostController _costController;

	[FieldOffset(Offset="0x28")]
	private List<UnitGearIngredientItem> _ingredientItems;

	[FieldOffset(Offset="0x30")]
	private InventoryItem _item;

	[FieldOffset(Offset="0x40")]
	private float _listItemHeight;

	[FieldOffset(Offset="0x48")]
	private ulong _craftCurrencyId;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private UnitGearIngredientItem _ingredientItemArchetype;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private CostButton _craftButton;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private Graphic _arrow;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Graphic _line;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private Image _selectedLineFill;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private UnityEngine.Color _unselectedLineColor;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private UnityEngine.Color _sufficientSelectedLineColor;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private UnityEngine.Color _insufficientSelectedLineColor;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private RectTransform _currentSelectedIngredientContainer;

	public CostButton CraftButton
	{
		[Address(RVA="0x11F3680", Offset="0x11F3680", VA="0x11F3680")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11F4C94", Offset="0x11F4C94", VA="0x11F4C94")]
	public UnitGearIngredientColumn()
	{
	}

	[Address(RVA="0x11F4C00", Offset="0x11F4C00", VA="0x11F4C00")]
	private void CraftClicked()
	{
	}

	[Address(RVA="0x11F3688", Offset="0x11F3688", VA="0x11F3688")]
	public void Initialize(WidgetDependencyContainer dependencies, int columnIndex, ulong craftCurrencyId)
	{
	}

	[Address(RVA="0x11F4A2C", Offset="0x11F4A2C", VA="0x11F4A2C")]
	public void PlayCraftGearAnimation(float scale, float duration, float elasticity)
	{
	}

	[Address(RVA="0x11F3D84", Offset="0x11F3D84", VA="0x11F3D84")]
	public void SetColumnRootItem(InventoryItem item)
	{
	}

	[Address(RVA="0x11F4840", Offset="0x11F4840", VA="0x11F4840")]
	public void SetCraftState(uint craftCurrencyCost, bool canCraft, bool showCraftButton)
	{
	}

	[Address(RVA="0x11F3D8C", Offset="0x11F3D8C", VA="0x11F3D8C")]
	public void SetIngredientData(int index, InventoryItem item, long ownedCount, long requiredCount, bool hasRecipe, bool canCraft, bool canCraftRequired)
	{
	}

	[Address(RVA="0x11F40F4", Offset="0x11F40F4", VA="0x11F40F4")]
	public void SetIngredientTreeLayout(int totalIngredientCount, int selectedIngredientIndex, int previousColumnSelectedItemIndex)
	{
	}

	[Address(RVA="0x11F492C", Offset="0x11F492C", VA="0x11F492C")]
	public void ShowSelectedIngredientNotch()
	{
	}

	[Address(RVA="0x11F3B94", Offset="0x11F3B94", VA="0x11F3B94")]
	public void Shutdown()
	{
	}
}