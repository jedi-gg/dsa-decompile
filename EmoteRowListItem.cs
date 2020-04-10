using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class EmoteRowListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private PlayerDomainController _playerDc;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private EmoteInventoryListItem _emoteListItem;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private GameObject _deckBackground;

	[FieldOffset(Offset="0x40")]
	private List<EmoteInventoryListItem> _emotesInRow;

	[Address(RVA="0x120BE68", Offset="0x120BE68", VA="0x120BE68")]
	public EmoteRowListItem()
	{
	}

	[Address(RVA="0x120B91C", Offset="0x120B91C", VA="0x120B91C", Slot="7")]
	public virtual void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x120AB50", Offset="0x120AB50", VA="0x120AB50")]
	public void SetRowData(IReadOnlyList<InventoryItem?> emotes, int startIndex)
	{
	}

	[Address(RVA="0x120BB5C", Offset="0x120BB5C", VA="0x120BB5C", Slot="4")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x120BD44", Offset="0x120BD44", VA="0x120BD44", Slot="5")]
	public override void TickUpdate()
	{
	}
}