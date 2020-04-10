using Glunies;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Serverproto;
using System;

public class PvpRankRewardsController : APopupController, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105BEE0", Offset="0x105BEE0")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105BEF0", Offset="0x105BEF0")]
	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105BF00", Offset="0x105BF00")]
	[FieldOffset(Offset="0x48")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x105BF10", Offset="0x105BF10")]
	[FieldOffset(Offset="0x50")]
	private PassportSeasonUtility _passportSeasonUtility;

	[FieldOffset(Offset="0x58")]
	private PvpRankRewardsView _view;

	[FieldOffset(Offset="0x60")]
	private PvpRankRewardsController.RewardFrequency _rewardFrequency;

	[Address(RVA="0x1289628", Offset="0x1289628", VA="0x1289628")]
	public PvpRankRewardsController()
	{
	}

	[Address(RVA="0x12894F8", Offset="0x12894F8", VA="0x12894F8", Slot="14")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x128929C", Offset="0x128929C", VA="0x128929C", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x12894BC", Offset="0x12894BC", VA="0x12894BC", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C87C", Offset="0x104C87C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public PvpRankRewardsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public RepeatedField<PvpRankRewardPreview> rankRewardPreviews;

		[FieldOffset(Offset="0x20")]
		public ulong nextPayoutTime;

		[FieldOffset(Offset="0x28")]
		public Action completed;

		[FieldOffset(Offset="0x30")]
		public Action<PvpRankRewardPreviewResponse> <>9__3;

		[FieldOffset(Offset="0x38")]
		public Action<long> <>9__4;

		[Address(RVA="0x12894B4", Offset="0x12894B4", VA="0x12894B4")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1289638", Offset="0x1289638", VA="0x1289638")]
		internal void <Initialize>b__0(Action executed)
		{
		}

		[Address(RVA="0x128988C", Offset="0x128988C", VA="0x128988C")]
		internal void <Initialize>b__1(Action executed)
		{
		}

		[Address(RVA="0x1289978", Offset="0x1289978", VA="0x1289978")]
		internal void <Initialize>b__2()
		{
		}

		[Address(RVA="0x12897A4", Offset="0x12897A4", VA="0x12897A4")]
		internal void <Initialize>b__3(PvpRankRewardPreviewResponse response)
		{
		}

		[Address(RVA="0x128980C", Offset="0x128980C", VA="0x128980C")]
		internal void <Initialize>b__4(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C88C", Offset="0x104C88C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action executed;

		[FieldOffset(Offset="0x18")]
		public PvpRankRewardsController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x2C2B0A8", Offset="0x2C2B0A8", VA="0x2C2B0A8")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x2C2B0B0", Offset="0x2C2B0B0", VA="0x2C2B0B0")]
		internal void <Initialize>b__5(PvpRankRewardsView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly PvpRankRewardsController.RewardFrequency RewardFrequency;

		[Address(RVA="0x2C2B118", Offset="0x2C2B118", VA="0x2C2B118")]
		public Context(PvpRankRewardsController.RewardFrequency rewardFrequency)
		{
		}
	}

	public enum RewardFrequency
	{
		[FieldOffset(Offset="0x0")]
		Weekly,
		[FieldOffset(Offset="0x0")]
		Season
	}
}