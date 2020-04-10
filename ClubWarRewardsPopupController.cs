using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class ClubWarRewardsPopupController : APopupController, IDispatchHandler<DClubWarRewardsPopupViewAction>, IDispatchHandler, IDispatchHandler<DClubWarRewardsChestListItemAction>
{
	[FieldOffset(Offset="0x38")]
	private ClubWarRewardsPopupView _view;

	[FieldOffset(Offset="0x40")]
	private int _clubPlace;

	[FieldOffset(Offset="0x48")]
	private string _warTelemetryId;

	[FieldOffset(Offset="0x50")]
	private IList<ClubWarReward> _rewards;

	[FieldOffset(Offset="0x58")]
	private ClubWarRewardsPopupController.PlayerRewardEligibility _rewardEligibility;

	[Attribute(Name="InjectAttribute", RVA="0x1057428", Offset="0x1057428")]
	[FieldOffset(Offset="0x60")]
	private ClubService _clubService;

	[Attribute(Name="InjectAttribute", RVA="0x1057438", Offset="0x1057438")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1057448", Offset="0x1057448")]
	[FieldOffset(Offset="0x70")]
	private LocalizationManager _locManager;

	[Attribute(Name="InjectAttribute", RVA="0x1057458", Offset="0x1057458")]
	[FieldOffset(Offset="0x78")]
	private DialogManager _dialogManager;

	[Address(RVA="0x14D994C", Offset="0x14D994C", VA="0x14D994C")]
	public ClubWarRewardsPopupController()
	{
	}

	[Address(RVA="0x14D9CB8", Offset="0x14D9CB8", VA="0x14D9CB8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F2F4", Offset="0x106F2F4")]
	private void <RefreshFromServer>b__9_0()
	{
	}

	[Address(RVA="0x14D9954", Offset="0x14D9954", VA="0x14D9954")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F2D4", Offset="0x106F2D4")]
	private void <RequestRewards>b__6_0(ClubWarRewardsResponse resp)
	{
	}

	[Address(RVA="0x14D9BF8", Offset="0x14D9BF8", VA="0x14D9BF8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F2E4", Offset="0x106F2E4")]
	private void <RequestRewards>b__6_1(long errorCode)
	{
	}

	[Address(RVA="0x14D902C", Offset="0x14D902C", VA="0x14D902C", Slot="14")]
	public void HandleDispatchAction(DClubWarRewardsPopupViewAction action)
	{
	}

	[Address(RVA="0x14D9030", Offset="0x14D9030", VA="0x14D9030", Slot="15")]
	public void HandleDispatchAction(DClubWarRewardsChestListItemAction action)
	{
	}

	[Address(RVA="0x14D8D50", Offset="0x14D8D50", VA="0x14D8D50", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x14D947C", Offset="0x14D947C", VA="0x14D947C")]
	private void LoadView(Action finished)
	{
	}

	[Address(RVA="0x14D9194", Offset="0x14D9194", VA="0x14D9194")]
	private void OpenReward(string rewardId)
	{
	}

	[Address(RVA="0x14D96A8", Offset="0x14D96A8", VA="0x14D96A8")]
	private void PopulateRewards()
	{
	}

	[Address(RVA="0x14D988C", Offset="0x14D988C", VA="0x14D988C")]
	private void RefreshFromServer()
	{
	}

	[Address(RVA="0x14D9560", Offset="0x14D9560", VA="0x14D9560")]
	private void RequestRewards(Action finished)
	{
	}

	[Address(RVA="0x14D9370", Offset="0x14D9370", VA="0x14D9370")]
	private void ShowChestDetails(ClubWarReward chest)
	{
	}

	[Address(RVA="0x14D8F54", Offset="0x14D8F54", VA="0x14D8F54", Slot="9")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x14D8FC0", Offset="0x14D8FC0", VA="0x14D8FC0", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BB3C", Offset="0x104BB3C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarRewardsPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x14D8F4C", Offset="0x14D8F4C", VA="0x14D8F4C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x14D9EB4", Offset="0x14D9EB4", VA="0x14D9EB4")]
		internal void <Initialize>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BB4C", Offset="0x104BB4C")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarRewardsPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x14D9558", Offset="0x14D9558", VA="0x14D9558")]
		public <>c__DisplayClass5_0()
		{
		}

		[Address(RVA="0x14DA058", Offset="0x14DA058", VA="0x14DA058")]
		internal void <LoadView>b__0(ClubWarRewardsPopupView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BB5C", Offset="0x104BB5C")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarRewardsPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public string rewardId;

		[Address(RVA="0x14D96A0", Offset="0x14D96A0", VA="0x14D96A0")]
		public <>c__DisplayClass7_0()
		{
		}

		[Address(RVA="0x14DA0B0", Offset="0x14DA0B0", VA="0x14DA0B0")]
		internal void <OpenReward>b__0(ClubWarOpenRewardResponse resp)
		{
		}

		[Address(RVA="0x14DA728", Offset="0x14DA728", VA="0x14DA728")]
		internal void <OpenReward>b__1(long errorCode)
		{
		}

		[Address(RVA="0x14DA810", Offset="0x14DA810", VA="0x14DA810")]
		internal void <OpenReward>b__2()
		{
		}
	}

	private enum PlayerRewardEligibility
	{
		[FieldOffset(Offset="0x0")]
		Ineligible,
		[FieldOffset(Offset="0x0")]
		Eligible,
		[FieldOffset(Offset="0x0")]
		AlreadyOpened
	}
}