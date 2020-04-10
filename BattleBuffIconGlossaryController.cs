using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class BattleBuffIconGlossaryController : APopupController
{
	[FieldOffset(Offset="0x38")]
	private BattleBuffIconGlossaryView _view;

	[Address(RVA="0x1136CA4", Offset="0x1136CA4", VA="0x1136CA4")]
	public BattleBuffIconGlossaryController()
	{
	}

	[Address(RVA="0x11368C4", Offset="0x11368C4", VA="0x11368C4", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x1136C8C", Offset="0x1136C8C", VA="0x1136C8C")]
	public bool IsShowing()
	{
		return new bool();
	}

	[Address(RVA="0x11369D8", Offset="0x11369D8", VA="0x11369D8")]
	public void SetActiveBuffTypes(HashSet<uint> iconTypes)
	{
	}

	[Address(RVA="0x1136BF4", Offset="0x1136BF4", VA="0x1136BF4")]
	public void Show(bool show)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B32C", Offset="0x104B32C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleBuffIconGlossaryController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x11369D0", Offset="0x11369D0", VA="0x11369D0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1136CAC", Offset="0x1136CAC", VA="0x1136CAC")]
		internal void <Initialize>b__0(BattleBuffIconGlossaryView view)
		{
		}
	}
}