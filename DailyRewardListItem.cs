using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DailyRewardListItem : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private RectTransform _offsetContainer;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private InventoryItemListItem _inventoryItem;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private GameObject _claimedState;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private GameObject _canClaimState;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private UiLabel _dayLabel;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private Image _verticalPath;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private Image _horizontalPath;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private UnityEngine.Color _unclaimedPathColor;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private UnityEngine.Color _canClaimPathColor;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private UnityEngine.Color _claimedPathColor;

	public RectTransform RewardItemRectTransform
	{
		[Address(RVA="0x11FE93C", Offset="0x11FE93C", VA="0x11FE93C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11FF0D0", Offset="0x11FF0D0", VA="0x11FF0D0")]
	public DailyRewardListItem()
	{
	}

	[Address(RVA="0x11FE9B4", Offset="0x11FE9B4", VA="0x11FE9B4")]
	public void Initialize(WidgetDependencyContainer dependencies, object ownerIdentifier, int index)
	{
	}

	[Address(RVA="0x11FF09C", Offset="0x11FF09C", VA="0x11FF09C")]
	public void SetClaimed()
	{
	}

	[Address(RVA="0x11FED24", Offset="0x11FED24", VA="0x11FED24")]
	public void SetItemPosition(int rewardIndex)
	{
	}

	[Address(RVA="0x11FED58", Offset="0x11FED58", VA="0x11FED58")]
	private void SetItemPosition(bool isOnTop)
	{
	}

	[Address(RVA="0x11FEEC0", Offset="0x11FEEC0", VA="0x11FEEC0")]
	private void SetPathPosition(bool isOnTop)
	{
	}

	[Address(RVA="0x11FEAC4", Offset="0x11FEAC4", VA="0x11FEAC4")]
	public void SetReward(InventoryItem? item, ItemCount? itemCount, DailyRewardListItem.State currentState, DailyRewardListItem.State nextState)
	{
	}

	[Address(RVA="0x11FEA90", Offset="0x11FEA90", VA="0x11FEA90")]
	public void Shutdown()
	{
	}

	public enum State
	{
		[FieldOffset(Offset="0x0")]
		Unclaimed,
		[FieldOffset(Offset="0x0")]
		Claimed,
		[FieldOffset(Offset="0x0")]
		CanClaim
	}
}