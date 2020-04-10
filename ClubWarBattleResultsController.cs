using Glunies;
using Il2CppDummyDll;
using System;

public class ClubWarBattleResultsController : AFeatureController, IDispatchHandler<DClubWarBattleResultsViewAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x68")]
	private ClubWarBattleResultsGameState.TransitionContext _context;

	[FieldOffset(Offset="0x70")]
	private AClubWarBattleResultsView _view;

	[Address(RVA="0x1269D28", Offset="0x1269D28", VA="0x1269D28")]
	public ClubWarBattleResultsController()
	{
	}

	[Address(RVA="0x1269C0C", Offset="0x1269C0C", VA="0x1269C0C", Slot="13")]
	public void HandleDispatchAction(DClubWarBattleResultsViewAction action)
	{
	}

	[Address(RVA="0x1269968", Offset="0x1269968", VA="0x1269968", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x1269B58", Offset="0x1269B58", VA="0x1269B58", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x1269BC8", Offset="0x1269BC8", VA="0x1269BC8", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BA3C", Offset="0x104BA3C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarBattleResultsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x1269B50", Offset="0x1269B50", VA="0x1269B50")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1269D30", Offset="0x1269D30", VA="0x1269D30")]
		internal void <Initialize>b__0(Action executed)
		{
		}

		[Address(RVA="0x1269E24", Offset="0x1269E24", VA="0x1269E24")]
		internal void <Initialize>b__1(Action executed)
		{
		}

		[Address(RVA="0x1269F18", Offset="0x1269F18", VA="0x1269F18")]
		internal void <Initialize>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BA4C", Offset="0x104BA4C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action executed;

		[FieldOffset(Offset="0x18")]
		public ClubWarBattleResultsController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x1269E1C", Offset="0x1269E1C", VA="0x1269E1C")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x1269FA8", Offset="0x1269FA8", VA="0x1269FA8")]
		internal void <Initialize>b__3(ClubWarBattleResultsVictoryView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BA5C", Offset="0x104BA5C")]
	private sealed class <>c__DisplayClass0_2
	{
		[FieldOffset(Offset="0x10")]
		public Action executed;

		[FieldOffset(Offset="0x18")]
		public ClubWarBattleResultsController.<>c__DisplayClass0_0 CS$<>8__locals2;

		[Address(RVA="0x1269F10", Offset="0x1269F10", VA="0x1269F10")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x126A010", Offset="0x126A010", VA="0x126A010")]
		internal void <Initialize>b__4(ClubWarBattleResultsDefeatView view)
		{
		}
	}
}