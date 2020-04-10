using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ClubWarRewardsChestListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x30")]
	private LocalizationManager _locManager;

	[FieldOffset(Offset="0x38")]
	private SingleAssetRegistry _openedChestRegistry;

	[FieldOffset(Offset="0x40")]
	private ClubWarReward _chest;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private Button _clickHandler;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private GameObject _unopenedContainer;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private GameObject _openedContainer;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private GameObject _openedRoot;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private UiLabel _playerName;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private UiLabel _chestName;

	private bool IsOpen
	{
		[Address(RVA="0x14D8B30", Offset="0x14D8B30", VA="0x14D8B30")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x14D8C38", Offset="0x14D8C38", VA="0x14D8C38")]
	public ClubWarRewardsChestListItem()
	{
	}

	[Address(RVA="0x14D8C40", Offset="0x14D8C40", VA="0x14D8C40")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F2C4", Offset="0x106F2C4")]
	private void <SetData>b__2_0(AssetHandle assetHandle)
	{
	}

	[Address(RVA="0x14D8B58", Offset="0x14D8B58", VA="0x14D8B58")]
	private void ChestClicked()
	{
	}

	[Address(RVA="0x14D877C", Offset="0x14D877C", VA="0x14D877C")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x14D88F8", Offset="0x14D88F8", VA="0x14D88F8")]
	public void SetData(ClubWarReward chest)
	{
	}

	[Address(RVA="0x14D888C", Offset="0x14D888C", VA="0x14D888C", Slot="4")]
	public override void Shutdown()
	{
	}
}