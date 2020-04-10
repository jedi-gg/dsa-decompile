using Glunies;
using Il2CppDummyDll;
using System;

public class KothBattleResultsController : AFeatureController, IDispatchHandler<DKothBattleResultsViewAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x68")]
	private AKothBattleResultsView _resultsView;

	[Attribute(Name="InjectAttribute", RVA="0x105A338", Offset="0x105A338")]
	[FieldOffset(Offset="0x70")]
	private LocalizationManager _locManager;

	[Address(RVA="0x11CAF4C", Offset="0x11CAF4C", VA="0x11CAF4C")]
	public KothBattleResultsController()
	{
	}

	[Address(RVA="0x11CAE84", Offset="0x11CAE84", VA="0x11CAE84", Slot="13")]
	public void HandleDispatchAction(DKothBattleResultsViewAction action)
	{
	}

	[Address(RVA="0x11CAC7C", Offset="0x11CAC7C", VA="0x11CAC7C", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x11CAF08", Offset="0x11CAF08", VA="0x11CAF08", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C2EC", Offset="0x104C2EC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public KothBattleResultsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public KothBattleResultsGameState.TransitionContext resultsContext;

		[FieldOffset(Offset="0x20")]
		public GameStateTransitionContext context;

		[Address(RVA="0x11CAE7C", Offset="0x11CAE7C", VA="0x11CAE7C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11CAF54", Offset="0x11CAF54", VA="0x11CAF54")]
		internal void <Initialize>b__0(Action finished)
		{
		}

		[Address(RVA="0x11CB048", Offset="0x11CB048", VA="0x11CB048")]
		internal void <Initialize>b__1(Action finished)
		{
		}

		[Address(RVA="0x11CB13C", Offset="0x11CB13C", VA="0x11CB13C")]
		internal void <Initialize>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C2FC", Offset="0x104C2FC")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action finished;

		[FieldOffset(Offset="0x18")]
		public KothBattleResultsController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x11CB040", Offset="0x11CB040", VA="0x11CB040")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x11CB468", Offset="0x11CB468", VA="0x11CB468")]
		internal void <Initialize>b__3(KothBattleResultsVictoryView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C30C", Offset="0x104C30C")]
	private sealed class <>c__DisplayClass0_2
	{
		[FieldOffset(Offset="0x10")]
		public Action finished;

		[FieldOffset(Offset="0x18")]
		public KothBattleResultsController.<>c__DisplayClass0_0 CS$<>8__locals2;

		[Address(RVA="0x11CB134", Offset="0x11CB134", VA="0x11CB134")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x11CB4D0", Offset="0x11CB4D0", VA="0x11CB4D0")]
		internal void <Initialize>b__4(KothBattleResultsDefeatView view)
		{
		}
	}
}