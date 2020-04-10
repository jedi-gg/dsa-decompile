using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassportSeasonLevelUpView : APopupView, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105B154", Offset="0x105B154")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105B164", Offset="0x105B164")]
	[FieldOffset(Offset="0x70")]
	private Procrastinator _procrastinator;

	[FieldOffset(Offset="0x78")]
	private IList<InventoryItem> _rewardItems;

	[FieldOffset(Offset="0x80")]
	private IList<ItemCount> _missingOutRewardItems;

	private PassportSeasonLevelUpView.SerializedFields Fields
	{
		[Address(RVA="0x14025B4", Offset="0x14025B4", VA="0x14025B4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14032D0", Offset="0x14032D0", VA="0x14032D0")]
	public PassportSeasonLevelUpView()
	{
	}

	[Address(RVA="0x14032D8", Offset="0x14032D8", VA="0x14032D8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10702F4", Offset="0x10702F4")]
	private void <SetRewards>g__ScrollToTopOfMissingRewards|2_0()
	{
	}

	[Address(RVA="0x14033D4", Offset="0x14033D4", VA="0x14033D4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070304", Offset="0x1070304")]
	private void <ViewAssetLoaded>b__4_0()
	{
	}

	[Address(RVA="0x1403458", Offset="0x1403458", VA="0x1403458")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070314", Offset="0x1070314")]
	private void <ViewAssetLoaded>b__4_1()
	{
	}

	[Address(RVA="0x140305C", Offset="0x140305C", VA="0x140305C")]
	private void BindMissingOutRewardListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x1402CEC", Offset="0x1402CEC", VA="0x1402CEC")]
	private void BindRewardListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x1402694", Offset="0x1402694", VA="0x1402694", Slot="22")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x1402F60", Offset="0x1402F60", VA="0x1402F60")]
	private void InitializeMissingOutRewardListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x1402BF0", Offset="0x1402BF0", VA="0x1402BF0")]
	private void InitializeRewardListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x1401D9C", Offset="0x1401D9C", VA="0x1401D9C")]
	public void SetData(int currentPassportLevel, bool isBackfillRewards, bool isPremium)
	{
	}

	[Address(RVA="0x1401F6C", Offset="0x1401F6C", VA="0x1401F6C")]
	public void SetRewards(PassportSeasonLevelUp levelUpData, List<ItemCount> missingOutRewards)
	{
	}

	[Address(RVA="0x1401254", Offset="0x1401254", VA="0x1401254")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x14028C8", Offset="0x14028C8", VA="0x14028C8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1402AB0", Offset="0x1402AB0", VA="0x1402AB0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106B2C4", Offset="0x106B2C4")]
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect RewardsScrollRect;

		[FieldOffset(Offset="0x38")]
		public WrappedScrollRect MissingOutRewardsScrollRect;

		[FieldOffset(Offset="0x40")]
		public RectTransform RewardsLayoutRoot;

		[FieldOffset(Offset="0x48")]
		public UnityEngine.GameObject MissingOutRewardsParent;

		[FieldOffset(Offset="0x50")]
		public UiLabel LevelLabel;

		[FieldOffset(Offset="0x58")]
		public UiLabel TitleLabel;

		[FieldOffset(Offset="0x60")]
		public Image FreeRewardsReceivedIcon;

		[FieldOffset(Offset="0x68")]
		public Image PremiumRewardsReceivedIcon;

		[FieldOffset(Offset="0x70")]
		public Button UpgradeButton;

		[FieldOffset(Offset="0x78")]
		public Button InfoButton;

		[FieldOffset(Offset="0x80")]
		public float MissingOutRewardsScrollDelayS;

		[FieldOffset(Offset="0x84")]
		public float MissingOutRewardsScrollDurationS;

		[Address(RVA="0x14034DC", Offset="0x14034DC", VA="0x14034DC")]
		public SerializedFields()
		{
		}
	}
}