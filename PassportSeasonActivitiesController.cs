using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class PassportSeasonActivitiesController : AFeatureController, IDispatchHandler<DPassportSeasonActivitiesViewAction>, IDispatchHandler, IDispatchHandler<DPlayerActivityUpdatedAction>, IDispatchHandler<DPlayerActivityClaimAction>, IDispatchHandler<DInventoryDeltaProcessedAction>
{
	[FieldOffset(Offset="0x0")]
	private const ulong NEW_ACTIVITIES_REFRESH_DELAY_S = 3L;

	[Attribute(Name="InjectAttribute", RVA="0x105ABF0", Offset="0x105ABF0")]
	[FieldOffset(Offset="0x68")]
	private PassportSeasonUtility _passportSeasonUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105AC00", Offset="0x105AC00")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105AC10", Offset="0x105AC10")]
	[FieldOffset(Offset="0x78")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105AC20", Offset="0x105AC20")]
	[FieldOffset(Offset="0x80")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x105AC30", Offset="0x105AC30")]
	[FieldOffset(Offset="0x88")]
	private CardUnlockTrackerController _cardUnlockTrackerController;

	[Attribute(Name="InjectAttribute", RVA="0x105AC40", Offset="0x105AC40")]
	[FieldOffset(Offset="0x90")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x105AC50", Offset="0x105AC50")]
	[FieldOffset(Offset="0x98")]
	private Procrastinator _procrastinator;

	[FieldOffset(Offset="0xA0")]
	private PassportSeasonActivitiesView _view;

	[FieldOffset(Offset="0xA8")]
	private TransientScrimView _transientScrimView;

	[FieldOffset(Offset="0xB0")]
	private PassportSeason? _season;

	[FieldOffset(Offset="0xC8")]
	private int _lastKnownPlayerPassportLevel;

	[FieldOffset(Offset="0xD0")]
	private long _lastKnownPlayerPassportXpAmount;

	[FieldOffset(Offset="0xD8")]
	private bool _purchasedLevelUp;

	[FieldOffset(Offset="0xE0")]
	private DateTime? _newActivitiesUnlockedTime;

	[Address(RVA="0x130B178", Offset="0x130B178", VA="0x130B178")]
	public PassportSeasonActivitiesController()
	{
	}

	[Address(RVA="0x130B180", Offset="0x130B180", VA="0x130B180")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107025C", Offset="0x107025C")]
	private void <HandleDispatchAction>b__4_0(ClaimActivityResponse response)
	{
	}

	[Address(RVA="0x130B1DC", Offset="0x130B1DC", VA="0x130B1DC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107026C", Offset="0x107026C")]
	private void <HandleDispatchAction>b__4_2()
	{
	}

	[Address(RVA="0x130B240", Offset="0x130B240", VA="0x130B240")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107027C", Offset="0x107027C")]
	private void <PurchaseLevel>b__12_1(long failureCode)
	{
	}

	[Address(RVA="0x130B2C0", Offset="0x130B2C0", VA="0x130B2C0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107028C", Offset="0x107028C")]
	private void <PurchaseLevel>b__12_2()
	{
	}

	[Address(RVA="0x130AFC8", Offset="0x130AFC8", VA="0x130AFC8")]
	private void AnimateXpCompleted(PassportSeasonLevelUpController.TelemetryContext levelUpContext)
	{
	}

	[Address(RVA="0x130976C", Offset="0x130976C", VA="0x130976C", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x1309F60", Offset="0x1309F60", VA="0x1309F60")]
	private ulong FindFirstActivityWithReward(PassportSeasonWeek? week, ulong queryRewardId)
	{
		return new ulong();
	}

	[Address(RVA="0x13097C8", Offset="0x13097C8", VA="0x13097C8")]
	private void FinishInitialization(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x1308A60", Offset="0x1308A60", VA="0x1308A60", Slot="13")]
	public void HandleDispatchAction(DPassportSeasonActivitiesViewAction action)
	{
	}

	[Address(RVA="0x1308F40", Offset="0x1308F40", VA="0x1308F40", Slot="15")]
	public void HandleDispatchAction(DPlayerActivityClaimAction action)
	{
	}

	[Address(RVA="0x13092BC", Offset="0x13092BC", VA="0x13092BC", Slot="14")]
	public void HandleDispatchAction(DPlayerActivityUpdatedAction action)
	{
	}

	[Address(RVA="0x1309338", Offset="0x1309338", VA="0x1309338", Slot="16")]
	public void HandleDispatchAction(DInventoryDeltaProcessedAction action)
	{
	}

	[Address(RVA="0x130856C", Offset="0x130856C", VA="0x130856C", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x1308C68", Offset="0x1308C68", VA="0x1308C68")]
	private void PurchaseLevel()
	{
	}

	[Address(RVA="0x1308788", Offset="0x1308788", VA="0x1308788")]
	private void SetLastKnownPlayerPassportValues()
	{
	}

	[Address(RVA="0x1308870", Offset="0x1308870", VA="0x1308870", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x13088C4", Offset="0x13088C4", VA="0x13088C4", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x13093B4", Offset="0x13093B4", VA="0x13093B4")]
	private void TryAnimateXp(InventoryDelta delta)
	{
	}

	[Address(RVA="0x13092D8", Offset="0x13092D8", VA="0x13092D8")]
	private void UpdateViewActivities(ulong selectedActivityId = 0L)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C4BC", Offset="0x104C4BC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static PassportSeasonActivitiesController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<long> <>9__4_1;

		[FieldOffset(Offset="0x10")]
		public static Action<BuyPassportSeasonLevelResponse> <>9__12_0;

		[Address(RVA="0x130B324", Offset="0x130B324", VA="0x130B324")]
		static <>c()
		{
		}

		[Address(RVA="0x130B388", Offset="0x130B388", VA="0x130B388")]
		public <>c()
		{
		}

		[Address(RVA="0x130B390", Offset="0x130B390", VA="0x130B390")]
		internal void <HandleDispatchAction>b__4_1(long errorCode)
		{
		}

		[Address(RVA="0x130B394", Offset="0x130B394", VA="0x130B394")]
		internal void <PurchaseLevel>b__12_0(BuyPassportSeasonLevelResponse response)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C48C", Offset="0x104C48C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public PassportSeasonActivitiesController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x1308780", Offset="0x1308780", VA="0x1308780")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x130B398", Offset="0x130B398", VA="0x130B398")]
		internal void <Initialize>b__0(Action jobFinished)
		{
		}

		[Address(RVA="0x130B48C", Offset="0x130B48C", VA="0x130B48C")]
		internal void <Initialize>b__1(Action jobFinished)
		{
		}

		[Address(RVA="0x130B5D0", Offset="0x130B5D0", VA="0x130B5D0")]
		internal void <Initialize>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C49C", Offset="0x104C49C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[FieldOffset(Offset="0x18")]
		public PassportSeasonActivitiesController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x130B484", Offset="0x130B484", VA="0x130B484")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x130B600", Offset="0x130B600", VA="0x130B600")]
		internal void <Initialize>b__3(PassportSeasonActivitiesView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C4AC", Offset="0x104C4AC")]
	private sealed class <>c__DisplayClass0_2
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[FieldOffset(Offset="0x18")]
		public PassportSeasonActivitiesController.<>c__DisplayClass0_0 CS$<>8__locals2;

		[Address(RVA="0x130B5C8", Offset="0x130B5C8", VA="0x130B5C8")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x130B668", Offset="0x130B668", VA="0x130B668")]
		internal void <Initialize>b__4(TransientScrimView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C4CC", Offset="0x104C4CC")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset="0x10")]
		public PassportSeasonActivitiesController <>4__this;

		[FieldOffset(Offset="0x18")]
		public PassportSeasonLevelUpController.TelemetryContext levelUpContext;

		[Address(RVA="0x130AD1C", Offset="0x130AD1C", VA="0x130AD1C")]
		public <>c__DisplayClass13_0()
		{
		}

		[Address(RVA="0x130B6D0", Offset="0x130B6D0", VA="0x130B6D0")]
		internal void <TryAnimateXp>b__0()
		{
		}
	}
}