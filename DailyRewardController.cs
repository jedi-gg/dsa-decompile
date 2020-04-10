using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class DailyRewardController : APopupController, IDispatchHandler<DDailyRewardViewAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x10579B4", Offset="0x10579B4")]
	[FieldOffset(Offset="0x38")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x10579C4", Offset="0x10579C4")]
	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x10579D4", Offset="0x10579D4")]
	[FieldOffset(Offset="0x48")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x50")]
	private DailyRewardView _view;

	[FieldOffset(Offset="0x58")]
	private Serverproto.DailyReward _playerRewardInfo;

	[FieldOffset(Offset="0x60")]
	private Gamedata.DailyReward? _rewardData;

	[Address(RVA="0x12B3FA0", Offset="0x12B3FA0", VA="0x12B3FA0")]
	public DailyRewardController()
	{
	}

	[Address(RVA="0x12B3FA8", Offset="0x12B3FA8", VA="0x12B3FA8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F4A4", Offset="0x106F4A4")]
	private void <ClaimDailyReward>b__3_0(DailyRewardClaimResponse response)
	{
	}

	[Address(RVA="0x12B4004", Offset="0x12B4004", VA="0x12B4004")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F4B4", Offset="0x106F4B4")]
	private void <ClaimDailyReward>b__3_1(long errorCode)
	{
	}

	[Address(RVA="0x12B4080", Offset="0x12B4080", VA="0x12B4080")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F4C4", Offset="0x106F4C4")]
	private void <ClaimDailyReward>b__3_2()
	{
	}

	[Address(RVA="0x12B3A18", Offset="0x12B3A18", VA="0x12B3A18")]
	private void ClaimDailyReward()
	{
	}

	[Address(RVA="0x12B3A0C", Offset="0x12B3A0C", VA="0x12B3A0C", Slot="14")]
	public void HandleDispatchAction(DDailyRewardViewAction action)
	{
	}

	[Address(RVA="0x12B36F8", Offset="0x12B36F8", VA="0x12B36F8", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x12B3E90", Offset="0x12B3E90", VA="0x12B3E90")]
	private int PreviousRewardsLength()
	{
		return new int();
	}

	[Address(RVA="0x12B3C80", Offset="0x12B3C80", VA="0x12B3C80")]
	private void SendClaimDailyRewardTelemetry(DailyRewardClaimResponse response)
	{
	}

	[Address(RVA="0x12B39D0", Offset="0x12B39D0", VA="0x12B39D0", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BCEC", Offset="0x104BCEC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public DailyRewardController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x11FDD6C", Offset="0x11FDD6C", VA="0x11FDD6C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11FDD74", Offset="0x11FDD74", VA="0x11FDD74")]
		internal void <Initialize>b__0(DailyRewardView view)
		{
		}
	}
}