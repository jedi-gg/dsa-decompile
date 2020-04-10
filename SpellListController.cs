using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class SpellListController : APopupController, IDispatchHandler<DSpellListViewAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x38")]
	private SpellListController.Context _context;

	[Address(RVA="0x124247C", Offset="0x124247C", VA="0x124247C")]
	public SpellListController()
	{
	}

	[Address(RVA="0x1242474", Offset="0x1242474", VA="0x1242474", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x1242198", Offset="0x1242198", VA="0x1242198", Slot="14")]
	public void HandleDispatchAction(DSpellListViewAction action)
	{
	}

	[Address(RVA="0x1242040", Offset="0x1242040", VA="0x1242040", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CA9C", Offset="0x104CA9C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public SpellListController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x1242190", Offset="0x1242190", VA="0x1242190")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1242484", Offset="0x1242484", VA="0x1242484")]
		internal void <Initialize>b__0(SpellListView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public IReadOnlyList<Spell> Spells;

		[FieldOffset(Offset="0x18")]
		public IReadOnlyList<Spell> SelectedSpells;

		[FieldOffset(Offset="0x20")]
		public IReadOnlyList<Spell> IneligibleSpells;

		[FieldOffset(Offset="0x28")]
		public IReadOnlyList<Spell> SpellsWithActiveBonus;

		[Address(RVA="0x1242734", Offset="0x1242734", VA="0x1242734")]
		public Context()
		{
		}
	}
}