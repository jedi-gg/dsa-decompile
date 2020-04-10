using Glunies;
using Il2CppDummyDll;
using System;

public class PvpBattleResultsController : AFeatureController, IDispatchHandler<DPvpBattleResultsRankViewAction>, IDispatchHandler, IDispatchHandler<DPvpBattleResultViewAction>, IDispatchHandler<DPopupControllerAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105BBC0", Offset="0x105BBC0")]
	[FieldOffset(Offset="0x68")]
	private DailyPvpRewardHelper _dailyPvpRewardHelper;

	[Attribute(Name="InjectAttribute", RVA="0x105BBD0", Offset="0x105BBD0")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105BBE0", Offset="0x105BBE0")]
	[FieldOffset(Offset="0x78")]
	private LocalizationManager _locManager;

	[Attribute(Name="InjectAttribute", RVA="0x105BBF0", Offset="0x105BBF0")]
	[FieldOffset(Offset="0x80")]
	private PlayerDomainController _playerDc;

	[FieldOffset(Offset="0x88")]
	private PvpBattleResultsGameState.TransitionContext _context;

	[FieldOffset(Offset="0x90")]
	private PvpBattleResultsRankView _rankView;

	[FieldOffset(Offset="0x98")]
	private APvpBattleResultsView _resultView;

	[Address(RVA="0x1283D24", Offset="0x1283D24", VA="0x1283D24")]
	public PvpBattleResultsController()
	{
	}

	[Address(RVA="0x1283344", Offset="0x1283344", VA="0x1283344", Slot="13")]
	public void HandleDispatchAction(DPvpBattleResultsRankViewAction action)
	{
	}

	[Address(RVA="0x12833A0", Offset="0x12833A0", VA="0x12833A0", Slot="14")]
	public void HandleDispatchAction(DPvpBattleResultViewAction action)
	{
	}

	[Address(RVA="0x12834E4", Offset="0x12834E4", VA="0x12834E4", Slot="15")]
	public void HandleDispatchAction(DPopupControllerAction action)
	{
	}

	[Address(RVA="0x1282E14", Offset="0x1282E14", VA="0x1282E14", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x1283584", Offset="0x1283584", VA="0x1283584")]
	private void ShowResults()
	{
	}

	[Address(RVA="0x12832B0", Offset="0x12832B0", VA="0x12832B0", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x12832F0", Offset="0x12832F0", VA="0x12832F0", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C7EC", Offset="0x104C7EC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public PvpBattleResultsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public string endReasonText;

		[FieldOffset(Offset="0x20")]
		public bool playerPassportLeveledUp;

		[FieldOffset(Offset="0x28")]
		public GameStateTransitionContext context;

		[Address(RVA="0x12832A8", Offset="0x12832A8", VA="0x12832A8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1283D2C", Offset="0x1283D2C", VA="0x1283D2C")]
		internal void <Initialize>b__0(Action executed)
		{
		}

		[Address(RVA="0x1283E2C", Offset="0x1283E2C", VA="0x1283E2C")]
		internal void <Initialize>b__1(Action finished)
		{
		}

		[Address(RVA="0x1283F20", Offset="0x1283F20", VA="0x1283F20")]
		internal void <Initialize>b__2(Action finished)
		{
		}

		[Address(RVA="0x1284014", Offset="0x1284014", VA="0x1284014")]
		internal void <Initialize>b__3(Action finished)
		{
		}

		[Address(RVA="0x1284108", Offset="0x1284108", VA="0x1284108")]
		internal void <Initialize>b__4(Action finished)
		{
		}

		[Address(RVA="0x12841FC", Offset="0x12841FC", VA="0x12841FC")]
		internal void <Initialize>b__5()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C7FC", Offset="0x104C7FC")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action finished;

		[FieldOffset(Offset="0x18")]
		public PvpBattleResultsController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x1283F18", Offset="0x1283F18", VA="0x1283F18")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x128425C", Offset="0x128425C", VA="0x128425C")]
		internal void <Initialize>b__6(PvpBattleResultsBackdropView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C80C", Offset="0x104C80C")]
	private sealed class <>c__DisplayClass0_2
	{
		[FieldOffset(Offset="0x10")]
		public Action finished;

		[FieldOffset(Offset="0x18")]
		public PvpBattleResultsController.<>c__DisplayClass0_0 CS$<>8__locals2;

		[Address(RVA="0x128400C", Offset="0x128400C", VA="0x128400C")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x12842FC", Offset="0x12842FC", VA="0x12842FC")]
		internal void <Initialize>b__7(PvpBattleResultsRankView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C81C", Offset="0x104C81C")]
	private sealed class <>c__DisplayClass0_3
	{
		[FieldOffset(Offset="0x10")]
		public Action finished;

		[FieldOffset(Offset="0x18")]
		public PvpBattleResultsController.<>c__DisplayClass0_0 CS$<>8__locals3;

		[Address(RVA="0x1284100", Offset="0x1284100", VA="0x1284100")]
		public <>c__DisplayClass0_3()
		{
		}

		[Address(RVA="0x1284364", Offset="0x1284364", VA="0x1284364")]
		internal void <Initialize>b__8(PvpBattleResultsVictoryView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C82C", Offset="0x104C82C")]
	private sealed class <>c__DisplayClass0_4
	{
		[FieldOffset(Offset="0x10")]
		public Action finished;

		[FieldOffset(Offset="0x18")]
		public PvpBattleResultsController.<>c__DisplayClass0_0 CS$<>8__locals4;

		[Address(RVA="0x12841F4", Offset="0x12841F4", VA="0x12841F4")]
		public <>c__DisplayClass0_4()
		{
		}

		[Address(RVA="0x1284578", Offset="0x1284578", VA="0x1284578")]
		internal void <Initialize>b__9(PvpBattleResultsDefeatView view)
		{
		}
	}
}