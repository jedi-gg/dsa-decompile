using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class AchievementsController : AFeatureController, IDispatchHandler<DPlayerActivityUpdatedAction>, IDispatchHandler, IDispatchHandler<DPlayerActivityClaimAction>, IDispatchHandler<DInventoryDeltaProcessedAction>, IDispatchHandler<DPlayerXpContainerAction>, IDispatchHandler<DPlayerActivityChooseRewardViewShown>
{
	[Attribute(Name="InjectAttribute", RVA="0x1052450", Offset="0x1052450")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1052460", Offset="0x1052460")]
	[FieldOffset(Offset="0x70")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x1052470", Offset="0x1052470")]
	[FieldOffset(Offset="0x78")]
	private CardUnlockTrackerController _cardUnlockTrackerController;

	[Attribute(Name="InjectAttribute", RVA="0x1052480", Offset="0x1052480")]
	[FieldOffset(Offset="0x80")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x88")]
	private AchievementsView _view;

	[FieldOffset(Offset="0x90")]
	private bool _checkForUnlocksOnInventoryDelta;

	[Address(RVA="0x1156424", Offset="0x1156424", VA="0x1156424")]
	public AchievementsController()
	{
	}

	[Address(RVA="0x1156434", Offset="0x1156434", VA="0x1156434")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DF68", Offset="0x106DF68")]
	private void <HandleDispatchAction>b__1_0(ClaimActivityResponse response)
	{
	}

	[Address(RVA="0x1156490", Offset="0x1156490", VA="0x1156490")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DF78", Offset="0x106DF78")]
	private void <HandleDispatchAction>b__1_2()
	{
	}

	[Address(RVA="0x1156164", Offset="0x1156164", VA="0x1156164", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x1155D0C", Offset="0x1155D0C", VA="0x1155D0C", Slot="14")]
	public void HandleDispatchAction(DPlayerActivityClaimAction action)
	{
	}

	[Address(RVA="0x1156030", Offset="0x1156030", VA="0x1156030", Slot="13")]
	public void HandleDispatchAction(DPlayerActivityUpdatedAction action)
	{
	}

	[Address(RVA="0x1156098", Offset="0x1156098", VA="0x1156098", Slot="15")]
	public void HandleDispatchAction(DInventoryDeltaProcessedAction action)
	{
	}

	[Address(RVA="0x1156108", Offset="0x1156108", VA="0x1156108", Slot="16")]
	public void HandleDispatchAction(DPlayerXpContainerAction action)
	{
	}

	[Address(RVA="0x115615C", Offset="0x115615C", VA="0x115615C", Slot="17")]
	public void HandleDispatchAction(DPlayerActivityChooseRewardViewShown action)
	{
	}

	[Address(RVA="0x1155C08", Offset="0x1155C08", VA="0x1155C08", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x11560A8", Offset="0x11560A8", VA="0x11560A8")]
	private void TryShowCardUnlocks()
	{
	}

	[Address(RVA="0x1156048", Offset="0x1156048", VA="0x1156048")]
	private void UpdateViewData()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AE0C", Offset="0x104AE0C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static AchievementsController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<long> <>9__1_1;

		[Address(RVA="0x11564F4", Offset="0x11564F4", VA="0x11564F4")]
		static <>c()
		{
		}

		[Address(RVA="0x1156558", Offset="0x1156558", VA="0x1156558")]
		public <>c()
		{
		}

		[Address(RVA="0x1156560", Offset="0x1156560", VA="0x1156560")]
		internal void <HandleDispatchAction>b__1_1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104ADFC", Offset="0x104ADFC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public AchievementsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x1155D04", Offset="0x1155D04", VA="0x1155D04")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1156564", Offset="0x1156564", VA="0x1156564")]
		internal void <Initialize>b__0(AchievementsView view)
		{
		}
	}
}