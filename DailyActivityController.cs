using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class DailyActivityController : AFeatureController, IDispatchHandler<DPlayerActivityClaimAction>, IDispatchHandler, IDispatchHandler<DPlayerActivityUpdatedAction>, IDispatchHandler<DDailyEnergyGiftClaimAction>, IDispatchHandler<DInventoryDeltaProcessedAction>, IDispatchHandler<DPlayerXpContainerAction>, IDispatchHandler<DRevSdkPlacementShownAction>, IDispatchHandler<DUnitListItemAction>, IDispatchHandler<DSpellListItemAction>, IDispatchHandler<DPopupControllerAction>
{
	[FieldOffset(Offset="0x0")]
	private const ulong DAY_END_REFRESH_DELAY_S = 5L;

	[Attribute(Name="InjectAttribute", RVA="0x10576A8", Offset="0x10576A8")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x10576B8", Offset="0x10576B8")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x10576C8", Offset="0x10576C8")]
	[FieldOffset(Offset="0x78")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x10576D8", Offset="0x10576D8")]
	[FieldOffset(Offset="0x80")]
	private CardUnlockTrackerController _cardUnlockTrackerController;

	[Attribute(Name="InjectAttribute", RVA="0x10576E8", Offset="0x10576E8")]
	[FieldOffset(Offset="0x88")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x10576F8", Offset="0x10576F8")]
	[FieldOffset(Offset="0x90")]
	private RevSdkController _revSdk;

	[Attribute(Name="InjectAttribute", RVA="0x1057708", Offset="0x1057708")]
	[FieldOffset(Offset="0x98")]
	private DailyActivityEnergyUtil _energyUtil;

	[FieldOffset(Offset="0xA0")]
	private DailyActivityView _activityView;

	[FieldOffset(Offset="0xA8")]
	private List<DailyEnergyGiftListItemData> _energyData;

	[FieldOffset(Offset="0xB0")]
	private ulong _watchAdActivityId;

	[Address(RVA="0x12AB2D4", Offset="0x12AB2D4", VA="0x12AB2D4")]
	public DailyActivityController()
	{
	}

	[Address(RVA="0x12AB2DC", Offset="0x12AB2DC", VA="0x12AB2DC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F374", Offset="0x106F374")]
	private void <HandleDispatchAction>b__4_0(ClaimDailyEnergyGiftResponse response)
	{
	}

	[Address(RVA="0x12AB6CC", Offset="0x12AB6CC", VA="0x12AB6CC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F384", Offset="0x106F384")]
	private void <HandleDispatchAction>b__4_1(long failureCode)
	{
	}

	[Address(RVA="0x12AB730", Offset="0x12AB730", VA="0x12AB730")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F394", Offset="0x106F394")]
	private void <HandleDispatchAction>b__7_0(ClaimActivityResponse response)
	{
	}

	[Address(RVA="0x12AB8A8", Offset="0x12AB8A8", VA="0x12AB8A8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F3A4", Offset="0x106F3A4")]
	private void <HandleDispatchAction>b__7_1(long failureCode)
	{
	}

	[Address(RVA="0x12AB94C", Offset="0x12AB94C", VA="0x12AB94C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F3B4", Offset="0x106F3B4")]
	private void <HandleDispatchAction>b__7_2()
	{
	}

	[Address(RVA="0x12AAC7C", Offset="0x12AAC7C", VA="0x12AAC7C", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x12A9E00", Offset="0x12A9E00", VA="0x12A9E00", Slot="13")]
	public void HandleDispatchAction(DPlayerActivityClaimAction action)
	{
	}

	[Address(RVA="0x12AA1EC", Offset="0x12AA1EC", VA="0x12AA1EC", Slot="14")]
	public void HandleDispatchAction(DPlayerActivityUpdatedAction action)
	{
	}

	[Address(RVA="0x12AA27C", Offset="0x12AA27C", VA="0x12AA27C", Slot="15")]
	public void HandleDispatchAction(DDailyEnergyGiftClaimAction action)
	{
	}

	[Address(RVA="0x12AA528", Offset="0x12AA528", VA="0x12AA528", Slot="16")]
	public void HandleDispatchAction(DInventoryDeltaProcessedAction action)
	{
	}

	[Address(RVA="0x12AA588", Offset="0x12AA588", VA="0x12AA588", Slot="17")]
	public void HandleDispatchAction(DPlayerXpContainerAction action)
	{
	}

	[Address(RVA="0x12AA5DC", Offset="0x12AA5DC", VA="0x12AA5DC", Slot="18")]
	public void HandleDispatchAction(DRevSdkPlacementShownAction action)
	{
	}

	[Address(RVA="0x12AA7B4", Offset="0x12AA7B4", VA="0x12AA7B4", Slot="19")]
	public void HandleDispatchAction(DUnitListItemAction action)
	{
	}

	[Address(RVA="0x12AA9A0", Offset="0x12AA9A0", VA="0x12AA9A0", Slot="20")]
	public void HandleDispatchAction(DSpellListItemAction action)
	{
	}

	[Address(RVA="0x12AAB28", Offset="0x12AAB28", VA="0x12AAB28", Slot="21")]
	public void HandleDispatchAction(DPopupControllerAction action)
	{
	}

	[Address(RVA="0x12A8D9C", Offset="0x12A8D9C", VA="0x12A8D9C", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x12AB15C", Offset="0x12AB15C", VA="0x12AB15C")]
	private void ShowLevelUpsIfNecessary()
	{
	}

	[Address(RVA="0x12A9C4C", Offset="0x12A9C4C", VA="0x12A9C4C", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x12AA218", Offset="0x12AA218", VA="0x12AA218")]
	private void UpdateViewData()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BCAC", Offset="0x104BCAC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static DailyActivityController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<long> <>9__2_1;

		[Address(RVA="0x12AB9B0", Offset="0x12AB9B0", VA="0x12AB9B0")]
		static <>c()
		{
		}

		[Address(RVA="0x12ABA14", Offset="0x12ABA14", VA="0x12ABA14")]
		public <>c()
		{
		}

		[Address(RVA="0x12ABA1C", Offset="0x12ABA1C", VA="0x12ABA1C")]
		internal void <HandleDispatchAction>b__2_1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BC8C", Offset="0x104BC8C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public DailyActivityController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x12A8EB4", Offset="0x12A8EB4", VA="0x12A8EB4")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x12ABA20", Offset="0x12ABA20", VA="0x12ABA20")]
		internal void <Initialize>b__0(DailyActivityView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BC9C", Offset="0x104BC9C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public PlayerActivity activity;

		[FieldOffset(Offset="0x18")]
		public DailyActivityController <>4__this;

		[Address(RVA="0x12AA1E4", Offset="0x12AA1E4", VA="0x12AA1E4")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x12ABC14", Offset="0x12ABC14", VA="0x12ABC14")]
		internal void <HandleDispatchAction>b__0(ClaimActivityResponse response)
		{
		}

		[Address(RVA="0x12AC2B0", Offset="0x12AC2B0", VA="0x12AC2B0")]
		internal void <HandleDispatchAction>b__2()
		{
		}
	}
}