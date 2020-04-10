using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;

public class SpellInventoryListItem : SpellListItem
{
	[FieldOffset(Offset="0x98")]
	private InventoryUtility _inventoryUtility;

	[FieldOffset(Offset="0xA0")]
	private BadgingController _badgingController;

	[FieldOffset(Offset="0xA8")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0xB0")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private GameObject _lockedOverlay;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private UiAnimatedGradientEffect _animatedGradientEffect;

	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	private Badge _badge;

	[FieldOffset(Offset="0xD0")]
	[SerializeField]
	private UiLabel _promotionProgressLabel;

	[Address(RVA="0x1242030", Offset="0x1242030", VA="0x1242030")]
	public SpellInventoryListItem()
	{
	}

	[Address(RVA="0x12417EC", Offset="0x12417EC", VA="0x12417EC", Slot="7")]
	public override void Initialize(WidgetDependencyContainer dependencies, object ownerIdentifier)
	{
	}

	[Address(RVA="0x1241F20", Offset="0x1241F20", VA="0x1241F20", Slot="9")]
	protected override void SetSpellDefinitionData(Gamedata.Spell spellDef)
	{
	}

	[Address(RVA="0x1241BAC", Offset="0x1241BAC", VA="0x1241BAC", Slot="8")]
	protected override void SetSpellInstanceData(Serverproto.Spell spell, Gamedata.Spell spellDef)
	{
	}

	[Address(RVA="0x1241AD0", Offset="0x1241AD0", VA="0x1241AD0", Slot="4")]
	public override void Shutdown()
	{
	}
}