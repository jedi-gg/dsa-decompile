using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class UnitListController : APopupController, IDispatchHandler<DUnitListViewAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x38")]
	private PersistedPlayerBattleUnits _unitsBattleInfo;

	[FieldOffset(Offset="0x40")]
	private UnitListController.Context _context;

	[Address(RVA="0x1508620", Offset="0x1508620", VA="0x1508620")]
	public UnitListController()
	{
	}

	[Address(RVA="0x1508618", Offset="0x1508618", VA="0x1508618", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x1507FDC", Offset="0x1507FDC", VA="0x1507FDC", Slot="14")]
	public void HandleDispatchAction(DUnitListViewAction action)
	{
	}

	[Address(RVA="0x1507E78", Offset="0x1507E78", VA="0x1507E78", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D15C", Offset="0x104D15C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitListController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x1507FD4", Offset="0x1507FD4", VA="0x1507FD4")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1508628", Offset="0x1508628", VA="0x1508628")]
		internal void <Initialize>b__0(UnitListView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public IReadOnlyList<Serverproto.Unit> Units;

		[FieldOffset(Offset="0x18")]
		public IReadOnlyList<Serverproto.Unit> SelectedUnits;

		[FieldOffset(Offset="0x20")]
		public IReadOnlyList<Serverproto.Unit> IneligibleUnits;

		[FieldOffset(Offset="0x28")]
		public IReadOnlyList<Serverproto.Unit> UnitsWithActiveBonus;

		[FieldOffset(Offset="0x30")]
		public PersistedPlayerBattleUnits UnitsBattleInfo;

		[FieldOffset(Offset="0x38")]
		public Serverproto.Unit UnitBeingReplaced;

		[FieldOffset(Offset="0x40")]
		public BattleRestriction? BattleRestriction;

		[Address(RVA="0x15089D8", Offset="0x15089D8", VA="0x15089D8")]
		public Context()
		{
		}
	}
}