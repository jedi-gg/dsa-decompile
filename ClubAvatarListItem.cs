using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ClubAvatarListItem : WrappedScrollRectListItem
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1055DC8", Offset="0x1055DC8")]
	[FieldOffset(Offset="0x28")]
	private InventoryItem? <Icon>k__BackingField;

	[FieldOffset(Offset="0x40")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x48")]
	private SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private RawImage _iconImage;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private Button _button;

	public InventoryItem? Icon
	{
		[Address(RVA="0x1467B50", Offset="0x1467B50", VA="0x1467B50")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EB3C", Offset="0x106EB3C")]
		get
		{
			return null;
		}
		[Address(RVA="0x1467B64", Offset="0x1467B64", VA="0x1467B64")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EB4C", Offset="0x106EB4C")]
		private set
		{
		}
	}

	[Address(RVA="0x1467E34", Offset="0x1467E34", VA="0x1467E34")]
	public ClubAvatarListItem()
	{
	}

	[Address(RVA="0x1467DB0", Offset="0x1467DB0", VA="0x1467DB0")]
	private void Clicked()
	{
	}

	[Address(RVA="0x1467B78", Offset="0x1467B78", VA="0x1467B78")]
	public void Initialize(WidgetDependencyContainer dependencies, object inventoryItemOwner)
	{
	}

	[Address(RVA="0x1467CD4", Offset="0x1467CD4", VA="0x1467CD4")]
	public void SetData(InventoryItem? icon)
	{
	}

	[Address(RVA="0x1467C6C", Offset="0x1467C6C", VA="0x1467C6C", Slot="4")]
	public override void Shutdown()
	{
	}
}