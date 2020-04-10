using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitInventoryListItem : UnitListItem
{
	[FieldOffset(Offset="0x140")]
	private BadgingController _badgingController;

	[FieldOffset(Offset="0x148")]
	private InventoryUtility _inventoryUtility;

	[FieldOffset(Offset="0x150")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="HeaderAttribute", RVA="0x1059708", Offset="0x1059708")]
	[FieldOffset(Offset="0x158")]
	[SerializeField]
	private Badge _badge;

	[FieldOffset(Offset="0x160")]
	[SerializeField]
	private Image _promotionProgressFill;

	[FieldOffset(Offset="0x168")]
	[SerializeField]
	private UiLabel _promotionProgressLabel;

	[FieldOffset(Offset="0x170")]
	[SerializeField]
	private UiLabel _customLabel;

	[FieldOffset(Offset="0x178")]
	[SerializeField]
	private GameObject _gearContainerBG;

	[FieldOffset(Offset="0x180")]
	[SerializeField]
	private List<Image> _gearIcons;

	[FieldOffset(Offset="0x188")]
	[SerializeField]
	private GameObject _lockedContainer;

	[FieldOffset(Offset="0x190")]
	[SerializeField]
	private UnitGearSlotStateData _gearSlotStateData;

	[FieldOffset(Offset="0x198")]
	[SerializeField]
	private UiAnimatedGradientEffect _animatedGradientEffect;

	[Address(RVA="0x1505D98", Offset="0x1505D98", VA="0x1505D98")]
	public UnitInventoryListItem()
	{
	}

	[Address(RVA="0x1505094", Offset="0x1505094", VA="0x1505094", Slot="7")]
	public override void Initialize(WidgetDependencyContainer dependencies, object ownerIdentifier)
	{
	}

	[Address(RVA="0x150562C", Offset="0x150562C", VA="0x150562C")]
	public void SetCustomLabel(Func<ulong, UiLabel, bool> customLabelFunc)
	{
	}

	[Address(RVA="0x1505C1C", Offset="0x1505C1C", VA="0x1505C1C", Slot="9")]
	protected override void SetUnitDefinitionData(Gamedata.Unit unitDef)
	{
	}

	[Address(RVA="0x1505718", Offset="0x1505718", VA="0x1505718", Slot="8")]
	protected override void SetUnitInstanceData(Serverproto.Unit unit, Gamedata.Unit unitDef)
	{
	}

	[Address(RVA="0x15054C4", Offset="0x15054C4", VA="0x15054C4", Slot="4")]
	public override void Shutdown()
	{
	}
}