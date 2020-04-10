using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class AdRewardView : APopupView, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x10524A0", Offset="0x10524A0")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x70")]
	private IList<InventoryItem> _rewards;

	private AdRewardView.SerializedFields Fields
	{
		[Address(RVA="0x1156E38", Offset="0x1156E38", VA="0x1156E38")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11574F4", Offset="0x11574F4", VA="0x11574F4")]
	public AdRewardView()
	{
	}

	[Address(RVA="0x115729C", Offset="0x115729C", VA="0x115729C")]
	private void BindRewardListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x1156F18", Offset="0x1156F18", VA="0x1156F18", Slot="22")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x11571A0", Offset="0x11571A0", VA="0x11571A0")]
	private void InitializeRewardListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x1156AF4", Offset="0x1156AF4", VA="0x1156AF4")]
	public void SetRewardsItems(InventoryDelta rewards)
	{
	}

	[Address(RVA="0x1156CD8", Offset="0x1156CD8", VA="0x1156CD8")]
	public void SetRewardsText(string text)
	{
	}

	[Address(RVA="0x11570DC", Offset="0x11570DC", VA="0x11570DC", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x115711C", Offset="0x115711C", VA="0x115711C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x10697B4", Offset="0x10697B4")]
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect RewardsScrollRect;

		[FieldOffset(Offset="0x38")]
		public UnityEngine.GameObject RewardsContainer;

		[FieldOffset(Offset="0x40")]
		public UnityEngine.GameObject LabelContainer;

		[FieldOffset(Offset="0x48")]
		public UiLabel RewardLabel;

		[Address(RVA="0x11574FC", Offset="0x11574FC", VA="0x11574FC")]
		public SerializedFields()
		{
		}
	}
}