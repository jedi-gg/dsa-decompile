using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KothRankRewardListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x0")]
	private const int MAX_REWARDS_TO_SHOW = 3;

	[FieldOffset(Offset="0x28")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x38")]
	private List<InventoryItemListItem> _inventoryItemListItemInstances;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private UiLabel _rankTitle;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private GameObject _currentRankIndicator;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private RectTransform _rewardListItemParent;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private InventoryItemListItem _rewardListItem;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private Image _rankIcon;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private PlayerRankSpriteLookup _playerRankSpriteLookup;

	[Address(RVA="0x11D6330", Offset="0x11D6330", VA="0x11D6330")]
	public KothRankRewardListItem()
	{
	}

	[Address(RVA="0x11D5904", Offset="0x11D5904", VA="0x11D5904")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11D5C44", Offset="0x11D5C44", VA="0x11D5C44")]
	public void SetData(KothRank? kothRank, IList<Serverproto.ItemCount> rewardItems, bool isPlayerRank, int numRanks)
	{
	}

	[Address(RVA="0x11D5A9C", Offset="0x11D5A9C", VA="0x11D5A9C", Slot="4")]
	public override void Shutdown()
	{
	}
}