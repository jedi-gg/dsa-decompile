using Gamedata;
using Glunies;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PvpRankRewardListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x0")]
	private const int MAX_REWARDS_TO_SHOW = 3;

	[FieldOffset(Offset="0x28")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x30")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x38")]
	private SingleAssetRegistry _rankIconRegistry;

	[FieldOffset(Offset="0x40")]
	private List<InventoryItemListItem> _inventoryItemListItemInstances;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private UiLabel _rankTitle;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private RawImage _rankIcon;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private UiLabel _rankPointsLabel;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private List<GameObject> _currentRankIndicators;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private RectTransform _rewardListItemParent;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private InventoryItemListItem _rewardListItem;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private Graphic _background;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private UnityEngine.Color _currentRankColor;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private UnityEngine.Color _notCurrentRankColor;

	[Address(RVA="0x12891F0", Offset="0x12891F0", VA="0x12891F0")]
	public PvpRankRewardListItem()
	{
	}

	[Address(RVA="0x1288934", Offset="0x1288934", VA="0x1288934")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1288C94", Offset="0x1288C94", VA="0x1288C94")]
	public void SetData(PvpRank? pvpRank, RepeatedField<Serverproto.ItemCount> rewardItems, bool isPlayerRank)
	{
	}

	[Address(RVA="0x1288AD8", Offset="0x1288AD8", VA="0x1288AD8", Slot="4")]
	public override void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C86C", Offset="0x104C86C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public bool isPlayerRank;

		[Address(RVA="0x12891E8", Offset="0x12891E8", VA="0x12891E8")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1289260", Offset="0x1289260", VA="0x1289260")]
		internal void <SetData>b__0(GameObject g)
		{
		}
	}
}