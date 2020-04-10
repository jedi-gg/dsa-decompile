using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class BattleRestrictionUnitListItem : UnitListItem
{
	[Attribute(Name="HeaderAttribute", RVA="0x105E8DC", Offset="0x105E8DC")]
	[FieldOffset(Offset="0x140")]
	[SerializeField]
	private UnityEngine.Color _restrictionsMetColor;

	[FieldOffset(Offset="0x150")]
	[SerializeField]
	private UnityEngine.Color _restrictionsNotMetColor;

	[FieldOffset(Offset="0x160")]
	[SerializeField]
	private GameObject _requiredContainer;

	[FieldOffset(Offset="0x168")]
	[SerializeField]
	private Graphic _requiredIndicator;

	[FieldOffset(Offset="0x170")]
	[SerializeField]
	private GameObject _rarityContainer;

	[FieldOffset(Offset="0x178")]
	[SerializeField]
	private UiLabel _rarityLabel;

	[FieldOffset(Offset="0x180")]
	[SerializeField]
	private GameObject _unitLockedContainer;

	[FieldOffset(Offset="0x188")]
	[SerializeField]
	private UiLabel _requiredLabel;

	[Address(RVA="0x128E890", Offset="0x128E890", VA="0x128E890")]
	public BattleRestrictionUnitListItem()
	{
	}

	[Address(RVA="0x128E58C", Offset="0x128E58C", VA="0x128E58C", Slot="7")]
	public override void Initialize(WidgetDependencyContainer dependencies, object ownerIdentifier)
	{
	}

	[Address(RVA="0x128E63C", Offset="0x128E63C", VA="0x128E63C")]
	public void SetRestrictionState(bool isRequired, bool passesRestrictions)
	{
	}

	[Address(RVA="0x128E76C", Offset="0x128E76C", VA="0x128E76C", Slot="8")]
	protected override void SetUnitInstanceData(Serverproto.Unit unit, Gamedata.Unit unitDef)
	{
	}
}