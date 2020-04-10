using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class PassportSeasonLevelUpController : APopupController, IDispatchHandler<DPassportSeasonLevelUpViewAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105B114", Offset="0x105B114")]
	[FieldOffset(Offset="0x38")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105B124", Offset="0x105B124")]
	[FieldOffset(Offset="0x40")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105B134", Offset="0x105B134")]
	[FieldOffset(Offset="0x48")]
	private PassportSeasonUtility _passportSeasonUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105B144", Offset="0x105B144")]
	[FieldOffset(Offset="0x50")]
	private RevSdkController _revSdk;

	[FieldOffset(Offset="0x58")]
	private PassportSeasonLevelUpView _view;

	public override bool ShouldBeRestoredFromHistory
	{
		[Address(RVA="0x14005AC", Offset="0x14005AC", VA="0x14005AC", Slot="7")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x14019FC", Offset="0x14019FC", VA="0x14019FC")]
	public PassportSeasonLevelUpController()
	{
	}

	[Address(RVA="0x1401A04", Offset="0x1401A04", VA="0x1401A04")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10702E4", Offset="0x10702E4")]
	private int <GetMissingOutPremiumRewards>b__5_0(Serverproto.ItemCount a, Serverproto.ItemCount b)
	{
		return new int();
	}

	[Address(RVA="0x14014FC", Offset="0x14014FC", VA="0x14014FC")]
	private List<Serverproto.ItemCount> GetMissingOutPremiumRewards(PassportSeason? season, int playerLevel)
	{
		return null;
	}

	[Address(RVA="0x1401324", Offset="0x1401324", VA="0x1401324", Slot="14")]
	public void HandleDispatchAction(DPassportSeasonLevelUpViewAction action)
	{
	}

	[Address(RVA="0x14005B4", Offset="0x14005B4", VA="0x14005B4", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x1400EE4", Offset="0x1400EE4", VA="0x1400EE4")]
	private void LogBackfillTelemetry(PassportSeasonLevelUpController.BackfillRewardsContext context, InventoryDelta inventoryDelta)
	{
	}

	[Address(RVA="0x1400954", Offset="0x1400954", VA="0x1400954")]
	private void LogLevelUpTelemetry(PassportSeasonLevelUpController.TelemetryContext levelUpContext, InventoryDelta inventoryDelta)
	{
	}

	[Address(RVA="0x140121C", Offset="0x140121C", VA="0x140121C", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C58C", Offset="0x104C58C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public PassportSeasonLevelUpController <>4__this;

		[FieldOffset(Offset="0x18")]
		public ITransitionContext context;

		[FieldOffset(Offset="0x20")]
		public PassportSeasonLevelUp pendingPassportLevelUp;

		[FieldOffset(Offset="0x28")]
		public Action completed;

		[Address(RVA="0x1400944", Offset="0x1400944", VA="0x1400944")]
		public <>c__DisplayClass2_0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C59C", Offset="0x104C59C")]
	private sealed class <>c__DisplayClass2_1
	{
		[FieldOffset(Offset="0x10")]
		public PassportSeason? season;

		[FieldOffset(Offset="0x28")]
		public PassportSeasonLevelUpController.<>c__DisplayClass2_0 CS$<>8__locals1;

		[Address(RVA="0x140094C", Offset="0x140094C", VA="0x140094C")]
		public <>c__DisplayClass2_1()
		{
		}

		[Address(RVA="0x1401AC8", Offset="0x1401AC8", VA="0x1401AC8")]
		internal void <Initialize>b__0(PassportSeasonLevelUpView view)
		{
		}
	}

	public class BackfillRewardsContext : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly long TelemetryRefId;

		[Address(RVA="0x14024D4", Offset="0x14024D4", VA="0x14024D4")]
		public BackfillRewardsContext(long telemetryRefId)
		{
		}
	}

	public enum LevelUpSource
	{
		[FieldOffset(Offset="0x0")]
		INVALID,
		[FieldOffset(Offset="0x0")]
		XpEarned,
		[FieldOffset(Offset="0x0")]
		BoughtFromLevelsView,
		[FieldOffset(Offset="0x0")]
		BoughtFromActivitiesView,
		[FieldOffset(Offset="0x0")]
		BoughtFromMultiRewardView
	}

	public class TelemetryContext : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly PassportSeasonLevelUpController.LevelUpSource LevelSource;

		[FieldOffset(Offset="0x18")]
		public readonly long TelemetryRefId;

		[Address(RVA="0x1402500", Offset="0x1402500", VA="0x1402500")]
		public TelemetryContext(PassportSeasonLevelUpController.LevelUpSource levelSource, long telemetryRefId)
		{
		}

		[Address(RVA="0x140253C", Offset="0x140253C", VA="0x140253C")]
		public static PassportSeasonLevelUpController.TelemetryContext DefaultXpEarned()
		{
			return null;
		}
	}
}