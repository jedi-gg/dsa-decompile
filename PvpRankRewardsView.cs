using Gamedata;
using Glunies;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PvpRankRewardsView : APopupView
{
	[FieldOffset(Offset="0x0")]
	private static bool _scrolledToCurrentRankThisSession;

	[FieldOffset(Offset="0x68")]
	private List<PvpRank?> _pvpRanks;

	[FieldOffset(Offset="0x70")]
	private RepeatedField<PvpRankRewardPreview> _rankRewardPreview;

	[FieldOffset(Offset="0x78")]
	private ulong _playerRankId;

	[FieldOffset(Offset="0x80")]
	private UiTimerLabel _payoutCountdown;

	[FieldOffset(Offset="0x88")]
	private PvpRankRewardsController.RewardFrequency _rewardFrequency;

	private PvpRankRewardsView.SerializedFields Fields
	{
		[Address(RVA="0x2C2B450", Offset="0x2C2B450", VA="0x2C2B450")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x2C2BCA0", Offset="0x2C2BCA0", VA="0x2C2BCA0")]
	public PvpRankRewardsView()
	{
	}

	[Address(RVA="0x2C2BA54", Offset="0x2C2BA54", VA="0x2C2BA54")]
	private void BindPvpRankListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x2C2B974", Offset="0x2C2B974", VA="0x2C2B974")]
	private void InitializePvpRankListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x2C2B144", Offset="0x2C2B144", VA="0x2C2B144")]
	public void SetData(PvpRankRewardsController.RewardFrequency rewardFrequency, IEnumerable<PvpRank?> pvpRanks, RepeatedField<PvpRankRewardPreview> rankRewardPreview, ulong playerRankId)
	{
	}

	[Address(RVA="0x2C2B6B8", Offset="0x2C2B6B8", VA="0x2C2B6B8")]
	public void SetPayoutTimer(DateTime? v)
	{
	}

	[Address(RVA="0x2C2B530", Offset="0x2C2B530", VA="0x2C2B530")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x2C2B7E0", Offset="0x2C2B7E0", VA="0x2C2B7E0", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x2C2B8D0", Offset="0x2C2B8D0", VA="0x2C2B8D0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106B7EC", Offset="0x106B7EC")]
		[FieldOffset(Offset="0x30")]
		public UiLabel HeaderLabel;

		[FieldOffset(Offset="0x38")]
		public WrappedScrollRect RewardsScrollRect;

		[FieldOffset(Offset="0x40")]
		public float AutoScrollDuration;

		[Attribute(Name="HeaderAttribute", RVA="0x106B824", Offset="0x106B824")]
		[FieldOffset(Offset="0x48")]
		public UnityEngine.GameObject PayoutCountdownContainer;

		[FieldOffset(Offset="0x50")]
		public UiLabel PayoutCountdown;

		[Address(RVA="0x2C2BCB0", Offset="0x2C2BCB0", VA="0x2C2BCB0")]
		public SerializedFields()
		{
		}
	}
}