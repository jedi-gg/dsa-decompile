using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class KothRankRewardsView : APopupView
{
	[FieldOffset(Offset="0x0")]
	private static bool _scrolledToCurrentRankThisSession;

	[FieldOffset(Offset="0x68")]
	private List<KothRank?> _kothRanks;

	[FieldOffset(Offset="0x70")]
	private IList<KothRankRewardPreview> _rankRewardPreview;

	[FieldOffset(Offset="0x78")]
	private ulong _playerRankId;

	[FieldOffset(Offset="0x80")]
	private UiTimerLabel _payoutCountdown;

	private KothRankRewardsView.SerializedFields Fields
	{
		[Address(RVA="0x11D7268", Offset="0x11D7268", VA="0x11D7268")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11D7900", Offset="0x11D7900", VA="0x11D7900")]
	public KothRankRewardsView()
	{
	}

	[Address(RVA="0x11D75B8", Offset="0x11D75B8", VA="0x11D75B8")]
	private void BindKothRankListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x11D74DC", Offset="0x11D74DC", VA="0x11D74DC")]
	private void InitializeKothRankListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11D6E4C", Offset="0x11D6E4C", VA="0x11D6E4C")]
	public void SetData(IEnumerable<KothRank?> kothRanks, IList<KothRankRewardPreview> rankRewardPreview, ulong playerRankId)
	{
	}

	[Address(RVA="0x11D70D8", Offset="0x11D70D8", VA="0x11D70D8")]
	public void SetPayoutEta(DateTime? v)
	{
	}

	[Address(RVA="0x11D65F8", Offset="0x11D65F8", VA="0x11D65F8")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x11D7348", Offset="0x11D7348", VA="0x11D7348", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11D7438", Offset="0x11D7438", VA="0x11D7438", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106AE24", Offset="0x106AE24")]
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect RewardsScrollRect;

		[FieldOffset(Offset="0x38")]
		public float AutoScrollDuration;

		[Attribute(Name="HeaderAttribute", RVA="0x106AE5C", Offset="0x106AE5C")]
		[FieldOffset(Offset="0x40")]
		public UnityEngine.GameObject PayoutCountdownContainer;

		[FieldOffset(Offset="0x48")]
		public UiLabel PayoutCountdown;

		[Address(RVA="0x11D7908", Offset="0x11D7908", VA="0x11D7908")]
		public SerializedFields()
		{
		}
	}
}