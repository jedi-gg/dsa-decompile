using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class BattleNodeOverrideDetailsPopupController : APopupController
{
	[FieldOffset(Offset="0x38")]
	private BattleNodeOverrideDetailsPopupController.Context _context;

	[Address(RVA="0x111553C", Offset="0x111553C", VA="0x111553C")]
	public BattleNodeOverrideDetailsPopupController()
	{
	}

	[Address(RVA="0x11153E4", Offset="0x11153E4", VA="0x11153E4", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B3BC", Offset="0x104B3BC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleNodeOverrideDetailsPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x1115534", Offset="0x1115534", VA="0x1115534")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1115544", Offset="0x1115544", VA="0x1115544")]
		internal void <Initialize>b__0(BattleNodeOverrideDetailsPopupView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly string TitleKey;

		[FieldOffset(Offset="0x18")]
		public readonly string DescriptionKey;

		[FieldOffset(Offset="0x20")]
		public readonly string Image;

		[Address(RVA="0x1115828", Offset="0x1115828", VA="0x1115828")]
		public Context(BattleNodeOverrideDescriptor descriptor)
		{
		}
	}
}