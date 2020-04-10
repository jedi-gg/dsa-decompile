using Glunies;
using Il2CppDummyDll;
using System;

public class ItemFindController : AFeatureController
{
	[Attribute(Name="InjectAttribute", RVA="0x10599FC", Offset="0x10599FC")]
	[FieldOffset(Offset="0x68")]
	private ItemFindControllerModule _itemFindModule;

	[FieldOffset(Offset="0x70")]
	private ItemFindGameState.Context _context;

	[FieldOffset(Offset="0x78")]
	private ItemFindView _view;

	[Address(RVA="0x137FD58", Offset="0x137FD58", VA="0x137FD58")]
	public ItemFindController()
	{
	}

	[Address(RVA="0x137FD60", Offset="0x137FD60", VA="0x137FD60")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10700A4", Offset="0x10700A4")]
	private void <FinishInitialization>b__6_0()
	{
	}

	[Address(RVA="0x137F774", Offset="0x137F774", VA="0x137F774", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x137F860", Offset="0x137F860", VA="0x137F860")]
	private void FinishInitialization()
	{
	}

	[Address(RVA="0x137F6F4", Offset="0x137F6F4", VA="0x137F6F4", Slot="9")]
	protected override void HandleBackButton(AView view)
	{
	}

	[Address(RVA="0x137F470", Offset="0x137F470", VA="0x137F470", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x137F77C", Offset="0x137F77C", VA="0x137F77C")]
	private void LoadView(Action finished)
	{
	}

	[Address(RVA="0x137F63C", Offset="0x137F63C", VA="0x137F63C", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x137F6B8", Offset="0x137F6B8", VA="0x137F6B8", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C25C", Offset="0x104C25C")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset="0x10")]
		public ItemFindController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x137F858", Offset="0x137F858", VA="0x137F858")]
		public <>c__DisplayClass5_0()
		{
		}

		[Address(RVA="0x137FD70", Offset="0x137FD70", VA="0x137FD70")]
		internal void <LoadView>b__0(ItemFindView view)
		{
		}
	}
}