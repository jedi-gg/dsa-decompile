using Il2CppDummyDll;
using System;
using UnityEngine;

public class PackOpeningInventoryItemListItem : InventoryItemListItem
{
	[FieldOffset(Offset="0x108")]
	[SerializeField]
	private ViewSequencer _revealSequencer;

	public ViewSequencer RevealSequencer
	{
		[Address(RVA="0x13049A8", Offset="0x13049A8", VA="0x13049A8")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x13049B0", Offset="0x13049B0", VA="0x13049B0")]
	public PackOpeningInventoryItemListItem()
	{
	}
}