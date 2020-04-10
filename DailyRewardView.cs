using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailyRewardView : APopupView, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1057A84", Offset="0x1057A84")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1057A94", Offset="0x1057A94")]
	[FieldOffset(Offset="0x70")]
	private Procrastinator _procrastinator;

	[FieldOffset(Offset="0x78")]
	private List<DailyRewardListItem> _rewardListItems;

	[FieldOffset(Offset="0x80")]
	private UiTimerLabel _timerLabel;

	[FieldOffset(Offset="0x88")]
	private DailyRewardListItem _rewardToClaim;

	private DailyRewardView.SerializedFields Fields
	{
		[Address(RVA="0x11FF1AC", Offset="0x11FF1AC", VA="0x11FF1AC")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11FFE7C", Offset="0x11FFE7C", VA="0x11FFE7C")]
	public DailyRewardView()
	{
	}

	[Address(RVA="0x11FF2BC", Offset="0x11FF2BC", VA="0x11FF2BC")]
	public void CelebrateSuccess(InventoryDelta delta)
	{
	}

	[Address(RVA="0x11FFD4C", Offset="0x11FFD4C", VA="0x11FFD4C")]
	private void ClaimClicked()
	{
	}

	[Address(RVA="0x11FF28C", Offset="0x11FF28C", VA="0x11FF28C")]
	private DailyRewardListItem.State GetStateForDay(int dayIndex, int playerRewardIndex, bool hasClaimedToday, bool isCompleted)
	{
		return new DailyRewardListItem.State();
	}

	[Address(RVA="0x11FF894", Offset="0x11FF894", VA="0x11FF894", Slot="22")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x11FE034", Offset="0x11FE034", VA="0x11FE034")]
	public void SetData(DailyRewardTier? dailyRewardTier, int playerRewardIndex, bool hasClaimedToday, bool isCompleted, DateTime nextRewardResetTime, int previousRewardsLength)
	{
	}

	[Address(RVA="0x11FF0D8", Offset="0x11FF0D8", VA="0x11FF0D8")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x11FF9D0", Offset="0x11FF9D0", VA="0x11FF9D0", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11FFB90", Offset="0x11FFB90", VA="0x11FFB90", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106A3C4", Offset="0x106A3C4")]
		[FieldOffset(Offset="0x30")]
		public UiLabel Title;

		[FieldOffset(Offset="0x38")]
		public Button ClaimButton;

		[FieldOffset(Offset="0x40")]
		public UiLabel Timer;

		[FieldOffset(Offset="0x48")]
		public DailyRewardListItem DailyRewardListItem;

		[FieldOffset(Offset="0x50")]
		public DailyRewardListItem FinalDailyRewardListItem;

		[FieldOffset(Offset="0x58")]
		public RawImage FinalRewardImage;

		[FieldOffset(Offset="0x60")]
		public Transform FinalRewardContainer;

		[FieldOffset(Offset="0x68")]
		public UnityEngine.GameObject CelebrationRoot;

		[FieldOffset(Offset="0x70")]
		public List<ParticleSystem> CelebrationParticles;

		[FieldOffset(Offset="0x78")]
		public float CelebrationAutoCloseTime;

		[Address(RVA="0x11FFEEC", Offset="0x11FFEEC", VA="0x11FFEEC")]
		public SerializedFields()
		{
		}
	}
}