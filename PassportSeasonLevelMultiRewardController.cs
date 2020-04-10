using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;

public class PassportSeasonLevelMultiRewardController : APopupController, IDispatchHandler<DPassportSeasonLevelMultiRewardViewAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105B0A4", Offset="0x105B0A4")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105B0B4", Offset="0x105B0B4")]
	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105B0C4", Offset="0x105B0C4")]
	[FieldOffset(Offset="0x48")]
	private PassportSeasonUtility _passportSeasonUtility;

	[FieldOffset(Offset="0x50")]
	private PassportSeasonLevelMultiRewardController.Context _context;

	[Address(RVA="0x13FEAD8", Offset="0x13FEAD8", VA="0x13FEAD8")]
	public PassportSeasonLevelMultiRewardController()
	{
	}

	[Address(RVA="0x13FEAD0", Offset="0x13FEAD0", VA="0x13FEAD0", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x13FE86C", Offset="0x13FE86C", VA="0x13FE86C", Slot="14")]
	public void HandleDispatchAction(DPassportSeasonLevelMultiRewardViewAction action)
	{
	}

	[Address(RVA="0x13FE610", Offset="0x13FE610", VA="0x13FE610", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C57C", Offset="0x104C57C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public PassportSeason? season;

		[FieldOffset(Offset="0x28")]
		public PassportSeasonLevelMultiRewardController <>4__this;

		[FieldOffset(Offset="0x30")]
		public Action completed;

		[Address(RVA="0x13FE864", Offset="0x13FE864", VA="0x13FE864")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x13FEAE0", Offset="0x13FEAE0", VA="0x13FEAE0")]
		internal void <Initialize>b__0(PassportSeasonLevelMultiRewardView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly int RewardLevelDataIndex;

		[FieldOffset(Offset="0x14")]
		public readonly PassportSeasonLevelMultiRewardController.Context.RewardsType TypeOfRewards;

		[Address(RVA="0x13FF3FC", Offset="0x13FF3FC", VA="0x13FF3FC")]
		public Context(int rewardLevelDataIndex, PassportSeasonLevelMultiRewardController.Context.RewardsType typeOfRewards)
		{
		}

		public enum RewardsType
		{
			[FieldOffset(Offset="0x0")]
			Free,
			[FieldOffset(Offset="0x0")]
			Premium
		}
	}
}