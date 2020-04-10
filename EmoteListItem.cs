using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class EmoteListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Button _clickHandler;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private RawImage _icon;

	[FieldOffset(Offset="0x38")]
	private SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x40")]
	private Action<ulong> _clickCallback;

	[FieldOffset(Offset="0x48")]
	private ulong _emoteId;

	[Address(RVA="0x120B914", Offset="0x120B914", VA="0x120B914")]
	public EmoteListItem()
	{
	}

	[Address(RVA="0x120B2D0", Offset="0x120B2D0", VA="0x120B2D0")]
	public void Initialize(WidgetDependencyContainer dependencies, Action<ulong> clickCallback)
	{
	}

	[Address(RVA="0x120B8B0", Offset="0x120B8B0", VA="0x120B8B0")]
	private void ListItemClicked()
	{
	}

	[Address(RVA="0x120B4E4", Offset="0x120B4E4", VA="0x120B4E4")]
	public void SetData(InventoryItem? emote)
	{
	}

	[Address(RVA="0x120B844", Offset="0x120B844", VA="0x120B844", Slot="4")]
	public override void Shutdown()
	{
	}
}