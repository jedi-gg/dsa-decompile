using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Diagnostics;

public class PassportSeasonLevelsController : AFeatureController, IDispatchHandler<DPassportSeasonLevelListItemAction>, IDispatchHandler, IDispatchHandler<DPassportSeasonControllerMultiRewardViewAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105AE6C", Offset="0x105AE6C")]
	[FieldOffset(Offset="0x68")]
	private PassportSeasonUtility _passportSeasonUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105AE7C", Offset="0x105AE7C")]
	[FieldOffset(Offset="0x70")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x105AE8C", Offset="0x105AE8C")]
	[FieldOffset(Offset="0x78")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105AE9C", Offset="0x105AE9C")]
	[FieldOffset(Offset="0x80")]
	private Procrastinator _procrastinator;

	[Attribute(Name="InjectAttribute", RVA="0x105AEAC", Offset="0x105AEAC")]
	[FieldOffset(Offset="0x88")]
	private TelemetryTranslator _telemetryTranslator;

	[FieldOffset(Offset="0x90")]
	private PassportSeasonLevelsView _view;

	[FieldOffset(Offset="0x98")]
	private TransientScrimView _transientScrimView;

	[FieldOffset(Offset="0xA0")]
	private PassportSeason? _season;

	[Address(RVA="0x14044A0", Offset="0x14044A0", VA="0x14044A0")]
	public PassportSeasonLevelsController()
	{
	}

	[Address(RVA="0x14044A8", Offset="0x14044A8", VA="0x14044A8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107029C", Offset="0x107029C")]
	[DebuggerHidden]
	private void <>n__0(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x1404278", Offset="0x1404278", VA="0x1404278")]
	private void AnimateLevelUpCompleted(PassportSeasonLevelUpController.LevelUpSource levelUpSource, InventoryDelta delta)
	{
	}

	[Address(RVA="0x1404214", Offset="0x1404214", VA="0x1404214", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x1403D04", Offset="0x1403D04", VA="0x1403D04")]
	private void DispatchRewardItemClickedEvent(string st2, long passportLevel, ulong firstRewardItemId)
	{
	}

	[Address(RVA="0x1403800", Offset="0x1403800", VA="0x1403800", Slot="13")]
	public void HandleDispatchAction(DPassportSeasonLevelListItemAction action)
	{
	}

	[Address(RVA="0x1404204", Offset="0x1404204", VA="0x1404204", Slot="14")]
	public void HandleDispatchAction(DPassportSeasonControllerMultiRewardViewAction action)
	{
	}

	[Address(RVA="0x1403500", Offset="0x1403500", VA="0x1403500", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x1403F14", Offset="0x1403F14", VA="0x1403F14")]
	private void PurchaseLevel(PassportSeasonLevelUpController.LevelUpSource levelUpSource)
	{
	}

	[Address(RVA="0x1403718", Offset="0x1403718", VA="0x1403718", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x140376C", Offset="0x140376C", VA="0x140376C", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C50C", Offset="0x104C50C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public PassportSeasonLevelsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x1403710", Offset="0x1403710", VA="0x1403710")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x14044B0", Offset="0x14044B0", VA="0x14044B0")]
		internal void <Initialize>b__0(Action jobFinished)
		{
		}

		[Address(RVA="0x14045A4", Offset="0x14045A4", VA="0x14045A4")]
		internal void <Initialize>b__1(Action jobFinished)
		{
		}

		[Address(RVA="0x14046E8", Offset="0x14046E8", VA="0x14046E8")]
		internal void <Initialize>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C51C", Offset="0x104C51C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[FieldOffset(Offset="0x18")]
		public PassportSeasonLevelsController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x140459C", Offset="0x140459C", VA="0x140459C")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x1404CA8", Offset="0x1404CA8", VA="0x1404CA8")]
		internal void <Initialize>b__3(PassportSeasonLevelsView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C52C", Offset="0x104C52C")]
	private sealed class <>c__DisplayClass0_2
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[FieldOffset(Offset="0x18")]
		public PassportSeasonLevelsController.<>c__DisplayClass0_0 CS$<>8__locals2;

		[Address(RVA="0x14046E0", Offset="0x14046E0", VA="0x14046E0")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x1404D10", Offset="0x1404D10", VA="0x1404D10")]
		internal void <Initialize>b__4(TransientScrimView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C53C", Offset="0x104C53C")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset="0x10")]
		public PassportSeasonLevelsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public long previousPlayerXp;

		[FieldOffset(Offset="0x20")]
		public int previousPassportLevel;

		[FieldOffset(Offset="0x24")]
		public PassportSeasonLevelUpController.LevelUpSource levelUpSource;

		[Address(RVA="0x1404270", Offset="0x1404270", VA="0x1404270")]
		public <>c__DisplayClass6_0()
		{
		}

		[Address(RVA="0x1404D78", Offset="0x1404D78", VA="0x1404D78")]
		internal void <PurchaseLevel>b__0(BuyPassportSeasonLevelResponse response)
		{
		}

		[Address(RVA="0x1404F84", Offset="0x1404F84", VA="0x1404F84")]
		internal void <PurchaseLevel>b__1(long failureCode)
		{
		}

		[Address(RVA="0x1405004", Offset="0x1405004", VA="0x1405004")]
		internal void <PurchaseLevel>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C54C", Offset="0x104C54C")]
	private sealed class <>c__DisplayClass6_1
	{
		[FieldOffset(Offset="0x10")]
		public BuyPassportSeasonLevelResponse response;

		[FieldOffset(Offset="0x18")]
		public PassportSeasonLevelsController.<>c__DisplayClass6_0 CS$<>8__locals1;

		[Address(RVA="0x1404ED4", Offset="0x1404ED4", VA="0x1404ED4")]
		public <>c__DisplayClass6_1()
		{
		}

		[Address(RVA="0x1405078", Offset="0x1405078", VA="0x1405078")]
		internal void <PurchaseLevel>b__3()
		{
		}
	}
}