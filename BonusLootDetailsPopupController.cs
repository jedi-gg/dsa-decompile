using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class BonusLootDetailsPopupController : APopupController
{
	[FieldOffset(Offset="0x38")]
	private BonusLootDetailsPopupController.Context _context;

	[FieldOffset(Offset="0x40")]
	private BonusLootDetailsPopupView _view;

	[FieldOffset(Offset="0x48")]
	private IList<BonusLootData> _bonusLootData;

	[Address(RVA="0x111F5DC", Offset="0x111F5DC", VA="0x111F5DC")]
	public BonusLootDetailsPopupController()
	{
	}

	[Address(RVA="0x111F334", Offset="0x111F334", VA="0x111F334", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x111F4F8", Offset="0x111F4F8", VA="0x111F4F8")]
	private void LoadView(Action finished)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B41C", Offset="0x104B41C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public BonusLootDetailsPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x111F4F0", Offset="0x111F4F0", VA="0x111F4F0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x111F5E4", Offset="0x111F5E4", VA="0x111F5E4")]
		internal void <Initialize>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B42C", Offset="0x104B42C")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset="0x10")]
		public BonusLootDetailsPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x111F5D4", Offset="0x111F5D4", VA="0x111F5D4")]
		public <>c__DisplayClass1_0()
		{
		}

		[Address(RVA="0x111FC3C", Offset="0x111FC3C", VA="0x111FC3C")]
		internal void <LoadView>b__0(BonusLootDetailsPopupView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly IList<BonusLootData> BonusLootDetailsData;

		[Address(RVA="0x111FC94", Offset="0x111FC94", VA="0x111FC94")]
		public Context(IList<BonusLootData> bonusLootDetailsData)
		{
		}
	}
}